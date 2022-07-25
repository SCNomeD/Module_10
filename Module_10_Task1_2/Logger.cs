using System;
using System.Threading;

namespace Module_10_Task1_2
{
    class Logger : ILogger
    {
        public void Error(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
            Thread.Sleep(1000);
        }

        public void Event(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
            Thread.Sleep(1000);
        }
    }
}
