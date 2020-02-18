using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox1.Path = driveListBox1.Drive;
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
        }

        private void dirListBox1_DoubleClick(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            pictureBox1.ImageLocation = fileListBox1.Path + @"\" + fileListBox1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loc = ((fileListBox1.SelectedIndex - 1 + fileListBox1.Items.Count) % fileListBox1.Items.Count);
            fileListBox1.SelectedIndex = loc;
            pictureBox1.ImageLocation = fileListBox1.Path + @"\" + fileListBox1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int loc = ((fileListBox1.SelectedIndex + 1 + fileListBox1.Items.Count) % fileListBox1.Items.Count);
            fileListBox1.SelectedIndex = loc;
            pictureBox1.ImageLocation = fileListBox1.Path + @"\" + fileListBox1.FileName;
        }

    }
}
