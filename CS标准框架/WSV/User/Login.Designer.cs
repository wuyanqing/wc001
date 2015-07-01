namespace WSV.User
{
    partial class Login
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
            this.Lab_Uid = new System.Windows.Forms.Label();
            this.Lab_Pwd = new System.Windows.Forms.Label();
            this.Tb_Uid = new WSV.Control.TextBox.TextBox();
            this.Tb_Pwd = new WSV.Control.TextBox.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.lab_Mess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab_Uid
            // 
            this.Lab_Uid.AutoSize = true;
            this.Lab_Uid.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Uid.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Uid.Location = new System.Drawing.Point(212, 125);
            this.Lab_Uid.Name = "Lab_Uid";
            this.Lab_Uid.Size = new System.Drawing.Size(46, 13);
            this.Lab_Uid.TabIndex = 0;
            this.Lab_Uid.Text = "账号：";
            // 
            // Lab_Pwd
            // 
            this.Lab_Pwd.AutoSize = true;
            this.Lab_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Pwd.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Pwd.Location = new System.Drawing.Point(212, 169);
            this.Lab_Pwd.Name = "Lab_Pwd";
            this.Lab_Pwd.Size = new System.Drawing.Size(46, 13);
            this.Lab_Pwd.TabIndex = 1;
            this.Lab_Pwd.Text = "密码：";
            // 
            // Tb_Uid
            // 
            this.Tb_Uid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Uid.Enabled = false;
            this.Tb_Uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Uid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Uid.Location = new System.Drawing.Point(261, 121);
            this.Tb_Uid.Name = "Tb_Uid";
            this.Tb_Uid.Size = new System.Drawing.Size(117, 23);
            this.Tb_Uid.TabIndex = 2;
            this.Tb_Uid.TableFlag = true;
            this.Tb_Uid.Tag = "";
            this.Tb_Uid.Upper = false;
            // 
            // Tb_Pwd
            // 
            this.Tb_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Pwd.Enabled = false;
            this.Tb_Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Pwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Pwd.Location = new System.Drawing.Point(261, 165);
            this.Tb_Pwd.Name = "Tb_Pwd";
            this.Tb_Pwd.PasswordChar = '*';
            this.Tb_Pwd.Size = new System.Drawing.Size(117, 23);
            this.Tb_Pwd.TabIndex = 3;
            this.Tb_Pwd.TableFlag = false;
            this.Tb_Pwd.Tag = "";
            this.Tb_Pwd.Upper = false;
            this.Tb_Pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Pwd_KeyPress);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Login.Enabled = false;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Login.Location = new System.Drawing.Point(206, 207);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(67, 31);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "登陆";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.Enabled = false;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Location = new System.Drawing.Point(309, 207);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(69, 31);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "退出";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // lab_Mess
            // 
            this.lab_Mess.BackColor = System.Drawing.Color.Transparent;
            this.lab_Mess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_Mess.Location = new System.Drawing.Point(0, 241);
            this.lab_Mess.Name = "lab_Mess";
            this.lab_Mess.Size = new System.Drawing.Size(446, 29);
            this.lab_Mess.TabIndex = 6;
            this.lab_Mess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WSV.Properties.Resources.dl;
            this.ClientSize = new System.Drawing.Size(446, 270);
            this.Controls.Add(this.lab_Mess);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Tb_Pwd);
            this.Controls.Add(this.Tb_Uid);
            this.Controls.Add(this.Lab_Pwd);
            this.Controls.Add(this.Lab_Uid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Uid;
        private System.Windows.Forms.Label Lab_Pwd;
        private WSV.Control.TextBox.TextBox Tb_Uid;
        private WSV.Control.TextBox.TextBox Tb_Pwd;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label lab_Mess;
    }
}