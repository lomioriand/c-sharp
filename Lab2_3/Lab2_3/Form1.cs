using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc()
        {
            try
            {
                double[,] arr = new double[4, 4] { { 1, 0.33333, 1.1989, 0.0001893 },
                                                    { 3, 1, 3.5966, 0.0005682},
                                                    { 0.8341, 0.278, 1, 0.0001579 },
                                                    { 1760, 1760, 6330, 1 }
                                                    };
                double n = 0, res = 0;
                int x, y;
                x = comboBox1.SelectedIndex;
                y = comboBox2.SelectedIndex;
                n = Double.Parse(textBox1.Text);
                res = Math.Round((n * arr[x, y]),7);

                textBox2.Text = res.ToString();
            }
            catch { }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }
    }
}
