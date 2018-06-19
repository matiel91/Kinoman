using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kinoman.Core

{
    public class CinemaIdJSONFileSource : IJsonDataSource
    {
        public CinemaLocation GetJson()
        {

            var json = File.ReadAllText(@"C:\WORK SPACE\Projekty\Kinoman\Kinoman\Kinoman.Tests\TestFiles\CinemaIDJson.json", Encoding.Default).ToString();
            Console.WriteLine(json);
            var data = CinemaLocation.FromJson(json);
            return data;

        }
    }
}
