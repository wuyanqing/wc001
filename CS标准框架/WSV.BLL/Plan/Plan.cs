using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV;
using WSV.DAL;

namespace WSV.BLL.Plan
{
    public class Plan
    {
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Plan.PlanVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select_D_Plan", "V_DC_Plan");
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        /// <summary>
        /// 查询出所有的类型
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectType()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Plan.PlanVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select_Type", "D_Type");
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        /// <summary>
        /// 查询计算方式
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectCountWay()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Plan.PlanVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select_CountWay", "D_CountWay");
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string AddData(Model.Plan.D_Plan Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Plan.PlanVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            long id = BLL.PublicFun.PublicFun.MaxId("D_Plan");
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,12, BLL.PublicFun.PublicFun.MaxId("D_Plan")),              
                db.MakeInParam("@Plan_Code", SqlDbType.VarChar,50, Item.Plan_Code),
                db.MakeInParam("@Plan_CountWay", SqlDbType.VarChar,50, Item.Plan_CountWay),
                db.MakeInParam("@Plan_Item", SqlDbType.VarChar,50, Item.Plan_Item),
                db.MakeInParam("@Plan_Specs", SqlDbType.VarChar,50, Item.Plan_Specs),
                db.MakeInParam("@Plan_Type", SqlDbType.VarChar,50, Item.Plan_Type),
                db.MakeInParam("@Plan_Send", SqlDbType.VarChar,50, Item.Plan_Send),
                db.MakeInParam("@Plan_Accept", SqlDbType.VarChar,50, Item.Plan_Accept),
                db.MakeInParam("@Plan_Num", SqlDbType.Decimal,50, Item.Plan_Num),
                db.MakeInParam("@Plan_SpareNum", SqlDbType.Decimal,50, Item.Plan_SpareNum),
                db.MakeInParam("@Plan_Money", SqlDbType.Decimal,50, Item.Plan_Money),
                db.MakeInParam("@Plan_SpareMoney", SqlDbType.Decimal,50, Item.Plan_SpareMoney),
                db.MakeInParam("@Remark", SqlDbType.VarChar,50, Item.Remark),
                db.MakeInParam("@Begin_Time", SqlDbType.VarChar,50, Item.Begin_Time),
                db.MakeInParam("@End_Time", SqlDbType.VarChar,50, Item.End_Time),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Insert", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 修改主数据
        /// </summary>
        /// <param name="Weight">model</param>
        /// <returns></returns>
        public static string UpdateData(Model.Plan.D_Plan Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Plan.PlanVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Plan_Code", SqlDbType.VarChar,50, Item.Plan_Code),
                db.MakeInParam("@Plan_CountWay", SqlDbType.VarChar,50, Item.Plan_CountWay),
                db.MakeInParam("@Plan_Item", SqlDbType.VarChar,50, Item.Plan_Item),
                db.MakeInParam("@Plan_Specs", SqlDbType.VarChar,50, Item.Plan_Specs),
                db.MakeInParam("@Plan_Type", SqlDbType.VarChar,50, Item.Plan_Type),
                db.MakeInParam("@Plan_Send", SqlDbType.VarChar,50, Item.Plan_Send),
                db.MakeInParam("@Plan_Accept", SqlDbType.VarChar,50, Item.Plan_Accept),
                db.MakeInParam("@Plan_Num", SqlDbType.Decimal,50, Item.Plan_Num),
                db.MakeInParam("@Plan_SpareNum", SqlDbType.Decimal,50, Item.Plan_SpareNum),
                db.MakeInParam("@Plan_Money", SqlDbType.Decimal,50, Item.Plan_Money),
                db.MakeInParam("@Plan_SpareMoney", SqlDbType.Decimal,50, Item.Plan_SpareMoney),
                db.MakeInParam("@Remark", SqlDbType.VarChar,50, Item.Remark),
                db.MakeInParam("@Begin_Time", SqlDbType.VarChar,50, Item.Begin_Time),
                db.MakeInParam("@End_Time", SqlDbType.VarChar,50, Item.End_Time),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Update", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 根据编号查询视图内容
        /// </summary>
        /// <param name="Item">D_Plan表model</param>
        public static void GetV_Plan(ref Model.Plan.D_Plan Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Plan.PlanVisitor();
            SqlDataReader dr = null;
            SqlParameter[] prams ={
                db.MakeInParam("@Plan_Code", SqlDbType.VarChar,50, Item.Plan_Code),
            };
            try
            {
                db.GetDataReader(visitor, prams, out dr, "Select_V_PlanByCode");
                if (dr.Read())
                {
                    Item.Plan_Item = dr["Plan_Item"].ToString();
                    Item.Plan_Send = dr["Plan_Send"].ToString();
                    Item.Plan_Specs = dr["Plan_Specs"].ToString();
                    Item.Plan_Accept = dr["Plan_Accept"].ToString();
                    Item.Plan_CountWay = dr["Plan_CountWay"].ToString();
                    Item.Plan_Type = dr["Plan_Type"].ToString();
                    Item.Plan_Num = Convert.ToDecimal(dr["Plan_Num"]);
                    Item.Plan_SpareNum = Convert.ToDecimal(dr["Plan_SpareNum"]);
                    Item.Plan_Money = Convert.ToDecimal(dr["Plan_Money"]);
                    Item.Plan_SpareMoney = Convert.ToDecimal(dr["Plan_SpareMoney"]);
                    Item.Begin_Time = dr["Begin_Time"].ToString();
                    Item.End_Time = dr["End_Time"].ToString();
                    Item.Remark = dr["Remark"].ToString();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                dr.Close();
                db.Dispose();
            }
        }
        /// <summary>
        /// 根据编号查询表内容
        /// </summary>
        /// <param name="Item">D_Plan表model</param>
        public static void GetPlan(ref Model.Plan.D_Plan Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Plan.PlanVisitor();
            SqlDataReader dr = null;
            SqlParameter[] prams ={
                db.MakeInParam("@Plan_Code", SqlDbType.VarChar,50, Item.Plan_Code),
            };
            try
            {
                db.GetDataReader(visitor, prams, out dr, "Select_D_PlanByCode");
                if (dr.Read())
                {
                    Item.Plan_Item = dr["Plan_Item"].ToString();
                    Item.Plan_Send = dr["Plan_Send"].ToString();
                    Item.Plan_Specs = dr["Plan_Specs"].ToString();
                    Item.Plan_Accept = dr["Plan_Accept"].ToString();
                    Item.Plan_CountWay = dr["Plan_CountWay"].ToString();
                    Item.Plan_Type = dr["Plan_Type"].ToString();
                    Item.Plan_Num = Convert.ToDecimal(dr["Plan_Num"]);
                    Item.Plan_SpareNum = Convert.ToDecimal(dr["Plan_SpareNum"]);
                    Item.Plan_Money = Convert.ToDecimal(dr["Plan_Money"]);
                    Item.Plan_SpareMoney = Convert.ToDecimal(dr["Plan_SpareMoney"]);
                    Item.Remark = dr["Remark"].ToString();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                dr.Close();
                db.Dispose();
            }
        }
        /// <summary>
        /// 是否作废数据
        /// </summary>
        /// <param name="ID">表ID</param>
        /// <param name="Used">是否作废</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Update_Used(string Code, int Used)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Plan.PlanVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Plan_Used", SqlDbType.Bit,8, Used),
                db.MakeInParam("@Plan_Code", SqlDbType.VarChar,50,Code),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Used", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        public static DataSet GetName()
        {
            DataBase db = new DataBase();
            DataSet ds = new DataSet();
            string sql = "select Name,DBName from V_C_Select where Show=1";
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
        public static string GetSql(string PlanCode)
        {
            string sql = "";
            DataTable dt = new DataTable();
            dt = GetName().Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Name = dt.Rows[i]["Name"].ToString();
                string DBName = dt.Rows[i]["DBName"].ToString();
                sql += DBName + " as " + Name + ",";
            }
            //sql = "Select " + sql + "ID,Code as 编号,CarCode as 车号,G_Oper as 毛司磅员,T_Oper as 皮司磅员,G_Table as 毛台号 ,T_Table as 皮台号,G_Time as 毛重时间,T_Time as 皮重时间,N_Time as 净重时间,used,Verify,State,WeiWay as 称重方式,[Print] as 打印次数 from V_D_Saver where Plan_code='" + PlanCode + "'";
            //sql = sql.TrimEnd(',');
            sql = "Select " + sql + "State,Used,Verify from V_D_Saver where Plan_code='" + PlanCode + "'";
            return sql;
        }
    }
}
