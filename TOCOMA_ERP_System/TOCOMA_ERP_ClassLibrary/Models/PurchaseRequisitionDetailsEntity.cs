using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PurchaseRequisitionDetailsEntity
    {
        public int PURCHASE_REQUISITION_DETAILS_ID { get; set; }
        public int PURCHASE_REQUISITION_ID { get; set; }
        public string REQUISITION_NO { get; set; }
        public int ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public string PACK_SIZE { get; set; }
        public string UOM { get; set; }
        public double QUANTITY { get; set; }
        public double RATE { get; set; }
        public double TOTAL { get; set; }
        public double ESTIMATED_AMOUNT { get; set; }
        public double ESTIMATED_COST { get; set; }

    }
}
