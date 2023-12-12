using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class LedgerGroupModel
    {
        public int GR_SERIAL { get; set; }
        [Required(ErrorMessage ="Please Input Group Name")]
        public string GR_NAME { get; set; }
        public string GR_PARENT { get; set; }
        public string GR_ONE_DOWN { get; set; }
        public string GR_PRIMARY { get; set; }
        public int GR_LEVEL { get; set; }
        public int GR_GROUP { get; set; }
        public int GR_PRIMARY_TYPE { get; set; }
        public string GR_CASH_FLOW_TYPE { get; set; }
        public int GR_PARENT_POSITION { get; set; }
        public string ENTRYBY { get; set; }
        public string UPDATEBY { get; set; }
        public bool Success_Status { get; set; }


        public List<LedgerModel> ledgerNameList { get; set; } 
      
    }
}
