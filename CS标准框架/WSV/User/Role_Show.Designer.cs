namespace WSV.User
{
    partial class Role_Show
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Tb_Name = new WSV.Control.TextBox.TextBox();
            this.Lab_Parent = new System.Windows.Forms.Label();
            this.Tb_Parent = new WSV.Control.TextBox.TextBox();
            this.Lab_Code = new System.Windows.Forms.Label();
            this.Tb_Code = new WSV.Control.TextBox.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tv_Power = new WSV.Control.MyTreeView.MyTreeView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(492, 32);
            this.toolStrip1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lab_Name);
            this.groupBox1.Controls.Add(this.Tb_Name);
            this.groupBox1.Controls.Add(this.Lab_Parent);
            this.groupBox1.Controls.Add(this.Tb_Parent);
            this.groupBox1.Controls.Add(this.Lab_Code);
            this.groupBox1.Controls.Add(this.Tb_Code);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Location = new System.Drawing.Point(311, 32);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(41, 12);
            this.Lab_Name.TabIndex = 5;
            this.Lab_Name.Text = "名称：";
            // 
            // Tb_Name
            // 
            this.Tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tb_Name.Location = new System.Drawing.Point(355, 28);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(98, 23);
            this.Tb_Name.TabIndex = 3;
            this.Tb_Name.TableFlag = true;
            this.Tb_Name.Tag = "";
            this.Tb_Name.Upper = false;
            // 
            // Lab_Parent
            // 
            this.Lab_Parent.AutoSize = true;
            this.Lab_Parent.Location = new System.Drawing.Point(10, 33);
            this.Lab_Parent.Name = "Lab_Parent";
            this.Lab_Parent.Size = new System.Drawing.Size(41, 12);
            this.Lab_Parent.TabIndex = 3;
            this.Lab_Parent.Text = "父类：";
            // 
            // Tb_Parent
            // 
            this.Tb_Parent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Parent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Parent.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Parent.Location = new System.Drawing.Point(54, 29);
            this.Tb_Parent.Name = "Tb_Parent";
            this.Tb_Parent.ReadOnly = true;
            this.Tb_Parent.Size = new System.Drawing.Size(100, 23);
            this.Tb_Parent.TabIndex = 1;
            this.Tb_Parent.TableFlag = true;
            this.Tb_Parent.Tag = "";
            this.Tb_Parent.Upper = false;
            // 
            // Lab_Code
            // 
            this.Lab_Code.AutoSize = true;
            this.Lab_Code.Location = new System.Drawing.Point(162, 32);
            this.Lab_Code.Name = "Lab_Code";
            this.Lab_Code.Size = new System.Drawing.Size(41, 12);
            this.Lab_Code.TabIndex = 0;
            this.Lab_Code.Text = "编号：";
            // 
            // Tb_Code
            // 
            this.Tb_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Code.Location = new System.Drawing.Point(206, 28);
            this.Tb_Code.Name = "Tb_Code";
            this.Tb_Code.Size = new System.Drawing.Size(98, 23);
            this.Tb_Code.TabIndex = 2;
            this.Tb_Code.TableFlag = true;
            this.Tb_Code.Tag = "";
            this.Tb_Code.Upper = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tv_Power);
            this.groupBox2.Location = new System.Drawing.Point(6, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 257);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "拥有权限";
            // 
            // Tv_Power
            // 
            this.Tv_Power.Location = new System.Drawing.Point(6, 16);
            this.Tv_Power.Name = "Tv_Power";
            this.Tv_Power.SelectNodesValue = null;
            this.Tv_Power.Size = new System.Drawing.Size(468, 236);
            this.Tv_Power.TabIndex = 0;
            // 
            // Role_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Role_Show";
            this.ShowInTaskbar = false;
            this.Text = "系统角色";
            this.Load += new System.EventHandler(this.Role_Show_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lab_Parent;
        private WSV.Control.TextBox.TextBox Tb_Parent;
        private System.Windows.Forms.Label Lab_Code;
        private WSV.Control.TextBox.TextBox Tb_Code;
        private System.Windows.Forms.Label Lab_Name;
        private WSV.Control.TextBox.TextBox Tb_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private WSV.Control.MyTreeView.MyTreeView Tv_Power;
    }
}