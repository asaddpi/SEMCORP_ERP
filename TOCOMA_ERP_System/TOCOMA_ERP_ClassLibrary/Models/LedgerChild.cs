using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class LedgerChild
    {
        public int LEDGER_SERIAL { get; set; }
        public string LEDGER_NAME { get; set; }
        public string LEDGER_CURRENCY_SYMBOL { get; set; }
        public int LEDGER_CASH_FLOW_TYPE { get; set; }
        public string LEDGER_PARENT_GROUP { get; set; }
        public string LEDGER_PRIMARY_GROUP { get; set; }
        public string LEDGER_ONE_DOWN { get; set; }
        public string LEDGER_PARTY_UNDER { get; set; }
        public string LEDGER_NAME_DEFAULT { get; set; }
        public string LEDGER_STATUS { get; set; }
        public decimal LEDGER_OPENING_BALANCE { get; set; }
        public decimal LEDGER_DEBIT_BALANCE { get; set; }
        public decimal LEDGER_CREDIT_BALANCE { get; set; }
        public decimal LEDGER_FC_OPENING_BALANCE { get; set; }
        public string LEDGER_CURRENCY_NAME { get; set; }
        public string LEDGER_ADDRESS1 { get; set; }
        public string LEDGER_ADDRESS2 { get; set; }
        public string LEDGER_CITY { get; set; }
        public string LEDGER_POSTAL { get; set; }
        public string LEDGER_FAX { get; set; }
        public string LEDGER_PHONE { get; set; }
        public string LEDGER_MOBILE { get; set; }
        public string LEDGER_EMAIL { get; set; }
        public string LEDGER_COUNTRY { get; set; }
        public string LEDGER_COMMENTS { get; set; }
        public string LEDGER_BENEFIT { get; set; }
        public string LEDGER_VECTOR { get; set; }
        public string LEDGER_LEVEL { get; set; }
        public string DR_CR { get; set; }
        public int LEDGER_GROUP { get; set; }
        public int LEDGER_PRIMARY_TYPE { get; set; }
        public int LEDGER_DEFAULT { get; set; }
        public string ENTRYBY { get; set; }
        public string UPDATEBY { get; set; }
    }
}
