using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;
using RMS.DL;
using RMS.Utility;

namespace BusinessAppConsole.UI
{
    public class MessageUI
    {
        public static (int, int) PrintCustomersNames(int empID)
        {
            List<Customer> customers = ObjectHandler.GetMessageDL().GetCustomersNames(empID);

            if (customers == null || customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
                Console.ReadKey();
                return (-1, -1); 
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t\t\t\t\t\t\tCustomers List");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in customers)
            {
                Console.WriteLine("\t\t\t\t\t\t\t" + item.GetUsername());
            }

            Console.WriteLine("\t\t\t\t\t\t\tGo Back");
            Console.ResetColor();

            int input = ConsoleUtility.MovementOfArrow(53, 8, 1, customers.Count + 1);
            if (input == customers.Count + 1)
                return (-1, -1);
            int id = customers[input-1].GetID();
            return (input, id);
        }

        public static void PrintCustomerMessages(int empID, int customerId, string query)
        {
            List<Message> messages = ObjectHandler.GetMessageDL().ReceiveMessages(empID, query);
            Console.WriteLine();
            foreach (var item in messages)
            {
                if (item.GetMessageText() == "")
                    continue;
                string decryptedMessage = Encryption.Decrypt(item.GetMessageText());
                string time = item.GetTime().ToString("HH:mm");
                if (item.GetSenderID() == customerId)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t\t\t\t\tCustomer: " + decryptedMessage + " "+ time);
                }
                if(item.GetSenderID() == empID && item.GetReceiverID() == customerId)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\t\t\t\t\t\t\tYou: " + decryptedMessage + " " + time);
                }
            }
            Console.ResetColor();
        }

        public static void SendMessage(int empID, int customerID)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorVisible = true;
            Console.Write("\t\t\t\t\t\t\tType your message: ");
            string message = Console.ReadLine();
            Console.CursorVisible = true;
            Console.ResetColor();
            message = message.Trim().Replace(",", "");
            Message message1 = new Message(empID, customerID, Encryption.Encrypt(message), DateTime.Now);
            ObjectHandler.GetMessageDL().SendMessage(message1);
        }
    }
}
