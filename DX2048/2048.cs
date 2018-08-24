using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DX2048
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tb_x = 0;
        int tb_y = 0;
        bool size_flag = true;
        int x, y;

        private void cb_buju_SelectedIndexChanged(object sender, EventArgs e)
        {
            size_flag = true;
            
            if (cb_buju.SelectedItem.ToString() == "自定义布局")
            {
                panel_myself.Enabled = true;
            }
            else
            {
                x = int.Parse(cb_buju.SelectedItem.ToString().Split('*')[0]);
                y = int.Parse(cb_buju.SelectedItem.ToString().Split('*')[1]);
                Draw(x, y);
                if (size_flag == false)
                {
                    MessageBox.Show("超过屏幕分辨率！");
                    Reset();
                    return;
                }
            }
            SelectNextControl(panel_show, true, true, true, true);
            this.Width = tb_x + (this.Width - panel_show.Width);
            this.Height = tb_y + (this.Height - panel_show.Height);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// 自定义画布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_myself_submit_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb_myself_x.Text) >= 4 && int.Parse(tb_myself_y.Text) >= 4)
            {
                Draw(int.Parse(tb_myself_x.Text), int.Parse(tb_myself_y.Text));
            }
            else
            {
                MessageBox.Show("自定义布局不可小于4*4!");
            }
        }
        
        /// <summary>
        /// 绘制x*y的布局
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Draw(int x, int y)
        {
            //初始化
            Reset();
            for (int i = 0; i < x; i++)
            {
                tb_x = 0;
                for (int j = 0; j < y; j++)
                {
                    Button bt = new Button();
                    bt.Width = 120;
                    bt.Height = 120;
                    bt.ForeColor = Color.Red;
                    if (panel_show.Controls.Count <= 0)
                    {

                    }
                    else
                    {
                        bt.Location = new Point(tb_x, tb_y);
                    }
                    panel_show.Controls.Add(bt);
                    tb_x += 125;
                }
                tb_y += 125;
            }

            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(this);
            if (tb_x > rect.Width || tb_y > rect.Height)
            {
                size_flag = false;
            }
            Random random_bt = new Random();
            //随机生成两个2
            for (int r = 0; r < 2; r++)
            {
                int ran = random_bt.Next(1, panel_show.Controls.Count);
                panel_show.Controls[ran].Text = "2";
            }
        }

        /// <summary>
        /// 重置画布
        /// </summary>
        void Reset()
        {
            panel_show.Controls.Clear();
            tb_x = 0;
            tb_y = 0;
            this.Refresh();
            cb_buju.Text = "";
            this.Width = begin_x;
            this.Height = begin_y;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int begin_x = 0;
        int begin_y = 0;
        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int sum = 0;
            if (e.KeyCode == Keys.Down)
            {
                int control_item = panel_show.Controls.Count - y;
                int flag = 0;
                for (int j = 0; j < x; j++, control_item++)
                {
                    flag++;
                    for (int i = 0; i < y; i++)
                    {
                        if (panel_show.Controls[flag].Text != "")
                        {
                            sum += int.Parse(panel_show.Controls[flag].Text);
                        }
                        flag += 4;
                    }
                    panel_show.Controls[control_item].Text = sum.ToString();
                    flag = 0;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {

            }
            else if (e.KeyCode == Keys.Left)
            {

            }
            else if (e.KeyCode == Keys.Right)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            begin_x = this.Width;
            begin_y = this.Height;
        }
    }
}
