using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class TransactionServices
    {
        public void TransactionAction(string transactionAction, int accountNumber)
        {
            switch (transactionAction)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Please enter amount to withdrawl");
                    int withdrawlAmount = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Your new balance is: ");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please enter amount of deposit");
                    //copy from withdrawl when its figured out
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine($"Your balance is:  ${new AccountService().GetAccountById(accountNumber).AccountBalance}");
                    Thread.Sleep(2000);
                    Console.WriteLine("Thank you, goodbye");
                    break;
                case "4":
                    //go back to beginning
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Thread.Sleep(2000);
                    Console.WriteLine("Goodbye");
                    Console.ResetColor();
                    //go back to transaction choices
                    break;
            }
        }


        public double NewBalanceWithdrawl(double accountBalance, int withdrawlAmount)
        {
            return accountBalance - withdrawlAmount;
        }

        public double NewBalanceDeposit(double accountBalance, int depositAmount)
        {
            return accountBalance + depositAmount;
        }

    }
}
