using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatoor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Данні не введені");
            else
            {
                double result = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Якщо нічого не введено
            if (textBox1.Text == "")
                MessageBox.Show("Данні не введені");
            else
            {
                //здійснюємо множення
                double result = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Данні не введені");
            else
            {
                double result = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Данні не введені");
            else
            {
                double result = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Данні не введені");
            else
            {
                double result = Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i, n, result = 1;

            n = Convert.ToInt32(textBox1.Text);

            for (i = 1; i <= n; i++)
                result *= i;

            textBox3.Text = result.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int result = n*n;
            textBox3.Text = result.ToString();
        }
    }
}
