using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Text;
using System.Collections;
using System.IO;


namespace notepad
{
    public partial class FormChild : Form
    {
        public FormChild()
        {
            InitializeComponent();
        }

        //打开文档
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            //新建一个保存文件的对话框
            //创建一个筛选器\过滤器            
            openFileDialog1.Filter = ("文本文档(*.txt)|*.txt");

            //判断用户点击的是打开按钮还是取消按钮
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获取打开文档的路径
                string path = openFileDialog1.FileName;
                //通用编码UTF8
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                //读取文档中的数据流
                string text = sr.ReadToEnd();
                textBoxNote.Text = text;
                //将打开的文件路径写到当前窗体的text属性中
                this.Text = path;
                //打开文件时，清空记号标签
                toolStripLabelMake.Text = "";
                sr.Close();
            }
        }

        //窗体加载事件
        private void FormChild_Load(object sender, EventArgs e)
        {
            //窗体加载时，要加载系统字体
            InstalledFontCollection myFonts = new InstalledFontCollection();
            //获取InstalledFontCollection对象的数组
            FontFamily[] ff = myFonts.Families;
            //声明一个ArrayL变量
            ArrayList List = new ArrayList();
            //获取系统数组的列表中集合的长度
            int count = ff.Length;                
            //使用for循环吧字体名称写入到toolStripComboBoxFont 控件中
            for (int i = 0; i < count; i++)
            {
                string FontName = ff[i].Name;
                toolStripComboBoxFont.Items.Add(FontName);
            }
        }

        //加粗按钮
        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            //点击按钮加粗，加粗时再点击按钮取消加粗
            if (textBoxNote.Font.Bold == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Bold);
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);
            }
        }

        //倾斜按钮
        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Font.Italic == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Italic);
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);
            }
        }
 
        //改变选择字体的索引事件
        private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFont.Text;
            float fontSize = float.Parse(toolStripComboBoxSize.Text);
            textBoxNote.Font = new Font(fontName, fontSize);
        }

        //改变字体大小
        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFont.Text;
            float fontSize = float.Parse(toolStripComboBoxSize.Text);
            textBoxNote.Font = new Font(fontName, fontSize);
        }

        private void toolStripComboBoxSize_TextChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFont.Text;
            float fontSize = float.Parse(toolStripComboBoxSize.Text);
            textBoxNote.Font = new Font(fontName, fontSize);
        }

        //保存文档
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Text.Trim() != "")
            {
                if (this.Text == "")
                {
                    //新建一个保存文件的对话框
                    //创建一个筛选器\过滤器
                    saveFileDialog1.Filter = ("文本文档(*.txt)|*.txt");                    
                    ////判断用户点击的是保存按钮还是取消按钮
                    if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                    {
                        //保存文件到用户指定的目录位置
                        //获取用户选择的文件及路径
                        string path = saveFileDialog1.FileName;
                        //保存文件到指定路径
                        StreamWriter sw = new StreamWriter(path, false);
                        sw.WriteLine(textBoxNote.Text.Trim());
                        //把窗体text属性设置为保存后的文件路径
                        this.Text = path;
                        //释放资源
                        sw.Flush();
                        sw.Close();
                    }
                }
                else
                {
                    //保存文件到用户指定的目录位置
                    //获取用户选择的文件及路径
                    string path = this.Text;
                    //保存文件到指定路径
                    StreamWriter sw = new StreamWriter(path, false);
                    sw.WriteLine(textBoxNote.Text.Trim());
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("空白文档不能保存", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //编辑文本时
        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            toolStripLabelMake.Text = "*";
        }

        //窗体关闭事件
        private void FormChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断记号lable是否是*号
            if (toolStripLabelMake.Text == "*")
            {
                //如果是*号进入代码，提示用户尚未保存
                DialogResult dr = MessageBox.Show("文档尚未保存，确定要继续退出吗？", "信息询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //如果用户选择是 确定 按钮
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        //新建按钮（清空）
        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            textBoxNote.Text = "";
            toolStripLabelMake.Text = "";
            this.Text = "";
        }
        //

    }
}
