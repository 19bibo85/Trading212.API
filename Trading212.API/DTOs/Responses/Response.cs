using System.Net;

namespace Trading212.API.DTOs.Responses
{
    public class Response<T> where T : class
    {
        public T? Data { get; internal set;}
        public HttpStatusCode Status { get; internal set; } = HttpStatusCode.OK;
        public string Message { get; internal set; } = "OK";
    }
}
