using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class Dividend
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<DividendItem>? Items { get; set; }

        [JsonProperty("nextPagePath", NullValueHandling = NullValueHandling.Ignore)]
        public string? NextPagePath { get; set; }
    }
}
