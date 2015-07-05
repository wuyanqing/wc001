using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using THOK.Util;

namespace LEDSHOW.Dao
{
    public class LedShowDao : BaseDao
    {

        /// <summary>
        /// 参数表信息
        /// </summary>
        /// <returns></returns>
        public DataTable getParameters(string strRequires)
        {
            string sql = @"SELECT * FROM SYS_PARAMETER {0}";
            return ExecuteQuery(string.Format(sql,strRequires)).Tables[0];
        }

        /// <summary>
        /// 送货单信息
        /// </summary>
        /// <returns></returns>
        public DataTable getRegistrationInfos(string strRequires)
        {
            string sql = @"SELECT A.*,B.ADDRESS_NAME FROM BUS_REGISTRATIONINFO  A
                            LEFT JOIN BUS_PRODUCTADDRESS B ON A.ADDRESS_CODE=B.ADDRESS_CODE {0}";
            return ExecuteQuery(string.Format(sql, strRequires)).Tables[0];
        }

        /// <summary>
        /// 待卸货总量
        /// </summary>
        /// <returns></returns>
        public int workTaskQty(string strRequires)
        {
            try
            {
                string sql = @"select SUM(quantity) from dbo.Bus_RegistrationInfo {0}";
                return int.Parse(ExecuteScalar(string.Format(sql, strRequires)).ToString());
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
