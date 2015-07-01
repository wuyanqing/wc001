namespace WSV.Record
{
    partial class Record_BaseInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gb_BaseShow = new System.Windows.Forms.GroupBox();
            this.Tb_Rank = new WSV.Control.TextBox.TextBox();
            this.lab_Rank = new System.Windows.Forms.Label();
            this.Tb_Rem = new WSV.Control.TextBox.TextBox();
            this.lab_Rem = new System.Windows.Forms.Label();
            this.Tb_Name = new WSV.Control.TextBox.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.Tb_Code = new WSV.Control.TextBox.TextBox();
            this.lab_Code = new System.Windows.Forms.Label();
            this.Dgv_baseInfo = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Rem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lb_BaseInfo = new WSV.Control.MyListBox.MyListBox();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Add = new System.Windows.Forms.ToolStripButton();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Del = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Used = new System.Windows.Forms.ToolStripButton();
            this.Btn_NoUsed = new System.Windows.Forms.ToolStripButton();
            this.Gb_BaseShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_baseInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_BaseShow
            // 
            this.Gb_BaseShow.Controls.Add(this.Tb_Rank);
            this.Gb_BaseShow.Controls.Add(this.lab_Rank);
            this.Gb_BaseShow.Controls.Add(this.Tb_Rem);
            this.Gb_BaseShow.Controls.Add(this.lab_Rem);
            this.Gb_BaseShow.Controls.Add(this.Tb_Name);
            this.Gb_BaseShow.Controls.Add(this.lab_Name);
            this.Gb_BaseShow.Controls.Add(this.Tb_Code);
            this.Gb_BaseShow.Controls.Add(this.lab_Code);
            this.Gb_BaseShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_BaseShow.Location = new System.Drawing.Point(148, 32);
            this.Gb_BaseShow.Name = "Gb_BaseShow";
            this.Gb_BaseShow.Size = new System.Drawing.Size(383, 90);
            this.Gb_BaseShow.TabIndex = 1;
            this.Gb_BaseShow.TabStop = false;
            this.Gb_BaseShow.Text = "详细信息";
            // 
            // Tb_Rank
            // 
            this.Tb_Rank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Rank.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Rank.Location = new System.Drawing.Point(231, 58);
            this.Tb_Rank.Name = "Tb_Rank";
            this.Tb_Rank.Size = new System.Drawing.Size(94, 23);
            this.Tb_Rank.TabIndex = 3;
            this.Tb_Rank.TableFlag = true;
            this.Tb_Rank.Tag = "";
            this.Tb_Rank.Upper = false;
            // 
            // lab_Rank
            // 
            this.lab_Rank.AutoSize = true;
            this.lab_Rank.Location = new System.Drawing.Point(191, 64);
            this.lab_Rank.Name = "lab_Rank";
            this.lab_Rank.Size = new System.Drawing.Size(41, 12);
            this.lab_Rank.TabIndex = 7;
            this.lab_Rank.Text = "等级：";
            // 
            // Tb_Rem
            // 
            this.Tb_Rem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Rem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Rem.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Rem.Location = new System.Drawing.Point(66, 58);
            this.Tb_Rem.Name = "Tb_Rem";
            this.Tb_Rem.Size = new System.Drawing.Size(95, 23);
            this.Tb_Rem.TabIndex = 2;
            this.Tb_Rem.TableFlag = true;
            this.Tb_Rem.Tag = "";
            this.Tb_Rem.Upper = false;
            // 
            // lab_Rem
            // 
            this.lab_Rem.AutoSize = true;
            this.lab_Rem.Location = new System.Drawing.Point(26, 64);
            this.lab_Rem.Name = "lab_Rem";
            this.lab_Rem.Size = new System.Drawing.Size(41, 12);
            this.lab_Rem.TabIndex = 5;
            this.lab_Rem.Text = "简码：";
            // 
            // Tb_Name
            // 
            this.Tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tb_Name.Location = new System.Drawing.Point(231, 20);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(94, 23);
            this.Tb_Name.TabIndex = 1;
            this.Tb_Name.TableFlag = true;
            this.Tb_Name.Tag = "";
            this.Tb_Name.Upper = false;
            this.Tb_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tb_Name_KeyUp);
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(191, 26);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(41, 12);
            this.lab_Name.TabIndex = 2;
            this.lab_Name.Text = "名称：";
            // 
            // Tb_Code
            // 
            this.Tb_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Code.Location = new System.Drawing.Point(66, 20);
            this.Tb_Code.Name = "Tb_Code";
            this.Tb_Code.Size = new System.Drawing.Size(95, 23);
            this.Tb_Code.TabIndex = 0;
            this.Tb_Code.TableFlag = true;
            this.Tb_Code.Tag = "";
            this.Tb_Code.Upper = false;
            this.Tb_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Code_KeyPress);
            // 
            // lab_Code
            // 
            this.lab_Code.AutoSize = true;
            this.lab_Code.Location = new System.Drawing.Point(26, 26);
            this.lab_Code.Name = "lab_Code";
            this.lab_Code.Size = new System.Drawing.Size(41, 12);
            this.lab_Code.TabIndex = 0;
            this.lab_Code.Text = "编号：";
            // 
            // Dgv_baseInfo
            // 
            this.Dgv_baseInfo.AllowUserToAddRows = false;
            this.Dgv_baseInfo.AllowUserToDeleteRows = false;
            this.Dgv_baseInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_baseInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_baseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_baseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_CodeID,
            this.Col_Name,
            this.Col_Rem});
            this.Dgv_baseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_baseInfo.EnterNextRow = true;
            this.Dgv_baseInfo.Location = new System.Drawing.Point(148, 122);
            this.Dgv_baseInfo.MultiSelect = false;
            this.Dgv_baseInfo.Name = "Dgv_baseInfo";
            this.Dgv_baseInfo.ReadOnly = true;
            this.Dgv_baseInfo.RowCode = true;
            this.Dgv_baseInfo.RowTemplate.Height = 23;
            this.Dgv_baseInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_baseInfo.Size = new System.Drawing.Size(383, 291);
            this.Dgv_baseInfo.TabIndex = 4;
            this.Dgv_baseInfo.Total = false;
            this.Dgv_baseInfo.TotalText = "";
            this.Dgv_baseInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_baseInfo_CellClick);
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "ID";
            this.Col_Id.HeaderText = "ID";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Visible = false;
            // 
            // Col_CodeID
            // 
            this.Col_CodeID.DataPropertyName = "CodeID";
            this.Col_CodeID.HeaderText = "编号";
            this.Col_CodeID.Name = "Col_CodeID";
            this.Col_CodeID.ReadOnly = true;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "名称";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            // 
            // Col_Rem
            // 
            this.Col_Rem.DataPropertyName = "Rem";
            this.Col_Rem.HeaderText = "简码";
            this.Col_Rem.Name = "Col_Rem";
            this.Col_Rem.ReadOnly = true;
            // 
            // Lb_BaseInfo
            // 
            this.Lb_BaseInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lb_BaseInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Lb_BaseInfo.FormattingEnabled = true;
            this.Lb_BaseInfo.ItemHeight = 25;
            this.Lb_BaseInfo.Location = new System.Drawing.Point(0, 32);
            this.Lb_BaseInfo.Name = "Lb_BaseInfo";
            this.Lb_BaseInfo.Size = new System.Drawing.Size(148, 379);
            this.Lb_BaseInfo.TabIndex = 2;
            this.Lb_BaseInfo.text = null;
            this.Lb_BaseInfo.value = null;
            this.Lb_BaseInfo.SelectedIndexChanged += new System.EventHandler(this.Lb_BaseInfo_SelectedIndexChanged);
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
            this.Btn_Save,
            this.Btn_Del,
            this.Btn_Fresh,
            this.Btn_Used,
            this.Btn_NoUsed,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(531, 32);
            this.toolStrip1.TabIndex = 13;
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
            // Btn_Save
            // 
            this.Btn_Save.Image = global::WSV.Properties.Resources.Btn_Save;
            this.Btn_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(58, 29);
            this.Btn_Save.Text = "修改";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
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
            // Btn_Used
            // 
            this.Btn_Used.Image = global::WSV.Properties.Resources.Btn_IsUsed;
            this.Btn_Used.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Used.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Used.Name = "Btn_Used";
            this.Btn_Used.Size = new System.Drawing.Size(58, 29);
            this.Btn_Used.Text = "作废";
            this.Btn_Used.Click += new System.EventHandler(this.Btn_Used_Click);
            // 
            // Btn_NoUsed
            // 
            this.Btn_NoUsed.Image = global::WSV.Properties.Resources.Btn_Edit;
            this.Btn_NoUsed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_NoUsed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_NoUsed.Name = "Btn_NoUsed";
            this.Btn_NoUsed.Size = new System.Drawing.Size(70, 29);
            this.Btn_NoUsed.Text = "反作废";
            this.Btn_NoUsed.Click += new System.EventHandler(this.Btn_NoUsed_Click);
            // 
            // Record_BaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 413);
            this.Controls.Add(this.Dgv_baseInfo);
            this.Controls.Add(this.Gb_BaseShow);
            this.Controls.Add(this.Lb_BaseInfo);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Record_BaseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "档案信息";
            this.Load += new System.EventHandler(this.Record_BaseInfo_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Record_BaseInfo_FormClosed);
            this.Gb_BaseShow.ResumeLayout(false);
            this.Gb_BaseShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_baseInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_BaseShow;
        private WSV.Control.TextBox.TextBox Tb_Code;
        private System.Windows.Forms.Label lab_Code;
        private WSV.Control.TextBox.TextBox Tb_Name;
        private System.Windows.Forms.Label lab_Name;
        private WSV.Control.MyListBox.MyListBox Lb_BaseInfo;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Add;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Del;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private WSV.Control.DataGridView.MyDataGridView Dgv_baseInfo;
        private WSV.Control.TextBox.TextBox Tb_Rank;
        private System.Windows.Forms.Label lab_Rank;
        private WSV.Control.TextBox.TextBox Tb_Rem;
        private System.Windows.Forms.Label lab_Rem;
        private System.Windows.Forms.ToolStripButton Btn_Used;
        private System.Windows.Forms.ToolStripButton Btn_NoUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Rem;
    }
}