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
    public partial class Form_home : Form
    {
        private int numRater;           //评委人数
        private int numPlayer;          //选手人数
        public Players[] player;          //选手类
        public  int total = 0;
        public bool flag;                   //判断是否初始化
        public double[] goal;           //临时分数数组
        public Form_home()
        {
            total = 0;
            numRater = 0;
            numPlayer = 0;
            flag = false;
            InitializeComponent();
        }
        public Button getBtWork
        {
            get{
                return btWork;
            }
        }
        public int inputNumRater()
        {
            return this.numRater;
        }
        public int inputNumPlayer()
        {
            return this.numPlayer;
        }
        public void getNumRater(int n)
        {
            this.numRater = n;
        }
        public void getNumPlayer(int n)
        {
            this.numPlayer  = n;
        }
        public void getPlayer(Players p)
        {
            this.player[total++] = p;
        }

        private void btInit_Click(object sender, EventArgs e)
        {
            Form_init form_init = new Form_init();
            this.Hide();
            form_init.ShowDialog(this);
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btWork_Click(object sender, EventArgs e)
        {
            form_work form_work = new form_work();
            goal = new double[this.inputNumRater()];
            form_work.ShowDialog(this);
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;//得到该文件目录
             path+="System Manual.docx";  //word文档路径
            System.Diagnostics.Process.Start(path); //打开此文件。
        }

    }
}
