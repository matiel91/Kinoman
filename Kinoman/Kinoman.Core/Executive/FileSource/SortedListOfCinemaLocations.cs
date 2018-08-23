using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core.Executive.FileSource
{
    public class SortedListOfCinemaLocations
    {
        /// <summary>
        /// Method deserialize JSON and save cinemas locations to list.
        /// </summary>
        /// <returns>Return alphabetically sorted list</returns>
        public List<string> Execute()
        {
            CinemaIdJSONFileSource cinemaLocation = new CinemaIdJSONFileSource();
            CinemaLocation venues = cinemaLocation.GetJson();
            List<string> listOfCinemaLocations = new List<string>();
            foreach (var venue in venues.Venues)
            {
                foreach (var cinema in venue.Cinemas)
                {
                    listOfCinemaLocations.Add(cinema.Search);
                }
            }
            listOfCinemaLocations.Sort();

            return listOfCinemaLocations;
        }
        /// <summary>
        /// Method return a list of cinemas in table view
        /// TO DO!<--------------
        /// </summary>
        /// <param name="input">List of strings</param>
        /// <returns>Return table view of cinemas list</returns>
        public string TableView(List<string> input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Count; i++)
            {
                result.Append($"{input[i],30}");
                if (i % 4 == 0 && i!=0)
                {
                    result.AppendLine();
                }
            }
            return result.ToString();
        }
    }
}
