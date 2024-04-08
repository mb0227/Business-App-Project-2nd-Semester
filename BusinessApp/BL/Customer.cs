using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Customer
    {
        protected string Username;
        protected string Contact;
        protected string Status;
        protected string Gender;
        protected List <OrderedProduct> Cart;
        protected int UserID;

        protected int CustomerID;//for reading data

        public Customer(string username)
        {
            Username = username;
        }

        public Customer(string username,string contact,string status, string gender)
        {
            Username = username;
            Contact = contact;
            Status = status;
            Gender = gender;
            Cart = new List <OrderedProduct>();
        }

        public Customer(int id, string username, string contact, string status, string gender, List<OrderedProduct> cart, int userId)
        {
            CustomerID = id;
            Username = username;
            Contact = contact;
            Status = status;
            Gender = gender;
            Cart = new List<OrderedProduct>();
            Cart = cart;
            UserID = userId;
        }

        public Customer(string username, string contact, string status, string gender,List<OrderedProduct> cart, int userId)
        {
            Username = username;
            Contact = contact;
            Status = status;
            Gender = gender;
            Cart = new List<OrderedProduct>();
            Cart = cart;
            UserID = userId;
        }

        public string GetUsername()
        {
            return Username;
        }

        public int GetID()
        {
            return CustomerID;
        }

        public string GetContact()
        {
            return Contact;
        }

        public string GetStatus()
        {
            return Status;
        }

        public string GetGender()
        {
            return Gender;
        }

        public int GetUserID()
        {
            return UserID;
        }

        public List<OrderedProduct> GetCart()
        {
            return Cart;
        }

        public void SetContact(string p)
        {
            Contact = p;
        }

        public void SetStatus(string s)
        {
            Status = s;
        }

        public void SetGender(string g)
        {
            Gender = g;
        }

        public void SetUserID(int id)
        {
            UserID = id;
        }

        public void SetCart(List<OrderedProduct> cart)
        {
            Cart = cart;
        }

        public void AddToCart(Product product, int quantity)
        {
            Cart.Add(new OrderedProduct(product, quantity));
        }

        public void RemoveFromCart(Product product) //remove product
        {
            Cart.Remove(Cart.Where(p => p.GetProduct().GetProductName().Equals(product.GetProductName())).FirstOrDefault());
        }

        public void RemoveFromCart(int index) //remove from index
        {
            Cart.RemoveAt(index);
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

        //public void placeOrder()
        //{
            
        //}
    }
}
