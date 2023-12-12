using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class SalesQuotationModel
    {
        public int SALES_QUOTATION_ID { get; set; }
        public string QUOTATION_NO { get; set; }
        public DateTime QUOTATION_DATE { get; set; }
        public string QUOTATION_TYPE{ get; set; }
        public DateTime VALID_UP_TO_DATE { get; set; }
        public string INCOTERM { get; set; }
        public string SHIP_VIA { get; set; }
        public string SALES_PERSON { get; set; }
        public string PHONE_NO { get; set; }
        public string PAYMENT_TERMS { get; set; }
        public string EXPECTED_DELIVERY_DATE { get; set; }
        public string WORKING_METHOD { get; set; }
        public string USED_PRODUCT { get; set; }
        public string TERMS_AND_CONDITION { get; set; }
        public DateTime INQUERY_DATE { get; set; }
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public double SALES_TOTAL { get; set; }
        public double UNTAXABLE_AMOUNT { get; set; }
        public double MOBILIZATION_COST { get; set; }
        public double TAX_RATE { get; set; }
        public double TAX_AMOUNT { get; set; }
        public double VAT_RATE { get; set; }
        public double VAT_AMOUNT { get; set; }
        public double OTHER_COST { get; set; }
        public double DISCOUNT_RATE { get; set; }
        public double DISCOUNT_AMOUNT { get; set; }        
        public string IN_WORD { get; set; }
        public string REG_BY { get; set; }
        public string STATUS { get; set; }
        public int SL { get; set; }
        
        //public string CORPORATE_ADDRESS { get; set; }
        //public string CONTACT_PERSON_NAME { get; set; }
        //public string CONTACT_PERSON_PHONE { get; set; }
        //public string CONTACT_PERSON_EMAIL { get; set; }

        public List<SalesQuotationAmountChartModel> chartList { get; set; }
    }
}
