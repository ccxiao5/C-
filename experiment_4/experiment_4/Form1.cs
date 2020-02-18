using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace experiment_4
{
    public partial class Form1 : Form
    {
        String Fname="";
        public String findtext="";
        public int location=0;//标记第几个选中位置
        public Form1()
        {
            InitializeComponent();
        }
        public RichTextBox getRTextBox {
            get {
                return rTextBox;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rTextBox.Width = this.ClientSize.Width;
            rTextBox.Height = this.ClientSize.Height - menuStrip1.Height;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            rTextBox.Width = this.ClientSize.Width;
            rTextBox.Height = this.ClientSize.Height - menuStrip1.Height - toolStrip1.Height;
        }
        private void 打开_Click(object sender, EventArgs e)
        {
           // openFileDialog1.InitialDirectory = "C:\\";//设置对话框初始位置
            openFileDialog1.Filter="所有文件|*.*|文本文件|*.txt";//设置文件名删选器字符串
            openFileDialog1.FilterIndex = 1;//设置文件筛选器的索引
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Fname = openFileDialog1.FileName;//获取文件的路径和文件名
                FileStream fs = new FileStream(Fname, FileMode.Open, FileAccess.Read);//创建只读的流文件
                StreamReader sr = new StreamReader(fs);
                rTextBox.Text = "";
                rTextBox.Text += sr.ReadToEnd();
                fs.Close();
            }
        }
        private void open_Click(object sender, EventArgs e)
        {
         //   openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "所有文件|*.*|文本文件|*.txt";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Fname = openFileDialog1.FileName;
                FileStream fs = new FileStream(Fname, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rTextBox.Text = "";
                rTextBox.Text += sr.ReadToEnd();
                fs.Close();
            }
        }
        private void 保存_Click(object sender, EventArgs e)
        {
            if (Fname == "" && rTextBox.Text == "")
                MessageBox.Show("请打开文件或输入内容后在保存");
            else
            {
                String file;
                FileStream fs = new FileStream(Fname, FileMode.Open, FileAccess.Write);//FileMode.Open文件指针在开头,FileMode.Append文件指针在末尾
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < rTextBox.Lines.Length; i++)//遍历行
                {
                    file = rTextBox.Lines[i];
                    sw.WriteLine(file);
                }
                sw.Close();
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (Fname == "" && rTextBox.Text == "")
            {      
                MessageBox.Show("请打开文件或输入内容后在保存","提示");
            }
            else
            {
                String file;
                FileStream fs = new FileStream(Fname, FileMode.Create, FileAccess.Write);//FileMode.Open文件指针在开头,FileMode.Append文件指针在末尾
                StreamWriter sw = new StreamWriter(fs);
                /**
                 * 此处会产生bug，因为在对于4行的数据，你删除一行保存，文件流里面仍然有4行
                 * FileStream fs = new FileStream(Fname, FileMode.Create, FileAccess.Write);
                 * FileMode.Create:表示如果存在覆盖
                 * 或者用这样直接创建StreamWriter对象
                 * StreamWriter sw = new StreamWriter(Fname，false，Encoding.default);
                 * false表示覆盖文件不追加
                 * 
                 * */
                for (int i = 0; i < rTextBox.Lines.Length; i++)//遍历行
                {
                    file = rTextBox.Lines[i];
                    sw.WriteLine(file);
                }
                sw.Close();
            }
        }
        private void 退出_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否保存后退出？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK) ;
            {
                String file;
                FileStream fs = new FileStream(Fname, FileMode.Create, FileAccess.Write);//FileMode.Open文件指针在开头,FileMode.Append文件指针在末尾
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < rTextBox.Lines.Length; i++)//遍历行
                {
                    file = rTextBox.Lines[i];
                    sw.WriteLine(file);
                }
                sw.Close();
            }
             this.Close();
           }
        private void 剪切_Click(object sender, EventArgs e)
        {
            rTextBox.Cut();
        }
        private void 复制_Click(object sender, EventArgs e)
        {
            rTextBox.Copy();
        }
        private void 粘贴_Click(object sender, EventArgs e)
        {
            rTextBox.Paste();
        }
        private void cut_Click(object sender, EventArgs e)
        {
            rTextBox.Cut();
        }
        private void copy_Click(object sender, EventArgs e)
        {
            rTextBox.Copy();
        }
        private void paste_Click(object sender, EventArgs e)
        {
            rTextBox.Paste();
        }
        private void 查找_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }
        private void 查找下一个_Click(object sender, EventArgs e)
        {
            if (findtext == "")
            {
                MessageBox.Show("请设置所需查找内容", "提示");
                return;
            }
            else
            {
                int i = rTextBox.Text.IndexOf(findtext, location + findtext.Length);
                if (i == -1)
                {
                    location = rTextBox.Text.IndexOf(findtext);
                    if (location != -1)
                        i = location;
                    else
                    {
                        MessageBox.Show("没有查到所输内容", "提示");
                        rTextBox.Select(0, 0);
                    }
                }
                else
                    location = i;
                rTextBox.SelectionStart = i;
                rTextBox.SelectionLength = findtext.Length;
            }
        }
        private void 字体_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rTextBox.ForeColor = fontDialog1.Color;
                rTextBox.Font = fontDialog1.Font;
            }
        }
        private void font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rTextBox.ForeColor = fontDialog1.Color;
                rTextBox.Font = fontDialog1.Font;
            }
        }

        private void bold_Click(object sender, EventArgs e)
        {
            if (rTextBox.SelectionFont.Bold)
                rTextBox.SelectionFont = new Font(rTextBox.Font, rTextBox.SelectionFont.Style&~FontStyle.Bold);
            else
                rTextBox.SelectionFont = new Font(rTextBox.Font, rTextBox.SelectionFont.Style|FontStyle.Bold);
        }
        private void Italy_Click(object sender, EventArgs e)
        {
            if(rTextBox.SelectionFont.Italic)
                rTextBox.SelectionFont = new Font(rTextBox.Font, rTextBox.SelectionFont.Style & ~FontStyle.Italic);
            else
                rTextBox.SelectionFont = new Font(rTextBox.Font, rTextBox.SelectionFont.Style |FontStyle.Italic);
        }
        private void underline_Click(object sender, EventArgs e)
        {
            if(rTextBox.SelectionFont.Underline)
                rTextBox.SelectionFont = new Font(rTextBox.Font, rTextBox.SelectionFont.Style & ~FontStyle.Underline);
            else
                rTextBox.SelectionFont = new Font(rTextBox.Font, rTextBox.SelectionFont.Style |FontStyle.Underline);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rTextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void replace_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }

    }
}
