using System;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Constants;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.HttpClients;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Managers
{
    public class CurrencyApiServiceManager
    {
        /// <summary>
        /// Shows currency rates async
        /// </summary>
        /// <returns></returns>
        public static async Task ShowCurrencyAsync()
        {
            var currencyRates = await ApiServicesHttpClient.Get<Root>(new Uri(CurrencyConst.Url));
            Console.WriteLine(currencyRates.ToString()); ;
        }
    }
}