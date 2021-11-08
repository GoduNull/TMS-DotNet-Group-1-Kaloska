using Newtonsoft.Json;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models.WeatherModels
{
    public class ConsolidatedWeather
    {
        [JsonProperty("weather_state_name")]
        public string WeatherStateName { get; set; }

        [JsonProperty("applicable_date")]
        public string ApplicableDate { get; set; }

        [JsonProperty("min_temp")]
        public double MinTemp { get; set; }

        [JsonProperty("max_temp")]
        public double MaxTemp { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("predictability")]
        public int Predictability { get; set; }
    }
}
