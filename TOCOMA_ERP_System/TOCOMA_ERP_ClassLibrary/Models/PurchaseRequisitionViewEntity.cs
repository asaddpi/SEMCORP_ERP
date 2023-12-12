using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PurchaseRequisitionViewEntity
    {
        public int PURCHASE_REQUISITION_ID { get; set; }
        public string REQUISITION_NO { get; set; }
        public string REQUESTED_BY { get; set; }
        public int REQUEST_DEPARTMENT_ID { get; set; }
        public int REQUEST_RECEIVE_DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string REQUEST_DEPARTMENT { get; set; }
        public string REQUEST_RECEIVE_DEPARTMENT { get; set; }
        public string REQUEST_DATE { get; set; }
        public string REQUIRED_DATE { get; set; }
        public string REQUEST_FOR { get; set; }
        public string PRIORITY { get; set; }
        public string PAYMENT_MODE { get; set; }
        public string REQUISITION_PURPOSE { get; set; }
        public double REQUISITION_TOTAL { get; set; }
        public string STATUS { get; set; }
        public string REG_BY { get; set; }
        public string ENTRYDATE { get; set; }
        
    }
}
