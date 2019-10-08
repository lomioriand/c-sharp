using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, D, d;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            D = (b * b) - (4 * a * c);
            d = Math.Sqrt(D);

            if (D == 0)
            {
                x1 = -b/(2*a);
                x2 = x1;
                label6.Text = x1.ToString();
                label7.Text = x2.ToString();
            }
            else if(D > 0)
            {
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                label6.Text = x1.ToString();
                label7.Text = x2.ToString();
            }
            else if(D<0)
            {
                label4.Text = "D<0";
                label5.Text = "Nqma realni koreni";
            }


            button1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
