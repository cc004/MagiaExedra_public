using System.Linq;

namespace PcrotoGen;

public class Protocol(ApiCall[] apis, ClassType[] common, EnumType[] enums, ClassType[] response, ClassType[] request)
{
    public ClassType[] request = request, response = response, common = common;
    public EnumType[] enums = enums;
    public ApiCall[] apis = apis;

    public static Protocol operator +(Protocol a, Protocol b)
    {
        return new Protocol(
            a.apis.Concat(b.apis).DistinctBy(a => a.request).ToArray(),
            MergeClass(a.common, b.common),
            MergeEnum(a.enums, b.enums),
            MergeClass(a.response, b.response),
            MergeClass(a.request, b.request));
    }

    private static EnumType[] MergeEnum(EnumType[] a, EnumType[] b)
    {
        var result = a.ToDictionary(c => c.name, c => c);

        foreach (var t in b)
        {
            if (!result.ContainsKey(t.name))
            {
                result[t.name] = t;
                continue;
            }

            var toMerge = result[t.name];
            foreach (var field in t.values)
            {
                toMerge.values[field.Key] = field.Value;
            }
        }

        return result.Values.ToArray();
    }

    private static ClassType[] MergeClass(ClassType[] a, ClassType[] b)
    {
        var result = a.ToDictionary(c => c.name, c => c);

        foreach (var t in b)
        {
            if (!result.ContainsKey(t.name))
            {
                result[t.name] = t;
                continue;
            }

            var toMerge = result[t.name];
            foreach (var field in t.fields)
            {

                toMerge.fields[field.Key] = field.Value;
            }
        }

        static IEnumerable<string> enumerateField(FieldType type)
        {
            return type.parameters.SelectMany(enumerateField).Prepend(type.baseType);
        }

        var resolved = new Dictionary<string, ClassType>();

        foreach (var type in result.Values)
        {
            if (resolved.ContainsKey(type.name)) continue;

            foreach (var dependency in type.fields.Values.SelectMany(enumerateField))
                if (result.TryGetValue(dependency, out var val))
                    resolved.TryAdd(dependency, val);

            resolved.Add(type.name, type);
        }
        return resolved.Values.ToArray();
    }
}