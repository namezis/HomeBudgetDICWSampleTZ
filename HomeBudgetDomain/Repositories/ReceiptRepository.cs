using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.Domain.Repositories
{
    public abstract class ReceiptRepository
    {
        public abstract Entities.Receipt GetReceiptById(long receiptId);
        public abstract void AddReceipt(Entities.Receipt receipt);
        public abstract void DeleteReceipt(Entities.Receipt receipt);
        public abstract void UpdateReceipt(Entities.Receipt receipt);
        public abstract IEnumerable<Entities.Receipt> GetReceiptsForAccount(string accountName);
        public abstract IEnumerable<Entities.Receipt> GetReceiptsForAccount(long accountId);
    }
}
