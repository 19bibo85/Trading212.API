using Newtonsoft.Json;

namespace Trading212.API.DTOs.Requests.Historicals
{
    public class TransactionRequest
    {
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public long Cursor { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }
    }
}
