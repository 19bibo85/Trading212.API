﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Requests.Orders
{
    public class StopOrderRequest
    {
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Quantity { get; set; }

        [JsonProperty("stopPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StopPrice { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }

        [JsonProperty("timeValidity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderTimeValidity? TimeValidity { get; set; }
    }
}
