using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class FullnameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Fullname) || t == typeof(Fullname?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "2D, Dubbing":
                    return Fullname.The2DDubbing;
                case "2D, Napisy":
                    return Fullname.The2DNapisy;
                case "2D, PL":
                    return Fullname.The2DPl;
                case "2D, Wersja oryginalna":
                    return Fullname.The2DWersjaOryginalna;
                case "360°, dubbing":
                    return Fullname.The360Dubbing;
                case "360°, wersja oryginalna":
                    return Fullname.The360WersjaOryginalna;
                case "3D, Dubbing":
                    return Fullname.The3DDubbing;
                case "3D, Napisy":
                    return Fullname.The3DNapisy;
            }
            throw new Exception("Cannot unmarshal type Fullname");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Fullname)untypedValue;
            switch (value)
            {
                case Fullname.The2DDubbing:
                    serializer.Serialize(writer, "2D, Dubbing"); return;
                case Fullname.The2DNapisy:
                    serializer.Serialize(writer, "2D, Napisy"); return;
                case Fullname.The2DPl:
                    serializer.Serialize(writer, "2D, PL"); return;
                case Fullname.The2DWersjaOryginalna:
                    serializer.Serialize(writer, "2D, Wersja oryginalna"); return;
                case Fullname.The360Dubbing:
                    serializer.Serialize(writer, "360°, dubbing"); return;
                case Fullname.The360WersjaOryginalna:
                    serializer.Serialize(writer, "360°, wersja oryginalna"); return;
                case Fullname.The3DDubbing:
                    serializer.Serialize(writer, "3D, Dubbing"); return;
                case Fullname.The3DNapisy:
                    serializer.Serialize(writer, "3D, Napisy"); return;
            }
            throw new Exception("Cannot marshal type Fullname");
        }
    }
}

