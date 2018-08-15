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
    class ResultDisplayTest
    {
        [TestCase]
        public void IsDispalyProprlyForToday()
        {
            FilmDataDownloaderFileSource filmDataDownloaderFileSource = new FilmDataDownloaderFileSource();
            var cinemaData = filmDataDownloaderFileSource.Get(34);
            var cut = new ResultDisplay(cinemaData);
            string result = cut.GenerateResult();

            string expectedResult = "Niedziela 05 Sierpnia\n" +
                "Ant-Man: OSA\n" +
                "13:05\t15:40\t18:15\t20:50" +
                "Iniemamocni 2" +
                "10:10\t14:50" +
                "Jak zostać czarodziejem" +
                "10:20\t12:35" +
                "Książe Czaruś" +
                "11:05" +
                "Mamma Mia! Here We Go Again" +
                "12:50\t15:20\t17:50\t20:20" +
                "Mission: Imposible-Fallout" +
                "19:30";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
