using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PurchaseInvoiceLocal
    {
        public int PO_ID { get; set; }
        public string PO_NUMBER_SHORT_CODE { get; set; }
        public string PO_NUMBER_LONG_CODE { get; set; }
        public string PO_DATE { get; set; }
        public string QUOTATION_REFERANCE_NO { get; set; }
        public string QUOTATION_REFERANCE_DATE { get; set; }
        public int VENDOR_ID { get; set; }
        public string VENDOR_NAME { get; set; }
        public string REGISTERED_ADDRESS { get; set; }
        public string IMPORT_FROM { get; set; }
        public string VENDOR_TYPE_STATUS { get; set; }
        public string NAME_SALES { get; set; }
        public string PHONE_SALES { get; set; }
        public string EMAIL_SALES { get; set; }
        public string CONTACT_PERSON_NAME_1 { get; set; }
        public string CONTACT_PERSON_CONTACT_NO_1 { get; set; }
        public string CONATACT_PERSON_EMAIL_1 { get; set; }
        public int CONSIGNEE_ID { get; set; }
        public string CURRENCY { get; set; }

        public string CONSIGNEE_NAME { get; set; }
        public string INCOTERM { get; set; }
        public string ADDRESS { get; set; }
        public string TERMS_OF_DELIVERY { get; set; }
        public string SHIPPING_ADDRESS { get; set; }
        public string DELIVERY_MODE { get; set; }
        public string PAYMENT_TERM { get; set; }
        public string TRUNSECTION_TYPE { get; set; }
        public string PAYMENT_MODE { get; set; }
        public string TRADE_TERM { get; set; }
        public string SHIP_VIA { get; set; }
        public string CONTAINER_SIZE { get; set; }
        public string BIN { get; set; }
        public string TIN { get; set; }
        public string VENDOR_CONTACT_EMAIL { get; set; }
        public string MOBILE { get; set; }
        public string LABEL { get; set; }
        public string SHELF_LIFE { get; set; }
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
        public string ETD_1st_Date { get; set; }
        public string ETD_2nd_Date { get; set; }
        public string ETD_3rd_Date { get; set; }
        public string ETD_4th_Date { get; set; }
        public string ETA_1st_Date { get; set; }
        public string ETA_2nd_Date { get; set; }
        public string ETA_3rd_Date { get; set; }
        public string ETA_4th_Date { get; set; }
        public string EA_WH_1st_Date { get; set; }
        public string EA_WH_2nd_Date { get; set; }
        public string EA_WH_3rd_Date { get; set; }
        public string EA_WH_4th_Date { get; set; }
        public string RECEIVED_DATE { get; set; }
        public string SHIPMENT_STATUS { get; set; }
        public string REG_BY { get; set; }
        public string REPORT_TYPE { get; set; }
        public int ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public string UOM { get; set; }
        public string QUANTITY { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_NO { get; set; }
        public string EMAIL { get; set; }
        public string CONTACT_PERSON_DESIGNATION { get; set; }
        public string RECEIVE_BY { get; set; }
        public string INVOICE_NO { get; set; }
        public string INVOICE_DATE { get; set; }
        public double UNIT_PRICE { get; set; }
        public string INVOICE_BREAKDOWN_AMOUNT { get; set; }
        public string TOTAL_INVOICE_AMOUNT { get; set; }
        public string PAYMENT_STATUS { get; set; }
        public string PACK_SIZE { get; set; }
        public string PACKAGING_INSTRUCTION { get; set; }
        public string OTHER_TERMS_AND_CONDITION { get; set; }
        public int SL { get; set; }
        
    }
}
