using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Requests.Pies
{
    public class PieRequest
    {
        [JsonProperty("dividendCashAction", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DividendCashAction? DividendCashAction { get; set; }

        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        [JsonProperty("goal", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Goal { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public Icon? Icon { get; set; }

        [JsonProperty("instrumentShares", NullValueHandling = NullValueHandling.Ignore)]
        public InstrumentSharesRequest? InstrumentShares { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }
    }
}
