namespace experiment_2
{
    partial class form_work
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboPlayer = new System.Windows.Forms.ComboBox();
            this.labRater = new System.Windows.Forms.Label();
            this.comboRater = new System.Windows.Forms.ComboBox();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labMaxGoal = new System.Windows.Forms.Label();
            this.labMinGoal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labGoal = new System.Windows.Forms.Label();
            this.bt_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选手";
            // 
            // comboPlayer
            // 
            this.comboPlayer.FormattingEnabled = true;
            this.comboPlayer.Location = new System.Drawing.Point(94, 42);
            this.comboPlayer.Name = "comboPlayer";
            this.comboPlayer.Size = new System.Drawing.Size(116, 20);
            this.comboPlayer.TabIndex = 1;
            this.comboPlayer.SelectedIndexChanged += new System.EventHandler(this.comboPlayer_SelectedIndexChanged);
            // 
            // labRater
            // 
            this.labRater.AutoSize = true;
            this.labRater.Location = new System.Drawing.Point(34, 93);
            this.labRater.Name = "labRater";
            this.labRater.Size = new System.Drawing.Size(29, 12);
            this.labRater.TabIndex = 2;
            this.labRater.Text = "评委";
            // 
            // comboRater
            // 
            this.comboRater.FormattingEnabled = true;
            this.comboRater.Location = new System.Drawing.Point(94, 90);
            this.comboRater.Name = "comboRater";
            this.comboRater.Size = new System.Drawing.Size(116, 20);
            this.comboRater.TabIndex = 3;
            this.comboRater.SelectedIndexChanged += new System.EventHandler(this.comboRater_SelectedIndexChanged);
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(93, 137);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(117, 21);
            this.txtGoal.TabIndex = 4;
            this.txtGoal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoal_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "分数";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(144, 183);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "退出";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btModify
            // 
            this.btModify.Enabled = false;
            this.btModify.Location = new System.Drawing.Point(36, 183);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 7;
            this.btModify.Text = "修改";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "最高分：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "最低分：";
            // 
            // labMaxGoal
            // 
            this.labMaxGoal.AutoSize = true;
            this.labMaxGoal.Location = new System.Drawing.Point(287, 45);
            this.labMaxGoal.Name = "labMaxGoal";
            this.labMaxGoal.Size = new System.Drawing.Size(41, 12);
            this.labMaxGoal.TabIndex = 10;
            this.labMaxGoal.Text = "label5";
            this.labMaxGoal.Visible = false;
            // 
            // labMinGoal
            // 
            this.labMinGoal.AutoSize = true;
            this.labMinGoal.Location = new System.Drawing.Point(287, 93);
            this.labMinGoal.Name = "labMinGoal";
            this.labMinGoal.Size = new System.Drawing.Size(41, 12);
            this.labMinGoal.TabIndex = 11;
            this.labMinGoal.Text = "label6";
            this.labMinGoal.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "最终得分";
            // 
            // labGoal
            // 
            this.labGoal.AutoSize = true;
            this.labGoal.Location = new System.Drawing.Point(287, 137);
            this.labGoal.Name = "labGoal";
            this.labGoal.Size = new System.Drawing.Size(41, 12);
            this.labGoal.TabIndex = 13;
            this.labGoal.Text = "label6";
            this.labGoal.Visible = false;
            // 
            // bt_list
            // 
            this.bt_list.Enabled = false;
            this.bt_list.Location = new System.Drawing.Point(253, 183);
            this.bt_list.Name = "bt_list";
            this.bt_list.Size = new System.Drawing.Size(75, 23);
            this.bt_list.TabIndex = 15;
            this.bt_list.Text = "成绩表";
            this.bt_list.UseVisualStyleBackColor = true;
            this.bt_list.Click += new System.EventHandler(this.bt_list_Click);
            // 
            // form_work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 228);
            this.Controls.Add(this.bt_list);
            this.Controls.Add(this.labGoal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labMinGoal);
            this.Controls.Add(this.labMaxGoal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.comboRater);
            this.Controls.Add(this.labRater);
            this.Controls.Add(this.comboPlayer);
            this.Controls.Add(this.label1);
            this.Name = "form_work";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "评分";
            this.Load += new System.EventHandler(this.form_work_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPlayer;
        private System.Windows.Forms.Label labRater;
        private System.Windows.Forms.ComboBox comboRater;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labMaxGoal;
        private System.Windows.Forms.Label labMinGoal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labGoal;
        private System.Windows.Forms.Button bt_list;
    }
}