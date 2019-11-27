using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public var for cut/copy/paste
        string txt = "";

        //Edit -> Undo
        Stack<string> undoList = new Stack<string>();
        bool t = true;
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = false;
            try
            {
                richTextBox1.Text = undoList.Pop().ToString();
            }
            catch { }
            t = true;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (t)
            {
                undoList.Push(richTextBox1.Text);
            }
        }

        //File -> New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        //File -> Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //File -> Open
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        //File -> Save
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files (*.*)|*.*";
            saveFile.Title = "Save";
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                StreamWriter sw = new StreamWriter(saveFile.FileName, false, utf8);
                sw.Write(str);
                sw.Close();
            }
        }

        //Edit -> Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // txt = richTextBox1.Text;
            Clipboard.SetText(richTextBox1.Text);
            richTextBox1.Clear();
        }

        //Edit -> Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //txt = richTextBox1.Text;
            Clipboard.SetText(richTextBox1.Text);
        }

        //Edit -> Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        //Edit -> Select all
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        //Format -> Font Color
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            colorDialog1.Color = richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               colorDialog1.Color != richTextBox1.SelectionColor)
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        //Format -> Alignment -> Left
        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        //Format -> Alignment -> Center
        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        //Format -> Alignment -> Right
        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        //Format -> Font
        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        //Format -> Background
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            colorDialog1.Color = richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               colorDialog1.Color != richTextBox1.BackColor)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
