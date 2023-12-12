using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class StockSummeryReportModel
    {
        public string BRAND_NAME { get; set; }
        public string ITEM_NAME { get; set; }
        public string PACK_SIZE { get; set; }
        public string UOM { get; set; }
        public double OPENING_BALANCE { get; set; }
        public double STOCK_IN_QUANTITY { get; set; }
        public double STOCK_OUT_QUANTITY { get; set; }
        public double BALANCE { get; set; }
        public double STOCK_LIMIT { get; set; }
        public string WAREHOUSE_NAME { get; set; }
        public double UNIT_PRICE { get; set; }
        public double TOTAL_VALUE { get; set; }
        public string REMARKS { get; set; }

    }
}
