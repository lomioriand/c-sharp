using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Enabled = false;
        }

        string s="";
        double sum=0;
        double num=0;
        int operation = 0;

        /*buttons 1 - 10
         * sa chislata posledovatelno
         */
        private void button1_Click(object sender, EventArgs e)
        {
            s += button1.Text;
            textBox1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s += button2.Text;
            textBox1.Text = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s += button3.Text;
            textBox1.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s += button4.Text;
            textBox1.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s += button5.Text;
            textBox1.Text = s;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s += button6.Text;
            textBox1.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s += button7.Text;
            textBox1.Text = s;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            s += button8.Text;
            textBox1.Text = s;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            s += button9.Text;
            textBox1.Text = s;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            s += button10.Text;
            textBox1.Text = s;
        }

        //plus button
        private void button16_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            operation = 1;
            s = "";
            sum += Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        //subtract button
        private void button15_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            operation = 2;
            s = "";
            sum -= Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        //multiply button
        private void button14_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            sum = 1;
            operation = 3;
            s = "";
            sum *= Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        //divide button
        private void button13_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            sum = 1;
            operation = 4;
            s = "";
            sum *= Double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        //clear button
        private void button18_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            s = "";
            textBox1.Text = "";
        }

        //equals button
        private void button17_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            switch (operation)
            {
                case 1:
                    num = Double.Parse(textBox1.Text);
                    sum += num;
                    break;
                case 2:
                    num = Double.Parse(textBox1.Text);
                    sum = -num - sum;
                    break;
                case 3:
                    num = Double.Parse(textBox1.Text);
                    sum = num * sum;
                    break;
                case 4:
                    num = Double.Parse(textBox1.Text);
                    sum = sum / num;
                    break;
            }
            textBox1.Text = (sum).ToString();
            s = sum.ToString();
            sum = 0;
        }

        //decimal button
        private void button12_Click(object sender, EventArgs e)
        {
            s += button12.Text;
            textBox1.Text = s;
            button12.Enabled = false;
        }

        //+/- button
        private void button11_Click(object sender, EventArgs e)
        {
            s = (Double.Parse(s) * -1).ToString();
            textBox1.Text = s;
        }

        //ToBinary button
        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(s);
                string binary = Convert.ToString(value, 2);
                richTextBox1.Text = binary;
            }
            catch { richTextBox1.Text = "No number is entered"; }
        }

        //10^x button
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                sum = 1;
                for (int i = 0; i < Int32.Parse(s); i++)
                {
                    sum *= 10;
                }
                s = sum.ToString();
                textBox1.Text = s;
                sum = 0;
            }
            catch { textBox1.Text = "Select number first"; }
        }

        //sqrt button
        private void button19_Click(object sender, EventArgs e)
        {

            sum = Math.Sqrt(Double.Parse(s));
            s = sum.ToString();
            textBox1.Text = s;
            sum = 0;
        }

        //sin button
        private void button24_Click(object sender, EventArgs e)
        {
            sum = Math.Sin(Double.Parse(s));
            s = sum.ToString();
            textBox1.Text = s;
            sum = 0;
        }

        //cos button
        private void button27_Click(object sender, EventArgs e)
        {
            sum = Math.Cos(Double.Parse(s));
            s = sum.ToString();
            textBox1.Text = s;
            sum = 0;
        }

        //tg button
        private void button26_Click(object sender, EventArgs e)
        {
            sum = Math.Tan(Double.Parse(s));
            s = sum.ToString();
            textBox1.Text = s;
            sum = 0;
        }

        //x^2
        private void button22_Click(object sender, EventArgs e)
        {
            sum = Double.Parse(s);
            sum = sum * sum;
            s = sum.ToString();
            textBox1.Text = s;
            sum = 0;
        }

        //x^3
        private void button23_Click(object sender, EventArgs e)
        {
            sum = Double.Parse(s);
            sum = sum * sum * sum;
            s = sum.ToString();
            textBox1.Text = s;
            sum = 0;
        }

        //log10
        private void button21_Click(object sender, EventArgs e)
        {
            sum = Math.Log10(Double.Parse(s));
            s = sum.ToString();
            textBox1.Text = s;
            sum = 0;
        }

        //Pi
        private void button25_Click(object sender, EventArgs e)
        {
            s = Math.PI.ToString();
            textBox1.Text = s;
        }

        //n!
        private void button28_Click(object sender, EventArgs e)
        {
            double num = Int32.Parse(s);
            sum = 1;

            while(num!=0)
            {
                sum *= num;
                num--;
            }

            s = sum.ToString();
            textBox1.Text = s;
            sum = 0;
        }
    }
}
