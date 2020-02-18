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
    public partial class Form_search : Form
    {
        public Form_search()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form_home form_home = (Form_home)this.Owner;
            txtId.Text = form_home.player[0].getId();
            txtName.Text = form_home.player[0].getName();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            int i;
            Form_home form_home = (Form_home)this.Owner;
            for (i = 0; i < form_home.total; i++)
                if (txtId.Text == form_home.player[i].getId())
                    break;
            txtId.Text = form_home.player[(i + 1) % form_home.total].getId();
            txtName.Text = form_home.player[(i + 1) % form_home.total].getName();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            int i;
            Form_home form_home = (Form_home)this.Owner;
            if (btModify.Text == "修改")
            { 
                txtName.Enabled = true;
                btNext.Enabled = false;
                btModify.Text = "保存";
            }
            else if (btModify.Text == "保存")
            {
                txtName.Enabled = false;
                btModify.Text = "修改";
                for (i = 0; i < form_home.total; i++)
                    if (txtId.Text == form_home.player[i].getId())
                    {
                        form_home.player[i].setName(txtName.Text);
                        break;
                    }
                btNext.Enabled = true;
            }
        }


    }
}
