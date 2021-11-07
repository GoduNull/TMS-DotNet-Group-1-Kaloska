using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Managers;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Operations
{
    public class CurrencyOperation : OperationBase
    {
        public override int Id => 3;

        public override string Name => "Currency rate";

        public override async Task ShowData()
        {
            await CurrencyApiServiceManager.ShowCurrencyAsync();           
        }
    }
}
