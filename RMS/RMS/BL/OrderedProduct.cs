using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class OrderedProduct
    {
        public OrderedProduct(Product product, string quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        private Product Product = new Product();
        private string Quantity;

        public void AddToCart(Product product, string quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public string GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(string quantity)
        {
            Quantity = quantity;
        }

        public Product GetProduct()
        {
            return Product;
        }

        public void SetProduct(Product product)
        {
            Product = product;
        }
    }
}
