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

namespace Lab6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(dateTimePicker1.Value.ToString());
        }
        Regex egnCheck = new Regex(@"^\d{10}$");
        Regex lnchCheck = new Regex(@"^\d{10}$");
        Regex bulCheck = new Regex(@"^\d{9,13}$");

        private void EGN()
        {
            string egn = textBox1.Text;
            string y, m, d, p;
            int ny, nm, nd;

            y = (egn[0].ToString() + egn[1].ToString()).ToString();
            m = (egn[2].ToString() + egn[3].ToString()).ToString();
            d = (egn[4].ToString() + egn[5].ToString()).ToString();

            ny = Int32.Parse(y);
            nm = Int32.Parse(m);
            nd = Int32.Parse(d);

            int controlSum = (egn[0] * 2) + (egn[1] * 4) + (egn[2] * 8) + (egn[3] * 5) +
                (egn[4] * 10) + (egn[5] * 9) + (egn[6] * 7) + (egn[7] * 3) + (egn[8] * 6);

            controlSum = controlSum - ((controlSum / 11) * (controlSum / 11));
            if (controlSum == 10) { controlSum = 0; }

            if (!egnCheck.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Невалидно ЕГН");
            }
            else
            {
                errorProvider1.Clear();

                try
                {
                    if (egn[8] % 2 == 0)
                    {
                        p = "Мъж";
                    }
                    else { p = "Жена"; }


                    if (nm > 0 && nm < 13)
                    {
                        y = "19" + y;
                        dateTimePicker1.Value = new DateTime(Int32.Parse(y), Int32.Parse(m), Int32.Parse(d));
                    }
                    if (nm > 20 && nm < 40)
                    {
                        nm = nm - 20;//Poluchava se mesecut
                        m = nm.ToString();

                        y = "18" + y;
                        dateTimePicker1.Value = new DateTime(Int32.Parse(y), Int32.Parse(m), Int32.Parse(d));
                    }
                    if (nm > 40)
                    {
                        nm = nm - 40;
                        m = nm.ToString();
                        y = "20" + y;
                        dateTimePicker1.Value = new DateTime(Int32.Parse(y), Int32.Parse(m), Int32.Parse(d));
                    }
                    MessageBox.Show("Вашият пол: " + p);

                } catch { }
            }
        }

        private void LNCH()
        {
            if (!lnchCheck.IsMatch(textBox1.Text))
            {
                errorProvider2.SetError(textBox1, "Невалидни данни /ЛНЧ");
            }
            else
            {
                errorProvider2.Clear();
                string ln = textBox1.Text;
                int controlSum = 0;
                controlSum += Convert.ToInt32(ln.Substring(0, 1)) * 21;
                controlSum += Convert.ToInt32(ln.Substring(1, 1)) * 19;
                controlSum += Convert.ToInt32(ln.Substring(8, 1)) * 1;

                int ControlDigit = Convert.ToInt32(controlSum) % 10;
                if (ln.Length == 10)
                {
                    if (Convert.ToInt32(ln.Substring(9, 1)) != ControlDigit)
                        MessageBox.Show("Грешна контролна сума. Вярната е: " + ControlDigit, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        private bool ValidateBultat_9()
        {
            int l = Convert.ToInt32(textBox1.Text.Length);
            string s;
            if (IsBulstatValid_9(textBox1.Text))
            {
                return true;
            }
            else
            {
                s = "Невалиден Булстат <> от 9 ! Въвели сте " + Convert.ToString(l) + " символа!";
                MessageBox.Show(s, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        private bool IsBulstatValid_9(string aText)
        {
            if (aText.Length != 9)
            {
                return false;
            }

            for (int i = 0; i < aText.Length; i++)
            {
                if (!Char.IsDigit(aText[i]))
                {
                    return false;
                }
            }
            string rd = textBox1.Text;
            // Контролна сума на 9 знаков Булстат

            int ControlSum = Convert.ToInt32(rd.Substring(0, 1)) * 1;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(1, 1)) * 2;

            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(7, 1)) * 8;
            int ControlDigit = Convert.ToInt32(ControlSum) % 11;

            if (aText.Length == 9)
            {
                if (ControlDigit == 10) //Проверяваме дали контролната сума е = 10
                {
                    ControlSum = Convert.ToInt32(rd.Substring(0, 1)) * 3;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(1, 1)) * 4;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(7, 1)) * 10;
                    ControlDigit = Convert.ToInt32(ControlSum) % 11;
                    {
                        if (ControlDigit == 10)
                            ControlDigit = 0;
                        else
                            MessageBox.Show("ControlDigit" + ControlDigit);
                    }

                }
                if (Convert.ToInt32(rd.Substring(8, 1)) != ControlDigit)
                    MessageBox.Show("Грешна контролна сума. Вярната е: " + ControlDigit, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            return true;
        }

        private void BUL()
        {
            if (!bulCheck.IsMatch(textBox1.Text))
            {
                errorProvider3.SetError(textBox1, "Невалидни данни /БУЛСТАТ");
            }
            else
            {
                errorProvider3.Clear();
                ValidateBultat_9();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                EGN();
            } else if (radioButton2.Checked == true)
            {
                LNCH();
            } else if (radioButton3.Checked == true)
            {
                BUL();
            }
        }
    }
}
