namespace delivery
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.lbcarcode = new System.Windows.Forms.Label();
            this.lbbillno = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.txbcarcode = new System.Windows.Forms.TextBox();
            this.txbphone = new System.Windows.Forms.TextBox();
            this.txbbillno = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cobaddress = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbcarcode
            // 
            this.lbcarcode.AutoSize = true;
            this.lbcarcode.Font = new System.Drawing.Font("宋体", 16F);
            this.lbcarcode.Location = new System.Drawing.Point(21, 22);
            this.lbcarcode.Name = "lbcarcode";
            this.lbcarcode.Size = new System.Drawing.Size(120, 22);
            this.lbcarcode.TabIndex = 0;
            this.lbcarcode.Text = "车辆牌号：";
            // 
            // lbbillno
            // 
            this.lbbillno.AutoSize = true;
            this.lbbillno.Font = new System.Drawing.Font("宋体", 16F);
            this.lbbillno.Location = new System.Drawing.Point(23, 108);
            this.lbbillno.Name = "lbbillno";
            this.lbbillno.Size = new System.Drawing.Size(109, 22);
            this.lbbillno.TabIndex = 2;
            this.lbbillno.Text = "送货单号:";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Font = new System.Drawing.Font("宋体", 16F);
            this.lbaddress.Location = new System.Drawing.Point(21, 67);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(120, 22);
            this.lbaddress.TabIndex = 1;
            this.lbaddress.Text = "中烟信息：";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Font = new System.Drawing.Font("宋体", 16F);
            this.lbphone.Location = new System.Drawing.Point(23, 154);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(120, 22);
            this.lbphone.TabIndex = 3;
            this.lbphone.Text = "联系方式：";
            // 
            // txbcarcode
            // 
            this.txbcarcode.Font = new System.Drawing.Font("宋体", 12F);
            this.txbcarcode.Location = new System.Drawing.Point(148, 22);
            this.txbcarcode.Name = "txbcarcode";
            this.txbcarcode.Size = new System.Drawing.Size(155, 26);
            this.txbcarcode.TabIndex = 4;
            // 
            // txbphone
            // 
            this.txbphone.Font = new System.Drawing.Font("宋体", 12F);
            this.txbphone.Location = new System.Drawing.Point(149, 150);
            this.txbphone.Name = "txbphone";
            this.txbphone.Size = new System.Drawing.Size(196, 26);
            this.txbphone.TabIndex = 7;
            // 
            // txbbillno
            // 
            this.txbbillno.Font = new System.Drawing.Font("宋体", 12F);
            this.txbbillno.Location = new System.Drawing.Point(148, 109);
            this.txbbillno.Name = "txbbillno";
            this.txbbillno.Size = new System.Drawing.Size(196, 26);
            this.txbbillno.TabIndex = 6;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("宋体", 12F);
            this.btnadd.Location = new System.Drawing.Point(97, 225);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 40);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "保存";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("宋体", 12F);
            this.btncancel.Location = new System.Drawing.Point(228, 225);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 40);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            this.btncancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btncancel_KeyPress);
            // 
            // cobaddress
            // 
            this.cobaddress.Font = new System.Drawing.Font("宋体", 12F);
            this.cobaddress.FormattingEnabled = true;
            this.cobaddress.Location = new System.Drawing.Point(149, 67);
            this.cobaddress.Name = "cobaddress";
            this.cobaddress.Size = new System.Drawing.Size(156, 24);
            this.cobaddress.TabIndex = 10;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 277);
            this.Controls.Add(this.cobaddress);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txbbillno);
            this.Controls.Add(this.txbphone);
            this.Controls.Add(this.txbcarcode);
            this.Controls.Add(this.lbphone);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbbillno);
            this.Controls.Add(this.lbcarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.Text = "送货登记";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcarcode;
        private System.Windows.Forms.Label lbbillno;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.TextBox txbcarcode;
        private System.Windows.Forms.TextBox txbphone;
        private System.Windows.Forms.TextBox txbbillno;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox cobaddress;
    }
}

