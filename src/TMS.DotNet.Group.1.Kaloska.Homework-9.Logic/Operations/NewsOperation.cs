using Logic.Managers;
using System.Threading.Tasks;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Operations
{
    public class NewsOperation : OperationBase
    {
        public override int Id => 1;

        public override string Name => "News";

        public override async Task ShowData()
        {
            await NewsApiServiceManager.ShowNewsAsync();
        }
    }
}