using Logic.Services;
using System.Threading.Tasks;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Ui
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            UiService uiService = new UiService();
            await uiService.RunAsync();
        }
    }
}