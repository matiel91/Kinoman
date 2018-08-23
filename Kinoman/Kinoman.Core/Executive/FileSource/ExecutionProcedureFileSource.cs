using Kinoman.Core.Executive.FileSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{   
    /// <summary>
    /// Class responsible for execution functions in proper order
    /// </summary>
    public class ExecutionProcedureFileSource : IExecute
    {
        /// <summary>
        /// Method execute procedure of running program in proper order
        /// </summary>
        /// <returns>Return string with a repoertoire</returns>
        public string Execute()
        {
            CinemaIdJSONFileSource cinemaIdJSONFileSource = new CinemaIdJSONFileSource();
            var cinemaIdData = cinemaIdJSONFileSource.GetJson();
            CinemaIdDownloader cinemaIdDownloader = new CinemaIdDownloader(cinemaIdData);
            ShowCinemaListsFromJSONFile showCinemaList = new ShowCinemaListsFromJSONFile();
            Console.WriteLine(showCinemaList.Execute());
            Console.WriteLine("Podaj kino");
            var cinemaName = Console.ReadLine();
            var cinemaId = cinemaIdDownloader.GetId(cinemaName);
            FilmDataDownloaderFileSource filmDataDownloaderFileSource = new FilmDataDownloaderFileSource();
            var cinemaData = filmDataDownloaderFileSource.Get(cinemaId);
            ResultDisplay resultDisplay = new ResultDisplay(cinemaData);
            var result = resultDisplay.GenerateResult();
            return result;
            
        }

    }
}
