using System;
using System.Windows.Forms;

namespace nguyendangduy1010
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = ""; 
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SetOperation("x");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
            operation = "";
            operation_pressed = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PerformCalculation();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SetOperation("/");
        }

        private void AppendNumber(string number)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
                textBox1.Clear();

            operation_pressed = false;
            textBox1.Text = textBox1.Text + number;
        }

        private void SetOperation(string op)
        {
            operation = op;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
        }

        private void PerformCalculation()
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox1.Text) != 0)
                    {
                        textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Error"; 
                    }
                    break;
                default:
                    break;
            }
            operation = "";
        }
    }
}

