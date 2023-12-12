using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ACC_VOUCHER_ITEM_MODEL
    {
      public decimal BILL_TRAN_SERIAL { get; set; }
      public string BILL_TRAN_KEY{ get; set; }
      public string BRANCH_ID{ get; set; }
      public string COMP_REF_NO{ get; set; }
      public int COMP_VOUCHER_TYPE{ get; set; }
        public int ITEM_ID { get; set; }
      public DateTime COMP_VOUCHER_DATE{ get; set; }
      public int BILL_TRAN_POSITION{ get; set; }
      public string STOCKITEM_NAME{ get; set; }
      public string ITEM_NAME_BANGLA{ get; set; }
      public string STOCKITEM_DESCRIPTION{ get; set; }
      public string GODOWNS_NAME{ get; set; }
      public int BILL_TRAN_PREV_NEW{ get; set; }
      public decimal BILL_QUANTITY{ get; set; }
      public decimal BILL_QUANTITY_BONUS { get; set; }
      public decimal BILL_RATE { get; set; }
      public string BILL_UOM{ get; set; }
      public string BILL_PER{ get; set; }
      public decimal BILL_UOM_BONUS { get; set; }
      public decimal BILL_AMOUNT { get; set; }
      public decimal BILL_ADD_LESS { get; set; }
      public decimal BILL_ADD_LESS_AMOUNT { get; set; }
      public decimal BILL_NET_AMOUNT { get; set; }
      public string BILL_TRAN_TOBY{ get; set; }
      public int BILL_TRAN_ISOPEN{ get; set; }
      public int BILL_STATUS{ get; set; }
      public string SALES_REP{ get; set; }
      public string VOUCHER_CURRENCY_SYMBOL{ get; set; }
      public decimal VOUCHER_FC_AMOUNT{ get; set; }
      public decimal FC_CONVERSION_RATE{ get; set; }
      public string AGNST_COMP_REF_NO{ get; set; }
      public string AGNST_COMP_REF_NO1{ get; set; }
      public string INV_LOG_NO{ get; set; }
      public decimal SHORT_QTY{ get; set; }
      public decimal G_COMM_PER{ get; set; }
      public int STAFF_QTY{ get; set; }
      public string STOCKGROUP_NAME{ get; set; }
      public decimal BILL_SALE_BALANCE{ get; set; }
      
    }
}
