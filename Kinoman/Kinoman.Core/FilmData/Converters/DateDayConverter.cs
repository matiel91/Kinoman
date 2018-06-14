using System;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal class DateDayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DateDay) || t == typeof(DateDay?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "czwartek":
                    return DateDay.Czwartek;
                case "niedziela":
                    return DateDay.Niedziela;
                case "piątek":
                    return DateDay.Piątek;
                case "poniedziałek":
                    return DateDay.Poniedziałek;
                case "sobota":
                    return DateDay.Sobota;
                case "wtorek":
                    return DateDay.Wtorek;
                case "środa":
                    return DateDay.Środa;
            }
            throw new Exception("Cannot unmarshal type DateDay");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DateDay)untypedValue;
            switch (value)
            {
                case DateDay.Czwartek:
                    serializer.Serialize(writer, "czwartek"); return;
                case DateDay.Niedziela:
                    serializer.Serialize(writer, "niedziela"); return;
                case DateDay.Piątek:
                    serializer.Serialize(writer, "piątek"); return;
                case DateDay.Poniedziałek:
                    serializer.Serialize(writer, "poniedziałek"); return;
                case DateDay.Sobota:
                    serializer.Serialize(writer, "sobota"); return;
                case DateDay.Wtorek:
                    serializer.Serialize(writer, "wtorek"); return;
                case DateDay.Środa:
                    serializer.Serialize(writer, "środa"); return;
            }
            throw new Exception("Cannot marshal type DateDay");
        }
    }
}

