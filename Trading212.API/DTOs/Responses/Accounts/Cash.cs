using Newtonsoft.Json;

namespace Trading212.API.DTOs.Responses.Accounts
{
    public class Cash
    {
        [JsonProperty("blocked", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Blocked { get; set; }

        [JsonProperty("free", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Free { get; set; }

        [JsonProperty("invested", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Invested { get; set; }

        [JsonProperty("pieCash", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PieCash { get; set; }

        [JsonProperty("ppl", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Ppl { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Result { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }
    }
}
