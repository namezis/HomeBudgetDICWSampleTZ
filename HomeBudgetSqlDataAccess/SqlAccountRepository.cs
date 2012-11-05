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
            return context.Accounts.AsEnumerable().OrderBy(p => p.AccountName).Select(p => p.ToDomainAccount());
        }

        public override Domain.Entities.Account GetAccountByName(string accountName)
        {
            throw new NotImplementedException();
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
