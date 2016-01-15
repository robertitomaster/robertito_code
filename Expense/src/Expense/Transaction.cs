using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Expense
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public virtual Account Account { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int ExpenseId { get; set; }
        public virtual ExpenseCategory ExpenseCategory { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime TransactionTime { get; set; }
        public int ReceiptId { get; set; }
        public virtual Receipt Recepit { get; set; }
    }

}
