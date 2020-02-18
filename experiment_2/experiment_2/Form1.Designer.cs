namespace experiment_2
{
    partial class Form_home
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
            this.label1 = new System.Windows.Forms.Label();
            this.btInit = new System.Windows.Forms.Button();
            this.btWork = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用程小疯的评分计分系统";
            // 
            // btInit
            // 
            this.btInit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInit.Location = new System.Drawing.Point(62, 146);
            this.btInit.Name = "btInit";
            this.btInit.Size = new System.Drawing.Size(105, 37);
            this.btInit.TabIndex = 1;
            this.btInit.Text = "系统初始化";
            this.btInit.UseVisualStyleBackColor = true;
            this.btInit.Click += new System.EventHandler(this.btInit_Click);
            // 
            // btWork
            // 
            this.btWork.Enabled = false;
            this.btWork.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btWork.Location = new System.Drawing.Point(211, 146);
            this.btWork.Name = "btWork";
            this.btWork.Size = new System.Drawing.Size(105, 37);
            this.btWork.TabIndex = 2;
            this.btWork.Text = "计分及评分";
            this.btWork.UseVisualStyleBackColor = true;
            this.btWork.Click += new System.EventHandler(this.btWork_Click);
            // 
            // btHelp
            // 
            this.btHelp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btHelp.Location = new System.Drawing.Point(62, 209);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(105, 37);
            this.btHelp.TabIndex = 3;
            this.btHelp.Text = "帮助";
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuit.Location = new System.Drawing.Point(211, 209);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(105, 37);
            this.btQuit.TabIndex = 4;
            this.btQuit.Text = "退出";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 278);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.btWork);
            this.Controls.Add(this.btInit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "程虎威的歌曲大奖赛评分计分系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInit;
        private System.Windows.Forms.Button btWork;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btQuit;
    }
}

