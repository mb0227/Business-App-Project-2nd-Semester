namespace RMS.UI
{
    partial class SendNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendNotifications));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notification = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sendBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.notification);
            this.panel1.Location = new System.Drawing.Point(56, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 893);
            this.panel1.TabIndex = 23;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendBtn.BorderColor = System.Drawing.Color.Transparent;
            this.sendBtn.BorderRadius = 18;
            this.sendBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.sendBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendBtn.FillColor = System.Drawing.Color.Lime;
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.Black;
            this.sendBtn.Location = new System.Drawing.Point(828, 414);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(256, 65);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send ";
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "Write Notification: ";
            // 
            // notification
            // 
            this.notification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notification.BorderRadius = 20;
            this.notification.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.notification.BorderThickness = 0;
            this.notification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.notification.DefaultText = "";
            this.notification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.notification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.notification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.notification.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.notification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.notification.Font = new System.Drawing.Font("Tahoma", 12F);
            this.notification.ForeColor = System.Drawing.Color.Black;
            this.notification.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.notification.Location = new System.Drawing.Point(636, 142);
            this.notification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notification.Multiline = true;
            this.notification.Name = "notification";
            this.notification.PasswordChar = '\0';
            this.notification.PlaceholderText = "";
            this.notification.SelectedText = "";
            this.notification.Size = new System.Drawing.Size(448, 240);
            this.notification.TabIndex = 0;
            this.notification.WordWrap = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(54, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1276, 91);
            this.panel3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(471, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "Send Notifications";
            // 
            // SendNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "SendNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SendNotifications";
            this.Load += new System.EventHandler(this.SendNotifications_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox notification;
        private Guna.UI2.WinForms.Guna2Button sendBtn;
    }
}