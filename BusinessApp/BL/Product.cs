using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Product
    {
        public Product()
        {            
        }
        public Product(string productName, string productDescription, string productCategory, int isAvailable)
        {
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            IsAvailable = isAvailable;
        }

        public Product(int id,string productName, string productDescription, string productCategory, int isAvailable)
        {
            ProductID = id;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            IsAvailable = isAvailable;
        }

        public Product(string productName, string productDescription, string productCategory, int isAvailable, List<ProductVariant> pv)
        {
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            IsAvailable = isAvailable;
            ProductVariants = pv;
        }

        public Product(int id,string productName, string productDescription, string productCategory, int isAvailable, List<ProductVariant> pv)
        {
            ProductID = id;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            IsAvailable = isAvailable;
            ProductVariants = pv;
        }

        private string ProductName;
        private string ProductDescription;
        private string ProductCategory;
        private int IsAvailable;
        private List<ProductVariant> ProductVariants = new List<ProductVariant>();

        private int ProductID;

        public string GetProductName()
        {
            return ProductName;
        }

        public int GetProductID()
        {
            return ProductID;
        }

        public string GetProductDescription()
        {
            return ProductDescription;
        }
        public string GetProductCategory()
        {
            return ProductCategory;
        }

        public int GetAvailable()
        {
            return IsAvailable;
        }

        public List<ProductVariant> GetProductVariants()
        {
            return ProductVariants;
        }

        public void SetAvailableQuantities(List<ProductVariant> aq)
        {
            ProductVariants = aq;
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

        public void AddQuantity(ProductVariant pv)
        {
            ProductVariants.Add(pv);
        }

        public void RemoveQuantity(ProductVariant pv)
        {
            ProductVariants.Remove(pv);
        }

        public void SetAvailable(int available)
        {
            IsAvailable = available;
        }
    }
}
