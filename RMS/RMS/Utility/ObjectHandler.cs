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
        private static readonly INotificationDL NotificationDL = new NotificationDBDL();
        private static readonly IReservationDL ReservationDL = new ReservationDBDL();
        private static readonly IEmployeeDL EmployeeDL = new EmployeeDBDL();
        private static readonly ICustomerDL CustomerDL = new CustomerDBDL();
        private static readonly IFeedbackDL FeedbackDL = new FeedbackDBDL();
        private static readonly IProductDL ProductDL = new ProductDBDL();
        private static readonly IMessageDL MessageDL = new MessageDBDL();
        private static readonly IVoucherDL VoucherDL = new VoucherDBDL();
        private static readonly IRegularDL RegularDL = new RegularDBDL();
        private static readonly IWaiterDL WaiterDL = new WaiterDBDL();
        private static readonly IAdminDL AdminDL = new AdminDBDL();
        private static readonly ITableDL TableDL = new TableDBDL();
        private static readonly IOrderDL OrderDL = new OrderDBDL();
        private static readonly IPhotoDL PhotoDL = new UserDBDL();
        private static readonly IUserDL UserDL = new UserDBDL();
        private static readonly IChefDL ChefDL = new ChefDBDL();
        private static readonly IDealDL DealDL = new DealDBDL();
        private static readonly IVipDL VipDL = new VipDBDL();

        //private static readonly INotificationDL NotificationDL = new NotificationFHDL();
        //private static readonly IReservationDL ReservationDL = new ReservationFHDL();
        //private static readonly IFeedbackDL FeedbackDL = new FeedbackFHDL();
        //private static readonly ICustomerDL CustomerDL = new CustomerFHDL();
        //private static readonly IEmployeeDL EmployeeDL = new EmployeeFHDL();
        //private static readonly IRegularDL RegularDL = new RegularFHDL();
        //private static readonly IProductDL ProductDL = new ProductFHDL();
        //private static readonly IMessageDL MessageDL = new MessageFHDL();
        //private static readonly IVoucherDL VoucherDL = new VoucherFHDL();
        //private static readonly IWaiterDL WaiterDL = new WaiterFHDL();
        //private static readonly ITableDL TableDL = new TableFHDL();
        //private static readonly IOrderDL OrderDL = new OrderFHDL();
        //private static readonly IAdminDL AdminDL = new AdminFHDL();
        //private static readonly IPhotoDL PhotoDL = new UserFHDL();
        //private static readonly IDealDL DealDL = new DealFHDL();
        //private static readonly IUserDL UserDL = new UserFHDL();
        //private static readonly IChefDL ChefDL = new ChefFHDL();
        //private static readonly IVipDL VipDL = new VipFHDL();

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
