using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_CalculatorProject
{
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string value1 = string.Empty;
        string value2 = string.Empty;
        char operation;
        double total = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "8";
            this.txtOutput.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "1";
            this.txtOutput.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "0";
            this.txtOutput.Text += input;
        }

        private void off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "7";
            this.txtOutput.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "9";
            this.txtOutput.Text += input;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            this.input = string.Empty;
            this.value1 = string.Empty;
            this.value2 = string.Empty;
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "6";
            this.txtOutput.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "5";
            this.txtOutput.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "4";
            this.txtOutput.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "2";
            this.txtOutput.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += "3";
            this.txtOutput.Text += input;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            input += ".";
            this.txtOutput.Text += input;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            value2 = input;
            double num1, num2;
            double.TryParse(value1, out num1);
            double.TryParse(value2, out num2);

            txtOutput.Text = "";
            this.input = string.Empty;
            this.value1 = string.Empty;
            this.value2 = string.Empty;


            if (operation == '+')
            {
                total = num1 + num2;
                txtOutput.Text = total.ToString();
            }
            else if (operation == '-')
            {
                total = num1 - num2;
                txtOutput.Text = total.ToString();
            }
            else if (operation == '*')
            {
                total = num1 * num2;
                txtOutput.Text = total.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    total = num1 / num2;
                    txtOutput.Text = total.ToString();
                }
                else
                {
                    txtOutput.Text = "DIV/Zero!";
                }
            }
        }
    }
}
