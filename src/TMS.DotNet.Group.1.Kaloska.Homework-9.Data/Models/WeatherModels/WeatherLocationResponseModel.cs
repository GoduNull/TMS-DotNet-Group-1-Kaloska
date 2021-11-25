using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models.WeatherModels
{
    public class WeatherLocationResponseModel
    {
        [JsonProperty("consolidated_weather")]
        public List<ConsolidatedWeather> ConsolidatedWeather { get; set; }
    }
}