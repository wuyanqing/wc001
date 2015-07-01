using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Globalization;
using System.Diagnostics;
using System.Data;
using System.Collections;               //ArrayList

namespace WSV.Control.DataGridView
{
    /// <summary>
    /// 重现实性datagridview
    /// 日期时间:2010-1-15
    /// 作者：邢正
    /// 修改：
    /// </summary>
    public class MyDataGridView :System.Windows.Forms.DataGridView 
    {
        //合计
        System.Windows.Forms.DataGridView botTotal;//= new DataGridView();
        DataTable dtSum;


        public MyDataGridView()
        {
            this.BackgroundColor = SystemColors.GradientActiveCaption;
            this.RowHeadersWidth = 41;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.ScrollBars = ScrollBars.Vertical;              //只显示垂直条
            //表头居中对齐
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            


            //RowHeadersDefaultCellStyle 
            botTotal = new System.Windows.Forms.DataGridView();
            botTotal.AllowUserToAddRows = false;
            botTotal.AllowUserToDeleteRows = false;
            botTotal.ScrollBars = ScrollBars.Horizontal;
            botTotal.ColumnHeadersVisible = false;
            botTotal.BackgroundColor = this.BackgroundColor;
            botTotal.Paint += new PaintEventHandler(botTotal_Paint);
            botTotal.RowPostPaint += new DataGridViewRowPostPaintEventHandler(botTotal_RowPostPaint);
            botTotal.Scroll += new ScrollEventHandler(botTotal_Scroll);
            botTotal.Height = 40;
            botTotal.Visible = _Total;
            this.Controls.Add(botTotal);
        }
        /// <summary>
        ///  获取DataGridView选定行的值集合
        /// </summary>
        public string SelectValues(string PrimaryKey)
        {
            string Id = "''";
            DataGridViewSelectedRowCollection dgv = this.SelectedRows;
            for (int i = 0; i < dgv.Count; i++)
            {
                Id += ",'" + dgv[i].Cells[PrimaryKey].Value + "'";
            }
            return Id;
        }
        #region 重写方法

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (!_EnterNextRow)
            {
                Keys key = (keyData & Keys.KeyCode);
                if (key == Keys.Enter)
                {
                    return this.ProcessRightKey(keyData);
                }
            }
            return base.ProcessDialogKey(keyData);
        }
        public new bool ProcessRightKey(Keys keyData)
        {
            
            if (!_EnterNextRow)
            {
                Keys key = (keyData & Keys.KeyCode);
                if (key == Keys.Enter & this.Rows.Count > 0)
                {
                    //第一种情况：只有一行,且当光标移到最后一列时
                    if ((base.CurrentCell.ColumnIndex == (base.ColumnCount - 1)) && (base.RowCount == 1))
                    {
                        base.CurrentCell = base.Rows[base.RowCount - 1].Cells[0];
                        return true;
                    }
                    //第二种情况：有多行，且当光标移到最后一列时,移到下一行第一个单元
                    if ((base.CurrentCell.ColumnIndex == (base.ColumnCount - 1)) && (base.CurrentCell.RowIndex < (base.RowCount - 1)))
                    {
                        base.CurrentCell = base.Rows[base.CurrentCell.RowIndex + 1].Cells[0];
                        return true;
                    }

                    return base.ProcessRightKey(keyData);
                }
            }
            return base.ProcessRightKey(keyData);
        }
        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (!_EnterNextRow)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    return this.ProcessRightKey(e.KeyData);
                }
                //if (e.KeyCode == Keys.F4)
                //{
                //    return this.ProcessRightKey(e.KeyData);
                //}
            }
            return base.ProcessDataGridViewKey(e);
        }
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Enter)
        //    {
        //        return base.ProcessTabKey(keyData);
        //    }
        //    else
        //    {
        //        return base.ProcessCmdKey(ref msg, keyData);
        //    }
        //}
        //当下一列是只读时，再一列
        protected override void OnCellEnter(DataGridViewCellEventArgs e)
        {
            if (!_EnterNextRow)
            {
                if (this.Columns[e.ColumnIndex].Visible && !this.Columns[e.ColumnIndex].ReadOnly)
                {
                    base.OnCellEnter(e);
                }
                else
                {
                    SendKeys.Send("{ENTER}");
                }
            }
        }


        //统计合计行
        protected override void OnCurrentCellChanged(EventArgs e)
        {
            DataTable dt = (DataTable)this.DataSource;

            foreach (DataGridViewColumn col in this.Columns)
            {
                SetTotalColumns(col);
            }
            base.OnCurrentCellChanged(e);

            if(_Total)
                GetSumData(dt);
            //if (this.Rows.Count > 1)
            //{
            //    //RowHeadersDefaultCellStyle 设置行的样式
            //    this.Rows[this.Rows.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            //    this.Rows[this.Rows.Count - 1].Height = this.Rows[this.Rows.Count - 1].Height + 40;
            //    this.Rows[this.Rows.Count - 1].Resizable = DataGridViewTriState.False;
            //}

        }
        protected override void OnDataSourceChanged(EventArgs e)
        {
            DataTable dt = (DataTable)this.DataSource;

            base.OnDataSourceChanged(e);

            //GetSumData(dt);
            if (this.Rows.Count > 1 && _Total)
            {
                //RowHeadersDefaultCellStyle 设置行的样式
                foreach (DataGridViewColumn Col in this.Columns)
                {
                    if (Col.CellType.Name != "DataGridViewCheckBoxCell")//Col.CellType != System.Type.GetType("System.Windows.Forms.DataGridViewCheckBoxCell"))
                        this.Rows[this.Rows.Count - 1].Cells[Col.Index].Style.Alignment = DataGridViewContentAlignment.TopLeft;
                    else
                        this.Rows[this.Rows.Count - 1].Cells[Col.Index].Style.Alignment = DataGridViewContentAlignment.TopCenter;
                }
                //this.Rows[this.Rows.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                this.Rows[this.Rows.Count - 1].Height = 60;// this.Rows[this.Rows.Count - 1].Height + 40;
                this.Rows[this.Rows.Count - 1].Resizable = DataGridViewTriState.False;
            }


        }


        //当控件大小改变时，合计行位置改变
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            //ResetButtomPanel();
            ResetBotDvg();
        }
        protected override void OnBorderStyleChanged(EventArgs e)
        {
            base.OnBorderStyleChanged(e);
            //ResetButtomPanel();
            ResetBotDvg();
        }

        //在前面加上行号
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {

            //是否显示行号
            if (!this._RowCode)
                return;

            //每行加入行号
            if (this.RowHeadersWidth < 20)
                return;
            

            SolidBrush B = new SolidBrush(Color.Black);

            //e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1, System.Globalization.CultureInfo.CurrentUICulture),
            //    e.InheritedRowStyle.Font, B, e.RowBounds.Left + this.RowHeadersWidth-35, e.RowBounds.Top + 4);

            e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1, System.Globalization.CultureInfo.CurrentUICulture),
               e.InheritedRowStyle.Font, B, e.RowBounds.Left + this.RowHeadersWidth / 2 - e.Graphics.MeasureString(Convert.ToString(e.RowIndex + 1, System.Globalization.CultureInfo.CurrentUICulture),
                                   this.Font).Width / 2, e.RowBounds.Top + 4);

            //e.Graphics.DrawString((e.RowIndex+1).ToString(System.Globalization.CultureInfo.CurrentCulture),
            //    this.DefaultCellStyle.Font, B, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);

            //e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentCulture),
            //    this.DefaultCellStyle.Font,B,e.RowBounds.Left + this.RowHeadersWidth - 30, e.RowBounds.Top + 4);//绘制图标

            base.OnRowPostPaint(e);
        }

        

        //当行标题宽改变时
        protected override void OnRowHeadersWidthChanged(EventArgs e)
        {
            botTotal.RowHeadersWidth = this.RowHeadersWidth;
            botTotal.Refresh();
            base.OnRowHeadersWidthChanged(e);
        }
        //当列宽改变时
        protected override void OnColumnWidthChanged(DataGridViewColumnEventArgs e)
        {
            //if (botTotal.DataSource == null)
            //{
            //    base.OnColumnWidthChanged(e);
            //    botTotal.Refresh();
            //    return;
            //}
            try
            {
                botTotal.Columns[e.Column.Name].Width = e.Column.Width;
                botTotal.Refresh();
            }
            catch { }
            base.OnColumnWidthChanged(e);
        }

        //当列改变时,合计的位置改变
        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);
            SetTotalColumns(e.Column);
        }
        protected override void OnColumnRemoved(DataGridViewColumnEventArgs e)
        {

            base.OnColumnRemoved(e);
            SetTotalColumns(e.Column);
        }
        protected override void OnColumnDisplayIndexChanged(DataGridViewColumnEventArgs e)
        {
            base.OnColumnDisplayIndexChanged(e);
            SetTotalColumns(e.Column);
        }

        //从新排序时
        protected override void OnSelectionChanged(EventArgs e)
        {
            if (this.Rows.Count > 1 && _Total )
            {
                //RowHeadersDefaultCellStyle 设置行的样式
                foreach (DataGridViewColumn Col in this.Columns)
                {
                    string aa = Col.CellType.Name;
                    if (Col.CellType.Name != "DataGridViewCheckBoxCell")// System.Type.GetType("System.Windows.Forms.DataGridViewCheckBoxCell"))
                        this.Rows[this.Rows.Count - 1].Cells[Col.Index].Style.Alignment = DataGridViewContentAlignment.TopLeft;
                    else
                        this.Rows[this.Rows.Count - 1].Cells[Col.Index].Style.Alignment = DataGridViewContentAlignment.TopCenter;
                }
                //this.Rows[this.Rows.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                this.Rows[this.Rows.Count - 1].Height = 60; //this.Rows[this.Rows.Count - 1].Height + 40;
                this.Rows[this.Rows.Count - 1].Resizable = DataGridViewTriState.False;
            }
            

            //if (this.SelectedRows.Count > 0)
            //{
            //    this.SelectedRows[0].Selected = true;
            //}
            base.OnSelectionChanged(e);
        }
        #endregion 重写方法

        #region 私有方法
        //合计列的位置对应
        private void SetTotalColumns(DataGridViewColumn col)
        {
            bool b_Col = false;
            DataGridViewColumn newcol = new DataGridViewColumn();
            newcol = (DataGridViewColumn)col.Clone();
            newcol.DisplayIndex = col.DisplayIndex;
            newcol.Visible = col.Visible;
            foreach (DataGridViewColumn d_co in botTotal.Columns)
            {
                if (d_co.Name == newcol.Name)
                {
                    b_Col = true;
                    break;
                }
            }
            if (b_Col)
            {
                botTotal.Columns.Remove(newcol.Name);
            }
            //newcol.HeaderText = newcol.Name;
            if (newcol.Name != "")
            {
                System.Windows.Forms.DataGridViewTextBoxColumn ColNew = new DataGridViewTextBoxColumn();
                ColNew.Name = newcol.Name;
                ColNew.DisplayIndex = newcol.DisplayIndex;
                ColNew.Visible = newcol.Visible;
                ColNew.DataPropertyName = newcol.DataPropertyName;
                botTotal.Columns.Add(ColNew);
                //botTotal.Columns.Add(newcol);
            }
        }

        //行头加入合计
        private void botTotal_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (!_Total)
                return;
            //每行加入行号
            if (this.RowHeadersWidth < 20)
                return;
            SolidBrush B = new SolidBrush(Color.Black);
            e.Graphics.DrawString("合计", e.InheritedRowStyle.Font, B, e.RowBounds.Left + this.RowHeadersWidth / 2 - e.Graphics.MeasureString("合计",
                                   botTotal.Font).Width / 2, e.RowBounds.Top + 4);
            //botTotal.Refresh();
        }

        //滚动合计时，上面的滚动
        protected void botTotal_Scroll(object sender, ScrollEventArgs e)
        {
            this.HorizontalScrollingOffset = e.NewValue;
        }

        //合计数据
        private void GetSumData(DataTable dt)
        {
            if (dt == null)
            {
                botTotal.DataSource = null;
                return;
            }


            DataRow dr;
            dtSum = new DataTable("Sum");
            //foreach (DataColumn Col in dt.Columns)
            //{
            //    dtSum.Columns.Add(Col.ColumnName, System.Type.GetType("System.String"));
            //}
            dtSum = dt.Clone();
            foreach (DataColumn Col in dtSum.Columns)
            {
                Col.DataType = System.Type.GetType("System.String");
            }
            dr = dtSum.NewRow();


            ArrayList RowList = ArrayList.Adapter(_TotalText.ToUpper().Split(','));
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn Col in dt.Columns)
                {
                    //if (Col.DataType == System.Type.GetType("System.Boolean"))
                    //    continue;
                    string ColName = Col.ColumnName.ToUpper();
                    if (RowList.Contains(ColName))
                    {

                        ////DatatableA.Columns[i].DataType = System.Type.GetType("System.Int32");
                        //Col.DataType = System.Type.GetType("System.Single");
                        //dr[ColName] = dt.Compute("Sum(" + ColName + ")", "true");

                        float _v = StrToFloat(row[ColName].ToString());
                        float _Sumv = StrToFloat(dr[ColName].ToString());
                        dr[ColName] = _Sumv + _v;
                    }
                    else
                        dr[ColName] = "";
                }
            }

            //for (int i = 1; i <= dt.Columns.Count - 1; i++)
            //{
            //    if (dt.Columns[i].DataType == (5.4F).GetType())
            //        dr[i] = dt.Compute("Sum(" + dt.Columns[i].ColumnName + ")", "true");
            //}


            dtSum.Rows.Add(dr);
            botTotal.AutoGenerateColumns = this.AutoGenerateColumns;
            this.botTotal.DataSource = dtSum;
            this.botTotal.ReadOnly = true;
            this.botTotal.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.botTotal.Rows[0].DefaultCellStyle.BackColor = Color.Aqua;
        }

        ////合计数据
        //private void GetSumData(DataTable dt)
        //{
        //    if (dt == null)
        //    {
        //        botTotal.DataSource = null;
        //        return;

        //    }


        //    DataRow dr;
        //    dtSum = new DataTable("Sum");
        //    dtSum = dt.Clone();


        //    //Random rdm = new Random();
        //    dr = dtSum.NewRow();
        //    //dr[0] = "合计";



        //    for (int i = 1; i <= dt.Columns.Count - 1; i++)
        //    {
        //        if (dt.Columns[i].DataType == (5.4F).GetType())
        //            dr[i] = dt.Compute("Sum(" + dt.Columns[i].ColumnName + ")", "true");
        //    }
        //    dtSum.Rows.Add(dr);
        //    botTotal.AutoGenerateColumns = this.AutoGenerateColumns;

        //    this.botTotal.DataSource = dtSum;
        //    this.botTotal.ReadOnly = true;
        //    this.botTotal.SelectionMode = DataGridViewSelectionMode.CellSelect;
        //    this.botTotal.Rows[0].DefaultCellStyle.BackColor = Color.Aqua;
        //}


        private void botTotal_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                ResetBotDvg();
            }
            catch { }
        }

        //合计的位置
        private void ResetBotDvg()
        {
            if (!_Total)
                return;
            //if (this.HorizontalScrollBar.Visible)
            //{
            //    //this.HorizontalScrollBar.Height = 40;
            //    //botTotal.Top = this.Height - botTotal.Height - this.HorizontalScrollBar.Height - 1;

            //}
            //else
            //{
            botTotal.Top = this.Height - botTotal.Height;
            //}

           
            if (this.BorderStyle == BorderStyle.Fixed3D)
            {
                botTotal.Left = 3;
                botTotal.Width = this.Width - 5;
            }
            else
            {
                botTotal.Left = 1;
                botTotal.Width = this.Width - 2;
            }
        }


        private float StrToFloat(string str)
        {
            float tid;
            if (float.TryParse(str, out tid) == false)
            {
                tid = 0;
            }
            if (tid < 0) { tid = 0; }
            return tid;
         }
        #endregion 私有方法



        #region 私有变量
        private bool _Total = false;                //是否显示合计
        private bool _RowCode = false;              //是否显示行号
        private string _TotalText = "";             //要合计的列名   
        private bool _EnterNextRow = true;         //回车是否到下一行
        #endregion

        #region 公共变量
        /// <summary>
        /// 回车是否到下一行
        /// </summary>
        [Description("是否显示底部合计")]
        public bool EnterNextRow
        {
            get { return _EnterNextRow; }
            set
            {
                _EnterNextRow = value;
            }
        }
        /// <summary>
        /// 是否显示
        /// </summary>
        [Description("是否显示底部合计")]
        public bool Total 
        { 
            get { return _Total; }
            set 
            { 
                _Total = value;
                botTotal.Visible = _Total;
                if (_Total)
                    this.ScrollBars = ScrollBars.Vertical;              //只显示垂直条
                else
                    this.ScrollBars = ScrollBars.Both;                  //两个同时显示s
            }
        }
        /// <summary>
        /// 是否显示
        /// </summary>
        [Description("是否显示行号")]
        public bool RowCode 
        { 
            get { return _RowCode; } 
            set 
            { 
                _RowCode = value;
                if (_RowCode)
                {
                    this.TopLeftHeaderCell.Value = "行号";
                    this.RowHeadersWidth = 41;
                }
                else
                {
                    this.TopLeftHeaderCell.Value = "";
                    this.RowHeadersWidth = 20;
                }
            } 
        }
        /// <summary>
        /// 需要显示的列名
        /// </summary>
        /// 
        [Description("需要合计的列名用豆号隔开(如:,col1,col2...,)前后都加逗号")]//如:上面画面的此属性值为: ,131,
        public string TotalText
        {
            get { return _TotalText; }
            set { _TotalText = value; }
        }
        #endregion

    }
}
