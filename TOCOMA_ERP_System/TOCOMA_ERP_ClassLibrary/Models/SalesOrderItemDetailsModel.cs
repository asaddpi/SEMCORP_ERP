using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class SalesOrderItemDetailsModel
    {
        public int SALES_ORDER_DETAILS_ID { get; set; }
       public int SALES_ID { get; set; }
        public string PO_WO_NUMBER { get; set; }
        public int ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public double SALES_QUANTITY { get; set; }
        public string UOM { get; set; }
        public string PACK_SIZE { get; set; }
        public double UNIT_PRICE { get; set; }
        public double AIT { get; set; }
        public double VAT { get; set; }
        public double TOTAL_PRICE { get; set; }
    }
}
