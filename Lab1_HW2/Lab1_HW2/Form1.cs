using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("This is an application to show if the number is even or odd!", "Zadadcha 6");
            label1.Text = "Input a number: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(textBox1.Text);
                if (x % 2 == 0)
                {
                    label1.Text = " Even!";
                }
                else
                {
                    label1.Text = "Odd!";
                }
            }
            catch
            {
                label1.Text = "Please enter a valid number!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure u want to exit", "Wtf bruh", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
