using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    internal class Customer : User
    {
        private string Email;
        private string PhoneNumber;
        private Order Order;
        private List<Product> Cart;
        private string OrderSpecifications;


        public Customer(string username, string password, string role, string gender, string email, string phoneNumber) : base(username, password, role, gender)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Order = new Order();
            Cart = new List<Product>();
        }

        public Customer(string username, string password, string role, string gender, string email, string phoneNumber, string orderSpecifications,Order order, List<Product> cart) : base(username, password, role, gender) 
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

        public List<Product> GetCart()
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

        public void SetCart(List<Product> c)
        {
            Cart = c;
        }

        public void SetSpecifications(string s)
        {
            OrderSpecifications = s;
        }

        public void AddToCart(Product product)
        {
            Cart.Add(product);
        }

        public void RemoveFromCart(Product product)
        {
            Cart.Remove(product);
        }

        public void ClearCart()
        {
            Cart.Clear();
        }

        public void PlaceOrder()
        {
            Order = new Order(OrderDL.GetTotalOrders(), Cart, Order.OrderStatus.Pending, DateTime.Now, OrderSpecifications, Username);
            Cart.Clear();
        }
    }
}
