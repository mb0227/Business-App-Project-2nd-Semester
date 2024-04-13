using RMS.BL;
using SSC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class OrderFHDL : IOrderDL
    {
        public void SaveOrder(Order order)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{order.GetCustomerID()}, {order.GetCustomerComments()},{"0"}, {order.GetOrderDate()}, {UtilityFunctions.GetCartString(order.GetProducts())}, {order.GetTotalPrice()}, {order.GetPaymentMethod()}");
            }
        }

        public void UpdateOrderStatus(int id, int status)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 8 && parts[0].Trim() == id.ToString())
                    {
                        parts[3] = status.ToString();
                        lines[i] = string.Join(",", parts);
                        File.WriteAllLines(path, lines); 
                        return; 
                    }
                }
            }
        }


        public void TakeOrder(Order order)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{-1}, {order.GetCustomerComments()}, {"0"}, {order.GetOrderDate()}, {UtilityFunctions.GetCartString(order.GetProducts())}, {order.GetTotalPrice()}, {order.GetPaymentMethod()}");
            }
        }

        public int HasOrder(int customerID)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    int count = 0;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 8 && parts[1].Trim() == customerID.ToString() && parts[3].Trim() == "0")
                        {
                            count++;
                        }
                    }
                    return count;
                }
            }
            return 0;
        }

        public int CountOrders(int customerID)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    int count = 0;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 8 && parts[1].Trim() == customerID.ToString() && parts[3].Trim() == "3")
                        {
                            count++;
                        }
                    }
                    return count;
                }
            }
            return -1;
        }

        public int GetOrderStatus(int customerID)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 8 && parts[1].Trim() == customerID.ToString())
                        {
                            int status = int.Parse(parts[3]);
                            return status;
                        }
                    }
                }
            }
            return -1;
        }

        public int FindOrderByID(int CustomerId)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 8 && parts[1].Trim() == CustomerId.ToString() && parts[3].Trim()=="0")
                        {
                            return int.Parse(parts[0]);
                        }
                    }
                }
            }
            return -1;
        }

        public void OrderDeal(Deal deal)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{"-1"},{""},{"0"},{DateTime.Now},{UtilityFunctions.GetDealString(deal)},{deal.GetPrice()},Cash on Delivery");
            }
        }

        public void OrderDeal(Deal deal, int customerID)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{customerID},{""},{"0"},{DateTime.Now},{UtilityFunctions.GetDealString(deal)},{deal.GetPrice()},Cash on Delivery");
            }
        }

        public void DeleteOrder(int customerID)
        {
            string path = UtilityFunctions.GetPath("Orders.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                List<string> newLines = new List<string>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8 && int.Parse(parts[1]) == customerID)
                    {
                        continue;
                    }
                    newLines.Add(line);
                }
            File.WriteAllLines(path, newLines);
            }
        }

        public List<Order> GetOrders(int status)
        {
            List<Order> orders = new List<Order>();
            string path = UtilityFunctions.GetPath("Orders.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8 && parts[3].Trim() == status.ToString())
                    {
                        int id = Convert.ToInt32(parts[0].Trim());
                        int customerID = Convert.ToInt32(parts[1].Trim());
                        string customerComments = parts[2].Trim();
                        Order.OrderStatus orderStatus = (Order.OrderStatus)Enum.Parse(typeof(Order.OrderStatus), parts[3].Trim());
                        DateTime orderDate = Convert.ToDateTime(parts[4].Trim());
                        List<OrderedProduct> products = UtilityFunctions.GetCartList(parts[5].Trim());
                        double totalPrice = Convert.ToDouble(parts[6].Trim());
                        string paymentMethod = parts[7].Trim();

                        Order order = new Order(id, products, orderStatus, orderDate, customerComments, customerID, paymentMethod);
                        orders.Add(order);
                    }
                }
            }
            return orders;
        }
    }
}
