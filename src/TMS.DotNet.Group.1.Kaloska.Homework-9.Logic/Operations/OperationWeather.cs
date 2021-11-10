using System.Threading.Tasks;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Services;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Operations
{
    public class OperationWeather : OperationBase
    {
        public override int Id => 2;

        public override string Name => "Weather forecast";

        public override async Task ShowData()
        {
            await WeatherUiService.RunAsync();
        }
    }
}