using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    public class ExecutionProcedureFileSource : IExecute
    {

        public string Execute()
        {
            CinemaIdJSONFileSource cinemaIdJSONFileSource = new CinemaIdJSONFileSource();
            var cinemaIdData = cinemaIdJSONFileSource.GetJson();
            CinemaIdDownloader cinemaIdDownloader = new CinemaIdDownloader(cinemaIdData);
            //wyswietlanie listy dostepnych kin
            Console.WriteLine("Podaj kino");
            var cinemaName = Console.ReadLine();
            var cinemaId = cinemaIdDownloader.GetId(cinemaName);
            FilmDataDownloaderFileSource filmDataDownloaderFileSource = new FilmDataDownloaderFileSource();
            var cinemaData = filmDataDownloaderFileSource.Get(cinemaId);
            ResultDisplay resultDisplay = new ResultDisplay(cinemaData);
            return resultDisplay.GenerateResult();
            
        }

    }
}
