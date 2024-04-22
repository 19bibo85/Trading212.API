using Newtonsoft.Json;
using System.Collections.Generic;
using Trading212.API.DTOs.Shared;

namespace Trading212.API.DTOs.Responses.Pies
{
    [JsonConverter(typeof(DynamicPropertiesConverter))]
    public class InstrumentShares : Dictionary<string, decimal?>
    {

    }
}
