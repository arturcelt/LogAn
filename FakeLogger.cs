using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    class FakeLogger : ILogger
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
