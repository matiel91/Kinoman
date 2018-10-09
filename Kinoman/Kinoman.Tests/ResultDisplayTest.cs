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
            string expectedResult = "Niedziela 05 sierpnia\r\n" +
                "Ant-Man i Osa\r\n" +
                "13:05\t15:40\t18:15\t20:50\t\r\n" +
                "Iniemamocni 2\r\n" +
                "10:10\t14:50\t\r\n" +
                "Jak zostać czarodziejem\r\n" +
                "10:20\t12:35\t\r\n" +
                "Książe Czaruś\r\n" +
                "11:05\t\r\n" +
                "Mamma Mia! Here We Go Again\r\n" +
                "12:50\t15:20\t17:50\t20:20\t\r\n" +
                "Mission: Imposible-Fallout\r\n" +
                "19:30\t\r\n";
            Assert.AreEqual(expectedResult, result);
            
        }
    }
}
