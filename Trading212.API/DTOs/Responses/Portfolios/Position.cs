using Newtonsoft.Json;
using System;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Responses.Portfolios
{
    public class Position
    {
        [JsonProperty("averagePrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AveragePrice { get; set; }

        [JsonProperty("currentPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CurrentPrice { get; set; }

        [JsonProperty("frontend", NullValueHandling = NullValueHandling.Ignore)]
        public PortfolioFrontend? Frontend { get; set; }

        [JsonProperty("fxPpl", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FxPpl { get; set; }

        [JsonProperty("initialFillDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? InitialFillDate { get; set; }

        [JsonProperty("maxBuy", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MaxBuy { get; set; }

        [JsonProperty("maxSell", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MaxSell { get; set; }

        [JsonProperty("pieQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PieQuantity { get; set; }

        [JsonProperty("ppl", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Ppl { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Quantity { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }
    }
}
