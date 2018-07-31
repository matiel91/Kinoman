using System;
using System.IO;
using System.Text;

namespace Kinoman.Core
{
    public class FilmDataDownloaderFileSource : IFilmDataSource
    {
        public Cinema Get(int cinemaId)
        {
            string path2 = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName; // Path to Project Directory
            string path = Path.Combine(path2, $@"Kinoman.Tests\TestFiles\cinema_{cinemaId}.json");//Path to file directory in project directory
            var json = File.ReadAllText(path, Encoding.Default);
            Cinema result = Cinema.FromJson(json);
            return result;
        }
    }
}
