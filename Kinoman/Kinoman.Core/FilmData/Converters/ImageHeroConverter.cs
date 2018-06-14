using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class ImageHeroConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ImageHero) || t == typeof(ImageHero?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "")
            {
                return ImageHero.Empty;
            }
            throw new Exception("Cannot unmarshal type ImageHero");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ImageHero)untypedValue;
            if (value == ImageHero.Empty)
            {
                serializer.Serialize(writer, ""); return;
            }
            throw new Exception("Cannot marshal type ImageHero");
        }
    }
}

