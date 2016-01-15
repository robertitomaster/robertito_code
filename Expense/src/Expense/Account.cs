using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Expense
{
    public class Account
    {
        [Key]
        public int AccountNumber { get; set; }
        public int RoutingNumber { get; set; }
        public string IntitutionName { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }

    }
}
