using System;
using System.Threading.Tasks;
using Logic.Managers;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Services;

namespace Logic.Services
{
    public class UiService
    {
        public async Task RunAsync()
        {
            try
            {
                var key = default(ConsoleKey);
                while (key != ConsoleKey.Q)
                {
                    Console.WriteLine("What do you want to see?\n1 - News." +
                        "\n2 - Weather forecast." +
                        "\n3 - Currency rates.");
                    var isSuccess = int.TryParse(Console.ReadLine(), out int type);
                    if (isSuccess)
                    {
                        switch (type)
                        {
                            case 1:
                                {
                                    await NewsApiServiceManager.ShowNewsAsync();
                                    break;
                                }
                            case 2:
                                {
                                    await WeatherUiService.RunAsync();
                                    break;
                                }
                            default:
                                {
                                    IncorrectChoice();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        IncorrectChoice();
                    }

                    Console.WriteLine("Press Q to quit..");
                    Console.Write("Press enter to continue..\n");
                    key = Console.ReadKey().Key;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void IncorrectChoice()
        {
            Console.WriteLine("Incorrect choice");
        }
    }
}