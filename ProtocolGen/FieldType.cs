using System.Diagnostics;
using Mono.Cecil;

namespace PcrotoGen;

public class FieldType
{
    public string baseType;
    public FieldType[] parameters;

    private static readonly TypeDefinition stringType = AssemblyDefinition.ReadAssembly("mscorlib.dll").MainModule.GetType("System.String");

    public static IEnumerable<TypeReference> FromType(TypeReference type, FieldType result)
    {
        if (type is not GenericInstanceType type2)
        {
            if (type.IsArray)
            {
                FieldType elementType = new FieldType();
                foreach (var @ref in FromType(type.GetElementType(), elementType))
                    yield return @ref;

                result.baseType = "List";
                result.parameters = new[]
                {
                    elementType
                };
                yield break;
            }
            result.parameters = Array.Empty<FieldType>();

            if (type.Name == "DateTimeOffset") type = stringType;

            switch (type.FullName)
            {
                case "System.Boolean":
                case "CodeStage.AntiCheat.ObscuredTypes.ObscuredBool":
                    result.baseType = "bool";
                    yield break;
                case "System.Int32":
                case "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt":
                    result.baseType = "int";
                    yield break;
                case "System.Int64":
                case "CodeStage.AntiCheat.ObscuredTypes.ObscuredLong":
                case "System.DateTime":
                    result.baseType = "long";
                    yield break;
                case "System.Single":
                case "CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat":
                    result.baseType = "float";
                    yield break;
                case "System.Double":
                case "CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble":
                    result.baseType = "double";
                    yield break;
                case "System.String":
                case "CodeStage.AntiCheat.ObscuredTypes.ObscuredString":
                    result.baseType = "string";
                    yield break;
            }

            // Debug.Assert(type.FullName.StartsWith("Network."));
            result.baseType = type.FullName;
            yield return type;
            yield break;
        }

        result.baseType = type2.ElementType.FullName switch
        {
            "System.Collections.Generic.Dictionary`2" => "Dict",
            "System.Collections.Generic.List`1" => "List",
            _ => throw new NotImplementedException()
        };

        var @params = new List<FieldType>();
        foreach (var param in type2.GenericArguments)
        {
            var res = new FieldType();
            foreach (var child in FromType(param, res))
                yield return child;
            @params.Add(res);
        }

        result.parameters = @params.ToArray();
    }
}