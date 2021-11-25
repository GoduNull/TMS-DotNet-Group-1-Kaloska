using System;
using System.Linq;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models.WeatherModels;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Helpers;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Services
{
    public static class WeatherUiService
    {
        public static async Task RunAsync()
        {
            var cityName = GetCityNameFromConsole();
            var date = GetDateFromConsole();
            var result = await WeatherApiHelper.GetWeatherForecastByCity(cityName);
            DisplayWeatherForecast(result, date);
        }

        private static string GetCityNameFromConsole()
        {
            Console.WriteLine("The application can show you a 5 day weather forecast for particular city." +
                              "\nPlease input city name:");
            var cityName = Console.ReadLine();

            return cityName;
        }

        private static string GetDateFromConsole()
        {
            Console.WriteLine("Please input date in YYYY-MM-DD format for which you would like to get a forecast:");
            var date = Console.ReadLine();

            return date;
        }

        private static void DisplayWeatherForecast(WeatherLocationResponseModel result, string date)
        {
            var consolidatedWeatherForSelectedDay = result.ConsolidatedWeather.First(x => x.ApplicableDate.Equals(date));
            Console.WriteLine($"Your weather forecast for {date}: " +
                              $"\n  Weather State: {consolidatedWeatherForSelectedDay.WeatherStateName}" +
                              $"\n  Minimum Temperature: {consolidatedWeatherForSelectedDay.MinTemp:0.0} °C" +
                              $"\n  Maximum Temperature: {consolidatedWeatherForSelectedDay.MaxTemp:0.0} °C" +
                              $"\n  Wind Speed: {consolidatedWeatherForSelectedDay.WindSpeed:0.0} mph" +
                              $"\n  Humidity: {consolidatedWeatherForSelectedDay.Humidity:0.0}%" +
                              $"\n  Predictability: {consolidatedWeatherForSelectedDay.Predictability:0}%");
        }
    }
}