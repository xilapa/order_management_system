using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ProductRepository
    {
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
        public static IEnumerable<Product> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save the current product information
        /// </summary>
        /// <param name="productId"></param>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if(product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // code to insert data
                    }
                    else
                    {
                        // code to update data
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }

    }
}