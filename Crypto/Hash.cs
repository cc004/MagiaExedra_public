using System.Text;

namespace Crypto;

public static class Hash
{
    public static string GetSalt()
    {
        var salt = AppCryptoConfig.HashSalt;
        return string.Concat(salt.Substring(0, 1), salt.Substring(1, salt.Length - 1));
    }

    public static byte[] GetHashKey()
    {
        var key = AppCryptoConfig.HashKey;
        key = string.Concat(key.Substring(0, 1), key.Substring(1, key.Length - 1));
        return Encoding.UTF8.GetBytes(key);
    }

    public static byte[] HashBytes(string text, int maxLength)
    {
        var v8 = GetSalt() + text;
        var v14 = AppCryptoConfig.GetHashAlgorithm(GetHashKey());
        var v15 = v14.ComputeHash(Encoding.UTF8.GetBytes(v8));
        if (v15.Length < maxLength || maxLength == 0) return v15;
        var offset = (v15.Length - maxLength) / 2;
        return v15[offset..(offset + maxLength)];
    }

    public static string HashString(string text, int maxLength)
    {
        var base64 = Convert.ToBase64String(HashBytes(text, maxLength));
        return base64.Length > maxLength ? base64.Substring((base64.Length - maxLength) / 2, maxLength) : base64;
    }
}