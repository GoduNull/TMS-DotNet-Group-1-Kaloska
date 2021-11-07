﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Logic.Managers;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Managers;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Operations;
using TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Services;

namespace Logic.Services
{
    public class UiService
    {
        private static Dictionary<int, OperationBase> _operations = new Dictionary<int, OperationBase>();

        public UiService()
        {
            var allOperations = Assembly.GetAssembly(typeof(OperationBase)).GetTypes()
                .Where(t => typeof(OperationBase).IsAssignableFrom(t) && t.IsAbstract == false);

            foreach (var operation in allOperations)
            {
                OperationBase newOperation = Activator.CreateInstance(operation) as OperationBase;
                _operations.Add(newOperation.Id, newOperation);
            }
        }

        public async Task RunAsync()
        {
            List<OperationBase> operationList = _operations.Values.OrderBy(x => x.Id).ToList();
            try
            {
                var key = default(ConsoleKey);
                while (key != ConsoleKey.Q)
                {
                    Console.WriteLine("What do you want to see?");
                    foreach (var operation in operationList)
                    {
                        Console.WriteLine($"{operation.Id} ..." + operation.Name);
                    }
                    var isSuccess = int.TryParse(Console.ReadLine(), out int type);
                    if (isSuccess)
                    {
                        await _operations[type].ShowData();                      
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