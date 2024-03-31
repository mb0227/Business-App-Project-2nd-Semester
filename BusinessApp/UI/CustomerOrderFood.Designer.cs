namespace SignInSignUp.UI
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.addToCart = new System.Windows.Forms.Button();
            this.clearCart = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.viewCart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantitiesComboBox = new System.Windows.Forms.ComboBox();
            this.comments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(290, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order Food";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(300, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 100);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(452, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuComboBox
            // 
            this.menuComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(220, 71);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(182, 37);
            this.menuComboBox.TabIndex = 0;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
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
            this.menuGridView.Location = new System.Drawing.Point(443, 150);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.RowHeadersWidth = 62;
            this.menuGridView.RowTemplate.Height = 28;
            this.menuGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.menuGridView.Size = new System.Drawing.Size(323, 277);
            this.menuGridView.TabIndex = 12;
            // 
            // addToCart
            // 
            this.addToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addToCart.BackColor = System.Drawing.Color.Orange;
            this.addToCart.FlatAppearance.BorderSize = 0;
            this.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCart.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.ForeColor = System.Drawing.Color.Black;
            this.addToCart.Location = new System.Drawing.Point(119, 433);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(180, 58);
            this.addToCart.TabIndex = 2;
            this.addToCart.Text = "Add to Cart";
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // clearCart
            // 
            this.clearCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearCart.BackColor = System.Drawing.Color.Red;
            this.clearCart.FlatAppearance.BorderSize = 0;
            this.clearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCart.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCart.ForeColor = System.Drawing.Color.MintCream;
            this.clearCart.Location = new System.Drawing.Point(557, 433);
            this.clearCart.Name = "clearCart";
            this.clearCart.Size = new System.Drawing.Size(180, 58);
            this.clearCart.TabIndex = 4;
            this.clearCart.Text = "Clear Cart";
            this.clearCart.UseVisualStyleBackColor = false;
            this.clearCart.Click += new System.EventHandler(this.clearCart_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.placeOrderButton.BackColor = System.Drawing.Color.SpringGreen;
            this.placeOrderButton.FlatAppearance.BorderSize = 0;
            this.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.ForeColor = System.Drawing.Color.Black;
            this.placeOrderButton.Location = new System.Drawing.Point(342, 518);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(180, 58);
            this.placeOrderButton.TabIndex = 5;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // viewCart
            // 
            this.viewCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewCart.BackColor = System.Drawing.Color.Teal;
            this.viewCart.FlatAppearance.BorderSize = 0;
            this.viewCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCart.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCart.ForeColor = System.Drawing.Color.MintCream;
            this.viewCart.Location = new System.Drawing.Point(340, 433);
            this.viewCart.Name = "viewCart";
            this.viewCart.Size = new System.Drawing.Size(180, 58);
            this.viewCart.TabIndex = 3;
            this.viewCart.Text = "View Cart\r\n";
            this.viewCart.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.quantitiesComboBox);
            this.panel1.Controls.Add(this.comments);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.menuGridView);
            this.panel1.Controls.Add(this.placeOrderButton);
            this.panel1.Controls.Add(this.viewCart);
            this.panel1.Controls.Add(this.clearCart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addToCart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuComboBox);
            this.panel1.Location = new System.Drawing.Point(300, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 673);
            this.panel1.TabIndex = 18;
            // 
            // quantitiesComboBox
            // 
            this.quantitiesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantitiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantitiesComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitiesComboBox.FormattingEnabled = true;
            this.quantitiesComboBox.Location = new System.Drawing.Point(587, 69);
            this.quantitiesComboBox.Name = "quantitiesComboBox";
            this.quantitiesComboBox.Size = new System.Drawing.Size(182, 37);
            this.quantitiesComboBox.TabIndex = 15;
            // 
            // comments
            // 
            this.comments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments.Location = new System.Drawing.Point(220, 203);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(182, 102);
            this.comments.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(42, 198);
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
            // CustomerOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 874);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1070, 889);
            this.Name = "CustomerOrderFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CustomerOrderFood";
            this.Load += new System.EventHandler(this.CustomerOrderFood_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Button clearCart;
        private System.Windows.Forms.Button viewCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.ComboBox quantitiesComboBox;
    }
}