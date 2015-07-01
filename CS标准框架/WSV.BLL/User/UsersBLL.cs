using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.Model.User;
using WSV.DAL;
using WSV.DAL.User;

namespace WSV.BLL.User
{
    public class UsersBLL
    {
        #region 查询出所有的数据
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new UsersDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_User");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region 添加数据
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool Insert(D_User Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new UsersDAL();
            bool Flag = false, ReFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Id", SqlDbType.BigInt,0,PublicFun.PublicFun.MaxId("D_User")),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@Uid", SqlDbType.VarChar,50, Item.Uid),
                db.MakeInParam("@Pwd", SqlDbType.VarChar,50, Item.Pwd),
                db.MakeInParam("@Role", SqlDbType.VarChar,50, Item.Role),
                db.MakeInParam("@Used", SqlDbType.Bit,0, Item.Used)
            };
            try
            {
                ReFlag = db.TransactSql(visitor, "Insert", prams, out N);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            if (ReFlag && N > 0)
            {
                Flag = true;
            }
            return Flag;
        }
        #endregion

        #region 修改数据
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool Update(D_User Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new UsersDAL();
            bool Flag= false,ReFlag=false;
            int N= 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@Uid", SqlDbType.VarChar,50, Item.Uid),
                db.MakeInParam("@Pwd", SqlDbType.VarChar,50, Item.Pwd),
                db.MakeInParam("@Role", SqlDbType.VarChar,50, Item.Role),
                db.MakeInParam("@Used", SqlDbType.Bit,0, Item.Used),
                db.MakeInParam("@Id", SqlDbType.BigInt,0,Item.Id)
            };
            try
            {
                ReFlag= db.TransactSql(visitor, "Update", prams, out N);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            if (ReFlag && N > 0)
            {
                Flag = true;
            }
            return Flag;
        }
        #endregion

        #region 删除数据
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="Id">要删除记录的Id</param>
        /// <returns></returns>
        public static bool Del(string Id)
        {
            DataBase db = new DataBase();
            bool Flag = false;
            try
            {
                if (db.TransactSql("delete from D_User where id in(" + Id + ")"))
                {
                    Flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Flag;
        }
        #endregion

        #region 用户登陆
        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool UserLogin(D_User Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new UsersDAL();
            bool Flag = false;
            SqlParameter[] prams ={
                db.MakeInParam("@Uid",SqlDbType.VarChar,50,Item.Uid),
                db.MakeInParam("@Pwd",SqlDbType.VarChar,50,Item.Pwd)
            };
            try
            {
                DataSet ds = new DataSet();
                ds = db.ReturnDataSet(visitor,prams,"UserLogin");
                DataRowCollection drc = ds.Tables[0].Rows;
                if (drc.Count > 0)
                {
                    DataRow dr = drc[0];
                    LUser.Id = Convert.ToInt64(dr["Id"]);
                    LUser.Code = dr["Code"].ToString();
                    LUser.Uid = dr["Uid"].ToString();
                    LUser.Name = dr["Name"].ToString();
                    LUser.Role = dr["Role"].ToString();
                    PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                    if (Ini.ExistIniFile())
                    {
                        LUser.TableNum = Ini.IniReadValue("LoadoMeter", "TableNum");
                    }
                    ds = WSV.BLL.SysInfo.LoadoMeterBLL.SelectAll(" where TableNum='" + LUser.TableNum + "'");
                    drc = ds.Tables[0].Rows;
                    if (drc.Count > 0)
                    {
                        dr = drc[0];
                        LUser.TableName = dr["Name"].ToString();
                        LUser.Ip = dr["Ip"].ToString();
                        LUser.Port = dr["Port"].ToString();
                    }
                    else
                    {
                        LUser.TableNum = "";
                    }
                    Flag = true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return Flag;
        }
        #endregion

        #region 检查用户密码
        /// <summary>
        /// 检查用户密码
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool CheckPwd(string pass)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new UsersDAL();
            bool Flag = false;
            SqlParameter[] prams ={
                db.MakeInParam("@Uid",SqlDbType.VarChar,50,LUser.Uid),
                db.MakeInParam("@Pwd",SqlDbType.VarChar,50,pass)
            };
            try
            {
                SqlDataReader dr;
                db.GetDataReader(visitor, prams, out dr, "UserLock");
                if (dr.Read())
                {
                    Flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return Flag;
        }
        #endregion

        #region 修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool RePwd(D_User Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new UsersDAL();
            bool Flag = false, ReFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Pwd",SqlDbType.VarChar,50,Item.Pwd),
                db.MakeInParam("@Id",SqlDbType.BigInt,0,Item.Id)
            };
            try
            {
                ReFlag = db.TransactSql(visitor, "RePwd", prams, out N);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            if (ReFlag && N > 0)
            {
                Flag = true;
            }
            return Flag;
        }
        #endregion

        #region 检查数据库连接
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool CheckDb()
        {
            bool Flag = true;
            DataBase db = new DataBase();
            try
            {
                Flag = db.Open();
            }
            catch
            {
                Flag = false;
            }
            finally
            {
                db.Dispose();
            }
            return Flag;
        }
        #endregion

        #region 检查数据库连接
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string  CheckDb(string aa)
        {
            return DAL.ConnString.DBServer() + " " + DAL.ConnString.DBName() + "  " + DAL.ConnString.Pass();
        }
        #endregion
    }
}
