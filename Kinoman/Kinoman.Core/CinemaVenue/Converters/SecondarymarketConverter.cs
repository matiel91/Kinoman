// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinemaLocation = CinemaLocation.FromJson(jsonString);
namespace Kinoman.Core.CinemaID
{
    using System;
    using Newtonsoft.Json;

    internal class SecondarymarketConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Secondarymarket) || t == typeof(Secondarymarket?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "True")
            {
                return Secondarymarket.True;
            }
            throw new Exception("Cannot unmarshal type Secondarymarket");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Secondarymarket)untypedValue;
            if (value == Secondarymarket.True)
            {
                serializer.Serialize(writer, "True"); return;
            }
            throw new Exception("Cannot marshal type Secondarymarket");
        }
    }
}

