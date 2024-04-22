using Newtonsoft.Json;
using System;

namespace Trading212.API.DTOs.Responses.Orders
{
    public class Order
    {
        [JsonProperty("creationTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationTime { get; set; }

        [JsonProperty("filledQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FilledQuantity { get; set; }

        [JsonProperty("filledValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FilledValue { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("limitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LimitPrice { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Quantity { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; }

        [JsonProperty("stopPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StopPrice { get; set; }

        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string? Strategy { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Value { get; set; }
    }


}
