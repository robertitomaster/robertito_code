using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense
{
    public class Transaction
    {
        public int Id { get; set; }

        public Account AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Description{ get; set; }
        public ExpenseCategory Category { get; set; }
        public User TransactionUser { get; set; }
        public DateTime TransactionTime { get; set; }
        public Receipt ReceiptId { get; set; }
    }
}
