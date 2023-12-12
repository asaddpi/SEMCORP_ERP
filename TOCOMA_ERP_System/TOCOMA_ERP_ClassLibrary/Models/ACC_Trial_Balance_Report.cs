using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ACC_Trial_Balance_Report
    {
        public string GR_NAME { get; set; }
        public string GR_PARENT { get; set; }
        public string GR_OPENING { get; set; }
        public string GR_DEBIT { get; set; }
        public string GR_CREDIT { get; set; }
        public string C_GR_DEBIT { get; set; }
        public string C_GR_CREDIT { get; set; }
        public string BRANCH_NAME { get; set; }
        
    }
}
