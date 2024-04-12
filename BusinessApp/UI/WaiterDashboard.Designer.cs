namespace SignInSignUp.UI
{
    partial class WaiterDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterDashboard));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pickupOrder = new Guna.UI2.WinForms.Guna2Button();
            this.reservationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deliverOrder = new Guna.UI2.WinForms.Guna2Button();
            this.manageBtns = new Guna.UI2.WinForms.Guna2Button();
            this.header = new System.Windows.Forms.Label();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.quantitiesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.comments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderDealBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.orderButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearCartButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.deals = new System.Windows.Forms.ComboBox();
            this.payment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pickupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deliverBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.pickupOrder);
            this.panel3.Controls.Add(this.reservationBtn);
            this.panel3.Controls.Add(this.deliverOrder);
            this.panel3.Controls.Add(this.manageBtns);
            this.panel3.Controls.Add(this.header);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1330, 91);
            this.panel3.TabIndex = 22;
            // 
            // pickupOrder
            // 
            this.pickupOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickupOrder.BorderColor = System.Drawing.Color.Transparent;
            this.pickupOrder.BorderRadius = 18;
            this.pickupOrder.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pickupOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pickupOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pickupOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pickupOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pickupOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pickupOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupOrder.ForeColor = System.Drawing.Color.Black;
            this.pickupOrder.Location = new System.Drawing.Point(778, 4);
            this.pickupOrder.Name = "pickupOrder";
            this.pickupOrder.Size = new System.Drawing.Size(128, 88);
            this.pickupOrder.TabIndex = 67;
            this.pickupOrder.Text = "Pickup";
            this.pickupOrder.Click += new System.EventHandler(this.pickupOrder_Click);
            // 
            // reservationBtn
            // 
            this.reservationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationBtn.BorderColor = System.Drawing.Color.Transparent;
            this.reservationBtn.BorderRadius = 18;
            this.reservationBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.reservationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reservationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reservationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reservationBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.reservationBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationBtn.ForeColor = System.Drawing.Color.Black;
            this.reservationBtn.Location = new System.Drawing.Point(1057, 4);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(247, 88);
            this.reservationBtn.TabIndex = 48;
            this.reservationBtn.Text = "View Reservations";
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // deliverOrder
            // 
            this.deliverOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliverOrder.BorderColor = System.Drawing.Color.Transparent;
            this.deliverOrder.BorderRadius = 18;
            this.deliverOrder.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.deliverOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deliverOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deliverOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deliverOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deliverOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.deliverOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverOrder.ForeColor = System.Drawing.Color.Black;
            this.deliverOrder.Location = new System.Drawing.Point(912, 4);
            this.deliverOrder.Name = "deliverOrder";
            this.deliverOrder.Size = new System.Drawing.Size(139, 88);
            this.deliverOrder.TabIndex = 47;
            this.deliverOrder.Text = "Deliver";
            this.deliverOrder.Click += new System.EventHandler(this.deliverOrder_Click);
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
            this.manageBtns.Location = new System.Drawing.Point(577, 4);
            this.manageBtns.Name = "manageBtns";
            this.manageBtns.Size = new System.Drawing.Size(168, 88);
            this.manageBtns.TabIndex = 45;
            this.manageBtns.Text = "Take Order";
            this.manageBtns.Click += new System.EventHandler(this.manageBtns_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.header.ForeColor = System.Drawing.Color.MintCream;
            this.header.Location = new System.Drawing.Point(6, 19);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(368, 52);
            this.header.TabIndex = 7;
            this.header.Text = "Waiter Dashboard";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.EnableHeadersVisualStyles = true;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dataGridView1.Location = new System.Drawing.Point(570, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(650, 479);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // quantitiesComboBox
            // 
            this.quantitiesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantitiesComboBox.BackColor = System.Drawing.Color.Silver;
            this.quantitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantitiesComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitiesComboBox.FormattingEnabled = true;
            this.quantitiesComboBox.Location = new System.Drawing.Point(286, 204);
            this.quantitiesComboBox.Name = "quantitiesComboBox";
            this.quantitiesComboBox.Size = new System.Drawing.Size(247, 37);
            this.quantitiesComboBox.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(97, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 36);
            this.label3.TabIndex = 53;
            this.label3.Text = "Variant";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(97, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 52;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuComboBox
            // 
            this.menuComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuComboBox.BackColor = System.Drawing.Color.Silver;
            this.menuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(286, 141);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(247, 37);
            this.menuComboBox.TabIndex = 50;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
            // 
            // comments
            // 
            this.comments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comments.BackColor = System.Drawing.Color.Silver;
            this.comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments.Location = new System.Drawing.Point(286, 263);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(245, 92);
            this.comments.TabIndex = 54;
            this.comments.WordWrap = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(97, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 36);
            this.label4.TabIndex = 55;
            this.label4.Text = "Comments";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.orderDealBtn.Location = new System.Drawing.Point(334, 536);
            this.orderDealBtn.Name = "orderDealBtn";
            this.orderDealBtn.Size = new System.Drawing.Size(190, 66);
            this.orderDealBtn.TabIndex = 59;
            this.orderDealBtn.Text = "Order Deal";
            this.orderDealBtn.Click += new System.EventHandler(this.orderDealBtn_Click);
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
            this.addButton.Location = new System.Drawing.Point(103, 459);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(190, 65);
            this.addButton.TabIndex = 56;
            this.addButton.Text = "Add to Cart";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.orderButton.Location = new System.Drawing.Point(334, 459);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(190, 65);
            this.orderButton.TabIndex = 58;
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
            this.clearCartButton.Location = new System.Drawing.Point(103, 537);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(190, 65);
            this.clearCartButton.TabIndex = 57;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.deals);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comments);
            this.panel1.Controls.Add(this.payment);
            this.panel1.Controls.Add(this.orderDealBtn);
            this.panel1.Controls.Add(this.quantitiesComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuComboBox);
            this.panel1.Controls.Add(this.clearCartButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.orderButton);
            this.panel1.Location = new System.Drawing.Point(12, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 670);
            this.panel1.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(97, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 36);
            this.label5.TabIndex = 64;
            this.label5.Text = "Deals";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deals
            // 
            this.deals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deals.BackColor = System.Drawing.Color.Silver;
            this.deals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deals.FormattingEnabled = true;
            this.deals.Location = new System.Drawing.Point(288, 80);
            this.deals.Name = "deals";
            this.deals.Size = new System.Drawing.Size(247, 37);
            this.deals.TabIndex = 63;
            // 
            // payment
            // 
            this.payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payment.BackColor = System.Drawing.Color.Silver;
            this.payment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(288, 390);
            this.payment.Multiline = true;
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(247, 49);
            this.payment.TabIndex = 61;
            this.payment.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(97, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 36);
            this.label2.TabIndex = 62;
            this.label2.Text = "Pay Method";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pickupBtn
            // 
            this.pickupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pickupBtn.BorderColor = System.Drawing.Color.Transparent;
            this.pickupBtn.BorderRadius = 18;
            this.pickupBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pickupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pickupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pickupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pickupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pickupBtn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.pickupBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupBtn.ForeColor = System.Drawing.Color.Black;
            this.pickupBtn.Location = new System.Drawing.Point(53, 121);
            this.pickupBtn.Name = "pickupBtn";
            this.pickupBtn.Size = new System.Drawing.Size(218, 57);
            this.pickupBtn.TabIndex = 65;
            this.pickupBtn.Text = "Pickup Order";
            this.pickupBtn.Visible = false;
            this.pickupBtn.Click += new System.EventHandler(this.deliver_Click);
            // 
            // deliverBtn
            // 
            this.deliverBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deliverBtn.BorderColor = System.Drawing.Color.Transparent;
            this.deliverBtn.BorderRadius = 18;
            this.deliverBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.deliverBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deliverBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deliverBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deliverBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deliverBtn.FillColor = System.Drawing.Color.Lime;
            this.deliverBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverBtn.ForeColor = System.Drawing.Color.Black;
            this.deliverBtn.Location = new System.Drawing.Point(300, 121);
            this.deliverBtn.Name = "deliverBtn";
            this.deliverBtn.Size = new System.Drawing.Size(218, 57);
            this.deliverBtn.TabIndex = 66;
            this.deliverBtn.Text = "Deliver Order";
            this.deliverBtn.Visible = false;
            this.deliverBtn.Click += new System.EventHandler(this.deliverBtn_Click);
            // 
            // logOut
            // 
            this.logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(1194, 97);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(68, 66);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOut.TabIndex = 67;
            this.logOut.TabStop = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // WaiterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.deliverBtn);
            this.Controls.Add(this.pickupBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "WaiterDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WaiterDashboard";
            this.Load += new System.EventHandler(this.WaiterDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button reservationBtn;
        private Guna.UI2.WinForms.Guna2Button deliverOrder;
        private Guna.UI2.WinForms.Guna2Button manageBtns;
        private System.Windows.Forms.Label header;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox quantitiesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button orderDealBtn;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button orderButton;
        private Guna.UI2.WinForms.Guna2Button clearCartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox deals;
        private Guna.UI2.WinForms.Guna2Button pickupBtn;
        private Guna.UI2.WinForms.Guna2Button deliverBtn;
        private Guna.UI2.WinForms.Guna2Button pickupOrder;
        private System.Windows.Forms.PictureBox logOut;
    }
}