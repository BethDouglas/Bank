using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Services;

namespace ATMConsole
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter account number");
            int accountNumber = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Enter PIN");
            int pinNumber = Int32.Parse(Console.ReadLine());

            //TODO - check pin and account number and retrieve name
            Console.Clear();

            Console.WriteLine(${"Hello" + ");





            CustomerService customerName = new CustomerService();
            customerName.CreateCustomer("Mr.", "Person");
        }






    }
}
