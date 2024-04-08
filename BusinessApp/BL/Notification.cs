using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Notification
    {
        private int ID;
        private string Message;

        public Notification( string message)
        {
            Message = message;
        }
        public Notification(int id, string message)
        {
            ID = id;
            Message = message;
        }

        public int GetID()
        {
            return ID;
        }

        public string GetMessage()
        {
            return Message;
        }

        public void SetID(int id)
        {
            ID = id;
        }

        public void SetMessage(string message)
        {
            Message = message;
        }
    }
}
