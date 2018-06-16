// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinemaLocation = CinemaLocation.FromJson(jsonString);
//CinemaVenue
namespace Kinoman.Core
{
    using Newtonsoft.Json;

    public static class SerializeCinemaVenue
    {
        public static string ToJson(this CinemaLocation self) => JsonConvert.SerializeObject(self, ConverterCinemaVenue.Settings);
    }
}

