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
    public class CinemaIDJSONWebSourceTests
    {
        [Test]
        public void IsNotNullWhenIsGetFromWeb()
        {
            //Arrange
            var cut = new CinemaIdJSONWebSource();            
            //Act
            var result = cut.GetJson();
            //Assert
            Assert.NotNull(result);
        }

    }
}

