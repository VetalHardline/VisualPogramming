using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string[] arr = str.Split(' ');
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length != 1)
                {
                    char ch1 = arr[i][0];
                    char ch2 = arr[i][arr[i].Length - 1];
                    arr[i] = ch2 + arr[i].Substring(1, arr[i].Length - 2) + ch1;
                }
                result += arr[i] + " ";
            }
            textBox2.Text += result;
        }
    }
}
