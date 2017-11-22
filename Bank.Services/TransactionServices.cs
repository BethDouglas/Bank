using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class TransactionServices
    {
        public void TransactionAction(string transactionAction)
        {
            switch (transactionAction)
            {
                case "1":
                    Console.WriteLine("Please enter amount to withdrawl");
                    break;
                case "2":
                    Console.WriteLine("Please enter amount of deposit");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }

    }
}
