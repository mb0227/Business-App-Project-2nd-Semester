using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RMS.BL;
using RMS.DL;
using RMS.Utility;

namespace BusinessAppConsole.UI
{
    public class UserUI
    {
        public static Customer SignUp()
        {
            string email, password, confirmPassword, username, gender, contact;
            PrintBackMessage();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorVisible = true; 
            Console.Write("\t\t\t\t\t\t\tEnter your email: ");
            email = Console.ReadLine();
            Console.Write("\t\t\t\t\t\t\tEnter your password: ");
            password = Console.ReadLine();
            Console.Write("\t\t\t\t\t\t\tEnter your name: ");
            username = Console.ReadLine();
            Console.Write("\t\t\t\t\t\t\tConfirm your password: ");
            confirmPassword = Console.ReadLine();
            Console.Write("\t\t\t\t\t\t\tEnter your Gender: ");
            gender = Console.ReadLine();
            Console.Write("\t\t\t\t\t\t\tEnter your Contact: ");
            contact = Console.ReadLine();
            Console.CursorVisible = false;
            Console.ResetColor();
            int result = CheckValidations(ref email,ref password,ref confirmPassword,ref username,ref gender,ref contact);
            if (result == -1)
                return new Customer("back");
            if (!PrintErrorMessage(result))
                return null;
            ObjectHandler.GetUserDL().SaveUser(new User(email, password, "Customer"));
            Customer c =  new Customer(username, contact, "Regular", gender);
            c.SetUserID(ObjectHandler.GetUserDL().GetUserID(email));
            return c;
        }

        private static void PrintBackMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\t\t\t\t\tEnter back in any field and skip others to go back.\n");
            Console.ResetColor();
        }

        private static bool PrintErrorMessage(int result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (result == 0)
                Console.WriteLine("\t\t\t\t\t\t\tInvalid email pattern");
            else if (result == 1)
                Console.WriteLine("\t\t\t\t\t\t\tEmail already exists");
            else if (result == 2)
                Console.WriteLine("\t\t\t\t\t\t\tPassword cannot be empty");
            else if (result == 3)
                Console.WriteLine("\t\t\t\t\t\t\tPasswords do not match");
            else if (result == 4)
                Console.WriteLine("\t\t\t\t\t\t\tUsername cannot be empty");
            else if (result == 5)
                Console.WriteLine("\t\t\t\t\t\t\tUsername already exists");
            else if (result == 6)
                Console.WriteLine("\t\t\t\t\t\t\tInvalid Gender. Enter m or f");
            else if (result == 7)
                Console.WriteLine("\t\t\t\t\t\t\tInvalid contact number");
            else
                return true;
            Console.ResetColor();
            Console.ReadKey();
            return false;
        }

        private static int CheckValidations(ref string e,ref string p,ref string cp,ref string u,ref string g,ref string c)
        {
            e = e.Replace(",","").Trim();
            p = p.Replace(",", "").Trim();
            cp = cp.Replace(",", "").Trim();
            u = u.Replace(",", "").Trim();
            g = g.Replace(",", "").Trim();
            c = c.Replace(",", "").Trim();
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            string contactPattern = @"^0\d{10}$";
            if(e.ToLower().Trim()=="back"||p.ToLower().Trim()=="back" || cp.ToLower().Trim() == "back" || u.ToLower().Trim() == "back" || g.ToLower().Trim() == "back" || c.ToLower().Trim() == "back")
            {
                return -1;
            }
            if (!Regex.IsMatch(e, emailPattern))
            {
                return 0;
            }
            else if (ObjectHandler.GetUserDL().EmailAlreadyExists(e))
            {
                return 1;
            }
            else if (string.IsNullOrEmpty(p))
            {
                return 2;
            }
            else if (p != cp)
            {
                return 3;
            }
            else if (string.IsNullOrEmpty(u))
            {
                return 4;
            }
            else if (ObjectHandler.GetCustomerDL().UsernameAlreadyExists(u))
            {
                return 5;
            }
            else if (g.ToLower().Trim() != "m" && g.ToLower().Trim() != "f")
            {
                return 6;
            }
            else if (!Regex.IsMatch(c, contactPattern))
            {
                return 7;
            }
            return 8;
        }

        public static User SignIn()
        {
            PrintBackMessage();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorVisible = true;
            Console.Write("\t\t\t\t\t\t\tEnter your email: ");
            string email = Console.ReadLine();
            Console.Write("\t\t\t\t\t\t\tEnter your password: ");
            string password = Console.ReadLine();
            Console.CursorVisible = false;
            Console.ResetColor();
            if(email.Trim().ToLower()=="back" || password.Trim().ToLower() == "back")
            {
                return null;
            }
            return new User(email, password, "");
        }

        public static void PrintInvalidUserMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t\tInvalid Credentials");
            Console.ResetColor();
            Console.ReadKey();
        }

        public static int AdminMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\t\t\t\t\t\t\tView Feedback");
            Console.WriteLine("\t\t\t\t\t\t\tView Messages");
            Console.WriteLine("\t\t\t\t\t\t\tLog Out");
            Console.ResetColor();
            return ConsoleUtility.MovementOfArrow(53, 7, 1, 3);
        }
    }
}
