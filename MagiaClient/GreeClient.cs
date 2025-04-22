using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Crypto;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MagiaClient
{
    internal static class RSAExtensions
    {
        public static string ExportSubjectPublicKeyInfoPem(this RSA rsa)
        {
            if (rsa == null) throw new ArgumentNullException(nameof(rsa));

            byte[] publicKeyBytes = rsa.ExportSubjectPublicKeyInfo();
            return ConvertToPem(publicKeyBytes, "PUBLIC KEY");
        }

        private static string ConvertToPem(byte[] keyBytes, string keyType)
        {
            string base64Key = Convert.ToBase64String(keyBytes, Base64FormattingOptions.InsertLineBreaks);
            return $"-----BEGIN {keyType}-----\n{base64Key}\n-----END {keyType}-----";
        }
    }
    public class GreeClient
    {
        private const string APP_ID = "863165203288142";

        private const string APP_SECRET =
            "858931807c393c548db2a5f725bb6b45";

        private readonly HttpClient client;
        private bool inited;
        public byte[] PrivateKey { get; private set; }
        public string Uuid { get; private set; }
        public string PublicKey { get; private set; }

        public static string GenerateDeviceId()
        {
            Random random = new Random();
            byte[] buffer = new byte[8]; // 8 bytes = 16 hex characters
            random.NextBytes(buffer);
            return BitConverter.ToString(buffer).Replace("-", "").ToLower();
        }
        public string deviceId = B(GenerateDeviceId());

        public GreeClient(HttpClient client)
        {
            this.client = client;
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-GREE-GAMELIB",
                $"authVersion%3D1.5.28%26billing%3D3%26storeType%3Dgoogle%26appVersion%3D{Constants.APP_VERSION}%26uaType%3Dandroid-app%26carrier%3DChina+Mobile+GSM%26compromised%3Dfalse%26countryCode%3DCN%26currencyCode%3DCNY%26model%3DAndroid-Phone");

            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Linux; Android 9; ASUS_I003DD Build/PI; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/68.0.3440.70 Mobile Safari/537.36");
        }

        public GreeClient(HttpClient client, byte[] privateKey, string uuid) : this(client)
        {
            PrivateKey = privateKey;
            Uuid = uuid;

            var rsa = RSA.Create(512);
            rsa.ImportPkcs8PrivateKey(privateKey, out _);

            PublicKey = rsa.ExportSubjectPublicKeyInfoPem();
        }

        private static class Util
        {
            // 假设已有其它 a 方法的重载：a(string) 与 a(Uri)
            public static string a(string var0)
            {
                if (var0 == null)
                {
                    return var0;
                }
                else
                {
                    StringBuilder var1 = new StringBuilder();
                    char[] var2 = var0.ToCharArray();
                    int var3 = var2.Length;

                    for (int var4 = 0; var4 < var3; ++var4)
                    {
                        char var5 = var2[var4];
                        if ((var5 < 'A' || var5 > 'Z') && (var5 < 'a' || var5 > 'z') && (var5 < '0' || var5 > '9') &&
                            var5 != '-' && var5 != '.' && var5 != '_' && var5 != '~')
                        {
                            byte[] var9 = Encoding.Latin1.GetBytes(var5.ToString());
                            int var6 = var9.Length;

                            for (int var7 = 0; var7 < var6; ++var7)
                            {
                                byte var8 = var9[var7];
                                var1.Append("%" + var8.ToString("X2"));
                            }
                        }
                        else
                        {
                            var1.Append(var5);
                        }
                    }

                    return var1.ToString();

                }
            }

            public static string a(Uri uri)
            {
                // 此方法将构造 scheme://authority/path 格式的字符串
                string scheme = uri.Scheme;
                string authority = uri.Authority;

                // 如果是默认端口，则去掉端口部分
                bool defaultPort = (scheme == "http" && uri.Port == 80) || (scheme == "https" && uri.Port == 443);
                if (defaultPort)
                {
                    int colonIndex = authority.LastIndexOf(":");
                    if (colonIndex >= 0)
                    {
                        authority = authority.Substring(0, colonIndex);
                    }
                }

                // 获取路径，如果没有则设为 "/"
                string path = uri.GetComponents(UriComponents.Path, UriFormat.Unescaped);

                return $"{scheme}://{authority}/{path}";
            }

            public static string a(string method, string url, SortedDictionary<string, string> parameters)
            {
                string baseUrl;
                try
                {
                    Uri uri = new Uri(url);
                    baseUrl = a(uri);
                }
                catch (UriFormatException ex)
                {
                    Console.WriteLine(ex);
                    baseUrl = "";
                }

                // 分析 URL 中的查询字符串部分
                int questionMarkIndex = url.IndexOf('?');
                if (questionMarkIndex >= 0)
                {
                    string query = url.Substring(questionMarkIndex + 1);
                    if (!string.IsNullOrEmpty(query))
                    {
                        string[] pairs = query.Split('&');
                        foreach (string pair in pairs)
                        {
                            int equalIndex = pair.IndexOf('=');
                            string key, value;
                            if (equalIndex < 0)
                            {
                                key = pair;
                                value = null;
                            }
                            else
                            {
                                key = pair.Substring(0, equalIndex);
                                value = pair.Substring(equalIndex + 1);
                            }
                            parameters[key] = value;
                        }
                    }
                }

                // 对参数进行拼接，忽略键为 "oauth_signature" 的参数
                StringBuilder sb = new StringBuilder();
                foreach (string key in parameters.Keys)
                {
                    if (!"oauth_signature".Equals(key))
                    {
                        sb.Append(a(key))
                          .Append("=")
                          .Append(a(parameters[key]))
                          .Append("&");
                    }
                }

                // 移除最后一个 '&'
                string paramString = sb.ToString();
                if (paramString.EndsWith("&"))
                {
                    paramString = paramString.Substring(0, paramString.Length - 1);
                }

                // 返回方法、baseUrl 和参数字符串经过 a(string) 编码后的拼接结果
                return a(method) + "&" + a(baseUrl) + "&" + a(paramString);
            }
        }

        public async Task Login()
        {
            try
            {
                await Post("/auth/authorize");
            }
            catch (InvalidOperationException ex)
            {
                if (ex.Message.Contains("Inactive Device"))
                {
                    await Post("/linked/active/update");
                    await Post("/auth/authorize");
                }
            }
        }

        public async Task Register()
        {
            string template =
                $"{{ \"appVersion\":\"{Constants.APP_VERSION}\",\"urlParam\":null,\"deviceModel\":\"Asus ASUS_I003DD\",\"osType\":2,\"osVersion\":\"Android OS 9 / API-28 (PI/rel.cjw.20220518.114133)\",\"storeType\":2,\"graphicsDeviceId\":0,\"graphicsDeviceVendorId\":0,\"processorCount\":4,\"processorType\":\"x86-64 SSE3 SSE4.1 SSE4.2 AVX\",\"supportedRenderTargetCount\":8,\"supports3DTextures\":true,\"supportsAccelerometer\":true,\"supportsComputeShaders\":true,\"supportsGyroscope\":true,\"supportsImageEffects\":true,\"supportsInstancing\":true,\"supportsLocationService\":true,\"supportsRenderTextures\":true,\"supportsRenderToCubemap\":true,\"supportsShadows\":true,\"supportsSparseTextures\":false,\"supportsStencil\":1,\"supportsVibration\":false,\"uuid\":null,\"xuid\":0,\"sm\":\"{Constants.SM}\"}}";

            using var rsa = RSA.Create(512);
            PublicKey = rsa.ExportSubjectPublicKeyInfoPem();

            var result = await Post("/auth/initialize", new JObject
            {
                ["device_id"] = deviceId,
                ["token"] = PublicKey,
                ["payload"] = template
            });

            PrivateKey = rsa.ExportPkcs8PrivateKey();
            Uuid = (string)result["uuid"];
        }

        public async Task<JObject> Post(string route, JObject body = null)
        {
            var oauth = new SortedDictionary<string, string>();
            var raw = body? .ToString() ?? string.Empty;
            var ts = DateTime.Now.ToTimeStamp().ToString();
            using (var sha1 = SHA1.Create())
                oauth["oauth_body_hash"] = Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(raw)));
            oauth["oauth_consumer_key"] = APP_ID;
            oauth["oauth_nonce"] = new Random().NextInt64().ToString();
            oauth["oauth_timestamp"] = ts;
            oauth["oauth_version"] = "1.0";

            var url = "https://gl-pkl-jp-payment.gree-apps.net/v1.0" + route; // /auth/initialize

            if (PrivateKey != null)
            {
                oauth["oauth_signature_method"] = "RSA-SHA1";

                var var6 = APP_SECRET + ts;
                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportPkcs8PrivateKey(PrivateKey, out _);
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(var6));

                        byte[] signature = rsa.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

                        oauth["xoauth_as_hash"] = Convert.ToBase64String(signature).Trim();
                    }
                }

                oauth["xoauth_requestor_id"] = Uuid;

                var var17 = Util.a("POST", url, oauth);

                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportPkcs8PrivateKey(PrivateKey, out _);
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(var17));

                        byte[] signature = rsa.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

                        oauth["oauth_signature"] = Convert.ToBase64String(signature).Trim();
                    }
                }
            }
            else
            {
                oauth["oauth_signature_method"] = "HMAC-SHA1";

                var var17 = Util.a("POST", url, oauth);
                using (HMACSHA1 hmac = new HMACSHA1(Encoding.UTF8.GetBytes(APP_SECRET)))
                {
                    byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(var17));
                    oauth["oauth_signature"] = Convert.ToBase64String(hashBytes).Trim();
                }

            }

            var var19 = new StringBuilder();
            var19.Append("OAuth ");

            foreach (var kvp in oauth)
            {
                var19.Append(kvp.Key)
                    .Append("=\"")
                    .Append(HttpUtility.UrlEncode(kvp.Value)) // e0.a 相当于 URL 编码
                    .Append("\",");
            }

            // 移除最后一个逗号
            if (var19.Length > 0)
            {
                var19.Length--;
            }

            string authorizationHeader = var19.ToString();

            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authorizationHeader);

            var resp = await client.PostAsync(url, new StringContent(raw, Encoding.UTF8, "application/json"));

            var result = JObject.Parse(await resp.Content.ReadAsStringAsync());

            if (Debugger.IsAttached)
                Console.WriteLine(result.ToString(Formatting.Indented));

            if ((string)result["result"] != "OK")
                throw new InvalidOperationException(result.ToString());

            return result;
        }


        public async Task<JObject> Get(string route)
        {
            var oauth = new SortedDictionary<string, string>();
            var raw = string.Empty;
            var ts = DateTime.Now.ToTimeStamp().ToString();
            using (var sha1 = SHA1.Create())
                oauth["oauth_body_hash"] = Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(raw)));
            oauth["oauth_consumer_key"] = APP_ID;
            oauth["oauth_nonce"] = new Random().NextInt64().ToString();
            oauth["oauth_timestamp"] = ts;
            oauth["oauth_version"] = "1.0";

            var url = "https://gl-pkl-jp-payment.gree-apps.net/v1.0" + route; // /auth/initialize

            if (PrivateKey != null)
            {
                oauth["oauth_signature_method"] = "RSA-SHA1";

                var var6 = APP_SECRET + ts;
                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportPkcs8PrivateKey(PrivateKey, out _);
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(var6));

                        byte[] signature = rsa.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

                        oauth["xoauth_as_hash"] = Convert.ToBase64String(signature).Trim();
                    }
                }

                oauth["xoauth_requestor_id"] = Uuid;

                var var17 = Util.a("GET", url, oauth);

                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportPkcs8PrivateKey(PrivateKey, out _);
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(var17));

                        byte[] signature = rsa.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

                        oauth["oauth_signature"] = Convert.ToBase64String(signature).Trim();
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("private key can't be null");
            }

            var var19 = new StringBuilder();
            var19.Append("OAuth ");

            foreach (var kvp in oauth)
            {
                var19.Append(kvp.Key)
                    .Append("=\"")
                    .Append(HttpUtility.UrlEncode(kvp.Value)) // e0.a 相当于 URL 编码
                    .Append("\",");
            }

            // 移除最后一个逗号
            if (var19.Length > 0)
            {
                var19.Length--;
            }

            string authorizationHeader = var19.ToString();

            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authorizationHeader);

            var resp = await client.GetAsync(url);

            var result = JObject.Parse(await resp.Content.ReadAsStringAsync());

            if ((string)result["result"] != "OK")
                throw new InvalidOperationException(result.ToString());

            return result;
        }


        private static string A(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                char transformedChar = c;
                if ((c >= 'a' && c <= 'm') || (c >= 'A' && c <= 'M'))
                {
                    transformedChar = (char)(c + 13);
                }
                else if ((c >= 'n' && c <= 'z') || (c >= 'N' && c <= 'Z'))
                {
                    transformedChar = (char)(c - 13);
                }
                result.Append(transformedChar);
            }

            return result.ToString();
        }

        private static string B(string input)
        {
            string base64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
            char[] reversed = base64Encoded.ToCharArray();
            Array.Reverse(reversed);
            return A(new string(reversed));
        }

        private static string DecodeB(string encodedInput)
        {
            string rot13Decoded = A(encodedInput);
            char[] reversed = rot13Decoded.ToCharArray();
            Array.Reverse(reversed);
            string base64Reversed = new string(reversed);
            byte[] decodedBytes = Convert.FromBase64String(base64Reversed);
            return Encoding.UTF8.GetString(decodedBytes);
        }

        public async Task RegisterPassword(string password)
        {
            await Post("/migration/password/register", new JObject
            {
                ["migration_password"] = B(password),
                ["device_id"] = deviceId,
            });
            // Console.WriteLine("password registered = " + password);
        }
        public async Task<string> GetMigrationCode()
        {
            var result = await Get("/migration/code");
            return (string) result["migration_code"];
        }

        public async Task MigrateFrom(string migrationCode, string password)
        {
            var migrated = await Post("/migration/code/verify", new JObject
            {
                ["migration_code"] = migrationCode,
                ["migration_password"] = B(password),
            });

            await Post("/migration", new JObject
            {
                ["migration_token"] = migrated["migration_token"],
                ["src_uuid"] = migrated["src_uuid"],
                ["device_id"] = deviceId,
                ["token"] = PublicKey,
                ["dst_uuid"] = Uuid,
            });

            Uuid = (string) migrated["src_uuid"];
        }
    }
}
