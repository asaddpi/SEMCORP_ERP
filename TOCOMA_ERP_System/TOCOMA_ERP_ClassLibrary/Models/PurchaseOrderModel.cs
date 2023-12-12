using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PurchaseOrderModel
    {
        public int PO_ID { get; set; }
        public string PO_NUMBER_LONG_CODE { get; set; }
        public string PO_NUMBER { get; set; }
        public string VOUCHER_NO { get; set; }
        public string VOUCHER_TYPE { get; set; }
        public string SUPPLIER_MEMO_NO { get; set; }
        public string REQUISITION_NO { get; set; }
        public string COMP_REF_NO { get; set; }
        public string BILL_TRAN_KEY { get; set; }
        public string LEDGER_NAME { get; set; }
        public string QUOTATION_REFERANCE_NO { get; set; }

        public string QUOTATION_REFERANCE_DATE { get; set; }
        public string TRUNSECTION_TYPE { get; set; }
        public string PO_DATE { get; set; }
        public string VENDOR_NAME { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public int BUSINESS_ID { get; set; }
        public int VENDOR_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public int CONSIGNEE_ID { get; set; }
        public string TERMS_OF_DELIVERY { get; set; }
        public string TERMS_CONDITION { get; set; }
        public string SHIPPING_ADDRESS { get; set; }
        public string DELIVERY_MODE { get; set; }
        public string PAYMENT_TERM { get; set; }
        public string PAYMENT_MODE { get; set; }
        public string CURRENCY_NAME { get; set; }
        public string INCOTERM { get; set; }
        public string SHIP_VIA { get; set; }
        public string CONTAINER_SIZE { get; set; }
        public string GOOD_RECEIVE_NOTE { get; set; }
        public string DELIVERY_TIME { get; set; }
        public string COUNTRY_OF_ORIGIN { get; set; }
        public string IMPORT_FROM { get; set; }
        public string PORT_OF_LOADING { get; set; }
        public string PORT_OF_DISCHARGE { get; set; }
        public string CARRING_WAY_NAME { get; set; }
        public decimal CARRING_WAY_COST { get; set; }
        public decimal LABOUR_COST { get; set; }
        public decimal OTHERS_COST { get; set; }
        public decimal SUB_TOTAL { get; set; }
        public decimal TAX_RATE { get; set; }
        public decimal TAX_AMOUNT { get; set; }
        public decimal VAT_RATE { get; set; }
        public decimal VAT_AMOUNT { get; set; }
        public decimal DISCOUNT_RATE { get; set; }
        public decimal DISCOUNT_AMOUNT { get; set; }
        public decimal ADVANCE { get; set; }

        public double GRAND_TOTAL { get; set; }
        public string SHIPPING_MARK { get; set; }
        public string LC_NO { get; set; }
        public string LC_STATUS { get; set; }
        public string LC_DATE { get; set; }
        public string BIN { get; set; }
        public string TIN { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE { get; set; }
        public string PACKAGING_INSTRUCTION { get; set; }
        public string OTHER_TERMS_AND_CONDITION { get; set; }
        public string PACKAGING { get; set; }
        public string IDENTIFICATION_NUMBER { get; set; }
        public string LABEL { get; set; }
        public string SHELF_LIFE { get; set; }
        public string DOCUMENT_NO { get; set; }
        public string RECEIVED_BY { get; set; }
        public string REG_BY { get; set; }
        public string REPORT_TYPE { get; set; }
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
        public DateTime? RECEIVED_DATE { get; set; }
        public string INVOICE_NO { get; set; }
        public DateTime INVOICE_DATE { get; set; }
        public string SHIPMENT_STATUS { get; set; }
        public DateTime DECUMENT_DATE { get; set; }
        public string RECEIVE_BY { get; set; }
        public string BILL_NO { get; set; }
        public string CARRYING_BY { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public bool status { get; set; }


        public List<PurchaseOrderDetailsEntity> pOrderDetailsList { get; set; }

        public ACC_COMPANY_VOUCHER_MODEL acc_com_VoucherModel { get; set; }
        public List<ACC_VOUCHER_MODEL> acc_Voucher_Model { get; set; }
        public List<ACC_VOUCHER_ITEM_MODEL> acc_VoucherItemList { get; set; }
    }
}
