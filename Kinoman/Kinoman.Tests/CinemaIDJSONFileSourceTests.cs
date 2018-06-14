using NUnit.Framework;
namespace Kinoman.Tests
{


    [TestFixture]
    public class CinemaIDJSONFileSourceTests
    {
        [Test]
        public void isNotNullWhenIsGetFromFile()
        {
            //Arrange
            var cut = new CinemaIdJSONFileSource();
            //Act
            var result = cut.GetJson();
            //Assert
            Assert.NotNull(result);
        }


        [TestCase("Bydgoszcz", 3)]
        [TestCase("Czechowice-Dziedzice", 37)]
        [TestCase("Elbląg", 2)]
        [TestCase("Gdańsk", 4)]
        [TestCase("Gdynia", 5)]
        [TestCase("Jaworzno", 41)]
        [TestCase("Katowice", 39)]
        [TestCase("Kielce", 33)]
        [TestCase("Warszawa Wola Park", 15)]
        [TestCase("Zabrze", 20)]
        public void isGetProperID(string location, int properId)
        {
            //Arrange
            var cut = new CinemaIdDownloader();

            //Act
            int result = cut.GetId(location);
            //Assert
            Assert.AreEqual(result, properId);
        }
    }
}
