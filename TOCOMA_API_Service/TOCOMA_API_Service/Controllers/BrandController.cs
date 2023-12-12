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
    public class BrandController : ControllerBase
    {
        private BrandService brandService;
        public BrandController(BrandService oBrandService)
        {
            brandService = oBrandService;
        }

        [HttpGet]
        public List<BrandModel> GetBrandList()
        {
            return brandService.GetBrandList();
        }
        [HttpPost]
        public BrandModel AddBrand([FromBody] BrandModel brand)
        {
            if (ModelState.IsValid) return brandService.AddBrand(brand);
            return null;
        }
    }
}
