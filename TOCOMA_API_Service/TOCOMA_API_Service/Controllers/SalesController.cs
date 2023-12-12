using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_API_Service.Service;
using TOCOMA_ERP_ClassLibrary.Models;

namespace Tocoma_ERP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private SalesServices salesService;
        public SalesController(SalesServices _oSalesServices)
        {
            salesService = _oSalesServices;
        }
        //[HttpGet]
        //public List<ItemEntity> GetItemList()
        //{
        //    return productService.GetItemList();
        //}
        [HttpPost]
        public SalesQuotationModel AddItem([FromBody] SalesQuotationModel salesQuotation)
        {
            if (ModelState.IsValid) return salesService.AddSalesQuotation(salesQuotation);
            return null;
        }
        [HttpPut]
        public SalesQuotationModel UpdateItem([FromBody] SalesQuotationModel salesQuotation)
        {
            if (ModelState.IsValid) return salesService.UpdateSalesQuotation(salesQuotation);
            return null;
        }
        [HttpGet]
        [Route("GetSalesQuotationId/{quotationNo}")]
        public int GetSalesQuotationId(string quotationNo)
        {
            return salesService.GetSalesQuotationId(quotationNo);
        }
        [HttpPost]
        [Route("AddSalesQuotationDetails")]
        public List<SalesItemDetailsModel> AddSalesQuotationDetails([FromBody] List<SalesItemDetailsModel> salesItemDetails)
        {
            if (ModelState.IsValid) return salesService.AddSalesQuotationDetails(salesItemDetails);
            return null;
        }
        [HttpPut]
        [Route("UpdateSalesQuotationDetails")]
        public List<SalesItemDetailsModel> UpdateSalesQuotationDetails([FromBody] List<SalesItemDetailsModel> salesItemDetails)
        {
            if (ModelState.IsValid) return salesService.UpdateSalesQuotationDetails(salesItemDetails);
            return null;
        }


        [HttpPost]
        [Route("AddSalesOrder")]
        public SalesOrderModel AddSalesOrder([FromBody] SalesOrderModel salesOrder)
        {
            if (ModelState.IsValid) return salesService.AddSalesOrder(salesOrder);
            return null;
        }
        //[HttpPost]
        //[Route("AddInvoice")]
        //internal InvoiceMasterEntity CreateInvoice([FromBody] InvoiceMasterEntity invoice)
        //{
        //    if (ModelState.IsValid) return salesService.CreateInvoice(invoice);
        //    return null;
        //}
        [HttpPost]
        [Route("AddInvoice")]
        public InvoiceMasterEntity CreateInvoice([FromBody] InvoiceMasterEntity invoice)
        {
            if (ModelState.IsValid) return salesService.CreateInvoice(invoice);
            return null;
        }
        [HttpPut]
        [Route("UpdateSalesOrder")]
        public SalesOrderModel UpdateSalesOrder([FromBody] SalesOrderModel salesOrder)
        {
            if (ModelState.IsValid) return salesService.UpdateSalesOrder(salesOrder);
            return null;
        }

        [HttpGet]
        [Route("GetSalesOrderId")]
        public int GetSalesOrderId()
        {
            return salesService.GetSalesOrderId();
        }

        [HttpPost]
        [Route("AddSalesOrderDetails")]
        public List<SalesItemDetailsModel> AddSalesOrderDetails([FromBody] List<SalesItemDetailsModel> salesItemDetails)
        {
            if (ModelState.IsValid) return salesService.AddSalesOrderDetails(salesItemDetails);
            return null;
        }
        [HttpPut]
        [Route("UpdateSalesOrderDetails")]
        public List<SalesItemDetailsModel> UpdateSalesOrderDetails([FromBody] List<SalesItemDetailsModel> salesItemDetails)
        {
            if (ModelState.IsValid) return salesService.UpdateSalesOrderDetails(salesItemDetails);
            return null;
        }
        [HttpGet]
        [Route("GetSalesOrderInfo")]
        public List<SalesOrderViewModel> GetSalesInfo()
        {
            return salesService.GetSalesInfo();
        }


        [HttpGet]
        [Route("GetSalesInfoByPONo/{PONo}")]
        public SalesOrderViewModel GetSalesInfoByPO(string PONo)
        {
            return salesService.GetSalesInfoByPO(PONo);
        }
        [HttpGet]
        [Route("GetCustomerPaymentInfoByPO/{PONo}")]
        public SalesOrderViewModel GetCustomerPaymentInfoByPO(string PONo)
        {
            return salesService.GetSalesInfoByPO(PONo);
        }
        [HttpGet]
        [Route("GetSalesInfoBySalesOrderNo/{salesOrderNo}")]
        public SalesOrderModel GetSalesInfoBySalesOrderNo(string salesOrderNo)
        {
            return salesService.GetSalesInfoBySalesOrderNo(salesOrderNo);
        }
        [HttpGet]
        [Route("GetSalesItemByPONo/{PONo}")]
        public List<SalesItemDetailsModel> GetSalesItemByPONo(string PONo)
        {
            return salesService.GetSalesItemByPoNo(PONo);
        }
        [HttpGet]
        [Route("GetAllSalesItemDetails")]
        public List<SalesItemDetailsModel> GetAllSalesItemDetails()
        {
            return salesService.GetAllSalesItemDetails();
        }
        [HttpGet]
        [Route("GetSalesOrderTrackingInfo")]
        public List<SalesOrderViewModel> GetSalesOrderTrackingInfo()
        {
            return salesService.GetSalesOrderTrackingInfo();
        }
        [HttpGet]
        [Route("GetShipmentStatus")]
        public List<SalesOrderViewModel> GetShipmentStatus()
        {
            return salesService.GetSalesOrderShipmentInfo();
        }

        [HttpGet]
        [Route("GetSalesByPONo/{PONo}")]
        public SalesOrderModel GetSalesByPO(string PONo)
        {
            return salesService.GetSalesByPO(PONo);
        }

        [HttpPut]
        [Route("UpdateSalesTrackingInfo")]
        public SalesOrderModel UpdateSalesTracking([FromBody] SalesOrderModel sales)
        {
            if (ModelState.IsValid) return salesService.UpdateSalesTracking(sales);
            return null;
        }
        [HttpGet]
        [Route("GetAllQuotation")]
        public List<SalesQuotationView> GetAllQuotationList()
        { return salesService.GetAllQuotationList(); }

        [HttpGet]

        [Route("GetworkOrderItemList/{woNO}")]
        public List<SalesItemDetailsModel> workOrderItem(string woNO)
        {
            return salesService.GetWorkOrderItemList(woNO);
        }
        [HttpGet]
        [Route("GetDeliveryNoteNoList/{woNo}")]
        public List<string>GetDeliveryNotNolist(string woNo)
        {
            return salesService.GetDeliveryNoteNoList(woNo);
        }
        [HttpGet]
        [Route("GetDeliveryNoteInfo/{woNo}")]
        public List<DeliveryNoteViewModel> GetDeliveryNoteInfo(string woNo)
        { return salesService.GetDeliveryList(woNo); }

        [HttpGet]
        [Route("GetAllDeliveryNoteInfo")]
        public List<DeliveryNoteViewModel> GetAllDeliveryNoteInfo()
        { return salesService.GetAllDeliveryList(); }

        [HttpGet]
        [Route("GetInvoiceInfo/{woNo}")]
        public List<InvoiceViewModel> GetInvoiceList(string woNo)
        { return salesService.GetInvoiceList(woNo); }

        [HttpGet]
        [Route("GetAllInvoiceInfo")]
        public List<InvoiceViewModel> GetAllInvoiceInfo()
        { return salesService.GetAllInvoiceList(); }

        [HttpGet]
        [Route("GetSalesOrderInfoByWorkOrderNO/{woNo}")]
        public SalesOrderViewModel GetSalesOrderInfoByWorkOrderNO(string woNo)
        { return salesService.GetSalesOrderInfoByWONO(woNo); }


        //GetSalesOrderInfoByWorkOrderNO

        [HttpGet]
        [Route("GetDeliveryInfoByDNNo/{deliveryNoteNo}")]
        public List<DeliveryNoteViewModel> GetDeliveryInfoByDNNo(string deliveryNoteNo)
        { return salesService.GetAllDeliveryListByDeliveryNote(deliveryNoteNo); }

        [HttpGet]
        [Route("GetInvoiceInfoByInvNo/{invNo}")]
        public List<InvoiceViewModel> GetInvoiceInfoByInvNo(string invNo)
        { return salesService.GetAllInvoiceListByInvNo(invNo); }

        [HttpGet]
        [Route("GetAllQuotationCurrentYear")]
        public List<SalesQuotationView> GetAllQuotationCurrentYear()
        { return salesService.GetAllQuotationListCurrentYear(); }
        [HttpGet]
        [Route("GetsalesQuotationInfoById/{Id}")]
        public SalesQuotationView GetSalesQuotationById(int Id)
        { return salesService.GetSalesQuotationById(Id); }
        [HttpGet]
        [Route("GetSalesQuotationItemListById/{Id}")]
        public List<SalesQuotationItemView> GetSalesQuotationItemList(int Id)
        { return salesService.GetSalesQuotationItemList(Id); }

        // ByQuotationNo.
        [HttpGet]
        [Route("GetsalesQuotationInfoByQuotationNo/{quotationNo}")]
        public SalesQuotationView ByQuotationNo(string quotationNo)
        { return salesService.GetSalesQuotationByQuotationNo(quotationNo); }
        [HttpGet]
        [Route("GetSalesQuotationItemListByByQuotationNo/{quotationNo}")]
        public List<SalesQuotationItemView> GetSalesQuotationItemListByByQuotationNo(string quotationNo)
        { return salesService.GetSalesQuotationItemListByQuotationNo(quotationNo); }






        [HttpGet]
        [Route("GetQuotationByQutNo/{qutNo}")]
        public SalesQuotationModel GetSalesQuotationByQutNo(string qutNo)
        { return salesService.GetSalesQuotationByReqNo(qutNo); }
        [HttpGet]
        [Route("GetQuotationDetailsByQutNo/{qutNo}")]
        public List<SalesItemDetailsModel> GetSalesQuotationItemListByQutNo(string qutNo)
        { return salesService.GetSalesQuotationItemListByQutNo(qutNo); }
        [HttpGet]
        [Route("GetTermsAndConditions/{Ids}")]
        public List<PurchaseTermsConditionsModel> GetTermsAndConditions(string Ids)
        { return salesService.GetTermsAndConditions(Ids); }
        [HttpGet]
        [Route("GetSalesTermsAndConditionsByIds/{Ids}")]
        public List<PurchaseTermsConditionsModel> GetSalesTermsAndConditionsByIds(string Ids)
        { return salesService.GetTermsAndConditions(Ids); }

        [HttpGet]
        [Route("GetUsedProduct/{Ids}")]
        public List<ItemEntity> GetUsedProduct(string Ids)
        { return salesService.GetUsedProduct(Ids); }


        

        [HttpGet]
        [Route("GetItemListByUsedProduct/{Ids}")]
        public List<ItemEntity> GetItemListByUsedProduct(string Ids)
        { return salesService.GetItemListByUsedProduct(Ids); }



        //GetItemListByUsedProduct

        //[HttpGet]
        //[Route("GetQutNo/{prefix}")]
        //public string GetQutNo(string prefix)
        //{
        //    return salesService.GetQutNo(prefix);
        //}
        [HttpGet]
        [Route("GetQutNo")]
        public string GetQutNo()
        {
            return salesService.GetQutNo();
        }
        [HttpGet]
        [Route("GetSalesOrderNo")]
        public string GetSalesOrderNo()
        {
            return salesService.GetSalesOrderNo();
        }
        [HttpGet]
        [Route("GetDeliveryNo")]
        public string GetDeliveryNoteNo()
        {
            return salesService.GetDeliveryNoteNo();
        }
        [HttpGet]
        [Route("GetUnPaidPoListByCustomerId/{customerId}")]
        public List<SalesOrderViewModel> GetUnpaidPOList(int customerId)
        {
            return salesService.GetUnPaidPoListByCustomerCode(customerId);
        }
        [HttpPut]
        [Route("UpdateSalesShipmentStatus")]
        public SalesOrderModel UpdateSalesShipmentStatus([FromBody] SalesOrderModel sales)
        {
            if (ModelState.IsValid) return salesService.UpdateSalesShipmentStatus(sales);
            return null;
        }
    }
}
