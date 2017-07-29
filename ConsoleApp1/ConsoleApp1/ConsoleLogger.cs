using System;

namespace ConsoleApp1
{
    [Code(Code = "Console")]
    public class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine($"hello from - {this.GetType().Name} message: {text}");
        }
    }
}
