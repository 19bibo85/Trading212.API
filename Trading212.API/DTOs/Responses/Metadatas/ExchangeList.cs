using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Responses.Metadatas
{
    public class ExchangeList
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        [JsonProperty("workingSchedules", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkingSchedule>? WorkingSchedules { get; set; }
    }
}
