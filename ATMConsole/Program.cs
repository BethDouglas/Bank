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
            //Console.WriteLine("Please enter account number");
            //int accountNumber = Int32.Parse(Console.ReadLine());


            //Console.WriteLine("Enter PIN");
            //int pin = Int32.Parse(Console.ReadLine());

            //TODO - check pin and account number and retrieve name
            //Console.Clear();

            //Console.WriteLine(${"Hello {customerName}");

            // - - - - Get Name from person typiong in Console-----
            //Console.WriteLine("Tell you first name:");
            //string first = Console.ReadLine();
            //Console.WriteLine("What is your last name");
            //string last = Console.ReadLine();
            // CustomerService customerName = new CustomerService();
            //customerName.CreateCustomer(first,last);

            //Console.WriteLine("Please choose a 6 digit account number");
            //int accountNumber = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Please choose a 4 digit PIN");
            //int pin = Int32.Parse(Console.ReadLine());

            //--Type in names to enter into db--
            //CustomerService customerName = new CustomerService();
            //customerName.CreateCustomer("Person", "BoPerson");

            AccountService accountNumber = new AccountService();
            accountNumber.CreateAccount(123456);

        }

    }
}
