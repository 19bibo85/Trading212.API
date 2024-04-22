using Newtonsoft.Json;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class DataIncluded
    {
        [JsonProperty("includeDividends", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeDividends { get; set; }

        [JsonProperty("includeInterest", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeInterest { get; set; }

        [JsonProperty("includeOrders", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeOrders { get; set; }

        [JsonProperty("includeTransactions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeTransactions { get; set; }
    }
}
