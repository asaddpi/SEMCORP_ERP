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
    public class AboutTocomaController : ControllerBase
    {
        private AboutTocomaService aboutTocomaService;
        public AboutTocomaController(AboutTocomaService _oAboutTocomaService)
        {
            aboutTocomaService = _oAboutTocomaService;
        }
        [HttpPost]
        public clsAboutTocoma AddItem([FromBody] clsAboutTocoma item)
        {
            if (ModelState.IsValid) return aboutTocomaService.AddItem(item);
            return null;
        }
        [HttpPost]
        [Route("AddVisionMission")]
        public clsTocomaVisionMission AddVisionMission([FromBody] clsTocomaVisionMission item)
        {
            if (ModelState.IsValid) return aboutTocomaService.AddVisionMission(item);
            return null;
        }
        [HttpGet]
        [Route("GetAboutTocoma")]
        public List<clsTocomaVisionMission> GetAboutTocoma()
        {
            return aboutTocomaService.GetAboutTocomaInfo();
        }
        //[HttpGet]
        //[Route("GetAboutTocoma")]
        //public List<clsTocomaVisionMission> GetAboutTocoma = new List<clsTocomaVisionMission>()
        //{
            
        //}
        [HttpPost]
        [Route("AddTocomaHistory")]
        public clsTocomaHistory AddTocomaHistory([FromBody] clsTocomaHistory item)
        {
            if (ModelState.IsValid) return aboutTocomaService.AddTocomaHistory(item);
            return null;
        }
        [HttpGet]
        public clsAboutTocoma GetTocomaInfo()
        {
            return aboutTocomaService.GetTocomaInfo();
        }
        // GET: api/authors
        [HttpGet]
        [Route("GetTestData")]
        public JsonResult GetAsJson()
        {
            var resourceModelList = aboutTocomaService.GetTocomaInfo();
            //var rng = new Random();
            //var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();

            return new JsonResult(resourceModelList);
        }
    }
}
