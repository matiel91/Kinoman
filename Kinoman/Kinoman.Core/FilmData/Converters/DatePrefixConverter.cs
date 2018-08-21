using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class DatePrefixConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DatePrefix) || t == typeof(DatePrefix?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return DatePrefix.Empty;
                case "Dzisiaj":
                    return DatePrefix.Dzisiaj;
                case "Jutro":
                    return DatePrefix.Jutro;
                default: return DatePrefix.Empty;
            }
            throw new Exception("Cannot unmarshal type DatePrefix");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DatePrefix)untypedValue;
            switch (value)
            {
                case DatePrefix.Empty:
                    serializer.Serialize(writer, ""); return;
                case DatePrefix.Dzisiaj:
                    serializer.Serialize(writer, "Dzisiaj"); return;
                case DatePrefix.Jutro:
                    serializer.Serialize(writer, "Jutro"); return;
            }
            throw new Exception("Cannot marshal type DatePrefix");
        }
    }
}

