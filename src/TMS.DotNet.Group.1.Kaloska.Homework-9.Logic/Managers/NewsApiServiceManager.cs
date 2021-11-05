using Data.Models;
using Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Managers
{
    class NewsApiServiceManager
    {
        internal async static Task ShowNewsAsync()
        {
            NewsApiService apiService = new();
            var AllNews = await apiService.GetNewsAsyns();
            foreach (News n in AllNews.Data.Take(5))
            {
                Console.WriteLine(n.ToString());
            }
        }
    }
}
