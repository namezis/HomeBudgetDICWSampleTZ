using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.XMLDataAccess
{
    public class XmlReceiptRepository : Domain.Repositories.ReceiptRepository
    {
        public override Domain.Entities.Receipt GetReceiptById(long receiptId)
        {
            throw new NotImplementedException();
        }

        public override void AddReceipt(Domain.Entities.Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public override void DeleteReceipt(Domain.Entities.Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public override void UpdateReceipt(Domain.Entities.Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Domain.Entities.Receipt> GetReceiptsForAccount(string accountName)
        {
            return null;
        }

        public override IEnumerable<Domain.Entities.Receipt> GetReceiptsForAccount(long accountId)
        {
            return null;
        }
    }
}
