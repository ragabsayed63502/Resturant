using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant
{
    internal class MenuItem : IComparable
    {
        private static int Cnt = 1;
        public string Name { get; set; }
        public int Code { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public MenuItem()
        {
            Name = "";
            Price = 0;
            Code = Cnt++;
        }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
            Code = Cnt++;
        }

        public MenuItem(string name, double price, int code) : this(name, price)
        {
            Code = code;
        }

        public static bool operator ==(MenuItem a, MenuItem b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(MenuItem a, MenuItem b)
        {
            return a.Equals(b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is MenuItem)
            {
                return ((MenuItem)obj).Code == Code && ((MenuItem)obj).Price == Price && ((MenuItem)obj).Name == Name;
            }
            return false;
        }
        public int CompareTo(object? item)
        {
            if (item is MenuItem)
            {
                if (Price < ((MenuItem)item).Price)
                    return -1;
                else if (Price > ((MenuItem)item).Price)
                    return 1;
            }

            return 0;
        }
        public override string ToString()
        {
            return $"{Name.PadRight(22).PadLeft(22)}|  {Price.ToString().PadLeft(5)} {"EGP".PadRight(7)} |";

        }
    }
}
