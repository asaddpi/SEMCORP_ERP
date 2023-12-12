using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ACC_VOUCHER_MODEL
    {
        public string VOUCHER_SERIAL { get; set; }
        public string COMP_REF_NO { get; set; }
        public string VOUCHER_REF_KEY { get; set; }
        public string BRANCH_ID { get; set; }
        public int COMP_VOUCHER_TYPE { get; set; }
        public int COMP_VOUCHER_POSITION { get; set; }
        public DateTime COMP_VOUCHER_DATE { get; set; }
        public string Voucher_date { get; set; }
        public decimal COMP_VOUCHER_AMOUNT { get; set; }
        public string COMP_VOUCHER_NARRATION { get; set; }
        
        public string LEDGER_NAME { get; set; }
        public string VOUCHER_CHEQUE_NUMBER { get; set; }
        public DateTime VOUCHER_CHEQUE_DATE { get; set; }
        
        public string Voucherchequedate { get; set; }
        public string VOUCHER_CHEQUE_DRAWN_ON { get; set; }
        public string VOUCHER_BANK_DATE { get; set; }
        public decimal VOUCHER_DEBIT_AMOUNT { get; set; }
        public decimal VOUCHER_CREDIT_AMOUNT { get; set; }
        public decimal VOUCHER_ADD_AMOUNT { get; set; }
        public decimal VOUCHER_LESS_AMOUNT { get; set; }
        public string VOUCHER_TOBY { get; set; }
        public string VOUCHER_REVERSE_LEDGER { get; set; }
        public decimal VOUCHER_FC_DEBIT_AMOUNT { get; set; }
        public decimal VOUCHER_FC_CREDIT_AMOUNT { get; set; }
        public string VOUCHER_CURRENCY_SYMBOL { get; set; }
        public string VOUCHER_ADD_LESS_SIGN { get; set; }        
        public string ENTRYBY { get; set; }
        public string UPDATEBY { get; set; }
        
    }
}
