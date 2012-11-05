using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.SqlDataAccess.EF
{
    public partial class Receipt
    {
        public Domain.Entities.Receipt ToDomainReceipt()
        {
            Domain.Entities.Receipt receipt = new Domain.Entities.Receipt();
            receipt.ReceiptId = this.ReceiptId;
            receipt.Amount = this.Amount;
            receipt.Description = this.Description;
            return receipt;
        }
    }
}
