using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class InvoiceViewModel : InvoiceDetailsEntity
    {
        public int INVOICE_MASTER_ID { get; set; }
        public string INVOICE_NO { get; set; }
        public string WO_NUMBER { get; set; }
        public string WORK_NAME { get; set; }
        public string PROJECT_DETAILS { get; set; }
        public string PO_WO_DATE { get; set; }
        public string DELIVERY_NOTE_NO { get; set; }
        public int CUSTOMER_ID { get; set; }
        public int CUSTOMER_PROJECT_ID { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CORPORATE_ADDRESS { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_PERSON_PHONE { get; set; }
        public string CONTACT_PERSON_EMAIL { get; set; }
        public string CONTACT_PERSON_DESIGNATION { get; set; }
        public string SHIPPING_PROJECT_NAME { get; set; }
        public string SHIPPING_PROJECT { get; set; }
        public string ORDER_RECEIVED_BY { get; set; }
        
        public string INVOICE_DATE { get; set; }
        public string TERMS_CONDITION { get; set; }
        public decimal INVOICE_AMOUNT { get; set; }
        public decimal DISCOUNT { get; set; }
        public decimal TAX_AMOUNT { get; set; }
        public decimal VAT { get; set; }
        public decimal ADVANCE { get; set; }
        public decimal GRAND_TOTAL { get; set; }
        public string IN_WORDS { get; set; }
        public int SL { get; set; }
    }
}
