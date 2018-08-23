using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core.Executive.FileSource
{
    /// <summary>
    /// Class responible for showing cinema list. 
    /// </summary>
    public class ShowCinemaListsFromJSONFile
    {
        /// <summary>
        /// Method deserialize JSON with CinemaIdJSONFileSource class. 
        /// </summary>
        /// <returns>Return string with cinema list splited by ", "</returns>
        public string Execute()
        {
            CinemaIdJSONFileSource cinemaLocation = new CinemaIdJSONFileSource();
            CinemaLocation venues = cinemaLocation.GetJson();
            StringBuilder cinemaList = new StringBuilder();
            foreach (var venue in venues.Venues)
            {
                foreach (var cinema in venue.Cinemas)
                {
                    cinemaList.Append(cinema.Search + ",");
                }
            }


            return cinemaList.ToString();
        }
    }
}
