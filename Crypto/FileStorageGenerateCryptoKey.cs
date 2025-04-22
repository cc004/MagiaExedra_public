using System.Security.Cryptography;
using System.Text;

namespace Crypto;

public static class FileStorageGenerateCryptoKey
{
    public static byte[] GenerateBytesKey(string key, string salt)
    {
        var algorithm = SHA512.Create();
        var raw = Encoding.UTF8.GetBytes(key + salt);
        var a = algorithm.ComputeHash(raw);
        var b = algorithm.ComputeHash(a);
        return a.Concat(b).ToArray();
    }
}