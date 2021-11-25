using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models.WeatherModels;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Constants;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.HttpClients;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Services
{
    public static class WeatherApiService
    {
        public static async Task<List<WeatherLocationSearchResponseModel>> GetLocationSearch(string query) => await ApiServicesHttpClient.Get<List<WeatherLocationSearchResponseModel>>(
            new Uri($"{WeatherApiConstants.BaseUrl}{WeatherApiConstants.GetLocationSearchUrlSegment}"),
            new Dictionary<string, string>
            {
                { "query", query }
            });

        public static async Task<WeatherLocationResponseModel> GetLocation(int woeId) => await ApiServicesHttpClient.Get<WeatherLocationResponseModel>(
            new Uri($"{WeatherApiConstants.BaseUrl}{string.Format(WeatherApiConstants.GetLocationUrlSegment, woeId)}"));
    }
}