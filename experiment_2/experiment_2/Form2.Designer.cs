namespace experiment_2
{
    partial class Form_init
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumRater = new System.Windows.Forms.TextBox();
            this.txtNumPlayer = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "评委数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选手数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "选手编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "姓名";
            // 
            // txtNumRater
            // 
            this.txtNumRater.Location = new System.Drawing.Point(85, 49);
            this.txtNumRater.Name = "txtNumRater";
            this.txtNumRater.Size = new System.Drawing.Size(93, 21);
            this.txtNumRater.TabIndex = 4;
            this.txtNumRater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumRater_KeyDown);
            // 
            // txtNumPlayer
            // 
            this.txtNumPlayer.Location = new System.Drawing.Point(255, 49);
            this.txtNumPlayer.Name = "txtNumPlayer";
            this.txtNumPlayer.Size = new System.Drawing.Size(93, 21);
            this.txtNumPlayer.TabIndex = 5;
            this.txtNumPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumPlayer_KeyDown);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(85, 117);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 21);
            this.txtId.TabIndex = 6;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(255, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 21);
            this.txtName.TabIndex = 7;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(255, 161);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(51, 21);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "录入";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(171, 161);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(51, 21);
            this.btQuit.TabIndex = 9;
            this.btQuit.Text = "退出";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(85, 161);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(51, 21);
            this.btSearch.TabIndex = 10;
            this.btSearch.Text = "查看";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Form_init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 206);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNumPlayer);
            this.Controls.Add(this.txtNumRater);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统初始化";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumRater;
        private System.Windows.Forms.TextBox txtNumPlayer;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btSearch;
    }
}