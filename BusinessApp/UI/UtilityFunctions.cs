using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp
{
    public class UtilityFunctions
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=SSC;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
