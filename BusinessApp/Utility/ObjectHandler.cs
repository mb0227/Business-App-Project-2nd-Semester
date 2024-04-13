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
            return new UserFHDL();
            //return new UserDBDL();
        }

        public static ICustomerDL GetCustomerDL()
        {
            return new CustomerFHDL();
            //return new CustomerDBDL();
        }

        public static IRegularDL GetRegularDL()
        {
            return new RegularFHDL();
            //return new RegularDBDL();
        }

        public static IEmployeeDL GetEmployeeDL()
        {
            return new EmployeeFHDL();
            //return new EmployeeDBDL();
        }

        public static IAdminDL GetAdminDL()
        {
            return new AdminFHDL();
            //return new AdminDBDL();
        }

        public static IChefDL GetChefDL()
        {
            return new ChefFHDL();
            //return new ChefDBDL();
        }
        
        public static IVipDL GetVipDL()
        {
            return new VipFHDL();
            //return new VipDBDL();
        }

        public static IFeedbackDL GetFeedbackDL()
        {
            return new FeedbackFHDL();
            //return new FeedbackDBDL();
        }

        public static IReservationDL GetReservationDL()
        {
            return new ReservationFHDL();
            //return new ReservationDBDL();
        }

        public static ITableDL GetTableDL()
        {
            return new TableFHDL();
            //return new TableDBDL();
        }

        public static IWaiterDL GetWaiterDL()
        {
            return new WaiterFHDL();
            //return new WaiterDBDL();
        }

        public static INotificationDL GetNotificationDL()
        {
            return new NotificationFHDL();
            //return new NotificationDBDL();
        }

        public static IOrderDL GetOrderDL()
        {
            return new OrderFHDL();
            //return new OrderDBDL();
        }

        public static IProductDL GetProductDL()
        {
            return new ProductFHDL();
            //return new ProductDBDL();
        }

        public static IDealDL GetDealDL()
        {
            return new DealFHDL();
            //return new DealDBDL();
        }

        public static IMessageDL GetMessageDL()
        {
            return new MessageFHDL();
            //return new MessageDBDL();
        }

        public static IVoucherDL GetVoucherDL()
        {
            return new VoucherFHDL();
            //return new VoucherDBDL;
        }

        public static IPhotoDL GetPhotoDL()
        {
            return new UserFHDL();
            //return new VoucherDBDL;
        }
    }
}
