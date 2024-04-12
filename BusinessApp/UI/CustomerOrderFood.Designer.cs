namespace SSC.UI
{
    partial class CustomerOrderFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderFood));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deleteOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.orderDealBtn = new Guna.UI2.WinForms.Guna2Button();
            this.trackOrderBtn = new Guna.UI2.WinForms.Guna2Button();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(130, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(130, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Variant";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuComboBox
            // 
            this.menuComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuComboBox.BackColor = System.Drawing.Color.LightGray;
            this.menuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(307, 210);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(247, 37);
            this.menuComboBox.TabIndex = 0;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.menuGridView);
            this.panel1.Controls.Add(this.deleteOrderBtn);
            this.panel1.Controls.Add(this.orderDealBtn);
            this.panel1.Controls.Add(this.trackOrderBtn);
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuComboBox);
            this.panel1.Location = new System.Drawing.Point(163, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 886);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.menuGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.menuGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.menuGridView.ColumnHeadersHeight = 20;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.menuGridView.EnableHeadersVisualStyles = true;
            this.menuGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.menuGridView.Location = new System.Drawing.Point(584, 103);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.RowHeadersVisible = false;
            this.menuGridView.RowHeadersWidth = 62;
            this.menuGridView.RowTemplate.Height = 28;
            this.menuGridView.Size = new System.Drawing.Size(527, 389);
            this.menuGridView.TabIndex = 46;
            this.menuGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.menuGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.menuGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.menuGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.menuGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.menuGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.menuGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.menuGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.menuGridView.ThemeStyle.ReadOnly = true;
            this.menuGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.menuGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.menuGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.menuGridView.ThemeStyle.RowsStyle.Height = 28;
            this.menuGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.menuGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteOrderBtn.BorderColor = System.Drawing.Color.Transparent;
            this.deleteOrderBtn.BorderRadius = 18;
            this.deleteOrderBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.deleteOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteOrderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteOrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteOrderBtn.Location = new System.Drawing.Point(783, 630);
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            this.deleteOrderBtn.Size = new System.Drawing.Size(190, 65);
            this.deleteOrderBtn.TabIndex = 12;
            this.deleteOrderBtn.Text = "Delete Order";
            this.deleteOrderBtn.Visible = false;
            this.deleteOrderBtn.Click += new System.EventHandler(this.deleteOrderBtn_Click);
            // 
            // orderDealBtn
            // 
            this.orderDealBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDealBtn.BorderColor = System.Drawing.Color.Transparent;
            this.orderDealBtn.BorderRadius = 18;
            this.orderDealBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.orderDealBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderDealBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderDealBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderDealBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderDealBtn.FillColor = System.Drawing.Color.MediumOrchid;
            this.orderDealBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDealBtn.ForeColor = System.Drawing.Color.Black;
            this.orderDealBtn.Location = new System.Drawing.Point(783, 540);
            this.orderDealBtn.Name = "orderDealBtn";
            this.orderDealBtn.Size = new System.Drawing.Size(190, 68);
            this.orderDealBtn.TabIndex = 7;
            this.orderDealBtn.Text = "Order Deal";
            this.orderDealBtn.Click += new System.EventHandler(this.orderDealBtn_Click);
            // 
            // trackOrderBtn
            // 
            this.trackOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackOrderBtn.BorderColor = System.Drawing.Color.Transparent;
            this.trackOrderBtn.BorderRadius = 18;
            this.trackOrderBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.trackOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.trackOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.trackOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.trackOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.trackOrderBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.trackOrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackOrderBtn.ForeColor = System.Drawing.Color.Black;
            this.trackOrderBtn.Location = new System.Drawing.Point(572, 543);
            this.trackOrderBtn.Name = "trackOrderBtn";
            this.trackOrderBtn.Size = new System.Drawing.Size(190, 65);
            this.trackOrderBtn.TabIndex = 10;
            this.trackOrderBtn.TabStop = false;
            this.trackOrderBtn.Text = "Track Order";
            this.trackOrderBtn.Click += new System.EventHandler(this.trackOrderBtn_Click);
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
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(362, 125);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(190, 58);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.addButton.Location = new System.Drawing.Point(136, 452);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(190, 65);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add to Cart";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.viewButton.Location = new System.Drawing.Point(348, 543);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(190, 65);
            this.viewButton.TabIndex = 9;
            this.viewButton.Text = "View Cart";
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
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
            this.orderButton.FillColor = System.Drawing.Color.Lime;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.Black;
            this.orderButton.Location = new System.Drawing.Point(348, 452);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(190, 65);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Place Order";
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
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
            this.clearCartButton.Location = new System.Drawing.Point(136, 543);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(190, 65);
            this.clearCartButton.TabIndex = 5;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
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
            "Variant",
            "Category"});
            this.sortGridView.Location = new System.Drawing.Point(980, 48);
            this.sortGridView.Name = "sortGridView";
            this.sortGridView.Size = new System.Drawing.Size(131, 27);
            this.sortGridView.TabIndex = 43;
            this.sortGridView.SelectedIndexChanged += new System.EventHandler(this.sortGridView_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(118, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 36);
            this.label6.TabIndex = 42;
            this.label6.Text = "Search Item";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.BackColor = System.Drawing.Color.LightGray;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.name.Location = new System.Drawing.Point(305, 64);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(247, 41);
            this.name.TabIndex = 3;
            this.name.WordWrap = false;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // quantitiesComboBox
            // 
            this.quantitiesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantitiesComboBox.BackColor = System.Drawing.Color.LightGray;
            this.quantitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantitiesComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitiesComboBox.FormattingEnabled = true;
            this.quantitiesComboBox.Location = new System.Drawing.Point(307, 272);
            this.quantitiesComboBox.Name = "quantitiesComboBox";
            this.quantitiesComboBox.Size = new System.Drawing.Size(247, 37);
            this.quantitiesComboBox.TabIndex = 1;
            // 
            // comments
            // 
            this.comments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comments.BackColor = System.Drawing.Color.LightGray;
            this.comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comments.Location = new System.Drawing.Point(307, 335);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(247, 89);
            this.comments.TabIndex = 2;
            this.comments.WordWrap = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(130, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Comments";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(51, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1276, 91);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(1150, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox.Size = new System.Drawing.Size(77, 76);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(556, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Food";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(801, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 52);
            this.label5.TabIndex = 24;
            this.label5.Text = "Menu";
            // 
            // CustomerOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "CustomerOrderFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CustomerOrderFood";
            this.Load += new System.EventHandler(this.CustomerOrderFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox quantitiesComboBox;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox sortGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button viewButton;
        private Guna.UI2.WinForms.Guna2Button orderButton;
        private Guna.UI2.WinForms.Guna2Button clearCartButton;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button trackOrderBtn;
        private Guna.UI2.WinForms.Guna2Button orderDealBtn;
        private Guna.UI2.WinForms.Guna2Button deleteOrderBtn;
        private Guna.UI2.WinForms.Guna2DataGridView menuGridView;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox;
        private System.Windows.Forms.Label label5;
    }
}