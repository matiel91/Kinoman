// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinemaLocation = CinemaLocation.FromJson(jsonString);
namespace Kinoman.Core
{
    using Newtonsoft.Json;

    public static class Serialize
    {
        public static string ToJson(this CinemaLocation self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}

