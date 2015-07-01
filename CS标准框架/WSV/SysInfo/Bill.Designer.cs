namespace WSV.SysInfo
{
    partial class Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.Gv_Bill = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PrintTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Preview = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tb_Name = new WSV.Control.TextBox.TextBox();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Tb_Code = new WSV.Control.TextBox.TextBox();
            this.Lab_Code = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_PrintMend = new WSV.Control.TextBox.TextBox();
            this.lab_PrintMend = new System.Windows.Forms.Label();
            this.Cb_Preview = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_BillName = new WSV.Control.MyComboBox.MyComboBox();
            this.Tb_PrintTitle = new WSV.Control.TextBox.TextBox();
            this.Lab_PrintTitle = new System.Windows.Forms.Label();
            this.Lab_BillName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Bill)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(690, 32);
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
            // Gv_Bill
            // 
            this.Gv_Bill.AllowUserToAddRows = false;
            this.Gv_Bill.AllowUserToDeleteRows = false;
            this.Gv_Bill.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Code,
            this.Col_Name,
            this.Col_BillName,
            this.Col_PrintTitle,
            this.Col_Preview});
            this.Gv_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gv_Bill.EnterNextRow = true;
            this.Gv_Bill.Location = new System.Drawing.Point(0, 129);
            this.Gv_Bill.Name = "Gv_Bill";
            this.Gv_Bill.ReadOnly = true;
            this.Gv_Bill.RowCode = false;
            this.Gv_Bill.RowHeadersWidth = 20;
            this.Gv_Bill.RowTemplate.Height = 23;
            this.Gv_Bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gv_Bill.Size = new System.Drawing.Size(690, 362);
            this.Gv_Bill.TabIndex = 3;
            this.Gv_Bill.Total = false;
            this.Gv_Bill.TotalText = "";
            this.Gv_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Bill_CellClick);
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "Id";
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Visible = false;
            // 
            // Col_Code
            // 
            this.Col_Code.DataPropertyName = "Code";
            this.Col_Code.HeaderText = "编号";
            this.Col_Code.Name = "Col_Code";
            this.Col_Code.ReadOnly = true;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "名称";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            // 
            // Col_BillName
            // 
            this.Col_BillName.DataPropertyName = "BillName";
            this.Col_BillName.HeaderText = "磅单";
            this.Col_BillName.Name = "Col_BillName";
            this.Col_BillName.ReadOnly = true;
            this.Col_BillName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_BillName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_PrintTitle
            // 
            this.Col_PrintTitle.DataPropertyName = "PrintTitle";
            this.Col_PrintTitle.HeaderText = "打印标题";
            this.Col_PrintTitle.Name = "Col_PrintTitle";
            this.Col_PrintTitle.ReadOnly = true;
            this.Col_PrintTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_PrintTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Preview
            // 
            this.Col_Preview.DataPropertyName = "Preview";
            this.Col_Preview.HeaderText = "是否预览";
            this.Col_Preview.Name = "Col_Preview";
            this.Col_Preview.ReadOnly = true;
            // 
            // Tb_Name
            // 
            this.Tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Name.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Name.Location = new System.Drawing.Point(262, 20);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.ReadOnly = true;
            this.Tb_Name.Size = new System.Drawing.Size(100, 23);
            this.Tb_Name.TabIndex = 2;
            this.Tb_Name.TableFlag = true;
            this.Tb_Name.Tag = "";
            this.Tb_Name.Upper = false;
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Location = new System.Drawing.Point(218, 24);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(41, 12);
            this.Lab_Name.TabIndex = 0;
            this.Lab_Name.Text = "名称：";
            // 
            // Tb_Code
            // 
            this.Tb_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Code.Location = new System.Drawing.Point(82, 20);
            this.Tb_Code.Name = "Tb_Code";
            this.Tb_Code.ReadOnly = true;
            this.Tb_Code.Size = new System.Drawing.Size(100, 23);
            this.Tb_Code.TabIndex = 1;
            this.Tb_Code.TableFlag = true;
            this.Tb_Code.Tag = "";
            this.Tb_Code.Upper = false;
            // 
            // Lab_Code
            // 
            this.Lab_Code.AutoSize = true;
            this.Lab_Code.Location = new System.Drawing.Point(38, 24);
            this.Lab_Code.Name = "Lab_Code";
            this.Lab_Code.Size = new System.Drawing.Size(41, 12);
            this.Lab_Code.TabIndex = 0;
            this.Lab_Code.Text = "编号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_PrintMend);
            this.groupBox1.Controls.Add(this.lab_PrintMend);
            this.groupBox1.Controls.Add(this.Cb_Preview);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cmb_BillName);
            this.groupBox1.Controls.Add(this.Tb_PrintTitle);
            this.groupBox1.Controls.Add(this.Lab_PrintTitle);
            this.groupBox1.Controls.Add(this.Lab_BillName);
            this.groupBox1.Controls.Add(this.Lab_Code);
            this.groupBox1.Controls.Add(this.Tb_Code);
            this.groupBox1.Controls.Add(this.Lab_Name);
            this.groupBox1.Controls.Add(this.Tb_Name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // Txt_PrintMend
            // 
            this.Txt_PrintMend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_PrintMend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_PrintMend.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Txt_PrintMend.Location = new System.Drawing.Point(450, 63);
            this.Txt_PrintMend.Name = "Txt_PrintMend";
            this.Txt_PrintMend.Size = new System.Drawing.Size(121, 23);
            this.Txt_PrintMend.TabIndex = 8;
            this.Txt_PrintMend.TableFlag = true;
            this.Txt_PrintMend.Tag = "";
            this.Txt_PrintMend.Upper = false;
            // 
            // lab_PrintMend
            // 
            this.lab_PrintMend.AutoSize = true;
            this.lab_PrintMend.Location = new System.Drawing.Point(381, 68);
            this.lab_PrintMend.Name = "lab_PrintMend";
            this.lab_PrintMend.Size = new System.Drawing.Size(65, 12);
            this.lab_PrintMend.TabIndex = 7;
            this.lab_PrintMend.Text = "补打标识：";
            // 
            // Cb_Preview
            // 
            this.Cb_Preview.AutoSize = true;
            this.Cb_Preview.Checked = true;
            this.Cb_Preview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_Preview.Location = new System.Drawing.Point(654, 67);
            this.Cb_Preview.Name = "Cb_Preview";
            this.Cb_Preview.Size = new System.Drawing.Size(15, 14);
            this.Cb_Preview.TabIndex = 5;
            this.Cb_Preview.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "是否预览：";
            // 
            // Cmb_BillName
            // 
            this.Cmb_BillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_BillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_BillName.FormattingEnabled = true;
            this.Cmb_BillName.Location = new System.Drawing.Point(450, 20);
            this.Cmb_BillName.Name = "Cmb_BillName";
            this.Cmb_BillName.Size = new System.Drawing.Size(121, 24);
            this.Cmb_BillName.TabIndex = 3;
            this.Cmb_BillName.text = null;
            this.Cmb_BillName.value = null;
            // 
            // Tb_PrintTitle
            // 
            this.Tb_PrintTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_PrintTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_PrintTitle.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tb_PrintTitle.Location = new System.Drawing.Point(82, 63);
            this.Tb_PrintTitle.Name = "Tb_PrintTitle";
            this.Tb_PrintTitle.Size = new System.Drawing.Size(280, 23);
            this.Tb_PrintTitle.TabIndex = 4;
            this.Tb_PrintTitle.TableFlag = true;
            this.Tb_PrintTitle.Tag = "";
            this.Tb_PrintTitle.Upper = false;
            // 
            // Lab_PrintTitle
            // 
            this.Lab_PrintTitle.AutoSize = true;
            this.Lab_PrintTitle.Location = new System.Drawing.Point(14, 68);
            this.Lab_PrintTitle.Name = "Lab_PrintTitle";
            this.Lab_PrintTitle.Size = new System.Drawing.Size(65, 12);
            this.Lab_PrintTitle.TabIndex = 0;
            this.Lab_PrintTitle.Text = "打印标题：";
            // 
            // Lab_BillName
            // 
            this.Lab_BillName.AutoSize = true;
            this.Lab_BillName.Location = new System.Drawing.Point(405, 25);
            this.Lab_BillName.Name = "Lab_BillName";
            this.Lab_BillName.Size = new System.Drawing.Size(41, 12);
            this.Lab_BillName.TabIndex = 0;
            this.Lab_BillName.Text = "磅单：";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 491);
            this.Controls.Add(this.Gv_Bill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Bill";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bill_FormClosed);
            this.Load += new System.EventHandler(this.Bill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Bill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private WSV.Control.DataGridView.MyDataGridView Gv_Bill;
        private WSV.Control.TextBox.TextBox Tb_Name;
        private System.Windows.Forms.Label Lab_Name;
        private WSV.Control.TextBox.TextBox Tb_Code;
        private System.Windows.Forms.Label Lab_Code;
        private System.Windows.Forms.GroupBox groupBox1;
        private WSV.Control.TextBox.TextBox Tb_PrintTitle;
        private System.Windows.Forms.Label Lab_PrintTitle;
        private System.Windows.Forms.Label Lab_BillName;
        private WSV.Control.MyComboBox.MyComboBox Cmb_BillName;
        private System.Windows.Forms.CheckBox Cb_Preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PrintTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Preview;
        private System.Windows.Forms.Label lab_PrintMend;
        private WSV.Control.TextBox.TextBox Txt_PrintMend;
    }
}