using Newtonsoft.Json;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Trading212.API.DTOs.Requests
{
    internal class Request
    {
        private readonly string? _query;
        private readonly string? _body;

        private Request(string? query, string? body)
        {
            _query = query;
            _body = body;
        }

        internal static Request CreateRequest(string? query, string? body) => new Request(query, body);

        internal string? Query => _query;

        internal string? Body => _body;

    }

    internal static class RequestHelper 
    {
        internal static Request CreateQuery<TQuery>(TQuery query) where TQuery : class => Create(query, default(object));

        internal static Request CreateBody<TBody>(TBody body) where TBody : class => Create(default(object), body);

        internal static Request Create<TQuery, TBody>(TQuery? query, TBody? body) where TQuery : class where TBody : class
        {
            string? q = null;
            if (query != null) 
            {
                var properties = query
                    .GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance);

                var keyValuePairs = properties
                    .Where(prop => prop.CanRead)
                    .Select(prop => $"{HttpUtility.UrlEncode(prop.Name)}={HttpUtility.UrlEncode(prop.GetValue(query)?.ToString() ?? string.Empty)}");

                if (keyValuePairs.Any())
                    q = $"{string.Join("&", keyValuePairs)}";
            }

            string? b = null;
            if (body != null)
                b = JsonConvert.SerializeObject(body);

            return Request.CreateRequest(q,b);
        }
    }
}
