using System;

namespace Resturant
{
    class Bill
    {
        private Order order;
        private Customer? customer;
        private Waiter? waiter;
        private double totalPrice = 0;
        public Bill(Order _order)
        {
            order = _order;
            CalcTotalPrice();

        }
        public Bill(Order order, Customer customer) : this(order)
        {
            this.customer = customer;
            CalcTotalPrice();

        }
        public Bill(Order order, Customer customer, Waiter waiter) : this(order, customer)
        {
            this.waiter = waiter;
            CalcTotalPrice();

        }
        public void CalcTotalPrice()
        {
            totalPrice = 0;
            for (int i = 0; i < order.itemsCount(); i++)
            {
                totalPrice += (order[i].Price * order[i].Amount);
            }
        }

        public void ShowBill()
        {
            order.ShowOrder();
            Console.WriteLine("".PadLeft(15) + $"{"|".PadRight(24)}The Total Price: {new string(totalPrice + " EGP").PadRight(31)}|");

            Console.WriteLine("".PadLeft(15) + "-------------------------------------------------------------------------");
        }
    }
}