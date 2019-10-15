using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool leapYear(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year, month, days;
            bool flag=false;
            try
            {
                year = Int32.Parse(textBox1.Text);
                month = Int32.Parse(textBox2.Text);

                if (leapYear(year))
                {
                    flag = true;
                    MessageBox.Show("Godinata e visokosna!");
                }
                else { MessageBox.Show("Godinata ne e visokosna!"); }

                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    days = 31;
                else if (month == 2 && flag == true) { days = 29; }
                else if (month == 2 && flag == false) { days = 28; }
                else
                    days = 30;

                MessageBox.Show("Dnite v meseca sa " + days);
            }
            catch { }
        }
    }
}
