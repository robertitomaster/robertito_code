using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense
{
    public class ExpenseCategory
    {
        public int ExpenseId { get; set; }


        public string Name { get; set; }


        public string Description { get; set; }


        public virtual Transaction Transaction { get; set; }

    }
}
