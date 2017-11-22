using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{

    public class AccountService
    {

        public bool CreateAccount(int accountNumber, int pin, string accountType, decimal accountBalance, int customerID)
        {
            var entity =
                new Account()
                {
                    AccountNumber = accountNumber,
                    Pin = pin,
                    AccountType = accountType,
                    AccountBalance = accountBalance,
                    CustomerID = customerID
                };
            using (var ctx = new BankEntities())
            {
                ctx.Accounts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public Account GetAccountById(int accountNumber)
        {
            return
                new BankEntities()
                    .Accounts
                    .SingleOrDefault(e => e.AccountNumber == accountNumber);
        }
    }
}
        //TODO - HOW TO WRITE THING IN PROGRAM TO CREATE ACCOUNT IF IT"S WRITTEN THIS WAY?
        //public bool CreateAccount(Account model)
        //{
            //var entity =
                //new Account()
                //{
                    //AccountNumber = model.AccountNumber,
                    //Pin = model.Pin,
                    //AccountType = model.AccountType,
                    //AccountBalance = model.AccountBalance,
                    //CustomerID = model.CustomerID
                //};


