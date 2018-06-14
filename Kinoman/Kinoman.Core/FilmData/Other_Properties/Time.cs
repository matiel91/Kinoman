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
    public partial class Time
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("version_id")]
        public string VersionId { get; set; }

        [JsonProperty("time")]
        public string TimeTime { get; set; }

        [JsonProperty("screen_type")]
        public ScreenType ScreenType { get; set; }

        [JsonProperty("screen_number")]
        public object ScreenNumber { get; set; }

        [JsonProperty("lang")]
        public object Lang { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("event_info")]
        public object EventInfo { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("kids_club")]
        public bool KidsClub { get; set; }
    }
}

