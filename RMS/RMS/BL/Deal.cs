using System;
using System.Collections.Generic;
using System.Text;

namespace RMS.BL
{
    public class Deal
    {
        private string DealName;
        private double Price;
        private List<(string Name, string Quantity)> Menu = new List<(string Name, string Quantity)>();
        private int ID;

        public Deal(string n, double p, List<(string Name, string Quantity)> m)
        {
            DealName = n;
            Price = p;
            Menu = m;
        }

        public Deal(int id, string n, double p, List<(string Name, string Quantity)> m) : this(n, p, m)
        {
            ID = id;
        }

        public string GetDealName()
        {
            return DealName;
        }

        public void SetDealName(string name)
        {
            DealName = name;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        public int GetID()
        {
            return ID;
        }

        public void SetID(int id)
        {
            ID = id;
        }

        public List<(string Name, string Quantity)> GetMenu()
        {
            return Menu;
        }

        public void SetMenu(List<(string Name, string Quantity)> menu)
        {
            Menu = menu;
        }

        public void AddMenuItem(string name, string quantity) //remove menu item
        {
            Menu.Add((name, quantity));
        }

        public void RemoveMenuItem(string name)
        {
            Menu.RemoveAll(item => item.Name == name);
        }

        public int GetTotalMenuItems()
        {
            return Menu.Count;
        }

        public string GetDealString()
        {
            StringBuilder itemString = new StringBuilder();
            foreach (var product in Menu)
            {
                itemString.Append($"{product.Quantity} of {product.Name};");
            }
            return itemString.ToString().TrimEnd(';');
        }

        public (string Name, string Quantity) GetMenuItemAtIndex(int index)
        {
            if (index >= 0 && index < Menu.Count)
            {
                return Menu[index];
            }
            else
            {
                throw null;
            }
        }

        public void ApplyDiscount(double discount)
        {
            if (discount < Price)
            {
                Price -= discount;
            }
        }
    }
}
