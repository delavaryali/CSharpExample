using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class DefaultImplementationsInInterfaces
    {
    }

    interface ILogger
    {
        void Log(string message);
        void Log(Exception exception) => Console.WriteLine(exception);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
