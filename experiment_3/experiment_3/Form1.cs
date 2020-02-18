using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace experiment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String path= driveListBox1.Drive;//获得驱动器列表框的路径
            dirListBox1.Path = path;//设置目录列表框路径
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String path = dirListBox1.Path;//获得目录列表框的路径
            fileListBox1.Path = path;//设置文件列表框路径
        }
        private void dirListBox1_DoubleClick(object sender, EventArgs e)
        {
            String path = dirListBox1.Path;//获得目录列表框的路径
            fileListBox1.Path = path;//设置文件列表框路径
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            String path = fileListBox1.Path;//获取文件目录
            String name = fileListBox1.FileName;//获取图片路径；
            String picture = path + "\\" + name;//或者path +@"\" +name
            pictureBox1.ImageLocation = picture;
        }
        private void btPrevious_Click(object sender, EventArgs e)
        {
            int loc = (fileListBox1.SelectedIndex - 1 + fileListBox1.Items.Count) % fileListBox1.Items.Count;//得到位置,fileListBox1.Items.Count得到文件数
            fileListBox1.SelectedIndex = loc;
            string path = fileListBox1.Path+"\\"+fileListBox1.get_Items(loc);
            pictureBox1.Load(path);
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            int loc = (fileListBox1.SelectedIndex + 1 + fileListBox1.Items.Count) % fileListBox1.Items.Count;//得到位置
            fileListBox1.SelectedIndex = loc;
            string path = fileListBox1.Path + "\\" + fileListBox1.get_Items(loc);
            pictureBox1.Load(path);
        }
    }
}
