using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "60";
        }


        int a1, a2, s1, s2, m1, m2;
        double sum, diff, mul, div, d1, d2;
        int count;
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            count = 60;

            a1 = rnd.Next(1, 50);
            label4.Text = a1.ToString();

            a2 = rnd.Next(1, 50);
            label6.Text = a2.ToString();
            sum = a1 + a2;
            

            s1 = rnd.Next(1, 50);
            label7.Text = s1.ToString();

            s2 = rnd.Next(1, 50);
            label9.Text = s2.ToString();
            diff = s1 - s2;

            m1 = rnd.Next(1, 50);
            label10.Text = m1.ToString();

            m2 = rnd.Next(1, 50);
            label12.Text = m2.ToString();
            mul = m1 * m2;

            d1 = rnd.Next(1, 50);
            label13.Text = d1.ToString();

            d2 = rnd.Next(1, 50);
            label15.Text = d2.ToString();
            div = d1 / d2;
            div = Math.Round(div, 2);

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            label2.Text = count.ToString();
        }

        private void finish()
        {
            try
            {
                int correct = 0;
                int wrong = 4;

                if (Double.Parse(numericUpDown1.Value.ToString()) == sum) { correct++; }
                if (Double.Parse(numericUpDown2.Value.ToString()) == diff) { correct++; }
                if (Double.Parse(numericUpDown3.Value.ToString()) == mul) { correct++; }
                if (Double.Parse(numericUpDown4.Value.ToString()) == div) { correct++; }
                MessageBox.Show("Correct: " + correct.ToString() + " \n Wrong:  " + (wrong - correct).ToString());
            }
            catch { }

            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                timer1.Stop();
                finish();
            }
            label2.Text = count.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            finish();
        }
    }
}
