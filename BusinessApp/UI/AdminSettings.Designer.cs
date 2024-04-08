namespace SignInSignUp.UI
{
    partial class AdminSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.passwordButton = new Guna.UI2.WinForms.Guna2Button();
            this.usernameButton = new Guna.UI2.WinForms.Guna2Button();
            this.logOutButton = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(54, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 91);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(497, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.tb);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.passwordButton);
            this.panel2.Controls.Add(this.usernameButton);
            this.panel2.Controls.Add(this.logOutButton);
            this.panel2.Location = new System.Drawing.Point(57, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 788);
            this.panel2.TabIndex = 12;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backBtn.Location = new System.Drawing.Point(359, 179);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(164, 69);
            this.backBtn.TabIndex = 20;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.BackColor = System.Drawing.Color.Lime;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Location = new System.Drawing.Point(849, 179);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(164, 69);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label.ForeColor = System.Drawing.Color.MintCream;
            this.label.Location = new System.Drawing.Point(436, 125);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 36);
            this.label.TabIndex = 18;
            this.label.Text = "text";
            this.label.Visible = false;
            // 
            // tb
            // 
            this.tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb.DefaultText = "";
            this.tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tb.ForeColor = System.Drawing.Color.Black;
            this.tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb.Location = new System.Drawing.Point(551, 125);
            this.tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb.Name = "tb";
            this.tb.PasswordChar = '\0';
            this.tb.PlaceholderText = "";
            this.tb.SelectedText = "";
            this.tb.Size = new System.Drawing.Size(283, 46);
            this.tb.TabIndex = 17;
            this.tb.Visible = false;
            this.tb.WordWrap = false;
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
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deleteButton.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteButton.Location = new System.Drawing.Point(359, 366);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(277, 72);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Account    ";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // passwordButton
            // 
            this.passwordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordButton.BorderColor = System.Drawing.Color.Transparent;
            this.passwordButton.BorderRadius = 18;
            this.passwordButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.passwordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passwordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passwordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passwordButton.FillColor = System.Drawing.Color.Orange;
            this.passwordButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordButton.ForeColor = System.Drawing.Color.Black;
            this.passwordButton.Image = ((System.Drawing.Image)(resources.GetObject("passwordButton.Image")));
            this.passwordButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordButton.ImageSize = new System.Drawing.Size(30, 30);
            this.passwordButton.Location = new System.Drawing.Point(675, 271);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(282, 72);
            this.passwordButton.TabIndex = 4;
            this.passwordButton.Text = "Change Password";
            this.passwordButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // usernameButton
            // 
            this.usernameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameButton.BorderColor = System.Drawing.Color.Transparent;
            this.usernameButton.BorderRadius = 18;
            this.usernameButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.usernameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.usernameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.usernameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.usernameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.usernameButton.FillColor = System.Drawing.Color.Orange;
            this.usernameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameButton.ForeColor = System.Drawing.Color.Black;
            this.usernameButton.Image = ((System.Drawing.Image)(resources.GetObject("usernameButton.Image")));
            this.usernameButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameButton.ImageSize = new System.Drawing.Size(30, 30);
            this.usernameButton.Location = new System.Drawing.Point(357, 271);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(289, 72);
            this.usernameButton.TabIndex = 2;
            this.usernameButton.Text = "Change Username";
            this.usernameButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logOutButton.BorderColor = System.Drawing.Color.Transparent;
            this.logOutButton.BorderRadius = 18;
            this.logOutButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.logOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logOutButton.FillColor = System.Drawing.Color.Red;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.Black;
            this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
            this.logOutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logOutButton.ImageSize = new System.Drawing.Size(30, 30);
            this.logOutButton.Location = new System.Drawing.Point(675, 366);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(278, 72);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log Out               ";
            this.logOutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1070, 889);
            this.Name = "AdminSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AdminSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button passwordButton;
        private Guna.UI2.WinForms.Guna2Button usernameButton;
        private Guna.UI2.WinForms.Guna2Button logOutButton;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2TextBox tb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button backBtn;
    }
}