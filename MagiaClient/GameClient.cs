using MagiaClient.Models;
using System;
using Crypto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MagiaClient
{
    public class GameClient
    {
        private readonly byte[] privateKey;
        private readonly string uuid;
        private string sessionId;
        private long userId;
        private long lastHomeAccessTime;

        private readonly HttpClient client;
        private const string ROOT = "https://api.mmme.pokelabo.jp";
        private const string ROOT_CDN = "https://static-masterdata-mmme.akamaized.net";

        public GameClient(HttpClient client, byte[] privateKey, string uuid)
        {
            this.client = client;
            this.privateKey = privateKey;
            this.uuid = uuid;

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.TryAddWithoutValidation("x-game-server-url", "https://api.mmme.pokelabo.jp");
            client.DefaultRequestHeaders.TryAddWithoutValidation("content-type", "application/x-msgpack");
            client.DefaultRequestHeaders.TryAddWithoutValidation("x-timezone-offset", "28800");
            client.DefaultRequestHeaders.TryAddWithoutValidation("x-language", "ja-Jpan");
            client.DefaultRequestHeaders.TryAddWithoutValidation("x-unity-version", "2022.3.21f1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("x-region", "JP");
            client.DefaultRequestHeaders.TryAddWithoutValidation("user-agent", "UnityRequest   (Asus ASUS_I003DD Android OS 9 / API-28 (PI/rel.cjw.20220518.114133))");
            client.DefaultRequestHeaders.TryAddWithoutValidation("x-app-version", Constants.APP_VERSION);

        }

        public void SetVersion(string version)
        {
            client.DefaultRequestHeaders.Remove("x-app-version");
            client.DefaultRequestHeaders.TryAddWithoutValidation("x-app-version", version);
        }

        public async Task Login()
        {
            var resp = await Request(new LoginApiLoginRequest
            {
                appVersion = client.DefaultRequestHeaders.GetValues("x-app-version").Single(),
                urlParam = null,
                deviceModel = "Asus ASUS_I003DD",
                osType = 2,
                osVersion = "Android OS 9 / API-28 (PI/rel.cjw.20220518.114133)",
                storeType = 2,
                graphicsDeviceId = 0,
                graphicsDeviceVendorId = 0,
                processorCount = 4,
                processorType = "x86-64 SSE3 SSE4.1 SSE4.2 AVX",
                supportedRenderTargetCount = 8,
                supports3DTextures = true,
                supportsAccelerometer = true,
                supportsComputeShaders = true,
                supportsGyroscope = true,
                supportsImageEffects = true,
                supportsInstancing = true,
                supportsLocationService = true,
                supportsRenderTextures = true,
                supportsRenderToCubemap = true,
                supportsShadows = true,
                supportsSparseTextures = false,
                supportsStencil = 1,
                supportsVibration = false,
                uuid = null,
                xuid = 0
            });
            sessionId = resp.sessionId;
            userId = resp.userId;

            // Console.WriteLine($"client login with session = {sessionId}, uid = {userId}");
        }
        private static long ActionTime()
        {
            return DateTimeOffset.UtcNow.ToFileTime();
        }

        public void AccessHome()
        {
            lastHomeAccessTime = DateTime.Now.ToTimeStamp();
        }

        public virtual async Task<TResponse> Request<TResponse>(RequestBase<TResponse> request)
            where TResponse : ResponseBase
        {
            var req = new Request<TResponse>();
            req.actionTime = ActionTime();
            req.sessionId = sessionId;
            req.userId = userId;
            req.uuid = uuid;
            req.payload = request;
            req.payload.lastHomeAccessTime = lastHomeAccessTime.ToString();

            var encrypted = PackHelper.Pack(JObject.FromObject(req), PackHelper.GetIV());

            client.DefaultRequestHeaders.TryAddWithoutValidation("x-post-signature", ApiCrypto.Sign(encrypted, privateKey));

            var resp = await client.PostAsync(ROOT + request.Url,
                new ByteArrayContent(encrypted));

            client.DefaultRequestHeaders.Remove("x-post-signature");

            if (resp.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException($"HTTP Status {resp.StatusCode}: \n{await resp.Content.ReadAsStringAsync()}");

            var content = await resp.Content.ReadAsByteArrayAsync();
            var obj = PackHelper.Unpack(content);

            var orm = obj.ToObject<Response<TResponse>>();

            if (orm.errors != null)
                throw new ApiException(string.Join('\n', orm.errors.Select(e => e.reason)));

            if (request is HomeApiGetHomeInfoRequest)
                AccessHome();

            if (responseCallback.TryGetValue(typeof(TResponse), out var action))
                action.DynamicInvoke(orm.payload);

            return orm.payload;
        }

        public async Task<TResponse> Request<TResponse>(RequestBase<TResponse> request, string token)
            where TResponse : ResponseBase
        {
            var req = new Request<TResponse>();
            req.actionTime = ActionTime();
            req.sessionId = sessionId;
            req.userId = userId;
            req.uuid = uuid;
            req.payload = request;
            req.payload.lastHomeAccessTime = lastHomeAccessTime.ToString();

            var encrypted = PackHelper.Pack(JObject.FromObject(req), PackHelper.GetIV());

            client.DefaultRequestHeaders.TryAddWithoutValidation("x-post-signature", ApiCrypto.Sign(encrypted, privateKey));

            var url = request is MstRequestBase<TResponse> ? request.Url : request.Url + "?";

            var resp = await client.PostAsync(ROOT_CDN + url + token,
                new ByteArrayContent(encrypted));

            client.DefaultRequestHeaders.Remove("x-post-signature");

            if (resp.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException($"HTTP Status {resp.StatusCode}: \n{await resp.Content.ReadAsStringAsync()}");

            var content = await resp.Content.ReadAsByteArrayAsync();
            var obj = PackHelper.Unpack(content);

            var orm = obj.ToObject<Response<TResponse>>();

            if (orm.errors != null)
                throw new ApiException(string.Join('\n', orm.errors.Select(e => e.reason)));

            if (request is HomeApiGetHomeInfoRequest)
                AccessHome();

            if (responseCallback.TryGetValue(typeof(TResponse), out var action))
                action.DynamicInvoke(orm.payload);

            return orm.payload;
        }

        private readonly Dictionary<Type, Delegate> responseCallback = new Dictionary<Type, Delegate>();

        public void On<TResponse>(Action<TResponse> action) where TResponse : ResponseBase
        {
            responseCallback[typeof(TResponse)] = action;
        }

        public async Task LoginFull()
        {
            await Login();
            await Request(new UserApiGetInitDataListRequest());
            await Request(new PartyApiGetCharacterBuildDataListRequest());
            await Request(new CharacterApiGetCharacterListRequest());
            await Request(new CollectionApiGetCollectionParamUpAchieveDataListRequest());
            await Request(new CollectionApiGetCollectionDataListRequest());
            await Request(new StyleApiGetStyleDataListRequest());
            await Request(new UserApiGetUserParamDataRequest());
            await Request(new ConfigApiGetConfigRequest());
            await Request(new UserApiLoadOptionRequest());
            await Request(new WebPayApiCancelLatestRequest());
            await Request(new TermsApiGetUpdatedTermsRequest
            {
                storeType = 2
            });
        }
    }
}

