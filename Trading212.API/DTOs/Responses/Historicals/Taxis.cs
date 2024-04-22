using Newtonsoft.Json;
using System;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class Taxis
    {
        [JsonProperty("fillId", NullValueHandling = NullValueHandling.Ignore)]
        public string? FillId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Quantity { get; set; }

        [JsonProperty("timeCharged", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TimeCharged { get; set; }
    }

}
