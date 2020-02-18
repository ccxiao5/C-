using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                label1.Font = new Font(radioButton1.Text, float.Parse((comboBox1.Text)), label1.Font.Style, GraphicsUnit.Pixel);
                listBox1.Items[0] = radioButton1.Text;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                label1.Font = new Font(radioButton2.Text, float.Parse((comboBox1.Text)), label1.Font.Style, GraphicsUnit.Pixel);
                listBox1.Items[0] = radioButton2.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Italic);
            else
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Italic);
            listBox1.Items[1] = label1.Font.Style;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);
            else
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Bold);
            listBox1.Items[1] = label1.Font.Style;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font= new Font(label1.Font.FontFamily,float.Parse(comboBox1.Text),label1.Font.Style);
            listBox1.Items[2] = label1.Font.Size;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Font.FontFamily);
            listBox1.Items.Add(label1.Font.Style);
            listBox1.Items.Add(label1.Font.Size);
        }
  
    }
}
