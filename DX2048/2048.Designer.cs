namespace DX2048
{
    partial class Form1
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
            this.panel_msg = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_reset = new System.Windows.Forms.Button();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_myself = new System.Windows.Forms.Panel();
            this.bt_myself_submit = new System.Windows.Forms.Button();
            this.tb_myself_y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_myself_x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_buju = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_show = new System.Windows.Forms.Panel();
            this.panel_msg.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_myself.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_msg
            // 
            this.panel_msg.Controls.Add(this.panel2);
            this.panel_msg.Controls.Add(this.panel_myself);
            this.panel_msg.Controls.Add(this.cb_buju);
            this.panel_msg.Controls.Add(this.label1);
            this.panel_msg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_msg.Location = new System.Drawing.Point(0, 0);
            this.panel_msg.Name = "panel_msg";
            this.panel_msg.Size = new System.Drawing.Size(509, 105);
            this.panel_msg.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.bt_reset);
            this.panel2.Controls.Add(this.tb_score);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(338, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 105);
            this.panel2.TabIndex = 6;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(41, 58);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(71, 28);
            this.bt_reset.TabIndex = 7;
            this.bt_reset.Text = "重新开始";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // tb_score
            // 
            this.tb_score.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_score.Location = new System.Drawing.Point(62, 8);
            this.tb_score.Multiline = true;
            this.tb_score.Name = "tb_score";
            this.tb_score.ReadOnly = true;
            this.tb_score.Size = new System.Drawing.Size(94, 36);
            this.tb_score.TabIndex = 6;
            this.tb_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_score.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Score：";
            // 
            // panel_myself
            // 
            this.panel_myself.Controls.Add(this.bt_myself_submit);
            this.panel_myself.Controls.Add(this.tb_myself_y);
            this.panel_myself.Controls.Add(this.label4);
            this.panel_myself.Controls.Add(this.tb_myself_x);
            this.panel_myself.Controls.Add(this.label3);
            this.panel_myself.Controls.Add(this.label2);
            this.panel_myself.Enabled = false;
            this.panel_myself.Font = new System.Drawing.Font("Tahoma", 9F);
            this.panel_myself.Location = new System.Drawing.Point(8, 41);
            this.panel_myself.Name = "panel_myself";
            this.panel_myself.Size = new System.Drawing.Size(324, 53);
            this.panel_myself.TabIndex = 2;
            // 
            // bt_myself_submit
            // 
            this.bt_myself_submit.Location = new System.Drawing.Point(231, 8);
            this.bt_myself_submit.Name = "bt_myself_submit";
            this.bt_myself_submit.Size = new System.Drawing.Size(81, 35);
            this.bt_myself_submit.TabIndex = 5;
            this.bt_myself_submit.Text = "重绘布局";
            this.bt_myself_submit.UseVisualStyleBackColor = true;
            this.bt_myself_submit.Click += new System.EventHandler(this.bt_myself_submit_Click);
            // 
            // tb_myself_y
            // 
            this.tb_myself_y.Location = new System.Drawing.Point(171, 15);
            this.tb_myself_y.Name = "tb_myself_y";
            this.tb_myself_y.Size = new System.Drawing.Size(47, 22);
            this.tb_myself_y.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y：";
            // 
            // tb_myself_x
            // 
            this.tb_myself_x.Location = new System.Drawing.Point(90, 15);
            this.tb_myself_x.Name = "tb_myself_x";
            this.tb_myself_x.Size = new System.Drawing.Size(47, 22);
            this.tb_myself_x.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "X：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "布局样式：";
            // 
            // cb_buju
            // 
            this.cb_buju.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cb_buju.FormattingEnabled = true;
            this.cb_buju.Items.AddRange(new object[] {
            "自定义布局",
            "4*4",
            "5*5",
            "6*6",
            "7*7",
            "8*8",
            "9*9",
            "10*10"});
            this.cb_buju.Location = new System.Drawing.Point(95, 13);
            this.cb_buju.Name = "cb_buju";
            this.cb_buju.Size = new System.Drawing.Size(121, 22);
            this.cb_buju.TabIndex = 1;
            this.cb_buju.SelectedIndexChanged += new System.EventHandler(this.cb_buju_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "布局格式：";
            // 
            // panel_show
            // 
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(0, 105);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(509, 607);
            this.panel_show.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 712);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.panel_msg);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel_msg.ResumeLayout(false);
            this.panel_msg.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_myself.ResumeLayout(false);
            this.panel_myself.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_msg;
        private System.Windows.Forms.ComboBox cb_buju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_myself;
        private System.Windows.Forms.TextBox tb_myself_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_myself_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_myself_submit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Panel panel_show;
    }
}

