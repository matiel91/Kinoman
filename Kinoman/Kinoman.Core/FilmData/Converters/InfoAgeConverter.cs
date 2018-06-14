using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class InfoAgeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InfoAge) || t == typeof(InfoAge?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return InfoAge.Empty;
                case "12":
                    return InfoAge.The12;
                case "13":
                    return InfoAge.The13;
                case "15":
                    return InfoAge.The15;
                case "7":
                    return InfoAge.The7;
                case "b.o.":
                    return InfoAge.BO;
            }
            throw new Exception("Cannot unmarshal type InfoAge");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (InfoAge)untypedValue;
            switch (value)
            {
                case InfoAge.Empty:
                    serializer.Serialize(writer, ""); return;
                case InfoAge.The12:
                    serializer.Serialize(writer, "12"); return;
                case InfoAge.The13:
                    serializer.Serialize(writer, "13"); return;
                case InfoAge.The15:
                    serializer.Serialize(writer, "15"); return;
                case InfoAge.The7:
                    serializer.Serialize(writer, "7"); return;
                case InfoAge.BO:
                    serializer.Serialize(writer, "b.o."); return;
            }
            throw new Exception("Cannot marshal type InfoAge");
        }
    }
}

