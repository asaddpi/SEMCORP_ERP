using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class OthersRequisitionItemsModel
    {
        public int PURCHASE_REQUISITION_OTHERS_ID { get; set; }
        public string OTHERS_ITEM { get; set; }
        public double QUANTITY { get; set; }
        public string UNIT { get; set; }
        public double RATE { get; set; }
        public double TOTAL { get; set; }
    }
}
