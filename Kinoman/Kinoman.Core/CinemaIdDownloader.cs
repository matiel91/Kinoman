using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    public class CinemaIdDownloader
    {
        public CinemaLocation Venue { get; }

        public CinemaIdDownloader(CinemaLocation venueParsedJson)
        {
            Venue = venueParsedJson;
        }

        public int GetId(string location)
        {
            string idResult = "0";
            List<Cinema> cinemaList = new List<Cinema>();
            foreach (var item in Venue.Venues)
            {
                foreach (var cinema in item.Cinemas)
                {


                    //if (cinema.Search.Equals(location, StringComparison.OrdinalIgnoreCase))
                    if(cinema.Search.Trim().Equals(location, StringComparison.OrdinalIgnoreCase))
                    {
                        return int.Parse(cinema.Id);
                    }
                }
            }
            throw new Exception("Something wrong in CinemaIdDownloader class");
        }
    }
}
