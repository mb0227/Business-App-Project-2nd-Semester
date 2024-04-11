using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface IOrderDL
    {
        void SaveOrder(Order order);
        int HasOrder(int customerID);
        int GetOrderStatus(int customerID);
        void OrderDeal(Deal deal, int customerID);
        void OrderDeal(Deal deal);
        List<Order> GetOrders(int status);
        void UpdateOrderStatus(int id, int status);
        void TakeOrder(Order order);
        int CountOrders(int customerID);
        void DeleteOrder(int customerID);
        int FindOrderByID(int CustomerId);

        //List<Order> GetOrdersByCustomer(int customerID);
        //void UpdateOrderStatus(int orderID, string status);
    }
}
