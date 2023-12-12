using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class SalesItemDetailsModel
    {
        public int SALES_QUOTATION_DETAILS_ID { get; set; }
        public int SALES_QUOTATION_ID { get; set; }
        public string QUOTATION_NO { get; set; }
        public string PO_WO_NUMBER { get; set; }
        public string SALES_ORDER_NO { get; set; }
        public int SALES_ID { get; set; }
        public int SL { get; set; }
        public int ITEM_ID { get; set; }
        public string SERVICE_CODE { get; set; }
        public string SERVICE_NAME { get; set; }
        public string NUMBER_OF_PACK { get; set; }
        public string ITEM_NAME { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public double SALES_QUANTITY { get; set; }
        public double ORDER_QUANTITY { get; set; }
        public double DELIVERY_QUANTITY { get; set; }
        public string  UOM { get; set; }
        public string PACK_SIZE { get; set; }
        public decimal UNIT_PRICE { get; set; }
        public decimal AIT { get; set; }
        public decimal VAT { get; set; }
        public decimal TOTAL_PRICE { get; set; }
        public double AMOUNT { get; set; }
    }
}
