namespace RMS.UI
{
    partial class ManageFeedback
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new Guna.UI2.WinForms.Guna2Button();
            this.reply = new Guna.UI2.WinForms.Guna2Button();
            this.tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewMsgs = new Guna.UI2.WinForms.Guna2Button();
            this.viewReviews = new Guna.UI2.WinForms.Guna2Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(52, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1276, 91);
            this.panel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(525, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Feedback";
            // 
            // dgv
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.ColumnHeadersHeight = 20;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.EnableHeadersVisualStyles = true;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgv.Location = new System.Drawing.Point(551, 58);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(664, 588);
            this.dgv.TabIndex = 47;
            this.dgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 20;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.RowsStyle.Height = 28;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.reply);
            this.panel1.Controls.Add(this.tb);
            this.panel1.Controls.Add(this.viewMsgs);
            this.panel1.Controls.Add(this.viewReviews);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(55, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 883);
            this.panel1.TabIndex = 48;
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back.BorderColor = System.Drawing.Color.Transparent;
            this.back.BorderRadius = 18;
            this.back.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back.FillColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(234, 489);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(164, 72);
            this.back.TabIndex = 52;
            this.back.Text = "Go Back";
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reply
            // 
            this.reply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reply.BorderColor = System.Drawing.Color.Transparent;
            this.reply.BorderRadius = 18;
            this.reply.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.reply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reply.FillColor = System.Drawing.Color.Lime;
            this.reply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.reply.ForeColor = System.Drawing.Color.Black;
            this.reply.Location = new System.Drawing.Point(332, 234);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(202, 72);
            this.reply.TabIndex = 51;
            this.reply.Text = "Reply";
            this.reply.Visible = false;
            this.reply.Click += new System.EventHandler(this.reply_Click);
            // 
            // tb
            // 
            this.tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb.BorderRadius = 18;
            this.tb.BorderThickness = 0;
            this.tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb.DefaultText = "";
            this.tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb.FillColor = System.Drawing.Color.Silver;
            this.tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tb.ForeColor = System.Drawing.Color.Black;
            this.tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb.Location = new System.Drawing.Point(234, 95);
            this.tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.tb.PasswordChar = '\0';
            this.tb.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb.PlaceholderText = "Write your reply here";
            this.tb.SelectedText = "";
            this.tb.Size = new System.Drawing.Size(300, 131);
            this.tb.TabIndex = 50;
            this.tb.Visible = false;
            this.tb.WordWrap = false;
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // viewMsgs
            // 
            this.viewMsgs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewMsgs.BorderColor = System.Drawing.Color.Transparent;
            this.viewMsgs.BorderRadius = 18;
            this.viewMsgs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewMsgs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewMsgs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewMsgs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewMsgs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewMsgs.FillColor = System.Drawing.Color.Turquoise;
            this.viewMsgs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMsgs.ForeColor = System.Drawing.Color.Black;
            this.viewMsgs.Location = new System.Drawing.Point(247, 408);
            this.viewMsgs.Name = "viewMsgs";
            this.viewMsgs.Size = new System.Drawing.Size(287, 69);
            this.viewMsgs.TabIndex = 49;
            this.viewMsgs.Text = "View Messages";
            this.viewMsgs.Click += new System.EventHandler(this.viewMsgs_Click);
            // 
            // viewReviews
            // 
            this.viewReviews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewReviews.BorderColor = System.Drawing.Color.Transparent;
            this.viewReviews.BorderRadius = 18;
            this.viewReviews.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewReviews.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewReviews.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewReviews.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewReviews.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewReviews.FillColor = System.Drawing.Color.Turquoise;
            this.viewReviews.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReviews.ForeColor = System.Drawing.Color.Black;
            this.viewReviews.Location = new System.Drawing.Point(247, 322);
            this.viewReviews.Name = "viewReviews";
            this.viewReviews.Size = new System.Drawing.Size(287, 72);
            this.viewReviews.TabIndex = 48;
            this.viewReviews.Text = "View Reviews";
            this.viewReviews.Click += new System.EventHandler(this.viewReviews_Click);
            // 
            // ManageFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1328, 1050);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "ManageFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManageFeedback";
            this.Load += new System.EventHandler(this.ManageFeedback_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button viewMsgs;
        private Guna.UI2.WinForms.Guna2Button viewReviews;
        private Guna.UI2.WinForms.Guna2TextBox tb;
        private Guna.UI2.WinForms.Guna2Button reply;
        private Guna.UI2.WinForms.Guna2Button back;
    }
}