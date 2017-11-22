using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{
     public class AuthServices
    {

        private BankEntities db = new BankEntities();

        public bool VerifyAccount(int accountNumber, int pin)
        {
            var query = from a in db.Accounts
                        where a.AccountNumber == accountNumber &&
                              a.Pin == pin
                        select a;

            foreach (var acc in query)
            {
                Console.WriteLine("Hello!");
                //TODO - add in customer name
                return true;
            }

            Console.WriteLine("Account and PIN do not match :(");
            return false;
           
        }       
    }
}
