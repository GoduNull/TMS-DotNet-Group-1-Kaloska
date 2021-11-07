using System;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Services;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Managers
{
    public class CurrencyApiServiceManager
    {
        /// <summary>
        /// Shows currency rates async
        /// </summary>
        /// <returns></returns>
        public async static Task ShowCurrencyAsync()
        {
            CurrencyApiService apiService = new CurrencyApiService();
            var currencyRates = await apiService.GetCurrencyRate();
            Console.WriteLine(currencyRates.ToString()); ;
        }
    }
}