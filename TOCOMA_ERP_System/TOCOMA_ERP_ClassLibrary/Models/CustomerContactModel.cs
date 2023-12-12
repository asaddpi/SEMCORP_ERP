using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class CustomerContactModel
    {
      public int CUSTOMER_CONTACT_ID { get; set; }
      public string CUSTOMER_VENDOR_CODE { get; set; }
      public string NAME { get; set; }
      public string DESIGNATION { get; set; }
        public int DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string WECHAT { get; set; }
        public string WHATSAPP { get; set; }
        public string TYPE { get; set; }
    }
}
