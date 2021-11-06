using Newtonsoft.Json;

namespace Data.Models
{
    public class News
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("readMoreUrl")]
        public string ReadMoreUrl { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString()
        {
            return $"{new string('=', 10)}\n\n{Content}\nAuthor: <{Author}>" +
                $"\n{Date}\nRead More: {ReadMoreUrl}\n";
        }
    }
}