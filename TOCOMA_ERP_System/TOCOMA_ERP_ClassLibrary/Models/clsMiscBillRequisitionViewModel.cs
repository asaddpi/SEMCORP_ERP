using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class clsMiscBillRequisitionViewModel
    {
        public int BILL_REQUISITION_ID { get; set; }
        public string DATE { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LEDGER_NAME { get; set; }
        public string LOCATION_FROM { get; set; }
        public string DESTINATION_TO { get; set; }
        public string PURPOSE { get; set; }
        public string TOUR_BY { get; set; }
        public decimal AMOUNT { get; set; }
        public string EMPLOYEE { get; set; }
        public string STATUS { get; set; }
        public int Operation_Type { get; set; }
    }
}
