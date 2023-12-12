using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PurchaseOrderEntity
    {
        public int PO_ID { get; set; }
        public string PO_NUMBER_SHORT_CODE { get; set; }
        public string PO_NUMBER_LONG_CODE { get; set; }
        public DateTime PO_DATE { get; set; }
        public string QUOTATION_REFERANCE_NO { get; set; }
        public string QUOTATION_REFERANCE_DATE { get; set; }
        public int VENDOR_ID { get; set; }
        public int CONSIGNEE_ID { get; set; }
        public string TERMS_OF_DELIVERY { get; set; }
        public string SHIPPING_ADDRESS { get; set; }
        public string DELIVERY_MODE { get; set; }
        public string PAYMENT_TERM { get; set; }
        public string PAYMENT_MODE { get; set; }
        public string TRADE_TERM { get; set; }
        public string SHIP_VIA { get; set; }
        public string CONTAINER_SIZE { get; set; }
        public string DELIVERY_TIME { get; set; }
        public string COUNTRY_OF_ORIGIN { get; set; }
        public string PORT_OF_LOADING { get; set; }
        public string PORT_OF_DISCHARGE { get; set; }
        public string SEA_FREIGHT { get; set; }
        public double GRAND_TOTAL { get; set; }
        public string SHIPPING_MARK { get; set; }
        public string PACKAGING { get; set; }
        public string IDENTIFICATION_NUMBER { get; set; }
        public string DOCUMENT_NO { get; set; }
        public string RECEIVED_BY { get; set; }
        public string SUPPLIER_INVOICE_NO { get; set; }
        public string SUPPLIER_INVOICE_DATE { get; set; }
        public string ORDER_BY { get; set; }
        public DateTime ETD_1st_Date { get; set; }
        public DateTime ETD_2nd_Date { get; set; }
        public DateTime ETD_3rd_Date { get; set; }
        public DateTime ETD_4th_Date { get; set; }
        public DateTime ETA_1st_Date { get; set; }
        public DateTime ETA_2nd_Date { get; set; }
        public DateTime ETA_3rd_Date { get; set; }
        public DateTime ETA_4th_Date { get; set; }
        public DateTime EA_WH_1st_Date { get; set; }
        public DateTime EA_WH_2nd_Date { get; set; }
        public DateTime EA_WH_3rd_Date { get; set; }
        public DateTime EA_WH_4th_Date { get; set; }
        public DateTime RECEIVED_DATE { get; set; }
        public string SHIPMENT_STATUS { get; set; }
        public string REG_BY { get; set; }
        
    }
}
