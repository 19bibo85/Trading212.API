using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Responses.Metadatas
{
    public class WorkingSchedule
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("timeEvents", NullValueHandling = NullValueHandling.Ignore)]
        public List<TimeEvent>? TimeEvents { get; set; }
    }
}
