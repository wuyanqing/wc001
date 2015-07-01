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
    public class CUserBll
    {
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
                ds = db.ReturnDataSet(visitor, prams, "UserLogin");
                DataRowCollection drc = ds.Tables[0].Rows;
                if (drc.Count > 0)
                {
                    DataRow dr = drc[0];
                    CUser.Id = Convert.ToInt64(dr["Id"]);
                    CUser.Code = dr["Code"].ToString();
                    CUser.Uid = dr["Uid"].ToString();
                    CUser.Name = dr["Name"].ToString();
                    CUser.Role = dr["Role"].ToString();
                    //PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                    //if (Ini.ExistIniFile())
                    //{
                    //    LUser.TableNum = Ini.IniReadValue("LoadoMeter", "TableNum");
                    //}
                    //ds = WSV.BLL.SysInfo.LoadoMeterBLL.SelectAll(" where TableNum='" + LUser.TableNum + "'");
                    //drc = ds.Tables[0].Rows;
                    //if (drc.Count > 0)
                    //{
                    //    dr = drc[0];
                    //    LUser.TableName = dr["Name"].ToString();
                    //    LUser.Ip = dr["Ip"].ToString();
                    //    LUser.Port = dr["Port"].ToString();
                    //}
                    //else
                    //{
                    //    LUser.TableNum = "";
                    //}
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
