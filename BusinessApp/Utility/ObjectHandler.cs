using RMS.BL;
using RMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace SSC.UI
{
    public class ObjectHandler
    {
        public static IUserDL GetUserDL()
        {
            return new UserDBDL();
        }

        public static ICustomerDL GetCustomerDL()
        {
            return new CustomerDBDL();
        }

        public static IEmployeeDL GetEmployeeDL()
        {
            return new EmployeeDBDL();
        }

        public static IAdminDL GetAdminDL()
        {
            return new AdminDBDL();
        }

        public static IChefDL GetChefDL()
        {
            return new ChefDBDL();
        }

        public static IRegularDL GetRegularDL()
        {
            return new RegularDBDL();
        }
        
        public static IVipDL GetVipDL()
        {
            return new VipDBDL();
        }

        public static IFeedbackDL GetFeedbackDL()
        {
            return new FeedbackDBDL();
        }

        public static IReservationDL GetReservationDL()
        {
            return new ReservationDBDL();
        }

        public static ITableDL GetTableDL()
        {
            return new TableDBDL();
        }

        public static IWaiterDL GetWaiterDL()
        {
            return new WaiterDBDL();
        }

        public static INotificationDL GetNotificationDL()
        {
            return new NotificationDBDL();
        }

        public static IOrderDL GetOrderDL()
        {
            return new OrderDBDL();
        }

        public static IProductDL GetProductDL()
        {
            return new ProductDBDL();
        }

        public static IDealDL GetDealDL()
        {
            return new DealDBDL();
        }
    }
}
