namespace RMS.UI
{
    partial class Reply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reply));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.msgPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.send = new System.Windows.Forms.PictureBox();
            this.msgTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(54, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1274, 91);
            this.panel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(570, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reply";
            // 
            // msgPanel
            // 
            this.msgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgPanel.AutoScroll = true;
            this.msgPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgPanel.Location = new System.Drawing.Point(267, 164);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Size = new System.Drawing.Size(1049, 475);
            this.msgPanel.TabIndex = 30;
            this.msgPanel.WrapContents = false;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.msgPanel;
            this.guna2VScrollBar1.BorderRadius = 12;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1290, 164);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 26;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(26, 475);
            this.guna2VScrollBar1.TabIndex = 0;
            // 
            // send
            // 
            this.send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.send.Image = ((System.Drawing.Image)(resources.GetObject("send.Image")));
            this.send.Location = new System.Drawing.Point(1160, 664);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(52, 50);
            this.send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.send.TabIndex = 31;
            this.send.TabStop = false;
            this.send.Click += new System.EventHandler(this.send_Click);
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
            this.msgTB.Location = new System.Drawing.Point(267, 658);
            this.msgTB.Margin = new System.Windows.Forms.Padding(4);
            this.msgTB.Multiline = true;
            this.msgTB.Name = "msgTB";
            this.msgTB.Padding = new System.Windows.Forms.Padding(4);
            this.msgTB.PasswordChar = '\0';
            this.msgTB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.msgTB.PlaceholderText = "Message";
            this.msgTB.SelectedText = "";
            this.msgTB.Size = new System.Drawing.Size(886, 67);
            this.msgTB.TabIndex = 32;
            this.msgTB.WordWrap = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10500;
            // 
            // Reply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.msgTB);
            this.Controls.Add(this.msgPanel);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "Reply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reply";
            this.Load += new System.EventHandler(this.Reply_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel msgPanel;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.PictureBox send;
        private Guna.UI2.WinForms.Guna2TextBox msgTB;
        private System.Windows.Forms.Timer Timer;
    }
}