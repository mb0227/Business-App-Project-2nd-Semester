using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    internal class Order
    {
        public enum OrderStatus
        {
            Pending,
            Processing,
            Shipped,
            Delivered,
            Cancelled,
            OnHold,       
            Refunded      
        }

        public Order()
        {            
        }
        public Order(int orderID,List<Product> products, OrderStatus orderStatus, DateTime orderDate, string customerComments, string customerName)
        {
            OrderID = orderID;
            Products = products;
            Status = orderStatus;
            OrderDate = orderDate;
            CustomerComments = customerComments;
            CalculateTotalPrice();
            CustomerName = customerName;
        }

        private int OrderID;
        private List<Product> Products =  new List<Product>();
        private int TotalPrice;
        private OrderStatus Status;
        private DateTime OrderDate;
        private string CustomerComments;
        private string CustomerName;    

        private void CalculateTotalPrice()
        {
            TotalPrice = 0;
            foreach (Product product in Products)
            {
                TotalPrice += product.GetPrice();
            }
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            CalculateTotalPrice();
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
            CalculateTotalPrice();
        }

        public int GetOrderID()
        {
            return OrderID;
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public int GetTotalPrice()
        {
            return TotalPrice;
        }

        public OrderStatus GetStatus()
        {
            return Status;
        }

        public DateTime GetOrderDate()
        {
            return OrderDate;
        }

        public string GetCustomerComments()
        {
            return CustomerComments;
        }

        public string GetCustomerName()
        {
            return CustomerName;
        }

        public void SetCustomerName(string customerName)
        {
            CustomerName = customerName;
        }

        public void SetStatus(OrderStatus status)
        {
            Status = status;
        }

        public void SetOrderID(int orderID)
        {
            OrderID = orderID;
        }

        public void SetOrderDate(DateTime orderDate)
        {
            OrderDate = orderDate;
        }

        public void SetCustomerComments(string customerComments)
        {
            CustomerComments = customerComments;
        }

        public void SetProducts(List<Product> products)
        {
            Products = products;
            CalculateTotalPrice();
        }
    }
}
