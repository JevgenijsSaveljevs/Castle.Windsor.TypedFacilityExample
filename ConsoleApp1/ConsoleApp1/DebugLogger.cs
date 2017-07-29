using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Code(Code = "Debug")]
    public class DebugLogger : ILogger
    {
        public void Log(string text)
        {
            Debug.WriteLine($"log from debugger: {text}");
        }
    }
}
