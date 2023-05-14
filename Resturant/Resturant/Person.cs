using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant
{
    abstract class Person
    {
        private static int Cnt = 1;
        private string name;
        private  string ssn;

        public string Name { get; set; }

        public string SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                ssn = value;
            }
        }
        public string? Phone { get; set; }
        public Address? Address { get; set; }

        public Person()
        {
           
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, string phone, Address? address) : this(name)
        {
            Phone = phone;
            Address = address;
        }


        public override string ToString()
        {
            return "".PadLeft(10) + $"Name : {Name}\n" +
                   (Phone == null ? "" : $"Phone : {Phone}\n") +
                   $"SSN : {SSN}\n" +
                   Address;
        }
    }
}
