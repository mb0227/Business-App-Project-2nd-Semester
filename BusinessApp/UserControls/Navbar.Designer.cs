namespace SSC.UI
{
    partial class Navbar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navbar));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.employeesButton = new Guna.UI2.WinForms.Guna2Button();
            this.customerCRUD = new Guna.UI2.WinForms.Guna2Button();
            this.notificationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addAdminButton = new Guna.UI2.WinForms.Guna2Button();
            this.tablesCRUDBtn = new Guna.UI2.WinForms.Guna2Button();
            this.feedbackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.employeesButton);
            this.sidebar.Controls.Add(this.customerCRUD);
            this.sidebar.Controls.Add(this.notificationBtn);
            this.sidebar.Controls.Add(this.addAdminButton);
            this.sidebar.Controls.Add(this.tablesCRUDBtn);
            this.sidebar.Controls.Add(this.feedbackBtn);
            this.sidebar.Controls.Add(this.settingsBtn);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(270, 1080);
            this.sidebar.MinimumSize = new System.Drawing.Size(59, 200);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(267, 1080);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 54);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboardButton);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 54);
            this.panel2.TabIndex = 1;
            // 
            // dashboardButton
            // 
            this.dashboardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardButton.FillColor = System.Drawing.Color.Transparent;
            this.dashboardButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardButton.Location = new System.Drawing.Point(0, -3);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(264, 54);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard            ";
            this.dashboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // employeesButton
            // 
            this.employeesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.employeesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.employeesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.employeesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.employeesButton.FillColor = System.Drawing.Color.Transparent;
            this.employeesButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesButton.ForeColor = System.Drawing.Color.White;
            this.employeesButton.Image = ((System.Drawing.Image)(resources.GetObject("employeesButton.Image")));
            this.employeesButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.employeesButton.Location = new System.Drawing.Point(3, 123);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(263, 54);
            this.employeesButton.TabIndex = 1;
            this.employeesButton.Text = "Employees CRUD  ";
            this.employeesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // customerCRUD
            // 
            this.customerCRUD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerCRUD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerCRUD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerCRUD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerCRUD.FillColor = System.Drawing.Color.Transparent;
            this.customerCRUD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.customerCRUD.ForeColor = System.Drawing.Color.White;
            this.customerCRUD.Image = ((System.Drawing.Image)(resources.GetObject("customerCRUD.Image")));
            this.customerCRUD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerCRUD.Location = new System.Drawing.Point(3, 183);
            this.customerCRUD.Name = "customerCRUD";
            this.customerCRUD.Size = new System.Drawing.Size(263, 54);
            this.customerCRUD.TabIndex = 2;
            this.customerCRUD.Text = "Customers CRUD  ";
            this.customerCRUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.customerCRUD.Click += new System.EventHandler(this.customerCRUD_Click);
            // 
            // notificationBtn
            // 
            this.notificationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notificationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notificationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notificationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notificationBtn.FillColor = System.Drawing.Color.Transparent;
            this.notificationBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationBtn.ForeColor = System.Drawing.Color.White;
            this.notificationBtn.Image = ((System.Drawing.Image)(resources.GetObject("notificationBtn.Image")));
            this.notificationBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notificationBtn.Location = new System.Drawing.Point(3, 243);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(263, 54);
            this.notificationBtn.TabIndex = 3;
            this.notificationBtn.Text = "Send Notification   ";
            this.notificationBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.notificationBtn.Click += new System.EventHandler(this.notificationBtn_Click);
            // 
            // addAdminButton
            // 
            this.addAdminButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addAdminButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addAdminButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addAdminButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addAdminButton.FillColor = System.Drawing.Color.Transparent;
            this.addAdminButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminButton.ForeColor = System.Drawing.Color.White;
            this.addAdminButton.Image = ((System.Drawing.Image)(resources.GetObject("addAdminButton.Image")));
            this.addAdminButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addAdminButton.Location = new System.Drawing.Point(3, 303);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(263, 54);
            this.addAdminButton.TabIndex = 4;
            this.addAdminButton.Text = "Add admin            ";
            this.addAdminButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addAdminButton.Click += new System.EventHandler(this.addAdminButton_Click);
            // 
            // tablesCRUDBtn
            // 
            this.tablesCRUDBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tablesCRUDBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tablesCRUDBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tablesCRUDBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tablesCRUDBtn.FillColor = System.Drawing.Color.Transparent;
            this.tablesCRUDBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesCRUDBtn.ForeColor = System.Drawing.Color.White;
            this.tablesCRUDBtn.Image = ((System.Drawing.Image)(resources.GetObject("tablesCRUDBtn.Image")));
            this.tablesCRUDBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tablesCRUDBtn.Location = new System.Drawing.Point(3, 363);
            this.tablesCRUDBtn.Name = "tablesCRUDBtn";
            this.tablesCRUDBtn.Size = new System.Drawing.Size(263, 54);
            this.tablesCRUDBtn.TabIndex = 5;
            this.tablesCRUDBtn.Text = "Tables CRUD         ";
            this.tablesCRUDBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tablesCRUDBtn.Click += new System.EventHandler(this.productsCRUDBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.feedbackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.feedbackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.feedbackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.feedbackBtn.FillColor = System.Drawing.Color.Transparent;
            this.feedbackBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.White;
            this.feedbackBtn.Image = ((System.Drawing.Image)(resources.GetObject("feedbackBtn.Image")));
            this.feedbackBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.feedbackBtn.Location = new System.Drawing.Point(3, 423);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(263, 54);
            this.feedbackBtn.TabIndex = 6;
            this.feedbackBtn.Text = "Manage Feedback  ";
            this.feedbackBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.feedbackBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsBtn.FillColor = System.Drawing.Color.Transparent;
            this.settingsBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.Location = new System.Drawing.Point(3, 483);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(263, 54);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.Text = "Settings                 ";
            this.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.settingsBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // Navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sidebar);
            this.Name = "Navbar";
            this.Size = new System.Drawing.Size(267, 537);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button dashboardButton;
        private Guna.UI2.WinForms.Guna2Button employeesButton;
        private Guna.UI2.WinForms.Guna2Button customerCRUD;
        private Guna.UI2.WinForms.Guna2Button notificationBtn;
        private Guna.UI2.WinForms.Guna2Button addAdminButton;
        private Guna.UI2.WinForms.Guna2Button tablesCRUDBtn;
        private Guna.UI2.WinForms.Guna2Button feedbackBtn;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
    }
}
