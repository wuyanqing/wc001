using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL;
using WSV.DAL.Weight;
using WSV.Model.Weight;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace WSV.BLL.Weight
{
    public class PlanBLL
    {
        #region 显示 临时数据
        /// <summary>
        /// 显示临时数据
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectALL()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.PlanDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "SelectALL", "V_DC_Plan");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region 添加数据时模糊查询
        /// <summary>
        /// 添加数据时模糊查询
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <param name="s_pr1"></param>
        /// <returns></returns>
        public static DataSet SelectData(string s_pr)
        {
            DataBase db = new DataBase();
            string sql = "select Plan_Code,Plan_Item,Plan_Specs,Plan_Send,Plan_Accept from V_DC_Plan where Plan_Code like '%" + s_pr + "%' and Plan_Used = 0";
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(sql);
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion
        #region 称重界面查询
        /// <summary>
        /// 称重界面查询
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <param name="s_pr1"></param>
        /// <returns></returns>
        public static bool SelectName(string flag, WeightModel Item)
        {
            bool retvalue = true;
            if (flag == "")
            {
                return false;
            }
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Weight.PlanDAL();
            SqlParameter[] prams ={
                db.MakeInParam ("@flag",SqlDbType.VarChar ,50,flag ),
            };
            SqlDataReader getReader = null;
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "selectCode");
                if (getReader.Read())
                {
                   Item.Txt.Plan_Code=getReader["Plan_Code"].ToString();
                }
                else
                {
                    retvalue = false;
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 修改剩余
        public static void upSpare(string Type, string Plan_Code, decimal Spare)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.PlanDAL();
            SqlParameter[] prams = new SqlParameter[2];
            if (Type == "01")
            {
                prams[0] = db.MakeInParam("@Plan_Code", SqlDbType.VarChar, 50, Plan_Code);
                prams[1] = db.MakeInParam("@Plan_SpareNum", SqlDbType.Decimal, 50, Spare);
                try
                {
                    db.TransactSql(visitor, "Plan_SpareNum", prams);
                }
                catch (Exception e)
                {
                    db.Dispose();
                    return;
                }
            }
            if (Type == "02")
            {
                prams[0] = db.MakeInParam("@Plan_Code", SqlDbType.VarChar, 50, Plan_Code);
                prams[1] = db.MakeInParam("@Plan_SpareMoney", SqlDbType.Decimal, 50, Spare);
                try
                {
                    db.TransactSql(visitor, "Plan_SpareMoney", prams);
                }
                catch (Exception e)
                {
                    db.Dispose();
                    return;
                }
            }
        }
        #endregion
    }
}
