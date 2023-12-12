using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ACC_General_Ledger_Report
    {
        public string COMP_VOUCHER_DATE { get; set; }
        public string COMP_REF_NO { get; set; }
        public string COMP_VOUCHER_TYPE { get; set; }
        public decimal VOUCHER_DEBIT_AMOUNT { get; set; }
        public decimal VOUCHER_CREDIT_AMOUNT { get; set; }
    }
}
