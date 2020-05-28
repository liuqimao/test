namespace notepad
{
    partial class FormChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripLabelMake = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripComboBoxFont,
            this.toolStripComboBoxSize,
            this.toolStripLabelMake});
            this.toolStrip.Location = new System.Drawing.Point(3, 3);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1188, 65);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(121, 65);
            this.toolStripComboBoxFont.Text = "字体";
            this.toolStripComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFont_SelectedIndexChanged);
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(121, 65);
            this.toolStripComboBoxSize.Text = "10";
            this.toolStripComboBoxSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSize_SelectedIndexChanged);
            this.toolStripComboBoxSize.TextChanged += new System.EventHandler(this.toolStripComboBoxSize_TextChanged);
            // 
            // textBoxNote
            // 
            this.textBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNote.Location = new System.Drawing.Point(3, 68);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNote.Size = new System.Drawing.Size(1188, 793);
            this.textBoxNote.TabIndex = 1;
            this.textBoxNote.TextChanged += new System.EventHandler(this.textBoxNote_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripLabelMake
            // 
            this.toolStripLabelMake.Name = "toolStripLabelMake";
            this.toolStripLabelMake.Size = new System.Drawing.Size(179, 60);
            this.toolStripLabelMake.Text = "toolStripLabelMake";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = global::notepad.Properties.Resources.page_white_add;
            this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(50, 60);
            this.toolStripButtonNew.Text = "新建";
            this.toolStripButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButtonOpen.Image = global::notepad.Properties.Resources.folder_vertical_open;
            this.toolStripButtonOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(50, 60);
            this.toolStripButtonOpen.Text = "打开";
            this.toolStripButtonOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButtonSave.Image = global::notepad.Properties.Resources.disk1;
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(50, 60);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButtonBold.Image = global::notepad.Properties.Resources.text_bold;
            this.toolStripButtonBold.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(50, 60);
            this.toolStripButtonBold.Text = "加粗";
            this.toolStripButtonBold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButtonItalic.Image = global::notepad.Properties.Resources.text_italic;
            this.toolStripButtonItalic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(50, 60);
            this.toolStripButtonItalic.Text = "倾斜";
            this.toolStripButtonItalic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1194, 864);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormChild";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "记事本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChild_FormClosing);
            this.Load += new System.EventHandler(this.FormChild_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSize;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMake;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
    }
}