using NUnit.Framework;
using Kinoman.Core;
namespace Kinoman.Tests
{
    [TestFixture]
    public class FilmDataDownloaderTests
    {
        [TestCase("Bydgoszcz")]
        [TestCase("Czechowice - Dziedzice")]
        [TestCase("Czechowice - Dziedzice")]
        [TestCase("Elbląg")]
        [TestCase("Gdańsk")]
        [TestCase("Gdynia")]
        [TestCase("Jaworzno")]
        [TestCase("Katowice")]
        [TestCase("Kielce")]
        [TestCase("Koszalin")]
        [TestCase("Kraków")]
        [TestCase("Lublin")]
        [TestCase("Łódź")]
        [TestCase("Olsztyn")]
        [TestCase("Poznań Malta")]
        [TestCase("Poznań Multikino 51")]
        [TestCase("Poznań Stary Browar")]
        [TestCase("Radom")]
        [TestCase("Rumia")]
        [TestCase("Rybnik")]
        [TestCase("Rzeszów")]
        [TestCase("Słupsk")]
        [TestCase("Sopot")]
        [TestCase("Szczecin")]
        [TestCase("Tychy")]
        [TestCase("Warszawa Targówek")]
        [TestCase("Warszawa Ursynów")]
        [TestCase("Warszawa Złote Tarasy")]
        [TestCase("Włocławek")]
        [TestCase("Wrocław Pasaż Grunwaldzki")]
        [TestCase("Zabrze")]
        [TestCase("Zgorzelec")]
        public void DoesNotThrowAnyException(string location)
        {
            //Arrange
            var cut = new FilmDataDownloader();
            CinemaIdDownloader idDownloader = new CinemaIdDownloader();
            //Act
            int id = idDownloader.GetId(location);

            //Assert
            Assert.DoesNotThrow(() => cut.Get(id)); //delegat??
        }
        [TestCase(39)]
        [TestCase(5)]
        [TestCase(4)]
        [TestCase(2)]
        public void IsNotNull(int cinemaId)
        {
            //Arrange
            var cut = new FilmDataDownloader();
            //Act
            var result = cut.Get(cinemaId);
            //Assert
            Assert.NotNull(result);
        }
    }
}
