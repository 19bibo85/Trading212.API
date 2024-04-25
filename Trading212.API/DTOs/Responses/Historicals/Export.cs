using Newtonsoft.Json;
using System;
using Trading212.API.DTOs.Enums;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class Export
    {
        [JsonProperty("dataIncluded", NullValueHandling = NullValueHandling.Ignore)]
        public DataIncluded? DataIncluded { get; set; }

        [JsonProperty("downloadLink", NullValueHandling = NullValueHandling.Ignore)]
        public string? DownloadLink { get; set; }

        [JsonProperty("reportId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReportId { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public ExportStatus? Status { get; set; }

        [JsonProperty("timeFrom", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TimeFrom { get; set; }

        [JsonProperty("timeTo", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TimeTo { get; set; }
    }    
}
