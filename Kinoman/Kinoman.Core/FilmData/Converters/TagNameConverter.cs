using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class TagNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TagName) || t == typeof(TagName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case " Dubbing":
                    return TagName.Dubbing;
                case " Napisy":
                    return TagName.Napisy;
                case " ORG":
                    return TagName.Org;
                case " PL":
                    return TagName.Pl;
                case "360°, ORG":
                    return TagName.The360Org;
                case "360°, dubbing":
                    return TagName.The360Dubbing;
            }
            throw new Exception("Cannot unmarshal type TagName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TagName)untypedValue;
            switch (value)
            {
                case TagName.Dubbing:
                    serializer.Serialize(writer, " Dubbing"); return;
                case TagName.Napisy:
                    serializer.Serialize(writer, " Napisy"); return;
                case TagName.Org:
                    serializer.Serialize(writer, " ORG"); return;
                case TagName.Pl:
                    serializer.Serialize(writer, " PL"); return;
                case TagName.The360Org:
                    serializer.Serialize(writer, "360°, ORG"); return;
                case TagName.The360Dubbing:
                    serializer.Serialize(writer, "360°, dubbing"); return;
            }
            throw new Exception("Cannot marshal type TagName");
        }
    }
}

