using MagiaClient.Models;

namespace MagiaClient;

public class CsfGameClient : GameClient
{
    public CsfGameClient(HttpClient client, byte[] privateKey, string uuid) : base(client, privateKey, uuid)
    {
    }

    private string token;
    public bool noRedirect = false;

    public async Task RefreshToken()
    {
        noRedirect = true;
        await Login();
        token = (await base.Request(new AkamaiApiCreateTokenRequest())).token;
        noRedirect = false;
    }
    public override async Task<TResponse> Request<TResponse>(RequestBase<TResponse> request)
    {
        if (noRedirect || request is AkamaiApiCreateTokenRequest)
            return await base.Request(request);

        if (token == null)
        {
            await RefreshToken();
        }

        if (request.Url.StartsWith("/api/mst"))
            return await Request(request, token);

        throw new InvalidOperationException(request.ToString());
    }
}