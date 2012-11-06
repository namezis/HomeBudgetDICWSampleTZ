using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HomeBudget.XMLDataAccess
{
    public class XmlAccountRepository : Domain.Repositories.AccountRepository
    {

        private readonly string storageFile;

        public XmlAccountRepository()
        {
            const string cAppData = "|AppData|";
            string confStorageFile = System.Configuration.ConfigurationManager.AppSettings["StorageFile"];

            if (confStorageFile.Contains(cAppData))
            {
                string confStoragePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_data");
                confStorageFile = confStorageFile.Replace(cAppData, confStoragePath);
            }           
            
            if (confStorageFile != null)
            {
                storageFile = confStorageFile;
            }
            else
            {
                throw new ArgumentNullException("StorageFile");
            }
        }

        public override IEnumerable<Domain.Entities.Account> GetAllAccounts()
        {
            dsHomeBudget ds = ReadData();

            var query = from row in ds.Account
                        select row;

            List<Domain.Entities.Account> list = new List<Domain.Entities.Account>();

            foreach (var item in query)
            {
                list.Add(new Domain.Entities.Account { AccountId = item.AccountId, AccountName = item.AccountName });
            }            

            return list;                    
        }

        public override Domain.Entities.Account GetAccountByName(string accountName)
        {
            dsHomeBudget ds = ReadData();

            var query = (from row in ds.Account
                        where String.Compare(row.AccountName, accountName, true) == 0
                        select row).FirstOrDefault();

            if (query == null)
            {
                return null;
            }

            Domain.Entities.Account account = new Domain.Entities.Account();
            account.AccountId = query.AccountId;
            accountName = query.AccountName;
            
            return account;
        }

        public override void AddAccount(Domain.Entities.Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException("account");
            }

            dsHomeBudget ds = ReadData();

            dsHomeBudget.AccountRow row = ds.Account.NewAccountRow();
            row.AccountName = account.AccountName;
            ds.Account.AddAccountRow(row);

            SaveData(ds);
        }

        public override void UpdateAccount(Domain.Entities.Account account)
        {
            throw new NotImplementedException();
        }

        public override void DeleteAccount(Domain.Entities.Account account)
        {
            throw new NotImplementedException();
        }

        private dsHomeBudget ReadData()
        {
            if (!File.Exists(storageFile))
            {
                CreateEmptyStorage();
            }

            dsHomeBudget ds = new dsHomeBudget();
            ds.ReadXml(storageFile);
            return ds;
        }

        private void SaveData(dsHomeBudget ds)
        {
            ds.WriteXml(storageFile);
        }

        private void CreateEmptyStorage()
        {
            dsHomeBudget ds = new dsHomeBudget();
            ds.WriteXml(storageFile);
        }

    }
}
