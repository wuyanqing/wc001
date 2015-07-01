namespace WSV.SysInfo
{
    partial class BackUp
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
            this.Btn_Backup = new System.Windows.Forms.Button();
            this.Btn_Resume = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Backup
            // 
            this.Btn_Backup.Location = new System.Drawing.Point(116, 77);
            this.Btn_Backup.Name = "Btn_Backup";
            this.Btn_Backup.Size = new System.Drawing.Size(70, 30);
            this.Btn_Backup.TabIndex = 1;
            this.Btn_Backup.Text = "数据备份";
            this.Btn_Backup.UseVisualStyleBackColor = true;
            this.Btn_Backup.Click += new System.EventHandler(this.Btn_Backup_Click);
            // 
            // Btn_Resume
            // 
            this.Btn_Resume.Location = new System.Drawing.Point(225, 77);
            this.Btn_Resume.Name = "Btn_Resume";
            this.Btn_Resume.Size = new System.Drawing.Size(70, 30);
            this.Btn_Resume.TabIndex = 1;
            this.Btn_Resume.Text = "数据恢复";
            this.Btn_Resume.UseVisualStyleBackColor = true;
            this.Btn_Resume.Click += new System.EventHandler(this.Btn_Resume_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WSV.Properties.Resources.s;
            this.pictureBox3.Location = new System.Drawing.Point(139, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WSV.Properties.Resources.z;
            this.pictureBox2.Location = new System.Drawing.Point(84, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WSV.Properties.Resources.h;
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 119);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Resume);
            this.Controls.Add(this.Btn_Backup);
            this.Name = "BackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据备份/恢复";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Backup;
        private System.Windows.Forms.Button Btn_Resume;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}