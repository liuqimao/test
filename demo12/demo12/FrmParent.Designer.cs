namespace demo12
{
    partial class FrmParent
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMymenuFile = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMymenuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMymenuFile
            // 
            this.menuStripMymenuFile.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMymenuFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMymenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemWindows,
            this.ToolStripMenuItemAbout});
            this.menuStripMymenuFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripMymenuFile.MdiWindowListItem = this.ToolStripMenuItemWindows;
            this.menuStripMymenuFile.Name = "menuStripMymenuFile";
            this.menuStripMymenuFile.Size = new System.Drawing.Size(1034, 32);
            this.menuStripMymenuFile.TabIndex = 0;
            this.menuStripMymenuFile.Text = "menuStripMymenu";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemClose,
            this.ToolStripMenuItemCloseAll,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(62, 48);
            this.ToolStripMenuItemFile.Text = "文件";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItemNew.Text = "新建";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemNew_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItemClose.Text = "关闭";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItemExit.Text = "退出";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemCloseAll
            // 
            this.ToolStripMenuItemCloseAll.Name = "ToolStripMenuItemCloseAll";
            this.ToolStripMenuItemCloseAll.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItemCloseAll.Text = "关闭全部";
            this.ToolStripMenuItemCloseAll.Click += new System.EventHandler(this.ToolStripMenuItemCloseAll_Click);
            // 
            // ToolStripMenuItemWindows
            // 
            this.ToolStripMenuItemWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3});
            this.ToolStripMenuItemWindows.Name = "ToolStripMenuItemWindows";
            this.ToolStripMenuItemWindows.Size = new System.Drawing.Size(62, 48);
            this.ToolStripMenuItemWindows.Text = "窗体";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItem1.Text = "水平排列";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItem2.Text = "垂直排列";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItem3.Text = "层叠排列";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(62, 28);
            this.ToolStripMenuItemAbout.Text = "关于";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1034, 636);
            this.Controls.Add(this.menuStripMymenuFile);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMymenuFile;
            this.Name = "FrmParent";
            this.Text = "父窗体";
            this.menuStripMymenuFile.ResumeLayout(false);
            this.menuStripMymenuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMymenuFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCloseAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWindows;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
    }
}

