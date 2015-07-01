namespace WSV.SysInfo
{
    partial class Port
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxT_Saver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxT_database = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxT_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.com_Accept = new WSV.Control.MyComboBox.MyComboBox();
            this.Txt_Accept = new WSV.Control.TextBox.TextBox();
            this.Btn_Accept = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器：";
            // 
            // TxT_Saver
            // 
            this.TxT_Saver.Location = new System.Drawing.Point(141, 74);
            this.TxT_Saver.Name = "TxT_Saver";
            this.TxT_Saver.Size = new System.Drawing.Size(140, 21);
            this.TxT_Saver.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "收货部门：";
            // 
            // TxT_database
            // 
            this.TxT_database.Location = new System.Drawing.Point(141, 174);
            this.TxT_database.Name = "TxT_database";
            this.TxT_database.Size = new System.Drawing.Size(140, 21);
            this.TxT_database.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据库名称：";
            // 
            // TxT_Password
            // 
            this.TxT_Password.Location = new System.Drawing.Point(141, 123);
            this.TxT_Password.Name = "TxT_Password";
            this.TxT_Password.PasswordChar = '*';
            this.TxT_Password.Size = new System.Drawing.Size(140, 21);
            this.TxT_Password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "服务器密码：";
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
            this.toolStrip1.Size = new System.Drawing.Size(393, 32);
            this.toolStrip1.TabIndex = 14;
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
            this.groupBox1.Controls.Add(this.com_Accept);
            this.groupBox1.Controls.Add(this.Txt_Accept);
            this.groupBox1.Controls.Add(this.Btn_Accept);
            this.groupBox1.Controls.Add(this.TxT_database);
            this.groupBox1.Controls.Add(this.TxT_Saver);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxT_Password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 217);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息";
            // 
            // com_Accept
            // 
            this.com_Accept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.com_Accept.FormattingEnabled = true;
            this.com_Accept.Location = new System.Drawing.Point(141, 28);
            this.com_Accept.Name = "com_Accept";
            this.com_Accept.Size = new System.Drawing.Size(140, 24);
            this.com_Accept.TabIndex = 18;
            this.com_Accept.text = null;
            this.com_Accept.value = null;
            // 
            // Txt_Accept
            // 
            this.Txt_Accept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_Accept.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Txt_Accept.Location = new System.Drawing.Point(141, 28);
            this.Txt_Accept.Name = "Txt_Accept";
            this.Txt_Accept.Size = new System.Drawing.Size(140, 23);
            this.Txt_Accept.TabIndex = 16;
            this.Txt_Accept.TableFlag = false;
            this.Txt_Accept.Tag = "";
            this.Txt_Accept.Upper = false;
            this.Txt_Accept.Visible = false;
            this.Txt_Accept.DoubleClick += new System.EventHandler(this.Txt_Accept_DoubleClick);
            this.Txt_Accept.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Accept_KeyDown);
            this.Txt_Accept.Leave += new System.EventHandler(this.Txt_Accept_Leave);
            // 
            // Btn_Accept
            // 
            this.Btn_Accept.BackgroundImage = global::WSV.Properties.Resources.Btn_Preview1;
            this.Btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Accept.Location = new System.Drawing.Point(281, 28);
            this.Btn_Accept.Name = "Btn_Accept";
            this.Btn_Accept.Size = new System.Drawing.Size(22, 23);
            this.Btn_Accept.TabIndex = 17;
            this.Btn_Accept.UseVisualStyleBackColor = true;
            this.Btn_Accept.Visible = false;
            this.Btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // Port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Port";
            this.Text = "接口配置";
            this.Load += new System.EventHandler(this.Port_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxT_Saver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxT_database;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxT_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private WSV.Control.TextBox.TextBox Txt_Accept;
        private System.Windows.Forms.Button Btn_Accept;
        private WSV.Control.MyComboBox.MyComboBox com_Accept;
    }
}