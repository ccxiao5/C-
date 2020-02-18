using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace experiment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int location=0;//用于标记替换位置
        //用于传值
        public RichTextBox getTxtPaper
        {
            get {
                return txtPaper;
            }
        }
        public TextBox getTxtFinding
        {
            get
            {
                return txtFinding;
            }
        }
        public TextBox getTxtReplacing
        {
            get
            {
                return txtReplacing;
            }
        }
        public Label getLabReplacing
        {
            get
            {
                return labReplacing;
            }
        }
        public int numFind;//numFind用于统计查找个数
        public int numReplace = 0;//numReplace用于统计替换个数
        private void Form1_Activated(object sender, EventArgs e)
        {
            txtFinding.Focus();
        }

        private void txtFinding_TextChanged(object sender, EventArgs e)
        {
            String text = txtPaper.Text;//用来获取txtPaper的值，大小写敏感
            String findText = txtFinding.Text;//用来查找的text
            String txtReplace = txtReplacing.Text;
            txtPaper.SelectAll();
            txtPaper.SelectionColor = Color.Black;//消除上一次查找高亮单词
            if (findText == "")
            {
                labFinding.Visible = false;              
                txtPaper.Select(0, 0);
                return;
            }
            int i = text.IndexOf(findText);//i用来标记查找位置
            numFind = 0;
            while (i < text.Length && i != -1)
            {
                /****
                 * 
                 * Selection方法只能选择最后出现相同单词（句子）的地方，所以我们改进让相同的单词变成红色
                 * 使用richTextBox
                 * 
                 ****/
                txtPaper.Select(i, findText.Length);
                txtPaper.SelectionColor = Color.Red;
                i = text.IndexOf(findText, i + findText.Length);
                numFind++;
            }
            location = text.IndexOf(findText);
            if (location != -1)
                txtPaper.Select(location, findText.Length);//选中第一个
            else
                txtPaper.Select(0, 0);//取消选中
            if (numFind == 0)
                btNext.Enabled = false;
            else
                btNext.Enabled = true;
            labFinding.Text = "已查找" + numFind.ToString() + "次";
            labFinding.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);//把Form1作为Form2的所有者传递给Form2 
        }

        private void txtReplacing_TextChanged(object sender, EventArgs e)
        {
            labReplacing.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {                                                                                               
            this.Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            int i =txtPaper.Text.IndexOf(txtFinding.Text,location+txtFinding.Text.Length);
            if (i == -1)
            {
                location = txtPaper.Text.IndexOf(txtFinding.Text);
                if (location != -1)
                    i = location;
                else
                { 
                    txtPaper.Select(0, 0);
                    btNext.Enabled = false;
                    return;
                }
            }
            else
                location = i;
            txtPaper.SelectionStart = i;
            txtPaper.SelectionLength = txtFinding.Text.Length;
            }

        }
}