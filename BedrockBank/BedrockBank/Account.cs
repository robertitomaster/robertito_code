using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public class Account
    {
        #region Variables

        private static int lastAccountNumber = 0;

        #endregion

        #region Properties

        public string Name { get; set; }

        public int AccountNumber { get; private set; }

        public int SSN { get; set; }

        public decimal Balance { get; private set; }



        #endregion

        #region Methods

        public decimal Deposit(decimal amount)
        {
           return  Balance += amount;
        }

        /// <summary>
        /// This method removes money from the account
        /// </summary>
        /// <param name="amount">amount to retire</param>
        /// <returns>The new balance</returns>
        /// <exception>ArgumentException</exception>
        public decimal Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("The amount to retire is bigger than the balance");

                throw new ArgumentException("There are no sufficient funds");
            }


            return Balance -= amount;
            
        }
        #endregion

        #region Costructor

        
        public Account()
        {
            
            AccountNumber = ++lastAccountNumber;

        }

        public Account(string name):this()
        {
            Name = name;
        }

        public Account(string accountName, decimal accountBalance):this(accountName)
        {
            this.Deposit(accountBalance);
        }
        #endregion
    }
}
