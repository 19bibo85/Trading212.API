using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class Transaction
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransactionItem>? Items { get; set; }

        [JsonProperty("nextPagePath", NullValueHandling = NullValueHandling.Ignore)]
        public string? NextPagePath { get; set; }
    }
}