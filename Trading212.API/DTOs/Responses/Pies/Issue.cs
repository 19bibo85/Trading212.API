using Newtonsoft.Json;

namespace Trading212.API.DTOs.Responses.Pies
{
    public class Issue
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string? Severity { get; set; }
    }
}
