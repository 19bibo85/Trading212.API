using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Responses.Pies
{
    public class Instrument
    {
        [JsonProperty("currentShare", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CurrentShare { get; set; }

        [JsonProperty("expectedShare", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ExpectedShare { get; set; }

        [JsonProperty("issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<Issue>? Issues { get; set; }

        [JsonProperty("ownedQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OwnedQuantity { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Results? Result { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }
    }
}
