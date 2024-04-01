namespace SignInSignUp
{
    partial class CustomerNavBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerNavBar));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.settingButton = new Guna.UI2.WinForms.Guna2Button();
            this.helpButton = new Guna.UI2.WinForms.Guna2Button();
            this.feedbackButton = new Guna.UI2.WinForms.Guna2Button();
            this.reservationButton = new Guna.UI2.WinForms.Guna2Button();
            this.orderFoodButton = new Guna.UI2.WinForms.Guna2Button();
            this.dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bars = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bars)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // settingButton
            // 
            this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingButton.BackColor = System.Drawing.Color.Transparent;
            this.settingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.settingButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.ForeColor = System.Drawing.Color.White;
            this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
            this.settingButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingButton.Location = new System.Drawing.Point(3, 355);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(216, 53);
            this.settingButton.TabIndex = 5;
            this.settingButton.Text = "Settings";
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.helpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.helpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.helpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.helpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.helpButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = global::SignInSignUp.Properties.Resources.icons8_help_50__1_;
            this.helpButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.helpButton.Location = new System.Drawing.Point(3, 296);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(216, 53);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help              ";
            this.helpButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click_1);
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.Transparent;
            this.feedbackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.feedbackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.feedbackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.feedbackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.feedbackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.feedbackButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackButton.ForeColor = System.Drawing.Color.White;
            this.feedbackButton.Image = global::SignInSignUp.Properties.Resources.icons8_feedback_50__1_;
            this.feedbackButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.feedbackButton.Location = new System.Drawing.Point(3, 237);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(216, 53);
            this.feedbackButton.TabIndex = 3;
            this.feedbackButton.Text = "   Feedback";
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click_1);
            // 
            // reservationButton
            // 
            this.reservationButton.BackColor = System.Drawing.Color.Transparent;
            this.reservationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reservationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reservationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reservationButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.reservationButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationButton.ForeColor = System.Drawing.Color.White;
            this.reservationButton.Image = global::SignInSignUp.Properties.Resources.icons8_reservation_50__1_;
            this.reservationButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reservationButton.Location = new System.Drawing.Point(3, 178);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(216, 53);
            this.reservationButton.TabIndex = 2;
            this.reservationButton.Text = "      Reservation";
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // orderFoodButton
            // 
            this.orderFoodButton.BackColor = System.Drawing.Color.Transparent;
            this.orderFoodButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderFoodButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderFoodButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderFoodButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderFoodButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.orderFoodButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderFoodButton.ForeColor = System.Drawing.Color.White;
            this.orderFoodButton.Image = global::SignInSignUp.Properties.Resources.icons8_order_food_60;
            this.orderFoodButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderFoodButton.Location = new System.Drawing.Point(3, 119);
            this.orderFoodButton.Name = "orderFoodButton";
            this.orderFoodButton.Size = new System.Drawing.Size(216, 53);
            this.orderFoodButton.TabIndex = 1;
            this.orderFoodButton.Text = "     Order Food";
            this.orderFoodButton.Click += new System.EventHandler(this.orderFoodButton_Click_1);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Transparent;
            this.dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dashboard.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboard.Location = new System.Drawing.Point(3, 59);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(216, 54);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "    Dashboard";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bars);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 50);
            this.panel1.TabIndex = 6;
            // 
            // bars
            // 
            this.bars.Image = global::SignInSignUp.Properties.Resources.bars_solid;
            this.bars.Location = new System.Drawing.Point(6, 3);
            this.bars.Name = "bars";
            this.bars.Size = new System.Drawing.Size(48, 44);
            this.bars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bars.TabIndex = 0;
            this.bars.TabStop = false;
            this.bars.Click += new System.EventHandler(this.bars_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.dashboard);
            this.sidebar.Controls.Add(this.orderFoodButton);
            this.sidebar.Controls.Add(this.reservationButton);
            this.sidebar.Controls.Add(this.feedbackButton);
            this.sidebar.Controls.Add(this.helpButton);
            this.sidebar.Controls.Add(this.settingButton);
            this.sidebar.Location = new System.Drawing.Point(0, -1);
            this.sidebar.MaximumSize = new System.Drawing.Size(219, 1080);
            this.sidebar.MinimumSize = new System.Drawing.Size(59, 1080);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(219, 1080);
            this.sidebar.TabIndex = 0;
            // 
            // CustomerNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "CustomerNavBar";
            this.Size = new System.Drawing.Size(219, 451);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bars)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Button settingButton;
        private Guna.UI2.WinForms.Guna2Button helpButton;
        private Guna.UI2.WinForms.Guna2Button feedbackButton;
        private Guna.UI2.WinForms.Guna2Button reservationButton;
        private Guna.UI2.WinForms.Guna2Button orderFoodButton;
        private Guna.UI2.WinForms.Guna2Button dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bars;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
    }
}
