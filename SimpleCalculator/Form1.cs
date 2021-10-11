using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Double number = 0;
        String lastOperator = "";
        bool performOper = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExtraButton_click(object sender, EventArgs e)
        {
            
            if (performOper)
                textBox1.Clear();

            performOper = false;

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if(!textBox1.Text.Contains('.'))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button buttonOperator = (Button)sender;
            lastOperator = buttonOperator.Text;

            number = Convert.ToDouble(textBox1.Text);

            label1.Text = textBox1.Text + lastOperator;
            performOper = true;

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch(lastOperator)
            {
                case "+":
                    textBox1.Text = (number + Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (number - Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (number * Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (number / Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            number = Convert.ToDouble(textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            lastOperator = "" ;
            label1.Text = "";
            performOper = false;
            number = 0;
        }
    }
}
