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
    public partial class Film
    {
        [JsonProperty("original_s_count")]
        public long OriginalSCount { get; set; }

        [JsonProperty("sortable")]
        public long Sortable { get; set; }

        [JsonProperty("showings")]
        public List<Showing> Showings { get; set; }

        [JsonProperty("show_showings")]
        public bool ShowShowings { get; set; }

        [JsonProperty("film_page_name")]
        public string FilmPageName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_hero")]
        public ImageHero ImageHero { get; set; }

        [JsonProperty("image_poster")]
        public string ImagePoster { get; set; }

        [JsonProperty("cert_image")]
        public CertImage CertImage { get; set; }

        [JsonProperty("cert_desc")]
        public object CertDesc { get; set; }

        [JsonProperty("synopsis_short")]
        public string SynopsisShort { get; set; }

        [JsonProperty("info_release")]
        public string InfoRelease { get; set; }

        [JsonProperty("info_runningtime_visible")]
        public bool InfoRunningtimeVisible { get; set; }

        [JsonProperty("info_runningtime")]
        public string InfoRunningtime { get; set; }

        [JsonProperty("info_age")]
        public InfoAge InfoAge { get; set; }

        [JsonProperty("pegi_class")]
        public ImageHero PegiClass { get; set; }

        [JsonProperty("info_director")]
        public string InfoDirector { get; set; }

        [JsonProperty("info_cast")]
        public object InfoCast { get; set; }

        [JsonProperty("availablecopy")]
        public string Availablecopy { get; set; }

        [JsonProperty("videolink")]
        public string Videolink { get; set; }

        [JsonProperty("filmlink")]
        public string Filmlink { get; set; }

        [JsonProperty("timeslink")]
        public string Timeslink { get; set; }

        [JsonProperty("video")]
        public ImageHero Video { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("coming_soon")]
        public bool ComingSoon { get; set; }

        [JsonProperty("comming_soon")]
        public bool CommingSoon { get; set; }

        [JsonProperty("announcement")]
        public bool Announcement { get; set; }

        [JsonProperty("virtual_reality")]
        public bool VirtualReality { get; set; }

        [JsonProperty("genres")]
        public Categories Genres { get; set; }

        [JsonProperty("tags")]
        public Categories Tags { get; set; }

        [JsonProperty("categories")]
        public Categories Categories { get; set; }

        [JsonProperty("showing_type")]
        public ShowingType ShowingType { get; set; }

        [JsonProperty("rank_votes")]
        public string RankVotes { get; set; }

        [JsonProperty("rank_value")]
        public string RankValue { get; set; }

        [JsonProperty("promo_labels")]
        public PromoLabels PromoLabels { get; set; }

        [JsonProperty("ReleaseDate")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("wantsee")]
        public string Wantsee { get; set; }

        [JsonProperty("showwantsee")]
        public bool Showwantsee { get; set; }

        [JsonProperty("newsletterurl")]
        public string Newsletterurl { get; set; }

        [JsonProperty("always_in_QB")]
        public bool AlwaysInQb { get; set; }

        [JsonProperty("priority_value")]
        public long PriorityValue { get; set; }
    }
}

