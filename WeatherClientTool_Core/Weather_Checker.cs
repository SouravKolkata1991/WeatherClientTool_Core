
using NLog;
using WeatherClientTool_Core.BAL;
using WeatherClientTool_Core.Helper;
using WeatherClientTool_Core.Models;

Logger _logger = LogManager.GetCurrentClassLogger();
Helper.Initialize(_logger);
string cityName = Helper.TakeInput(_logger);
Helper.GetWeatherDetails(cityName, _logger);
string choice = Helper.GetChoice(_logger);
while (choice.ToUpper() == "Y" || choice.ToUpper() == "YES")
{
    cityName = Helper.TakeInput(_logger);
    Helper.GetWeatherDetails(cityName, _logger);
    choice = Helper.GetChoice(_logger);
}
_logger.Info("App console is closing as user search completed");
_logger.Info("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

System.Environment.Exit(1);

