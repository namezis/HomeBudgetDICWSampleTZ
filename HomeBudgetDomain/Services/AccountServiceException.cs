using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.Domain.Services
{
    public class AccountServiceException : Exception
    {
        public AccountServiceException(string message) : base(message)
        {        
        }
    }
}
