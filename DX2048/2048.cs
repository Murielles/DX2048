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
        DataTable Create_dt = new DataTable();
        int begin_x = 0;
        int begin_y = 0;

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

            //画button控件
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

            Random();
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
            Create_dt = new DataTable();
        }

        void Create_DataTable(string flag)
        {
            Create_dt = new DataTable();
            for (int c = 0; c < y; c++)
            {
                Create_dt.Columns.Add();
                
            }

            int Control_num = 0;
            for (int col = 0; col < y; col++)
            {
                DataRow dr = Create_dt.NewRow();
                for (int row = 0; row < x; row++, Control_num++)
                {
                    dr[row] = panel_show.Controls[Control_num].Text;
                }
                Create_dt.Rows.Add(dr);
            }

            switch (flag)
            {
                case "Down":
                    {
                        
                    }
                    break;
                case "Up":
                    {

                    }
                    break;
                case "Right":
                    {

                    }
                    break;
                case "Left":
                    {

                    }
                    break;
                default: break;
            }
        }


        private void bt_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Random();
            int Control_num = 0;

            if (e.KeyCode == Keys.Down)
            {
                Create_DataTable("Down");
            }
            else if (e.KeyCode == Keys.Up)
            {
                Create_DataTable("Up");
            }
            else if (e.KeyCode == Keys.Right)
            {
                Create_DataTable("Right");
            }
            else if (e.KeyCode == Keys.Left)
            {
                Create_DataTable("Left");
            }
            for (int i = 0; i < Create_dt.Rows.Count; i++)
            {
                for (int j = 0; j < Create_dt.Rows[i].ItemArray.Length; j++, Control_num++)
                {
                    panel_show.Controls[Control_num].Text = Create_dt.Rows[i][j].ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            begin_x = this.Width;
            begin_y = this.Height;
        }

        void Random()
        {
            Random random_bt = new Random();
            //随机生成两个2
            for (int r = 0; r < 2; r++)
            {
                int ran = random_bt.Next(0, panel_show.Controls.Count);
                if (panel_show.Controls[ran].Text == "")
                {
                    panel_show.Controls[ran].Text = "2";
                }
            }
        }
    }
}
