namespace RMS.UI
{
    partial class ManageTables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTables));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.capacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteTableBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewTableBtn = new Guna.UI2.WinForms.Guna2Button();
            this.makeTableBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(56, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1274, 91);
            this.panel4.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(502, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Tables";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel3.Controls.Add(this.guna2DataGridView1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.capacity);
            this.panel3.Controls.Add(this.deleteTableBtn);
            this.panel3.Controls.Add(this.viewTableBtn);
            this.panel3.Controls.Add(this.makeTableBtn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(56, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1274, 880);
            this.panel3.TabIndex = 24;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = true;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(303, 180);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.Size = new System.Drawing.Size(825, 479);
            this.guna2DataGridView1.TabIndex = 51;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(777, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Booked",
            "Unbooked"});
            this.comboBox1.Location = new System.Drawing.Point(881, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 37);
            this.comboBox1.TabIndex = 15;
            // 
            // capacity
            // 
            this.capacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.capacity.BorderThickness = 0;
            this.capacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacity.DefaultText = "";
            this.capacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.capacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.capacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.capacity.ForeColor = System.Drawing.Color.Black;
            this.capacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacity.Location = new System.Drawing.Point(519, 23);
            this.capacity.Margin = new System.Windows.Forms.Padding(4);
            this.capacity.Name = "capacity";
            this.capacity.PasswordChar = '\0';
            this.capacity.PlaceholderText = "";
            this.capacity.SelectedText = "";
            this.capacity.Size = new System.Drawing.Size(219, 44);
            this.capacity.TabIndex = 13;
            // 
            // deleteTableBtn
            // 
            this.deleteTableBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteTableBtn.BorderColor = System.Drawing.Color.Transparent;
            this.deleteTableBtn.BorderRadius = 18;
            this.deleteTableBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.deleteTableBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteTableBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteTableBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteTableBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteTableBtn.FillColor = System.Drawing.Color.Red;
            this.deleteTableBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTableBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteTableBtn.Location = new System.Drawing.Point(890, 90);
            this.deleteTableBtn.Name = "deleteTableBtn";
            this.deleteTableBtn.Size = new System.Drawing.Size(245, 65);
            this.deleteTableBtn.TabIndex = 3;
            this.deleteTableBtn.Text = "Delete Table";
            this.deleteTableBtn.Click += new System.EventHandler(this.deleteTableBtn_Click);
            // 
            // viewTableBtn
            // 
            this.viewTableBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewTableBtn.BorderColor = System.Drawing.Color.Transparent;
            this.viewTableBtn.BorderRadius = 18;
            this.viewTableBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewTableBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewTableBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewTableBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewTableBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewTableBtn.FillColor = System.Drawing.Color.Orange;
            this.viewTableBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTableBtn.ForeColor = System.Drawing.Color.Black;
            this.viewTableBtn.Location = new System.Drawing.Point(605, 90);
            this.viewTableBtn.Name = "viewTableBtn";
            this.viewTableBtn.Size = new System.Drawing.Size(248, 65);
            this.viewTableBtn.TabIndex = 2;
            this.viewTableBtn.Text = "Update Table";
            this.viewTableBtn.Click += new System.EventHandler(this.viewTableBtn_Click);
            // 
            // makeTableBtn
            // 
            this.makeTableBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.makeTableBtn.BorderColor = System.Drawing.Color.Transparent;
            this.makeTableBtn.BorderRadius = 18;
            this.makeTableBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.makeTableBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.makeTableBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.makeTableBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.makeTableBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.makeTableBtn.FillColor = System.Drawing.Color.Lime;
            this.makeTableBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTableBtn.ForeColor = System.Drawing.Color.Black;
            this.makeTableBtn.Location = new System.Drawing.Point(310, 90);
            this.makeTableBtn.Name = "makeTableBtn";
            this.makeTableBtn.Size = new System.Drawing.Size(248, 65);
            this.makeTableBtn.TabIndex = 1;
            this.makeTableBtn.Text = "Make new Table";
            this.makeTableBtn.Click += new System.EventHandler(this.makeTableBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(307, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter Capacity";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ManageTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "ManageTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManageTables";
            this.Load += new System.EventHandler(this.ManageTables_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox capacity;
        private Guna.UI2.WinForms.Guna2Button deleteTableBtn;
        private Guna.UI2.WinForms.Guna2Button viewTableBtn;
        private Guna.UI2.WinForms.Guna2Button makeTableBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}