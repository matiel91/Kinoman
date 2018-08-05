using Kinoman.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Tests
{
    [TestFixture]
    public class ExeciutonProcedureFileSourceTest
    {
        [TestCase]
        public void isNotEmpty()
        {
            //method should return Cinema object
            var cut = new ExecutionProcedureFileSource();
            Assert.IsNotNull(cut.Execute());        
        }
        [TestCase]
        public void isInstanceOfVenue()
        {
            //method should return Cinema object
            var cut = new ExecutionProcedureFileSource();
            Assert.IsInstanceOf(typeof(Venue), cut.Execute());
        }

    }
}
