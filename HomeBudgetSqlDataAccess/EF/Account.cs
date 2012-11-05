using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.SqlDataAccess.EF
{
    public partial class Account
    {

        public Domain.Entities.Account ToDomainAccount()
        {
            Domain.Entities.Account account = new Domain.Entities.Account();
            account.AccountId = this.AccountId;
            account.AccountName = this.AccountName;
            return account;
        }

    }
}
