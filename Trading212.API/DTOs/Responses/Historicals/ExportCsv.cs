using Newtonsoft.Json;

namespace Trading212.API.DTOs.Responses.Historicals
{
    public class ExportCsv
    {
        [JsonProperty("reportId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReportId { get; set; }
    }
}
