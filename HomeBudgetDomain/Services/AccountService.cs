using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.Domain.Services
{
    public class AccountService
    {

        private readonly Repositories.AccountRepository repository;

        public AccountService(Repositories.AccountRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentException("repository");
            }
            this.repository = repository;
        }

        /// <summary>
        /// Add new account to the list of accounts.
        /// </summary>        
        /// <param name="account">Required is AccountName.</param>
        public void AddAccount(Entities.Account account)
        {
            // Account record must be provided.
            if (account == null)
            {
                throw new AccountServiceException("Account record must be provided.");
            }

            // Account name must not be null or empty string.
            if (String.IsNullOrEmpty(account.AccountName))
            {
                throw new AccountServiceException("Account name must be provided.");
            }

            // Account with this name must not exist.
            if (repository.GetAccountByName(account.AccountName) == null)
            {
                repository.AddAccount(account);
            }
            else
            {
                throw new AccountServiceException("Account with this name already exist.");
            }            
        }

        public void UpdateAccount(Entities.Account account)
        {
            repository.UpdateAccount(account);
        }

        public void DeleteAccount(Entities.Account account)
        {
            repository.DeleteAccount(account);
        }

        public IEnumerable<Entities.Account> GetAllAccounts()
        {
            return repository.GetAllAccounts();
        }

        public Entities.Account GetAccountByName(string accountName)
        {
            return repository.GetAccountByName(accountName);
        }               
    }
}
