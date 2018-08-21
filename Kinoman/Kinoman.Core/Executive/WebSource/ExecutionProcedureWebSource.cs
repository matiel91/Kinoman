using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core.Executive
{
    public class ExecutionProcedureWebSource : IExecute
    {
        public string Execute()
        {
            CinemaIdJSONWebSource idJson = new CinemaIdJSONWebSource();
            FilmDataDownloaderWebSource filmDataDownloader = new FilmDataDownloaderWebSource();
            var idCinemaLocation = idJson.GetJson();
            CinemaIdDownloader cinemaIdDownloader = new CinemaIdDownloader(idCinemaLocation);
            Console.WriteLine("Podaj kino");
            var id = cinemaIdDownloader.GetId(Console.ReadLine());
            var filmData = filmDataDownloader.Get(id);
            ResultDisplay resultDisplay = new ResultDisplay(filmData);
            return resultDisplay.GenerateResult();


        }
    }
}
