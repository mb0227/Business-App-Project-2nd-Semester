namespace RMS.UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCart));
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.cartGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuComboBox
            // 
            this.menuComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(461, 361);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(235, 37);
            this.menuComboBox.TabIndex = 1;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(316, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 34);
            this.label2.TabIndex = 32;
            this.label2.Text = "Product";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(317, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "Variant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantitiesComboBox
            // 
            this.quantitiesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantitiesComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitiesComboBox.FormattingEnabled = true;
            this.quantitiesComboBox.Location = new System.Drawing.Point(461, 429);
            this.quantitiesComboBox.Name = "quantitiesComboBox";
            this.quantitiesComboBox.Size = new System.Drawing.Size(235, 37);
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
            this.name.Location = new System.Drawing.Point(461, 237);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(235, 41);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(315, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 34);
            this.label3.TabIndex = 39;
            this.label3.Text = "Search ";
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
            this.panel1.Size = new System.Drawing.Size(1274, 91);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(118, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 625);
            this.panel2.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(572, 20);
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
            this.searchButton.FillColor = System.Drawing.Color.SteelBlue;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(516, 288);
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
            this.updateButton.Location = new System.Drawing.Point(516, 502);
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
            this.backButton.Location = new System.Drawing.Point(417, 585);
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
            this.deleteButton.Location = new System.Drawing.Point(321, 502);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 58);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cartGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cartGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cartGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cartGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cartGridView.ColumnHeadersHeight = 30;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.cartGridView.EnableHeadersVisualStyles = true;
            this.cartGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.cartGridView.Location = new System.Drawing.Point(717, 224);
            this.cartGridView.MultiSelect = false;
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ReadOnly = true;
            this.cartGridView.RowHeadersVisible = false;
            this.cartGridView.RowHeadersWidth = 62;
            this.cartGridView.RowTemplate.Height = 28;
            this.cartGridView.Size = new System.Drawing.Size(562, 511);
            this.cartGridView.TabIndex = 47;
            this.cartGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.cartGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cartGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cartGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cartGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cartGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cartGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cartGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.cartGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cartGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cartGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cartGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cartGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.cartGridView.ThemeStyle.ReadOnly = true;
            this.cartGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cartGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cartGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.cartGridView.ThemeStyle.RowsStyle.Height = 28;
            this.cartGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.cartGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.cartGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.quantitiesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "ViewCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewCart";
            this.Load += new System.EventHandler(this.ViewCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.Label label2;
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
        private Guna.UI2.WinForms.Guna2DataGridView cartGridView;
    }
}