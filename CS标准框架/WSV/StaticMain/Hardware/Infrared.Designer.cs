namespace WSV.Hardware
{
    partial class Infrared
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
            this.Lab_Enable = new System.Windows.Forms.Label();
            this.Cb_Enable = new System.Windows.Forms.CheckBox();
            this.Cmb_Infrared1 = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_Infrared1 = new System.Windows.Forms.Label();
            this.Cmb_Infrared2 = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_Infrared2 = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(236, 32);
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
            // Lab_Enable
            // 
            this.Lab_Enable.AutoSize = true;
            this.Lab_Enable.Location = new System.Drawing.Point(29, 56);
            this.Lab_Enable.Name = "Lab_Enable";
            this.Lab_Enable.Size = new System.Drawing.Size(65, 12);
            this.Lab_Enable.TabIndex = 0;
            this.Lab_Enable.Text = "启用红外：";
            // 
            // Cb_Enable
            // 
            this.Cb_Enable.AutoSize = true;
            this.Cb_Enable.Location = new System.Drawing.Point(100, 54);
            this.Cb_Enable.Name = "Cb_Enable";
            this.Cb_Enable.Size = new System.Drawing.Size(15, 14);
            this.Cb_Enable.TabIndex = 1;
            this.Cb_Enable.UseVisualStyleBackColor = true;
            // 
            // Cmb_Infrared1
            // 
            this.Cmb_Infrared1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Infrared1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Infrared1.FormattingEnabled = true;
            this.Cmb_Infrared1.Location = new System.Drawing.Point(100, 86);
            this.Cmb_Infrared1.Name = "Cmb_Infrared1";
            this.Cmb_Infrared1.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Infrared1.TabIndex = 2;
            this.Cmb_Infrared1.text = null;
            this.Cmb_Infrared1.value = null;
            // 
            // Lab_Infrared1
            // 
            this.Lab_Infrared1.AutoSize = true;
            this.Lab_Infrared1.Location = new System.Drawing.Point(41, 92);
            this.Lab_Infrared1.Name = "Lab_Infrared1";
            this.Lab_Infrared1.Size = new System.Drawing.Size(53, 12);
            this.Lab_Infrared1.TabIndex = 0;
            this.Lab_Infrared1.Text = "红外一：";
            // 
            // Cmb_Infrared2
            // 
            this.Cmb_Infrared2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Infrared2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Infrared2.FormattingEnabled = true;
            this.Cmb_Infrared2.Location = new System.Drawing.Point(100, 127);
            this.Cmb_Infrared2.Name = "Cmb_Infrared2";
            this.Cmb_Infrared2.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Infrared2.TabIndex = 4;
            this.Cmb_Infrared2.text = null;
            this.Cmb_Infrared2.value = null;
            // 
            // Lab_Infrared2
            // 
            this.Lab_Infrared2.AutoSize = true;
            this.Lab_Infrared2.Location = new System.Drawing.Point(41, 133);
            this.Lab_Infrared2.Name = "Lab_Infrared2";
            this.Lab_Infrared2.Size = new System.Drawing.Size(53, 12);
            this.Lab_Infrared2.TabIndex = 3;
            this.Lab_Infrared2.Text = "红外二：";
            // 
            // Infrared
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 180);
            this.Controls.Add(this.Cmb_Infrared2);
            this.Controls.Add(this.Lab_Infrared2);
            this.Controls.Add(this.Cmb_Infrared1);
            this.Controls.Add(this.Lab_Infrared1);
            this.Controls.Add(this.Lab_Enable);
            this.Controls.Add(this.Cb_Enable);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Infrared";
            this.Text = "红外设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Infrared_FormClosed);
            this.Load += new System.EventHandler(this.Infrared_Load);
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
        private System.Windows.Forms.Label Lab_Enable;
        private System.Windows.Forms.CheckBox Cb_Enable;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Infrared1;
        private System.Windows.Forms.Label Lab_Infrared1;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Infrared2;
        private System.Windows.Forms.Label Lab_Infrared2;
    }
}