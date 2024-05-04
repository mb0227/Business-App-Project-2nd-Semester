using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Message
    {
        private int MessageID;
        private int SenderID;
        private int ReceiverID;
        private string MessageText;
        private DateTime TimeStamp;

        public Message(int senderID, int receiverID, string messageText)
        {
            this.SenderID = senderID;
            this.ReceiverID = receiverID;
            this.MessageText = messageText;
        }

        public Message(int senderID, int receiverID, string messageText, DateTime time) : this(senderID, receiverID, messageText)
        {
            TimeStamp = time;
        }

        public Message(int messageID, int senderID, int receiverID, string messageText) : this(senderID, receiverID, messageText)
        {
            this.MessageID = messageID;
        }

        public Message(int messageID, int senderID, int receiverID, string messageText, DateTime time) : this(messageID, senderID, receiverID, messageText)
        {
            TimeStamp = time;
        }

        public DateTime GetTime()
        {
            return TimeStamp;
        }

        public int GetMessageID()
        {
            return MessageID;
        }

        public int GetSenderID()
        {
            return SenderID;
        }

        public int GetReceiverID()
        {
            return ReceiverID;
        }

        public string GetMessageText()
        {
            return MessageText;
        }

        public void SetMessageText(string messageText)
        {
            MessageText = messageText;
        }
    }
}
