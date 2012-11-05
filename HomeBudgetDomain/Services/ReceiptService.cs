using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.Domain.Services
{
    public class ReceiptService
    {

        private readonly Repositories.ReceiptRepository repository;

        public ReceiptService(Repositories.ReceiptRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentException("repository");
            }
            this.repository = repository;
        }

        public Entities.Receipt GetReceiptById(long receiptId)
        {
            return GetReceiptById(receiptId);
        }

        public void AddReceipt(Entities.Receipt receipt)
        {
            repository.AddReceipt(receipt);
        }

        public void DeleteReceipt(Entities.Receipt receipt)
        {
            repository.DeleteReceipt(receipt);
        }

        public void UpdateReceipt(Entities.Receipt receipt)
        {
            repository.UpdateReceipt(receipt);
        }

        public IEnumerable<Entities.Receipt> GetReceiptsForAccount(string accountName)
        {
            return repository.GetReceiptsForAccount(accountName);
        }

        public IEnumerable<Entities.Receipt> GetReceiptsForAccount(long accountId)
        {
            return repository.GetReceiptsForAccount(accountId);
        }


    }
}
