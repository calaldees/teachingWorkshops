using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        string mem = "";
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation = "+";
            mem = textBox1.Text;
            textBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "-";
            mem = textBox1.Text;
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(mem);
            double num2 = double.Parse(textBox1.Text);
            double ans = 0;
            switch (operation) {
                case "+":
                    ans = num1 + num2;
                    break;
                case "-":
                    ans = num1 - num2;
                    break;

            }
            textBox1.Text = $"{ans}";
        }
    }
}
