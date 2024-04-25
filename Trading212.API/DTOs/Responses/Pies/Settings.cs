using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Responses.Pies
{
    public class Settings
    {
        [JsonProperty("creationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationDate { get; set; }

        [JsonProperty("dividendCashAction", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PieDividendCashAction? DividendCashAction { get; set; }

        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        [JsonProperty("goal", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Goal { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public PieIcon? Icon { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("initialInvestment", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? InitialInvestment { get; set; }

        [JsonProperty("instrumentShares", NullValueHandling = NullValueHandling.Ignore)]
        public InstrumentShares? InstrumentShares { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        [JsonProperty("pubicUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string? PubicUrl { get; set; }
    }
}
