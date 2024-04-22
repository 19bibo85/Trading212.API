using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Requests.Orders
{
    public class LimitOrderRequest
    {
        [JsonProperty("limitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LimitPrice { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Quantity { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }

        [JsonProperty("timeValidity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeValidity? TimeValidity { get; set; }
    }
}
