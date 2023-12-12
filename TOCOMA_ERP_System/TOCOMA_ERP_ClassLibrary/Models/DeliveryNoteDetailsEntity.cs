using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class DeliveryNoteDetailsEntity
    {
        public int DELIVERY_DETAILS_ID { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        //public string SL { get; set; }
        public double QUANTITY { get; set; }
        public string UNIT { get; set; }
        public int DELIVERY_ID { get; set; }
        public string DELIVERY_NOTE_NO { get; set; }
    }
}
