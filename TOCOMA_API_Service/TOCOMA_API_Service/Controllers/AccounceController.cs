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
    public class AccounceController : ControllerBase
    {
        private AccounceService accounceService;        
        public AccounceController(AccounceService _oaccounceService)
        {
            accounceService = _oaccounceService;
            
        }
        [HttpGet]
        [Route("GetJournal")]
        public List<Acc_GeneralJournalModel> GetJournalEntry()
        {
            return accounceService.GetJournal();
        }
        [HttpPost]
        [Route("AddTransection")]
        public Acc_TransectionModel AddTransection([FromBody] Acc_TransectionModel transectionModel)
        {
            if (ModelState.IsValid) return accounceService.AddTransection(transectionModel);
            return null;
        }
        [HttpPost]
        [Route("AddLedger")]
        public List<Acc_LedgerModel> AddLedger([FromBody] List<Acc_LedgerModel> ledgerModel)
        {
            if (ModelState.IsValid) return accounceService.AddJournalDetails(ledgerModel);
            return null;
        }
        
       [HttpGet]
        [Route("GetTransectionId")]
        public int GetPurchaseOrderId()
        {
            return accounceService.GetTransectionId();
        }
        [HttpGet]
        [Route("GetPayableDetailsView")]
        public List<AccPayableDetailsViewModel> GetAccouncePayable()
        {
            return accounceService.GetAccouncePayable();
        }
        [HttpGet]
        [Route("GetPayableSummery")]
        public List<AccPayableDetailsViewModel> GetPayableSummery()
        {
            return accounceService.GetAccouncePayableSummery();
        }
        
        [HttpGet]
        [Route("GetTransectionUnicCode")]
        public string GetTransectionCode()
        {
            return accounceService.GetTransectionUnicCode();
        }
        [HttpGet]
        [Route("GetSupplierAccountSummery")]
        public List<AccPayableDetailsViewModel> GetSupplierAccountSummery()
        {
            return accounceService.GetSupplierAccountSummery();
        }
        [HttpGet]
        [Route("GetSupplierTotalPaidAmount")]
        public List<AccPayableDetailsViewModel> GetSupplierTotalPaidAmount()
        {
            return accounceService.GetSupplierTotalPaidAmount();
        }
        
    }
}
