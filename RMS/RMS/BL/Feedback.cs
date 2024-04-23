using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Feedback
    {
        private string Review;
        private int CustomerID;

        public Feedback(string review, int customerID)
        {
            Review = review;
            CustomerID = customerID;
        }

        public string GetReview()
        {
            return Review;
        }

        public int GetCustomerID()
        {
            return CustomerID;
        }

        public void SetCustomerID(int id)
        {
            CustomerID = id;
        }
        public void SetReview(string review)
        {
            Review = review;
        }
    }

}
