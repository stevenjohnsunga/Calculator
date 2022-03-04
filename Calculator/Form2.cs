using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int fnum = 0;
        int snum = 0;
       
        string op = "";
        void dis(string x)
        {

            txtdisplay.AppendText(x);
        }
        void disabler()
        {
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dis("9");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dis("7");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dis("8");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dis("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dis("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dis("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dis("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dis("2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dis("1");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dis("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
                op = "+";
                fnum = int.Parse(txtdisplay.Text);
                txtdisplay.Text = "";
            disabler();

        }
        void enabler()
        {
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            op = "-";
            fnum = int.Parse(txtdisplay.Text);
            txtdisplay.Text = "";
            disabler();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = "/";
            fnum = int.Parse(txtdisplay.Text);
            txtdisplay.Text = "";
            disabler();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = "*";
            fnum = int.Parse(txtdisplay.Text);
            txtdisplay.Text = "";
            disabler();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                snum = int.Parse(txtdisplay.Text);
                enabler();
                int x = snum + fnum;
                txtdisplay.Text = "";
                txtdisplay.AppendText(x.ToString());
            }
            if (op == "-")
            {
                snum = int.Parse(txtdisplay.Text);
                enabler();
                int x = snum - fnum;
                txtdisplay.Text = "";
                txtdisplay.AppendText(x.ToString());
            }
            if (op == "*")
            {
                snum = int.Parse(txtdisplay.Text);
                enabler();
                int x = snum * fnum;
                txtdisplay.Text = "";
                txtdisplay.AppendText(x.ToString());
            }
            if (op == "/")
            {
                snum = int.Parse(txtdisplay.Text);
                enabler();
                int x = snum / fnum;
                txtdisplay.Text = "";
                txtdisplay.AppendText(x.ToString());
            }
            op = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            enabler();
            txtdisplay.Text = "";
            fnum = 0;
            snum = 0;
            op = "";
        }
    }
}
