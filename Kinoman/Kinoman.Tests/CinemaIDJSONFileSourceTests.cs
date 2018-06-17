using Kinoman.Core;
using NUnit.Framework;
namespace Kinoman.Tests
{


    [TestFixture]
    public partial class CinemaIDJSONFileSourceTests
    {
        [Test]
        public void IsNotNullWhenIsGetFromFile()
        {
            //Arrange
            var cut = new CinemaIdJSONFileSource();
            //Act
            var result = cut.GetJson();
            //Assert
            Assert.NotNull(result);
        }
    }
}
