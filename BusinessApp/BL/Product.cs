using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    public class Product
    {
        public Product()
        {            
        }
        public Product(string productName, string productDescription, string productCategory, int price, int stock)
        {
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            Price = price;
            Stock = stock;
            AvailableQuantities = new List<string>();
        }

        private string ProductName;
        private string ProductDescription;
        private string ProductCategory;
        private int Price;
        private int Stock;
        private List<string> AvailableQuantities;

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

        public List<string> GetAvailableQuantities()
        {
            return AvailableQuantities;
        }

        public void SetAvailableQuantities(List<string> aq)
        {
            AvailableQuantities = aq;
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

        public void AddQuantity(string quantity)
        {
            AvailableQuantities.Add(quantity);
        }

        public string ReturnQuantityString()
        {
            string str = "";
            foreach (string record in AvailableQuantities)
            {
                str += record + ",";
            }
            return str.TrimEnd(',');
        }
    }
}
