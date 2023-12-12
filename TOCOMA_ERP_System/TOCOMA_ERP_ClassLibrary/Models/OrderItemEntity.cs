using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class OrderItemEntity
    {
        public int ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }
        public string PACK_SIZE { get; set; }
        public string UOM { get; set; }
    }
}
