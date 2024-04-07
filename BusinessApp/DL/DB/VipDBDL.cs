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
    }
}
