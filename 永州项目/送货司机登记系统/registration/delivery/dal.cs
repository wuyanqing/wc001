using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using THOK.Util;

namespace delivery
{
    public class dal : BaseDao
    {
        public DataTable registrationInfo(DateTime date1, DateTime date2)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                string sql = @"select * from Bus_RegistrationInfo where daytime>='{0}' and  daytime<'{1}'";
                return this.ExecuteQuery(string.Format(sql, date1, date2)).Tables[0];
            }
        }
        public DataTable registrationInfo()
        {
            using (PersistentManager pm = new PersistentManager())
            {
                string sql = @"select * from Bus_RegistrationInfo order by id desc";
                return this.ExecuteQuery(sql).Tables[0];
            }
        }
        public bool addRegistrationInfo(RegistrationInfo registrationinformation, out string log)
        {
            bool state = false;
            try
            {
                using (PersistentManager persistentManager = new PersistentManager())
                {
                    string sql = string.Format("insert into  Bus_RegistrationInfo values( '{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')"
                        , registrationinformation._name
                        , registrationinformation._billno
                        , registrationinformation._carcode
                        , registrationinformation._phone
                        , registrationinformation._daytime
                        , registrationinformation._state
                        , registrationinformation._memo
                        , registrationinformation._port
                        , registrationinformation._address
                        , registrationinformation._isSubmit
                        , registrationinformation._iswork);
                    ExecuteNonQuery(sql);
                    state = true;
                    log = "时间：" + registrationinformation._daytime + "姓名:" + registrationinformation._name + "车牌号：" + registrationinformation._carcode + "进入物流中心";
                }
            }
            catch (Exception ex)
            {
                state = false;
                log = ex.ToString();
            }
            return state;
        }
    }
}
