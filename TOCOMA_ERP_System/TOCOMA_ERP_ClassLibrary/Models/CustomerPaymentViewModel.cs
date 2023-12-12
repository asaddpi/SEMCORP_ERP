using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class CustomerPaymentViewModel
    {
        public string CUSTOMER_PAYMENT_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public int SALES_ID { get; set; }
        public string SALES_ORDER_NO { get; set; }
        public DateTime PAYMENT_DATE { get; set; }
        public string TYPE_OF_PAYMENT { get; set; }
        public string CHEQUE_NO { get; set; }
        public DateTime CHEQUE_DATE { get; set; }
        public int BANK_ID { get; set; }
        public string BANK_NAME { get; set; }
        public int BANK_BRANCH_ID { get; set; }
        public string BRANCH_NAME { get; set; }
        public double PAYMENT_AMOUNT { get; set; }
        public double AMOUNT_PAID { get; set; }
        public double AMOUNT_DUE { get; set; }
        public double OPENING_BALANCE { get; set; }
        public double CURRENT_BALANCE { get; set; }
        public string MONEY_RECEIPT_NO { get; set; }
        public DateTime NEXT_PAYMENT_DATE { get; set; }
        public string REMARKS { get; set; }
        public string INVOICE_NO { get; set; }
        public string RECEIVED_BY { get; set; }
        public double INVOICE_BREAKDOWN_AMOUNT { get; set; }
        public double TOTAL_INVOICE_AMOUNT { get; set; }
        public string PAYMENT_STATUS { get; set; }
        public string REG_BY { get; set; }
    }
}
