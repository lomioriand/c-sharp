using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_1
{
    public partial class Form1 : Form
    {
        int i = 0;
        int ans_index = 0;
        int right = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            textBox1.Visible = false;
            button2.Visible = false;

            label1.Text = questions[i];
            radioButton1.Text = answers[ans_index];
            radioButton2.Text = answers[ans_index + 1];
            radioButton3.Text = answers[ans_index + 2];
            radioButton4.Text = answers[ans_index + 3];

        }

        string[] questions = new string[]
{   "What is 9 cubed?", "What is 6+3?",
    "What type of animal is tuna sandwiches made from?",
    "What is 18 backwards?",
    "What color is the snow?",
    "What is the capital of Bulgaria?"
};
        string[] answers = new string[] {
   "9", "81", "729", "2",
   "4", "2", "9", "1",
   "zebra", "aardvark", "fish", "gnu",
   "31", "81", "91", "88",
   "Red", "Green", "White", "Violet",
   "Varna", "Shumen", "Sofia", "Plovdiv"
};
        string[] quizAnswers = new string[] { "729", "9", "aardvark", "81", "White","Sofia" };

        private void button1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    if (radioButton3.Checked == true)
                        right++;
                    break;
                case 1:
                    if (radioButton3.Checked == true)
                        right++;
                    break;
                case 2:
                    if (radioButton3.Checked == true)
                        right++;
                    break;
                case 3:
                    if (radioButton2.Checked == true)
                        right++;
                    break;
                case 4:
                    if (radioButton3.Checked == true)
                        right++;
                    break;

            }
            radioButton1.Checked = true;
            if (i == 4)
            {
                i++;
                ans_index += 4;
                label1.Text = questions[i];
                radioButton1.Text = answers[ans_index];
                radioButton2.Text = answers[ans_index + 1];
                radioButton3.Text = answers[ans_index + 2];
                radioButton4.Text = answers[ans_index + 3];
                button1.Visible = false; button2.Visible = true;
            }
            else { 
                i++;
                ans_index += 4;
                label1.Text = questions[i];
                radioButton1.Text = answers[ans_index];
                radioButton2.Text = answers[ans_index + 1];
                radioButton3.Text = answers[ans_index + 2];
                radioButton4.Text = answers[ans_index + 3];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                right++;
            }
            MessageBox.Show("End of Test");
            try
            {
                if (right == 6)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("C:/Users/Admin/source/repos/Lab7_1/frog.jpg");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }catch { MessageBox.Show("Image file not found"); }

            label2.Text = "Result:";
            textBox1.Visible = true;
            textBox1.Text = right.ToString()+" out of 6";
        }
    }
}
