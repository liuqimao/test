using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Form2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Mainwindow_Load(object sender,EventArgs e)
        {
            textBox.Text = DateTime.Now.ToString();
        }
        bool b = false;//

        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBox.Text = DateTime.Now.ToString();//timer每一秒运行一次更新一次值
            if (b == false)//证明时间没到,进行一次时间判断,时间到了就不要进行判断
            {
                if (h == DateTime.Now.Hour)
                {
                    if (m == DateTime.Now.Minute)
                    {
                        b = true;//证明时间刚好到了
                        //SoundPlayer sound = new SoundPlayer();
                        //sound.SoundLocation = "../../shengpizi.wav";
                        //sound.Play();
                    }
                }
            }
        }
        int h, m;
        private void Button_Click(object sender, EventArgs e)
        {
            b = false;
            //获取设置的闹钟时间的小时数和分钟数
            h = int.Parse(textBox1.Text);
            m = int.Parse(textBox2.Text);
        }


        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
