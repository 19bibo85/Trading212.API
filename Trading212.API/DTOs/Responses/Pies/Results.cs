using Newtonsoft.Json;

namespace Trading212.API.DTOs.Responses.Pies
{
    public class Results
    {
        [JsonProperty("investedValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? InvestedValue { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Result { get; set; }

        [JsonProperty("resultCoef", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ResultCoef { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Value { get; set; }
    }
}
