using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Path;

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog1.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(Path);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Path);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
        }
    }
}
