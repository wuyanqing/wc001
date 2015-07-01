namespace WSV.SysInfo
{
    partial class Voice
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
            this.Lbx_Voice = new WSV.Control.MyListBox.MyListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cklx_Voice = new WSV.Control.MyCheckedListBox.MyCheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Ck_Voice = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbx_Voice
            // 
            this.Lbx_Voice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Lbx_Voice.FormattingEnabled = true;
            this.Lbx_Voice.ItemHeight = 25;
            this.Lbx_Voice.Location = new System.Drawing.Point(6, 20);
            this.Lbx_Voice.Name = "Lbx_Voice";
            this.Lbx_Voice.Size = new System.Drawing.Size(159, 354);
            this.Lbx_Voice.TabIndex = 0;
            this.Lbx_Voice.text = null;
            this.Lbx_Voice.value = null;
            this.Lbx_Voice.SelectedIndexChanged += new System.EventHandler(this.Lbx_Voice_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbx_Voice);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "语音提示项目";
            // 
            // Cklx_Voice
            // 
            this.Cklx_Voice.CheckOnClick = true;
            this.Cklx_Voice.FormattingEnabled = true;
            this.Cklx_Voice.Location = new System.Drawing.Point(6, 23);
            this.Cklx_Voice.Name = "Cklx_Voice";
            this.Cklx_Voice.Size = new System.Drawing.Size(268, 164);
            this.Cklx_Voice.TabIndex = 2;
            this.Cklx_Voice.text = null;
            this.Cklx_Voice.value = null;
            this.Cklx_Voice.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Cklx_Voice_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cklx_Voice);
            this.groupBox2.Location = new System.Drawing.Point(180, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.Location = new System.Drawing.Point(186, 256);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(75, 34);
            this.Btn_Enter.TabIndex = 4;
            this.Btn_Enter.Text = "确定";
            this.Btn_Enter.UseVisualStyleBackColor = true;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(280, 256);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 34);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "取消";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Ck_Voice
            // 
            this.Ck_Voice.AutoSize = true;
            this.Ck_Voice.Checked = true;
            this.Ck_Voice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ck_Voice.Location = new System.Drawing.Point(331, 19);
            this.Ck_Voice.Name = "Ck_Voice";
            this.Ck_Voice.Size = new System.Drawing.Size(15, 14);
            this.Ck_Voice.TabIndex = 6;
            this.Ck_Voice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "是否试听：";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(376, 256);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 34);
            this.Btn_Save.TabIndex = 8;
            this.Btn_Save.Text = "应用";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Voice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 388);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ck_Voice);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Voice";
            this.ShowInTaskbar = false;
            this.Text = "语音提示设置";
            this.Load += new System.EventHandler(this.Voice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WSV.Control.MyListBox.MyListBox Lbx_Voice;
        private System.Windows.Forms.GroupBox groupBox1;
        private Control.MyCheckedListBox.MyCheckedListBox Cklx_Voice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.CheckBox Ck_Voice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Save;
    }
}