namespace WSV.User
{
    partial class SysLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysLock));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_NoLock = new System.Windows.Forms.Button();
            this.lab_Mess = new System.Windows.Forms.Label();
            this.txt_Pwd = new WSV.Control.TextBox.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSV.Properties.Resources.SysLock;
            this.pictureBox1.Location = new System.Drawing.Point(8, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // but_NoLock
            // 
            this.but_NoLock.Location = new System.Drawing.Point(270, 32);
            this.but_NoLock.Name = "but_NoLock";
            this.but_NoLock.Size = new System.Drawing.Size(50, 25);
            this.but_NoLock.TabIndex = 1;
            this.but_NoLock.Text = "解锁";
            this.but_NoLock.UseVisualStyleBackColor = true;
            this.but_NoLock.Click += new System.EventHandler(this.but_NoLock_Click);
            // 
            // lab_Mess
            // 
            this.lab_Mess.AutoSize = true;
            this.lab_Mess.Location = new System.Drawing.Point(75, 37);
            this.lab_Mess.Name = "lab_Mess";
            this.lab_Mess.Size = new System.Drawing.Size(59, 12);
            this.lab_Mess.TabIndex = 2;
            this.lab_Mess.Text = "输入密码:";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Pwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_Pwd.Location = new System.Drawing.Point(138, 32);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(126, 23);
            this.txt_Pwd.TabIndex = 0;
            this.txt_Pwd.TableFlag = false;
            this.txt_Pwd.Tag = "";
            this.txt_Pwd.Upper = false;
            this.txt_Pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pwd_KeyPress);
            // 
            // SysLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 88);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.lab_Mess);
            this.Controls.Add(this.but_NoLock);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysLock";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "解除锁定";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_NoLock;
        private System.Windows.Forms.Label lab_Mess;
        private WSV.Control.TextBox.TextBox txt_Pwd;
    }
}