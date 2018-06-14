using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    public partial class PromoLabelsName
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }
    }
}

