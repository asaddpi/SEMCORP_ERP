using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class DeliveryNoteViewModel : DeliveryNoteDetailsEntity
    {
        //public int DELIVERY_ID { get; set; }
        public string DELIVERY_DATE { get; set; }
        public string DELIVERY_TIME { get; set; }
        public string WO_NUMBER { get; set; }
        public string WORK_NAME { get; set; }
        //public string DELIVERY_NOTE_NO { get; set; }
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CORPORATE_ADDRESS { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_PERSON_PHONE { get; set; }
        public string CONTACT_PERSON_EMAIL { get; set; }
        public string CONTACT_PERSON_DESIGNATION { get; set; }
        public string SHIPPING_PROJECT_NAME { get; set; }
        public int CUSTOMER_PROJECT_ID { get; set; }
        public string CARRING_BY { get; set; }
        public string SALES_PERSON { get; set; }
        public string DELIVERY_PERSON { get; set; }
        public string ITEM_CATEGORY { get; set; }
        public string DELIVERY_LOCATION { get; set; }
        public string TOTAL_WEIGHT { get; set; }
        public string STATUS { get; set; }
        public int SL { get; set; }

        
    }
}
