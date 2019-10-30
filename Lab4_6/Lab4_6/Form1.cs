using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] toppings = new string[] { "anchovies", "bacon", "mushrooms", "onions", "peppers", "sausages" };

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            for (int i = 0; i < toppings.Length; i++)
            {
                checkedListBox1.Items.Add(toppings[i].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (radioButton1.Checked == true)
            {
                sum += 9.25;
            } else if (radioButton2.Checked == true)
            {
                sum += 11.50;
            } else if(radioButton3.Checked == true)
            {
                sum += 13.75;
            }

            string crust="";
            if(radioButton4.Checked == true)
            {
                crust = "thick";
            } else if (radioButton5.Checked == true)
            {
                crust = "thin";
            }

            string cheese = "";
            if(checkBox1.Checked == true)
            {
                sum += 1.5;
                cheese = " extra cheese and";
            }


            int n = checkedListBox1.CheckedItems.Count;
            sum += n;

            string toppings="";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    toppings +=checkedListBox1.Items[i].ToString() + " ";
                }

            }

            richTextBox1.Text = "You ordered a " + crust + " pizza with " + cheese + " " + n + " toppings: \n "+
                toppings+
                "\n Your total is "+sum;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
