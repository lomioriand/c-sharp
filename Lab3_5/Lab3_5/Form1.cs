using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int p;
            var labels = new List<Label> { label1, label2, label3, label4, label5, label6 };

            foreach (var label in labels)
            {
                p = rand.Next(49) + 1;
                label.Text = p.ToString() ;
            }
            
        }
    }
}
