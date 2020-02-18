namespace experiment_1
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
            this.labInfo = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInfo.Location = new System.Drawing.Point(84, 21);
            this.labInfo.MaximumSize = new System.Drawing.Size(150, 60);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(122, 20);
            this.labInfo.TabIndex = 0;
            this.labInfo.Text = "是否将n替换成m?";
            this.labInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(74, 73);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(61, 20);
            this.yes.TabIndex = 1;
            this.yes.Text = "是";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(183, 73);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(64, 20);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "否";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 116);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.labInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button cancel;
    }
}