using System.Diagnostics;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;

namespace PcrotoGen
{
    internal static class Program
    {
        private static readonly string[] additionalTypes = new string[]
        {
        };

        private static Protocol ResolveProtocol(List<ApiCall> apis, ModuleDefinition def)
        {
            var added = new HashSet<string>();

            var enums = new List<EnumType>();
            var common = new List<ClassType>();
            var request = new List<ClassType>();
            var response = new List<ClassType>();
            void Resolve(TypeReference reference)
            {
                if (added.Contains(reference.FullName)) return;
                added.Add(reference.FullName);

                Console.WriteLine(reference.FullName);

                var def = reference.Resolve();
                if (def.IsEnum) enums.Add(new EnumType(def));
                else
                {
                    var type = new ClassType();
                    foreach (var @ref in ClassType.FromType(def, type))
                        Resolve(@ref);
                    common.Add(type);
                }
            }

            foreach (var api in apis)
            {
                ClassType req = new(), resp = new();
                foreach (var @ref in ClassType.FromType(def.GetType(api.request), req).Concat(
                             ClassType.FromType(def.GetType(api.response), resp)))
                    Resolve(@ref);
                if (req.name == "ReDrive.Api.AppReqBase")
                    req.name = resp.name.Replace("Response", "Request");
                api.request = req.name;
                api.response = resp.name;
                request.Add(req);
                response.Add(resp);
            }

            foreach (var type in additionalTypes)
            {
                Resolve(def.GetType(type));
            }

            return new Protocol(apis: apis.ToArray(), common: common.ToArray(), enums: enums.ToArray(),
                response: response.ToArray(), request: request.ToArray());
        }

        private static List<ApiCall> ReadApiCallIl2Cpp(ModuleDefinition definition)
        {
            var result = new List<ApiCall>();
            var added = new HashSet<string>();

            foreach (var type in definition.GetTypes())
            {
                var urlField = type.Fields.FirstOrDefault(f => f.IsPublic && f.IsStatic && f.Name == "Url");
                
                if (urlField == null) continue;

                var requestType = type.NestedTypes.SingleOrDefault(t => t.Name == "Request")
                    ?? definition.GetType("ReDrive.Api.AppReqBase");
                var respType = type.NestedTypes.Single(t => t.Name == "Response");
                if (respType == null) continue;

                result.Add(new()
                {
                    url = (string) urlField.Constant,
                    request = requestType.FullName,
                    response = respType.FullName
                });
            }

            return result;
        }

        static void Main(string[] args)
        {
            var il2cpp = AssemblyDefinition.ReadAssembly("Assembly-CSharp.dll")!.MainModule!;

            var apis = ReadApiCallIl2Cpp(il2cpp); /*.Where(a => !apihash.Contains(a.response)).ToList();*/

            var protocol = ResolveProtocol(apis, il2cpp);

            SaveCSharpProtocol(protocol);
        }
        private static void SaveCSharpProtocol(Protocol protocol)
        {
            var reqDict = protocol.apis.ToDictionary(a => a.request, a => a.response);

            var additions = new Dictionary<string, string>();
            foreach (var key in protocol.apis)
                additions[key.request] = $"    public sealed override string Url => \"{key.url}\";";

            void WriteFile(ClassType[] types, string file, string header, Func<string, string> name, Func<string, string> baseClass)
            {
                string FieldToString(FieldType field)
                {
                    string CSharpType(string type)
                    {
                        return type switch
                        {
                            "long" => "long",
                            "string" => "string",
                            "double" => "double",
                            "int" => "int",
                            "bool" => "bool",
                            _ => type.Replace("Network.Definition.", "").Replace(".", "")
                        };
                    }

                    return field.parameters.Length == 0
                        ? CSharpType(field.baseType)
                        : $"{CSharpType(field.baseType)}<{string.Join(", ", field.parameters.Select(FieldToString))}>";
                }

                File.Delete("../../../../MagiaClient/Models/" + file);
                using var sw = new StreamWriter(File.OpenWrite("../../../../MagiaClient/Models/" + file));

                sw.WriteLine($"namespace MagiaClient.Models;");
                sw.WriteLine();
                sw.WriteLine(header);
                sw.WriteLine();

                foreach (var type in types)
                {
                    sw.WriteLine($"public class {name(type.name)} : {baseClass(type.name)}");
                    sw.WriteLine("{");

                    if (additions.TryGetValue(type.name, out var val))
                        sw.WriteLine(val);

                    foreach (var field in type.fields)
                    {
                        sw.WriteLine($"    public {FieldToString(field.Value)} {field.Key} {{ get; set; }}");
                    }

                    if (type.fields.Count == 0)
                    {
                        sw.WriteLine("    // No fields");
                    }

                    sw.WriteLine("}");
                    sw.WriteLine();
                }
            }

            WriteFile(protocol.common, "Common.cs",
                "using System;\nusing System.Collections.Generic;",
                x => x.Replace("Network.Definition.", "").Replace(".", ""), _ => "object");

            WriteFile(protocol.request, "Requests.cs",
                "using System;\nusing System.Collections.Generic;\n",
                x => x.Split('.').Last().Replace("/", ""), x => 
                    $"RequestBase<{reqDict[x].Split('.').Last().Replace("/", "")}>");

            WriteFile(protocol.response, "Responses.cs",
                "using System;\nusing System.Collections.Generic;\n",
                x => x.Split('.').Last().Replace("/", ""), _ => "ResponseBase");

            File.Delete("../../../../MagiaClient/Models/Enums.cs");
            using (var sw = new StreamWriter(File.OpenWrite("../../../../MagiaClient/Models/Enums.cs")))
            {
                sw.WriteLine("namespace MagiaClient.Models;");
                sw.WriteLine();
                sw.WriteLine("using System;");
                sw.WriteLine();

                foreach (var type in protocol.enums)
                {
                    sw.WriteLine($"public enum {type.name.Replace("Network.Definition.", "").Replace(".", "")}");
                    sw.WriteLine("{");
                    foreach (var constant in type.values)
                    {
                        sw.WriteLine($"    {constant.Key} = {constant.Value},");
                    }
                    sw.WriteLine("}");
                    sw.WriteLine();
                }
            }
        }
    }
}
