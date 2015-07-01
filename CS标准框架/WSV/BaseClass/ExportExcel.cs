using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
//using WSV.Control;
using System.Windows.Forms;

namespace WSV.BaseClass
{
    /// <summary>
    /// 导出Excel
    /// </summary>
    public class ExportExcel
    {
        //private static List<string> AvailableColumns = new List<string>();
        public bool Export(DataGridView myview)
        {
            if (myview.Rows.Count < 1)
            {
                BaseClass.Function.MessageWarning("没有数据可供导出！");
                return false;
            }
            try
            {
                Excel.ApplicationClass MyExcel = new Excel.ApplicationClass();
                MyExcel.Visible = true;
                if (MyExcel == null)
                {
                    MessageBox.Show("EXCEL无法启动！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                Excel.Workbooks MyWorkBooks = MyExcel.Workbooks;
                Excel.Workbook MyWorkBook = MyWorkBooks.Add(Missing.Value);
                Excel.Worksheet MyWorkSheet = (Excel.Worksheet)MyWorkBook.Worksheets[1];
                //AvailableColumns.Clear();
                //foreach (DataGridViewColumn c in myview.Columns)
                //{
                //    if (!c.Visible) continue;
                //    AvailableColumns.Add(c.HeaderText);
                //}
                //int count = AvailableColumns.Count+1;
                string column = "";
                int count = myview.ColumnCount;
                if (count > 1 && count <= 26)
                {
                    char col = (char)(65 + count - 1);
                    column = col.ToString() + "1";
                }
                if (count > 27 && count <= 52)
                {
                    char col = (char)(65 + count - 26);
                    column = "A" + col.ToString() + "1";
                }
                Excel.Range MyRange = MyWorkSheet.get_Range("A1", column);
                object[] MyHeader = new object[count];
                for (int i = 0; i < count; i++)
                {
                    MyHeader[i] = myview.Columns[i].HeaderText.ToString();
                    //MyHeader[i] = AvailableColumns[i].ToString();
                }
                MyRange.Value2 = MyHeader;
                if (myview.Rows.Count > 0)
                {
                    MyRange = MyWorkSheet.get_Range("A2", Missing.Value);
                    object[,] MyData = new Object[myview.Rows.Count, count];
                    for (int i = 0; i < myview.Rows.Count; i++)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            MyData[i, j] = myview.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    MyRange = MyRange.get_Resize(myview.Rows.Count, count);
                    MyRange.Value2 = MyData;
                    MyRange.EntireColumn.AutoFit();
                }
                //MyExcel = null;
            }
            catch (Exception Err)
            {
                MessageBox.Show("调用EXCEL程序时出现错误！" + Err.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }   //导出excel
    }
}
