using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Extensions;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.HttpClients
{
    public class ApiServicesHttpClient
    {
        private static HttpClient _client;

        public static async Task<TResult> Get<TResult>(Uri uri, Dictionary<string, string> queryParameters = null)
        {
            var builder = new UriBuilder(uri);

            if (queryParameters != null)
            {
                builder.Query = queryParameters.ConvertToQueryString();
            }

            var request = new HttpRequestMessage(HttpMethod.Get, builder.Uri);
            var response = await GetClient().SendAsync(request);

            return JsonConvert.DeserializeObject<TResult>(response.Content.ReadAsStringAsync().Result);
        }

        private static HttpClient GetClient()
        {
            if (_client != null) return _client;
            _client = new HttpClient();

            return _client;
        }
    }
}