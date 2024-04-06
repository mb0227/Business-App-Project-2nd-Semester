using RMS.BL;
using SSC.UI;
using SSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.DL;
using Guna.UI2.WinForms;

namespace SignInSignUp.UI
{
    public partial class AddAdmin : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        IUserDBDL userDL = new UserDL();
        IEmployeeDBDL employeeDL = new EmployeeDL();
        public AddAdmin()
        {
            InitializeComponent();
        }

        public AddAdmin(Size size, Point location, Admin admin)
        {
            InitializeComponent();
            //InitializeUserControls();
            this.Size = size;
            this.Location = location;
            Admin = admin;
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            User user = new User(email.Text, password.Text, "Admin");
            userDL.StoreUserInDB(user);
            Employee employee = new Employee(username.Text, contact.Text, Convert.ToDouble(salary.Text), dateTime.Value, GetSelectedRadioButton().Text.ToString(), UserDL.GetUserID(email.Text, password.Text));
            employeeDL.StoreEmployeeInDB(employee);
            Admin admin = new Admin(username.Text, contact.Text, Convert.ToDouble(salary.Text), dateTime.Value, GetSelectedRadioButton().Text.ToString(), UserDL.GetUserID(email.Text, password.Text), splitText(tb1.Text), splitText(tb2.Text), EmployeeDL.GetEmployeeID(username.Text));
            ChefDL.StoreChefInDB(chef);
        }

        private List<string> splitText(string input)
        {
            string[] parts = input.Split(',');

            List<string> resultList = new List<string>();

            foreach (string part in parts)
            {
                resultList.Add(part.Trim());
            }
            return resultList;
        }

        private bool IsRadioButtonSelected(Guna2GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    return true;
                }
            }
            return false;
        }

        private RadioButton GetSelectedRadioButton()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton;
                }
            }
            return null;
        }

    }
}
