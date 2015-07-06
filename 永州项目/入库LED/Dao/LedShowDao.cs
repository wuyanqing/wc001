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
        /// 进入配送中心车辆信息
        /// </summary>
        /// <returns></returns>
        public DataTable getRegistrationInfos(string strRequires)
        {
            string sql = @"SELECT A.*,B.ADDRESS_NAME FROM BUS_REGISTRATIONINFO  A
                            LEFT JOIN BUS_PRODUCTADDRESS B ON A.ADDRESS_CODE=B.ADDRESS_CODE {0}";
            return ExecuteQuery(string.Format(sql, strRequires)).Tables[0];
        }
    }
}
