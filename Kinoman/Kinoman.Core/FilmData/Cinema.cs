using System.Collections.Generic;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    public partial class Cinema
    {
        public static Cinema FromJson(string json) => JsonConvert.DeserializeObject<Cinema>(json, Converter.Settings);// -Cinema.Converter.Setting

        [JsonProperty("films")]
        public List<Film> Films { get; set; }

        [JsonProperty("cdate")]
        public string Cdate { get; set; }

        [JsonProperty("SiteRootPath")]
        public string SiteRootPath { get; set; }

        [JsonProperty("Site")]
        public string Site { get; set; }

        [JsonProperty("Lang")]
        public string Lang { get; set; }

    }
}

