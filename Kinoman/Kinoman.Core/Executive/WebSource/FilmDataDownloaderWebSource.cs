using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    /// <summary>
    /// Class respondible for deserializing JSON with cinemas repertoire data. JSON,s source is file.
    /// </summary>
    public class FilmDataDownloaderWebSource: IFilmDataSource
    {
        /// <summary>
        /// Function takes id of cinema and return Cinema type with repertoir for introduced id
        /// </summary>
        /// <param name="cinemaId">Id of cinema. Possible to take with CinemaIdDownloader class. cinemaID is used for
        /// aproach proper link with cinemas repertooir</param>
        /// <returns>Return Cinema type</returns>
        public Cinema Get(int cinemaId)
        {
            HttpClient client = new HttpClient();            
            var json = client.GetStringAsync($@"https://multikino.pl/data/filmswithshowings/{cinemaId}").Result;
            Cinema result = Cinema.FromJson(json);
            return result;
        }
    }
}
