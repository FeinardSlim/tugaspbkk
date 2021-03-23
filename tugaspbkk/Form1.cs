using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tugaspbkk
{
    public partial class Form1 : Form
    {
        private float firstNumber, secondNumber;
        private string operators;
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "0")
                textBox1.Text = Convert.ToString(-1 * float.Parse(textBox1.Text));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            secondNumber = float.Parse(textBox1.Text);
            if (secondNumber == 0) secondNumber = firstNumber;
            calculations();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text + button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" ) textBox1.Text = String.Empty;
            textBox1.Text = textBox1.Text + button10.Text;
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(operators)) calculations();
            firstNumber = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            operators = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(operators)) calculations();
            firstNumber = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            operators = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(operators)) calculations();
            firstNumber = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            operators = "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(operators)) calculations();
            firstNumber = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            operators = "+";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(operators)) calculations();
            firstNumber = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            operators = "%";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            operators = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button20.Text;
        }

        private void calculations()
        {
            if (textBox1.Text.EndsWith("."))
            {
                Debug.WriteLine(textBox1.Text);
                textBox1.Text = textBox1.Text.TrimEnd('.');
                Debug.WriteLine(textBox1.Text);
            }
            secondNumber = float.Parse(textBox1.Text);
            Debug.WriteLine("DEBUG: FIRST {0}, SECOND {1}, OPERATOR {2}", firstNumber, secondNumber, operators);
            switch (operators)
            {
                case "+":
                    textBox1.Text = Convert.ToString(firstNumber + secondNumber);
                    firstNumber = float.Parse(textBox1.Text);
                    secondNumber = 0;
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(firstNumber - secondNumber);
                    firstNumber = float.Parse(textBox1.Text);
                    secondNumber = 0;
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(firstNumber * secondNumber);
                    firstNumber = float.Parse(textBox1.Text);
                    secondNumber = 0;
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(firstNumber / secondNumber);
                    firstNumber = float.Parse(textBox1.Text);
                    secondNumber = 0;
                    break;
                case "%":
                    textBox1.Text = Convert.ToString(firstNumber % secondNumber);
                    firstNumber = float.Parse(textBox1.Text);
                    secondNumber = 0;
                    break;
                default:
                    textBox1.Text = "ERR";
                    firstNumber = 0;
                    secondNumber = 0;
                    break;
            }

            Debug.WriteLine("DEBUG: FIRST {0}, SECOND {1}, OPERATOR {2}", firstNumber, secondNumber, operators);
        }
    }
}
