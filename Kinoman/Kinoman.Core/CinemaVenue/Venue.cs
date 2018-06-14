// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinemaLocation = CinemaLocation.FromJson(jsonString);
namespace Kinoman.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class Venue
    {
        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("cinemas")]
        public List<Cinema> Cinemas { get; set; }
    }
}

