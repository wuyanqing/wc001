namespace WSV.SysInfo
{
    partial class BillInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillInfo));
            this.tool_BillInfo = new System.Windows.Forms.ToolStrip();
            this.Btn_Design = new System.Windows.Forms.ToolStripButton();
            this.Btn_Preview = new System.Windows.Forms.ToolStripButton();
            this.Btn_line1 = new System.Windows.Forms.ToolStripSeparator();
            this.But_ReName = new System.Windows.Forms.ToolStripButton();
            this.But_Del = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.list_AllBill = new WSV.Control.MyListBox.MyListBox();
            this.gbx_AllBill = new System.Windows.Forms.GroupBox();
            this.Image_AllBill = new System.Windows.Forms.ImageList(this.components);
            this.gbx_db = new System.Windows.Forms.GroupBox();
            this.gv_DB = new System.Windows.Forms.DataGridView();
            this.tool_BillInfo.SuspendLayout();
            this.gbx_AllBill.SuspendLayout();
            this.gbx_db.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // tool_BillInfo
            // 
            this.tool_BillInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Design,
            this.Btn_Preview,
            this.Btn_line1,
            this.But_ReName,
            this.But_Del,
            this.toolStripSeparator1,
            this.Btn_Exit});
            this.tool_BillInfo.Location = new System.Drawing.Point(0, 0);
            this.tool_BillInfo.Name = "tool_BillInfo";
            this.tool_BillInfo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tool_BillInfo.Size = new System.Drawing.Size(557, 32);
            this.tool_BillInfo.TabIndex = 2;
            this.tool_BillInfo.Text = "toolStrip1";
            // 
            // Btn_Design
            // 
            this.Btn_Design.Image = global::WSV.Properties.Resources.Btn_Design;
            this.Btn_Design.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Design.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Design.Name = "Btn_Design";
            this.Btn_Design.Size = new System.Drawing.Size(58, 29);
            this.Btn_Design.Text = "设计";
            this.Btn_Design.Click += new System.EventHandler(this.Btn_Design_Click);
            // 
            // Btn_Preview
            // 
            this.Btn_Preview.Image = global::WSV.Properties.Resources.Btn_Preview1;
            this.Btn_Preview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Preview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Preview.Name = "Btn_Preview";
            this.Btn_Preview.Size = new System.Drawing.Size(58, 29);
            this.Btn_Preview.Text = "预览";
            this.Btn_Preview.Click += new System.EventHandler(this.Btn_Preview_Click);
            // 
            // Btn_line1
            // 
            this.Btn_line1.Name = "Btn_line1";
            this.Btn_line1.Size = new System.Drawing.Size(6, 32);
            // 
            // But_ReName
            // 
            this.But_ReName.Image = global::WSV.Properties.Resources.But_ReName;
            this.But_ReName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.But_ReName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.But_ReName.Name = "But_ReName";
            this.But_ReName.Size = new System.Drawing.Size(94, 29);
            this.But_ReName.Text = "修改文件名";
            this.But_ReName.Click += new System.EventHandler(this.But_ReName_Click);
            // 
            // But_Del
            // 
            this.But_Del.Image = global::WSV.Properties.Resources.Btn_Delete;
            this.But_Del.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.But_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.But_Del.Name = "But_Del";
            this.But_Del.Size = new System.Drawing.Size(58, 29);
            this.But_Del.Text = "删除";
            this.But_Del.Click += new System.EventHandler(this.But_Del_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
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
            // list_AllBill
            // 
            this.list_AllBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_AllBill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.list_AllBill.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_AllBill.FormattingEnabled = true;
            this.list_AllBill.ItemHeight = 25;
            this.list_AllBill.Location = new System.Drawing.Point(3, 17);
            this.list_AllBill.Name = "list_AllBill";
            this.list_AllBill.Size = new System.Drawing.Size(154, 329);
            this.list_AllBill.TabIndex = 3;
            this.list_AllBill.text = null;
            this.list_AllBill.value = null;
            this.list_AllBill.SelectedIndexChanged += new System.EventHandler(this.list_AllBill_SelectedIndexChanged);
            // 
            // gbx_AllBill
            // 
            this.gbx_AllBill.Controls.Add(this.list_AllBill);
            this.gbx_AllBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbx_AllBill.Location = new System.Drawing.Point(0, 32);
            this.gbx_AllBill.Name = "gbx_AllBill";
            this.gbx_AllBill.Size = new System.Drawing.Size(160, 359);
            this.gbx_AllBill.TabIndex = 4;
            this.gbx_AllBill.TabStop = false;
            this.gbx_AllBill.Text = "所有磅单";
            // 
            // Image_AllBill
            // 
            this.Image_AllBill.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Image_AllBill.ImageStream")));
            this.Image_AllBill.TransparentColor = System.Drawing.Color.Transparent;
            this.Image_AllBill.Images.SetKeyName(0, "But_Bill.png");
            // 
            // gbx_db
            // 
            this.gbx_db.Controls.Add(this.gv_DB);
            this.gbx_db.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_db.Location = new System.Drawing.Point(160, 32);
            this.gbx_db.Name = "gbx_db";
            this.gbx_db.Size = new System.Drawing.Size(397, 359);
            this.gbx_db.TabIndex = 5;
            this.gbx_db.TabStop = false;
            this.gbx_db.Text = "设计数据";
            // 
            // gv_DB
            // 
            this.gv_DB.AllowUserToAddRows = false;
            this.gv_DB.AllowUserToDeleteRows = false;
            this.gv_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_DB.Location = new System.Drawing.Point(3, 17);
            this.gv_DB.Name = "gv_DB";
            this.gv_DB.RowHeadersWidth = 15;
            this.gv_DB.RowTemplate.Height = 23;
            this.gv_DB.Size = new System.Drawing.Size(391, 339);
            this.gv_DB.TabIndex = 0;
            // 
            // BillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 391);
            this.Controls.Add(this.gbx_db);
            this.Controls.Add(this.gbx_AllBill);
            this.Controls.Add(this.tool_BillInfo);
            this.Name = "BillInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BillInfo_FormClosed);
            this.Load += new System.EventHandler(this.BillInfo_Load);
            this.tool_BillInfo.ResumeLayout(false);
            this.tool_BillInfo.PerformLayout();
            this.gbx_AllBill.ResumeLayout(false);
            this.gbx_db.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool_BillInfo;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private WSV.Control.MyListBox.MyListBox list_AllBill;
        private System.Windows.Forms.GroupBox gbx_AllBill;
        private System.Windows.Forms.GroupBox gbx_db;
        private System.Windows.Forms.DataGridView gv_DB;
        private System.Windows.Forms.ToolStripButton Btn_Design;
        private System.Windows.Forms.ToolStripButton Btn_Preview;
        private System.Windows.Forms.ToolStripSeparator Btn_line1;
        private System.Windows.Forms.ToolStripButton But_Del;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton But_ReName;
        private System.Windows.Forms.ImageList Image_AllBill;
    }
}