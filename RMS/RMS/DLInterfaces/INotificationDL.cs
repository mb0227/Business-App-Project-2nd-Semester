using RMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public interface INotificationDL
    {
        void SaveNotification(Notification n);
        List<string> GetNotifications(int customerId);
        void MarkAsRead(int customerId);
    }
}
