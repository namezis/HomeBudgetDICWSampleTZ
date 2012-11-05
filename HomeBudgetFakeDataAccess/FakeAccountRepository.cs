using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.FakeDataAccess
{
    /// <summary>
    /// This class will allow to test the functionality of domain without any file or database, just keeping account data on a list.
    /// </summary>
    public class FakeAccountRepository : Domain.Repositories.AccountRepository
    {
        /// <summary>
        /// List of all accounts in current instance.
        /// </summary>
        private readonly List<Domain.Entities.Account> list = new List<Domain.Entities.Account>();

        /// <summary>
        /// Counter for the next account ID. This should imitate auto-increment in SQL database.
        /// </summary>
        private int nextAccountId = 1;

        /// <summary>
        /// Function for getting next account id.
        /// </summary>
        /// <returns></returns>
        private int GetNextAccountId()
        {
            return nextAccountId++;
        }

        /// <summary>
        /// Constructor with some sample data.
        /// </summary>
        public FakeAccountRepository()
        {
            // Sample data.
            AddAccount(new Domain.Entities.Account { AccountId = 0, AccountName = "Test1" });
            AddAccount(new Domain.Entities.Account { AccountId = 0, AccountName = "Test2" });
            AddAccount(new Domain.Entities.Account { AccountId = 0, AccountName = "Test3" });
            AddAccount(new Domain.Entities.Account { AccountId = 0, AccountName = "Test4" });
        }

        public override IEnumerable<Domain.Entities.Account> GetAllAccounts()
        {
            return list;
        }

        public override Domain.Entities.Account GetAccountByName(string accountName)
        {
            var account = (from item in list
                           where String.Compare(item.AccountName, accountName, true) == 0
                           select item).FirstOrDefault();

            return account;
        }

        public override void AddAccount(Domain.Entities.Account account)
        {
            list.Add(new Domain.Entities.Account { AccountId = GetNextAccountId(), AccountName = account.AccountName });
        }

        public override void UpdateAccount(Domain.Entities.Account account)
        {
            throw new NotImplementedException();
        }

        public override void DeleteAccount(Domain.Entities.Account account)
        {
            throw new NotImplementedException();
        }
    }
}
