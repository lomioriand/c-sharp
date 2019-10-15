using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_2
{
    public partial class Form1 : Form
    {
        int flag;

        public Form1()
        {
            InitializeComponent();
            label5.Text = null;
            label6.Text = null;
            label8.Text = null;
            label10.Text = null;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {//допуска запетая, BackSpace Ascii 44 и запетая -  Ascii 8            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true; textBox1.Focus();
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z, pddo, pdzpo, doo, dzpo, zdravni, total;

            try
            {
                z = Double.Parse(textBox1.Text);

                if(flag == 1) { pddo = 0.089; pdzpo = 0; }
                else { pddo = 0.067; pdzpo = 0.0022; }

                doo = Math.Round(pddo * z,2);
                dzpo = Math.Round(pdzpo * z,2);

                zdravni = Math.Round(0.032 * z,2);

                total = Math.Round(doo + dzpo + zdravni,2);

                label5.Text = doo.ToString();
                label6.Text = dzpo.ToString();
                label8.Text = zdravni.ToString();
                label10.Text = total.ToString();

            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
