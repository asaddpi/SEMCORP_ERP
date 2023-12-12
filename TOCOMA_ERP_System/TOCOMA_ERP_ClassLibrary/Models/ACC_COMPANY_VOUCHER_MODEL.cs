using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ACC_COMPANY_VOUCHER_MODEL
    {
      public int COMP_VOUCHER_SERIAL {get;set;}
      public string COMP_REF_NO {get;set;}
      public int SAMPLE_STATUS {get;set;}
      public string COMPANY_ID { get;set;}
      public string BRANCH_ID {get;set;}
      public string LEDGER_NAME {get;set;}
      public int COMP_VOUCHER_TYPE {get;set;}
      public DateTime COMP_VOUCHER_DATE {get;set;}
      public string COMP_VOUCHER_MONTH_ID {get;set;}
      public decimal COMP_VOUCHER_AMOUNT {get;set;}
      public decimal COMP_VOUCHER_ADD_AMOUNT {get;set;}
      public decimal COMP_VOUCHER_LESS_AMOUNT {get;set;}
      public decimal COMP_VOUCHER_NET_AMOUNT {get;set;}
      public decimal COMP_VOUCHER_PROCESS_AMOUNT {get;set;}
      public string COMP_VOUCHER_NARRATION {get;set;}
      public string COMP_VOUCHER_TERM_OF_PAYMENTS {get;set;}
      public string COMP_VOUCHER_DESPATCH_THRU {get;set;}
      public int COMP_VOUCHER_STATUS {get;set;}
      public int COMP_VOUCHER_FC {get;set;}
      public int COMP_AGAINST_REF {get;set;}
      public string AGNST_COMP_REF_NO {get;set;}      
      public string ENTRYBY {get;set;}
      public string UPDATEBY {get;set;}
      public bool status { get; set; }
      public string ErrorMessage { get; set; }


      public List<ACC_VOUCHER_MODEL> accVoucherList { get; set; } = new List<ACC_VOUCHER_MODEL>();
    }
}
