using System.Net.Http;
using System.Threading.Tasks;
using Data.Models;
using Logic.Constants;
using Newtonsoft.Json;

namespace Logic.Services
{
    public class NewsApiService
    {
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;
        }

        public async Task<NewsResponse> GetNewsAsync()
        {
            HttpClient client = GetClient();
            var result = await client.GetAsync(CommonConstants.Web);

            return JsonConvert.DeserializeObject<NewsResponse>(await result.Content.ReadAsStringAsync());
        }
    }
}
