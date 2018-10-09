using Kinoman.Core;
using Kinoman.Core.Executive;
using Kinoman.Core.Executive.FileSource;
using Kinoman.Core.Executive.WebSource;
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
            ExecutionProcedureWebSource execute = new ExecutionProcedureWebSource();
            Console.WriteLine(execute.Execute());
            Console.ReadLine();
        }
    }
}
