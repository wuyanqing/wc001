namespace WSV.SysInfo
{
    partial class BaseInfo
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
            this.Tc_BaseInfo = new System.Windows.Forms.TabControl();
            this.Tp_UserInfo = new System.Windows.Forms.TabPage();
            this.Tb_PrintTitle = new WSV.Control.TextBox.TextBox();
            this.Lb_PrintTitle = new System.Windows.Forms.Label();
            this.Tb_Tel = new WSV.Control.TextBox.TextBox();
            this.Lb_Tel = new System.Windows.Forms.Label();
            this.Tb_Address = new WSV.Control.TextBox.TextBox();
            this.Lb_Address = new System.Windows.Forms.Label();
            this.Tb_Company = new WSV.Control.TextBox.TextBox();
            this.Lb_Company = new System.Windows.Forms.Label();
            this.Tp_Design = new System.Windows.Forms.TabPage();
            this.Tb_DTel = new WSV.Control.TextBox.TextBox();
            this.Lb_DTel = new System.Windows.Forms.Label();
            this.Tb_DAddress = new WSV.Control.TextBox.TextBox();
            this.Lb_DAddress = new System.Windows.Forms.Label();
            this.Tb_DCompany = new WSV.Control.TextBox.TextBox();
            this.Lb_DCompany = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Tc_BaseInfo.SuspendLayout();
            this.Tp_UserInfo.SuspendLayout();
            this.Tp_Design.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(338, 32);
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
            // Tc_BaseInfo
            // 
            this.Tc_BaseInfo.Controls.Add(this.Tp_UserInfo);
            this.Tc_BaseInfo.Controls.Add(this.Tp_Design);
            this.Tc_BaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tc_BaseInfo.Location = new System.Drawing.Point(0, 32);
            this.Tc_BaseInfo.Name = "Tc_BaseInfo";
            this.Tc_BaseInfo.SelectedIndex = 0;
            this.Tc_BaseInfo.Size = new System.Drawing.Size(338, 200);
            this.Tc_BaseInfo.TabIndex = 1;
            // 
            // Tp_UserInfo
            // 
            this.Tp_UserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.Tp_UserInfo.Controls.Add(this.Tb_PrintTitle);
            this.Tp_UserInfo.Controls.Add(this.Lb_PrintTitle);
            this.Tp_UserInfo.Controls.Add(this.Tb_Tel);
            this.Tp_UserInfo.Controls.Add(this.Lb_Tel);
            this.Tp_UserInfo.Controls.Add(this.Tb_Address);
            this.Tp_UserInfo.Controls.Add(this.Lb_Address);
            this.Tp_UserInfo.Controls.Add(this.Tb_Company);
            this.Tp_UserInfo.Controls.Add(this.Lb_Company);
            this.Tp_UserInfo.Location = new System.Drawing.Point(4, 21);
            this.Tp_UserInfo.Name = "Tp_UserInfo";
            this.Tp_UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_UserInfo.Size = new System.Drawing.Size(330, 175);
            this.Tp_UserInfo.TabIndex = 0;
            this.Tp_UserInfo.Text = "用户信息";
            // 
            // Tb_PrintTitle
            // 
            this.Tb_PrintTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_PrintTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_PrintTitle.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_PrintTitle.Location = new System.Drawing.Point(98, 135);
            this.Tb_PrintTitle.Name = "Tb_PrintTitle";
            this.Tb_PrintTitle.Size = new System.Drawing.Size(200, 23);
            this.Tb_PrintTitle.TabIndex = 4;
            this.Tb_PrintTitle.TableFlag = true;
            this.Tb_PrintTitle.Tag = "";
            this.Tb_PrintTitle.Upper = false;
            // 
            // Lb_PrintTitle
            // 
            this.Lb_PrintTitle.AutoSize = true;
            this.Lb_PrintTitle.Location = new System.Drawing.Point(30, 140);
            this.Lb_PrintTitle.Name = "Lb_PrintTitle";
            this.Lb_PrintTitle.Size = new System.Drawing.Size(65, 12);
            this.Lb_PrintTitle.TabIndex = 0;
            this.Lb_PrintTitle.Text = "打印标题：";
            // 
            // Tb_Tel
            // 
            this.Tb_Tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Tel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Tel.Location = new System.Drawing.Point(98, 96);
            this.Tb_Tel.Name = "Tb_Tel";
            this.Tb_Tel.Size = new System.Drawing.Size(200, 23);
            this.Tb_Tel.TabIndex = 3;
            this.Tb_Tel.TableFlag = true;
            this.Tb_Tel.Tag = "";
            this.Tb_Tel.Upper = false;
            // 
            // Lb_Tel
            // 
            this.Lb_Tel.AutoSize = true;
            this.Lb_Tel.Location = new System.Drawing.Point(30, 101);
            this.Lb_Tel.Name = "Lb_Tel";
            this.Lb_Tel.Size = new System.Drawing.Size(65, 12);
            this.Lb_Tel.TabIndex = 0;
            this.Lb_Tel.Text = "联系电话：";
            // 
            // Tb_Address
            // 
            this.Tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Address.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Address.Location = new System.Drawing.Point(98, 57);
            this.Tb_Address.Name = "Tb_Address";
            this.Tb_Address.Size = new System.Drawing.Size(200, 23);
            this.Tb_Address.TabIndex = 2;
            this.Tb_Address.TableFlag = true;
            this.Tb_Address.Tag = "";
            this.Tb_Address.Upper = false;
            // 
            // Lb_Address
            // 
            this.Lb_Address.AutoSize = true;
            this.Lb_Address.Location = new System.Drawing.Point(30, 62);
            this.Lb_Address.Name = "Lb_Address";
            this.Lb_Address.Size = new System.Drawing.Size(65, 12);
            this.Lb_Address.TabIndex = 0;
            this.Lb_Address.Text = "单位地址：";
            // 
            // Tb_Company
            // 
            this.Tb_Company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Company.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Company.Location = new System.Drawing.Point(98, 19);
            this.Tb_Company.Name = "Tb_Company";
            this.Tb_Company.Size = new System.Drawing.Size(200, 23);
            this.Tb_Company.TabIndex = 1;
            this.Tb_Company.TableFlag = true;
            this.Tb_Company.Tag = "";
            this.Tb_Company.Upper = false;
            // 
            // Lb_Company
            // 
            this.Lb_Company.AutoSize = true;
            this.Lb_Company.Location = new System.Drawing.Point(30, 24);
            this.Lb_Company.Name = "Lb_Company";
            this.Lb_Company.Size = new System.Drawing.Size(65, 12);
            this.Lb_Company.TabIndex = 0;
            this.Lb_Company.Text = "单位名称：";
            // 
            // Tp_Design
            // 
            this.Tp_Design.BackColor = System.Drawing.SystemColors.Control;
            this.Tp_Design.Controls.Add(this.Tb_DTel);
            this.Tp_Design.Controls.Add(this.Lb_DTel);
            this.Tp_Design.Controls.Add(this.Tb_DAddress);
            this.Tp_Design.Controls.Add(this.Lb_DAddress);
            this.Tp_Design.Controls.Add(this.Tb_DCompany);
            this.Tp_Design.Controls.Add(this.Lb_DCompany);
            this.Tp_Design.Location = new System.Drawing.Point(4, 21);
            this.Tp_Design.Name = "Tp_Design";
            this.Tp_Design.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Design.Size = new System.Drawing.Size(330, 175);
            this.Tp_Design.TabIndex = 1;
            this.Tp_Design.Text = "设计单位";
            // 
            // Tb_DTel
            // 
            this.Tb_DTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_DTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_DTel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_DTel.Location = new System.Drawing.Point(98, 95);
            this.Tb_DTel.Name = "Tb_DTel";
            this.Tb_DTel.Size = new System.Drawing.Size(200, 23);
            this.Tb_DTel.TabIndex = 3;
            this.Tb_DTel.TableFlag = true;
            this.Tb_DTel.Tag = "";
            this.Tb_DTel.Upper = false;
            // 
            // Lb_DTel
            // 
            this.Lb_DTel.AutoSize = true;
            this.Lb_DTel.Location = new System.Drawing.Point(30, 100);
            this.Lb_DTel.Name = "Lb_DTel";
            this.Lb_DTel.Size = new System.Drawing.Size(65, 12);
            this.Lb_DTel.TabIndex = 0;
            this.Lb_DTel.Text = "联系电话：";
            // 
            // Tb_DAddress
            // 
            this.Tb_DAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_DAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_DAddress.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_DAddress.Location = new System.Drawing.Point(98, 56);
            this.Tb_DAddress.Name = "Tb_DAddress";
            this.Tb_DAddress.Size = new System.Drawing.Size(200, 23);
            this.Tb_DAddress.TabIndex = 2;
            this.Tb_DAddress.TableFlag = true;
            this.Tb_DAddress.Tag = "";
            this.Tb_DAddress.Upper = false;
            // 
            // Lb_DAddress
            // 
            this.Lb_DAddress.AutoSize = true;
            this.Lb_DAddress.Location = new System.Drawing.Point(30, 61);
            this.Lb_DAddress.Name = "Lb_DAddress";
            this.Lb_DAddress.Size = new System.Drawing.Size(65, 12);
            this.Lb_DAddress.TabIndex = 0;
            this.Lb_DAddress.Text = "单位地址：";
            // 
            // Tb_DCompany
            // 
            this.Tb_DCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_DCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_DCompany.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_DCompany.Location = new System.Drawing.Point(98, 18);
            this.Tb_DCompany.Name = "Tb_DCompany";
            this.Tb_DCompany.Size = new System.Drawing.Size(200, 23);
            this.Tb_DCompany.TabIndex = 1;
            this.Tb_DCompany.TableFlag = true;
            this.Tb_DCompany.Tag = "";
            this.Tb_DCompany.Upper = false;
            // 
            // Lb_DCompany
            // 
            this.Lb_DCompany.AutoSize = true;
            this.Lb_DCompany.Location = new System.Drawing.Point(30, 23);
            this.Lb_DCompany.Name = "Lb_DCompany";
            this.Lb_DCompany.Size = new System.Drawing.Size(65, 12);
            this.Lb_DCompany.TabIndex = 0;
            this.Lb_DCompany.Text = "单位名称：";
            // 
            // BaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 232);
            this.Controls.Add(this.Tc_BaseInfo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BaseInfo";
            this.Text = "基本信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseInfo_FormClosed);
            this.Load += new System.EventHandler(this.BaseInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Tc_BaseInfo.ResumeLayout(false);
            this.Tp_UserInfo.ResumeLayout(false);
            this.Tp_UserInfo.PerformLayout();
            this.Tp_Design.ResumeLayout(false);
            this.Tp_Design.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.TabControl Tc_BaseInfo;
        private System.Windows.Forms.TabPage Tp_UserInfo;
        private System.Windows.Forms.TabPage Tp_Design;
        private WSV.Control.TextBox.TextBox Tb_Company;
        private System.Windows.Forms.Label Lb_Company;
        private WSV.Control.TextBox.TextBox Tb_PrintTitle;
        private System.Windows.Forms.Label Lb_PrintTitle;
        private WSV.Control.TextBox.TextBox Tb_Tel;
        private System.Windows.Forms.Label Lb_Tel;
        private WSV.Control.TextBox.TextBox Tb_Address;
        private System.Windows.Forms.Label Lb_Address;
        private WSV.Control.TextBox.TextBox Tb_DTel;
        private System.Windows.Forms.Label Lb_DTel;
        private WSV.Control.TextBox.TextBox Tb_DAddress;
        private System.Windows.Forms.Label Lb_DAddress;
        private WSV.Control.TextBox.TextBox Tb_DCompany;
        private System.Windows.Forms.Label Lb_DCompany;
    }
}