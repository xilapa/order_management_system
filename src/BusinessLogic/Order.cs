using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Order
    {
        public Order()
        {
            
        }  

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (!OrderDate.HasValue) isValid = false;
            
            return isValid;
        }

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
        public static List<Order> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save the current order information
        /// </summary>
        /// <param name="orderId"></param>
        public void Save(int orderId)
        {
            throw new NotImplementedException();
        }

    }
}