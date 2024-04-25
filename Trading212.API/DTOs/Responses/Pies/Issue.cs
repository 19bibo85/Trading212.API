using Newtonsoft.Json;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Responses.Pies
{
    public class Issue
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public PieErrorName? Name { get; set; }

        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public PieErrorSeverity? Severity { get; set; }
    }
}
