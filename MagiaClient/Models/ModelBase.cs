using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MagiaClient.Models
{
    public abstract class ResponseBase
    {
        public int status;
    }

    public abstract class RequestBase<TResponse> where TResponse : ResponseBase
    {
        [JsonIgnore]
        public abstract string Url { get; }

        public string sm = Constants.SM;
        public string lastHomeAccessTime;
    }

    public class ServerError
    {
        public string domain;
        public int code;
        public string field;
        public string reason;
    }

    public class Response<TResponse> where TResponse : ResponseBase
    {
        public TResponse payload;
        public string url;
        public int status;
        public ServerError[] errors;
    }

    public class Request<TResponse> where TResponse: ResponseBase
    {
        public RequestBase<TResponse> payload;
        public string uuid;
        public long userId;
        public string sessionId;
        public string actionToken;
        public string ctag;
        public long actionTime;
    }
}
