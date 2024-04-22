using Newtonsoft.Json;

namespace Trading212.API.DTOs.Requests.Historicals
{
    public class OrderRequest
    {
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public long Cursor { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }
    }
}
