using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{
    public partial class Showing
    {
        [JsonProperty("date_prefix")]
        public DatePrefix DatePrefix { get; set; }

        [JsonProperty("date_day")]
        public DateDay DateDay { get; set; }

        [JsonProperty("date_short")]
        public string DateShort { get; set; }

        [JsonProperty("date_long")]
        public string DateLong { get; set; }

        [JsonProperty("date_time")]
        public DateTimeOffset DateTime { get; set; }

        [JsonProperty("date_formatted")]
        public string DateFormatted { get; set; }

        [JsonProperty("times")]
        public List<Time> Times { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset Cdate { get; set; }

        [JsonProperty("clone")]
        public bool Clone { get; set; }
    }
}

