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
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please enter amount of deposit");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(new AccountService().GetAccountById(accountNumber).AccountBalance);
                    Thread.Sleep(2000);
                    Console.WriteLine("Thank you, goodbye");
                    break;
                case "4":
                    //go back to beginning
                    break;
                default:
                    Console.WriteLine("Error");
                    Thread.Sleep(2000);
                    Console.WriteLine("Goodbye");
                    //go back to transaction choices
                    break;
            }
        }

    }
}
