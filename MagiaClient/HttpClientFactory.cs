using System.Net;

namespace MagiaClient;

public static class HttpClientFactory
{
    public static HttpClient Create() => new HttpClient(new HttpClientHandler
    {
        //Proxy = new WebProxy("localhost", 8888)
    });
}