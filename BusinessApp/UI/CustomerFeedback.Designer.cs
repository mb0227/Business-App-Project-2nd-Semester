namespace RMS.UI
{
    partial class CustomerFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFeedback));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lovedit = new System.Windows.Forms.PictureBox();
            this.happy = new System.Windows.Forms.PictureBox();
            this.angry = new System.Windows.Forms.PictureBox();
            this.sad = new System.Windows.Forms.PictureBox();
            this.expressionless = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lovedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionless)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(95, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leave a Feedback: ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lovedit);
            this.panel2.Controls.Add(this.happy);
            this.panel2.Controls.Add(this.angry);
            this.panel2.Controls.Add(this.sad);
            this.panel2.Controls.Add(this.expressionless);
            this.panel2.Location = new System.Drawing.Point(301, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 795);
            this.panel2.TabIndex = 9;
            // 
            // lovedit
            // 
            this.lovedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lovedit.BackColor = System.Drawing.Color.Transparent;
            this.lovedit.Image = ((System.Drawing.Image)(resources.GetObject("lovedit.Image")));
            this.lovedit.Location = new System.Drawing.Point(766, 274);
            this.lovedit.Name = "lovedit";
            this.lovedit.Size = new System.Drawing.Size(102, 107);
            this.lovedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lovedit.TabIndex = 7;
            this.lovedit.TabStop = false;
            this.lovedit.Click += new System.EventHandler(this.lovedit_Click);
            // 
            // happy
            // 
            this.happy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.happy.BackColor = System.Drawing.Color.Transparent;
            this.happy.Image = ((System.Drawing.Image)(resources.GetObject("happy.Image")));
            this.happy.Location = new System.Drawing.Point(633, 274);
            this.happy.Name = "happy";
            this.happy.Size = new System.Drawing.Size(102, 107);
            this.happy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.happy.TabIndex = 8;
            this.happy.TabStop = false;
            this.happy.Click += new System.EventHandler(this.happy_Click);
            // 
            // angry
            // 
            this.angry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.angry.BackColor = System.Drawing.Color.Transparent;
            this.angry.Image = ((System.Drawing.Image)(resources.GetObject("angry.Image")));
            this.angry.Location = new System.Drawing.Point(236, 274);
            this.angry.Name = "angry";
            this.angry.Size = new System.Drawing.Size(102, 107);
            this.angry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.angry.TabIndex = 6;
            this.angry.TabStop = false;
            this.angry.Click += new System.EventHandler(this.angry_Click);
            // 
            // sad
            // 
            this.sad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sad.BackColor = System.Drawing.Color.Transparent;
            this.sad.Image = ((System.Drawing.Image)(resources.GetObject("sad.Image")));
            this.sad.Location = new System.Drawing.Point(360, 274);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(102, 107);
            this.sad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sad.TabIndex = 5;
            this.sad.TabStop = false;
            this.sad.Click += new System.EventHandler(this.sad_Click);
            // 
            // expressionless
            // 
            this.expressionless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expressionless.BackColor = System.Drawing.Color.Transparent;
            this.expressionless.Image = ((System.Drawing.Image)(resources.GetObject("expressionless.Image")));
            this.expressionless.Location = new System.Drawing.Point(495, 274);
            this.expressionless.Name = "expressionless";
            this.expressionless.Size = new System.Drawing.Size(102, 107);
            this.expressionless.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.expressionless.TabIndex = 4;
            this.expressionless.TabStop = false;
            this.expressionless.Click += new System.EventHandler(this.expressionless_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.pictureBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(56, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1276, 91);
            this.panel4.TabIndex = 21;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(1149, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox.Size = new System.Drawing.Size(77, 76);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(472, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer Feedback";
            // 
            // CustomerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "CustomerFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CustomerFeedback";
            this.Load += new System.EventHandler(this.CustomerFeedback_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lovedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionless)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox expressionless;
        private System.Windows.Forms.PictureBox sad;
        private System.Windows.Forms.PictureBox angry;
        private System.Windows.Forms.PictureBox lovedit;
        private System.Windows.Forms.PictureBox happy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox;
    }
}