using System.Collections.Generic;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    public partial class Categories
    {
        [JsonProperty("names")]
        public List<CategoriesName> Names { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}

