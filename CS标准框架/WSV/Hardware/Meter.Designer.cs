namespace WSV.Hardware
{
    partial class Meter
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
            this.Lab_Serial = new System.Windows.Forms.Label();
            this.Lab_Unit = new System.Windows.Forms.Label();
            this.Tb_DetectStart = new WSV.Control.TextBox.TextBox();
            this.Lab_DetectStart = new System.Windows.Forms.Label();
            this.Lab_MeterType = new System.Windows.Forms.Label();
            this.Tb_FullBalance = new WSV.Control.TextBox.TextBox();
            this.Lab_FullBalance = new System.Windows.Forms.Label();
            this.Lab_BaudRate = new System.Windows.Forms.Label();
            this.Cmb_Serial = new WSV.Control.MyComboBox.MyComboBox();
            this.Cmb_MeterType = new WSV.Control.MyComboBox.MyComboBox();
            this.Cmb_BaudRate = new WSV.Control.MyComboBox.MyComboBox();
            this.Cmb_Unit = new WSV.Control.MyComboBox.MyComboBox();
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
            this.toolStrip1.Size = new System.Drawing.Size(393, 32);
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
            // Lab_Serial
            // 
            this.Lab_Serial.AutoSize = true;
            this.Lab_Serial.Location = new System.Drawing.Point(16, 57);
            this.Lab_Serial.Name = "Lab_Serial";
            this.Lab_Serial.Size = new System.Drawing.Size(65, 12);
            this.Lab_Serial.TabIndex = 0;
            this.Lab_Serial.Text = "仪表串口：";
            // 
            // Lab_Unit
            // 
            this.Lab_Unit.AutoSize = true;
            this.Lab_Unit.Location = new System.Drawing.Point(196, 94);
            this.Lab_Unit.Name = "Lab_Unit";
            this.Lab_Unit.Size = new System.Drawing.Size(65, 12);
            this.Lab_Unit.TabIndex = 0;
            this.Lab_Unit.Text = "计量单位：";
            // 
            // Tb_DetectStart
            // 
            this.Tb_DetectStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_DetectStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_DetectStart.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_DetectStart.Location = new System.Drawing.Point(84, 128);
            this.Tb_DetectStart.Name = "Tb_DetectStart";
            this.Tb_DetectStart.Size = new System.Drawing.Size(100, 23);
            this.Tb_DetectStart.TabIndex = 5;
            this.Tb_DetectStart.TableFlag = true;
            this.Tb_DetectStart.Tag = "";
            this.Tb_DetectStart.Upper = false;
            // 
            // Lab_DetectStart
            // 
            this.Lab_DetectStart.AutoSize = true;
            this.Lab_DetectStart.Location = new System.Drawing.Point(16, 134);
            this.Lab_DetectStart.Name = "Lab_DetectStart";
            this.Lab_DetectStart.Size = new System.Drawing.Size(65, 12);
            this.Lab_DetectStart.TabIndex = 0;
            this.Lab_DetectStart.Text = "检测起点：";
            // 
            // Lab_MeterType
            // 
            this.Lab_MeterType.AutoSize = true;
            this.Lab_MeterType.Location = new System.Drawing.Point(196, 57);
            this.Lab_MeterType.Name = "Lab_MeterType";
            this.Lab_MeterType.Size = new System.Drawing.Size(65, 12);
            this.Lab_MeterType.TabIndex = 0;
            this.Lab_MeterType.Text = "仪表类型：";
            // 
            // Tb_FullBalance
            // 
            this.Tb_FullBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_FullBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_FullBalance.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_FullBalance.Location = new System.Drawing.Point(264, 128);
            this.Tb_FullBalance.Name = "Tb_FullBalance";
            this.Tb_FullBalance.Size = new System.Drawing.Size(100, 23);
            this.Tb_FullBalance.TabIndex = 6;
            this.Tb_FullBalance.TableFlag = true;
            this.Tb_FullBalance.Tag = "";
            this.Tb_FullBalance.Upper = false;
            // 
            // Lab_FullBalance
            // 
            this.Lab_FullBalance.AutoSize = true;
            this.Lab_FullBalance.Location = new System.Drawing.Point(196, 134);
            this.Lab_FullBalance.Name = "Lab_FullBalance";
            this.Lab_FullBalance.Size = new System.Drawing.Size(65, 12);
            this.Lab_FullBalance.TabIndex = 0;
            this.Lab_FullBalance.Text = "最大秤值：";
            // 
            // Lab_BaudRate
            // 
            this.Lab_BaudRate.AutoSize = true;
            this.Lab_BaudRate.Location = new System.Drawing.Point(28, 95);
            this.Lab_BaudRate.Name = "Lab_BaudRate";
            this.Lab_BaudRate.Size = new System.Drawing.Size(53, 12);
            this.Lab_BaudRate.TabIndex = 0;
            this.Lab_BaudRate.Text = "波特率：";
            // 
            // Cmb_Serial
            // 
            this.Cmb_Serial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Serial.FormattingEnabled = true;
            this.Cmb_Serial.Location = new System.Drawing.Point(84, 54);
            this.Cmb_Serial.Name = "Cmb_Serial";
            this.Cmb_Serial.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Serial.TabIndex = 1;
            this.Cmb_Serial.text = null;
            this.Cmb_Serial.value = null;
            // 
            // Cmb_MeterType
            // 
            this.Cmb_MeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_MeterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_MeterType.FormattingEnabled = true;
            this.Cmb_MeterType.Location = new System.Drawing.Point(264, 54);
            this.Cmb_MeterType.Name = "Cmb_MeterType";
            this.Cmb_MeterType.Size = new System.Drawing.Size(100, 24);
            this.Cmb_MeterType.TabIndex = 2;
            this.Cmb_MeterType.text = null;
            this.Cmb_MeterType.value = null;
            // 
            // Cmb_BaudRate
            // 
            this.Cmb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_BaudRate.FormattingEnabled = true;
            this.Cmb_BaudRate.Location = new System.Drawing.Point(84, 91);
            this.Cmb_BaudRate.Name = "Cmb_BaudRate";
            this.Cmb_BaudRate.Size = new System.Drawing.Size(100, 24);
            this.Cmb_BaudRate.TabIndex = 3;
            this.Cmb_BaudRate.text = null;
            this.Cmb_BaudRate.value = null;
            // 
            // Cmb_Unit
            // 
            this.Cmb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Unit.FormattingEnabled = true;
            this.Cmb_Unit.Location = new System.Drawing.Point(264, 91);
            this.Cmb_Unit.Name = "Cmb_Unit";
            this.Cmb_Unit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Unit.TabIndex = 4;
            this.Cmb_Unit.text = null;
            this.Cmb_Unit.value = null;
            // 
            // Meter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 179);
            this.Controls.Add(this.Cmb_Unit);
            this.Controls.Add(this.Cmb_BaudRate);
            this.Controls.Add(this.Cmb_MeterType);
            this.Controls.Add(this.Cmb_Serial);
            this.Controls.Add(this.Tb_FullBalance);
            this.Controls.Add(this.Lab_FullBalance);
            this.Controls.Add(this.Lab_BaudRate);
            this.Controls.Add(this.Tb_DetectStart);
            this.Controls.Add(this.Lab_DetectStart);
            this.Controls.Add(this.Lab_MeterType);
            this.Controls.Add(this.Lab_Unit);
            this.Controls.Add(this.Lab_Serial);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Meter";
            this.Tag = "Meter";
            this.Text = "仪表设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Meter_FormClosed);
            this.Load += new System.EventHandler(this.Meter_Load);
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
        private System.Windows.Forms.Label Lab_Serial;
        private System.Windows.Forms.Label Lab_Unit;
        private WSV.Control.TextBox.TextBox Tb_DetectStart;
        private System.Windows.Forms.Label Lab_DetectStart;
        private System.Windows.Forms.Label Lab_MeterType;
        private WSV.Control.TextBox.TextBox Tb_FullBalance;
        private System.Windows.Forms.Label Lab_FullBalance;
        private System.Windows.Forms.Label Lab_BaudRate;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Serial;
        private WSV.Control.MyComboBox.MyComboBox Cmb_MeterType;
        private WSV.Control.MyComboBox.MyComboBox Cmb_BaudRate;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Unit;
    }
}