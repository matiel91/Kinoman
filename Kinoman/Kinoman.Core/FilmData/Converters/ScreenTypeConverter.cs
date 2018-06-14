using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class ScreenTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScreenType) || t == typeof(ScreenType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "2D":
                    return ScreenType.The2D;
                case "3D":
                    return ScreenType.The3D;
            }
            throw new Exception("Cannot unmarshal type ScreenType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ScreenType)untypedValue;
            switch (value)
            {
                case ScreenType.The2D:
                    serializer.Serialize(writer, "2D"); return;
                case ScreenType.The3D:
                    serializer.Serialize(writer, "3D"); return;
            }
            throw new Exception("Cannot marshal type ScreenType");
        }
    }
}

