using System.Security.Cryptography;
using System.Text;

namespace Crypto;

public static class BasicCrypto
{
    public static byte[] Decrypt(byte[] cryptoKey, byte[] data)
    {
        using var aes = new RijndaelManaged();
        var dataHead = data[..cryptoKey.Length];
        aes.BlockSize = 8 * cryptoKey.Length;
        aes.KeySize = 8 * cryptoKey.Length;
        aes.IV = dataHead;
        aes.Key = cryptoKey;
        aes.Mode = CipherMode.CBC; // 1
        aes.Padding = PaddingMode.PKCS7; // 2

        var raw = aes.CreateDecryptor().TransformFinalBlock(data, dataHead.Length, data.Length - dataHead.Length);

        return raw;
    }
    public static byte[] Encrypt(byte[] cryptoKey, byte[] data, byte[] iv)
    {
        using var aes = new RijndaelManaged();
        aes.BlockSize = 8 * cryptoKey.Length;
        aes.KeySize = 8 * cryptoKey.Length;
        aes.IV = iv;
        aes.Key = cryptoKey;
        aes.Mode = CipherMode.CBC; // 1
        aes.Padding = PaddingMode.PKCS7; // 2

        var raw = aes.CreateEncryptor()
            .TransformFinalBlock(data, 0, data.Length);

        return iv.Concat(raw).ToArray();
    }


    public static byte[] Decrypt(string cryptoKey, byte[] data)
    {
        return Decrypt(Encoding.UTF8.GetBytes(cryptoKey), data);
    }
    public static byte[] Encrypt(string cryptoKey, byte[] data, byte[] iv)
    {
        return Encrypt(Encoding.UTF8.GetBytes(cryptoKey), data, iv);
    }
}