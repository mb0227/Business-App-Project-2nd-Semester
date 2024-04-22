namespace RMS.UI
{
    partial class ChefDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefDashboard));
            this.panel3 = new System.Windows.Forms.Panel();
            this.manageOrders = new Guna.UI2.WinForms.Guna2Button();
            this.manageBtns = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.manageOrders);
            this.panel3.Controls.Add(this.manageBtns);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-4, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 91);
            this.panel3.TabIndex = 21;
            // 
            // manageOrders
            // 
            this.manageOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageOrders.BorderColor = System.Drawing.Color.Transparent;
            this.manageOrders.BorderRadius = 18;
            this.manageOrders.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.manageOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.manageOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageOrders.ForeColor = System.Drawing.Color.Black;
            this.manageOrders.Location = new System.Drawing.Point(910, 6);
            this.manageOrders.Name = "manageOrders";
            this.manageOrders.Size = new System.Drawing.Size(260, 82);
            this.manageOrders.TabIndex = 46;
            this.manageOrders.Text = "Manage Orders";
            this.manageOrders.Click += new System.EventHandler(this.manageOrders_Click);
            // 
            // manageBtns
            // 
            this.manageBtns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageBtns.BorderColor = System.Drawing.Color.Transparent;
            this.manageBtns.BorderRadius = 18;
            this.manageBtns.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.manageBtns.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageBtns.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageBtns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageBtns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageBtns.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.manageBtns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBtns.ForeColor = System.Drawing.Color.Black;
            this.manageBtns.Location = new System.Drawing.Point(644, 2);
            this.manageBtns.Name = "manageBtns";
            this.manageBtns.Size = new System.Drawing.Size(260, 88);
            this.manageBtns.TabIndex = 45;
            this.manageBtns.Text = "Manage Products";
            this.manageBtns.Click += new System.EventHandler(this.manageBtns_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(58, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chef Dashboard";
            // 
            // logOut
            // 
            this.logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(1098, 96);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(68, 66);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOut.TabIndex = 22;
            this.logOut.TabStop = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // ChefDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 889);
            this.Name = "ChefDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChefDashboard";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button manageOrders;
        private Guna.UI2.WinForms.Guna2Button manageBtns;
        private System.Windows.Forms.PictureBox logOut;
    }
}