using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    public partial class ShowingType
    {
        [JsonProperty("name")]
        public ShowingTypeName Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}

