using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Lab10
{
    public partial class Form1 : Form
    {
        int x1=0, x2 =0;
        public Form1()
        {
            InitializeComponent();

            label1.Text = x1.ToString();
            label2.Text = x2.ToString();

            textBox1.Text = "Blue";
            textBox2.Text = "Red";

            try
            {
                pictureBox1.BackgroundImage = Image.FromFile("C:/Users/Admin/source/repos/Lab10/1.png");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox2.BackgroundImage = Image.FromFile("C:/Users/Admin/source/repos/Lab10/2.png");
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;

                pictureBox1.Left = x1;
                pictureBox2.Left = x2;
            }
            catch { MessageBox.Show("Images not Found"); }
        }

        private async Task startAsync()
        {
            Random rnd = new Random();

            while (x1<500 || x2<500)
            {
                x1 += rnd.Next(1, 8);
                pictureBox1.Left = x1;
                label1.Text = x1.ToString();

                x2 += rnd.Next(1, 8);
                pictureBox2.Left = x2;
                label2.Text = x2.ToString();

                await Task.Delay(40);
            }

            if (x1 > x2)
            {
                MessageBox.Show(textBox1.Text + " is the winner!");
            } else if (x2 > x1)
            {
                MessageBox.Show(textBox2.Text + " is the winner!");
            }
            else
            {
                MessageBox.Show("It's a draw!");
            }
        }


        // start button
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            startAsync();
        }

        // clear button
        private void button2_Click(object sender, EventArgs e)
        {
            x1 = 0;x2 = 0;
            label1.Text = x1.ToString();
            label2.Text = x2.ToString();
            pictureBox1.Left = x1;
            pictureBox2.Left = x2;

            button1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
