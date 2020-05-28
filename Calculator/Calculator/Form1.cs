using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        float temp1 = -1;//记录第一个数字
        int pos = 0;     //储存计算方式

        public void addNum(int num)
        {
            textBox1.Text = textBox1.Text + num.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
 
        //1
        private void button1_Click(object sender, EventArgs e)
        {
            addNum(1);
        }

        //0
        private void button0_Click(object sender, EventArgs e)
        {
            addNum(0);
        }

        //2
        private void button2_Click(object sender, EventArgs e)
        {
            addNum(2);
        }

        //3
        private void button3_Click(object sender, EventArgs e)
        {
            addNum(3);
        }

        //4
        private void button4_Click(object sender, EventArgs e)
        {
            addNum(4);
        }

        //5
        private void button5_Click(object sender, EventArgs e)
        {
            addNum(5);
        }

        //6
        private void button6_Click(object sender, EventArgs e)
        {
            addNum(6);
        }

        //7
        private void button7_Click(object sender, EventArgs e)
        {
            addNum(7);
        }

        //8
        private void button8_Click(object sender, EventArgs e)
        {
            addNum(8);
        }

        //9
        private void button9_Click(object sender, EventArgs e)
        {
            addNum(9);
        }

        //除法
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            pos = 4;//修改计算方式的标志位
            temp1 = Convert.ToInt64(textBox1.Text);//获取前一个值
            textBox1.Text = "";
        }

        //乘法
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            pos = 3;//修改计算方式的标志位
            temp1 = Convert.ToInt64(textBox1.Text);//获取前一个值
            textBox1.Text = "";
        }


        //减法
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            pos = 2;//修改计算方式的标志位
            temp1 = Convert.ToInt64(textBox1.Text);//获取前一个值
            textBox1.Text = "";
        }

        //加法
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            pos = 1;//修改计算方式的标志位
            temp1 = Convert.ToInt64(textBox1.Text);//获取前一个值
            textBox1.Text = "";
        }

        //等于
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            float temp2;
            if (textBox1.Text != "")
            {
                temp2 = Convert.ToInt64(textBox1.Text);//获取后一个数字
            }
            else
            {
                temp2 = temp1;
            }

            switch (pos)
            {
                case 1:
                    textBox1.Text = (temp1 + temp2).ToString();
                    break;
                case 2:
                    textBox1.Text = (temp1 - temp2).ToString();
                    break;
                case 3:
                    textBox1.Text = (temp1 * temp2).ToString();
                    break;
                case 4:
                    textBox1.Text = (temp1 / temp2).ToString();
                    break;
            }
        }

        //清空
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//
            temp1 = 0;
            pos = 0;
        }
    }
}
