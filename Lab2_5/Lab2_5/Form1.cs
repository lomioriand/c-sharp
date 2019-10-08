using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label6.Text = "";
            label8.Text = "";
            radioButton1.Checked = false;
        }

        int index = 0;
        private void newclient()
        {
            index++;
            label2.Text = index.ToString();
            textBox1.Text = "";
            textBox2.Text = "";
            label6.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void calcP()
        {
            try
            {
                int staro = Int32.Parse(textBox1.Text);
                int novo = Int32.Parse(textBox2.Text);
                int res = novo - staro; //tekushto potreblenie
                label6.Text = res.ToString();
            }
            catch { }
        }

        private void calcT()
        {
            double  tarifa, res=-1;
            
            try
            {
                tarifa = Double.Parse(label6.Text);
                if (radioButton1.Checked == true) { res = tarifa * 0.34; }
                else if (radioButton2.Checked==true) { res = tarifa * 0.44; }
                else if (radioButton3.Checked==true) { res = tarifa * 0.54; }
              
                label8.Text = res.ToString();
            }
            catch { }
        }

        private void novKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newclient();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcP(); //potreblenie
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calcP();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calcT(); // tarifa
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calcT();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calcT();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zaProgramataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey this is the Water program", "Author: Nutfi ");
        }

        private void izhodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
