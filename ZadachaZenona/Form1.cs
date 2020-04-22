using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZadachaZenona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vAxiles, vCherapasha;
        double x, y;
        double time, dTime;
        double difference;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;
            Pen Pen = new Pen(Color.Black, 3);
            Pen Pen_2 = new Pen(Color.Gray, 3);
            grf.DrawEllipse(Pen, (float)x, pictureBox1.Height-100, 100, 100);
            grf.DrawEllipse(Pen_2, (float)y, pictureBox1.Height - 50, 50, 50);           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x > Width)
            {
                x = -100;
            } 
            if (y>Width)
            {
                y = -100;
            }            
            x += vAxiles;
            y += vCherapasha;
            pictureBox1.Refresh();
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
            double.TryParse(textBox1.Text, out vAxiles);
            double.TryParse(textBox2.Text, out vCherapasha);           
            timer1.Start();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (x > Width)
            {
                x = -100;
            }
            if (y > Width)
            {
                y = -100;
            }
            difference = y - x;
            time = difference / vAxiles;
            dTime = time / 1000;
            x += vAxiles * dTime;
            y += vCherapasha * dTime;
            pictureBox1.Refresh();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            double.TryParse(textBox1.Text, out vAxiles);
            double.TryParse(textBox2.Text, out vCherapasha);
            timer2.Start();
        }
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {            
            timer1.Stop();
            timer2.Stop();
        } 
        
    }
}
