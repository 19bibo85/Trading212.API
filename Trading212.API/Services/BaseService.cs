using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trading212.API.DTOs.Requests;
using Trading212.API.DTOs.Responses;

namespace Trading212.API.Services
{
    public abstract class BaseService
    {
        #region Private Members 

        private readonly Trading212Config _config;

        private readonly HttpClient _httpClient;

        private readonly Dictionary<HttpStatusCode, string> ErrorMessages = new Dictionary<HttpStatusCode, string>()
        {
            { HttpStatusCode.BadRequest, "Bad Request" },

            { HttpStatusCode.Unauthorized, "Bad API key" },

            { HttpStatusCode.Forbidden, "Scope missing for API key" },

            { HttpStatusCode.NotFound, "Item not found" },

            { HttpStatusCode.RequestTimeout, "Timed-out" },

            { HttpStatusCode.TooManyRequests, "Too many requests. Please refer to the documentation for information on the maximum number of requests allowed per second." },

        };

        #endregion

        #region Constructor

        protected BaseService(Trading212Config config)
        {
            _config = config;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", config.APIKey);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.BaseAddress = config.BaseAddress;
        }

        #endregion

        #region Execute

        internal async Task<Response<TOuput>> Execute<TOuput>(HttpMethod method, string endpoint, TimeSpan retryAfter, CancellationToken cancellationToken) where TOuput : class
        {
            return await this.Execute<TOuput>(method, endpoint, null, null, null, retryAfter, cancellationToken);
        }

        internal async Task<Response<TOuput>> Execute<TOuput>(HttpMethod method, string endpoint, long id, TimeSpan retryAfter, CancellationToken cancellationToken) where TOuput : class
        {
            return await this.Execute<TOuput>(method, endpoint, id, null, null, retryAfter, cancellationToken);
        }

        internal async Task<Response<TOuput>> Execute<TOuput>(HttpMethod method, string endpoint, Request data, TimeSpan retryAfter, CancellationToken cancellationToken) where TOuput : class
        {
            return await this.Execute<TOuput>(method, endpoint, null, data.Query, data.Body, retryAfter, cancellationToken);
        }

        internal async Task<Response<TOuput>> Execute<TOuput>(HttpMethod method, string endpoint, long id, Request data, TimeSpan retryAfter, CancellationToken cancellationToken) where TOuput : class
        {
            return await this.Execute<TOuput>(method, endpoint, id, data.Query, data.Body, retryAfter, cancellationToken);
        }

        private async Task<Response<TOuput>> Execute<TOuput>(HttpMethod method, string endpoint, long? id, string? query, string? body, TimeSpan retryAfter, CancellationToken cancellationToken) where TOuput : class
        {
            var result = new Response<TOuput>();

            long count = 0;
            do
            {
                var request = new HttpRequestMessage
                {
                    Method = method
                };

                var uriBuilder = new UriBuilder($"{_config.BaseAddress}{endpoint}");

                if (id.HasValue)
                    uriBuilder.Path += $"/{id}";

                if (!string.IsNullOrWhiteSpace(query))
                    uriBuilder.Query = query;

                if (!string.IsNullOrWhiteSpace(body))
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                request.RequestUri = uriBuilder.Uri;

                var response = await _httpClient.SendAsync(request, cancellationToken);

                result.Status = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    result.Message = "OK";

                    result.Data = JsonConvert.DeserializeObject<TOuput>(responseContent);
                }
                else
                {
                    result.Message = "An error occurred while processing your request.";

                    if (ErrorMessages.TryGetValue(response.StatusCode, out string errorMessage))
                        result.Message = errorMessage;
                }

                count++;
            }
            while (Continue(result.Status, retryAfter, count));

            return result;
        }
        private bool Continue(HttpStatusCode status, TimeSpan retryAfter, long count)
        {
            if (status == HttpStatusCode.TooManyRequests && count <= _config.Retry)
            {
                Thread.Sleep((int)retryAfter.TotalMilliseconds);
                return true;
            }
            return false;
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose managed resources
                _httpClient.Dispose();
            }
        }

        #endregion
    }
}
