using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_6
{
    public partial class Form2 : Form
    {
        public int n;

        public Form2(int n)
        {
            this.n = n;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = Int32.Parse(textBox1.Text);
            if (guess < n)
            {
                MessageBox.Show("The number is bigger than " + guess);
            }
            else if(guess > n)
            {
                MessageBox.Show("The number is smaller than " + guess);
            }
            else { MessageBox.Show("Poznahte! Chisloto e " + n); }
            //
        }
    }
}
