using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    /// <summary>
    /// Class reposnible for downloading ID of entered cinema location
    /// </summary>
    public class CinemaIdDownloader
    {
        public CinemaLocation Venue { get; }

        /// <summary>
        /// Constructior take as parameter CinemaLocation type which store deserialized JSON with cinemas locations
        /// </summary>
        public CinemaIdDownloader(CinemaLocation venueParsedJson)
        {
            Venue = venueParsedJson;
        }
        /// <summary>
        /// Method return id number for enetered location
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Id number for enetered cinema location e.g location = "Gdynia"</returns>
        public int GetId(string location)
        {
            List<Cinema> cinemaList = new List<Cinema>();
            foreach (var item in Venue.Venues)
            {
                foreach (var cinema in item.Cinemas)
                {
                    if(cinema.Search.Trim().Equals(location, StringComparison.OrdinalIgnoreCase))
                    {                       
                        return int.Parse(cinema.Id);
                    }
                }
            }
            // Exception is thrown usually when inadequate location entered. 
            // Need to follow cinema list which can be showed up with SortedListOfCinemaLocations class 
            throw new Exception("Something wrong in CinemaIdDownloader class");
        }
    }
}
