using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new DatePrefixConverter(),
                new ScreenTypeConverter(),
                new FullnameConverter(),
                new TagNameConverter(),
                new CertImageConverter(),
                new TypeEnumConverter(),
                new ImageHeroConverter(),
                new InfoAgeConverter(),
                new ClassConverter(),
                new PositionConverter(),
                new ShowingTypeNameConverter(),
                new DateDayConverter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

