using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ProjectWiseStockModel
    {
        public string CUSTOMER_NAME { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string PROJECT_CODE { get; set; }
        public string SHIPPING_PROJECT_NAME { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        public string STOCK_QUANTITY { get; set; }
        public string UNIT { get; set; }
        public string USED_QUANTITY { get; set; }
        public string DAMAGED_QUANTITY { get; set; }
        public string RETURN_QUANTITY { get; set; }
        public string SHIFT_QUANTITY { get; set; }

    }
}
