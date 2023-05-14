using System;
using cw = System.Console;
namespace Resturant
{
    class Customer : Person
    {
        public Customer()
        {

        }

        public Customer(string name, int id) : base(name)
        {

        }
        public static Customer CreateCustomer()
        {
            Customer customer = new Customer();
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.WriteLine("".PadLeft(20) + "Enter you information");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            customer.Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("".PadLeft(20) + "Phone: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            customer.Phone = Console.ReadLine();
            return customer;
        }
    }
}