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
        public bool CreateAccount(int accountNumber, int pinNumber, string accountType, double accountBalance)
        {
            var entity =
                new Account()
                {
                    AccountNumber = accountNumber
                };
            using (var ctx = new BankEntities())
            {
                ctx.Accounts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }






    }
}
