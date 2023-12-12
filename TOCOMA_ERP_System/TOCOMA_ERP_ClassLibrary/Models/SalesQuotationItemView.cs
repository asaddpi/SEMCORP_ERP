using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class SalesQuotationItemView
    {
        public string SALES_QUOTATION_DETAILS_ID { get; set; }
        public string SALES_QUOTATION_ID { get; set; }
        public string QUOTATION_NO { get; set; }
        public string ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public string SERVICE_CODE { get; set; }
        public string SERVICE_NAME { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public string ORDER_QUANTITY { get; set; }
        public string UOM { get; set; }
        public string PACK_SIZE { get; set; }
        public decimal UNIT_PRICE { get; set; }
        public decimal AIT { get; set; }
        public decimal VAT { get; set; }
        public decimal TOTAL_PRICE { get; set; }
        public string REG_DATE { get; set; }
        public string UPD_DATE { get; set; }
        public string SL { get; set; }
    }
}
