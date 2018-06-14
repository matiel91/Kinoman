using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class ClassConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Class) || t == typeof(Class?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "promo-label--hit":
                    return Class.PromoLabelHit;
                case "promo-label--promo":
                    return Class.PromoLabelPromo;
            }
            throw new Exception("Cannot unmarshal type Class");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Class)untypedValue;
            switch (value)
            {
                case Class.PromoLabelHit:
                    serializer.Serialize(writer, "promo-label--hit"); return;
                case Class.PromoLabelPromo:
                    serializer.Serialize(writer, "promo-label--promo"); return;
            }
            throw new Exception("Cannot marshal type Class");
        }
    }
}

