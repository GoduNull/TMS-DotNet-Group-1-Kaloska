using System;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Logic.Services;

namespace Logic.Managers
{
    class NewsApiServiceManager
    {
        internal async static Task ShowNewsAsync()
        {
            NewsApiService apiService = new();
            var AllNews = await apiService.GetNewsAsync();
            foreach (News n in AllNews.Data.Take(5))
            {
                Console.WriteLine(n.ToString());
            }
        }
    }
}
