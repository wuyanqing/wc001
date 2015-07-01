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
    public class CardBLL
    {
        #region 查询所有卡号
        /// <summary>
        /// 查询所有卡号
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectALL()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.CardDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "SelectALL", "V_D_Card_Temp");
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

        #region 保存卡号
        /// <summary>
        /// 保存卡号
        /// </summary>
        /// <param name="values"></param>
        public static void Save_Card(WeightModel values)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.CardDAL();

            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_Card")),
                db.MakeInParam("@Card",SqlDbType.VarChar,50,values.Txt.Card),
                db.MakeInParam("@CarCode",SqlDbType.VarChar,50,values.Txt.CarCode),
                db.MakeInParam("@Type",SqlDbType.VarChar,50,values.Txt.Type),
                db.MakeInParam("@Item",SqlDbType.VarChar,50,values.Txt.Item),
                db.MakeInParam("@Specs",SqlDbType.VarChar,50,values.Txt.Specs),
                db.MakeInParam("@Place",SqlDbType.VarChar,50,values.Txt.Place),
                db.MakeInParam("@Send",SqlDbType.VarChar,50,values.Txt.Send),
                db.MakeInParam("@Accept",SqlDbType.VarChar,50,values.Txt.Accept),
                db.MakeInParam("@Carry",SqlDbType.VarChar,50,values.Txt.Carry),
                db.MakeInParam("@Model",SqlDbType.VarChar,50,values.Txt.Model),
                db.MakeInParam("@Driver",SqlDbType.VarChar,50,values.Txt.Driver),
                db.MakeInParam("@Spare",SqlDbType.VarChar,50,values.Txt.Spare),
                db.MakeInParam("@Tare",SqlDbType.Float,50,values.Float.Tare),
                db.MakeInParam("@State",SqlDbType.Bit,1,values.StateFun.State)
                    };
            try
            {
                db.TransactSql(visitor, "Save_Card", prams);
            }
            catch (Exception err)
            {
                db.Dispose();
                MessageBox.Show("数据不全！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                db.Dispose();
            }
        }
        #endregion 

        #region 查询当前卡号
        public static bool SelectCard(string Card, WeightModel Item)
        {
            bool retvalues = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CardDAL();
            SqlParameter[] prams={
                 db.MakeInParam("@Card",SqlDbType.VarChar,50,Card)
            };
            SqlDataReader getread = null;
            db.GetDataReader(visitor, prams, out getread, "SelectCard");
            try
            {
                if (getread.Read())
                {
                    Item.Txt.Type = getread["Type"].ToString();
                    Item.Txt.Item = getread["Item"].ToString();
                    Item.Txt.Specs = getread["Specs"].ToString();
                    Item.Txt.Place = getread["Place"].ToString();
                    Item.Txt.Send = getread["Send"].ToString();
                    Item.Txt.Accept = getread["Accept"].ToString();
                    Item.Txt.Carry = getread["Carry"].ToString();
                    Item.Txt.Model = getread["Model"].ToString();
                    Item.Txt.Driver = getread["Driver"].ToString();
                    Item.Txt.Spare = getread["Spare"].ToString();
                    Item.Txt.CarCode = getread["CarCode"].ToString();
                    Item.StateFun.State = Convert.ToBoolean(getread["State"]);
                    Item.Float.Tare =Convert.ToDecimal(getread["Tare"].ToString());
                }
                else
                {
                    return retvalues = false;
                }
                getread.Close();
            }
            catch (Exception e)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalues;
        }
        #endregion

        #region 修改数据
        public static bool Update(WeightModel Values)
        {
            bool retvalue = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CardDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Card",SqlDbType.VarChar,50,Values.Txt.Card),
                db.MakeInParam("@CarCode",SqlDbType.VarChar,50,Values.Txt.CarCode),
                db.MakeInParam("@Type",SqlDbType.VarChar,50,Values.Txt.Type),
                db.MakeInParam("@Item",SqlDbType.VarChar,50,Values.Txt.Item),
                db.MakeInParam("@Specs",SqlDbType.VarChar,50,Values.Txt.Specs),
                db.MakeInParam("@Place",SqlDbType.VarChar,50,Values.Txt.Place),
                db.MakeInParam("@Send",SqlDbType.VarChar,50,Values.Txt.Send),
                db.MakeInParam("@Accept",SqlDbType.VarChar,50,Values.Txt.Accept),
                db.MakeInParam("@Carry",SqlDbType.VarChar,50,Values.Txt.Carry),
                db.MakeInParam("@Model",SqlDbType.VarChar,50,Values.Txt.Model),
                db.MakeInParam("@Driver",SqlDbType.VarChar,50,Values.Txt.Driver),
                db.MakeInParam("@Spare",SqlDbType.VarChar,50,Values.Txt.Spare),
                db.MakeInParam("@Tare",SqlDbType.Float,50,Values.Float.Tare),
                db.MakeInParam("@State",SqlDbType.Bit,1,Values.StateFun.State)
                    };
            try
            {
                db.TransactSql(visitor, "Update_Card", prams);
            }
            catch (Exception err)
            {
                db.Dispose();
                MessageBox.Show(err.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 返回数据编号
        /// <summary>
        /// 返回数据编号
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <returns></returns>
        public string Back_Code(string s_Pr)
        {
            string Code = "";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CardDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Name", SqlDbType.VarChar,50,s_Pr)
            };
            SqlDataReader dr = null;
            try
            {
                db.GetDataReader(visitor, prams, out dr, "Back_Code");
                if (dr.Read())
                {
                    Code = dr["Code"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return Code;
        }
        #endregion

        #region 删除数据
        public static bool Delete(string S_Pr)
        {
            bool retvalue = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CardDAL();
            SqlParameter[] prams =
                {
                    db.MakeInParam("@Card",SqlDbType.VarChar,50,S_Pr)
                };
             try
            {
                db.TransactSql(visitor, "Delete", prams);
            }
            catch (Exception err)
            {
                db.Dispose();
                MessageBox.Show(err.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 查询卡号信息
        public static bool SelectByCard(string Card, WeightModel Item)
        {
            bool retvalues = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CardDAL();
            SqlParameter[] prams ={
                 db.MakeInParam("@Card",SqlDbType.VarChar,50,Card)
            };
            SqlDataReader getread = null;
            db.GetDataReader(visitor, prams, out getread, "SelectByCard");
            try
            {
                if (getread.Read())
                {
                    Item.Txt.Type = getread["Type"].ToString();
                    Item.Txt.Item = getread["Item"].ToString();
                    Item.Txt.Specs = getread["Specs"].ToString();
                    Item.Txt.Place = getread["Place"].ToString();
                    Item.Txt.Send = getread["Send"].ToString();
                    Item.Txt.Accept = getread["Accept"].ToString();
                    Item.Txt.Carry = getread["Carry"].ToString();
                    Item.Txt.Model = getread["Model"].ToString();
                    Item.Txt.Driver = getread["Driver"].ToString();
                    Item.Txt.Spare = getread["Spare"].ToString();
                    Item.Txt.CarCode = getread["CarCode"].ToString();
                    Item.StateFun.State = Convert.ToBoolean(getread["State"]);
                    Item.Float.Tare = Convert.ToDecimal(getread["Tare"].ToString());
                }
                else
                {
                    return retvalues = false;
                }
                getread.Close();
            }
            catch (Exception e)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalues;
        }
        #endregion
    }
}
