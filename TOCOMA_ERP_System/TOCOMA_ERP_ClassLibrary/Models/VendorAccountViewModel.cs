using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class VendorAccountViewModel
    {
		public int VENDOR_ID { get; set; }
		public string PO_DATE { get; set; }
		public string TRANSECTION_DATE { get; set; }
		public string DESCRIPTION { get; set; }
		public string TRUNSECTION_TYPE { get; set; }
		public string QUOTATION_REFERANCE_NO { get; set; }
		public string PO_NUMBER_LONG_CODE { get; set; }
		public string INVOICE_NO { get; set; }
		public string INVOICE_DATE { get; set; }
		public string DELIVERY_CHALLAN_NO { get; set; }
		public string DELIVERY_DATE { get; set; }
		public string ITEM_NAME { get; set; }
		public string UOM { get; set; }
		public string QUANTITY { get; set; }
		public string UNIT_PRICE { get; set; }
		public double TOTAL_AMOUNT { get; set; }
		public double AIT { get; set; }
		public double VAT { get; set; }
		public double ADJ_RETURN_DISCOUNT { get; set; }
		public string PAYMENT_DATE { get; set; }
		public string TYPE_OF_PAYMENT { get; set; }
		public string CHEQUE_NO { get; set; }
		public string CHEQUE_DATE { get; set; }
		public string BANK_NAME { get; set; }
		public string BRANCH_NAME { get; set; }
		public double AMOUNT_PAID { get; set; }
		public string BALANCE { get; set; }
		public string REMARKS { get; set; }
	}
}
