namespace SSC.UI
{
    partial class ViewCart
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
            this.components = new System.ComponentModel.Container();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.quantitiesComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuComboBox
            // 
            this.menuComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(472, 338);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(182, 37);
            this.menuComboBox.TabIndex = 1;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(246, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 34);
            this.label2.TabIndex = 32;
            this.label2.Text = "Select Item";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartGridView
            // 
            this.cartGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cartGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cartGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cartGridView.Location = new System.Drawing.Point(700, 269);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ReadOnly = true;
            this.cartGridView.RowHeadersWidth = 62;
            this.cartGridView.RowTemplate.Height = 28;
            this.cartGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cartGridView.Size = new System.Drawing.Size(455, 388);
            this.cartGridView.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(247, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "Select Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantitiesComboBox
            // 
            this.quantitiesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantitiesComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitiesComboBox.FormattingEnabled = true;
            this.quantitiesComboBox.Location = new System.Drawing.Point(472, 406);
            this.quantitiesComboBox.Name = "quantitiesComboBox";
            this.quantitiesComboBox.Size = new System.Drawing.Size(182, 37);
            this.quantitiesComboBox.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Tahoma", 14F);
            this.name.Location = new System.Drawing.Point(472, 269);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(182, 41);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(246, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 39;
            this.label3.Text = "Search Item";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(54, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 91);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(118, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 625);
            this.panel2.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(497, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 52);
            this.label4.TabIndex = 6;
            this.label4.Text = "View Cart";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.BorderColor = System.Drawing.Color.Transparent;
            this.searchButton.BorderRadius = 18;
            this.searchButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.FillColor = System.Drawing.Color.Teal;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(252, 520);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(180, 58);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.BorderColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 18;
            this.updateButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.Orange;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(472, 520);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(180, 58);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BorderColor = System.Drawing.Color.Transparent;
            this.backButton.BorderRadius = 18;
            this.backButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.FillColor = System.Drawing.Color.DarkTurquoise;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(252, 599);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(180, 58);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BorderColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 18;
            this.deleteButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(472, 599);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 58);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.quantitiesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuComboBox);
            this.MinimumSize = new System.Drawing.Size(1130, 900);
            this.Name = "ViewCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewCart";
            this.Load += new System.EventHandler(this.ViewCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox quantitiesComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
    }
}