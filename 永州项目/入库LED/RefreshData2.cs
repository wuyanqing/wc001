using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEDSHOW
{
    public class RefreshData2
    {
        private int totalRoute2;
        private int totalCustomer2;
        private int totalQuantity2;

        private int completeRoute2;
        private int completeCustomer2;
        private int completeQuantity2;

        private int average2;

        private string routeName2;
        private string batch2;

        public string Batch2
        {
            get { return batch2; }
            set { batch2 = value; }
        }
        private int currentRouteQuantity2;
        private int currentRouteCompleteQuantity2;

        public int CurrentRouteCompleteQuantity2
        {
            get { return currentRouteCompleteQuantity2; }
            set { currentRouteCompleteQuantity2 = value; }
        }

        public int CurrentRouteQuantity2
        {
            get { return currentRouteQuantity2; }
            set { currentRouteQuantity2 = value; }
        }

        public string RouteName2
        {
            get { return routeName2; }
            set { routeName2 = value; }
        }

        public int Average2
        {
            get { return average2; }
            set { average2 = value; }
        }

        public int TotalRoute2
        {
            get { return totalRoute2; }
            set { totalRoute2 = value; }
        }

        public int TotalCustomer2
        {
            get { return totalCustomer2; }
            set { totalCustomer2 = value; }
        }

        public int TotalQuantity2
        {
            get { return totalQuantity2; }
            set { totalQuantity2 = value; }
        }

        public int CompleteRoute2
        {
            get { return completeRoute2; }
            set { completeRoute2 = value; }
        }
        public int CompleteCustomer2
        {
            get { return completeCustomer2; }
            set { completeCustomer2 = value; }
        }

        public int CompleteQuantity2
        {
            get { return completeQuantity2; }
            set { completeQuantity2 = value; }
        }
    }
}
