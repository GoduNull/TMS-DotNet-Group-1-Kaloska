using Newtonsoft.Json;
using System.Collections.Generic;

namespace Data.Models
{
    public class NewsResponse
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("data")]
        public IEnumerable<News> Data { get; set; }

        [JsonProperty("success")]
        public string Success { get; set; }
    }
}