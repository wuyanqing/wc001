using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEDSHOW
{
    public class RefreshData
    {
        private int total;//总数

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        private int untotal;//未补货

        public int Untotal
        {
            get { return untotal; }
            set { untotal = value; }
        }
        private string product_name;//卷烟名称

        public string Product_name
        {
            get { return product_name; }
            set { product_name = value; }
        }


        private string quantity;//数量

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
       
     
      
        private string cell_name;//货位名称

        public string Cell_name
        {
            get { return cell_name; }
            set { cell_name = value; }
        }

       
     
    }
}
