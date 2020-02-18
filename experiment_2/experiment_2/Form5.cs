using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace experiment_2
{
    public partial class Form_show : Form
    {
        public Form_show()
        {
            InitializeComponent();
        }

        private void Form_show_Load(object sender, EventArgs e)
        {
            txtGoal.Text += "";
            Form_home form_home = (Form_home)this.Owner;
            Players temp;
            for(int i = 0;i<form_home.inputNumPlayer() - 1;i++)
                for (int j = 0; j < form_home.inputNumPlayer() - 1 - i; j++)
                    if (form_home.player[j].getFinalGoal() < form_home.player[j + 1].getFinalGoal())
                    {
                        temp = form_home.player[j];
                        form_home.player[j] = form_home.player[j + 1];
                        form_home.player[j + 1] = temp;
                    }
            for (int i = 0; i < form_home.inputNumPlayer(); i++)
                txtGoal.Text += (i + 1).ToString() + ". " + "选手编号:  " + form_home.player[i].getId() + "\t" + "选手姓名:  " + form_home.player[i].getName() + "\t" + "选手成绩:  " + form_home.player[i].getFinalGoal() + "\r\n";
            txtGoal.Select(0, 0);//取消自动选中
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
