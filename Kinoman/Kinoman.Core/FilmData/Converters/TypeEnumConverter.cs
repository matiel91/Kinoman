using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Film Details":
                    return TypeEnum.FilmDetails;
                case "Marathon Event":
                    return TypeEnum.MarathonEvent;
                case "Standard Event":
                    return TypeEnum.StandardEvent;
                case "Virtual Reality Event":
                    return TypeEnum.VirtualRealityEvent;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.FilmDetails:
                    serializer.Serialize(writer, "Film Details"); return;
                case TypeEnum.MarathonEvent:
                    serializer.Serialize(writer, "Marathon Event"); return;
                case TypeEnum.StandardEvent:
                    serializer.Serialize(writer, "Standard Event"); return;
                case TypeEnum.VirtualRealityEvent:
                    serializer.Serialize(writer, "Virtual Reality Event"); return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }
    }
}

