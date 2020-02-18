namespace experiment_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFinding = new System.Windows.Forms.TextBox();
            this.txtReplacing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btReplace = new System.Windows.Forms.Button();
            this.labFinding = new System.Windows.Forms.Label();
            this.labReplacing = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPaper = new System.Windows.Forms.RichTextBox();
            this.btNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFinding
            // 
            this.txtFinding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFinding.Location = new System.Drawing.Point(123, 182);
            this.txtFinding.Multiline = true;
            this.txtFinding.Name = "txtFinding";
            this.txtFinding.Size = new System.Drawing.Size(289, 49);
            this.txtFinding.TabIndex = 1;
            this.txtFinding.TextChanged += new System.EventHandler(this.txtFinding_TextChanged);
            // 
            // txtReplacing
            // 
            this.txtReplacing.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReplacing.Location = new System.Drawing.Point(123, 269);
            this.txtReplacing.Multiline = true;
            this.txtReplacing.Name = "txtReplacing";
            this.txtReplacing.Size = new System.Drawing.Size(287, 44);
            this.txtReplacing.TabIndex = 2;
            this.txtReplacing.TextChanged += new System.EventHandler(this.txtReplacing_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "输入的文本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "要查找的内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "要替换的内容";
            // 
            // btReplace
            // 
            this.btReplace.BackColor = System.Drawing.SystemColors.Control;
            this.btReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btReplace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReplace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btReplace.Location = new System.Drawing.Point(431, 290);
            this.btReplace.Margin = new System.Windows.Forms.Padding(0);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(68, 23);
            this.btReplace.TabIndex = 6;
            this.btReplace.Text = "替换";
            this.btReplace.UseVisualStyleBackColor = false;
            this.btReplace.Click += new System.EventHandler(this.button1_Click);
            // 
            // labFinding
            // 
            this.labFinding.AutoSize = true;
            this.labFinding.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFinding.Location = new System.Drawing.Point(129, 236);
            this.labFinding.Name = "labFinding";
            this.labFinding.Size = new System.Drawing.Size(74, 20);
            this.labFinding.TabIndex = 7;
            this.labFinding.Text = "已查找n次";
            this.labFinding.Visible = false;
            // 
            // labReplacing
            // 
            this.labReplacing.AutoSize = true;
            this.labReplacing.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labReplacing.Location = new System.Drawing.Point(128, 319);
            this.labReplacing.Name = "labReplacing";
            this.labReplacing.Size = new System.Drawing.Size(78, 20);
            this.labReplacing.TabIndex = 8;
            this.labReplacing.Text = "已替换m次";
            this.labReplacing.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 290);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "退出程序";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPaper
            // 
            this.txtPaper.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPaper.HideSelection = false;
            this.txtPaper.Location = new System.Drawing.Point(123, 5);
            this.txtPaper.Name = "txtPaper";
            this.txtPaper.Size = new System.Drawing.Size(397, 171);
            this.txtPaper.TabIndex = 10;
            this.txtPaper.Text = resources.GetString("txtPaper.Text");
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.SystemColors.Control;
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btNext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNext.Location = new System.Drawing.Point(431, 198);
            this.btNext.Margin = new System.Windows.Forms.Padding(0);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(68, 23);
            this.btNext.TabIndex = 11;
            this.btNext.Text = "下一个";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(607, 359);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.txtPaper);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labReplacing);
            this.Controls.Add(this.labFinding);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReplacing);
            this.Controls.Add(this.txtFinding);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm程虎威的文本的查找与替换 ";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFinding;
        private System.Windows.Forms.TextBox txtReplacing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Label labFinding;
        private System.Windows.Forms.Label labReplacing;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtPaper;
        private System.Windows.Forms.Button btNext;
    }
}

