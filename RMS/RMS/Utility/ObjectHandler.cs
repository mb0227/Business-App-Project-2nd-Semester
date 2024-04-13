using RMS.BL;
using RMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace RMS.UI
{
    public class ObjectHandler
    {
        public static IUserDL GetUserDL()
        {
            //return new UserDBDL();
            return new UserDBDL();
        }

        public static ICustomerDL GetCustomerDL()
        {
            return new CustomerDBDL();
            //return new CustomerDBDL();
        }

        public static IRegularDL GetRegularDL()
        {
            return new RegularDBDL();
            //return new RegularDBDL();
        }

        public static IEmployeeDL GetEmployeeDL()
        {
            return new EmployeeDBDL();
            //return new EmployeeDBDL();
        }

        public static IAdminDL GetAdminDL()
        {
            return new AdminDBDL();
            //return new AdminDBDL();
        }

        public static IChefDL GetChefDL()
        {
            return new ChefDBDL();
            //return new ChefDBDL();
        }

        public static IVipDL GetVipDL()
        {
            return new VipDBDL();
            //return new VipDBDL();
        }

        public static IFeedbackDL GetFeedbackDL()
        {
            return new FeedbackDBDL();
            //return new FeedbackDBDL();
        }

        public static IReservationDL GetReservationDL()
        {
            return new ReservationDBDL();
            //return new ReservationDBDL();
        }

        public static ITableDL GetTableDL()
        {
            return new TableDBDL();
            //return new TableDBDL();
        }

        public static IWaiterDL GetWaiterDL()
        {
            return new WaiterDBDL();
            //return new WaiterDBDL();
        }

        public static INotificationDL GetNotificationDL()
        {
            return new NotificationDBDL();
            //return new NotificationDBDL();
        }

        public static IOrderDL GetOrderDL()
        {
            return new OrderDBDL();
            //return new OrderDBDL();
        }

        public static IProductDL GetProductDL()
        {
            return new ProductDBDL();
            //return new ProductDBDL();
        }

        public static IDealDL GetDealDL()
        {
            return new DealDBDL();
            //return new DealDBDL();
        }

        public static IMessageDL GetMessageDL()
        {
            return new MessageDBDL();
            //return new MessageDBDL();
        }

        public static IVoucherDL GetVoucherDL()
        {
            return new VoucherDBDL();
            //return new VoucherDBDL;
        }

        public static IPhotoDL GetPhotoDL()
        {
            return new UserDBDL();
            //return new VoucherDBDL;
        }
    }
}
