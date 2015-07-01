namespace WSV.User
{
    partial class RePwd
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.Lb_OldPwd = new System.Windows.Forms.Label();
            this.Tb_OldPwd = new WSV.Control.TextBox.TextBox();
            this.Lb_Pwd = new System.Windows.Forms.Label();
            this.Tb_Pwd = new WSV.Control.TextBox.TextBox();
            this.Lb_CheckPwd = new System.Windows.Forms.Label();
            this.Tb_CheckPwd = new WSV.Control.TextBox.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Save,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(253, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::WSV.Properties.Resources.Btn_Save;
            this.Btn_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(58, 29);
            this.Btn_Save.Text = "保存";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Fresh
            // 
            this.Btn_Fresh.Image = global::WSV.Properties.Resources.Btn_Fresh;
            this.Btn_Fresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Fresh.Name = "Btn_Fresh";
            this.Btn_Fresh.Size = new System.Drawing.Size(58, 29);
            this.Btn_Fresh.Text = "刷新";
            this.Btn_Fresh.Click += new System.EventHandler(this.Btn_Fresh_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Image = global::WSV.Properties.Resources.Btn_Close;
            this.Btn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(58, 29);
            this.Btn_Exit.Text = "退出";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lb_OldPwd
            // 
            this.Lb_OldPwd.AutoSize = true;
            this.Lb_OldPwd.Location = new System.Drawing.Point(40, 53);
            this.Lb_OldPwd.Name = "Lb_OldPwd";
            this.Lb_OldPwd.Size = new System.Drawing.Size(65, 12);
            this.Lb_OldPwd.TabIndex = 0;
            this.Lb_OldPwd.Text = "原始密码：";
            // 
            // Tb_OldPwd
            // 
            this.Tb_OldPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_OldPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_OldPwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_OldPwd.Location = new System.Drawing.Point(108, 48);
            this.Tb_OldPwd.Name = "Tb_OldPwd";
            this.Tb_OldPwd.Size = new System.Drawing.Size(100, 23);
            this.Tb_OldPwd.TabIndex = 1;
            this.Tb_OldPwd.TableFlag = true;
            this.Tb_OldPwd.Tag = "";
            this.Tb_OldPwd.Upper = false;
            this.Tb_OldPwd.UseSystemPasswordChar = true;
            // 
            // Lb_Pwd
            // 
            this.Lb_Pwd.AutoSize = true;
            this.Lb_Pwd.Location = new System.Drawing.Point(40, 92);
            this.Lb_Pwd.Name = "Lb_Pwd";
            this.Lb_Pwd.Size = new System.Drawing.Size(65, 12);
            this.Lb_Pwd.TabIndex = 0;
            this.Lb_Pwd.Text = "修改密码：";
            // 
            // Tb_Pwd
            // 
            this.Tb_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Pwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Pwd.Location = new System.Drawing.Point(108, 87);
            this.Tb_Pwd.Name = "Tb_Pwd";
            this.Tb_Pwd.Size = new System.Drawing.Size(100, 23);
            this.Tb_Pwd.TabIndex = 2;
            this.Tb_Pwd.TableFlag = true;
            this.Tb_Pwd.Tag = "";
            this.Tb_Pwd.Upper = false;
            this.Tb_Pwd.UseSystemPasswordChar = true;
            // 
            // Lb_CheckPwd
            // 
            this.Lb_CheckPwd.AutoSize = true;
            this.Lb_CheckPwd.Location = new System.Drawing.Point(40, 130);
            this.Lb_CheckPwd.Name = "Lb_CheckPwd";
            this.Lb_CheckPwd.Size = new System.Drawing.Size(65, 12);
            this.Lb_CheckPwd.TabIndex = 0;
            this.Lb_CheckPwd.Text = "确认密码：";
            // 
            // Tb_CheckPwd
            // 
            this.Tb_CheckPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_CheckPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_CheckPwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_CheckPwd.Location = new System.Drawing.Point(108, 125);
            this.Tb_CheckPwd.Name = "Tb_CheckPwd";
            this.Tb_CheckPwd.Size = new System.Drawing.Size(100, 23);
            this.Tb_CheckPwd.TabIndex = 3;
            this.Tb_CheckPwd.TableFlag = true;
            this.Tb_CheckPwd.Tag = "";
            this.Tb_CheckPwd.Upper = false;
            this.Tb_CheckPwd.UseSystemPasswordChar = true;
            // 
            // RePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 165);
            this.Controls.Add(this.Lb_CheckPwd);
            this.Controls.Add(this.Tb_CheckPwd);
            this.Controls.Add(this.Lb_Pwd);
            this.Controls.Add(this.Tb_Pwd);
            this.Controls.Add(this.Lb_OldPwd);
            this.Controls.Add(this.Tb_OldPwd);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RePwd";
            this.Text = "修改密码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RePwd_FormClosed);
            this.Load += new System.EventHandler(this.RePwd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.Label Lb_OldPwd;
        private WSV.Control.TextBox.TextBox Tb_OldPwd;
        private System.Windows.Forms.Label Lb_Pwd;
        private WSV.Control.TextBox.TextBox Tb_Pwd;
        private System.Windows.Forms.Label Lb_CheckPwd;
        private WSV.Control.TextBox.TextBox Tb_CheckPwd;
    }
}