using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW1_logger1
{
    class Logger
    {
        private Logger()
        {

        }
        private static Logger instance;
        private static List<string> LogMessages = new List<string>();
        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public string NewMessage(string MessageLevel, Exception ex)
        {
            string result = $"{MessageLevel}, Action failedby reason: {ex.StackTrace}";
            LogMessages.Add(result);
            return result;
        }

        public string NewMessage(string MessageLevel, string Message)
        {
            string result = $"{MessageLevel}, Message: {Message}";
            LogMessages.Add(result);
            return result;
        }
    }
}
