namespace RMS.UI
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msgTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.send = new System.Windows.Forms.PictureBox();
            this.msgPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.pictureBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(54, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1276, 91);
            this.panel4.TabIndex = 22;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(1145, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox.Size = new System.Drawing.Size(77, 76);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 30;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(591, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Help";
            // 
            // msgTB
            // 
            this.msgTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgTB.BorderRadius = 18;
            this.msgTB.BorderThickness = 0;
            this.msgTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msgTB.DefaultText = "";
            this.msgTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.msgTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.msgTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.msgTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.msgTB.FillColor = System.Drawing.Color.Gainsboro;
            this.msgTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.msgTB.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTB.ForeColor = System.Drawing.Color.Black;
            this.msgTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.msgTB.Location = new System.Drawing.Point(24, 7);
            this.msgTB.Margin = new System.Windows.Forms.Padding(4);
            this.msgTB.Multiline = true;
            this.msgTB.Name = "msgTB";
            this.msgTB.Padding = new System.Windows.Forms.Padding(4);
            this.msgTB.PasswordChar = '\0';
            this.msgTB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.msgTB.PlaceholderText = "Message";
            this.msgTB.SelectedText = "";
            this.msgTB.Size = new System.Drawing.Size(886, 67);
            this.msgTB.TabIndex = 0;
            this.msgTB.WordWrap = false;
            this.msgTB.TextChanged += new System.EventHandler(this.msgTB_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.send);
            this.panel2.Controls.Add(this.msgTB);
            this.panel2.Location = new System.Drawing.Point(249, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 307);
            this.panel2.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(975, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // send
            // 
            this.send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.send.Image = ((System.Drawing.Image)(resources.GetObject("send.Image")));
            this.send.Location = new System.Drawing.Point(917, 13);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(52, 50);
            this.send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.send.TabIndex = 0;
            this.send.TabStop = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // msgPanel
            // 
            this.msgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgPanel.AutoScroll = true;
            this.msgPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgPanel.Location = new System.Drawing.Point(249, 164);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Size = new System.Drawing.Size(1067, 457);
            this.msgPanel.TabIndex = 29;
            this.msgPanel.WrapContents = false;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.AutoSize = true;
            this.guna2VScrollBar1.BindingContainer = this.msgPanel;
            this.guna2VScrollBar1.BorderRadius = 12;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 516;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1290, 164);
            this.guna2VScrollBar1.Maximum = 519;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 26;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(26, 457);
            this.guna2VScrollBar1.SmallChange = 5;
            this.guna2VScrollBar1.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.msgPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1350, 1030);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox msgTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox send;
        private System.Windows.Forms.FlowLayoutPanel msgPanel;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox;
        private System.Windows.Forms.Timer Timer;
    }
}