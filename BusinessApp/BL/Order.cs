using SSC.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace RMS.BL
{
    public class Order
    {
        public enum OrderStatus
        {
            Pending,
            Prepared,
            PickedUp,
            Delivered,
            Cancelled
        }

        public Order()
        {            
        }

        public Order(List<OrderedProduct> products, OrderStatus orderStatus, DateTime orderDate, string customerComments, string paymentMethod, int id)
        {
            ProductsOrdered = products;
            Status = orderStatus;
            OrderDate = orderDate;
            CustomerComments = customerComments;
            CalculateTotalPrice();
            CustomerID = id;
            PaymentMethod = paymentMethod;
        }

        public Order(double discount,List<OrderedProduct> products, OrderStatus orderStatus, DateTime orderDate, string customerComments, string paymentMethod, int id)
        {
            ProductsOrdered = products;
            Status = orderStatus;
            OrderDate = orderDate;
            CustomerComments = customerComments;
            CalculateTotalPrice(discount);
            CustomerID = id;
            PaymentMethod = paymentMethod;
        }

        public Order(List<OrderedProduct> products, OrderStatus orderStatus, DateTime orderDate, string customerComments, string paymentMethod)
        {
            ProductsOrdered = products;
            Status = orderStatus;
            OrderDate = orderDate;
            CustomerComments = customerComments;
            CalculateTotalPrice();
            PaymentMethod = paymentMethod;
        }

        public Order(int orderID,List<OrderedProduct> products, OrderStatus orderStatus, DateTime orderDate, string customerComments, int id, string paymentMethod)
        {
            OrderID = orderID;
            ProductsOrdered = products;
            Status = orderStatus;
            OrderDate = orderDate;
            CustomerComments = customerComments;
            CalculateTotalPrice();
            CustomerID = id;
            PaymentMethod = paymentMethod;
        }

        private int OrderID;
        private List <OrderedProduct> ProductsOrdered =  new List<OrderedProduct>();
        private double TotalPrice;
        private OrderStatus Status;
        private DateTime OrderDate;
        private string CustomerComments;
        private int CustomerID;
        private string PaymentMethod;


        public string GetProductsString()
        {
            StringBuilder cartString = new StringBuilder();

            foreach (var orderedProduct in ProductsOrdered)
            {
                cartString.Append($"{orderedProduct.GetQuantity()} of {orderedProduct.GetProduct().GetProductName()},");
            }
            return cartString.ToString().TrimEnd(',');
        }
        private void CalculateTotalPrice()
        {
            TotalPrice = 0;
            for(int i=0;i< ProductsOrdered.Count;i++) 
            {
                string productName = ProductsOrdered[i].GetProduct().GetProductName();
                TotalPrice += ObjectHandler.GetProductDL().GetPrice(ObjectHandler.GetProductDL().GetProductID(productName), ProductsOrdered[i].GetQuantity());
            }
        }

        private void CalculateTotalPrice(double discount)
        {
            TotalPrice = 0;
            for (int i = 0; i < ProductsOrdered.Count; i++)
            {
                string productName = ProductsOrdered[i].GetProduct().GetProductName();
                TotalPrice += ObjectHandler.GetProductDL().GetPrice(ObjectHandler.GetProductDL().GetProductID(productName), ProductsOrdered[i].GetQuantity());
            }
            if(discount<TotalPrice)
            {
                TotalPrice -= discount;
            }
        }

        public void AddProduct(Product product, string quantity)
        {
            ProductsOrdered.Add(new OrderedProduct(product, quantity));
            CalculateTotalPrice();
        }

        public void RemoveProduct(Product product, string quantity)
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

        public double GetTotalPrice()
        {
            return TotalPrice;
        }

        public string GetPaymentMethod()
        {
            return PaymentMethod;
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

        public int GetCustomerID()
        {
            return CustomerID;
        }

        public void SetCustomerName(int customerID)
        {
            CustomerID = customerID;
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
