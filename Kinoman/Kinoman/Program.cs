using Kinoman.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman
{
    class Program
    {
        static void Main(string[] args)
        {
            var parsedJson = new CinemaIdJSONFileSource();
            var cut = new CinemaIdDownloader(parsedJson.GetJson());

            foreach (var item in cut.Venue.Venues)
            {
                foreach (var item2 in item.Cinemas)
                {
                    Console.WriteLine(item2.SearchTerm);
                }
            }
            Console.ReadLine();
        }
    }
}
