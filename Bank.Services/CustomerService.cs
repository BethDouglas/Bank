using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{
    public class CustomerService
    {

        public bool CreateCustomer(string firstName, string lastName)
        {
            var entity =
                new Customer()
                {
                    LastName = lastName,
                    FirstName = firstName
                };
            using (var ctx = new BankEntities())
            {
                ctx.Customers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public string CustomerName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

             
    }
}
