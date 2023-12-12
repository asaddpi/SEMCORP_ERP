using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class Acc_LedgerModel
    {
        public int LEDGER_ENTRY_ID { get; set; }
        public int TRANSACTION_ID { get; set; }
        public int ACCOUNT_ID { get; set; }
        public string ENTRY_TYPE { get; set; }
        public double AMOUNT { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public int COST_CENTER_ID { get; set; }
    }
}
