using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursov_proekt
{
    public partial class Form2 : Form
    {
        string team1, team2;
        int sum1 = 0; //team 1 score
        int sum2 = 0; //team 2 score

        private void button2_Click(object sender, EventArgs e)
        {
            if (sum1 > sum2)
            {
                MessageBox.Show(team1 + " are the Winners!");
            }
            else if(sum1<sum2)
            {
                MessageBox.Show(team2 + " are the Winners!");
            }
            else
            {
                MessageBox.Show("It's a Tie-Game");
            }
            this.Close();
        }

        public Form2(string t1, string t2, string p1, string p2, string p3, string p4,
                     string p5, string p6, string p7, string p8, string p9, string p10)
        {
            InitializeComponent();
           // MessageBox.Show("Welcome to the game!");
            button2.Hide();
            team1 = t1; team2 = t2;
            label1.Text = team1;
            label2.Text = team2;
            label4.Text = p1;
            label5.Text = p2;
            label6.Text = p3;
            label7.Text = p4;
            label8.Text = p5;
            label9.Text = p6;
            label10.Text = p7;
            label11.Text = p8;
            label12.Text = p9;
            label13.Text = p10;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();

            Random rnd = new Random();
            int a = rnd.Next(15, 30);
            label4.Text += " :" + a.ToString();
            sum1 += a;

            a = rnd.Next(12, 30);
            label5.Text += " :" + a.ToString();
            sum1 += a;

            a = rnd.Next(8, 26);
            label6.Text += " :" + a.ToString();
            sum1 += a;

            a = rnd.Next(7, 25);
            label7.Text += " :" + a.ToString();
            sum1 += a;

            a = rnd.Next(6, 24);
            label8.Text += " :" + a.ToString();
            sum1 += a;

            a = rnd.Next(15, 30);
            label9.Text += " :" + a.ToString();
            sum2 += a;

            a = rnd.Next(12, 30);
            label10.Text += " :" + a.ToString();
            sum2 += a;

            a = rnd.Next(8, 26);
            label11.Text += " :" + a.ToString();
            sum2 += a;

            a = rnd.Next(7, 25);
            label12.Text += " :" + a.ToString();
            sum2 += a;

            a = rnd.Next(6, 24);
            label13.Text += " :" + a.ToString();
            sum2 += a;

            textBox1.Text = sum1.ToString();
            textBox2.Text = sum2.ToString();

            button2.Show();
        }
    }
}
