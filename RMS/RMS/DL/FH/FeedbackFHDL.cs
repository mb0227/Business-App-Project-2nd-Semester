using RMS.BL;
using RMS.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class FeedbackFHDL : IFeedbackDL
    {
        private readonly string path = UtilityFunctions.GetPath("Feedbacks.txt");
        public void SaveReview(Feedback feedback)
        {
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{feedback.GetReview()}, {feedback.GetCustomerID()}");
            }
        }

        public List<Feedback> GetReviews()
        {
            List<Feedback> feedbacks = new List<Feedback>();

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string review = parts[1].Trim();
                        int customerID = Convert.ToInt32(parts[2].Trim());

                        Feedback feedback = new Feedback(review, customerID);
                        feedbacks.Add(feedback);
                    }
                }
            }
            return feedbacks;
        }
    }
}
