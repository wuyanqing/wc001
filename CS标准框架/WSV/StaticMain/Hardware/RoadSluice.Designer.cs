namespace WSV.Hardware
{
    partial class RoadSluice
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
            this.Cmb_RoadSluice1 = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_RoadSluice1 = new System.Windows.Forms.Label();
            this.Lab_Enable = new System.Windows.Forms.Label();
            this.Cb_Enable = new System.Windows.Forms.CheckBox();
            this.Cmb_RoadSluice2 = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_RoadSluice2 = new System.Windows.Forms.Label();
            this.Cmb_WorkMode1 = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_WorkMode1 = new System.Windows.Forms.Label();
            this.Cmb_WorkMode2 = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_WorkMode2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.toolStrip1.Size = new System.Drawing.Size(273, 32);
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
            // Cmb_RoadSluice1
            // 
            this.Cmb_RoadSluice1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_RoadSluice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_RoadSluice1.FormattingEnabled = true;
            this.Cmb_RoadSluice1.Location = new System.Drawing.Point(105, 18);
            this.Cmb_RoadSluice1.Name = "Cmb_RoadSluice1";
            this.Cmb_RoadSluice1.Size = new System.Drawing.Size(100, 24);
            this.Cmb_RoadSluice1.TabIndex = 2;
            this.Cmb_RoadSluice1.text = null;
            this.Cmb_RoadSluice1.value = null;
            // 
            // Lab_RoadSluice1
            // 
            this.Lab_RoadSluice1.AutoSize = true;
            this.Lab_RoadSluice1.Location = new System.Drawing.Point(43, 24);
            this.Lab_RoadSluice1.Name = "Lab_RoadSluice1";
            this.Lab_RoadSluice1.Size = new System.Drawing.Size(65, 12);
            this.Lab_RoadSluice1.TabIndex = 0;
            this.Lab_RoadSluice1.Text = "初始状态：";
            // 
            // Lab_Enable
            // 
            this.Lab_Enable.AutoSize = true;
            this.Lab_Enable.Location = new System.Drawing.Point(62, 48);
            this.Lab_Enable.Name = "Lab_Enable";
            this.Lab_Enable.Size = new System.Drawing.Size(65, 12);
            this.Lab_Enable.TabIndex = 0;
            this.Lab_Enable.Text = "启用道闸：";
            // 
            // Cb_Enable
            // 
            this.Cb_Enable.AutoSize = true;
            this.Cb_Enable.Location = new System.Drawing.Point(126, 47);
            this.Cb_Enable.Name = "Cb_Enable";
            this.Cb_Enable.Size = new System.Drawing.Size(15, 14);
            this.Cb_Enable.TabIndex = 1;
            this.Cb_Enable.UseVisualStyleBackColor = true;
            // 
            // Cmb_RoadSluice2
            // 
            this.Cmb_RoadSluice2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_RoadSluice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_RoadSluice2.FormattingEnabled = true;
            this.Cmb_RoadSluice2.Location = new System.Drawing.Point(105, 20);
            this.Cmb_RoadSluice2.Name = "Cmb_RoadSluice2";
            this.Cmb_RoadSluice2.Size = new System.Drawing.Size(100, 24);
            this.Cmb_RoadSluice2.TabIndex = 3;
            this.Cmb_RoadSluice2.text = null;
            this.Cmb_RoadSluice2.value = null;
            // 
            // Lab_RoadSluice2
            // 
            this.Lab_RoadSluice2.AutoSize = true;
            this.Lab_RoadSluice2.Location = new System.Drawing.Point(43, 26);
            this.Lab_RoadSluice2.Name = "Lab_RoadSluice2";
            this.Lab_RoadSluice2.Size = new System.Drawing.Size(65, 12);
            this.Lab_RoadSluice2.TabIndex = 0;
            this.Lab_RoadSluice2.Text = "初始状态：";
            // 
            // Cmb_WorkMode1
            // 
            this.Cmb_WorkMode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_WorkMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_WorkMode1.FormattingEnabled = true;
            this.Cmb_WorkMode1.Location = new System.Drawing.Point(105, 58);
            this.Cmb_WorkMode1.Name = "Cmb_WorkMode1";
            this.Cmb_WorkMode1.Size = new System.Drawing.Size(100, 24);
            this.Cmb_WorkMode1.TabIndex = 4;
            this.Cmb_WorkMode1.text = null;
            this.Cmb_WorkMode1.value = null;
            // 
            // Lab_WorkMode1
            // 
            this.Lab_WorkMode1.AutoSize = true;
            this.Lab_WorkMode1.Location = new System.Drawing.Point(43, 64);
            this.Lab_WorkMode1.Name = "Lab_WorkMode1";
            this.Lab_WorkMode1.Size = new System.Drawing.Size(65, 12);
            this.Lab_WorkMode1.TabIndex = 0;
            this.Lab_WorkMode1.Text = "工作方式：";
            // 
            // Cmb_WorkMode2
            // 
            this.Cmb_WorkMode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_WorkMode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_WorkMode2.FormattingEnabled = true;
            this.Cmb_WorkMode2.Location = new System.Drawing.Point(105, 60);
            this.Cmb_WorkMode2.Name = "Cmb_WorkMode2";
            this.Cmb_WorkMode2.Size = new System.Drawing.Size(100, 24);
            this.Cmb_WorkMode2.TabIndex = 6;
            this.Cmb_WorkMode2.text = null;
            this.Cmb_WorkMode2.value = null;
            // 
            // Lab_WorkMode2
            // 
            this.Lab_WorkMode2.AutoSize = true;
            this.Lab_WorkMode2.Location = new System.Drawing.Point(43, 66);
            this.Lab_WorkMode2.Name = "Lab_WorkMode2";
            this.Lab_WorkMode2.Size = new System.Drawing.Size(65, 12);
            this.Lab_WorkMode2.TabIndex = 5;
            this.Lab_WorkMode2.Text = "工作方式：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmb_RoadSluice1);
            this.groupBox1.Controls.Add(this.Lab_RoadSluice1);
            this.groupBox1.Controls.Add(this.Cmb_WorkMode1);
            this.groupBox1.Controls.Add(this.Lab_WorkMode1);
            this.groupBox1.Location = new System.Drawing.Point(7, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "道闸一";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cmb_RoadSluice2);
            this.groupBox2.Controls.Add(this.Lab_RoadSluice2);
            this.groupBox2.Controls.Add(this.Cmb_WorkMode2);
            this.groupBox2.Controls.Add(this.Lab_WorkMode2);
            this.groupBox2.Location = new System.Drawing.Point(7, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 96);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "道闸二";
            // 
            // RoadSluice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 277);
            this.Controls.Add(this.Cb_Enable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lab_Enable);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoadSluice";
            this.Text = "道闸设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoadSluice_FormClosed);
            this.Load += new System.EventHandler(this.RoadSluice_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_RoadSluice1;
        private System.Windows.Forms.Label Lab_RoadSluice1;
        private System.Windows.Forms.Label Lab_Enable;
        private System.Windows.Forms.CheckBox Cb_Enable;
        private WSV.Control.MyComboBox.MyComboBox Cmb_RoadSluice2;
        private System.Windows.Forms.Label Lab_RoadSluice2;
        private WSV.Control.MyComboBox.MyComboBox Cmb_WorkMode1;
        private System.Windows.Forms.Label Lab_WorkMode1;
        private WSV.Control.MyComboBox.MyComboBox Cmb_WorkMode2;
        private System.Windows.Forms.Label Lab_WorkMode2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}