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
    public class OurClientController : ControllerBase
    {
        private OurClientService ourClientService;
        public OurClientController(OurClientService _oAboutTocomaService)
        {
            ourClientService = _oAboutTocomaService;
        }
        [HttpPost]
        [Route("AddClientProjectSectorType")]
        public clsClientProjectSectorType  AddItem([FromBody] clsClientProjectSectorType item)
        {
            if (ModelState.IsValid) return ourClientService.AddItem(item);
            return null;
        }
        [HttpGet]
        [Route("GetClientProjectSectorType")]
        public List<clsClientProjectSectorType> GetItemList()
        {
            return ourClientService.GetClientProjectSectorTypeList();
        }
        [HttpPost]
        [Route("AddClientDetails")]
        public clsClientDetails ClientDetails([FromBody] clsClientDetails item)
        {
            if (ModelState.IsValid) return ourClientService.AddClientDetails(item);
            return null;
        }
    }
}
