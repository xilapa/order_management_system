using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve a order from ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieve a list with all orders
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Order> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save the current order information
        /// </summary>
        /// <param name="orderId"></param>
        public bool Save(Order order)
        {
            throw new NotImplementedException();
        }

    }
}