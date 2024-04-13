using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class ProductVariant 
    {
        private string Quantity;
        private double Price; 

        public int ProductID;

        public ProductVariant(int productID, string quantity, double price) : this(quantity, price)
        {
            ProductID = productID;
        }

        public ProductVariant(string quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public string GetQuantity()
        {
            return Quantity;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
