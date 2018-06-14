using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Cinema;
//
//    var cinema = Cinema.FromJson(jsonString);

namespace Kinoman.Core
{

    public partial class Tag
    {
        [JsonProperty("name")]
        public TagName Name { get; set; }

        [JsonProperty("fullname")]
        public Fullname Fullname { get; set; }
    }
}

