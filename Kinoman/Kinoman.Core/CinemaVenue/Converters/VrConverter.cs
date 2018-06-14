using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinemaLocation = CinemaLocation.FromJson(jsonString);
namespace Kinoman.Core
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    internal class VrConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Vr) || t == typeof(Vr?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "False":
                    return Vr.False;
                case "True":
                    return Vr.True;
            }
            throw new Exception("Cannot unmarshal type Vr");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Vr)untypedValue;
            switch (value)
            {
                case Vr.False:
                    serializer.Serialize(writer, "False"); return;
                case Vr.True:
                    serializer.Serialize(writer, "True"); return;
            }
            throw new Exception("Cannot marshal type Vr");
        }
    }
}

