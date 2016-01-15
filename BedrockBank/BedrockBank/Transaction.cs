using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public enum TransactionType
    {
        Credit,
        Debit
    }
    public class Transaction
    {

        [Key]
        public int TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public int AccountNumber { get; set; }
        public virtual Account Account { get; set; }

    }
}
