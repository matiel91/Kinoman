using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    public static class Serialize
    {
        public static string ToJson(this Cinema self) => JsonConvert.SerializeObject(self, Converter.Settings);// -Cinema.Converter.Setting
    }
}

