using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    public class FakeLogger2: ILogger
    {
        public Exception WillThrow = null;
        public string LoggerGotMessage = null;

        public void LogError(string message)
        {
            LoggerGotMessage = message;
            if(WillThrow != null)
            {
                throw WillThrow;
            }
        }
    }
}
