using Newtonsoft.Json;
using System.Collections.Generic;
using Trading212.API.DTOs.Shared;

namespace Trading212.API.DTOs.Requests.Pies
{
    [JsonConverter(typeof(DynamicPropertiesConverter))]
    public class InstrumentSharesRequest : Dictionary<string, decimal?>
    {

    }    
}
