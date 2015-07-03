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
        public DataTable LedShowInfo()
        {
            using (PersistentManager pm = new PersistentManager())
            {
                LedShowDao dao = new LedShowDao();
                dao.SetPersistentManager(pm);
                return dao.LedShowInfo();
            }
        }
    }
}
