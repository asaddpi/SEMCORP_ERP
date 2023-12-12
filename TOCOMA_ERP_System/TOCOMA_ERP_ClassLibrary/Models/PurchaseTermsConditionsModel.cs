using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PurchaseTermsConditionsModel
    {
        public int PURCHASE_TERMS_CONDITION_ID { get; set; }
        public int SALES_TERMS_CONDITION_ID { get; set; }
        public string TERMS_AND_CONDITIONS { get; set; }
        public bool STATUS { get; set; }
        public int POSITION { get; set; }
        public int TERMS_CONDITION_TYPE_ID { get; set; }
        public string TERMS_CONDITION_TYPE { get; set; }
        public bool IsChecked { get; set; }
        public int SL { get; set; }
    }
}
