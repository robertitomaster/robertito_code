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
            int convertedSSN;

            Console.WriteLine("Verifying your SSN");

            if (int.TryParse(ssn, out convertedSSN) == true)
            {

                    var accounts = BankFactory.GetAllAccountsBySSN(convertedSSN);

                    if (accounts.Count() == 0)
                    {
                        Console.WriteLine("No accounts found for {0}", convertedSSN);

                        Console.WriteLine("But give me your name and account will be created:");

                        var newaccountuser = Console.ReadLine();

                        var outAccount = BankFactory.CreateAccount(newaccountuser, convertedSSN);

                        Console.WriteLine("The account number is {0}", outAccount.AccountNumber);
                        Console.WriteLine("Maiking a deposit of {0:c} to your account as a welcome.", 100.00);

                        BankFactory.Deposit(outAccount.AccountNumber, 100.00M);
                    }
                    else
                    {
                        foreach (var account in accounts)
                        {
                            Console.WriteLine("Account Number: {0}, Balance: {1:c}", account.AccountNumber, account.Balance);

                            Console.Write("Please make a deposit, how much?:");

                            var depositamount = Console.ReadLine();

                            decimal outamount;

                           if (decimal.TryParse(depositamount, out outamount))
                            {

                               BankFactory.Deposit(account.AccountNumber, outamount);
                            }

                        }
                    }
            }
        }
    }
}
