using Newtonsoft.Json;
using System;
using Trading212.API.DTOs.Responses.Historicals;

namespace Trading212.API.DTOs.Requests.Historicals
{
    public class ExportRequest
    {
        [JsonProperty("dataIncluded", NullValueHandling = NullValueHandling.Ignore)]
        public DataIncluded? DataIncluded { get; set; }

        [JsonProperty("timeFrom", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TimeFrom { get; set; }

        [JsonProperty("timeTo", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TimeTo { get; set; }
    }
}
