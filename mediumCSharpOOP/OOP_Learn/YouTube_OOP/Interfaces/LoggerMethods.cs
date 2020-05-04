using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class LoggerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Looged customer added!");
        }
    }

    class DatabaseLogger : Interfaces.ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : Interfaces.ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger : Interfaces.ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }
}
