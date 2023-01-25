using NLog;
using WeatherClientTool_Core.DAL;
using WeatherClientTool_Core.Models;

namespace WeatherClientTool_Core.BAL
{
    public class City_Weather
    {
        City_Weather_DAL _Weather_DAL = new City_Weather_DAL();
        public static Logger _logger = LogManager.GetCurrentClassLogger();

        public City GetWeatherDetails(string cityName)
        {
            City _city = new City();
            if (cityName != null && cityName != "")
            {
                _logger.Info("User have provided no city name as '" + cityName + "'");
                try
                {
                    _logger.Info("Getting Latitude and Longitude details of " + cityName);
                    _city = _Weather_DAL.GetLatLongDetails(cityName);
                    if (_city.CityName != null)
                    {
                        _logger.Info("Latitude and Longitude details of " + cityName + " received");
                        _city = _Weather_DAL.GetWeatherDetails(_city);
                    }
                    else
                    {
                        _city.Message = "Latitude and Longitude details of " + cityName + " not found";
                        _logger.Info("Latitude and Longitude details of " + cityName + " not found");
                    }
                    return _city;
                }
                catch (Exception ex)
                {
                    _logger.Fatal("Error Occured while getting weather details from data layer");
                    _logger.Fatal("Error message:\n" + ex.Message);
                    return null;
                }
            }
            else
            {
                _logger.Info("User have provided no city name");
                return null;
            }

        }
    }
}