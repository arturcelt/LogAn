using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    public class FakeWebService: IWebService
    {
        public Exception ToThrow;

        public void LogError(string message)
        {
            if(ToThrow != null)
            {
                throw ToThrow;
            }
        }
    }
}
