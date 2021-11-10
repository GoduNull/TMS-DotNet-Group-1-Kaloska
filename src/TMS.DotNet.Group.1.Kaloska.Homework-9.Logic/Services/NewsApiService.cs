using Data.Models;
using Logic.Constants;
using System;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.HttpClients;

namespace Logic.Services
{
    public class NewsApiService
    {
        public static async Task<NewsResponse> GetNewsAsync() => await ApiServicesHttpClient.Get<NewsResponse>(new Uri(CommonConstants.Web));
    }
}