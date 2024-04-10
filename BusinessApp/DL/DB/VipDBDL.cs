using RMS.BL;
using SSC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class VipDBDL : IVipDL
    {
        public List<VIP> GetVIPs()
        {
            List<VIP> vips = new List<VIP>();
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT V.ID, C.Username, V.MembershipLevel, V.CustomerID FROM Customers C JOIN VIP V ON C.ID = V.CustomerID;", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        string membershipLvl = reader.GetString(2);
                        int customerID = reader.GetInt32(3);

                        VIP vip = new VIP(username, id, membershipLvl, customerID);
                        vips.Add(vip);

                    }
                }
            }
            return vips;
        }

        public void SaveVIP(VIP vip)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO VIP(MembershipLevel, CustomerID, Vouchers) VALUES (@MembershipLevel, @CustomerID,@Vouchers)", connection);
                command.Parameters.AddWithValue("@MembershipLevel", vip.GetMembershipLevel());
                command.Parameters.AddWithValue("@CustomerID", vip.GetCustomerID());
                command.Parameters.AddWithValue("@Vouchers", string.Join(",", vip.GetVouchers()));
                command.ExecuteNonQuery();
            }
        }

        public VIP GetVIP(int customerID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM VIP WHERE CustomerID=@CustomerID", connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string membershipLevel = reader.GetString(1);
                        int customerId = reader.GetInt32(2);
                        string vouchers = reader.GetString(3);
                        List<string> Vouchers = new List<string>(vouchers.Split(','));
                        return new VIP(id, membershipLevel, customerId, Vouchers);
                    }
                }
                return null;
            }
        }

        public void UpdateVIP(string membershipLevel, int customerID, List<string> Vouchers)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE VIP SET MembershipLevel = @MembershipLevel, Vouchers = @Vouchers WHERE CustomerID=@CustomerID", connection);
                command.Parameters.AddWithValue("@MembershipLevel", membershipLevel);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Vouchers", string.Join(",", Vouchers));
                command.ExecuteNonQuery();
            }
        }

        
    }
}
