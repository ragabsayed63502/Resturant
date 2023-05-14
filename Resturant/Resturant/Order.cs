using System;
using System.Collections.Generic;

namespace Resturant
{
    class Order
    {
        private readonly DateTime _date = DateTime.Now;
        static int Cnt = 3030;
        public int Id { get; }
        public string Date()
        {
            return _date.ToString("MM/dd/yyyy hh:mm tt");
        }
        private List<OrderItem> OrderList = new List<OrderItem>();

        public OrderItem this[int idx]
        {
            get
            {
                return OrderList[idx];
            }
        }

        public Customer? customer;
        public Order()
        {
            Id = Cnt++;
        }

        public Order(List<OrderItem> items)
        {
            Id = Cnt++;
            OrderList.AddRange(items);
        }

        public Order(List<OrderItem> items, Customer _customer)
        {
            Id = Cnt++;
            customer = _customer;
            OrderList.AddRange(items);
        }

        public Order(OrderItem item)
        {
            Id = Cnt++;
            OrderList.Add(item);
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderList.Add(orderItem);
        }

        public int itemsCount()
        {
            return OrderList.Count;
        }

        public void ShowOrder()
        {
            OrderList.Sort();

            Console.WriteLine("".PadLeft(15) + "-------------------------------------------------------------------------");
            Console.WriteLine("".PadLeft(15) + $"|{"Name".PadLeft(15)}{"|".PadLeft(11)} {"Price".PadLeft(10)}{"|".PadLeft(6)} {"Amount".PadRight(8).PadLeft(10)} | {"Total Price".PadLeft(12)} {"|".PadLeft(2)} ");
            Console.WriteLine("".PadLeft(15) + "-------------------------------------------------------------------------");
            for (int i = 0; i < OrderList.Count; i++)
            {
                Console.WriteLine("".PadLeft(15) + $"[{i + 1}] {OrderList[i]}");
            }
            Console.WriteLine("".PadLeft(15) + "-------------------------------------------------------------------------");


        }

    }
}