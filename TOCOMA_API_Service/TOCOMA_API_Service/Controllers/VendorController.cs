using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;
using TOCOMA_API_Service.Service;



namespace TOCOMA_API_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private VendorService vendorService;

        public VendorController(VendorService _ovendorService)
        {
            vendorService = _ovendorService;
        }
        [HttpPost]
        public VendorEntity AddVendor([FromBody] VendorEntity vendorEntity)
        {
            if (ModelState.IsValid) return vendorService.AddVendor(vendorEntity);
            return null;
        }
        [HttpPut]
        public VendorEntity UpdateVendor([FromBody] VendorEntity vendorEntity)
        {
            if (ModelState.IsValid) return vendorService.UpdateVendor(vendorEntity);
            return null;
        }
        [HttpPost]
        [Route("AddVendorPayment")]
        public VendorPaymentModel AddVendorPayment([FromBody] VendorPaymentModel vendorPayment)
        {
            if (ModelState.IsValid) return vendorService.AddVendorPayment(vendorPayment);
            return null;
        }

        [HttpGet]
        public List<VendorEntity> GetVendorList()
        {
            return vendorService.GetVendorList();
        }
        [HttpGet]
        [Route("GetVendorDetailsByVendorCode/{vendorCode}")]
        public VendorEntity GetVendorByVendorCode(string vendorCode)
        {
            return vendorService.GetVendorByVendorCode(vendorCode);
        }
        [HttpGet]
        [Route("GetVendorContactDetailsCode/{vendorCode}")]
        public List<CustomerContactModel> GetVendorContactDetailsCode(string vendorCode)
        {
            return vendorService.GetVendorContactDetailsCode(vendorCode);
        }
        
        //[HttpGet]
        //[Route("GetTest")]
        //public JsonResult GetTest()
        //{
        //    return reportcontroller.CreateReport();
        //}
        [HttpGet]
        [Route("GetTest")]
        public string GetTest()
        {
            //return reportcontroller.CreateReport();
            string responseURL = "";
            responseURL = "/SaveFile.aspx?FileType=XLSX";
            return responseURL;
        }
        [HttpGet]
        [Route("GetVendorAccountInfoByVendorId/{vendorId}")]
        public List<VendorAccountViewModel> GetVendorAccountInfo(string vendorId)
        {
            return vendorService.GetVendorAccountInfo(vendorId);
        }
        [HttpGet]
        [Route("GetVendorPaymentByPaymentDate/{date1}/{date2}")]
        public List<VendorPaymentViewModel> GetPurchaseOrderIdByPurchaseDate(DateTime date1, DateTime date2)
        {
            return vendorService.GetVendorPaymentBYDate(date1, date2);
        }
        [HttpGet]
        [Route("GetSupplierOutStandingBalance/{pono}")]
        public double GetOutStandingBalance(string pono)
        {
            return vendorService.GetSupplierOutStandingBalance(pono);
        }
        [HttpDelete]
        [Route("DeleteVendorContact/{id}")]
        public void DeleteUnit(int id)
        {
            vendorService.DeleteVendorContact(id);
        }
        

    }
}
