using System;
using System.Collections.Generic;
using CommonLibrary;

namespace BusinessLogic
{
    public class Order : EntityBase, ILoggable
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
        public override bool Validate()
        {
            var isValid = true;

            if (!OrderDate.HasValue) isValid = false;
            
            return isValid;
        }

        public override string ToString() => ($"{OrderDate} : {OrderId}");

        public string Log() => $"{OrderId} : {OrderDate} - CustomerID: {CustomerID} - Status: {EntityState}";
    }
}