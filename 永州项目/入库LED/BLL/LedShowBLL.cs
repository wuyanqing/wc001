using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using THOK.Util;
using LEDSHOW.Dao;

namespace LEDSHOW.BLL
{
    public class LedShowBLL : BaseDao
    {
        /// <summary>
        /// 进入配送中心车辆信息
        /// </summary>
        /// <returns></returns>
        public DataTable getRegistrationInfos(string strRequires)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                LedShowDao dao = new LedShowDao();
                dao.SetPersistentManager(pm);
                return dao.getRegistrationInfos(strRequires);
            }
        }
    }
}
