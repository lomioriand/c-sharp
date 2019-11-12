using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Въведете име!";
            toolStripStatusLabel2.Text = (System.DateTime.Now).ToString();
            
        }

        Regex regex = new Regex(@"^\d{10}$");

        private void button1_Click(object sender, EventArgs e)
        {

            bool success = true;
            foreach (Control c in this.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0)
                    success = false;
            }

            if (success)
            {
                
            }
            else { MessageBox.Show("Проверете въведените данни" ,"FAIL"); }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Въведете презиме!";
            toolStripStatusLabel2.Text = (System.DateTime.Now).ToString();

            if (Regex.IsMatch(textBox1.Text, @"\P{IsCyrillic}"))
            {
                errorProvider1.SetError(textBox1, "Пишете на кирилица");
            }
            else { errorProvider1.Clear();}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Въведете фамилия!";
            toolStripStatusLabel2.Text = (System.DateTime.Now).ToString();

            if (Regex.IsMatch(textBox2.Text, @"\P{IsCyrillic}"))
            {
                errorProvider2.SetError(textBox2, "Пишете на кирилица");
            }
            else { errorProvider2.Clear();}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Въведете ЕГН!";
            toolStripStatusLabel2.Text = (System.DateTime.Now).ToString();

            if (Regex.IsMatch(textBox3.Text, @"\P{IsCyrillic}"))
            {
                errorProvider3.SetError(textBox3, "Пишете на кирилица");
            }
            else { errorProvider3.Clear();}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Въведете Адрес!";
            toolStripStatusLabel2.Text = (System.DateTime.Now).ToString();

            if (!regex.IsMatch(textBox4.Text))
            {
                errorProvider4.SetError(textBox4, "Само числа, максимален брой = 10");
            }
            else { errorProvider4.Clear();}
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Натиснете бутона!";
            toolStripStatusLabel2.Text = (System.DateTime.Now).ToString();
        }
    }
}
