﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BL;
using RMS.DL;

namespace SSC.UI
{
    public partial class CustomerBookTable : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        private Customer customer;
        public CustomerBookTable()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public CustomerBookTable(Size size, Point location, Customer c)
        {
            InitializeComponent();
            InitializeUserControls();
            this.Size = size;
            this.Location = location;
            customer = c;
            FillComboBox();
        }

        private void InitializeUserControls()
        {
            cHeader = new CustomerHeader();
            Controls.Add(cHeader);
            cHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            cHeader.Top = 0;
            cHeader.Left = 0;
            cHeader.Width = this.Width;
            cHeader.BringToFront();

            cNavBar = new CustomerNavBar();
            Controls.Add(cNavBar);
            cNavBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom;
            cNavBar.Width = 147;
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;
            cNavBar.BringToFront();

            cNavBar.NavigationRequested += CustomerNavBar_NavigationRequested;
            cNavBar.NavBarCollapsed += CNavBar_NavBarCollapsed;
        }

        private void CustomerNavBar_NavigationRequested(object sender, string formName)
        {
            switch (formName)
            {
                case "dashboard":
                    OpenForm(new CustomerDashboard(this.Size, this.Location, customer));
                    break;
                case "orderFood":
                    OpenForm(new CustomerOrderFood(this.Size, this.Location, customer));
                    break;
                case "bookTable":
                    OpenForm(new CustomerBookTable(this.Size, this.Location, customer));
                    break;
                case "feedback":
                    OpenForm(new CustomerFeedback(this.Size, this.Location, customer));
                    break;
                case "settings":
                    OpenForm(new Settings(this.Size, this.Location, customer));
                    break;
                case "help":
                    OpenForm(new UI.Help(this.Size, this.Location, customer));
                    break;
                default:
                    break;
            }
        }

        private void OpenForm(Form form)
        {
            form.Size = this.Size;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void CNavBar_NavBarCollapsed(object sender, bool collapsed)
        {
            if (collapsed)
            {
                panel4.BringToFront();
            }
            else
            {
                panel4.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            foreach (Table table in ObjectHandler.GetTableDL().GetTables())
            {
                if (table.GetStatus() == "Unbooked")
                {
                    comboBox1.Items.Add(table.GetID());
                }
            }
        }

        private bool CheckValidations()
        {
            if (!string.IsNullOrEmpty(comboBox1.Text.ToString()))
            {
                int max = ObjectHandler.GetTableDL().GetTableCapacity(Convert.ToInt32(comboBox1.Text));
                if (!int.TryParse(guna2TextBox1.Text, out int number) || number < 1 || number > max)
                {
                    errorProvider1.SetError(guna2TextBox1, $"Please enter a valid number between 1 and {max}.");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(guna2TextBox1, "");
                }
            }
            else
            {
                return false;
            }

            DateTime currentDate = DateTime.Today;

            if (dateTimePicker1.Value < currentDate)
            {
                errorProvider1.SetError(guna2TextBox1, $"Please enter a valid date for reservation.");
                return false;
            }
            else
            {
                errorProvider1.SetError(guna2TextBox1, "");
            }

            int customerID = ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername());

            if (ObjectHandler.GetReservationDL().GetCustomerReservationCount(customerID) == 1)
            {
                errorProvider1.SetError(guna2TextBox1, "You already have a reservation booked.");
                return false;
            }

            return true;
        }

        private void makeReservation_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {
                ObjectHandler.GetReservationDL().SaveReservation(new Reservation(dateTimePicker1.Value,Convert.ToInt32(guna2TextBox1.Text), ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername()), int.Parse(comboBox1.Text)));
                ObjectHandler.GetTableDL().UpdateTable(new Table(ObjectHandler.GetTableDL().GetTableCapacity(int.Parse(comboBox1.Text)), int.Parse(comboBox1.Text), "Booked"));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void viewReservationButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = customer.GetUsername();
                int customerID = ObjectHandler.GetCustomerDL().GetCustomerID(name);
                if (ObjectHandler.GetReservationDL().GetCustomerReservationCount(customerID) == 1)
                {
                    reservationText.Text = "";
                    reservationText.Text = "You have a Reservation at "+ ObjectHandler.GetReservationDL().GetReservationDate(customerID);
                    reservationText.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteReservation_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername());
                if (ObjectHandler.GetReservationDL().GetCustomerReservationCount(customerID) == 1)
                {
                    ObjectHandler.GetTableDL().UpdateTablesStatus(ObjectHandler.GetTableDL().GetReservedTableID(customerID));
                    ObjectHandler.GetReservationDL().DeleteReservation(customerID);
                    MessageBox.Show("Successfully Deleted reservation");
                    reservationText.Visible = false;
                }
                else
                {
                    MessageBox.Show("You have no Reservation to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
