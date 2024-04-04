using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC
{
    public class Customer : User
    {
        private string Email;
        private string PhoneNumber;
        private Order Order;
        private List <OrderedProduct> Cart;
        private string OrderSpecifications;

        public Customer(string username, string password, string role, string gender, string email, string phoneNumber) : base(username, password, role, gender)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Order = new Order();
            Cart = new List <OrderedProduct>();
        }

        public Customer(string username, string password, string role, string gender, string email, string phoneNumber, Order order, List<OrderedProduct> cart) : base(username, password, role, gender)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Order = order;
            Cart = cart;
        }

        public Customer(string username, string password, string role, string gender, string email, string phoneNumber, string orderSpecifications,Order order, List<OrderedProduct> cart) : base(username, password, role, gender) 
        {
            Email = email;
            PhoneNumber = phoneNumber;
            OrderSpecifications = orderSpecifications;
            Order = order;
            Cart = cart;
        }

        public string GetEmail()
        {
            return Email;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public Order GetOrder()
        {
            return Order;
        }

        public string GetSpecifications()
        {
            return OrderSpecifications;
        }

        public List<OrderedProduct> GetCart()
        {
            return Cart;
        }

        public void SetEmail(string e)
        {
            Email = e;
        }

        public void SetPhoneNumber(string p)
        {
            PhoneNumber = p;
        }

        public void SetOrder(Order o)
        {
            Order = o;
        }

        public void SetCart(List<OrderedProduct> c)
        {
            Cart = c;
        }

        public void SetSpecifications(string s)
        {
            OrderSpecifications = s;
        }

        public void AddToCart(Product product, int quantity)
        {
            Cart.Add(new OrderedProduct(product, quantity));
        }

        public void RemoveFromCart(Product product) //remove from index
        {
            Cart.Remove(Cart.Where(p => p.GetProduct().GetProductName().Equals(product.GetProductName())).FirstOrDefault());
        }

        public void PlaceOrder()
        {
            Order = new Order(OrderDL.GetTotalOrders(), Cart, Order.OrderStatus.Pending, DateTime.Now, OrderSpecifications, Username);
            Cart.Clear();
        }

        public int GetSelectedItemIndex(string itemName)
        {
            foreach(OrderedProduct p in Cart)
            {
                if(p.GetProduct().GetProductName().Equals(itemName))
                {
                    return Cart.IndexOf(p);
                }
            }
            return -1;
        }
    }
}
