using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEDSHOW
{
    public class RefreshData
    {
        private int totalRoute;
        private int totalCustomer;
        private int totalQuantity;

        private int completeRoute;
        private int completeCustomer;
        private int completeQuantity;

        private int average;

        private string routeName;
        private string batch;

        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }
        private int currentRouteQuantity;
        private int currentRouteCompleteQuantity;

        public int CurrentRouteCompleteQuantity
        {
            get { return currentRouteCompleteQuantity; }
            set { currentRouteCompleteQuantity = value; }
        }

        public int CurrentRouteQuantity
        {
            get { return currentRouteQuantity; }
            set { currentRouteQuantity = value; }
        }

        public string RouteName
        {
            get { return routeName; }
            set { routeName = value; }
        }

        public int Average
        {
            get { return average; }
            set { average = value; }
        }

        public int TotalRoute
        {
            get { return totalRoute; }
            set { totalRoute = value; }
        }

        public int TotalCustomer
        {
            get { return totalCustomer; }
            set { totalCustomer = value; }
        }

        public int TotalQuantity
        {
            get { return totalQuantity; }
            set { totalQuantity = value; }
        }

        public int CompleteRoute
        {
            get { return completeRoute; }
            set { completeRoute = value; }
        }
        public int CompleteCustomer
        {
            get { return completeCustomer; }
            set { completeCustomer = value; }
        }

        public int CompleteQuantity
        {
            get { return completeQuantity; }
            set { completeQuantity = value; }
        }
    }
}
