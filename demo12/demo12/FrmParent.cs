using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo12
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        //新建
        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            //MDI多窗体、    SDI单窗体
            //在父窗体中打开子窗体
            
            FrmChild child = new FrmChild();//
            child.MdiParent = this;         //指定子窗体的MDI父窗体
            child.Show();                   //显示子窗体
            //child.ShowDialog();//将窗体显示对话模式，使后面的窗体失去焦点
        }

        //关闭
        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            //获取当前多窗体中，处于激活状态的子窗体
            Form frm= this.ActiveMdiChild;
            //关闭激活状态的子窗体
            frm.Close();


        }

        //退出
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemCloseAll_Click(object sender, EventArgs e)
        {
            foreach(Form frm in this.MdiChildren)//集合
            {
                //
                Form fc = this.ActiveMdiChild;
                fc.Close();

            }
        }

        //水平排列
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

        }

        //垂直排列
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        //层叠排列
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("北极企鹅","这是关于信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2,MessageBoxOptions.RightAlign);//Icon图标
        }
    }
}
