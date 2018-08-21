using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core.Executive.FileSource
{
    public class ShowCinemaListsFromJSONFile
    {
        public string Execute()
        {
            CinemaIdJSONFileSource cinemaLocation = new CinemaIdJSONFileSource();
            CinemaLocation venues = cinemaLocation.GetJson();
            StringBuilder cinemaList = new StringBuilder();
            foreach (var venue in venues.Venues)
            {
                foreach (var cinema in venue.Cinemas)
                {
                    cinemaList.Append(cinema.Name + ",\t");
                }
            }

            return cinemaList.ToString();
        }
    }
}
