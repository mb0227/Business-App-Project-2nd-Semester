using RMS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppConsole.UI
{
    public class FeedbackUI
    {
        public static int TakeFeedback()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\t\t\t\t\t\t\t5 Stars");
            Console.WriteLine("\t\t\t\t\t\t\t4 Stars");
            Console.WriteLine("\t\t\t\t\t\t\t3 Stars");
            Console.WriteLine("\t\t\t\t\t\t\t2 Stars");
            Console.WriteLine("\t\t\t\t\t\t\t1 Stars");
            Console.WriteLine("\t\t\t\t\t\t\tLog Out");
            Console.ResetColor();
            return ConsoleUtility.MovementOfArrow(53, 7, 1, 6);
        }

        public static void PrintReviews()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach(var feedback in ObjectHandler.GetFeedbackDL().GetReviews())
            {
                Console.WriteLine("\t\t\t\t\t\t\tFeedback: " + feedback.GetReview() + " Customer ID: "+ feedback.GetCustomerID());
            }
            Console.ResetColor();
        }
    }
}
