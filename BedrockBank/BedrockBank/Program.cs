using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bedrock Bank!");
            Console.Write("Please enter your Social Security Number:");
            var ssn = Console.ReadLine();
            var intSSN = 0;
            bool success = int.TryParse(ssn, out intSSN);

            if (success)
            {
                var accounts = BankFactory.GetAlllAccountsBySSN(intSSN);

                    if (accounts == null)
                    {
                    Console.WriteLine("No accounts");
                    }
                else
                {
                    foreach(var account in accounts)
                    {
                        Console.WriteLine("Account Number: {0}, Balance: {1:c}", account.AccountNumber, account.Balance);
                    }
                }
            }


        }
    }
}
