using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class VoucherItem
    {
        public string Serial { get; set; }
        public string ComRefNo { get; set; }
        public string symbol { get; set; }
        public string particular { get; set; }
        public decimal debitAmount { get; set; }
        public decimal creditAmount { get; set; }
        public string ChequeNo { get; set; }
        //public DateTime ChequeDate { get; set; }
        public DateTime ChequeDate { get; set; }
        public string chequedate { get; set; }

        public string DrawnOn { get; set; }

        
    }
}
