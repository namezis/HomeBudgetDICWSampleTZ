using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.Domain.Repositories
{
    public abstract class AccountRepository
    {
        public abstract IEnumerable<Entities.Account> GetAllAccounts();
        public abstract Entities.Account GetAccountByName(string accountName);
        public abstract void AddAccount(Entities.Account account);
        public abstract void UpdateAccount(Entities.Account account);
        public abstract void DeleteAccount(Entities.Account account);       
    }
}
