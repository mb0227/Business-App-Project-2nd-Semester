namespace SSC.UI
{
    partial class ManageCustomers
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clearCartButton = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(52, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1126, 91);
            this.panel4.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(397, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Customers";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.clearCartButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.menuGridView);
            this.panel1.Location = new System.Drawing.Point(164, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 657);
            this.panel1.TabIndex = 23;
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
            this.searchBtn.Location = new System.Drawing.Point(228, 461);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(182, 64);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            // 
            // clearCartButton
            // 
            this.clearCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearCartButton.BorderColor = System.Drawing.Color.Transparent;
            this.clearCartButton.BorderRadius = 18;
            this.clearCartButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.clearCartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearCartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearCartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearCartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearCartButton.FillColor = System.Drawing.Color.Red;
            this.clearCartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCartButton.ForeColor = System.Drawing.Color.Black;
            this.clearCartButton.Location = new System.Drawing.Point(695, 460);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(190, 65);
            this.clearCartButton.TabIndex = 7;
            this.clearCartButton.Text = "Delete";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(128, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 36);
            this.label6.TabIndex = 42;
            this.label6.Text = "Search Item";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(329, 304);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(182, 41);
            this.name.TabIndex = 3;
            // 
            // menuGridView
            // 
            this.menuGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.menuGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.menuGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuGridView.Location = new System.Drawing.Point(608, 51);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.RowHeadersWidth = 62;
            this.menuGridView.RowTemplate.Height = 28;
            this.menuGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.menuGridView.Size = new System.Drawing.Size(357, 367);
            this.menuGridView.TabIndex = 12;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.MaximumSize = new System.Drawing.Size(1200, 1000);
            this.MinimumSize = new System.Drawing.Size(1070, 889);
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManageCustomers";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2Button clearCartButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView menuGridView;
    }
}