using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class CustomerViewModel
    {
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CORPORATE_ADDRESS { get; set; }
        public string SHIPPING_ADDRESS { get; set; }
        public int CUSTOMER_TYPE_ID { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_PERSON_PHONE { get; set; }
        public string CONTACT_PERSON_EMAIL { get; set; }
        public string CONTACT_PERSON_DESIGNATION { get; set; }
        public int SL { get; set; }
    }
}
