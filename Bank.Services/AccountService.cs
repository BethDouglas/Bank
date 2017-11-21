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
        public bool CreateAccount(Account model)
        {
            var entity =
                new Account()
                {
                    AccountNumber = model.AccountNumber,
                    Pin = model.Pin,
                    AccountType = model.AccountType,
                    AccountBalance = model.AccountBalance
                };

            using (var ctx = new BankEntities())
            {
                ctx.Accounts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }






    }
}
