namespace experiment_4
{
    partial class Form2
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
            this.tbFind = new System.Windows.Forms.TextBox();
            this.labfind = new System.Windows.Forms.Label();
            this.labreplace = new System.Windows.Forms.Label();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btNext = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.btReplaceall = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(75, 29);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(136, 21);
            this.tbFind.TabIndex = 0;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            this.tbFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyDown);
            // 
            // labfind
            // 
            this.labfind.AutoSize = true;
            this.labfind.Location = new System.Drawing.Point(28, 32);
            this.labfind.Name = "labfind";
            this.labfind.Size = new System.Drawing.Size(29, 12);
            this.labfind.TabIndex = 1;
            this.labfind.Text = "查找";
            // 
            // labreplace
            // 
            this.labreplace.AutoSize = true;
            this.labreplace.Location = new System.Drawing.Point(28, 71);
            this.labreplace.Name = "labreplace";
            this.labreplace.Size = new System.Drawing.Size(29, 12);
            this.labreplace.TabIndex = 2;
            this.labreplace.Text = "替换";
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(75, 68);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(136, 21);
            this.tbReplace.TabIndex = 3;
            this.tbReplace.TextChanged += new System.EventHandler(this.tbReplace_TextChanged);
            // 
            // btNext
            // 
            this.btNext.Enabled = false;
            this.btNext.Location = new System.Drawing.Point(239, 12);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 4;
            this.btNext.Text = "下一个";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btReplace
            // 
            this.btReplace.Enabled = false;
            this.btReplace.Location = new System.Drawing.Point(239, 41);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(75, 23);
            this.btReplace.TabIndex = 5;
            this.btReplace.Text = "替换";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btReplaceall
            // 
            this.btReplaceall.Enabled = false;
            this.btReplaceall.Location = new System.Drawing.Point(239, 70);
            this.btReplaceall.Name = "btReplaceall";
            this.btReplaceall.Size = new System.Drawing.Size(75, 23);
            this.btReplaceall.TabIndex = 6;
            this.btReplaceall.Text = "替换全部";
            this.btReplaceall.UseVisualStyleBackColor = true;
            this.btReplaceall.Click += new System.EventHandler(this.btReplaceall_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(239, 99);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 131);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReplaceall);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.labreplace);
            this.Controls.Add(this.labfind);
            this.Controls.Add(this.tbFind);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label labfind;
        private System.Windows.Forms.Label labreplace;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btReplaceall;
        private System.Windows.Forms.Button btCancel;
    }
}