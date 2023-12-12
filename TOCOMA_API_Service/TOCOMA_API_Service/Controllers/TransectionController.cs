using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_API_Service.Service;
using TOCOMA_ERP_ClassLibrary.Models;

namespace TOCOMA_API_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransectionController : ControllerBase
    {
        private TransectionService transectionService;
        public TransectionController(TransectionService _oTransectionService)
        {
            transectionService = _oTransectionService;
        }

        #region ACC_COMPANY_VOUCHER_ PAYMENT VOUCHER
        [HttpPost]
        [Route("AddPaymentVoucher")]
        public ACC_COMPANY_VOUCHER_MODEL AddACC_COMPANY_VOUCHER_PAYMENTVOUCHER([FromBody] ACC_COMPANY_VOUCHER_MODEL currency)
        {
            bool flag = false;
            if (ModelState.IsValid) return transectionService.AddACC_COMPANY_VOUCHER_PAYMENTVOUCHER(currency);
            return null;
        }
        [HttpPost]
        [Route("UpdatePaymentVoucher")]
        public ACC_COMPANY_VOUCHER_MODEL UpdateACC_COMPANY_VOUCHER_PAYMENTVOUCHER([FromBody] ACC_COMPANY_VOUCHER_MODEL currency)
        {
            if (ModelState.IsValid) return transectionService.UpdateACC_COMPANY_VOUCHER_PAYMENTVOUCHER(currency);
            return null;
        }
        [HttpPost]
        [Route("UpdatePaymentStatus")]
        public VendorPaymentViewModel UpdateACC_COMPANY_VOUCHER_PAYMENTVOUCHER([FromBody] VendorPaymentViewModel payment)
        {
            if (ModelState.IsValid) return transectionService.UpdatePaymentStatus(payment);
            return null;
        }
        //
        [HttpPost]
        [Route("UpdatePaymentReceiptStatus")]
        public CustomerPaymentViewModel UpdateACC_COMPANY_VOUCHER_PAYMENTReceiptVOUCHER([FromBody] CustomerPaymentViewModel payment)
        {
            if (ModelState.IsValid) return transectionService.UpdatePaymentReceiptStatus(payment);
            return null;
        }
        [HttpGet]
        [Route("GetVoucherList/{VoucherType}")]
        public List<ACC_COMPANY_VOUCHER_MODEL> GetVoucherList(int VoucherType)
        { return transectionService.GetVoucherList(VoucherType); }

        [HttpGet]
        [Route("GetPaymentVoucherByRefNo/{RefNo}")]
        public ACC_COMPANY_VOUCHER_MODEL GetPaymentVoucherByRefNo(string RefNo)
        { return transectionService.GetPaymentVoucherByRefNo(RefNo); }





        [HttpGet]
        [Route("GetACCVoucherByRefNo/{RefNo}")]
        public List<ACC_VOUCHER_MODEL> GetACCVoucherByRefNo(string RefNo)
        { return transectionService.GetACCVoucherByRefNo(RefNo); }

        //[HttpPost]
        //[Route("AddPaymentVoucherDetails")] 
        //public List<ACC_VOUCHER_MODEL> AddACC_COMPANY_VOUCHER_PAYMENT_VOUCHER_Details([FromBody] List<ACC_VOUCHER_MODEL> voucherDetails)
        //{
        //    if (ModelState.IsValid) return transectionService.ADD_ACC_VOUCHER_MODEL_PAYMENTVOUCHER_DETAILS(voucherDetails);
        //    return null;
        //}
        #endregion
        [HttpGet]
        [Route("GetChartList")]
        public List<PrimaryModel> GetChartList()
        {
            return transectionService.GetchartList();
        }
        [HttpGet]
        [Route("GetLedgerGroupList")]
        public List<LedgerGroupModel> GetLedgerGroupList()
        {
            return transectionService.GetLedgerGroupList();
        }
        //[HttpPost]
        //[Route("DeletePaymentByRefNo/{refNo}")]
        //public void DeletePaymentByRefNo(string refNo)
        //{
        //    transectionService.DeletePaymentByRefNo(refNo);
        //}
        [HttpPost]
        [Route("DeletePaymentByRefNo")]
        public ACC_COMPANY_VOUCHER_MODEL DeletePayment([FromBody] ACC_COMPANY_VOUCHER_MODEL currency)
        {
            if (ModelState.IsValid) return transectionService.DeletePaymentByRefNo(currency);
            return null;
        }
        [HttpGet]
        [Route("GetVoucherNo/{Type}")]
        public string GetVoucherNo(string Type)
        {
            return transectionService.GetACCVoucherNo(Type);
        }
        [HttpGet]
        [Route("GetPurchaseVoucherNo")]
        public string GetPurchaseVoucherNo()
        {
            return transectionService.GetPurchaseVoucherNo();
        }
        [HttpGet]
        [Route("GetTrialBalanceInfo/{fromDate}/{toDate}")]
        //[Route("GetTrialBalanceInfo")]
        public List<ACC_Trial_Balance_Report> GetTrialBalanceInfo(string fromDate, string toDate)
        {
            return transectionService.GetTrialBalance(fromDate, toDate);
        }
        [HttpGet]
        [Route("Get_ACC_TrialBalanceInfo/{fromDate}/{toDate}")]
        //[Route("GetTrialBalanceInfo")]
        public List<ACC_Trial_Balance_Report> Get_ACC_TrialBalanceInfo(string fromDate, string toDate)
        {
            return transectionService.GetACCTrialBalance(fromDate, toDate);
        }
        // 



        [HttpGet]
        [Route("GetProfitAndLoss/{fromDate}/{toDate}")]
        public List<ACC_PROFIT_LOSS> GetProfitAndLoss(string fromDate, string toDate)
        {
            return transectionService.GetProfitAndLoss(fromDate, toDate);
        }
        [HttpGet]
        [Route("GetBalanceSheet/{fromDate}/{toDate}")]
        public List<ACC_Balance_Sheet_Report> GetBalanceSheet(string fromDate, string toDate)
        {
            return transectionService.GetBalanceSheetReport(fromDate, toDate);
        }
        [HttpGet]
        [Route("GetGeneralLedger/{fromDate}/{toDate}/{ledgerName}")]
        public List<ACC_General_Ledger_Report> GetGeneralLedger(string fromDate, string toDate, string ledgerName)
        {
            return transectionService.GetGeneralLedgerReport(fromDate, toDate, ledgerName);
        }

        [HttpGet]
        [Route("GetLedgerDataByLedgerName/{ledgerName}")]
        public LedgerModel GetLedgerDataByLedgerName(string ledgerName)
        {
            return transectionService.GetLedgerDataByLedgerName(ledgerName);
        }
        [HttpGet]
        [Route("GetAccouncePayableBalance")]
        public List<clsAccount_Payable_Balance> GetAccouncePayableBalance()
        {
            return transectionService.GetAccounce_Payable_Balance();
        }
        [HttpGet]
        [Route("GetAccounceReceivableBalance")]
        public List<clsAccount_Payable_Balance> GetAccounceReceivableBalance()
        {
            return transectionService.GetAccounce_Receiveable_Balance();
        }
        [HttpPost]
        [Route("AddBillReq")]
        public clsMiscBillRequisition AddBillReq([FromBody] clsMiscBillRequisition miscbillReq)
        {
            bool flag = false;
            if (ModelState.IsValid) return transectionService.AddBillReq(miscbillReq);
            return null;
        }
        [HttpGet]
        [Route("GetBillReqList")]
        public List<clsMiscBillRequisition> GetBillReqList()
        {
            return transectionService.GetBillReqList();
        }
        [HttpGet]
        [Route("GetBillReqListById/{Id}")]
        public List<clsMiscBillRequisitionViewModel> GetBillReqList(string Id)
        {
            return transectionService.GetBillReqListById(Id);
        }
        [HttpGet]
        [Route("GetCashBalance")]
        public CashAndBankBalanceModel GetCashBalance()
        {
            return transectionService.GetCashBalance();
        }
        [HttpGet]
        [Route("GetBankLedgerList")]
        public List<LedgerModel> GetBankLedgerList()
        {
            return transectionService.GetBankLedgerList();
        }
        [HttpGet]
        [Route("GetBankVoucherList")]
        public List<ACC_VOUCHER_MODEL> GetBankVoucherList()
        {
            return transectionService.GetBankVoucherList();
        }

        //GetBankLedgerList  
    }
}

