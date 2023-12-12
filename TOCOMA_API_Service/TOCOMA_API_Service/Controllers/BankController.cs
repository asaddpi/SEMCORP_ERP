using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;
using TOCOMA_API_Service.Service;

namespace Tocoma_ERP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private BankService bankService;
        public BankController(BankService _ObankService)
        {
            bankService = _ObankService;
        }
        [HttpGet]
        public List<BankModel> BankList()
        {
            return bankService.GetBankList();
        }
        [HttpGet]
        [Route("GetBranchList/{BankId}")]
        public List<BankBranchModel> branchList(int BankId)
        {
            return bankService.GetBranchList(BankId);
        }
        [HttpPost]
        public BankModel AddBank([FromBody] BankModel bankModel)
        {
            if (ModelState.IsValid) return bankService.AddBank(bankModel);
            return null;
        }
        [HttpPut]
        public BankModel UpdateBank([FromBody] BankModel bankModel)
        {
            if (ModelState.IsValid) return bankService.UpdateBank(bankModel);
            return null;
        }
        [HttpDelete]
        [Route("DeleteBank/{id}")]
        public void DeleteBank(int id)
        {
            bankService.DeleteBank(id);
        }
        [HttpGet]
        [Route("GetAllBranch")]
        public List<BankBranchModel> GetAllBranch()
        {
            return bankService.GetAllBranch();
        }
        [HttpPost]
        [Route("AddBranch")]
        public BankBranchModel AddBranch([FromBody] BankBranchModel branchModel)
        {
            if (ModelState.IsValid) return bankService.AddBranch(branchModel);
            return null;
        }
        [HttpPut]
        [Route("UpdateBranch")]
        public BankBranchModel UpdateBranch([FromBody] BankBranchModel branchModel)
        {
            if (ModelState.IsValid) return bankService.UpdateBranch(branchModel);
            return null;
        }
        [HttpGet]
        [Route("GetBranchInfo/{branchId}")]
        public BankBranchModel GetBranchInfo(int branchId)
        {
            return bankService.GetBranchInfo(branchId);
            
        }
    }
}
