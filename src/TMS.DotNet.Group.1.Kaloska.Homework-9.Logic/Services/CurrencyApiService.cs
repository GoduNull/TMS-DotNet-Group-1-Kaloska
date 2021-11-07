using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Constants;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Services
{
    public class CurrencyApiService
    {
        /// <summary>
        /// Gives currency rates
        /// </summary>
        /// <returns></returns>
        public async Task<Root> GetCurrencyRate()
        {
            var currentRoot = new Root();
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(CurrencyConst.Url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var responceString = await response.Content.ReadAsStringAsync();
                        var responceObject = JsonConvert.DeserializeObject<Root>(responceString);
                        return responceObject;
                    }
                    return currentRoot;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return currentRoot;
            }
        }
    }
}