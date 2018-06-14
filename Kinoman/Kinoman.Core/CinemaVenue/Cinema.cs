// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinemaLocation = CinemaLocation.FromJson(jsonString);
using Newtonsoft.Json;
namespace Kinoman.Core
{

    public partial class Cinema
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("search_term")]
        public string SearchTerm { get; set; }

        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("selected")]
        public string Selected { get; set; }

        [JsonProperty("filteredname")]
        public string Filteredname { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("secondarymarket")]
        public Secondarymarket Secondarymarket { get; set; }

        [JsonProperty("vr")]
        public Vr Vr { get; set; }
    }
}

