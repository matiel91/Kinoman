using System.Collections.Generic;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    public partial class PromoLabels
    {
        [JsonProperty("names")]
        public List<PromoLabelsName> Names { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("isborder")]
        public bool Isborder { get; set; }
    }
}

