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
    public partial class Form_init : Form
    {
        public Form_init()
        {
            InitializeComponent();
        }
        private void txtNumRater_KeyDown(object sender, KeyEventArgs e)//按下回车或者按下TAB自动切换到下一个文本框
        {
            Keys k= e.KeyCode;
            if (k == Keys.Tab || k == Keys.Enter)
            {
                txtNumPlayer.Focus();
                if(k == Keys.Enter)
                {
                    try{//捕获输入数字字符外的异常
                    Form_home form_home = (Form_home)this.Owner;
                        if (Convert.ToInt32(txtNumRater.Text) > 2)
                            form_home.getNumRater(Convert.ToInt32(txtNumRater.Text));
                        else
                        {
                            DialogResult resulet = MessageBox.Show(this, "评委数至少三人");  //保持评委人数至少三个;
                            txtNumRater.Text = "";
                            txtNumRater.Focus();
                        }
                    }
                    catch(Exception){
                        DialogResult resulet = MessageBox.Show(this, "请输入正确数字");
                        txtNumRater.Text = "";
                        txtNumRater.Focus();
                    }
                }
            }
        }

        private void txtNumPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode;
            if (k == Keys.Tab || k == Keys.Enter)
            {
                txtId.Focus();
                try
                {
                    if (k == Keys.Enter)
                    {
                        Form_home form_home = (Form_home)this.Owner;
                        form_home.getNumPlayer(Convert.ToInt32(txtNumPlayer.Text));
                        form_home.player = new Players[Convert.ToInt32(txtNumPlayer.Text)];
                        form_home.flag = true;
                        txtId.Enabled = true;
                        txtName.Enabled = true;
                        txtId.Focus();
                    }
                }
                catch (Exception)
                {
                    DialogResult resulet = MessageBox.Show(this, "请输入正确数字");
                    txtNumPlayer.Text = "";
                    txtNumPlayer.Focus();
                }
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode;
            if (k == Keys.Tab || k == Keys.Enter)
                txtName.Focus(); 
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode;
            if (k == Keys.Enter)
            {
                Form_home form_home = (Form_home)this.Owner;
                int i;
                for (i = 0; i < form_home.total; i++)
                    if (form_home.player[i].getId() == txtId.Text)
                    {
                        DialogResult resulet = MessageBox.Show(this, "不能输入重复的编号");  //保持主键唯一
                        txtName.Text = "";
                        txtId.Text = "";
                        txtId.Focus();
                        break;
                    }
                    if (i == form_home.total)
                    {
                        Players p = new Players(txtName.Text, txtId.Text);
                        form_home.getPlayer(p);
                        if (form_home.total >= Convert.ToInt32(txtNumPlayer.Text))
                        {
                            btSave.Enabled = false;
                            txtName.Enabled = false;
                            txtId.Enabled = false;
                            btSearch.Focus();
                        }
                        txtName.Text = "";
                        txtId.Text = "";
                        txtId.Focus();
                    }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtId.Text == "")
            {
                DialogResult resulet = MessageBox.Show(this, "请输入完整信息");//保证录入数据的完整性
                return;
            }
            Form_home form_home = (Form_home)this.Owner;
            int i;
            for (i = 0; i < form_home.total; i++)
                if (form_home.player[i].getId() == txtId.Text)
                {
                    DialogResult resulet = MessageBox.Show(this, "不能输入重复的编号");  //保持主键唯一
                    txtName.Text = "";
                    txtId.Text = "";
                    txtId.Focus();
                    break;
                }
            if (i == form_home.total)
            {
                Players p = new Players(txtName.Text, txtId.Text);
                form_home.getPlayer(p);
                if (form_home.total >= Convert.ToInt32(txtNumPlayer.Text))
                {
                    btSave.Enabled = false;
                    txtName.Enabled = false;
                    txtId.Enabled = false;
                    btSearch.Focus();
                }
                txtName.Text = "";
                txtId.Text = "";
                txtId.Focus();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Form_home form_home = (Form_home)this.Owner;
            Form_search form_search = new Form_search();
            form_search.ShowDialog(form_home);
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_home form_home = (Form_home)this.Owner;
            if(form_home.flag)
                form_home.getBtWork.Enabled = true;
            form_home.Show();
        }



    }
}
