using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ItemSubCategory
    {
        public int SUBCATEGORY_ID { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public int CATEGORY_ID { get; set; }
        public string CATEGORY_NAME { get; set; }
        public string SUBCATEGORY_NAME { get; set; }
        public int Operation_Type { get; set; }
    }
}
