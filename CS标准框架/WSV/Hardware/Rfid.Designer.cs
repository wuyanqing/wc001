namespace WSV.Hardware
{
    partial class Rfid
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
            this.Cmb_CardType = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_CardType = new System.Windows.Forms.Label();
            this.Cmb_WeightType = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_WeightType = new System.Windows.Forms.Label();
            this.Cmb_BaudRate = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_BaudRate = new System.Windows.Forms.Label();
            this.Cmb_Serial = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_Serial = new System.Windows.Forms.Label();
            this.Lab_Enable = new System.Windows.Forms.Label();
            this.Cb_Enable = new System.Windows.Forms.CheckBox();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cmb_CardType
            // 
            this.Cmb_CardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_CardType.FormattingEnabled = true;
            this.Cmb_CardType.Location = new System.Drawing.Point(101, 54);
            this.Cmb_CardType.Name = "Cmb_CardType";
            this.Cmb_CardType.Size = new System.Drawing.Size(100, 24);
            this.Cmb_CardType.TabIndex = 11;
            this.Cmb_CardType.text = null;
            this.Cmb_CardType.value = null;
            // 
            // Lab_CardType
            // 
            this.Lab_CardType.AutoSize = true;
            this.Lab_CardType.Location = new System.Drawing.Point(40, 60);
            this.Lab_CardType.Name = "Lab_CardType";
            this.Lab_CardType.Size = new System.Drawing.Size(65, 12);
            this.Lab_CardType.TabIndex = 10;
            this.Lab_CardType.Text = "通讯类型：";
            // 
            // Cmb_WeightType
            // 
            this.Cmb_WeightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_WeightType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_WeightType.FormattingEnabled = true;
            this.Cmb_WeightType.Location = new System.Drawing.Point(101, 135);
            this.Cmb_WeightType.Name = "Cmb_WeightType";
            this.Cmb_WeightType.Size = new System.Drawing.Size(150, 24);
            this.Cmb_WeightType.TabIndex = 15;
            this.Cmb_WeightType.text = null;
            this.Cmb_WeightType.value = null;
            // 
            // Lab_WeightType
            // 
            this.Lab_WeightType.AutoSize = true;
            this.Lab_WeightType.Location = new System.Drawing.Point(40, 141);
            this.Lab_WeightType.Name = "Lab_WeightType";
            this.Lab_WeightType.Size = new System.Drawing.Size(65, 12);
            this.Lab_WeightType.TabIndex = 6;
            this.Lab_WeightType.Text = "称重方式：";
            // 
            // Cmb_BaudRate
            // 
            this.Cmb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_BaudRate.FormattingEnabled = true;
            this.Cmb_BaudRate.Location = new System.Drawing.Point(316, 95);
            this.Cmb_BaudRate.Name = "Cmb_BaudRate";
            this.Cmb_BaudRate.Size = new System.Drawing.Size(100, 24);
            this.Cmb_BaudRate.TabIndex = 14;
            this.Cmb_BaudRate.text = null;
            this.Cmb_BaudRate.value = null;
            // 
            // Lab_BaudRate
            // 
            this.Lab_BaudRate.AutoSize = true;
            this.Lab_BaudRate.Location = new System.Drawing.Point(260, 102);
            this.Lab_BaudRate.Name = "Lab_BaudRate";
            this.Lab_BaudRate.Size = new System.Drawing.Size(53, 12);
            this.Lab_BaudRate.TabIndex = 7;
            this.Lab_BaudRate.Text = "波特率：";
            // 
            // Cmb_Serial
            // 
            this.Cmb_Serial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Serial.FormattingEnabled = true;
            this.Cmb_Serial.Location = new System.Drawing.Point(101, 95);
            this.Cmb_Serial.Name = "Cmb_Serial";
            this.Cmb_Serial.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Serial.TabIndex = 13;
            this.Cmb_Serial.text = null;
            this.Cmb_Serial.value = null;
            // 
            // Lab_Serial
            // 
            this.Lab_Serial.AutoSize = true;
            this.Lab_Serial.Location = new System.Drawing.Point(49, 101);
            this.Lab_Serial.Name = "Lab_Serial";
            this.Lab_Serial.Size = new System.Drawing.Size(53, 12);
            this.Lab_Serial.TabIndex = 8;
            this.Lab_Serial.Text = "通讯号：";
            // 
            // Lab_Enable
            // 
            this.Lab_Enable.AutoSize = true;
            this.Lab_Enable.Location = new System.Drawing.Point(257, 60);
            this.Lab_Enable.Name = "Lab_Enable";
            this.Lab_Enable.Size = new System.Drawing.Size(89, 12);
            this.Lab_Enable.TabIndex = 9;
            this.Lab_Enable.Text = "启用电子标签：";
            // 
            // Cb_Enable
            // 
            this.Cb_Enable.AutoSize = true;
            this.Cb_Enable.Location = new System.Drawing.Point(346, 60);
            this.Cb_Enable.Name = "Cb_Enable";
            this.Cb_Enable.Size = new System.Drawing.Size(15, 14);
            this.Cb_Enable.TabIndex = 12;
            this.Cb_Enable.UseVisualStyleBackColor = true;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Save,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(446, 32);
            this.toolStrip1.TabIndex = 16;
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
            // Rfid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 184);
            this.Controls.Add(this.Cb_Enable);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Cmb_CardType);
            this.Controls.Add(this.Lab_CardType);
            this.Controls.Add(this.Cmb_WeightType);
            this.Controls.Add(this.Lab_WeightType);
            this.Controls.Add(this.Cmb_BaudRate);
            this.Controls.Add(this.Lab_BaudRate);
            this.Controls.Add(this.Cmb_Serial);
            this.Controls.Add(this.Lab_Serial);
            this.Controls.Add(this.Lab_Enable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rfid";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子标签设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rfid_FormClosed);
            this.Load += new System.EventHandler(this.Rfid_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WSV.Control.MyComboBox.MyComboBox Cmb_CardType;
        private System.Windows.Forms.Label Lab_CardType;
        private WSV.Control.MyComboBox.MyComboBox Cmb_WeightType;
        private System.Windows.Forms.Label Lab_WeightType;
        private WSV.Control.MyComboBox.MyComboBox Cmb_BaudRate;
        private System.Windows.Forms.Label Lab_BaudRate;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Serial;
        private System.Windows.Forms.Label Lab_Serial;
        private System.Windows.Forms.Label Lab_Enable;
        private System.Windows.Forms.CheckBox Cb_Enable;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;

    }
}