using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using BusinessAppConsole.UI;
using RMS.BL;
using RMS.DL;
using RMS.UI;

namespace BusinessAppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleUtility.ClearScreen();
                int option = ConsoleUtility.Homepage();
                if(option==1) //Sign In
                {
                    while(true)
                    {
                        ConsoleUtility.ClearScreen();
                        User user = UserUI.SignIn();
                        string role = "";
                        bool flag = false;
                        if (user!=null)
                            role = ObjectHandler.GetUserDL().SearchUserForRole(user.GetEmail(), user.GetPassword());
                        else
                            break;
                        int userID = ObjectHandler.GetUserDL().GetUserID(user.GetEmail());
                        if (role!="")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t\t\t\t\t\tSigned In Successfully");
                            if (role.ToLower() == "customer" && userID!=-1)
                            {
                                Console.WriteLine("\t\t\t\t\t\t\tCustomer Login Successful");
                                Console.ReadKey();
                                while (true)
                                {
                                    ConsoleUtility.LoadingFunction();
                                    ConsoleUtility.ClearScreen();
                                    int feedback = FeedbackUI.TakeFeedback();
                                    Customer customer = ObjectHandler.GetCustomerDL().SearchCustomerById(userID);
                                    if (feedback == 1)
                                    {
                                        ObjectHandler.GetFeedbackDL().SaveReview(new Feedback("1 Star", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername())));
                                    }
                                    else if (feedback == 2)
                                    {
                                        ObjectHandler.GetFeedbackDL().SaveReview(new Feedback("2 Stars", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername())));
                                    }
                                    else if (feedback == 3)
                                    {
                                        ObjectHandler.GetFeedbackDL().SaveReview(new Feedback("3 Stars", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername())));
                                    }
                                    else if (feedback == 4)
                                    {
                                        ObjectHandler.GetFeedbackDL().SaveReview(new Feedback("4 Stars", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername())));
                                    }
                                    else if (feedback == 5)
                                    {
                                        ObjectHandler.GetFeedbackDL().SaveReview(new Feedback("5 Stars", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername())));
                                    }
                                    else if (feedback == 6)
                                    {
                                        ConsoleUtility.LoadingFunction();
                                        flag = true;
                                        break;
                                    }
                                }
                                if (flag)
                                {
                                    break;
                                }
                            }
                            else if (role.ToLower() == "admin" && userID != -1)
                            {
                                Console.WriteLine("\t\t\t\t\t\t\tAdmin Login Successful");
                                Console.ReadKey();
                                while (true)
                                {
                                    ConsoleUtility.LoadingFunction();
                                    ConsoleUtility.ClearScreen();
                                    int opt = UserUI.AdminMenu();
                                    if(opt == 1)
                                    {
                                        ConsoleUtility.ClearScreen();
                                        FeedbackUI.PrintReviews();
                                        Console.ReadKey();
                                    }
                                    else if(opt == 2)
                                    {
                                        ConsoleUtility.LoadingFunction();
                                        flag = true;
                                        break;
                                    }
                                }
                                if (flag)
                                {
                                    break;
                                }
                            }
                            else if (role.ToLower() == "chef" && userID != -1)
                            {
                                Console.WriteLine("\t\t\t\t\t\t\tChef Login Successful");
                                Console.ReadKey();
                            }
                            else if (role.ToLower() == "\t\t\t\t\t\t\twaiter" && userID != -1)
                            {
                                Console.WriteLine("\t\t\t\t\t\t\tWaiter Login Successful");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            UserUI.PrintInvalidUserMessage();
                            continue;
                        }
                        Console.ResetColor();   
                    }
                }
                else if(option==2) //Sign Up
                {
                    while(true)
                    {
                        ConsoleUtility.ClearScreen();                        
                        Customer customer = UserUI.SignUp();
                        if (customer != null && customer.GetUsername().ToLower().Trim() == "back")
                        {
                            break;
                        }
                        else if (customer != null)
                        {
                            ConsoleUtility.LoadingFunction();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.ResetColor();
                            ObjectHandler.GetCustomerDL().SaveCustomer(customer);
                            ObjectHandler.GetRegularDL().SaveRegular(new Regular(0, ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername())));
                            Console.WriteLine("\t\t\t\t\t\t\tSigned Up Successfully");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if(option==3)
                {
                    break;
                }
            }
        }
    }
}
