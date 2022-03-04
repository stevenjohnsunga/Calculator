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
        bool isA=true;
        void dis(string x)
        {

            txtdisplay.AppendText(x);
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
    }
}
