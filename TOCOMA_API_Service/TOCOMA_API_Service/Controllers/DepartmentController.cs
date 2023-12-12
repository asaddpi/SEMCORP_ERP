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
    public class DepartmentController : ControllerBase
    {
        private DepartmentService departmentService;
        
        public DepartmentController(DepartmentService _opurchaseService)
        {
            departmentService = _opurchaseService;
        }
        [HttpGet]
        public List<DepartmentEntity>DepartmentList()
        {
            return departmentService.GetDepartmentList();            
        }

        [HttpGet]
        [Route("GetItemList")]
        public List<ItemEntity> GetItemList()
        {
            return departmentService.GetItemList();
        }
    }
}
