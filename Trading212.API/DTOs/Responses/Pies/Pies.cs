using Newtonsoft.Json;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Responses.Pies
{
    public class Pies
    {
        [JsonProperty("cash", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Cash { get; set; }

        [JsonProperty("dividendDetails", NullValueHandling = NullValueHandling.Ignore)]
        public DividendDetails? DividendDetails { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Progress { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Results? Result { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public PieStatus? Status { get; set; }
    }    
}
