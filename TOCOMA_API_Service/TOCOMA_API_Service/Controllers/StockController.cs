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
    public class StockController : ControllerBase
    {
        private StockService stockService;
        public StockController(StockService _ostockService)
        {
            stockService = _ostockService;
        }
        [HttpPost]
        public StockModel AddStock([FromBody] StockModel stockModel)
        {
            if (ModelState.IsValid) return stockService.AddStock(stockModel);
            return null;
        }
        [HttpGet]
        [Route("GetStockId/{po_no}")]
        public int GetStockId(string po_No)
        {
            return stockService.GetPurchaseOrderId(po_No);
        }
        [HttpPost]
        [Route("AddStockDetails")]
        public List<Stock_Details_Model> AddStockDetails([FromBody] List<Stock_Details_Model> purchaseOrderDetails)
        {
            if (ModelState.IsValid) return stockService.AddStockDetails(purchaseOrderDetails);
            return null;
        }
        [HttpPost]
        [Route("AddStockSummery")]
        public List<Stock_Details_Model> AddStockSummery([FromBody] List<Stock_Details_Model> purchaseOrderDetails)
        {
            if (ModelState.IsValid) return stockService.AddStockSummery(purchaseOrderDetails);
            return null;
        }
        [HttpGet]
        [Route("GetStockStatement")]
        public List<StockModel>GetStockStatement()
        {
            return stockService.GetStockStatement();
        }
        [HttpGet]
        [Route("GetStockSummery")]
        public List<StockSummeryReportModel> GetStockSummery()
        {
            return stockService.GetStockSummery();
        }
        [HttpGet]
        [Route("GetProjectwiseStock")]
        public List<ProjectWiseStockModel> projectwiseStockList()
        {
            return stockService.GetProjectwiseStock();
        }
        [HttpGet]
        [Route("GetStockSummryForProject")]
        public List<StockSummeryReportModel> GetStockSummryForProject()
        {
            return stockService.GetStockSummaryForProject();
        }
        [HttpGet]
        [Route("SGetStockSummery")]
        public List<RStockInformation> GetStockSummeryForProject()
        {
            return stockService.mGetStockSummery();
        }
    }
}
