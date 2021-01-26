using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    public class FakeWebService: IWebService
    {
        public string MessageToWebService;

        public void Write(ErrorInfo errorInfo)
        {
            MessageToWebService = errorInfo.Message;
        }

        
    }
}
