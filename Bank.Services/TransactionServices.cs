using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{
    public class TransactionServices
    {
        public void TransactionAction(string transactionAction, int accountNumber)
        {
            Account currentAccount = new AccountService().GetAccountById(accountNumber);

            switch (transactionAction)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Please enter amount to withdrawl");
                    int withdrawlAmount = Int32.Parse(Console.ReadLine());

                    decimal NewBalanceWithdrawl()
                    {
                        return currentAccount.AccountBalance - (decimal)withdrawlAmount;
                    }

                    Console.WriteLine(NewBalanceWithdrawl());
                    //TODO: update balance in database
                    Console.WriteLine($"Your new balance is:  ${NewBalanceWithdrawl()}");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please enter amount of deposit");
                    int depositAmount = Int32.Parse(Console.ReadLine());

                    decimal NewBalanceDeposit()
                    {
                        return currentAccount.AccountBalance - (decimal)depositAmount;
                    }

                    Console.WriteLine(NewBalanceDeposit());

                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine($"Your balance is:  ${new AccountService().GetAccountById(accountNumber).AccountBalance}");
                    Thread.Sleep(2000);
                    Console.WriteLine("Thank you, goodbye");
                    //TODO: change to go back to transaction choices
                    break;
                case "4":
                    //TODO: go back to beginning - while loop with continue?
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Thread.Sleep(2000);
                    Console.WriteLine("Goodbye");
                    Console.ResetColor();
                    //TODO:  change to go back to transaction choices
                    break;
            }
        }
    }
}
