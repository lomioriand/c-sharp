using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            label3.Text = "Rezultat";
            textBox2.Text = null;
        }

        private void calculate()
        {
            double t = 0, res = 0;
            try
            {
                t = Double.Parse(textBox1.Text);
            }
            catch
            {

            }

            if (comboBox1.SelectedItem.ToString() == "C")
            {
                res = Math.Round(((t * 9) / 5 + 32),2);
                label3.Text = t.ToString() + " from C to F : ";
            }
            else
            {
                res = Math.Round(((t - 32) / (1.8)),2);
                label3.Text = t.ToString() + " from F to C : ";
            }

            textBox2.Text = res.ToString();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
