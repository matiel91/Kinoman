using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class PositionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Position) || t == typeof(Position?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Position.Empty;
                case "promo-label-container--down-right":
                    return Position.PromoLabelContainerDownRight;
            }
            throw new Exception("Cannot unmarshal type Position");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Position)untypedValue;
            switch (value)
            {
                case Position.Empty:
                    serializer.Serialize(writer, ""); return;
                case Position.PromoLabelContainerDownRight:
                    serializer.Serialize(writer, "promo-label-container--down-right"); return;
            }
            throw new Exception("Cannot marshal type Position");
        }
    }
}

