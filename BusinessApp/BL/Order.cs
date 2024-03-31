using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    public class Order
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
        public Order(int orderID,List<OrderedProduct> products, OrderStatus orderStatus, DateTime orderDate, string customerComments, string customerName)
        {
            OrderID = orderID;
            ProductsOrdered = products;
            Status = orderStatus;
            OrderDate = orderDate;
            CustomerComments = customerComments;
            CalculateTotalPrice();
            CustomerName = customerName;
        }

        private int OrderID;
        private List <OrderedProduct> ProductsOrdered =  new List<OrderedProduct>();
        private int TotalPrice;
        private OrderStatus Status;
        private DateTime OrderDate;
        private string CustomerComments;
        private string CustomerName;    

        private void CalculateTotalPrice()
        {
            TotalPrice = 0;
            for(int i=0;i< ProductsOrdered.Count;i++)
            {
                TotalPrice += ProductsOrdered[i].GetQuantity() * ProductsOrdered[i].GetProduct().GetPrice();
            }
        }

        public void AddProduct(Product product, int quantity)
        {
            ProductsOrdered.Add(new OrderedProduct(product, quantity));
            CalculateTotalPrice();
        }

        public void RemoveProduct(Product product, int quantity)
        {
            ProductsOrdered.Remove(new OrderedProduct(product, quantity));
            CalculateTotalPrice();
        }

        public int GetOrderID()
        {
            return OrderID;
        }

        public List<OrderedProduct> GetProducts()
        {
            return ProductsOrdered;
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

        public void SetProducts(List<OrderedProduct> products)
        {
            ProductsOrdered = products;
            CalculateTotalPrice();
        }
    }
}
