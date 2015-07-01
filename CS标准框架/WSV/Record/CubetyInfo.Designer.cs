namespace WSV.Record
{
    partial class CubetyInfo
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
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_CubetyInfo = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cubety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Float_Txt_Cubety = new WSV.Control.TextBox.FloatTextBox();
            this.Com_Item = new WSV.Control.MyComboBox.MyComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Add = new System.Windows.Forms.ToolStripButton();
            this.Btn_Update = new System.Windows.Forms.ToolStripButton();
            this.Btn_Del = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CubetyInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "比重：";
            // 
            // Dgv_CubetyInfo
            // 
            this.Dgv_CubetyInfo.AllowUserToAddRows = false;
            this.Dgv_CubetyInfo.AllowUserToDeleteRows = false;
            this.Dgv_CubetyInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_CubetyInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_CubetyInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CubetyInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_Code,
            this.Col_Cubety});
            this.Dgv_CubetyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_CubetyInfo.EnterNextRow = true;
            this.Dgv_CubetyInfo.Location = new System.Drawing.Point(0, 85);
            this.Dgv_CubetyInfo.Name = "Dgv_CubetyInfo";
            this.Dgv_CubetyInfo.ReadOnly = true;
            this.Dgv_CubetyInfo.RowCode = false;
            this.Dgv_CubetyInfo.RowHeadersWidth = 20;
            this.Dgv_CubetyInfo.RowTemplate.Height = 23;
            this.Dgv_CubetyInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_CubetyInfo.Size = new System.Drawing.Size(544, 366);
            this.Dgv_CubetyInfo.TabIndex = 20;
            this.Dgv_CubetyInfo.Total = false;
            this.Dgv_CubetyInfo.TotalText = "";
            this.Dgv_CubetyInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CubetyInfo_CellClick);
            // 
            // Col_ID
            // 
            this.Col_ID.DataPropertyName = "ID";
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            // 
            // Col_Code
            // 
            this.Col_Code.DataPropertyName = "Code";
            this.Col_Code.HeaderText = "货物名称";
            this.Col_Code.Name = "Col_Code";
            this.Col_Code.ReadOnly = true;
            // 
            // Col_Cubety
            // 
            this.Col_Cubety.DataPropertyName = "Cubety";
            this.Col_Cubety.HeaderText = "折方系数";
            this.Col_Cubety.Name = "Col_Cubety";
            this.Col_Cubety.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Float_Txt_Cubety);
            this.groupBox1.Controls.Add(this.Com_Item);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 53);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Float_Txt_Cubety
            // 
            this.Float_Txt_Cubety.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Float_Txt_Cubety.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Float_Txt_Cubety.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Float_Txt_Cubety.Location = new System.Drawing.Point(351, 19);
            this.Float_Txt_Cubety.Name = "Float_Txt_Cubety";
            this.Float_Txt_Cubety.Size = new System.Drawing.Size(109, 23);
            this.Float_Txt_Cubety.TabIndex = 6;
            this.Float_Txt_Cubety.TableFlag = true;
            this.Float_Txt_Cubety.Tag = "";
            this.Float_Txt_Cubety.Text = "0";
            this.Float_Txt_Cubety.Upper = false;
            // 
            // Com_Item
            // 
            this.Com_Item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Com_Item.FormattingEnabled = true;
            this.Com_Item.Location = new System.Drawing.Point(95, 17);
            this.Com_Item.Name = "Com_Item";
            this.Com_Item.Size = new System.Drawing.Size(121, 24);
            this.Com_Item.TabIndex = 5;
            this.Com_Item.text = null;
            this.Com_Item.value = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "货名";
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
            this.Btn_Add,
            this.Btn_Update,
            this.Btn_Del,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(544, 32);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Image = global::WSV.Properties.Resources.Btn_Add;
            this.Btn_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(58, 29);
            this.Btn_Add.Text = "添加";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Image = global::WSV.Properties.Resources.Btn_Edit;
            this.Btn_Update.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(58, 29);
            this.Btn_Update.Text = "修改";
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Image = global::WSV.Properties.Resources.Btn_Delete;
            this.Btn_Del.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(58, 29);
            this.Btn_Del.Text = "删除";
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // CubetyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 451);
            this.Controls.Add(this.Dgv_CubetyInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CubetyInfo";
            this.Text = "比重管理";
            this.Load += new System.EventHandler(this.CubetyInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CubetyInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.Label label2;
        private WSV.Control.DataGridView.MyDataGridView Dgv_CubetyInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private WSV.Control.TextBox.FloatTextBox Float_Txt_Cubety;
        private WSV.Control.MyComboBox.MyComboBox Com_Item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Update;
        private System.Windows.Forms.ToolStripButton Btn_Add;
        private System.Windows.Forms.ToolStripButton Btn_Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cubety;
    }
}