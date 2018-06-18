using Kinoman.Core;
using NUnit.Framework;
namespace Kinoman.Tests
{
    public partial class CinemaIDJSONFileSourceTests
    {
        [TestFixture]
        public class CinemaIdDonwloaderTests
        {
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
            public void IsGetProperIDWhenTakeDataFromFile(string location, int properId)
            {
                //Arrange
                var parsedJson = new CinemaIdJSONFileSource();
                var cut = new CinemaIdDownloader(parsedJson.GetJson());

                //Act
                int result = cut.GetId(location);
                //Assert
                Assert.AreEqual(result, properId);
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
            public void IsGetProperIDWhenTakeDataFromWeb(string location, int properId)
            {
                //Arrange
                var parsedJson = new CinemaIdJSONWebSource();
                var cut = new CinemaIdDownloader(parsedJson.GetJson());

                //Act
                int result = cut.GetId(location);
                //Assert
                Assert.AreEqual(result, properId);
            }

        }

    }
}
