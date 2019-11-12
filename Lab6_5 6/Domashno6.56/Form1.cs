using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;



namespace Domashno6._56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "The average temperature for the week was: ";
            button1.Text = "Temperature";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double sum = 0;
            string[] days = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string day in days)
            {
                double temperatura = (double.Parse(Interaction.InputBox("The temperature in " + day + " is: ")));
                listBox1.Items.Add(temperatura + " degrees Celsius \nwas the temperature " + day);
                sum = sum + temperatura;
            }
            sum = sum / 7;
            listBox1.Sorted = true;
            label1.Text = label1.Text + string.Format("{0:0.##}", (sum)) + " degrees centigrade."
                + "\nThe minimum temperature = " + string.Format("{0:0.##}", listBox1.Items[0].ToString())
                + "\nThe maximum temperature = " + string.Format("{0:0.##}", listBox1.Items[6].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 3] = "Weather forecast for the week ";
            xlWorkSheet.Cells[2, 1] = listBox1.Items[0].ToString();

            
            xlWorkSheet.Cells[2, 7] = listBox1.Items[6].ToString();

            xlWorkSheet.Cells[3, 3] = label1.Text;
            xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }



        private void CreateWordDocument()
        {
            object oMissing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word._Application objWord;
            Microsoft.Office.Interop.Word._Document objDoc;
            objWord = new Microsoft.Office.Interop.Word.Application();
            objWord.Visible = true;
            objDoc = objWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);
            Microsoft.Office.Interop.Word.Paragraph objPara;
            objPara = objDoc.Content.Paragraphs.Add(ref oMissing);
            objPara.Range.Text = "Weather forecast for the week ";
            objPara.Range.Font.Bold = 1;
            objPara.Range.Font.Size = 14;
            objPara.Format.SpaceAfter = 0;
            objPara.Range.InsertParagraphAfter();
            objPara.Range.Font.Bold = 0;
            objPara.Range.Font.Italic = 1;
            objPara.Range.Text = listBox1.Items[0].ToString();


            objPara.Range.Text = listBox1.Items[6].ToString();
            objPara.Range.Text = label1.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateWordDocument();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

