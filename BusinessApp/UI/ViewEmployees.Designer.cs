namespace SignInSignUp.UI
{
    partial class ViewEmployees
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewWaiterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewChefBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.viewAdmins = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.viewAdmins);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.viewWaiterBtn);
            this.panel1.Controls.Add(this.viewChefBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(52, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 830);
            this.panel1.TabIndex = 25;
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backbtn.BorderColor = System.Drawing.Color.Transparent;
            this.backbtn.BorderRadius = 18;
            this.backbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.backbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbtn.FillColor = System.Drawing.Color.MediumOrchid;
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.Black;
            this.backbtn.Location = new System.Drawing.Point(888, 38);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(203, 64);
            this.backbtn.TabIndex = 43;
            this.backbtn.Text = "Back to All";
            this.backbtn.Visible = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // viewWaiterBtn
            // 
            this.viewWaiterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewWaiterBtn.BorderColor = System.Drawing.Color.Transparent;
            this.viewWaiterBtn.BorderRadius = 18;
            this.viewWaiterBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewWaiterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewWaiterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewWaiterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewWaiterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewWaiterBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.viewWaiterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewWaiterBtn.ForeColor = System.Drawing.Color.Black;
            this.viewWaiterBtn.Location = new System.Drawing.Point(762, 108);
            this.viewWaiterBtn.Name = "viewWaiterBtn";
            this.viewWaiterBtn.Size = new System.Drawing.Size(230, 64);
            this.viewWaiterBtn.TabIndex = 4;
            this.viewWaiterBtn.Text = "View Waiters";
            this.viewWaiterBtn.Click += new System.EventHandler(this.viewWaiterBtn_Click);
            // 
            // viewChefBtn
            // 
            this.viewChefBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewChefBtn.BorderColor = System.Drawing.Color.Transparent;
            this.viewChefBtn.BorderRadius = 18;
            this.viewChefBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewChefBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewChefBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewChefBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewChefBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewChefBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.viewChefBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewChefBtn.ForeColor = System.Drawing.Color.Black;
            this.viewChefBtn.Location = new System.Drawing.Point(318, 108);
            this.viewChefBtn.Name = "viewChefBtn";
            this.viewChefBtn.Size = new System.Drawing.Size(206, 64);
            this.viewChefBtn.TabIndex = 3;
            this.viewChefBtn.Text = "View Chefs";
            this.viewChefBtn.Click += new System.EventHandler(this.viewChefBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BorderColor = System.Drawing.Color.Transparent;
            this.searchBtn.BorderRadius = 18;
            this.searchBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBtn.FillColor = System.Drawing.Color.Orange;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(457, 178);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(170, 64);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BorderColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderRadius = 18;
            this.deleteBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(691, 178);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(190, 65);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(282, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 36);
            this.label6.TabIndex = 42;
            this.label6.Text = "Search Employee";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(535, 50);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(300, 41);
            this.name.TabIndex = 0;
            this.name.WordWrap = false;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(260, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(764, 374);
            this.dataGridView1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(53, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1126, 98);
            this.panel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(397, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Employees";
            // 
            // viewAdmins
            // 
            this.viewAdmins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewAdmins.BorderColor = System.Drawing.Color.Transparent;
            this.viewAdmins.BorderRadius = 18;
            this.viewAdmins.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewAdmins.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewAdmins.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewAdmins.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewAdmins.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewAdmins.FillColor = System.Drawing.Color.Teal;
            this.viewAdmins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAdmins.ForeColor = System.Drawing.Color.Black;
            this.viewAdmins.Location = new System.Drawing.Point(535, 108);
            this.viewAdmins.Name = "viewAdmins";
            this.viewAdmins.Size = new System.Drawing.Size(221, 64);
            this.viewAdmins.TabIndex = 44;
            this.viewAdmins.Text = "View Admins";
            this.viewAdmins.Click += new System.EventHandler(this.viewAdmins_Click);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 998);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.MinimumSize = new System.Drawing.Size(1100, 1030);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.Load += new System.EventHandler(this.ViewEmployees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button backbtn;
        private Guna.UI2.WinForms.Guna2Button viewWaiterBtn;
        private Guna.UI2.WinForms.Guna2Button viewChefBtn;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button viewAdmins;
    }
}