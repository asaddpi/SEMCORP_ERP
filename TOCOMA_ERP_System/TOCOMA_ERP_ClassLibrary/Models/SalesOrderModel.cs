using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class SalesOrderModel
    {
        public string SALES_ID { get; set; }
        public string SALES_ORDER_NO { get; set; }
        public string PO_WO_NUMBER { get; set; }
        public string COMP_REF_NO { get; set; }
        public string LEDGER_NAME { get; set; }
        public string VOUCHER_TYPE { get; set; }        
        public string PO_WO_DATE { get; set; }
        public string SALES_DATE { get; set; }
        public string SALES_ORDER_RECEIVED_DATE { get; set; }
        public string ORDER_RECEIVED_BY { get; set; }
        public int CUSTOMER_ID { get; set; }
        public int CUSTOMER_PROJECT_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string DELIVERY_DATE { get; set; }
        public string ASSIGN_TO { get; set; }
        public string ETA_TL_WH_1st_DATE { get; set; }
        public string ETA_TL_WH_2nd_DATE { get; set; }
        public string ETA_TL_WH_3rd_DATE { get; set; }
        public string EXPECTED_DELIVERY_1st_DATE { get; set; }
        public string EXPECTED_DELIVERY_2nd_DATE { get; set; }
        public string EXPECTED_DELIVERY_3rd_DATE { get; set; }
        public string PARCHENTAGE_OF_COMPLETE { get; set; }
        public string STATUS_OF_SHIPMENT { get; set; }
        public string NEXT_INSTRUCTION { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public decimal DISCOUNT_IN_PARCHENT { get; set; }
        public decimal DISCOUNT_IN_TAKA { get; set; }
        public decimal ADVANCE_PAID_IN_PARCHENT { get; set; }
        public decimal ADVANCE_PAID_IN_TAKA { get; set; }
        public decimal DELIVERY_CHARGE { get; set; }
        public decimal OTHERS_CHARGE { get; set; }
        public string QUOTATION_REFERENCE { get; set; }
        public string PI_REFERENCE { get; set; }
        public string TERMS_AND_CONDITION { get; set; }
        public string SALES_ORDER_REFERENCE { get; set; }
        public string DELIVERY_NOTE_NO { get; set; }
        public string DELIVERY_NOTE_DATE { get; set; }
        public string CUSTOMER_PO_NO { get; set; }
        public string CUSTOMER_PO_DATE { get; set; }
        public double GRAND_TOTAL { get; set; }
        public string CURRENCY { get; set; }
        public string SALES_PERSON { get; set; }
        public string DELIVERY_BY { get; set; }
        public string GATE_PASS_NO { get; set; }
        public string QUOTATION_NO { get; set; }
        public string INVOICE_NO { get; set; }
        public string INVOICE_DATE { get; set; }
        public string TOTAL_INVOICE_AMOUNT { get; set; }
        public string PAYMENT_STATUS { get; set; }
        public string PAYMENT_RECEIVED_DATE { get; set; }
        public string REMARKS { get; set; }
        public string REG_BY { get; set; }
        public string UPD_BY { get; set; }
        public bool SuccessStatus { get; set; }


        public List<SalesItemDetailsModel> sOrderDetailsList { get; set; }

        public ACC_COMPANY_VOUCHER_MODEL acc_com_VoucherModel { get; set; }
        public List<ACC_VOUCHER_MODEL> acc_Voucher_Model { get; set; }
        public List<ACC_VOUCHER_ITEM_MODEL> acc_VoucherItemList { get; set; }
    }
}
