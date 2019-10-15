using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class Form2 : Form
    {
        int flag; // za izbraniq radio button

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            flag = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            flag = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            flag = 5;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            flag = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            flag = 7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null; 
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, result;
                a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox2.Text);

                switch (flag)
                {
                    case 1:
                        result = Math.Pow((a + b),2);
                        break;

                    case 2:
                        result = Math.Pow((a - b), 2);
                        break;

                    case 3:
                        result = (a + b) * (a - b);
                        break;

                    case 4:
                        result = Math.Pow((a + b), 3);
                        break;

                    case 5:
                        result = Math.Pow((a - b), 3);
                        break;

                    case 6:
                        result = (a * a * a) + (b * b * b);
                        break;

                    case 7:
                        result = (a * a * a) - (b * b * b);
                        break;

                    default:
                        result = -1;
                        break;
                }
                textBox3.Text = result.ToString();
            }
            catch { }
        }
    }
}
