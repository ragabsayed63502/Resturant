using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant
{
    class Address
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

        public Address()
        {

        }
        public Address(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }
       
        public override string ToString()
        {
            return $"Address : {Country}, {City}, {Street}\n";
        }
    }
}
