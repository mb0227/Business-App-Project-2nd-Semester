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
        private static IUserDL UserDL = new UserDBDL();
        private static ICustomerDL CustomerDL = new CustomerDBDL();
        private static IRegularDL RegularDL= new RegularDBDL();
        private static IEmployeeDL EmployeeDL = new EmployeeDBDL();
        private static IAdminDL AdminDL = new AdminDBDL();
        private static IChefDL ChefDL = new ChefDBDL();            
        private static IVipDL VipDL = new VipDBDL();
        private static IFeedbackDL FeedbackDL = new FeedbackDBDL();
        private static IReservationDL ReservationDL = new ReservationDBDL();
        private static ITableDL TableDL = new TableDBDL();            
        private static IWaiterDL WaiterDL = new WaiterDBDL();
        private static INotificationDL NotificationDL = new NotificationDBDL();
        private static IOrderDL OrderDL = new OrderDBDL();            
        private static IProductDL ProductDL = new ProductDBDL();
        private static IDealDL DealDL = new DealDBDL();
        private static IMessageDL MessageDL = new MessageDBDL();
        private static IVoucherDL VoucherDL = new VoucherDBDL();
        private static IPhotoDL PhotoDL = new UserDBDL();

        //private static IUserDL UserDL = new UserFHDL();
        //private static ICustomerDL CustomerDL = new CustomerFHDL();
        //private static IRegularDL RegularDL = new RegularFHDL();            
        //private static IEmployeeDL EmployeeDL = new EmployeeFHDL();
        //private static IAdminDL AdminDL = new AdminFHDL();
        //private static IChefDL ChefDL = new ChefFHDL();       
        //private static IVipDL VipDL = new VipFHDL();
        //private static IFeedbackDL FeedbackDL = new FeedbackFHDL();
        //private static IReservationDL ReservationDL = new ReservationFHDL();
        //private static ITableDL TableDL = new TableFHDL();            
        //private static IWaiterDL WaiterDL = new WaiterFHDL();
        //private static INotificationDL NotificationDL = new NotificationFHDL();
        //private static IOrderDL OrderDL = new OrderFHDL();
        //private static IProductDL ProductDL = new ProductFHDL();
        //private static IDealDL DealDL = new DealFHDL();
        //private static IMessageDL MessageDL = new MessageFHDL();
        //private static IVoucherDL VoucherDL = new VoucherFHDL();
        //private static IPhotoDL PhotoDL = new UserFHDL();

        public static IUserDL GetUserDL()
        {
            return UserDL;
        }

        public static ICustomerDL GetCustomerDL()
        {
            return CustomerDL;
        }

        public static IRegularDL GetRegularDL()
        {
            return RegularDL;
        }

        public static IEmployeeDL GetEmployeeDL()
        {
           return EmployeeDL;
        }

        public static IAdminDL GetAdminDL()
        {
            return AdminDL;
        }

        public static IChefDL GetChefDL()
        {
            return ChefDL;
        }

        public static IVipDL GetVipDL()
        {
            return VipDL;
        }

        public static IFeedbackDL GetFeedbackDL()
        {
            return FeedbackDL;
        }

        public static IReservationDL GetReservationDL()
        {
            return ReservationDL;
        }

        public static ITableDL GetTableDL()
        {
            return TableDL;
        }

        public static IWaiterDL GetWaiterDL()
        {
            return WaiterDL;
        }

        public static INotificationDL GetNotificationDL()
        {
            return NotificationDL;
        }

        public static IOrderDL GetOrderDL()
        {
            return OrderDL;
        }

        public static IProductDL GetProductDL()
        {
            return ProductDL;
        }

        public static IDealDL GetDealDL()
        {
            return DealDL;
        }

        public static IMessageDL GetMessageDL()
        {
            return MessageDL;
        }

        public static IVoucherDL GetVoucherDL()
        {
            return VoucherDL;
        }

        public static IPhotoDL GetPhotoDL()
        {
            return PhotoDL;
        }
    }
}
