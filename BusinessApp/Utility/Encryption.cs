using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utility.UI
{
    public class Encryption
    {
        private static int totalAlphabets = 26;
        private static char[] alphabets = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                      'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        private static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


        public static string Encrypt(string text)
        {
            string encodedVersion = "";
            for (int i = 0; i < text.Length; i++)
            {
                bool isUpper = char.IsUpper(text[i]);
                bool isLower = char.IsLower(text[i]);
                if (!isUpper && !isLower)
                {
                    encodedVersion += text[i];
                    continue;
                }

                for (int j = 0; j < totalAlphabets; j++)
                {
                    int ascii = text[i];
                    if (text[i] == ' ')
                    {
                        encodedVersion += ' ';
                        break;
                    }
                    else if (isUpper && text[i] == alphabets[j])
                    {
                        j = (j + 11) % totalAlphabets; // Encryption: Shift forward by 11 positions
                        encodedVersion += alphabets[j];
                        break;
                    }
                    else if (isLower && text[i] == alphabet[j])
                    {
                        j = (j + 11) % totalAlphabets; // Encryption: Shift forward by 11 positions
                        encodedVersion += alphabet[j];
                        break;
                    }
                }
            }
            return encodedVersion;
        }


        public static string Decrypt(string text)
        {
            string decodedVersion = "";
            for (int i = 0; i < text.Length; i++)
            {
                bool isUpper = char.IsUpper(text[i]);
                bool isLower = char.IsLower(text[i]);
                if (!isUpper && !isLower)
                {
                    decodedVersion += text[i];
                    continue;
                }

                for (int j = 0; j < totalAlphabets; j++)
                {
                    int ascii = text[i];
                    if (text[i] == ' ')
                    {
                        decodedVersion += ' ';
                        break;
                    }
                    else if (isUpper && text[i] == alphabets[j])
                    {
                        j = (j - 11 + totalAlphabets) % totalAlphabets; 
                        decodedVersion += alphabets[j];
                        break;
                    }
                    else if (isLower && text[i] == alphabet[j])
                    {
                        j = (j - 11 + totalAlphabets) % totalAlphabets;
                        decodedVersion += alphabet[j];
                        break;
                    }
                }
            }
            return decodedVersion;
        }
    }
}
