using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ServiceEntity
    {
        public int SERVICE_ID { get; set; }
        public int SERVICE_CATEGORY_ID { get; set; }
        public string SERVICE_CODE { get; set; }
        public string SERVICE_NAME { get; set; }
        public int OPERATION_TYPE { get; set; }
    }
}
