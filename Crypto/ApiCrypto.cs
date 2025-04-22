using System.Security.Cryptography;
using System.Text;

namespace Crypto;

public static class ApiCrypto
{
    private const string MsgPackAppCryptoKey = "UVFBdDtWKhpESJj3";
    public static byte[] Decrypt(byte[] encrypted)
    {
        var key = MsgPackAppCryptoKey;
        var hashkey = Hash.HashString(key, 16);
        return BasicCrypto.Decrypt(hashkey, encrypted);
    }

    public static byte[] Encrypt(byte[] raw, byte[] iv)
    {
        var key = MsgPackAppCryptoKey;
        var hashkey = Hash.HashString(key, 16);
        return BasicCrypto.Encrypt(hashkey, raw, iv);
    }

    public static long ToTimeStamp(this DateTime time)
    {
        // time = time.AddYears(10);
        var ts = time.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        return (long)ts.TotalSeconds;
    }

    public static string Sign(byte[] encrypted, byte[] privateKey)
    {
        var hashed = SHA1.Create().ComputeHash(encrypted);
        var data = Convert.ToBase64String(hashed);
        using (RSA rsa = RSA.Create())
        {
            // Import the private key in PKCS#8 format
            rsa.ImportPkcs8PrivateKey(privateKey, out _);

            // Use SHA-1 hash algorithm for signing
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(data));

                // Sign the hash with the RSA private key
                byte[] signature = rsa.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

                return Convert.ToBase64String(signature);
            }
        }
    }

}