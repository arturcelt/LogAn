using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    public class FakeWebService: IWebService
    {
        public string LastError;

        public void LogError(string message)
        {
            this.LastError = message;
        }
    }
}
