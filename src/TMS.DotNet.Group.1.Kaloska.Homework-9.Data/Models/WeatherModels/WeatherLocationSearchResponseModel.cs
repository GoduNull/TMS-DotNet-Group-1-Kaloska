using Newtonsoft.Json;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models.WeatherModels
{
    public class WeatherLocationSearchResponseModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("woeid")]
        public int WoeId { get; set; }
    }
}