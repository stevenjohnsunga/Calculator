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

        private void button2_Click(object sender, EventArgs e)
        {
            txtdisplay.AppendText("9");
        }
    }
}
