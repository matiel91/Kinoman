using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    public class FilmDataDownloaderWebSource: IFilmDataSource
    {
        public Cinema Get(int cinemaId)
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync($@"https://multikino.pl/data/filmswithshowings/{cinemaId}").Result;
            Cinema result = Cinema.FromJson(json);
            return result;
        }
    }
}
