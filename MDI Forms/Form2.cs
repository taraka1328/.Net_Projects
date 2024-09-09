using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Calculator : Form
    {
        int a = 0;
        int b, c;
        String msg;
        public Calculator()
        {
            InitializeComponent();
        }

        private void tb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_1.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_9.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_0.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_1.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            msg = "+";
            a = Convert.ToInt32(tb_1.Text);
            tb_1.Text = "";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            msg = "-";
            a = Convert.ToInt32(tb_1.Text);
            tb_1.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (msg == "+")
            {
                b = Convert.ToInt32(tb_1.Text);
                c = a + b;
                tb_1.Text = c.ToString();
            }
            if (msg == "-")
            {
                b = Convert.ToInt32(tb_1.Text);
                c = a - b;
                tb_1.Text = c.ToString();
            }
            if (msg == "*")
            {
                b = Convert.ToInt32(tb_1.Text);
                c = a * b;
                tb_1.Text = c.ToString();
            }
            if (msg == "/")
            {
                b = Convert.ToInt32(tb_1.Text);
                if (b == 0)
                {
                    tb_1.Text = "Division by zero error";
                }
                else
                {
                    c = a / b;
                    tb_1.Text = c.ToString();
                }

            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            msg = "*";
            a = Convert.ToInt32(tb_1.Text);
            tb_1.Text = "";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            msg = "/";
            a = Convert.ToInt32(tb_1.Text);
            tb_1.Text = "";
        }
    }
}
