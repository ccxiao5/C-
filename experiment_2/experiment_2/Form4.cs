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
    public partial class form_work : Form
    {
        public form_work()
        {
            InitializeComponent();
        }

        private void form_work_Load(object sender, EventArgs e)
        {
            //初始化comboBox
            Form_home form_home = (Form_home)this.Owner;
            comboPlayer.Text = form_home.player[0].getName();
             for(int i=0;i<form_home.inputNumPlayer();i++)
             {
                 Object obj = form_home.player[i].getName();
                 comboPlayer.Items.Add(obj);
             }          
             comboRater.Text = "第1位评委";
             for (int i = 1; i <= form_home.inputNumRater(); i++)
             {
                 String temp ="第" + i.ToString() + "位评委";
                 Object obj = temp;
                 comboRater.Items.Add(obj);
             }
             if (comboPlayer.Items.Count > 0)//这句不能删掉，原因没有找到
             {   
                 comboPlayer.SelectedIndex = 0; //默认选择第一条
             }
             if (comboRater.Items.Count > 0)
             {
                 comboRater.SelectedIndex = 0; //默认选择第一条
             }
             txtGoal.Focus();
        }
        private void txtGoal_KeyDown(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode;
            int id = comboPlayer.SelectedIndex;//获取第几位选手
            int location = comboRater.SelectedIndex;//标记第几个评委
            Form_home form_home = (Form_home)this.Owner;
            if (k == Keys.Enter)
            {
                if (!btModify.Enabled)//通过修改按钮是否可用判断是录分还是保存，没有启用说明还在录分
                {
                    form_home.goal[location++] = Convert.ToDouble(txtGoal.Text);
                    if (location < form_home.inputNumRater())//避免越界
                    {
                        comboRater.SelectedIndex = location;
                        comboRater.Text = comboRater.Items[location].ToString();
                    }
                    else
                    {
                        form_home.player[id].getGoal(form_home.goal);
                        labMaxGoal.Visible = true;
                        labMaxGoal.Text = form_home.player[id].getMaxGoal().ToString();
                        labMinGoal.Visible = true;
                        labMinGoal.Text = form_home.player[id].getMinGoal().ToString();
                        labGoal.Visible = true;
                        labGoal.Text = form_home.player[id].getFinalGoal().ToString();
                        comboPlayer.Focus();
                        txtGoal.Enabled = false;
                        btModify.Enabled = true;
                        /***
                        * 
                        *判断是否能打印成绩表
                        * 
                        ***/
                        int i;
                        for (i = 0; i < form_home.inputNumPlayer(); i++)
                            if (form_home.player[i].getFinalGoal() == 0)
                                break;
                        if (i == form_home.inputNumPlayer())//判断是否所有成员有成绩
                            bt_list.Enabled = true;
                        return;
                    }
                    txtGoal.Text = "";
                 } 
                 else
                 {
                        form_home.player[id].resetGoal(comboRater.SelectedIndex, Convert.ToDouble(txtGoal.Text));
                        form_home.player[id].getGoal(form_home.player[id].showGoal());
                        txtGoal.Enabled = false;
                        btModify.Text = "修改";
                        labMaxGoal.Text = form_home.player[id].getMaxGoal().ToString();
                        labMinGoal.Text = form_home.player[id].getMinGoal().ToString();
                        labGoal.Text = form_home.player[id].getFinalGoal().ToString();
                 }
            }
         }

        private void comboRater_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id=comboPlayer.SelectedIndex;//获取第几位选手
            Form_home form_home = (Form_home)this.Owner;
            if (form_home.player[id].getFinalGoal() > 0)
                txtGoal.Text = form_home.player[id].outputGoal(comboRater.SelectedIndex).ToString();
            else
            {
                btModify.Enabled = false;
                txtGoal.Enabled = true;
                txtGoal.Text = "";
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            if (btModify.Text == "修改")
            {
                btModify.Text = "保存";
                txtGoal.Text = "";
                txtGoal.Enabled = true;     
            }
            else {
                int id = comboPlayer.SelectedIndex;//获取第几位选手
                Form_home form_home = (Form_home)this.Owner;
                form_home.player[id].resetGoal(comboRater.SelectedIndex, Convert.ToDouble(txtGoal.Text));
                form_home.player[id].getGoal(form_home.player[id].showGoal());
                txtGoal.Enabled = false;
                btModify.Text = "修改";
                labMaxGoal.Text = form_home.player[id].getMaxGoal().ToString();
                labMinGoal.Text = form_home.player[id].getMinGoal().ToString();
                labGoal.Text = form_home.player[id].getFinalGoal().ToString();
            }

        }
        private void comboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboRater.SelectedIndex = 0; //默认选择第一条
            int id = comboPlayer.SelectedIndex;//获取第几位选手
            int rater_id = comboRater.SelectedIndex;//获取第几位评委
            Form_home form_home = (Form_home)this.Owner;
            if (form_home.player[id].getFinalGoal() > 0)
            {
                txtGoal.Enabled = false;
                txtGoal.Text = form_home.player[id].outputGoal(comboRater.SelectedIndex).ToString();
                labMaxGoal.Text = form_home.player[id].getMaxGoal().ToString();
                labMinGoal.Text = form_home.player[id].getMinGoal().ToString();
            }
            else
            {
                btModify.Enabled = false;
                txtGoal.Enabled = true;
                txtGoal.Text = "";
                labMaxGoal.Text = "";
                labMinGoal.Text = "";
                labGoal.Text = "";
            }
        }

        private void bt_list_Click(object sender, EventArgs e)
        {
            Form_home form_home = (Form_home)this.Owner;
            Form_show form_show = new Form_show();
            form_show.ShowDialog(form_home);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
