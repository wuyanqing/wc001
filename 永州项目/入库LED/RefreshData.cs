using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEDSHOW
{
    public class RefreshData
    {
        private int total;//当前入库总数

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        private int untotal;//当前入库车辆未入库任务数量

        public int Untotal
        {
            get { return untotal; }
            set { untotal = value; }
        }
        private int unWorktotalCars;//等待卸货车辆总数

        public int UnWorktotalCars
        {
            get { return unWorktotalCars; }
            set { unWorktotalCars = value; }
        }
        private int allWaitCas;//当前入库总数

        public int AllWaitCas
        {
            get { return allWaitCas; }
            set { allWaitCas = value; }
        }

        private string currentCarcode;//正在入库车辆车牌号

        public string CurrentCarcode
        {
            get { return currentCarcode; }
            set { currentCarcode = value; }
        }



        private string waitCarcode;//准备入库车牌号

        public string WaitCarcode
        {
            get { return waitCarcode; }
            set { waitCarcode = value; }
        }
    }
}
