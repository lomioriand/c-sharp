using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        TextBox tx1 = new TextBox();
        TextBox tx2 = new TextBox();

        void func1(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(tx1.Text);
                if (x > 360 || x < -360) { throw new ArgumentOutOfRangeException(); };
                double sin = Math.Round(Math.Sin(x), 3);
                double cos = Math.Round(Math.Cos(x), 3);
                double tan = Math.Round(Math.Tan(x), 3);

                MessageBox.Show("Trigonometric functions \n " +
                                "cos " + x + " = " + cos +
                                "\nsin " + x + " = " + sin +
                                "\ntan " + x + " = " + tan, "");
            }
            catch { MessageBox.Show("X should be between [-360;360]"); } 
        }

        void func2(object sender, EventArgs e)
        {
            try
            {
                double r = Double.Parse(tx2.Text);
                if (r > 10 || r < 1) { throw new ArgumentOutOfRangeException(); };
                double S = Math.Round(Math.PI * r * r, 2);
                double P = Math.Round(2 * Math.PI * r, 2);

                MessageBox.Show("S i P na okrujnost\n S=" + S + "\n P=" + P);
            }
            catch { MessageBox.Show("r should be between [1;10]"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx1.Size = new System.Drawing.Size(120, 30);
            tx1.Location = new System.Drawing.Point(20, 40);
            this.Controls.Add(tx1);
            tx1.TextChanged += new EventHandler(func1);

            tx2.Size = new System.Drawing.Size(120, 3);
            tx2.Location = new System.Drawing.Point(60, 80);
            this.Controls.Add(tx2);
            tx2.TextChanged += new EventHandler(func2);
        }
    }
}
