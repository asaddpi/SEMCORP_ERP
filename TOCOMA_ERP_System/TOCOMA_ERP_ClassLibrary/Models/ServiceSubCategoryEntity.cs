using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ServiceSubCategoryEntity
    {
        public int SERVICE_SUB_CATEGORY_ID { get; set; }
        public int SERVICE_CATEGORY_ID { get; set; }
        public string SERVICE_CATEGORY_NAME { get; set; }
        public string SERVICE_SUB_CATEGORY_NAME { get; set; }
        public int Operation_Type { get; set; }
    }
}
