using Logic.Services;
using System;
using System.Threading.Tasks;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Ui
{
    class Program
    {
        static async Task Main(string[] args)
        {
            UiService uiService = new UiService();
            await uiService.RunAsync();
        }
    }
}
