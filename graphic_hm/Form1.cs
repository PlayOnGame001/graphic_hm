using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic_hm
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(this.Width, this.Height);

            comboBox1.SelectionLength = 0;
            comboBox1.Items.Add("y = kx");
            comboBox1.Items.Add("y = kx + b");
            comboBox1.Items.Add("y = x^2");
            comboBox1.Items.Add("y = x^3");
            comboBox1.Items.Add("y = x^1/2");
            //comboBox1.Items.Add("y = ax^2 + bx + c");
            //comboBox1.Items.Add("y = sinx");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                g = Graphics.FromImage(pictureBox1.Image = bitmap);
                g.DrawLine(Pens.Black, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
                g.DrawLine(Pens.Black, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);

                Graphics gr = pictureBox1.CreateGraphics();
                gr = Graphics.FromImage(pictureBox1.Image = bitmap);


                int a = 1;
                int b = 0;
                int c = 0;
                double x, y;
                int orgio_x = pictureBox1.Width / 2;
                int orgio_y = pictureBox1.Height / 2;

                Bitmap bit = new Bitmap(1, 1);
                bit.SetPixel(0, 0, Color.Red);


                int index = comboBox1.SelectedIndex;
                switch (index)
                {
                    case 0:
                        gr.DrawLine(Pens.Red, 10, 338, 338, 10);
                        break;

                    case 1:
                        gr.DrawLine(Pens.Red, 10, 338, 338, 40);
                        break;

                    case 2:
                        for (double i = 0; i < 10000; i += 0.01)
                        {
                            x = i;
                            y = (a * (x * x)) + ((b * x) + c);
                            gr.DrawImageUnscaled(bit, orgio_x + (int)x, orgio_y - (int)y);
                            gr.DrawImageUnscaled(bit, orgio_x - (int)x, orgio_y - (int)y);
                        }
                        break;

                    case 3:
                        for (double i = 0; i < 10000; i += 0.01)
                        {
                            x = i;
                            y = (a * (x * x)) + ((b * x) + c);
                            gr.DrawImageUnscaled(bit, orgio_x + (int)x, orgio_y - (int)y);
                            gr.DrawImageUnscaled(bit, orgio_x - (int)x, orgio_y + (int)y);
                        }
                        break;

                    case 4:
                        int orgio3_x = 177;
                        int orgio3_y = 171;

                        for (double i = 0; i < 10000; i += 0.01)
                        {
                            x = i;
                            y = (a * (x * x)) + ((b * x) + c);
                            gr.DrawImageUnscaled(bit, orgio3_x + (int)y, orgio3_y - (int)x);
                        }
                        break;
                }
        }
    }
}
