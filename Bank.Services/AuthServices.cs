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
                Console.WriteLine("Hello, I don't know your name yet.");
                //TODO - add in customer name
                return true;
            }

            Console.WriteLine("Account and PIN do not match :(");
            //TODO - go back to beginning
            return false;
           
        }

        //public string CurrentCustomerName(string firstName, string lastName)
        //{
        //var query = from a in db.Accounts

        //}


        //CustomerServices cusotmerServies = new CustomerServices();
        //customerServies.CustomerName(firstName, lastName);
    }
}
