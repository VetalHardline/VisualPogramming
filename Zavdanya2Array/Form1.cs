using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavdanya2Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, minimal = 100;
            int[] arr = new int[6];
            Random rand = new Random();

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
                textBox1.Text += Convert.ToString(arr[i]) + "  ";
            }

            foreach (int elem in arr)
            {
                if (elem > 0 && elem < minimal)
                    minimal = elem;
            }
            textBox2.Text += Convert.ToString(minimal) + "  ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, plus = 0;
            int[] arr = new int[6];
            Random rand = new Random();

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);

                textBox1.Text += Convert.ToString(arr[i]) + "  ";

                if (arr[i] > 0 && arr[i] % 3 == 0)
                {
                    plus += arr[i];
                }
            }
            textBox3.Text += Convert.ToString(plus);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            int[] arr = new int[11];
            Random rand = new Random();

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-4, 3);

                textBox1.Text += Convert.ToString(arr[i]) + "  ";

                if (arr[i] != 0)
                {
                    textBox4.Text += Convert.ToString(arr[i] + "  ");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[5, 5];
            int[] Newarray = new int[5];
            Random rand = new Random();


            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int column = 0; column < arr.GetLength(1); column++)
                {
                    arr[row, column] = rand.Next(0, 100);
                }
            }

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int column = 0; column < arr.GetLength(1); column++)
                {
                    textBox1.Text += Convert.ToString(arr[row, column] + "\t");
                }
            }
        }
    }
}
