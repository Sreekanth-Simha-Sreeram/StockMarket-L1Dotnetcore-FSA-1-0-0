using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Tests.Exceptions
{
    class CompanyNotFoundException : StockMarketException
    {
        public string Messages = "Company Not Found in Tasks List";

        public CompanyNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
