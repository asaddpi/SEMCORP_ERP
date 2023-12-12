using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class AccountsHead
    {
        public string Item { get; set; }
        public List<LG_Group> parentGrouplist { get; set; } = new List<LG_Group>();
        public List<LedgerChild> Childlist { get; set; } = new List<LedgerChild>();
        
    }
}
