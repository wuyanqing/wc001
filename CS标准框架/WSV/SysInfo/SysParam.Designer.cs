namespace WSV.SysInfo
{
    partial class SysParam
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
            this.Tc_SysPram = new System.Windows.Forms.TabControl();
            this.Tp_DataFormat = new System.Windows.Forms.TabPage();
            this.Cmb_CodeWay = new WSV.Control.MyComboBox.MyComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_CodeRule = new WSV.Control.MyComboBox.MyComboBox();
            this.Lb_CodeRule = new System.Windows.Forms.Label();
            this.Cmb_EndNetMode = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_EndNetMode = new System.Windows.Forms.Label();
            this.Cmb_MoneyMode = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_MoneyMode = new System.Windows.Forms.Label();
            this.Tp_NumDigit = new System.Windows.Forms.TabPage();
            this.Cmb_MoneyRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_MoneyRound = new System.Windows.Forms.Label();
            this.Cmb_MoneyDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_MoneyDigit = new System.Windows.Forms.Label();
            this.Cmb_PriceRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_PriceRound = new System.Windows.Forms.Label();
            this.Cmb_PriceDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_PriceDigit = new System.Windows.Forms.Label();
            this.Cmb_EndNetRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_EndNetRound = new System.Windows.Forms.Label();
            this.Cmb_EndNetDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_EndNetDigit = new System.Windows.Forms.Label();
            this.Cmb_DeductRateRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_DeductRateRound = new System.Windows.Forms.Label();
            this.Cmb_DeductRateDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_DeductRateDigit = new System.Windows.Forms.Label();
            this.Cmb_DeductWeightRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_DeductWeightRound = new System.Windows.Forms.Label();
            this.Cmb_DeductWeightDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_DeductWeightDigit = new System.Windows.Forms.Label();
            this.Cmb_NetRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_NetRound = new System.Windows.Forms.Label();
            this.Cmb_NetDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_Cmb_NetDigit = new System.Windows.Forms.Label();
            this.Cmb_TareRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_TareRound = new System.Windows.Forms.Label();
            this.Cmb_TareDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_Cmb_TareDigit = new System.Windows.Forms.Label();
            this.Cmb_GrossRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_GrossRound = new System.Windows.Forms.Label();
            this.Cmb_GrossDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.Lab_Cmb_GrossDigit = new System.Windows.Forms.Label();
            this.Cmb_CubeRound = new WSV.Control.MyComboBox.MyComboBox();
            this.Cmb_CubeDigit = new WSV.Control.MyComboBox.MyComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Tc_SysPram.SuspendLayout();
            this.Tp_DataFormat.SuspendLayout();
            this.Tp_NumDigit.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(505, 32);
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
            // Tc_SysPram
            // 
            this.Tc_SysPram.Controls.Add(this.Tp_DataFormat);
            this.Tc_SysPram.Controls.Add(this.Tp_NumDigit);
            this.Tc_SysPram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tc_SysPram.Location = new System.Drawing.Point(0, 32);
            this.Tc_SysPram.Name = "Tc_SysPram";
            this.Tc_SysPram.SelectedIndex = 0;
            this.Tc_SysPram.Size = new System.Drawing.Size(505, 403);
            this.Tc_SysPram.TabIndex = 2;
            // 
            // Tp_DataFormat
            // 
            this.Tp_DataFormat.BackColor = System.Drawing.SystemColors.Control;
            this.Tp_DataFormat.Controls.Add(this.Cmb_CodeWay);
            this.Tp_DataFormat.Controls.Add(this.label1);
            this.Tp_DataFormat.Controls.Add(this.Cmb_CodeRule);
            this.Tp_DataFormat.Controls.Add(this.Lb_CodeRule);
            this.Tp_DataFormat.Controls.Add(this.Cmb_EndNetMode);
            this.Tp_DataFormat.Controls.Add(this.Lab_EndNetMode);
            this.Tp_DataFormat.Controls.Add(this.Cmb_MoneyMode);
            this.Tp_DataFormat.Controls.Add(this.Lab_MoneyMode);
            this.Tp_DataFormat.Location = new System.Drawing.Point(4, 21);
            this.Tp_DataFormat.Name = "Tp_DataFormat";
            this.Tp_DataFormat.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_DataFormat.Size = new System.Drawing.Size(497, 378);
            this.Tp_DataFormat.TabIndex = 1;
            this.Tp_DataFormat.Text = "系统参数";
            // 
            // Cmb_CodeWay
            // 
            this.Cmb_CodeWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CodeWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_CodeWay.FormattingEnabled = true;
            this.Cmb_CodeWay.Location = new System.Drawing.Point(213, 283);
            this.Cmb_CodeWay.Name = "Cmb_CodeWay";
            this.Cmb_CodeWay.Size = new System.Drawing.Size(150, 24);
            this.Cmb_CodeWay.TabIndex = 6;
            this.Cmb_CodeWay.text = null;
            this.Cmb_CodeWay.value = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "序号生成方式：";
            // 
            // Cmb_CodeRule
            // 
            this.Cmb_CodeRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CodeRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_CodeRule.FormattingEnabled = true;
            this.Cmb_CodeRule.Location = new System.Drawing.Point(213, 199);
            this.Cmb_CodeRule.Name = "Cmb_CodeRule";
            this.Cmb_CodeRule.Size = new System.Drawing.Size(150, 24);
            this.Cmb_CodeRule.TabIndex = 4;
            this.Cmb_CodeRule.text = null;
            this.Cmb_CodeRule.value = null;
            // 
            // Lb_CodeRule
            // 
            this.Lb_CodeRule.AutoSize = true;
            this.Lb_CodeRule.Location = new System.Drawing.Point(121, 205);
            this.Lb_CodeRule.Name = "Lb_CodeRule";
            this.Lb_CodeRule.Size = new System.Drawing.Size(89, 12);
            this.Lb_CodeRule.TabIndex = 3;
            this.Lb_CodeRule.Text = "序号编码规则：";
            // 
            // Cmb_EndNetMode
            // 
            this.Cmb_EndNetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_EndNetMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_EndNetMode.FormattingEnabled = true;
            this.Cmb_EndNetMode.Location = new System.Drawing.Point(213, 123);
            this.Cmb_EndNetMode.Name = "Cmb_EndNetMode";
            this.Cmb_EndNetMode.Size = new System.Drawing.Size(150, 24);
            this.Cmb_EndNetMode.TabIndex = 2;
            this.Cmb_EndNetMode.text = null;
            this.Cmb_EndNetMode.value = null;
            // 
            // Lab_EndNetMode
            // 
            this.Lab_EndNetMode.AutoSize = true;
            this.Lab_EndNetMode.Location = new System.Drawing.Point(97, 129);
            this.Lab_EndNetMode.Name = "Lab_EndNetMode";
            this.Lab_EndNetMode.Size = new System.Drawing.Size(113, 12);
            this.Lab_EndNetMode.TabIndex = 0;
            this.Lab_EndNetMode.Text = "结算净重得到方式：";
            // 
            // Cmb_MoneyMode
            // 
            this.Cmb_MoneyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_MoneyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_MoneyMode.FormattingEnabled = true;
            this.Cmb_MoneyMode.Location = new System.Drawing.Point(213, 39);
            this.Cmb_MoneyMode.Name = "Cmb_MoneyMode";
            this.Cmb_MoneyMode.Size = new System.Drawing.Size(150, 24);
            this.Cmb_MoneyMode.TabIndex = 1;
            this.Cmb_MoneyMode.text = null;
            this.Cmb_MoneyMode.value = null;
            // 
            // Lab_MoneyMode
            // 
            this.Lab_MoneyMode.AutoSize = true;
            this.Lab_MoneyMode.Location = new System.Drawing.Point(121, 45);
            this.Lab_MoneyMode.Name = "Lab_MoneyMode";
            this.Lab_MoneyMode.Size = new System.Drawing.Size(89, 12);
            this.Lab_MoneyMode.TabIndex = 0;
            this.Lab_MoneyMode.Text = "金额得到方式：";
            // 
            // Tp_NumDigit
            // 
            this.Tp_NumDigit.BackColor = System.Drawing.SystemColors.Control;
            this.Tp_NumDigit.Controls.Add(this.Cmb_CubeRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_MoneyRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_CubeDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_MoneyRound);
            this.Tp_NumDigit.Controls.Add(this.label3);
            this.Tp_NumDigit.Controls.Add(this.label4);
            this.Tp_NumDigit.Controls.Add(this.Cmb_MoneyDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_MoneyDigit);
            this.Tp_NumDigit.Controls.Add(this.Cmb_PriceRound);
            this.Tp_NumDigit.Controls.Add(this.Lab_PriceRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_PriceDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_PriceDigit);
            this.Tp_NumDigit.Controls.Add(this.Cmb_EndNetRound);
            this.Tp_NumDigit.Controls.Add(this.Lab_EndNetRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_EndNetDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_EndNetDigit);
            this.Tp_NumDigit.Controls.Add(this.Cmb_DeductRateRound);
            this.Tp_NumDigit.Controls.Add(this.Lab_DeductRateRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_DeductRateDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_DeductRateDigit);
            this.Tp_NumDigit.Controls.Add(this.Cmb_DeductWeightRound);
            this.Tp_NumDigit.Controls.Add(this.Lab_DeductWeightRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_DeductWeightDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_DeductWeightDigit);
            this.Tp_NumDigit.Controls.Add(this.Cmb_NetRound);
            this.Tp_NumDigit.Controls.Add(this.Lab_NetRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_NetDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_Cmb_NetDigit);
            this.Tp_NumDigit.Controls.Add(this.Cmb_TareRound);
            this.Tp_NumDigit.Controls.Add(this.Lab_TareRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_TareDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_Cmb_TareDigit);
            this.Tp_NumDigit.Controls.Add(this.Cmb_GrossRound);
            this.Tp_NumDigit.Controls.Add(this.Lab_GrossRound);
            this.Tp_NumDigit.Controls.Add(this.Cmb_GrossDigit);
            this.Tp_NumDigit.Controls.Add(this.Lab_Cmb_GrossDigit);
            this.Tp_NumDigit.Location = new System.Drawing.Point(4, 21);
            this.Tp_NumDigit.Name = "Tp_NumDigit";
            this.Tp_NumDigit.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_NumDigit.Size = new System.Drawing.Size(497, 378);
            this.Tp_NumDigit.TabIndex = 0;
            this.Tp_NumDigit.Text = "小数位设置";
            // 
            // Cmb_MoneyRound
            // 
            this.Cmb_MoneyRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_MoneyRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_MoneyRound.FormattingEnabled = true;
            this.Cmb_MoneyRound.Location = new System.Drawing.Point(355, 297);
            this.Cmb_MoneyRound.Name = "Cmb_MoneyRound";
            this.Cmb_MoneyRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_MoneyRound.TabIndex = 16;
            this.Cmb_MoneyRound.text = null;
            this.Cmb_MoneyRound.value = null;
            // 
            // Lab_MoneyRound
            // 
            this.Lab_MoneyRound.AutoSize = true;
            this.Lab_MoneyRound.Location = new System.Drawing.Point(263, 303);
            this.Lab_MoneyRound.Name = "Lab_MoneyRound";
            this.Lab_MoneyRound.Size = new System.Drawing.Size(89, 12);
            this.Lab_MoneyRound.TabIndex = 0;
            this.Lab_MoneyRound.Text = "金额取数方式：";
            // 
            // Cmb_MoneyDigit
            // 
            this.Cmb_MoneyDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_MoneyDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_MoneyDigit.FormattingEnabled = true;
            this.Cmb_MoneyDigit.Location = new System.Drawing.Point(127, 297);
            this.Cmb_MoneyDigit.Name = "Cmb_MoneyDigit";
            this.Cmb_MoneyDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_MoneyDigit.TabIndex = 15;
            this.Cmb_MoneyDigit.text = null;
            this.Cmb_MoneyDigit.value = null;
            // 
            // Lab_MoneyDigit
            // 
            this.Lab_MoneyDigit.AutoSize = true;
            this.Lab_MoneyDigit.Location = new System.Drawing.Point(35, 303);
            this.Lab_MoneyDigit.Name = "Lab_MoneyDigit";
            this.Lab_MoneyDigit.Size = new System.Drawing.Size(89, 12);
            this.Lab_MoneyDigit.TabIndex = 0;
            this.Lab_MoneyDigit.Text = "金额精确位数：";
            // 
            // Cmb_PriceRound
            // 
            this.Cmb_PriceRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_PriceRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_PriceRound.FormattingEnabled = true;
            this.Cmb_PriceRound.Location = new System.Drawing.Point(355, 255);
            this.Cmb_PriceRound.Name = "Cmb_PriceRound";
            this.Cmb_PriceRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_PriceRound.TabIndex = 14;
            this.Cmb_PriceRound.text = null;
            this.Cmb_PriceRound.value = null;
            // 
            // Lab_PriceRound
            // 
            this.Lab_PriceRound.AutoSize = true;
            this.Lab_PriceRound.Location = new System.Drawing.Point(263, 261);
            this.Lab_PriceRound.Name = "Lab_PriceRound";
            this.Lab_PriceRound.Size = new System.Drawing.Size(89, 12);
            this.Lab_PriceRound.TabIndex = 0;
            this.Lab_PriceRound.Text = "单价取数方式：";
            // 
            // Cmb_PriceDigit
            // 
            this.Cmb_PriceDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_PriceDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_PriceDigit.FormattingEnabled = true;
            this.Cmb_PriceDigit.Location = new System.Drawing.Point(127, 255);
            this.Cmb_PriceDigit.Name = "Cmb_PriceDigit";
            this.Cmb_PriceDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_PriceDigit.TabIndex = 13;
            this.Cmb_PriceDigit.text = null;
            this.Cmb_PriceDigit.value = null;
            // 
            // Lab_PriceDigit
            // 
            this.Lab_PriceDigit.AutoSize = true;
            this.Lab_PriceDigit.Location = new System.Drawing.Point(35, 261);
            this.Lab_PriceDigit.Name = "Lab_PriceDigit";
            this.Lab_PriceDigit.Size = new System.Drawing.Size(89, 12);
            this.Lab_PriceDigit.TabIndex = 0;
            this.Lab_PriceDigit.Text = "单价精确位数：";
            // 
            // Cmb_EndNetRound
            // 
            this.Cmb_EndNetRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_EndNetRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_EndNetRound.FormattingEnabled = true;
            this.Cmb_EndNetRound.Location = new System.Drawing.Point(355, 214);
            this.Cmb_EndNetRound.Name = "Cmb_EndNetRound";
            this.Cmb_EndNetRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_EndNetRound.TabIndex = 12;
            this.Cmb_EndNetRound.text = null;
            this.Cmb_EndNetRound.value = null;
            // 
            // Lab_EndNetRound
            // 
            this.Lab_EndNetRound.AutoSize = true;
            this.Lab_EndNetRound.Location = new System.Drawing.Point(239, 220);
            this.Lab_EndNetRound.Name = "Lab_EndNetRound";
            this.Lab_EndNetRound.Size = new System.Drawing.Size(113, 12);
            this.Lab_EndNetRound.TabIndex = 0;
            this.Lab_EndNetRound.Text = "结算净重取数方式：";
            // 
            // Cmb_EndNetDigit
            // 
            this.Cmb_EndNetDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_EndNetDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_EndNetDigit.FormattingEnabled = true;
            this.Cmb_EndNetDigit.Location = new System.Drawing.Point(127, 214);
            this.Cmb_EndNetDigit.Name = "Cmb_EndNetDigit";
            this.Cmb_EndNetDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_EndNetDigit.TabIndex = 11;
            this.Cmb_EndNetDigit.text = null;
            this.Cmb_EndNetDigit.value = null;
            // 
            // Lab_EndNetDigit
            // 
            this.Lab_EndNetDigit.AutoSize = true;
            this.Lab_EndNetDigit.Location = new System.Drawing.Point(11, 220);
            this.Lab_EndNetDigit.Name = "Lab_EndNetDigit";
            this.Lab_EndNetDigit.Size = new System.Drawing.Size(113, 12);
            this.Lab_EndNetDigit.TabIndex = 0;
            this.Lab_EndNetDigit.Text = "结算净重精确位数：";
            // 
            // Cmb_DeductRateRound
            // 
            this.Cmb_DeductRateRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_DeductRateRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_DeductRateRound.FormattingEnabled = true;
            this.Cmb_DeductRateRound.Location = new System.Drawing.Point(355, 172);
            this.Cmb_DeductRateRound.Name = "Cmb_DeductRateRound";
            this.Cmb_DeductRateRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_DeductRateRound.TabIndex = 10;
            this.Cmb_DeductRateRound.text = null;
            this.Cmb_DeductRateRound.value = null;
            // 
            // Lab_DeductRateRound
            // 
            this.Lab_DeductRateRound.AutoSize = true;
            this.Lab_DeductRateRound.Location = new System.Drawing.Point(263, 178);
            this.Lab_DeductRateRound.Name = "Lab_DeductRateRound";
            this.Lab_DeductRateRound.Size = new System.Drawing.Size(89, 12);
            this.Lab_DeductRateRound.TabIndex = 0;
            this.Lab_DeductRateRound.Text = "扣率取数方式：";
            // 
            // Cmb_DeductRateDigit
            // 
            this.Cmb_DeductRateDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_DeductRateDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_DeductRateDigit.FormattingEnabled = true;
            this.Cmb_DeductRateDigit.Location = new System.Drawing.Point(127, 172);
            this.Cmb_DeductRateDigit.Name = "Cmb_DeductRateDigit";
            this.Cmb_DeductRateDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_DeductRateDigit.TabIndex = 9;
            this.Cmb_DeductRateDigit.text = null;
            this.Cmb_DeductRateDigit.value = null;
            // 
            // Lab_DeductRateDigit
            // 
            this.Lab_DeductRateDigit.AutoSize = true;
            this.Lab_DeductRateDigit.Location = new System.Drawing.Point(35, 178);
            this.Lab_DeductRateDigit.Name = "Lab_DeductRateDigit";
            this.Lab_DeductRateDigit.Size = new System.Drawing.Size(89, 12);
            this.Lab_DeductRateDigit.TabIndex = 0;
            this.Lab_DeductRateDigit.Text = "扣率精确位数：";
            // 
            // Cmb_DeductWeightRound
            // 
            this.Cmb_DeductWeightRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_DeductWeightRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_DeductWeightRound.FormattingEnabled = true;
            this.Cmb_DeductWeightRound.Location = new System.Drawing.Point(355, 133);
            this.Cmb_DeductWeightRound.Name = "Cmb_DeductWeightRound";
            this.Cmb_DeductWeightRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_DeductWeightRound.TabIndex = 8;
            this.Cmb_DeductWeightRound.text = null;
            this.Cmb_DeductWeightRound.value = null;
            // 
            // Lab_DeductWeightRound
            // 
            this.Lab_DeductWeightRound.AutoSize = true;
            this.Lab_DeductWeightRound.Location = new System.Drawing.Point(263, 139);
            this.Lab_DeductWeightRound.Name = "Lab_DeductWeightRound";
            this.Lab_DeductWeightRound.Size = new System.Drawing.Size(89, 12);
            this.Lab_DeductWeightRound.TabIndex = 0;
            this.Lab_DeductWeightRound.Text = "扣重取数方式：";
            // 
            // Cmb_DeductWeightDigit
            // 
            this.Cmb_DeductWeightDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_DeductWeightDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_DeductWeightDigit.FormattingEnabled = true;
            this.Cmb_DeductWeightDigit.Location = new System.Drawing.Point(127, 133);
            this.Cmb_DeductWeightDigit.Name = "Cmb_DeductWeightDigit";
            this.Cmb_DeductWeightDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_DeductWeightDigit.TabIndex = 7;
            this.Cmb_DeductWeightDigit.text = null;
            this.Cmb_DeductWeightDigit.value = null;
            // 
            // Lab_DeductWeightDigit
            // 
            this.Lab_DeductWeightDigit.AutoSize = true;
            this.Lab_DeductWeightDigit.Location = new System.Drawing.Point(35, 139);
            this.Lab_DeductWeightDigit.Name = "Lab_DeductWeightDigit";
            this.Lab_DeductWeightDigit.Size = new System.Drawing.Size(89, 12);
            this.Lab_DeductWeightDigit.TabIndex = 0;
            this.Lab_DeductWeightDigit.Text = "扣重精确位数：";
            // 
            // Cmb_NetRound
            // 
            this.Cmb_NetRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_NetRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_NetRound.FormattingEnabled = true;
            this.Cmb_NetRound.Location = new System.Drawing.Point(355, 91);
            this.Cmb_NetRound.Name = "Cmb_NetRound";
            this.Cmb_NetRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_NetRound.TabIndex = 6;
            this.Cmb_NetRound.text = null;
            this.Cmb_NetRound.value = null;
            // 
            // Lab_NetRound
            // 
            this.Lab_NetRound.AutoSize = true;
            this.Lab_NetRound.Location = new System.Drawing.Point(263, 97);
            this.Lab_NetRound.Name = "Lab_NetRound";
            this.Lab_NetRound.Size = new System.Drawing.Size(89, 12);
            this.Lab_NetRound.TabIndex = 0;
            this.Lab_NetRound.Text = "净重取数方式：";
            // 
            // Cmb_NetDigit
            // 
            this.Cmb_NetDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_NetDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_NetDigit.FormattingEnabled = true;
            this.Cmb_NetDigit.Location = new System.Drawing.Point(127, 91);
            this.Cmb_NetDigit.Name = "Cmb_NetDigit";
            this.Cmb_NetDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_NetDigit.TabIndex = 5;
            this.Cmb_NetDigit.text = null;
            this.Cmb_NetDigit.value = null;
            // 
            // Lab_Cmb_NetDigit
            // 
            this.Lab_Cmb_NetDigit.AutoSize = true;
            this.Lab_Cmb_NetDigit.Location = new System.Drawing.Point(35, 97);
            this.Lab_Cmb_NetDigit.Name = "Lab_Cmb_NetDigit";
            this.Lab_Cmb_NetDigit.Size = new System.Drawing.Size(89, 12);
            this.Lab_Cmb_NetDigit.TabIndex = 0;
            this.Lab_Cmb_NetDigit.Text = "净重精确位数：";
            // 
            // Cmb_TareRound
            // 
            this.Cmb_TareRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TareRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_TareRound.FormattingEnabled = true;
            this.Cmb_TareRound.Location = new System.Drawing.Point(355, 50);
            this.Cmb_TareRound.Name = "Cmb_TareRound";
            this.Cmb_TareRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_TareRound.TabIndex = 4;
            this.Cmb_TareRound.text = null;
            this.Cmb_TareRound.value = null;
            // 
            // Lab_TareRound
            // 
            this.Lab_TareRound.AutoSize = true;
            this.Lab_TareRound.Location = new System.Drawing.Point(263, 56);
            this.Lab_TareRound.Name = "Lab_TareRound";
            this.Lab_TareRound.Size = new System.Drawing.Size(89, 12);
            this.Lab_TareRound.TabIndex = 0;
            this.Lab_TareRound.Text = "皮重取数方式：";
            // 
            // Cmb_TareDigit
            // 
            this.Cmb_TareDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TareDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_TareDigit.FormattingEnabled = true;
            this.Cmb_TareDigit.Location = new System.Drawing.Point(127, 50);
            this.Cmb_TareDigit.Name = "Cmb_TareDigit";
            this.Cmb_TareDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_TareDigit.TabIndex = 3;
            this.Cmb_TareDigit.text = null;
            this.Cmb_TareDigit.value = null;
            // 
            // Lab_Cmb_TareDigit
            // 
            this.Lab_Cmb_TareDigit.AutoSize = true;
            this.Lab_Cmb_TareDigit.Location = new System.Drawing.Point(35, 56);
            this.Lab_Cmb_TareDigit.Name = "Lab_Cmb_TareDigit";
            this.Lab_Cmb_TareDigit.Size = new System.Drawing.Size(89, 12);
            this.Lab_Cmb_TareDigit.TabIndex = 0;
            this.Lab_Cmb_TareDigit.Text = "皮重精确位数：";
            // 
            // Cmb_GrossRound
            // 
            this.Cmb_GrossRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_GrossRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_GrossRound.FormattingEnabled = true;
            this.Cmb_GrossRound.Location = new System.Drawing.Point(355, 10);
            this.Cmb_GrossRound.Name = "Cmb_GrossRound";
            this.Cmb_GrossRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_GrossRound.TabIndex = 2;
            this.Cmb_GrossRound.text = null;
            this.Cmb_GrossRound.value = null;
            // 
            // Lab_GrossRound
            // 
            this.Lab_GrossRound.AutoSize = true;
            this.Lab_GrossRound.Location = new System.Drawing.Point(263, 16);
            this.Lab_GrossRound.Name = "Lab_GrossRound";
            this.Lab_GrossRound.Size = new System.Drawing.Size(89, 12);
            this.Lab_GrossRound.TabIndex = 0;
            this.Lab_GrossRound.Text = "毛重取数方式：";
            // 
            // Cmb_GrossDigit
            // 
            this.Cmb_GrossDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_GrossDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_GrossDigit.FormattingEnabled = true;
            this.Cmb_GrossDigit.Location = new System.Drawing.Point(127, 10);
            this.Cmb_GrossDigit.Name = "Cmb_GrossDigit";
            this.Cmb_GrossDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_GrossDigit.TabIndex = 1;
            this.Cmb_GrossDigit.text = null;
            this.Cmb_GrossDigit.value = null;
            // 
            // Lab_Cmb_GrossDigit
            // 
            this.Lab_Cmb_GrossDigit.AutoSize = true;
            this.Lab_Cmb_GrossDigit.Location = new System.Drawing.Point(35, 16);
            this.Lab_Cmb_GrossDigit.Name = "Lab_Cmb_GrossDigit";
            this.Lab_Cmb_GrossDigit.Size = new System.Drawing.Size(89, 12);
            this.Lab_Cmb_GrossDigit.TabIndex = 0;
            this.Lab_Cmb_GrossDigit.Text = "毛重精确位数：";
            // 
            // Cmb_CubeRound
            // 
            this.Cmb_CubeRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CubeRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_CubeRound.FormattingEnabled = true;
            this.Cmb_CubeRound.Location = new System.Drawing.Point(355, 338);
            this.Cmb_CubeRound.Name = "Cmb_CubeRound";
            this.Cmb_CubeRound.Size = new System.Drawing.Size(100, 24);
            this.Cmb_CubeRound.TabIndex = 26;
            this.Cmb_CubeRound.text = null;
            this.Cmb_CubeRound.value = null;
            // 
            // Cmb_CubeDigit
            // 
            this.Cmb_CubeDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CubeDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_CubeDigit.FormattingEnabled = true;
            this.Cmb_CubeDigit.Location = new System.Drawing.Point(127, 338);
            this.Cmb_CubeDigit.Name = "Cmb_CubeDigit";
            this.Cmb_CubeDigit.Size = new System.Drawing.Size(100, 24);
            this.Cmb_CubeDigit.TabIndex = 25;
            this.Cmb_CubeDigit.text = null;
            this.Cmb_CubeDigit.value = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "折方取数方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "折方精确位数：";
            // 
            // SysParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 435);
            this.Controls.Add(this.Tc_SysPram);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SysParam";
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.SysParam_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SysParam_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Tc_SysPram.ResumeLayout(false);
            this.Tp_DataFormat.ResumeLayout(false);
            this.Tp_DataFormat.PerformLayout();
            this.Tp_NumDigit.ResumeLayout(false);
            this.Tp_NumDigit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.TabControl Tc_SysPram;
        private System.Windows.Forms.TabPage Tp_NumDigit;
        private System.Windows.Forms.TabPage Tp_DataFormat;
        private WSV.Control.MyComboBox.MyComboBox Cmb_MoneyRound;
        private System.Windows.Forms.Label Lab_MoneyRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_MoneyDigit;
        private System.Windows.Forms.Label Lab_MoneyDigit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_PriceRound;
        private System.Windows.Forms.Label Lab_PriceRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_PriceDigit;
        private System.Windows.Forms.Label Lab_PriceDigit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_EndNetRound;
        private System.Windows.Forms.Label Lab_EndNetRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_EndNetDigit;
        private System.Windows.Forms.Label Lab_EndNetDigit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_DeductRateRound;
        private System.Windows.Forms.Label Lab_DeductRateRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_DeductRateDigit;
        private System.Windows.Forms.Label Lab_DeductRateDigit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_DeductWeightRound;
        private System.Windows.Forms.Label Lab_DeductWeightRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_DeductWeightDigit;
        private System.Windows.Forms.Label Lab_DeductWeightDigit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_NetRound;
        private System.Windows.Forms.Label Lab_NetRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_NetDigit;
        private System.Windows.Forms.Label Lab_Cmb_NetDigit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_TareRound;
        private System.Windows.Forms.Label Lab_TareRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_TareDigit;
        private System.Windows.Forms.Label Lab_Cmb_TareDigit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_GrossRound;
        private System.Windows.Forms.Label Lab_GrossRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_GrossDigit;
        private System.Windows.Forms.Label Lab_Cmb_GrossDigit;
        private WSV.Control.MyComboBox.MyComboBox Cmb_EndNetMode;
        private System.Windows.Forms.Label Lab_EndNetMode;
        private WSV.Control.MyComboBox.MyComboBox Cmb_MoneyMode;
        private System.Windows.Forms.Label Lab_MoneyMode;
        private WSV.Control.MyComboBox.MyComboBox Cmb_CodeRule;
        private System.Windows.Forms.Label Lb_CodeRule;
        private WSV.Control.MyComboBox.MyComboBox Cmb_CodeWay;
        private System.Windows.Forms.Label label1;
        private WSV.Control.MyComboBox.MyComboBox Cmb_CubeRound;
        private WSV.Control.MyComboBox.MyComboBox Cmb_CubeDigit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}