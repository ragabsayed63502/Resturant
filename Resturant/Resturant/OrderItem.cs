using System;

namespace Resturant
{
    class OrderItem : IComparable
    {

        private MenuItem item;
        public readonly double Price; // if there is a sale on this item use set
        private int amount;
        //public double TotalPrice;

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                // TotalPrice = Price * amount;
            }
        }
        private readonly DateTime _date = DateTime.Now;
        public string Date()
        {
            return _date.ToString("MM/dd/yyyy hh:mm tt");
        }

        public OrderItem(MenuItem _item)
        {

            item = _item;
            Price = item.Price;
        }

        public OrderItem(MenuItem _item, int _amount)
        {
            item = _item;
            Price = item.Price;
            Amount = _amount;
        }
        public override string ToString()
        {
            return $"{item.Name.PadRight(22).PadLeft(22)}|  {Price.ToString().PadLeft(5)} {"EGP".PadRight(7)} |" + $" {Amount.ToString().PadLeft(6) + "".PadRight(4)}" +
                $" | {(Price * amount).ToString().PadLeft(6)} {"EGP".PadRight(6)} |";
        }

        public static bool operator ==(OrderItem a, OrderItem b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(OrderItem a, OrderItem b)
        {
            return a.Equals(b);
        }
        public override bool Equals(object? obj)
        {
            if (obj is OrderItem)
                return ((OrderItem)obj).item == item;
            return base.Equals(obj);
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


    }
}