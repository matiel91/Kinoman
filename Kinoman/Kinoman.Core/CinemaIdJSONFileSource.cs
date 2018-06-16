using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core

{
    public class CinemaIdJSONFileSource : IJsonDataSource
    {
        public CinemaLocation GetJson()
        {
                       
            string json = File.ReadAllText(@"C:\WORK SPACE\Projekty\Kinoman\Kinoman\Kinoman.Tests\TestFiles\CinemaIDJson.txt");
            var result = CinemaLocation.FromJson(json);
            return result;
            
        }
    }
}
