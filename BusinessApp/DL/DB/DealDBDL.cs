using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;
using SSC;

namespace RMS.DL
{
    public class DealDBDL : IDealDL
    {
        public List<Deal> GetDeals()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                List <Deal> deals = new List<Deal>();
                SqlCommand command = new SqlCommand("SELECT * FROM Deals", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string name = reader["DealName"].ToString();
                    string items = reader["Items"].ToString();
                    decimal p = Convert.ToDecimal(reader["TotalPrice"]);
                    double price = Convert.ToDouble(p);

                    string[] parts = items.Split(',');

                    List<(string name, string quantity)> menu = new List<(string name, string quantity)>();

                    foreach (string part in parts)
                    {
                         string[] subParts = part.Trim().Split(new string[] { " of " }, StringSplitOptions.None);
                        if (subParts.Length == 2)
                        {
                            string quantity = subParts[0].Trim();
                            string n = subParts[1].Trim();

                            menu.Add((name, quantity));
                        }
                    }
                    Deal deal = new Deal(id, name, price, menu);
                    deals.Add(deal);
                }
                return deals;
            }
        }

        public void SaveDeal(Deal deal)
        {
                using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Deals (DealName, TotalPrice,Items) VALUES (@DealName, @TotalPrice, @Items)", connection);
                    command.Parameters.AddWithValue("@DealName", deal.GetDealName());
                    command.Parameters.AddWithValue("@TotalPrice", deal.GetPrice());
                    command.Parameters.AddWithValue("@Items", deal.GetDealString());
                    command.ExecuteNonQuery();
                }
            
        }
    }
}
