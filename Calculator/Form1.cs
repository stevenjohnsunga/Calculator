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
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }
        void calccsd()
        {
            if ((displaybox.Text == "0") || (enter_value))
                displaybox.Text = "";
            enter_value = false;
            string num="";
            if (num == ".")
            {
                if (!displaybox.Text.Contains("."))
                    displaybox.Text = displaybox.Text + num;
            }
            else
                displaybox.Text = displaybox.Text + num;

        }
        private void btn_num_dot(object sender, EventArgs e)
        {
            if ((displaybox.Text == "0") || (enter_value))
                displaybox.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!displaybox.Text.Contains("."))
                    displaybox.Text = displaybox.Text + num.Text;
            }
            else
                displaybox.Text = displaybox.Text + num.Text;
        }

        private void clear_entry_Click(object sender, EventArgs e)
        {
            displaybox.Text = "0";
            lblShowOperation.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            results = 0;
            displaybox.Text = "0";
            lblShowOperation.Text = "";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text.Length > 0)
            {
                displaybox.Text = displaybox.Text.Remove(displaybox.Text.Length -1, 1);
            }
            if (displaybox.Text == "")
            {
                displaybox.Text = "0";
            }
        }
        private void Arithmetic_exp_mod(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (results != 0)
            {
                equal_sym.PerformClick();
                operation = num.Text;
                displaybox.Text = "";
                lblShowOperation.Text = System.Convert.ToString(results) + " " + operation;
            }
            else
            {
                operation = num.Text;
                results = Double.Parse(displaybox.Text);
                displaybox.Text = "";
                lblShowOperation.Text = System.Convert.ToString(results) + " " + operation;
            }
        }

        private void equal_sym_Click(object sender, EventArgs e)
        {
            lblShowOperation.Text = "";
            switch (operation)
            {
                case "+":
                    displaybox.Text = (results + Double.Parse(displaybox.Text)).ToString();
                    break;
                case "-":
                    displaybox.Text = (results - Double.Parse(displaybox.Text)).ToString();
                    break;
                case "*":
                    displaybox.Text = (results * Double.Parse(displaybox.Text)).ToString();
                    break;
                case "/":
                    displaybox.Text = (results / Double.Parse(displaybox.Text)).ToString();
                    break;
                case "Mod":
                    displaybox.Text = (results % Double.Parse(displaybox.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(displaybox.Text);
                    double j;
                    j = (results);
                    displaybox.Text = Math.Exp(i * Math.Log(j * 10)).ToString();
                    break;
            }
            results = Double.Parse(displaybox.Text);
            lblShowOperation.Text = "";
        }

        private void pi_sym_Click(object sender, EventArgs e)
        {
            displaybox.Text = "3.14159265359"; 
        }

        private void logarithm_Click(object sender, EventArgs e)
        {
            double logFunction = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("log" + "(" + (displaybox.Text) + ")");
            logFunction = Math.Log10(logFunction);
            displaybox.Text = System.Convert.ToString(logFunction);
        }

        private void rootsymbol_Click(object sender, EventArgs e)
        {
            double squareRoot = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("√" + "(" + (displaybox.Text) + ")");
            squareRoot = Math.Sqrt(squareRoot);
            displaybox.Text = System.Convert.ToString(squareRoot);
        }

        private void sine_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "180")
            {
                lblShowOperation.Text = System.Convert.ToString("sin" + "(" + (displaybox.Text) + ")");
                displaybox.Text = "0";
            }else if (displaybox.Text == "360")
            {
                lblShowOperation.Text = System.Convert.ToString("sin" + "(" + (displaybox.Text) + ")");
                displaybox.Text = "0";
            }
            else
            {
                double sineTrigo = Double.Parse(displaybox.Text);
                lblShowOperation.Text = System.Convert.ToString("sin" + "(" + (displaybox.Text) + ")");
                sineTrigo = Math.Sin(sineTrigo * Math.PI / 180);
                displaybox.Text = System.Convert.ToString(sineTrigo);
            }
        }

        private void cosine_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "90")
            {
                lblShowOperation.Text = System.Convert.ToString("cos" + "(" + (displaybox.Text) + ")");
                displaybox.Text = "0";
            }else if (displaybox.Text == "270")
            {
                lblShowOperation.Text = System.Convert.ToString("cos" + "(" + (displaybox.Text) + ")");
                displaybox.Text = "0";
            }
            else
            {
                double cosineTrigo = Double.Parse(displaybox.Text);
                lblShowOperation.Text = System.Convert.ToString("cos" + "(" + (displaybox.Text) + ")");
                cosineTrigo = Math.Cos(cosineTrigo * Math.PI / 180);
                displaybox.Text = System.Convert.ToString(cosineTrigo);
            }   
        }

        private void tangent_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "90")
            {
                lblShowOperation.Text = System.Convert.ToString("tan" + "(" + (displaybox.Text) + ")");
                displaybox.Text = Double.PositiveInfinity.ToString();
            }else if (displaybox.Text == "270")
            {
                lblShowOperation.Text = System.Convert.ToString("tan" + "(" + (displaybox.Text) + ")");
                displaybox.Text = Double.PositiveInfinity.ToString();
            }else if (displaybox.Text == "180")
            {
                lblShowOperation.Text = System.Convert.ToString("tan" + "(" + (displaybox.Text) + ")");
                displaybox.Text = "0";
            }else if (displaybox.Text == "360")
            {
                lblShowOperation.Text = System.Convert.ToString("tan" + "(" + (displaybox.Text) + ")");
                displaybox.Text = "0";
            }
            else
            {
                double tanTrigo = Double.Parse(displaybox.Text);
                lblShowOperation.Text = System.Convert.ToString("tan" + "(" + (displaybox.Text) + ")");
                tanTrigo = Math.Tan(tanTrigo * Math.PI / 180);
                displaybox.Text = System.Convert.ToString(tanTrigo);
            }
        }

        private void hyperbolic_sine_Click(object sender, EventArgs e)
        {
            double sinhTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("sinh" + "(" + (displaybox.Text) + ")");
            sinhTrigo = Math.Sinh(sinhTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(sinhTrigo);
        }

        private void hyperbolic_cos_Click(object sender, EventArgs e)
        {
            double coshTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("cosh" + "(" + (displaybox.Text) + ")");
            coshTrigo = Math.Cosh(coshTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(coshTrigo);
        }

        private void hyperbolic_tan_Click(object sender, EventArgs e)
        {
            double tanhTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("tanh" + "(" + (displaybox.Text) + ")");
            tanhTrigo = Math.Tanh(tanhTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(tanhTrigo);
        }

        private void squared_value_Click(object sender, EventArgs e)
        {
            double squarenum;
            lblShowOperation.Text = System.Convert.ToString("sqr" + "(" + (displaybox.Text) + ")");
            squarenum = Convert.ToDouble(displaybox.Text) * Convert.ToDouble(displaybox.Text);
            displaybox.Text = System.Convert.ToString(squarenum);
        }

        private void cubed_value_Click(object sender, EventArgs e)
        {
            double cubenum;
            lblShowOperation.Text = System.Convert.ToString("cube" + "(" + (displaybox.Text) + ")");
            cubenum = Convert.ToDouble(displaybox.Text) * Convert.ToDouble(displaybox.Text) * Convert.ToDouble(displaybox.Text);
            displaybox.Text = System.Convert.ToString(cubenum);
        }

        private void reciprocal_func_Click(object sender, EventArgs e)
        {
            double reciprocal_num;
            lblShowOperation.Text = System.Convert.ToString("1/" + "(" + (displaybox.Text) + ")");
            reciprocal_num = Convert.ToDouble(1.0 / Convert.ToDouble(displaybox.Text));
            displaybox.Text = System.Convert.ToString(reciprocal_num);
        }

        private void ten_raised_to_x_Click(object sender, EventArgs e)
        {
            double ten_raised_to_num;
            lblShowOperation.Text = System.Convert.ToString("10^" + "(" + (displaybox.Text) + ")");
            ten_raised_to_num = Math.Pow(10, Convert.ToDouble(displaybox.Text));
            displaybox.Text = System.Convert.ToString(ten_raised_to_num);
        }

        private void factorial_func_Click(object sender, EventArgs e)
        {
            double fact_num;
            int factor = 1;
            fact_num = Convert.ToDouble(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString((displaybox.Text) + "!");
            if (fact_num < 0)
            {
                displaybox.Text = System.Convert.ToString("Error");
            }
            else if (fact_num <= 1)
            {
                displaybox.Text = System.Convert.ToString("1");
            }
            else
            {
                for(int i = 1; i <= fact_num ; i++)
                {
                    factor = factor * i;
                    displaybox.Text = System.Convert.ToString(factor);
                }
            }
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            double num;
            num = -1 * Convert.ToDouble(displaybox.Text);
            displaybox.Text = System.Convert.ToString(num);
        }

        private void natural_log_Click(object sender, EventArgs e)
        {
            double ln_num = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("ln" + "(" + (displaybox.Text) + ")");
            results = Math.Log(ln_num);
            displaybox.Text = results.ToString();
        }

        private void square_root_Click(object sender, EventArgs e)
        {
            double sqr_num = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("sqrt" + "(" + (displaybox.Text) + ")");
            sqr_num = Math.Sqrt(sqr_num);
            displaybox.Text = System.Convert.ToString(sqr_num);
        }

        private void cube_root_Click(object sender, EventArgs e)
        {
            double cbroot_num = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("cuberoot" + "(" + (displaybox.Text) + ")");
            cbroot_num = (Math.Pow(cbroot_num, (double)1.0 / 3.0));
            displaybox.Text = System.Convert.ToString(cbroot_num);
        }

        private void percent_sign_Click(object sender, EventArgs e)
        {
            double percent_num = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString((displaybox.Text) + "%");
            percent_num = Convert.ToDouble(0.01 * Convert.ToDouble(displaybox.Text));
            displaybox.Text = System.Convert.ToString(percent_num);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my Calculator! :)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
