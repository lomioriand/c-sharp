using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Area Calculation";
            label2.Text = "";
            label3.Text = "";
        }

        private void calcArea()
        {
            try
            {
                int h = vScrollBar1.Value;
                int w = hScrollBar1.Value;
                int area = h * w;

                label1.Text = "Height : " + h.ToString();
                label2.Text = "Width : " + w.ToString();
                label3.Text = "Area : " + area.ToString();
            }
            catch { }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            calcArea();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            calcArea();
        }
    }
}
