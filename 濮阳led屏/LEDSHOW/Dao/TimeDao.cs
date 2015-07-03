using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using THOK.Util;
using System.Data;

namespace LEDSHOW.Dao
{
   public class TimeDao:BaseDao
    {

        //远程服务器查询纯分拣时间
        public DataTable FindSortTime(string sortNo)//  convert(varchar(100),getdate(),23)
        {

            string sql = "";
            if (sortNo == "one")
                sql = @"select sum(use_time) from sms_sms_device_state where begin_time>'2014-12-19' and device_code='01' and device_type=1";
            else
                sql = @"select sum(use_time) from sms_sms_device_state where begin_time>'2014-12-19' and device_code='02' and device_type=1";
            return ExecuteQuery(sql).Tables[0];
        }

    }
}
