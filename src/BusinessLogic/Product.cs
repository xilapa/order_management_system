using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class Product : EntityBase
    {
        public Product()
        {
            PriceHistory = new List<Price>();
        }

        public Product(int productId) : this()
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
                return PriceHistory.Last().Value;
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
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (!CurrentPrice.HasValue) isValid = false;
            Console.WriteLine("price",CurrentPrice);
            
            return isValid;
        }
        
        public override string ToString() => Name;
    }
}