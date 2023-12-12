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
    public class EmployeeController : ControllerBase
    {
        private EmployeeService employeeService;
        
        public EmployeeController(EmployeeService _oemployeeService)
        {
            employeeService = _oemployeeService;            
        }
        [HttpGet]
        public List<EmployeeModel> GetProductCategoryList()
        {
            return employeeService.GetEmployeelist();
        }
        [HttpGet]
        [Route("GetSOCEmployeeList")]
        public List<EmployeeModel> GetSOCEmployeeList()
        {
            return employeeService.GetSOCEmployeelist();
        }
        [HttpGet]
        [Route("GetEmployeeById/{empId}")]
        public EmployeeModel GetEmployeeById(string empId)
        {
            return employeeService.GetEmployeeByCode(empId);
        }
    }
}
