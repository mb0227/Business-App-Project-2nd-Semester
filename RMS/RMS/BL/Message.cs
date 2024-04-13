using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Message
    {
        private int messageID;
        private int senderID;
        private int receiverID;
        private string messageText;
        private DateTime timeStamp;

        public Message(int senderID, int receiverID, string messageText)
        {
            this.senderID = senderID;
            this.receiverID = receiverID;
            this.messageText = messageText;
        }

        public Message(int senderID, int receiverID, string messageText, DateTime time) : this(senderID, receiverID, messageText)
        {
            timeStamp = time;
        }

        public Message(int messageID, int senderID, int receiverID, string messageText) : this(senderID, receiverID, messageText)
        {
            this.messageID = messageID;
        }

        public DateTime GetTime()
        {
            return timeStamp;
        }

        public int GetMessageID()
        {
            return messageID;
        }

        public int GetSenderID()
        {
            return senderID;
        }

        public int GetReceiverID()
        {
            return receiverID;
        }

        public string GetMessageText()
        {
            return messageText;
        }
    }
}
