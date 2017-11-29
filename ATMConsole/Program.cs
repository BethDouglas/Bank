using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bank.Services;
using Figgle;

namespace ATMConsole
{

    class Program 
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FiggleFonts.Standard.Render("Super  Fancy  ATM  !"));
            Console.ResetColor();

            Console.WriteLine("Please enter account number");
            int accountNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter PIN");
            int pin = Int32.Parse(Console.ReadLine());

            AuthServices authServies = new AuthServices();
            authServies.VerifyAccount(accountNumber, pin);

            Thread.Sleep(1000);
            Console.WriteLine("\nWhat would you like to do?\n" +
                 "1: Withdrawl\n" +
                 "2: Deposit\n" +
                 "3: Check Balance\n" +
                 "4: Cancel\n");

            TransactionServices transactionservices = new TransactionServices();
            transactionservices.TransactionAction(Console.ReadLine(), accountNumber);   


            // - - - - How to Get Name and account info from person typiong in Console-----
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

            //- - - - How to type in names and account info to enter into db----
            //CustomerService customerName = new CustomerService();
            //customerName.CreateCustomer("Person", "BoPerson");

            //AccountService account = new AccountService();
            //account.CreateAccount(888888, 8888, "Checking", 13000, 5);
        }
    }
}
