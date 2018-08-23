using System;
using System.IO;
using System.Text;

namespace Kinoman.Core
{
    /// <summary>
    /// Class respondible for deserializing JSON with cinemas repertoire data. JSON,s source is file.
    /// </summary>
    public class FilmDataDownloaderFileSource : IFilmDataSource
    {
        /// <summary>
        /// Function takes id of cinema and return Cinema type with repertoir for introduced id
        /// </summary>
        /// <param name="cinemaId">Id of cinema. Possible to take with CinemaIdDownloader class</param>
        /// <returns>Return Cinema type</returns>
        public Cinema Get(int cinemaId)
        {
            string path2 = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName; // Path to Project Directory
            string path = Path.Combine(path2, $@"Kinoman.Tests\TestFiles\cinema_{cinemaId}.json");//Path to file directory in project directory
            var json = File.ReadAllText(path, Encoding.UTF8).ToString();//To string added
            Cinema result = Cinema.FromJson(json);
            return result;
        }

        //private static string Utf8ToUnicode(string utf8)
        //{
        //    return Encoding.Unicode.GetString(
        //      Encoding.Convert(
        //      Encoding.UTF8,
        //      Encoding.Unicode,
        //      Encoding.UTF8.GetBytes(utf8)));
        //}
    }
}
