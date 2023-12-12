using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_API_Service.Service.Website;
using TOCOMA_ERP_ClassLibrary.Models.WebsiteModel;

namespace TOCOMA_API_Service.Controllers.Website
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenceProjectController : ControllerBase
    {
        private ReferenceProjectTypeService ref_Project_TypeService;
        public ReferenceProjectController(ReferenceProjectTypeService _oReferenceProjectTypeService)
        {
            ref_Project_TypeService = _oReferenceProjectTypeService;
        }
        [HttpGet]
        [Route("GetIsItemExist/{typeName}")]
        public bool GetIsItemExist(string typeName)
        {
            return ref_Project_TypeService.GetIsItemExist(typeName);
        }
        [HttpGet]
        [Route("GetReferenceProjectType")]
        public List<ReferenceProjectTypeModel> GetItemList()
        {
            return ref_Project_TypeService.GetProjectTypeist();
        }
        [HttpPost]
        public ReferenceProjectTypeModel AddItem([FromBody] ReferenceProjectTypeModel item)
        {
            if (ModelState.IsValid) return ref_Project_TypeService.AddItem(item);
            return null;
        }
        [HttpPost]
        [Route("AddReferenceProject")]
        public clsReferenceProject AddReferenceProject([FromBody] clsReferenceProject item)
        {
            if (ModelState.IsValid) return ref_Project_TypeService.AddReferenceProject(item);
            return null;
        }
        [HttpDelete]
        [Route("DeleteRefProjectType/{id}")]
        public void DeleteRefProjectType(int id)
        {
            ref_Project_TypeService.DeleteRefProjectType(id);
        }
    }
}
