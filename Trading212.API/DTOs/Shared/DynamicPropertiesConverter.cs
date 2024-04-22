using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Trading212.API.DTOs.Shared
{
    public class DynamicPropertiesConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Dictionary<string, decimal?>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var dynamicProperties = new Dictionary<string, decimal?>();

            JObject jsonObject = JObject.Load(reader);
            foreach (var property in jsonObject.Properties())
            {
                dynamicProperties.Add(property.Name, decimal.TryParse(property.Value?.ToString(), out decimal value) ? (decimal?)value : null);
            }

            return dynamicProperties;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
                return;

            var dynamicProperties = (Dictionary<string, decimal?>)value;

            var jsonObject = new JObject();
            foreach (var kvp in dynamicProperties)
            {
                jsonObject.Add(kvp.Key, kvp.Value);
            }

            jsonObject.WriteTo(writer);
        }
    }
}
