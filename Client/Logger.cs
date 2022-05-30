using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Logger
    {
        private readonly string format_T;
        public Logger(string TimeFormat)
        {
            format_T = TimeFormat;
        }

        public void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now.ToString(format_T)}:{msg}");
        }
    }
}
