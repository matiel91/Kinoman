// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinemaLocation = CinemaLocation.FromJson(jsonString);
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Kinoman.Core
{

    public partial class CinemaLocation
    {
        public static CinemaLocation FromJson(string json) => JsonConvert.DeserializeObject<CinemaLocation>(json, ConverterCinemaVenue.Settings);

        [JsonProperty("favourites")]
        public List<object> Favourites { get; set; }

        [JsonProperty("venues")]
        public List<Venue> Venues { get; set; }
    }
}

