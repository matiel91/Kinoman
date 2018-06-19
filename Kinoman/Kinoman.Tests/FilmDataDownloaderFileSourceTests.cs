using Kinoman.Core;
using NUnit.Framework;
namespace Kinoman.Tests
{
    public partial class FilmDataDownloaderWebSourceTests
    {
        [TestFixture]
        public class FilmDataDownloaderFileSourceTests
        {
            
            [TestCase(2)]
            [TestCase(20)]
            [TestCase(5)]
            public void IsNotNull(int cinemaId)
            {
                //Arrange
                var cut = new FilmDataDownloaderFileSource();
                //Act
                var result = cut.Get(cinemaId);
                //Assert
                Assert.NotNull(result);
            }
        }
    }
}
