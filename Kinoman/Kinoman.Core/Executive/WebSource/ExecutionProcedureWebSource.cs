using Kinoman.Core.Executive.FileSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core.Executive
{

    /// <summary>
    /// Class responsible for execution functions in proper order
    /// </summary>
    public class ExecutionProcedureWebSource : IExecute
    {
        /// <summary>
        /// Method execute procedure of running program in proper order
        /// </summary>
        /// <returns>Return string with a repoertoire</returns>
        public string Execute()
        {
            CinemaIdJSONWebSource idJson = new CinemaIdJSONWebSource();
            FilmDataDownloaderWebSource filmDataDownloader = new FilmDataDownloaderWebSource();
            var idCinemaLocation = idJson.GetJson();
            CinemaIdDownloader cinemaIdDownloader = new CinemaIdDownloader(idCinemaLocation);
            ShowCinemaListsFromJSONFile showCinemaList = new ShowCinemaListsFromJSONFile();
            Console.WriteLine(showCinemaList.Execute());
            Console.WriteLine("Podaj kino");
            var id = cinemaIdDownloader.GetId(Console.ReadLine());
            var filmData = filmDataDownloader.Get(id);
            ResultDisplay resultDisplay = new ResultDisplay(filmData);
            return resultDisplay.GenerateResult();


        }
    }
}
