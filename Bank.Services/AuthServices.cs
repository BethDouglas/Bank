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
                return true;
            }

            Console.WriteLine("Account and PIN do not match :(");
            return false;
           
        }




        //public void login()
        //{
        //    var db = new BankEntities();

        //    AccountService account = (from u in db.Accounts
        //                              where u.AccountNumber.Equals(accountNumber) &&
        //                                    u.Pin.Equals(pin)
        //                               select u).FirstorDefault();

        //    if (account == null)
        //    {
        //        Console.WriteLine("Invalid Account # or PIN.");
        //    }

        //    else
        //    {
        //        Console.WriteLine("Welcome!");
        //    }


        //}
        
            
    }
}
