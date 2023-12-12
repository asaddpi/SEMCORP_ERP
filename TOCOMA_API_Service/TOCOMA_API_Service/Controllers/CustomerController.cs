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
    public class CustomerController : ControllerBase
    {
        private CustomerService customerService;
        public CustomerController(CustomerService _customerService)
        {
            customerService = _customerService;
        }
        [HttpGet]
        public List<CustomerModel> GetItemList()
        {
            return customerService.GetCustomerList();
        }
        [HttpGet]
        [Route("GetCustomerProjectList")]
        public List<CustomerModel> GetCustomerProjectList()
        {
            return customerService.GetCustomerProjectList();
        }
        [HttpPost]
        public CustomerModel AddItem([FromBody] CustomerModel customer)
        {
            if (ModelState.IsValid) return customerService.AddCustomer(customer);
            return null;
        }
        [HttpPut]
        public CustomerModel UpdateItem([FromBody] CustomerModel customer)
        {
            if (ModelState.IsValid) return customerService.UpdateCustomer(customer);
            return null;
        }
        [HttpPost]
        [Route("AddCustomerProject")]
        public CustomerProjectModel AddCustomerProject([FromBody] CustomerProjectModel customerproject)
        {
            if (ModelState.IsValid) return customerService.AddCustomerProject(customerproject);
            return null;
        }
        
        [HttpPut]
        [Route("UpdateCustomerProject")]
        public List<CustomerProjectModel> UpdateCustomerProject([FromBody] List<CustomerProjectModel> customerproject)
        {
            if (ModelState.IsValid) return customerService.UpdateCustomerProject(customerproject);
            return null;
        }
        [HttpGet]
        [Route("GetProjectDataByProjectId/{projectId}")]
        public CustomerProjectModel GetProjectListByProjectId(string projectId)
        {
            return customerService.GetAllCustomerProjectListById(projectId);
        }        
        [HttpPost]
        [Route("AddCustomerContact")]
        public List<CustomerContactModel> AddCustomerContact([FromBody] List<CustomerContactModel> customercontact)
        {
            if (ModelState.IsValid) return customerService.AddCustomerContact(customercontact);
            return null;
        }
        
        
        [HttpPut]
        [Route("UpdateCustomerContact")]
        public List<CustomerContactModel> UpdateCustomerContact([FromBody] List<CustomerContactModel> customercontact)
        {
            if (ModelState.IsValid) return customerService.UpdateCustomerContact(customercontact);
            return null;
        }

        

        [HttpGet]
        [Route("GetCustomerType")]
        public List<CustomerTypeModel> GetCustomerType()
        {
            return customerService.GetCustomerType();
        }
        
        
        [HttpGet]
        [Route("GetCustomerData/{customerId}")]
        public CustomerModel GetCustomerData(int customerId)
        {
            return customerService.GetCustomerData(customerId);
        }
        [HttpGet]
        [Route("GetCustomerContactList/{customerId}")]
        public List<CustomerContactModel> GetCustomerContactList(string customerId)
        {
            return customerService.GetCustomerContactList(customerId);
        }
        [HttpGet]
        [Route("GetCustomerProjectList/{customerId}")]
        public List<CustomerProjectModel> GetCustomerProjectList(int customerId)
        {
            return customerService.GetCustomerProjectList(customerId);
        }
        [HttpGet]
        [Route("GetAllCustomerProjectList")]
        public List<CustomerProjectModel> GetAllCustomerProjectList()
        {
            return customerService.GetAllCustomerProjectList();
        }

        [HttpGet]
        [Route("GetWorkOrderNoList/{customerId}/{projectId}")]
        public List<string> GetWorkOrderNoList(int customerId,int projectId)
        {
            return customerService.GetWorkOrderNoList(customerId, projectId);
        }

        //

        [HttpGet]
        [Route("GetCustomerCode/{code}")]
        public string GetTransectionCode(string code)
        {
            return customerService.GetCustomerCode(code);
        }
        [HttpGet]
        [Route("GetCustomerId/{customer_code}")]
        public int GetCustomerIdByCustomerCode(string customer_code)
        {
            return customerService.GetPurchaseOrderId(customer_code);
        }
        [HttpGet]
        [Route("GetAllCustomer")]
        public List<CustomerViewModel> GetAllCustomer()
        {
            return customerService.GetAllCustomers();
        }
        [HttpGet]
        [Route("GetCustomerAccountData/{CustomerId}")]
        public List<CustomerAccountReportModel> GetCustomerAccountData(string CustomerId)
        {
            return customerService.GetCustomerAccountData(CustomerId);
        }
        
        [HttpDelete]
        [Route("DeleteCustomerContact/{id}")]
        public void DeleteCustomerContact(int id)
        {
            customerService.DeleteCustomerContact(id);
        }
        [HttpGet]
        [Route("GetCustomerReceiveableBalance/{pono}")]
        public double GetOutStandingBalance(string pono)
        {
            return customerService.GetCustomerReceiveableBalance(pono);
        }
        [HttpPost]
        [Route("AddCustomerPayment")]
        public CustomerPaymentViewModel AddVendorPayment([FromBody] CustomerPaymentViewModel vendorPayment)
        {
            if (ModelState.IsValid) return customerService.AddCustomerPayment(vendorPayment);
            return null;
        }
        [HttpGet]
        [Route("GetCustomerAccountById/{customerId}")]
        public CustomerViewModel GetCustomerViewById(string customerId)
        {
            return customerService.GetCustomerById(customerId);
        }
    }
}
