using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBeetleRace
{
    public partial class Form1 : Form
    {
        int flag1;
        int x1, x2;
        int Finish;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            x1 = 1; x2 = 1;
            pictureBox1.Left = x1;
            pictureBox2.Left = x2;
            flag1 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag1 = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag1 != 0)
            {
                Random a = new Random();
                int count = a.Next(8);
                x1 += count;
                label1.Text = Convert.ToString(x1);
                pictureBox1.Left = x1;
                count = a.Next(8);
                x2 += count;
                label2.Text = Convert.ToString(x2);
                pictureBox2.Left = x2;
            }

            if ((x1 >= Finish) || (x2 >= Finish))
            {
                flag1 = 0;
            }

            if(x1>=Finish)
            {
                textBox3.Text = "Гравець 1 переміг";
            }

            if (x2 >= Finish)
            {
                textBox3.Text = "Гравець 2 переміг";
            }
        }

        private void діїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\nЩоб почати гонку - натисніть кнопку СТАРТ \nЩоб спробувати ще раз - натисніть кнопку ЗНОВУ.");
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\t\t\tВітаю!\n\nЦе гра про двох жуків, яким стало сумно, тому вони вирішили пограти в гонку." +
                "\n\n\t\t\tГарної гри!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Гравець 1";
            textBox2.Text = "Гравець 2";
            label1.Text = "0";
            label2.Text = "0";
            pictureBox1.Left = 1;
            pictureBox2.Left = 1;
            Finish = panel1.Size.Width - pictureBox1.Width;
        }
    }
}
