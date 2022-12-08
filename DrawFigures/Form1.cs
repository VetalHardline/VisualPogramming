using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DrawFigures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = new SolidBrush(Color.Pink);
            g.DrawRectangle(Pens.Red, 40, 100, 150, 50);
            g.FillRectangle(brush, 40, 100, 150, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = new SolidBrush(Color.Gray);
            g.DrawEllipse(Pens.Red, 240, 100, 150, 50);
            g.FillEllipse(brush, 240, 100, 150, 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = new SolidBrush(Color.Brown);
            Brush brush2 = new HatchBrush(HatchStyle.SmallCheckerBoard, Color.White);
            g.DrawEllipse(Pens.Red, 470, 30, 200, 200);
            g.FillEllipse(brush, 470, 30, 200, 200);

            g.DrawEllipse(Pens.Red, 700, 100, 150, 50);
            g.FillEllipse(brush2, 700, 100, 150, 50);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = new SolidBrush(Color.Brown);
            Point[] pt = {
            new Point(60, 10),
            new Point(90, 10),
            new Point(140, 100),
            new Point(10, 100),
            };

            g.DrawLines(Pens.Red, pt);
            g.FillPolygon(brush, pt);
            g.DrawRectangle(Pens.Red, 10, 100, 131, 100);
            g.FillRectangle(brush, 10, 100, 131, 100);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = new SolidBrush(Color.Yellow);
            Point[] pt = {
            new Point(100, 10),
            new Point(190, 100),
            new Point(10, 100),
            };

            g.DrawLines(Pens.Red, pt);
            g.FillPolygon(brush, pt);
            g.DrawRectangle(Pens.Red, 10, 100, 180, 100);
            g.FillRectangle(brush, 10, 100, 180, 100);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = new HatchBrush(HatchStyle.Cross, Color.Green);
            Point[] pt = {
            new Point(50, 10),
            new Point(100, 10),
            new Point(140, 100),
            new Point(10, 100),
            };

            g.DrawLines(Pens.Red, pt);
            g.FillPolygon(brush, pt);
            g.DrawRectangle(Pens.Red, 10, 100, 131, 100);
            g.FillRectangle(brush, 10, 100, 131, 100);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = new SolidBrush(Color.Yellow);
            Brush brush2 = new SolidBrush(Color.Green);

            g.FillEllipse(brush, 300, 150, 150, 150);
            g.FillEllipse(brush2, 150, 200, 150, 50);
            g.FillEllipse(brush2, 450, 200, 150, 50);
            g.FillEllipse(brush2, 350, 300, 50, 150);
            g.FillEllipse(brush2, 350, 0, 50, 150);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush brush = new HatchBrush(HatchStyle.Cross, Color.Red);

            Point[] pt = {
            new Point(400, 10),
            new Point(490, 100),
            new Point(310, 100),
            };

            g.DrawLines(Pens.Red, pt);
            g.FillPolygon(brush, pt);
            g.DrawRectangle(Pens.Red, 310, 100, 180, 100);
            g.FillRectangle(brush, 310, 100, 180, 100);

        }
    }
}
