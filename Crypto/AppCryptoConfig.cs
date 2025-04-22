using System.Security.Cryptography;

namespace Crypto;

public static class AppCryptoConfig
{
    public static string HashKey => Builtin.GetKey(0);
    public static string HashSalt => Builtin.GetKey(1);

    public static string CryptoKey
    {
        get
        {
            var key = Builtin.GetKey(2);
            return Hash.HashString(key, 16);
        }
    }
    public static HashAlgorithm GetHashAlgorithm(byte[] secretKey)
    {
        return new HMACSHA256(secretKey);
    }
}