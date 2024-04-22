using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class OrderItem
    {
        [JsonProperty("dateCreated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("dateExecuted", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateExecuted { get; set; }

        [JsonProperty("dateModified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateModified { get; set; }

        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string? Executor { get; set; }

        [JsonProperty("fillCost", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FillCost { get; set; }

        [JsonProperty("fillId", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FillId { get; set; }

        [JsonProperty("fillPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FillPrice { get; set; }

        [JsonProperty("fillResult", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FillResult { get; set; }

        [JsonProperty("fillType", NullValueHandling = NullValueHandling.Ignore)]
        public string? FillType { get; set; }

        [JsonProperty("filledQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FilledQuantity { get; set; }

        [JsonProperty("filledValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FilledValue { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Id { get; set; }

        [JsonProperty("limitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LimitPrice { get; set; }

        [JsonProperty("orderedQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OrderedQuantity { get; set; }

        [JsonProperty("orderedValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OrderedValue { get; set; }

        [JsonProperty("parentOrder", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ParentOrder { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; }

        [JsonProperty("stopPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StopPrice { get; set; }

        [JsonProperty("taxes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taxis>? Taxes { get; set; }

        [JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticker { get; set; }

        [JsonProperty("timeValidity", NullValueHandling = NullValueHandling.Ignore)]
        public string? TimeValidity { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }
    }
}
