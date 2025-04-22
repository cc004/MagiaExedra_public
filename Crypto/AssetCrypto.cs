using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public static class LocalStorageUtility
    {
        public static string ConvertToHash(string text, string salt)
        {
            using var md5 = MD5.Create();
            var hash = Convert.ToBase64String(md5.ComputeHash(
                Encoding.UTF8.GetBytes(text + salt))).TrimEnd((char) 0x3D);
            hash = hash.Replace((char)0x2B, (char)0x2D).Replace((char)0x2F, (char)0x5F);
            return hash;
        }

        public static string ConvertIdToHash(string id)
        {
            return ConvertToHash(id, string.Empty)[..4];
        }

        public static string ConvertToHashWithSplitSlash(string text, string salt)
        {
            return Path.Combine(text.Split((char)0x2F).Select(t => ConvertToHash(t, salt)).ToArray());
        }
    }

    public class AssetCrypto
    {
        private const string SALT = "1c7f";
        public const string JAPAN_TAG = "ja-Jpan";

        public static string GetAnyUrl(string baseUrl, string name, string revision)
        {
            var v5 = LocalStorageUtility.ConvertToHashWithSplitSlash(baseUrl, "");
            name = LocalStorageUtility.ConvertToHashWithSplitSlash(name, SALT);

            return v5 + "/" + name.Replace('\\', '/') + "?key=" +
                   LocalStorageUtility.ConvertIdToHash(JAPAN_TAG) + revision;
        }
    }
}
