using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class ShowingTypeNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ShowingTypeName) || t == typeof(ShowingTypeName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Filmy":
                    return ShowingTypeName.Filmy;
                case "Wydarzenia":
                    return ShowingTypeName.Wydarzenia;
            }
            throw new Exception("Cannot unmarshal type ShowingTypeName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ShowingTypeName)untypedValue;
            switch (value)
            {
                case ShowingTypeName.Filmy:
                    serializer.Serialize(writer, "Filmy"); return;
                case ShowingTypeName.Wydarzenia:
                    serializer.Serialize(writer, "Wydarzenia"); return;
            }
            throw new Exception("Cannot marshal type ShowingTypeName");
        }
    }
}

