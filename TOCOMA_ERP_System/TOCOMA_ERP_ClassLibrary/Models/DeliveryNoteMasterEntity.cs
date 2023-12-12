using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class DeliveryNoteMasterEntity
    {
        public int DELIVERY_ID { get; set; }
        public DateTime DELIVERY_DATE { get; set; }
        public string DELIVERY_TIME { get; set; }
        public string WO_NUMBER { get; set; }
        public string WORK_NAME { get; set; }
        public string DELIVERY_NOTE_NO { get; set; }
        public string DELIVERY_LOCATION { get; set; }
        public string ITEM_CATEGORY { get; set; }
        public int CUSTOMER_ID { get; set; }
        public int CUSTOMER_PROJECT_ID { get; set; }
        public string DELIVERY_PERSON { get; set; }
        public string CARRING_BY { get; set; }
        public string TOTAL_WEIGHT { get; set; }
        public string STATUS { get; set; }

        public List<DeliveryNoteDetailsEntity>deliverlyDetailsList { get; set; }
       

    }
}
