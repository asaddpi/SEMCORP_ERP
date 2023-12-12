using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class Stock_Details_Model
    {
        public int STOCK_DETAILS_ID { get; set; }
        public int STOCK_ID { get; set; }
        public int ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public string PACK_SIZE { get; set; }
        public string UOM { get; set; }
        public double STOCK_IN_QUANTITY { get; set; }
        public double STOCK_OUT_QUANTITY { get; set; }
        public double UNIT_PRICE { get; set; }
        public double TOTAL_PRICE { get; set; }
        public double BALANCE { get; set; }
        public int WAREHOUSE_ID { get; set; }
        public double TOTAL_VALUE { get; set; }
        public string REMARKS { get; set; }
    }
}
