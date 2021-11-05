using Data.Models;
using Logic.Constants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


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
        public async Task<NewsResponse> GetNewsAsyns()
        {
            HttpClient client = GetClient();
            var result = await client.GetAsync(CommonConstants.Web);
            return JsonConvert.DeserializeObject<NewsResponse>(await result.Content.ReadAsStringAsync());
        }
    }
}
