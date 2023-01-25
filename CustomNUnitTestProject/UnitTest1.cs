
using NLog;
using WeatherClientTool_Core.Helper;

namespace CustomNUnitTestProject
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }
        [Test]
        public void TestKolkata()
        {
            Logger _logger = LogManager.GetCurrentClassLogger();
            Assert.AreEqual(true, Helper.GetWeatherDetails("Kolkata", _logger));
        }
        [Test]
        public void TestMumbai()
        {
            Logger _logger = LogManager.GetCurrentClassLogger();
            Assert.AreEqual(true, Helper.GetWeatherDetails("Mumbai",_logger));
        }
        [Test]
        public void TestKanpur()
        {
            Logger _logger = LogManager.GetCurrentClassLogger();
            //Kanpur is not present in the city list csv file with latitude and longitude data
            Assert.AreEqual(false, Helper.GetWeatherDetails("Kanpur",_logger));
        }
        [Test]
        public void TestInvalidCity()
        {
            Logger _logger = LogManager.GetCurrentClassLogger();
            Assert.AreEqual(false, Helper.GetWeatherDetails("kkkkk",_logger));
        }
    }
}