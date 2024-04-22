using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class Order
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderItem>? Items { get; set; }

        [JsonProperty("nextPagePath", NullValueHandling = NullValueHandling.Ignore)]
        public string? NextPagePath { get; set; }
    }
}
