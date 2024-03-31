using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    public class Product
    {
        public Product(string productName, string productDescription, string productCategory, int price, int stock)
        {
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            Price = price;
            Stock = stock;
        }

        private string ProductName;
        private string ProductDescription;
        private string ProductCategory;
        private int Price;
        private int Stock;

        public void UpdateStock(string operation, int quantity)
        {
            if (operation == "add")
            {
                Stock += quantity;
            }
            else if (operation == "remove")
            {
                Stock -= quantity;
            }
        }

        public bool StockAvailable(int quantity)
        {
            if (quantity > Stock)
            {
                return false;
            }
            return true;
        }

        public string GetProductName()
        {
            return ProductName;
        }

        public string GetProductDescription()
        {
            return ProductDescription;
        }
        public string GetProductCategory()
        {
            return ProductCategory;
        }

        public int GetPrice()
        {
            return Price;
        }

        public int GetStock()
        {
            return Stock;
        }

        public void SetPrice(int price)
        {
            Price = price;
        }

        public void SetStock(int stock)
        {
            Stock = stock;
        }

        public void SetCategory(string category)
        {
            ProductCategory = category;
        }

        public void SetDescription(string description)
        {
            ProductDescription = description;
        }

        public void SetProductName(string productName)
        {
            ProductName = productName;
        }
    }
}
