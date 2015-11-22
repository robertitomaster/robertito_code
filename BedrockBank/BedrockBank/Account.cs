using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Account
    {
        #region Properties

        public string Name { get; set; }

        public int AccountNumber { get; set; }

        public decimal Balance { get; set; }

        #endregion

        #region Methods

        public decimal Deposit(decimal amount)
        {
            return 1.0M;
        }
        #endregion
    }
}
