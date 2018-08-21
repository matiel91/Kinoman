using Kinoman.Core.Executive;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Tests
{
    class ExecutionProcedureWebSourceTest
    {
        [TestCase]
        public void isNotEmpty()
        {
            //method should return Cinema object
            //check how to make test cases when class required loading data from user!!!!!!!!!!!!
            var cut = new ExecutionProcedureWebSource();
            Assert.IsNotNull(cut.Execute());
        }
        [TestCase]
        public void isInstanceOfVenue()
        {
            //method should return Cinema object
            var cut = new ExecutionProcedureWebSource();
            Assert.IsInstanceOf(typeof(string), cut.Execute());
        }
    }
}
