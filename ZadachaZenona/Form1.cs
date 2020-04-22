﻿using System;
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
        double _speedAxiles;
        double _speedCherapasha;
        double _x;
        double _y;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;
            Pen Pen = new Pen(Color.Black, 3);
            Pen Pen_2 = new Pen(Color.Gray, 3);
            grf.DrawEllipse(Pen, (float)_x, pictureBox1.Height-100, 100, 100);
            grf.DrawEllipse(Pen_2, (float)_y, pictureBox1.Height - 50, 50, 50);           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_x > Width)
            {
                _x = -100;
            } 
            if (_y > Width)
            {
                _y = -100;
            }            
            _x += _speedAxiles;
            _y += _speedCherapasha;
            pictureBox1.Refresh();
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
            double.TryParse(textBox1.Text, out _speedAxiles);
            double.TryParse(textBox2.Text, out _speedCherapasha);           
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
            if (_x > Width)
            {
                _x = -100;
            }
            if (_y > Width)
            {
                _y = -100;
            }
            double difference = _y - _x;
            double time = difference / _speedAxiles;
            double dTime = time / 1000;
            _x += _speedAxiles * dTime;
            _y += _speedCherapasha * dTime;
            pictureBox1.Refresh();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            double.TryParse(textBox1.Text, out _speedAxiles);
            double.TryParse(textBox2.Text, out _speedCherapasha);
            timer2.Start();
        }
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {            
            timer1.Stop();
            timer2.Stop();
        } 
        
    }
}
