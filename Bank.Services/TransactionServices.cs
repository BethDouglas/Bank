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
                    Console.WriteLine($"Your balance is:  ${new AccountService().GetAccountById(accountNumber).AccountBalance}");
                    Console.WriteLine("Please type your balance exactly as it appears above");
                    int balanceBeforeWithdrawl = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Thank you");
                    Console.WriteLine("Please enter amount to withdrawl");
                    int withdrawlAmount = Int32.Parse(Console.ReadLine());

                    int NewBalanceWinthdrawl(int balanceBeforeWithdrawl, int withdrawlAmount)
                    {
                        return balanceBeforeWithdrawl - withdrawlAmount;
                    }
                    //Console.WriteLine(NewBalanceWithdrawl);
                    //TODO: update balance in database
                    Console.WriteLine($"Your new balance is:  ${NewBalanceWithdrawl()}");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please enter amount of deposit");
                    //TODO: copy from withdrawl when its figured out
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


        //new AccountService().GetAccountById(accountNumber).AccountBalance = accountBalance;

        //public decimal NewBalanceWithdrawl(decimal accountBalance, decimal withdrawlAmount)
        //{
        //    return accountBalance - withdrawlAmount;
        //}

        //public decimal NewBalanceDeposit(decimal accountBalance, decimal depositAmount)
        //{
        //    return accountBalance + depositAmount;
        //}

    }
}
