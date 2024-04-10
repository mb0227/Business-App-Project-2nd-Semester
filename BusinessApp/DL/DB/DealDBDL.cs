using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;
using SSC;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace RMS.DL
{
    public class DealDBDL : IDealDL
    {
        public Deal GetDeal(string name)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                List<Deal> deals = new List<Deal>();
                SqlCommand command = new SqlCommand("SELECT * FROM Deals", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int dealId = Convert.ToInt32(reader["ID"]);
                    string Name = reader["DealName"].ToString();
                    string items = reader["Items"].ToString();
                    decimal p = Convert.ToDecimal(reader["TotalPrice"]);
                    double price = Convert.ToDouble(p);
                    return new Deal(dealId, Name, price, UtilityFunctions.GetDealList(items));
                }
            }
            return null;
        }

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
                    Deal deal = new Deal(id, name, price, UtilityFunctions.GetDealList(items));
                    deals.Add(deal);
                }
                return deals;
            }
        }

        public Deal GetDeal(int id)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                List<Deal> deals = new List<Deal>();
                SqlCommand command = new SqlCommand("SELECT * FROM Deals", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int dealId = Convert.ToInt32(reader["ID"]);
                    string name = reader["DealName"].ToString();
                    string items = reader["Items"].ToString();
                    decimal p = Convert.ToDecimal(reader["TotalPrice"]);
                    double price = Convert.ToDouble(p);
                    return new Deal(dealId, name, price, UtilityFunctions.GetDealList(items));
                }
            }
            return null;
        }

        public void RemoveDeal(int id)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Deals WHERE ID=@ID", connection);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
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
