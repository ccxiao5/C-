using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace experiment_4
{
    public partial class Form2 : Form
    {
        public String findingWord;
        public Form2()
        {
            InitializeComponent();
        }
        private void tbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form1 form1 = (Form1)this.Owner;
                findingWord = tbFind.Text;
                btNext.Enabled = true;            
                if (findingWord == "")
                {
                    form1.getRTextBox.Select(0, 0);
                }
                else
                {
                    String rTxbox = form1.getRTextBox.Text;
                    int i = rTxbox.IndexOf(findingWord);//i用来标记查找位置
                    while (i < rTxbox.Length && i != -1)//设置所有fingding背景颜色
                    {
                        form1.getRTextBox.Select(i, findingWord.Length);
                        form1.getRTextBox.SelectionColor = Color.Red;
                        i = rTxbox.IndexOf(findingWord, i + findingWord.Length);
                    }
                    if (rTxbox.IndexOf(findingWord) != -1)//设置选中状态
                        form1.getRTextBox.Select(rTxbox.IndexOf(findingWord), findingWord.Length);
                    else
                    {
                        MessageBox.Show("没有查到所输内容", "提示");
                        form1.getRTextBox.Select(0, 0);
                    }
                    form1.getRTextBox.Focus();
                    form1.findtext = findingWord;
                    form1.location = rTxbox.IndexOf(findingWord);
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            form1.getRTextBox.Select(0, 0);
            String rTxbox = form1.getRTextBox.Text;
            if (rTxbox == "" || findingWord=="")
                return;
            int i = rTxbox.IndexOf(findingWord);//i用来标记查找位置
            while (i < rTxbox.Length && i != -1)//设置所有fingding背景颜色
            {
                form1.getRTextBox.Select(i, findingWord.Length);
                form1.getRTextBox.SelectionColor = Color.Black;
                i = rTxbox.IndexOf(findingWord, i + findingWord.Length);
            }
            form1.getRTextBox.Select(0, 0);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            int i = form1.getRTextBox.Text.IndexOf(form1.findtext, form1.location + form1.findtext.Length);
            if (i == -1)
            {
                form1.location = form1.getRTextBox.Text.IndexOf(form1.findtext);
                if (form1.location != -1)
                    i = form1.location;
                else
                {
                    MessageBox.Show("没有查到所输内容", "提示");
                    btReplace.Enabled = false;
                    btReplaceall.Enabled = false;
                    btNext.Enabled = false;
                    form1.getRTextBox.Select(0, 0);
                    tbFind.Focus();
                    return;
                }
            }
            else
                form1.location = i;
            form1.getRTextBox.SelectionStart = i;
            form1.getRTextBox.SelectionLength = form1.findtext.Length;
            form1.getRTextBox.Focus();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            if (tbFind.Text == "")
            {
                btNext.Enabled = false;
                btReplace.Enabled = false;
                btReplaceall.Enabled = false;
            }
        }
        private void tbReplace_TextChanged(object sender, EventArgs e)
        {
            if (tbReplace.Text == "")
            {
                btReplace.Enabled = false;
                btReplaceall.Enabled = false;
            }
            else
            {
                btReplace.Enabled = true;
                btReplaceall.Enabled = true;
            }
            Form1 form1 = (Form1)this.Owner;
            form1.getRTextBox.Focus();
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            int i = form1.getRTextBox.Text.IndexOf(tbFind.Text);//i来标记查找位置
            int j = 0;//j来标记替换位置
            form1.getRTextBox.Text=form1.getRTextBox.Text.Remove(form1.location, tbFind.Text.Length);
            form1.getRTextBox.Text=form1.getRTextBox.Text.Insert(form1.location, tbReplace.Text);
           while (i < form1.getRTextBox.Text.Length && i != -1)
            {
                form1.getRTextBox.Select(i, tbFind.Text.Length);
                form1.getRTextBox.SelectionColor = Color.Red;
                i = form1.getRTextBox.Text.IndexOf(tbFind.Text, i + tbFind.Text.Length);
            }
           form1.getRTextBox.SelectionStart = form1.location;
           form1.getRTextBox.SelectionLength = tbReplace.Text.Length;
         
        }

        private void btReplaceall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否全部替换？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Form1 form1 = (Form1)this.Owner;
                form1.getRTextBox.Text=form1.getRTextBox.Text.Replace(tbFind.Text, tbReplace.Text);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
