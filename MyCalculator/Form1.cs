using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;

                //MessageBox.Show("Addition result: " + result.ToString());

                label4.Text = "Addition result: " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill both fields...");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 - num2;

                //MessageBox.Show("Addition result: " + result.ToString());

                label4.Text = "Subtraction result: " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill both fields...");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 * num2;

                //MessageBox.Show("Addition result: " + result.ToString());

                label4.Text = "Multiplication result: " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill both fields...");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float num1 = int.Parse(textBox1.Text);
                float num2 = int.Parse(textBox2.Text);

                float result = num1 / num2;

                //MessageBox.Show("Addition result: " + result.ToString());

                label4.Text = "Division result: " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill both fields...");
            }
        }
    }
}
