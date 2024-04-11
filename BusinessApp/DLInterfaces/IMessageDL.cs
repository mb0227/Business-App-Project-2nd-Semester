using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface IMessageDL
    {
        void ReplyToMessage(string replyText, int employeeID, int customerID);
        List<Message> ReceiveMessages(int id, string query);
        int GetAvailableEmployee();
        void SendMessage(Message msg);
    }
}
