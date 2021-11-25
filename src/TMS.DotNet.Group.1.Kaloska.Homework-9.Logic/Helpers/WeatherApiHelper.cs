using System.Linq;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models.WeatherModels;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Services;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Helpers
{
    public static class WeatherApiHelper
    {
        public static async Task<WeatherLocationResponseModel> GetWeatherForecastByCity(string cityName)
        {
            var locationSearchResponseModel = await WeatherApiService.GetLocationSearch(cityName);
            var locationResponseModel = await WeatherApiService.GetLocation(locationSearchResponseModel.First().WoeId);

            return locationResponseModel;
        }
    }
}