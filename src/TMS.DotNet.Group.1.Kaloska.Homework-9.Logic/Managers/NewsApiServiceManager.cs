using Data.Models;
using Logic.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Logic.Managers
{
    internal class NewsApiServiceManager
    {
        internal static async Task ShowNewsAsync()
        {
            var AllNews = await NewsApiService.GetNewsAsync();
            foreach (News n in AllNews.Data.Take(5))
            {
                Console.WriteLine(n.ToString());
            }
        }
    }
}