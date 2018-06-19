using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    public class CinemaIdJSONWebSource : IJsonDataSource
    {
        public CinemaLocation GetJson()
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync(@"https://multikino.pl/data/locations/").Result;
            var result = CinemaLocation.FromJson(json);
            return result;
        }
    }
}
