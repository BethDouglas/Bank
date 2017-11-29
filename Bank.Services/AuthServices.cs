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
                //TODO - add in customer name - get account by id, then get customer id, then get name from customer table
                return true;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Account and PIN do not match :(");
            Console.ResetColor();
            //TODO - go back to re-enter account/pin - don't go to choices (this still goes into account even if pin is not right)
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
