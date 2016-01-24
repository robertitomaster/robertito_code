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
            var loginattempts = 3;
            var isLoginSuccessful = false;
            Console.WriteLine("***Welcome to Bedrock Bank!***");
            Console.Write("Please enter your Social Security Number:");
            var ssn = Console.ReadLine();
            int convertedSSN;

            while (loginattempts > 0 && !isLoginSuccessful)
            {
                
                if (int.TryParse(ssn, out convertedSSN) == true)
                {
                    isLoginSuccessful = true;
                    var accounts = BankFactory.GetAllAccountsBySSN(convertedSSN);

                    if (accounts.Count() == 0)
                    {
                        Console.WriteLine("No accounts found for {0}.", convertedSSN);

                        Console.Write("Do you want to create one? (y/n)");

                        var choice = Console.Read();

                        if (choice == 89 || choice == 121)
                        {
                            Console.WriteLine("What is your name?");
                            var name = Console.ReadLine();
                            var outAccount = BankFactory.CreateAccount(name, convertedSSN);
                            var accountBalanceafterdeposit = BankFactory.Deposit(outAccount.AccountNumber, 100.00M);
                            Console.WriteLine("Account Number: {0} and Balance: {1} ", outAccount.AccountNumber, accountBalanceafterdeposit);
                        }
                        
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

                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Withdraw");
                        Console.WriteLine("0. Exit");

                        var choice = Console.Read();
                        if(choice == 1 || choice == 2)
                        {
                            Console.Write("Account Number Please: ");
                            var accountNo = Console.ReadLine();
                            Console.Write("");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a correct value!");

                }
            }
        }
    }
}
