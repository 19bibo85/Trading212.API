using Newtonsoft.Json;

namespace Trading212.API.DTOs.Responses.Accounts
{
    public class Metadata
    {
        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrencyCode { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }
    }


}
