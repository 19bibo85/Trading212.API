using Newtonsoft.Json;
using System;

namespace Trading212.API.DTOs.Responses.Metadatas
{
    public class InstrumentList
    {
        [JsonProperty("addedOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AddedOn { get; set; }

        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrencyCode { get; set; }

        [JsonProperty("isin", NullValueHandling = NullValueHandling.Ignore)]
        public string? Isin { get; set; }

        [JsonProperty("maxOpenQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MaxOpenQuantity { get; set; }

        [JsonProperty("minTradeQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MinTradeQuantity { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        [JsonProperty("shortname", NullValueHandling = NullValueHandling.Ignore)]
        public string? Shortname { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("workingScheduleId", NullValueHandling = NullValueHandling.Ignore)]
        public long? WorkingScheduleId { get; set; }
    }
}
