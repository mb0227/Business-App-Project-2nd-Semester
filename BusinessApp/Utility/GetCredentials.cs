using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.UI;
using System.IO;

namespace RMS.UI
{
    public class GetCredentials
    {
        public static string GetCreds(string type)
        {
            string path = "..//..//Credentials//Credentials.txt";
            string str = "";
            if (File.Exists(path))
            {
                string[] line = File.ReadAllLines(path);
                string[] parts = line[0].Split(',');
                if (type == "mail")
                    str = Encryption.Decrypt(parts[0]);
                else
                    str = Encryption.Decrypt(parts[1]);
            }
            return str;
        }
    }
}
