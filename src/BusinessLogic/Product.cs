using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Product
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Price> PriceHistory { get; private set; }
        public decimal? CurrentPrice 
        { 
            get 
            {
                return PriceHistory[-1].Value;
            }
        }

        /// <summary>
        /// Set a new price to the product
        /// </summary>
        /// <param name="date"></param>
        /// <param name="price"></param>
        public void SetPrice(decimal? price, DateTimeOffset? date = null)
        {
            var p = new Price();

            if (!price.HasValue) throw new ArgumentNullException($"{nameof(price)} is null");
            if (!date.HasValue) date = DateTimeOffset.Now;

            p.Value = price;
            p.Date = date;
            PriceHistory.Add(p);
        }


        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (!CurrentPrice.HasValue) isValid = false;
            
            return isValid;
        }

        /// <summary>
        /// Retrieve a product from ID
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieve a list with all products
        /// </summary>
        /// <returns></returns>
        public static List<Product> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save the current product information
        /// </summary>
        /// <param name="productId"></param>
        public void Save(int productId)
        {
            throw new NotImplementedException();
        }

    }
}