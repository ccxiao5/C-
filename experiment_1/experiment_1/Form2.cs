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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void yes_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            String findText = form1.getTxtFinding.Text;
            String txtReplace = form1.getTxtReplacing.Text;
            String text = form1.getTxtPaper.Text;
            int i = text.IndexOf(findText);//i用来标记查找位置
            int j = 0;//j用来找到被替换的位置
            text = text.Remove(form1.location, findText.Length);
            text = text.Insert(form1.location, txtReplace);
            form1.numReplace++;
            form1.getTxtPaper.Text = text;
            i = text.IndexOf(findText);
            while (i < text.Length && i != -1)
            {
                form1.getTxtPaper.Select(i, findText.Length);
                form1.getTxtPaper.SelectionColor = Color.Red;
                i = text.IndexOf(findText, i + findText.Length);
            }
            form1.getTxtPaper.SelectionStart = form1.location;
            form1.getTxtPaper.SelectionLength = txtReplace.Length;
            form1.getLabReplacing.Text = "已修改" + form1.numReplace + "次";
            form1.getLabReplacing.Visible = true;
            this.Close();
            
           
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            labInfo.Text = "是否将   \'" + form1.getTxtFinding.Text + "\'   替换成  \'" + form1.getTxtReplacing.Text + "\'";
        }
    }
}
