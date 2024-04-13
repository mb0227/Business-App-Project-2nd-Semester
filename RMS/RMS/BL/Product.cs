﻿using System;
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

        public Product(int id, string productName, string productDescription, string productCategory, int isAvailable) : this(productName, productDescription, productCategory, isAvailable)
        {
            ProductID = id;
        }

        public Product(int id, string productName, string productCategory, double price, string quantity)
        {
            ProductID = id;
            ProductName = productName;
            ProductCategory = productCategory;
            Price = price;
            Quantity = quantity;
        }

        private string ProductName;
        private string ProductDescription;
        private string ProductCategory;
        private int IsAvailable;
        private List<ProductVariant> ProductVariants = new List<ProductVariant>();

        private int ProductID;
        private double Price;//for customers
        private string Quantity;

        public string GetQuantity()
        {
            return Quantity;
        }

        public double GetPrice()
        {
            return Price;
        }

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