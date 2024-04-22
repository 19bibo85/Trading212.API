using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Responses.Pies
{
    public class Pie
    {
        [JsonProperty("instruments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Instrument>? Instruments { get; set; }

        [JsonProperty("settings", NullValueHandling = NullValueHandling.Ignore)]
        public Settings? Settings { get; set; }
    }
}
