using System.Collections.Generic;

namespace Resturant
{
    class Waiter : Person
    {
        private List<Order> CustomerOrders = new List<Order>();

        public void TakeOrder(Order newOrder)
        {
            CustomerOrders.Add(newOrder);
        }
        public bool CancelOrder(Order newOrder)
        {
            return CustomerOrders.Remove(newOrder);
        }
        public bool CancelOrder(int OrderId)
        {
            for (int i = 0; i < CustomerOrders.Count; i++)
            {
                if (CustomerOrders[i].Id == OrderId)
                    return CustomerOrders.Remove(CustomerOrders[i]);
            }
            return false;
        }

    }
}