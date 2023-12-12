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
    public class ProductController : ControllerBase
    {
        private ProductService productService;
        public ProductController(ProductService oProductService)
        {
            productService = oProductService;
        }
        [HttpGet]
        public List<ItemViewModel> GetItemList()
        {
            return productService.GetItemList();
        }
        [HttpGet]
        [Route("GetProjectItem")]
        public List<ItemViewModel> GetProjectItem()
        {
            return productService.GetProjectItemList();
        }

       

        [HttpPost]
        public ItemEntity AddItem([FromBody] ItemEntity item)
        {
            if (ModelState.IsValid) return productService.AddItem(item);
            return null;
        }
        [HttpPut]
        public ItemEntity EditItem([FromBody] ItemEntity item)
        {
            if (ModelState.IsValid) return productService.EditItem(item);
            return null;
        }
        [HttpGet]
        [Route("GetIsItemExist/{itemcode}")]
        public bool GetIsItemExist(string itemcode)
        {
            return productService.GetIsItemExist(itemcode);
        }
        [HttpGet]
        [Route("GetItemByItemName/{itemName}")]
        public ItemEntity GetItemByItemName(string itemName)
        {
            return productService.GetItemNameByItem(itemName);
        }
        [HttpGet]
        [Route("GetProductCode")]
        public string GetProductCode()
        {
            return productService.GetProductCode();
        }
        [HttpGet]
        [Route("GetItemByCode/{itemCode}")]
        public ItemViewModel GetItemDetailsByItemCode(string itemCode)
        { return productService.GetItemDetailsByItemCode(itemCode); }

    }
}
