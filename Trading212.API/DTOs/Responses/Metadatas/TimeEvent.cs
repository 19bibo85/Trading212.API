using Newtonsoft.Json;
using System;

namespace Trading212.API.DTOs.Responses.Metadatas
{
    public class TimeEvent
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }
    }
}
