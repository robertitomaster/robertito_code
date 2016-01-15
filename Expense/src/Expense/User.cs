using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Expense
{
    public class User
    {
        [Key]
        public int UserID { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string PhoneNumber { get; set; }


        public string Address { get; set; }


        public string City { get; set; }


        public string State { get; set; }


        public virtual Transaction Transaction { get; set; }

    }
}
