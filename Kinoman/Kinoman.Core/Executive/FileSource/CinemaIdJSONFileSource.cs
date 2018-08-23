using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kinoman.Core

{   
    /// <summary>
    /// Class responible for deserialize JSON with cinema location list. JSON's source is a file.
    /// </summary>
    public class CinemaIdJSONFileSource : IJsonDataSource
    {
        /// <summary>
        /// Method deserialize JSON's from file.
        /// </summary>
        /// <returns>Return CinemaLocation type</returns>
        public CinemaLocation GetJson()
        {
            string path2 = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName; // Path to Project Directory
            string path = Path.Combine(path2, @"Kinoman.Tests\TestFiles\CinemaIDJson.json");//Path to file directory in project directory
            var json = File.ReadAllText(path, Encoding.Default).ToString();
            //Console.WriteLine(json);
            var data = CinemaLocation.FromJson(json);
            return data;

        }
    }
}
