using Newtonsoft.Json;

namespace Trading212.API.DTOs.Requests.Orders
{
    public class MarketOrderRequest
    {
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Quantity { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }
    }
}
