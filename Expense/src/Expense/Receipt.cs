using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Expense
{
    public class Receipt
    {
        [Key]
        public int ReceiptID { get; set; }


        public string ReceiptURL { get; set; }


        public virtual Transaction Transaction { get; set; }

    }
}
