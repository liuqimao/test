using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("读书被选中");
            }
            else
            {
                MessageBox.Show("读书被取消");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("旅游被选中");
            }
            else
            {
                MessageBox.Show("旅游被取消");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("电影被选中");
            }
            else
            {
                MessageBox.Show("电影被取消");
            }
        }

        //private void cLBoxAihao_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int index = cLBoxAihao.SelectedIndex;
        //    string name = cLBoxAihao.Items[index].ToString();
        //    MessageBox.Show(name);
        //}

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            //给Linkable赋值
            int len = llblLink.Text.Length;
            llblLink.Links.Add(0, len, @"http://www.baidu.com");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 

        private void llblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData.ToString();
            Process.Start("C:/Users/Administrator/AppData/Local/Google/Chrome/Application/chrome.exe", url);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            txtName1.Text = name;

        }
    }
}
