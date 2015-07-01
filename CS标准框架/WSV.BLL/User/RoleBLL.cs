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
    public class RoleBLL
    {
        #region 查询出所有的数据
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet SelectAll(string WhereSql)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new RoleDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_UserRole", WhereSql);
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
        public static bool Insert(D_UserRole Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new RoleDAL();
            bool Flag = false, ReFlag = false,RolePowerFlag=false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Id", SqlDbType.BigInt,0,PublicFun.PublicFun.MaxId("D_UserRole")),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@ParentCode", SqlDbType.VarChar,50, Item.ParentCode)
            };
            try
            {
                ReFlag = db.TransactSql(visitor, "Insert", prams, out N);
                RolePowerFlag=AddRolePower(Item.Code, Item.RolePower);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            if (ReFlag && N > 0 && RolePowerFlag)
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
        public static bool Update(D_UserRole Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new RoleDAL();
            bool Flag = false, ReFlag = false, RolePowerFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@Id", SqlDbType.BigInt,0,Item.Id)
            };
            try
            {
                ReFlag = db.TransactSql(visitor, "Update", prams, out N);
                RolePowerFlag = AddRolePower(Item.Code, Item.RolePower);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            if (ReFlag && N > 0&&RolePowerFlag)
            {
                Flag = true;
            }
            return Flag;
        }
        #endregion

        #region 添加权限
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="RoleCode">角色编号</param>
        /// <param name="PowerCode">权限编号</param>
        /// <returns></returns>
        private static bool AddRolePower(string RoleCode,string RolePower)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new RoleDAL();
            bool Flag = true;
            int N = 0;
            try
            {
                SqlParameter[] prams;
                prams =new SqlParameter[]{
                    db.MakeInParam("@RoleCode", SqlDbType.VarChar,50,RoleCode),
                    };
                db.TransactSql(visitor, "DelRolePower", prams);

                string[] PowerList =RolePower.Split(',');
                for (int i = 0; i < PowerList.Length; i++)
                {
                    db = new DataBase();
                    prams =new SqlParameter[]{
                    db.MakeInParam("@RoleCode", SqlDbType.VarChar,50,RoleCode),
                    db.MakeInParam("@PowerCode", SqlDbType.VarChar,50,PowerList[i])
                    };
                    db.TransactSql(visitor, "AddRolePower", prams);
                }
            }
            catch (Exception ex)
            {
                Flag = false;
                throw ex;
            }
            finally
            {
                db.Dispose();
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
                if (db.TransactSql("delete from D_UserRole where id in(" + Id + ")"))
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

        #region 查询角色拥有的权限
        /// <summary>
        /// 查询角色拥有的权限
        /// </summary>
        /// <param name="RoleCode">角色编号</param>
        /// <returns></returns>
        public static string RolePower(string RoleCode)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new RoleDAL();
            string Nid = "";
            SqlParameter[] prams ={
               db.MakeInParam("@RoleCode", SqlDbType.VarChar,50,RoleCode)
            };
            try
            {
                SqlDataReader dr;
                db.GetDataReader(visitor, prams, out dr, "RolePower");
                while (dr.Read())
                {
                    Nid += "," + dr["PowerCode"];
                }
                if (!string.IsNullOrEmpty(Nid)) { Nid = Nid.Substring(1); }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return Nid;
        }
        #endregion

        #region 查询角色是否拥有某个权限
        /// <summary>
        /// 查询角色是否拥有某个权限
        /// </summary>
        /// <param name="RoleCode">角色编号</param>
        /// <param name="PowerCode">权限编号</param>
        /// <returns></returns>
        public static bool CheckRolePower(string RuleName)
        {
            if (LUser.Id <= 2)
                return true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new RoleDAL();
            bool Flag = false;
            SqlParameter[] prams ={
               db.MakeInParam("@RoleCode", SqlDbType.VarChar,50,LUser.Role),
               db.MakeInParam("@RuleName", SqlDbType.VarChar,50,RuleName)
            };
            try
            {
                SqlDataReader dr;
                db.GetDataReader(visitor, prams, out dr, "CheckRolePower");
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


    }
}
