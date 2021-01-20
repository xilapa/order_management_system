using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }  

        public Order(int orderId) : this ()
        {
            OrderId = orderId;
        }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerID { get; set; }
        public Address ShippingAddress { get; set; }

        public List<OrderItem> OrderItems { get; set; }


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
    }
}