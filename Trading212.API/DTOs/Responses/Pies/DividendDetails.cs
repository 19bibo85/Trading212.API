using Newtonsoft.Json;

namespace Trading212.API.DTOs.Responses.Pies
{
    public class DividendDetails
    {
        [JsonProperty("gained", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Gained { get; set; }

        [JsonProperty("inCash", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? InCash { get; set; }

        [JsonProperty("reinvested", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Reinvested { get; set; }
    }
}
