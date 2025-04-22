using System.Net;
using Crypto;
using MagiaClient.Models;

namespace MagiaClient;

public class AssetManager
{
    private readonly HttpClient client = HttpClientFactory.Create();

    private AssetManager()
    {
    }

    public ResourceMstRecord[] Records { get; private set; }
    private string token;

    public static async Task<AssetManager> CreateFromClient(GameClient client)
    {
        var mgr = new AssetManager();
        var fileList = await client.Request(new GetResourceFileMstListRequest());
        var assetList = await client.Request(new GetResourceAssetBundleMstListRequest("f04834a1e8aa26914c7e4729c17dd188"));
        var list1 = assetList.ToArray();
        var list2 = fileList.ToArray();

        foreach (var x in list1) x.root = "assetbundles/android";
        foreach (var x in list2) x.root = "files";

        mgr.Records = list1.Concat(list2).ToArray();
        mgr.token = (await client.Request(new AkamaiApiCreateTokenRequest())).token;

        return mgr;
    }

    public async Task<byte[]> Download(string name)
    {

        var assetUrl = "https://static-files-mmme.akamaized.net/web/resource/" +
                       name + "&" +
                       token;

        var res = await client.GetByteArrayAsync(assetUrl);

        return res;
    }
    public async Task<byte[]> Download(ResourceMstRecord record)
    {
        var name = record.name;

        var crypto = record.cryptoKey;
        var revision = record.revision;

        var converted = AssetCrypto.GetAnyUrl(record.root, name, revision);

        var assetUrl = "https://static-files-mmme.akamaized.net/web/resource/" +
                       converted + "&" +
                       token;

        var res = await client.GetByteArrayAsync(assetUrl);

        if (!record.isEncrypted)
            return res;

        var cryptoKey = FileStorageGenerateCryptoKey.GenerateBytesKey(name + crypto, "");

        var fileDec = FileStorageXORCipher.Cipher(res, cryptoKey);

        return fileDec;
    }
}