using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class CustomerProjectModel
    {
        public int CUSTOMER_PROJECT_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string SHIPPING_PROJECT_NAME { get; set; }
        public string PROJECT_NAME_SHORT_FORM { get; set; }
        public string PROJECT_CONTACT_PERSON_NAME { get; set; }
        public string PROJECT_CONTACT_PERSON_PHONE { get; set; }
        public string PROJECT_CONTACT_PERSON_EMAIL { get; set; }

        public string PROJECT_ADDRESS { get; set; }
        public int OPERATION_TYPE { get; set; }
    }
}
