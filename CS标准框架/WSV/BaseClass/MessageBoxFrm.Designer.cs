namespace WSV.BaseClass
{
    partial class MessageBoxFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxFrm));
            this.lab_Show = new System.Windows.Forms.Label();
            this.txt_Mess = new System.Windows.Forms.TextBox();
            this.But_Ok = new System.Windows.Forms.Button();
            this.But_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Show
            // 
            this.lab_Show.Location = new System.Drawing.Point(18, 9);
            this.lab_Show.Name = "lab_Show";
            this.lab_Show.Size = new System.Drawing.Size(258, 16);
            this.lab_Show.TabIndex = 0;
            this.lab_Show.Text = "label1";
            this.lab_Show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Mess
            // 
            this.txt_Mess.Location = new System.Drawing.Point(18, 33);
            this.txt_Mess.Multiline = true;
            this.txt_Mess.Name = "txt_Mess";
            this.txt_Mess.Size = new System.Drawing.Size(258, 45);
            this.txt_Mess.TabIndex = 1;
            // 
            // But_Ok
            // 
            this.But_Ok.Location = new System.Drawing.Point(120, 91);
            this.But_Ok.Name = "But_Ok";
            this.But_Ok.Size = new System.Drawing.Size(75, 25);
            this.But_Ok.TabIndex = 2;
            this.But_Ok.Text = "确定";
            this.But_Ok.UseVisualStyleBackColor = true;
            this.But_Ok.Click += new System.EventHandler(this.But_Ok_Click);
            // 
            // But_Cancel
            // 
            this.But_Cancel.Location = new System.Drawing.Point(201, 91);
            this.But_Cancel.Name = "But_Cancel";
            this.But_Cancel.Size = new System.Drawing.Size(75, 25);
            this.But_Cancel.TabIndex = 3;
            this.But_Cancel.Text = "取消";
            this.But_Cancel.UseVisualStyleBackColor = true;
            this.But_Cancel.Click += new System.EventHandler(this.But_Cancel_Click);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 124);
            this.Controls.Add(this.But_Cancel);
            this.Controls.Add(this.But_Ok);
            this.Controls.Add(this.txt_Mess);
            this.Controls.Add(this.lab_Show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBox";
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.MessageBoxFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Show;
        private System.Windows.Forms.TextBox txt_Mess;
        private System.Windows.Forms.Button But_Ok;
        private System.Windows.Forms.Button But_Cancel;
    }
}