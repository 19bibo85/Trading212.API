using Newtonsoft.Json;
using System;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class DividendItem
    {
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        [JsonProperty("amountInEuro", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AmountInEuro { get; set; }

        [JsonProperty("grossAmountPerShare", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? GrossAmountPerShare { get; set; }

        [JsonProperty("paidOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PaidOn { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Quantity { get; set; }

        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string? Reference { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public DividendType? Type { get; set; }
    }
}
