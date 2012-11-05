using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudget.Domain.Entities
{
    public class Receipt
    {
        public long ReceiptId { get; set; }
        public long AccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
