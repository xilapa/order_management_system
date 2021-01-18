using System;

namespace BusinessLogic
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (!PurchasePrice.HasValue) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;
            
            return isValid;
        }

        /// <summary>
        /// Retrieve a order item from ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save the current order item information
        /// </summary>
        /// <param name="orderId"></param>
        public void Save(int orderId)
        {
            throw new NotImplementedException();
        }

    }
}