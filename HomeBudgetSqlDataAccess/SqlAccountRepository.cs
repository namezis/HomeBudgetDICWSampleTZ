using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace HomeBudget.SqlDataAccess
{
    public class SqlAccountRepository : Domain.Repositories.AccountRepository
    {

        private readonly EF.HomeBudgetContainer context;

        public SqlAccountRepository()
        {
            string connHomeBudgetContainer = ConfigurationManager.ConnectionStrings["HomeBudgetContainer"].ConnectionString;

            if (connHomeBudgetContainer == null)
            {
                throw new ArgumentNullException("connHomeBudgetContainer");
            }

            this.context = new EF.HomeBudgetContainer(connHomeBudgetContainer);
        }

        public override IEnumerable<Domain.Entities.Account> GetAllAccounts()
        {
            var accounts = (from r in context.Accounts
                            orderby r.AccountName
                            select r).AsEnumerable();
            
            return from a in accounts
                   select a.ToDomainAccount();
        }

        public override Domain.Entities.Account GetAccountByName(string accountName)
        {
            var query = (from r in context.Accounts
                         where String.Compare(r.AccountName, accountName, true) == 0
                         select r).FirstOrDefault();

            Domain.Entities.Account retAccount = null;

            if (query != null)
            {
                retAccount = new Domain.Entities.Account();
                retAccount.AccountId = query.AccountId;
                retAccount.AccountName = query.AccountName;
            }

            return retAccount;
        }

        public override void AddAccount(Domain.Entities.Account account)
        {
            EF.Account efAccount = new EF.Account();
            efAccount.AccountName = account.AccountName;
            context.Accounts.AddObject(efAccount);
            context.SaveChanges();
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
