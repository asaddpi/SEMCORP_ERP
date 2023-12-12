using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class SessionData
    {
        public static List<ACC_VOUCHER_MODEL> paymentDataList { get; set; }
        public static List<clsMiscBillRequisitionViewModel> miscBillReqList { get; set; }
        public static List<ACC_Trial_Balance_Report> trialBalanceList { get; set; }
        public static List<ACC_PROFIT_LOSS> profitAndLossList { get; set; }
        public static List<ACC_Balance_Sheet_Report> balanceSheetList { get; set; }
        public static List<ACC_General_Ledger_Report> generalLedgerList { get; set; }
        public static List<RStockInformation> stockStatementListReport { get; set; }
        public static List<PurchaseOrderViewModel> purchaseRecortList { get; set; }
        public static LedgerModel sessionLedgerModel { get; set; }
        public static string From_date { get; set; }
        public static string To_date { get; set; }
        public static decimal TotalProfitLoss { get; set; }
    }
}
