using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.FakeDataAccess
{
    public class FakeReceiptRepository : Domain.Repositories.ReceiptRepository
    {

        /// <summary>
        /// List of all recipts in current instance.
        /// </summary>
        private readonly List<Domain.Entities.Receipt> list = new List<Domain.Entities.Receipt>();

        /// <summary>
        /// Counter for the next receipt ID. This should imitate auto-increment in SQL database.
        /// </summary>
        private int nextReceiptId = 1;

        /// <summary>
        /// Function for getting next receipt id.
        /// </summary>
        /// <returns></returns>
        private int GetNextReceiptId()
        {
            return nextReceiptId++;
        }

        /// <summary>
        /// Constructor with some sample data.
        /// </summary>
        public FakeReceiptRepository()
        {
            // Sample data.
            AddReceipt(new Domain.Entities.Receipt { ReceiptId = 0, Description = "Test1", Amount = 67.98M });
            AddReceipt(new Domain.Entities.Receipt { ReceiptId = 0, Description = "Test2", Amount = 123.58M });
            AddReceipt(new Domain.Entities.Receipt { ReceiptId = 0, Description = "Test3", Amount = 67.12M });
            AddReceipt(new Domain.Entities.Receipt { ReceiptId = 0, Description = "Test4", Amount = 567.78M });
        }

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
