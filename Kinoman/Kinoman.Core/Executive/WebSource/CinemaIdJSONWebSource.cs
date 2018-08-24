using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    /// <summary>
    /// Class responible for deserialize JSON with cinema location list. JSON's source is a website.
    /// </summary>
    public class CinemaIdJSONWebSource : IJsonDataSource
    {
        /// <summary>
        /// Method deserialize JSON's from website.
        /// </summary>
        /// <returns>Return CinemaLocation type</returns>
        public CinemaLocation GetJson()
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync(@"https://multikino.pl/data/locations/").Result;
            var result = CinemaLocation.FromJson(json);
            return result;
        }
    }
}
