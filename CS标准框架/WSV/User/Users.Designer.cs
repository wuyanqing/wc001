namespace WSV.User
{
    partial class Users
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
            this.Btn_Add = new System.Windows.Forms.ToolStripButton();
            this.Btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Del = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.Lab_Code = new System.Windows.Forms.Label();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Lab_Uid = new System.Windows.Forms.Label();
            this.Lab_Pwd = new System.Windows.Forms.Label();
            this.Lab_Role = new System.Windows.Forms.Label();
            this.Lab_Used = new System.Windows.Forms.Label();
            this.Cb_Used = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tb_Uid = new WSV.Control.TextBox.TextBox();
            this.Cmb_Role = new WSV.Control.MyComboBox.MyComboBox();
            this.Tb_Code = new WSV.Control.TextBox.TextBox();
            this.Tb_Pwd = new WSV.Control.TextBox.TextBox();
            this.Tb_Name = new WSV.Control.TextBox.TextBox();
            this.Gv_Users = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Used = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Add,
            this.Btn_Edit,
            this.Btn_Save,
            this.Btn_Del,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(622, 32);
            this.toolStrip1.TabIndex = 0;
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
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::WSV.Properties.Resources.Btn_Edit;
            this.Btn_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(58, 29);
            this.Btn_Edit.Text = "修改";
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
            // Lab_Code
            // 
            this.Lab_Code.AutoSize = true;
            this.Lab_Code.Location = new System.Drawing.Point(27, 32);
            this.Lab_Code.Name = "Lab_Code";
            this.Lab_Code.Size = new System.Drawing.Size(41, 12);
            this.Lab_Code.TabIndex = 0;
            this.Lab_Code.Text = "编号：";
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Location = new System.Drawing.Point(203, 32);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(41, 12);
            this.Lab_Name.TabIndex = 0;
            this.Lab_Name.Text = "姓名：";
            // 
            // Lab_Uid
            // 
            this.Lab_Uid.AutoSize = true;
            this.Lab_Uid.Location = new System.Drawing.Point(374, 33);
            this.Lab_Uid.Name = "Lab_Uid";
            this.Lab_Uid.Size = new System.Drawing.Size(53, 12);
            this.Lab_Uid.TabIndex = 0;
            this.Lab_Uid.Text = "用户名：";
            // 
            // Lab_Pwd
            // 
            this.Lab_Pwd.AutoSize = true;
            this.Lab_Pwd.Location = new System.Drawing.Point(27, 68);
            this.Lab_Pwd.Name = "Lab_Pwd";
            this.Lab_Pwd.Size = new System.Drawing.Size(41, 12);
            this.Lab_Pwd.TabIndex = 0;
            this.Lab_Pwd.Text = "密码：";
            // 
            // Lab_Role
            // 
            this.Lab_Role.AutoSize = true;
            this.Lab_Role.Location = new System.Drawing.Point(203, 69);
            this.Lab_Role.Name = "Lab_Role";
            this.Lab_Role.Size = new System.Drawing.Size(41, 12);
            this.Lab_Role.TabIndex = 0;
            this.Lab_Role.Text = "角色：";
            // 
            // Lab_Used
            // 
            this.Lab_Used.AutoSize = true;
            this.Lab_Used.Location = new System.Drawing.Point(374, 69);
            this.Lab_Used.Name = "Lab_Used";
            this.Lab_Used.Size = new System.Drawing.Size(53, 12);
            this.Lab_Used.TabIndex = 0;
            this.Lab_Used.Text = "已启用：";
            // 
            // Cb_Used
            // 
            this.Cb_Used.AutoSize = true;
            this.Cb_Used.Checked = true;
            this.Cb_Used.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_Used.Location = new System.Drawing.Point(429, 68);
            this.Cb_Used.Name = "Cb_Used";
            this.Cb_Used.Size = new System.Drawing.Size(15, 14);
            this.Cb_Used.TabIndex = 6;
            this.Cb_Used.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tb_Uid);
            this.groupBox1.Controls.Add(this.Cb_Used);
            this.groupBox1.Controls.Add(this.Lab_Code);
            this.groupBox1.Controls.Add(this.Cmb_Role);
            this.groupBox1.Controls.Add(this.Tb_Code);
            this.groupBox1.Controls.Add(this.Tb_Pwd);
            this.groupBox1.Controls.Add(this.Lab_Name);
            this.groupBox1.Controls.Add(this.Lab_Uid);
            this.groupBox1.Controls.Add(this.Tb_Name);
            this.groupBox1.Controls.Add(this.Lab_Pwd);
            this.groupBox1.Controls.Add(this.Lab_Used);
            this.groupBox1.Controls.Add(this.Lab_Role);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // Tb_Uid
            // 
            this.Tb_Uid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Uid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Uid.Location = new System.Drawing.Point(429, 29);
            this.Tb_Uid.Name = "Tb_Uid";
            this.Tb_Uid.Size = new System.Drawing.Size(100, 23);
            this.Tb_Uid.TabIndex = 3;
            this.Tb_Uid.TableFlag = true;
            this.Tb_Uid.Tag = "";
            this.Tb_Uid.Upper = false;
            // 
            // Cmb_Role
            // 
            this.Cmb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Role.FormattingEnabled = true;
            this.Cmb_Role.Location = new System.Drawing.Point(247, 63);
            this.Cmb_Role.Name = "Cmb_Role";
            this.Cmb_Role.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Role.TabIndex = 5;
            this.Cmb_Role.text = null;
            this.Cmb_Role.value = null;
            // 
            // Tb_Code
            // 
            this.Tb_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Code.Location = new System.Drawing.Point(71, 28);
            this.Tb_Code.Name = "Tb_Code";
            this.Tb_Code.Size = new System.Drawing.Size(100, 23);
            this.Tb_Code.TabIndex = 1;
            this.Tb_Code.TableFlag = true;
            this.Tb_Code.Tag = "";
            this.Tb_Code.Upper = false;
            // 
            // Tb_Pwd
            // 
            this.Tb_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Pwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Pwd.Location = new System.Drawing.Point(71, 64);
            this.Tb_Pwd.Name = "Tb_Pwd";
            this.Tb_Pwd.Size = new System.Drawing.Size(100, 23);
            this.Tb_Pwd.TabIndex = 4;
            this.Tb_Pwd.TableFlag = true;
            this.Tb_Pwd.Tag = "";
            this.Tb_Pwd.Upper = false;
            this.Tb_Pwd.UseSystemPasswordChar = true;
            // 
            // Tb_Name
            // 
            this.Tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tb_Name.Location = new System.Drawing.Point(247, 28);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(100, 23);
            this.Tb_Name.TabIndex = 2;
            this.Tb_Name.TableFlag = true;
            this.Tb_Name.Tag = "";
            this.Tb_Name.Upper = false;
            // 
            // Gv_Users
            // 
            this.Gv_Users.AllowUserToAddRows = false;
            this.Gv_Users.AllowUserToDeleteRows = false;
            this.Gv_Users.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Code,
            this.Col_Name,
            this.Col_Uid,
            this.Col_Pwd,
            this.Col_Role,
            this.Col_RoleName,
            this.Col_Used});
            this.Gv_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gv_Users.EnterNextRow = true;
            this.Gv_Users.Location = new System.Drawing.Point(0, 132);
            this.Gv_Users.Name = "Gv_Users";
            this.Gv_Users.ReadOnly = true;
            this.Gv_Users.RowCode = false;
            this.Gv_Users.RowHeadersWidth = 20;
            this.Gv_Users.RowTemplate.Height = 23;
            this.Gv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gv_Users.Size = new System.Drawing.Size(622, 284);
            this.Gv_Users.TabIndex = 0;
            this.Gv_Users.Total = false;
            this.Gv_Users.TotalText = "";
            this.Gv_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Users_CellClick);
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
            // Col_Uid
            // 
            this.Col_Uid.DataPropertyName = "Uid";
            this.Col_Uid.HeaderText = "用户名";
            this.Col_Uid.Name = "Col_Uid";
            this.Col_Uid.ReadOnly = true;
            // 
            // Col_Pwd
            // 
            this.Col_Pwd.DataPropertyName = "Pwd";
            this.Col_Pwd.HeaderText = "密码";
            this.Col_Pwd.Name = "Col_Pwd";
            this.Col_Pwd.ReadOnly = true;
            this.Col_Pwd.Visible = false;
            // 
            // Col_Role
            // 
            this.Col_Role.DataPropertyName = "Role";
            this.Col_Role.HeaderText = "角色编号";
            this.Col_Role.Name = "Col_Role";
            this.Col_Role.ReadOnly = true;
            this.Col_Role.Visible = false;
            // 
            // Col_RoleName
            // 
            this.Col_RoleName.DataPropertyName = "RoleName";
            this.Col_RoleName.HeaderText = "角色";
            this.Col_RoleName.Name = "Col_RoleName";
            this.Col_RoleName.ReadOnly = true;
            // 
            // Col_Used
            // 
            this.Col_Used.DataPropertyName = "Used";
            this.Col_Used.HeaderText = "已启用";
            this.Col_Used.Name = "Col_Used";
            this.Col_Used.ReadOnly = true;
            this.Col_Used.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Used.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 416);
            this.Controls.Add(this.Gv_Users);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作员";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            this.Load += new System.EventHandler(this.Users_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Add;
        private System.Windows.Forms.ToolStripButton Btn_Del;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.ToolStripButton Btn_Edit;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private WSV.Control.DataGridView.MyDataGridView Gv_Users;
        private System.Windows.Forms.Label Lab_Code;
        private System.Windows.Forms.Label Lab_Name;
        private System.Windows.Forms.Label Lab_Uid;
        private System.Windows.Forms.Label Lab_Pwd;
        private System.Windows.Forms.Label Lab_Role;
        private System.Windows.Forms.Label Lab_Used;
        private WSV.Control.TextBox.TextBox Tb_Code;
        private WSV.Control.TextBox.TextBox Tb_Name;
        private WSV.Control.TextBox.TextBox Tb_Uid;
        private WSV.Control.TextBox.TextBox Tb_Pwd;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Role;
        private System.Windows.Forms.CheckBox Cb_Used;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_RoleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Used;
    }
}