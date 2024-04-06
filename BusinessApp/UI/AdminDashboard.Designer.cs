namespace SSC.UI
{
    partial class AdminDashboard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.viewButton = new Guna.UI2.WinForms.Guna2Button();
            this.orderButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearCartButton = new Guna.UI2.WinForms.Guna2Button();
            this.sortGridView = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.quantitiesComboBox = new System.Windows.Forms.ComboBox();
            this.comments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(55, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1126, 91);
            this.panel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(481, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Food";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.viewButton);
            this.panel1.Controls.Add(this.orderButton);
            this.panel1.Controls.Add(this.clearCartButton);
            this.panel1.Controls.Add(this.sortGridView);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.quantitiesComboBox);
            this.panel1.Controls.Add(this.comments);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.menuGridView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuComboBox);
            this.panel1.Location = new System.Drawing.Point(163, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 657);
            this.panel1.TabIndex = 21;
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
            this.searchBtn.Location = new System.Drawing.Point(329, 376);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(182, 54);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.BorderColor = System.Drawing.Color.Transparent;
            this.addButton.BorderRadius = 18;
            this.addButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(67, 460);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(190, 65);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add to Cart";
            // 
            // viewButton
            // 
            this.viewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewButton.BorderColor = System.Drawing.Color.Transparent;
            this.viewButton.BorderRadius = 18;
            this.viewButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewButton.FillColor = System.Drawing.Color.Teal;
            this.viewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.Black;
            this.viewButton.Location = new System.Drawing.Point(298, 460);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(190, 65);
            this.viewButton.TabIndex = 6;
            this.viewButton.Text = "View Cart";
            // 
            // orderButton
            // 
            this.orderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderButton.BorderColor = System.Drawing.Color.Transparent;
            this.orderButton.BorderRadius = 18;
            this.orderButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.orderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderButton.FillColor = System.Drawing.Color.SpringGreen;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.Black;
            this.orderButton.Location = new System.Drawing.Point(782, 460);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(190, 65);
            this.orderButton.TabIndex = 8;
            this.orderButton.Text = "Place Order";
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
            this.clearCartButton.Location = new System.Drawing.Point(539, 460);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(190, 65);
            this.clearCartButton.TabIndex = 7;
            this.clearCartButton.Text = "Clear Cart";
            // 
            // sortGridView
            // 
            this.sortGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortGridView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortGridView.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGridView.FormattingEnabled = true;
            this.sortGridView.Items.AddRange(new object[] {
            "Sort By",
            "ProductName",
            "Price",
            "Stock"});
            this.sortGridView.Location = new System.Drawing.Point(825, 25);
            this.sortGridView.Name = "sortGridView";
            this.sortGridView.Size = new System.Drawing.Size(131, 27);
            this.sortGridView.TabIndex = 43;
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
            // quantitiesComboBox
            // 
            this.quantitiesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantitiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantitiesComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitiesComboBox.FormattingEnabled = true;
            this.quantitiesComboBox.Location = new System.Drawing.Point(329, 113);
            this.quantitiesComboBox.Name = "quantitiesComboBox";
            this.quantitiesComboBox.Size = new System.Drawing.Size(182, 37);
            this.quantitiesComboBox.TabIndex = 1;
            // 
            // comments
            // 
            this.comments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments.Location = new System.Drawing.Point(329, 176);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(182, 102);
            this.comments.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(128, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Comments";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.menuGridView.Location = new System.Drawing.Point(599, 63);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.RowHeadersWidth = 62;
            this.menuGridView.RowTemplate.Height = 28;
            this.menuGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.menuGridView.Size = new System.Drawing.Size(357, 367);
            this.menuGridView.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(128, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(126, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuComboBox
            // 
            this.menuComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(329, 51);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(182, 37);
            this.menuComboBox.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1070, 889);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "7";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button viewButton;
        private Guna.UI2.WinForms.Guna2Button orderButton;
        private Guna.UI2.WinForms.Guna2Button clearCartButton;
        private System.Windows.Forms.ComboBox sortGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox quantitiesComboBox;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox menuComboBox;
    }
}