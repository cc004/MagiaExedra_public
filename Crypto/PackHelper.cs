using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Crypto;
using MsgPack;
using Newtonsoft.Json.Linq;

namespace Crypto
{
    public static class PackHelper
    {
        public static JToken Unpack(byte[] crypted)
        {
            var decrypted = ApiCrypto.Decrypt(crypted);
            return JToken.FromObject(new BoxingPacker().Unpack(decrypted));
        }

        private static object Mapper(JToken o) =>
            o switch
            {
                JArray arr => arr.Select(Mapper).ToArray(),
                JObject obj => new Dictionary<string, object>(obj.Properties()
                    .Select(prop => new KeyValuePair<string, object>(prop.Name, Mapper(prop.Value)))),
                _ => o.ToObject<object>()
            };

        public static byte[] GetIV()
        {
            return "88 46 51 55 30 61 67 82 55 2c ab 5e 1d 7c 85 0f".Split(' ').Select(x => byte.Parse(x, NumberStyles.HexNumber))
                .ToArray();
        }
        public static byte[] Pack(JToken token, byte[] iv)
        {
            var buf = new BoxingPacker().Pack(Mapper(token));
            return ApiCrypto.Encrypt(buf, iv);
        }
    }
}