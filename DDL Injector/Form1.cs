using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDL_Injector
{
    public partial class Form1 : Form
    {
        public string FilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if(!openFileDialog1.CheckFileExists || !openFileDialog1.CheckPathExists)
            {
                openFileDialog1.ShowDialog();
                return;
            }
            FilePath = openFileDialog1.FileName;
            file_path_label.Text = $"File path:{FilePath}";
        }

        private void pid_label_Click(object sender, EventArgs e)
        {

        }
    }
}
