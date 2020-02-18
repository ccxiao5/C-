namespace experiment_4
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑 = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切 = new System.Windows.Forms.ToolStripMenuItem();
            this.复制 = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴 = new System.Windows.Forms.ToolStripMenuItem();
            this.查找 = new System.Windows.Forms.ToolStripMenuItem();
            this.replace = new System.Windows.Forms.ToolStripMenuItem();
            this.next = new System.Windows.Forms.ToolStripMenuItem();
            this.格式 = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行 = new System.Windows.Forms.ToolStripMenuItem();
            this.字体 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看 = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cut = new System.Windows.Forms.ToolStripButton();
            this.copy = new System.Windows.Forms.ToolStripButton();
            this.paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.font = new System.Windows.Forms.ToolStripLabel();
            this.bold = new System.Windows.Forms.ToolStripButton();
            this.Italy = new System.Windows.Forms.ToolStripButton();
            this.underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑,
            this.格式,
            this.查看,
            this.帮助});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建,
            this.打开,
            this.保存,
            this.退出});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建
            // 
            this.新建.Name = "新建";
            this.新建.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建.Size = new System.Drawing.Size(152, 22);
            this.新建.Text = "新建";
            // 
            // 打开
            // 
            this.打开.Name = "打开";
            this.打开.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开.Size = new System.Drawing.Size(152, 22);
            this.打开.Text = "打开";
            this.打开.Click += new System.EventHandler(this.打开_Click);
            // 
            // 保存
            // 
            this.保存.Name = "保存";
            this.保存.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存.Size = new System.Drawing.Size(152, 22);
            this.保存.Text = "保存";
            this.保存.Click += new System.EventHandler(this.保存_Click);
            // 
            // 退出
            // 
            this.退出.Name = "退出";
            this.退出.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.退出.ShowShortcutKeys = false;
            this.退出.Size = new System.Drawing.Size(152, 22);
            this.退出.Text = "退出(X)";
            this.退出.Click += new System.EventHandler(this.退出_Click);
            // 
            // 编辑
            // 
            this.编辑.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切,
            this.复制,
            this.粘贴,
            this.查找,
            this.replace,
            this.next});
            this.编辑.Name = "编辑";
            this.编辑.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.编辑.Size = new System.Drawing.Size(59, 21);
            this.编辑.Text = "编辑(&E)";
            // 
            // 剪切
            // 
            this.剪切.Name = "剪切";
            this.剪切.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切.Size = new System.Drawing.Size(157, 22);
            this.剪切.Text = "剪切";
            this.剪切.Click += new System.EventHandler(this.剪切_Click);
            // 
            // 复制
            // 
            this.复制.Name = "复制";
            this.复制.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制.Size = new System.Drawing.Size(157, 22);
            this.复制.Text = "复制";
            this.复制.Click += new System.EventHandler(this.复制_Click);
            // 
            // 粘贴
            // 
            this.粘贴.Name = "粘贴";
            this.粘贴.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴.Size = new System.Drawing.Size(157, 22);
            this.粘贴.Text = "粘贴";
            this.粘贴.Click += new System.EventHandler(this.粘贴_Click);
            // 
            // 查找
            // 
            this.查找.Name = "查找";
            this.查找.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.查找.Size = new System.Drawing.Size(157, 22);
            this.查找.Text = "查找";
            this.查找.Click += new System.EventHandler(this.查找_Click);
            // 
            // replace
            // 
            this.replace.Name = "replace";
            this.replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replace.Size = new System.Drawing.Size(157, 22);
            this.replace.Text = "替换";
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // next
            // 
            this.next.Name = "next";
            this.next.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.next.Size = new System.Drawing.Size(157, 22);
            this.next.Text = "查找下一个";
            this.next.Click += new System.EventHandler(this.查找下一个_Click);
            // 
            // 格式
            // 
            this.格式.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行,
            this.字体});
            this.格式.Name = "格式";
            this.格式.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.格式.Size = new System.Drawing.Size(62, 21);
            this.格式.Text = "格式(&O)";
            // 
            // 自动换行
            // 
            this.自动换行.Checked = true;
            this.自动换行.CheckState = System.Windows.Forms.CheckState.Checked;
            this.自动换行.Name = "自动换行";
            this.自动换行.Size = new System.Drawing.Size(167, 22);
            this.自动换行.Text = "自动换行";
            // 
            // 字体
            // 
            this.字体.Name = "字体";
            this.字体.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.F)));
            this.字体.Size = new System.Drawing.Size(167, 22);
            this.字体.Text = "字体";
            this.字体.Click += new System.EventHandler(this.字体_Click);
            // 
            // 查看
            // 
            this.查看.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏ToolStripMenuItem});
            this.查看.Name = "查看";
            this.查看.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.查看.Size = new System.Drawing.Size(60, 21);
            this.查看.Text = "查看(&V)";
            // 
            // 状态栏ToolStripMenuItem
            // 
            this.状态栏ToolStripMenuItem.Name = "状态栏ToolStripMenuItem";
            this.状态栏ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.状态栏ToolStripMenuItem.Text = "状态栏";
            // 
            // 帮助
            // 
            this.帮助.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem});
            this.帮助.Name = "帮助";
            this.帮助.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.帮助.Size = new System.Drawing.Size(61, 21);
            this.帮助.Text = "帮助(&H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(0, 53);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(526, 280);
            this.rTextBox.TabIndex = 1;
            this.rTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.save,
            this.toolStripSeparator1,
            this.cut,
            this.copy,
            this.paste,
            this.toolStripSeparator2,
            this.font,
            this.bold,
            this.Italy,
            this.underline,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(526, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // open
            // 
            this.open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(23, 22);
            this.open.Text = "toolStripButton1";
            this.open.ToolTipText = "打开";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 22);
            this.save.Text = "toolStripButton2";
            this.save.ToolTipText = "保存";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cut
            // 
            this.cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cut.Image = ((System.Drawing.Image)(resources.GetObject("cut.Image")));
            this.cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(23, 22);
            this.cut.Text = "toolStripButton3";
            this.cut.ToolTipText = "剪切";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy.Image = ((System.Drawing.Image)(resources.GetObject("copy.Image")));
            this.copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(23, 22);
            this.copy.Text = "toolStripButton4";
            this.copy.ToolTipText = "复制";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paste.Image = ((System.Drawing.Image)(resources.GetObject("paste.Image")));
            this.paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(23, 22);
            this.paste.Text = "toolStripButton5";
            this.paste.ToolTipText = "粘贴";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(16, 22);
            this.font.Text = "A";
            this.font.ToolTipText = "字体";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // bold
            // 
            this.bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(23, 22);
            this.bold.Text = "toolStripButton6";
            this.bold.ToolTipText = "加粗";
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // Italy
            // 
            this.Italy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italy.Image = ((System.Drawing.Image)(resources.GetObject("Italy.Image")));
            this.Italy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italy.Name = "Italy";
            this.Italy.Size = new System.Drawing.Size(23, 22);
            this.Italy.Text = "toolStripButton7";
            this.Italy.ToolTipText = "斜体";
            this.Italy.Click += new System.EventHandler(this.Italy_Click);
            // 
            // underline
            // 
            this.underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underline.Image = ((System.Drawing.Image)(resources.GetObject("underline.Image")));
            this.underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(23, 22);
            this.underline.Text = "toolStripButton8";
            this.underline.ToolTipText = "下划线";
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "颜色";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 333);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本编辑器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建;
        private System.Windows.Forms.ToolStripMenuItem 打开;
        private System.Windows.Forms.ToolStripMenuItem 保存;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private System.Windows.Forms.ToolStripMenuItem 编辑;
        private System.Windows.Forms.ToolStripMenuItem 剪切;
        private System.Windows.Forms.ToolStripMenuItem 复制;
        private System.Windows.Forms.ToolStripMenuItem 粘贴;
        private System.Windows.Forms.ToolStripMenuItem 查找;
        private System.Windows.Forms.ToolStripMenuItem replace;
        private System.Windows.Forms.ToolStripMenuItem 格式;
        private System.Windows.Forms.ToolStripMenuItem 自动换行;
        private System.Windows.Forms.ToolStripMenuItem 字体;
        private System.Windows.Forms.ToolStripMenuItem 查看;
        private System.Windows.Forms.ToolStripMenuItem 状态栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem next;
        private System.Windows.Forms.RichTextBox rTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton open;
        private System.Windows.Forms.ToolStripButton save;
        private System.Windows.Forms.ToolStripButton cut;
        private System.Windows.Forms.ToolStripButton copy;
        private System.Windows.Forms.ToolStripButton paste;
        private System.Windows.Forms.ToolStripButton bold;
        private System.Windows.Forms.ToolStripButton Italy;
        private System.Windows.Forms.ToolStripButton underline;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripLabel font;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}

