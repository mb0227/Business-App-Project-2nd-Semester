using RMS.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSC
{
    public class UtilityFunctions
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=RMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static string ConvertProductVariantToString(ProductVariant variant)
        {
            string result = $"{variant.GetQuantity()} for {variant.GetPrice()}";
            return result;
        }

        public static ProductVariant ConvertStringToProductVariant(string variantString)
        {
            string[] parts = variantString.Split(new string[] { " for " }, StringSplitOptions.None);

            if (parts.Length == 2)
            {
                string quantityString = parts[0].Trim();
                double price = double.Parse(parts[1]);

                ProductVariant variant = new ProductVariant(quantityString, price);
                return variant;
            }
            else
            {
                return null;
            }
        }

    }
}
