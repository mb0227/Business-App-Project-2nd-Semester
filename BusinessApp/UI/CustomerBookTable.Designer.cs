namespace SSC.UI
{
    partial class CustomerBookTable
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.orderButton = new Guna.UI2.WinForms.Guna2Button();
            this.viewReservationButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteReservation = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(329, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 37);
            this.comboBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(87, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Available Tables";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel3.Controls.Add(this.deleteReservation);
            this.panel3.Controls.Add(this.viewReservationButton);
            this.panel3.Controls.Add(this.orderButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(169, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 707);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(55, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1126, 91);
            this.panel4.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(447, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = "Book Table";
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
            this.orderButton.Location = new System.Drawing.Point(111, 348);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(256, 65);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Make Reservation";
            // 
            // viewReservationButton
            // 
            this.viewReservationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewReservationButton.BorderColor = System.Drawing.Color.Transparent;
            this.viewReservationButton.BorderRadius = 18;
            this.viewReservationButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewReservationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewReservationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewReservationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewReservationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewReservationButton.FillColor = System.Drawing.Color.Orange;
            this.viewReservationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReservationButton.ForeColor = System.Drawing.Color.Black;
            this.viewReservationButton.Location = new System.Drawing.Point(392, 348);
            this.viewReservationButton.Name = "viewReservationButton";
            this.viewReservationButton.Size = new System.Drawing.Size(262, 65);
            this.viewReservationButton.TabIndex = 2;
            this.viewReservationButton.Text = "View Reservations";
            // 
            // deleteReservation
            // 
            this.deleteReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteReservation.BorderColor = System.Drawing.Color.Transparent;
            this.deleteReservation.BorderRadius = 18;
            this.deleteReservation.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.deleteReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteReservation.FillColor = System.Drawing.Color.Red;
            this.deleteReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReservation.ForeColor = System.Drawing.Color.Black;
            this.deleteReservation.Location = new System.Drawing.Point(678, 348);
            this.deleteReservation.Name = "deleteReservation";
            this.deleteReservation.Size = new System.Drawing.Size(266, 65);
            this.deleteReservation.TabIndex = 3;
            this.deleteReservation.Text = "Delete Reservation";
            // 
            // CustomerBookTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1070, 889);
            this.Name = "CustomerBookTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Book Table";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button orderButton;
        private Guna.UI2.WinForms.Guna2Button deleteReservation;
        private Guna.UI2.WinForms.Guna2Button viewReservationButton;
    }
}