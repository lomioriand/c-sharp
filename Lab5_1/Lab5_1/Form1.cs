using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int month = int.Parse(dateTimePicker1.Value.ToString("MM"));
                int day = int.Parse(dateTimePicker1.Value.ToString("dd"));
                string astro_sign = "";
                if (month == 12)
                {

                    if (day < 22)
                        astro_sign = "strelets";
                    else
                        astro_sign = "kozirog";
                }

                else if (month == 1)
                {
                    if (day < 20)
                        astro_sign = "kozirog";
                    else
                        astro_sign = "vodolei";
                }

                else if (month == 2)
                {
                    if (day < 19)
                        astro_sign = "vodolei";
                    else
                        astro_sign = "ribi";
                }

                else if (month == 3)
                {
                    if (day < 21)
                        astro_sign = "ribi";
                    else
                        astro_sign = "oven";
                }
                else if (month == 4)
                {
                    if (day < 20)
                        astro_sign = "oven";
                    else
                        astro_sign = "telets";
                }

                else if (month == 5)
                {
                    if (day < 21)
                        astro_sign = "telets";
                    else
                        astro_sign = "bliznatsi";
                }

                else if (month == 6)
                {
                    if (day < 21)
                        astro_sign = "bliznatsi";
                    else
                        astro_sign = "rak";
                }

                else if (month == 7)
                {
                    if (day < 23)
                        astro_sign = "rak";
                    else
                        astro_sign = "LUV";
                }

                else if (month == 8)
                {
                    if (day < 23)
                        astro_sign = "LUV";
                    else
                        astro_sign = "deva";
                }

                else if (month == 9)
                {
                    if (day < 23)
                        astro_sign = "deva";
                    else
                        astro_sign = "vezni";
                }

                else if (month == 10)
                {
                    if (day < 23)
                        astro_sign = "vezni";
                    else
                        astro_sign = "skorpion";
                }

                else if (month == 11)
                {
                    if (day < 22)
                        astro_sign = "skorpion";
                    else
                        astro_sign = "strelets";
                }

                richTextBox1.Text = "Zodiac sign: " + astro_sign;
            }
            catch { }
        }
    }
}
