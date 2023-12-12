using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;
using TOCOMA_API_Service.Service;
using Microsoft.AspNetCore.Hosting;

namespace TOCOMA_API_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private PurchaseService purchaseService;
        private IHostingEnvironment _host;
        public PurchaseController(PurchaseService oPurchaseService, IHostingEnvironment host)//
        {
            purchaseService = oPurchaseService;
            _host = host;
        }
        [HttpGet]
        public List<PurchaseRequisitionEntity> GetProductCategoryList()
        {
            return purchaseService.GetProductCategoryList();
        }
        [HttpPost]
        public PurchaseRequisitionEntity AddPurchaseRequisition([FromBody] PurchaseRequisitionEntity purchaseRequisition)
        {
            if (ModelState.IsValid) return purchaseService.AddPurchaseRequisition(purchaseRequisition);
            return null;
        }
        [HttpPut]
        public PurchaseRequisitionEntity UpdatePurchaseRequisition([FromBody] PurchaseRequisitionEntity purchaseRequisition)
        {
            if (ModelState.IsValid) return purchaseService.UpdatePurchaseRequisition(purchaseRequisition);
            return null;
        }
        [HttpPost]
        [Route("AddPurchaseRequisitionDetails")]
        public List<PurchaseRequisitionDetailsEntity> AddPurchaseRequisitionDetails([FromBody] List<PurchaseRequisitionDetailsEntity> purchaseRequisitionDetails)
        {
            if (ModelState.IsValid) return purchaseService.AddPurchaseRequisitionDetails(purchaseRequisitionDetails);
            return null;
        }
        [HttpPut]
        [Route("UpdatePurchaseRequisitionDetails")]
        public List<PurchaseRequisitionDetailsEntity> UpdatePurchaseRequisitionDetails([FromBody] List<PurchaseRequisitionDetailsEntity> purchaseRequisitionDetails)
        {
            if (ModelState.IsValid) return purchaseService.UpdatePurchaseRequisitionDetails(purchaseRequisitionDetails);
            return null;
        }
        //------------
        [HttpPost]
        [Route("AddPurchaseRequisitionOthers")]
        public List<PurchaseRequisitionOthersModel> AddPurchaseRequisitionOthers([FromBody] List<PurchaseRequisitionOthersModel> purchaseRequisitionOthers)
        {
            if (ModelState.IsValid) return purchaseService.AddPurchaseRequisitionOthers(purchaseRequisitionOthers);
            return null;
        }
        [HttpPut]
        [Route("UpdatePurchaseRequisitionOthers")]
        public List<PurchaseRequisitionOthersModel> UpdatePurchaseRequisitionOthers([FromBody] List<PurchaseRequisitionOthersModel> purchaseRequisitionOthers)
        {
            if (ModelState.IsValid) return purchaseService.UpdatePurchaseRequisitionOthers(purchaseRequisitionOthers);
            return null;
        }
        [HttpPost]
        [Route("AddPurchaseOrder")]
        public PurchaseOrderModel AddPurchaseOrder([FromBody] PurchaseOrderModel purchaseOrder)
        {
            if (ModelState.IsValid) return purchaseService.AddPurchase(purchaseOrder);
            return null;
        }
        [HttpPost]
        [Route("AddPurchaseForProject")]
        public PurchaseOrderModel AddPurchaseForProject([FromBody] PurchaseOrderModel purchaseOrder)
        {
            if (ModelState.IsValid) return purchaseService.AddPurchaseForProject(purchaseOrder);
            return null;
        }
        
        [HttpPut]
        [Route("UpdatePurchaseForProject")]
        public PurchaseOrderModel UpdatePurchaseForProject([FromBody] PurchaseOrderModel purchaseOrder)
        {
            if (ModelState.IsValid) return purchaseService.UpdatePurchaseForProject(purchaseOrder);
            return null;
        }
        [HttpPost]
        [Route("AddStockOut")]
        public DeliveryNoteMasterEntity AddStockOut([FromBody] DeliveryNoteMasterEntity purchaseOrder)
        {
            if (ModelState.IsValid) return purchaseService.CreateDeliveryNote(purchaseOrder);
            return null;
        }

        [HttpDelete]
        [Route("DeletePurchaseItem/{id}")]
        public void DeletePurchaseItem(int id)
        {
            purchaseService.DeletePurchaseItem(id);
        }

        [HttpPut]
        [Route("EditPurchaseOrder")]
        public PurchaseOrderModel EditPurchaseOrder([FromBody] PurchaseOrderModel purchaseOrder)
        {
            if (ModelState.IsValid) return purchaseService.EditPurchaseOrder(purchaseOrder);
            return null;
        }
        [HttpPut]
        [Route("UpdateShipmentInfo")]
        public PurchaseOrderModel UpdateShipmentInfo([FromBody] PurchaseOrderModel purchaseOrder)
        {
            if (ModelState.IsValid) return purchaseService.UpdateShipmentInfo(purchaseOrder);
            return null;
        }
        [HttpPut]
        [Route("UpdateGoodsReceiveInfo")] 
        public PurchaseOrderModel UpdateGoodsReceiveInfo([FromBody] PurchaseOrderModel purchaseOrder)
        {
            if (ModelState.IsValid) return purchaseService.UpdateGoodsReceiveInfo(purchaseOrder);
            return null;
        }
        [HttpPost]
        [Route("AddPurchaseOrderDetails")]
        public List<PurchaseOrderDetailsEntity> AddPurchaseOrderDetails([FromBody] List<PurchaseOrderDetailsEntity> purchaseOrderDetails)
        {
            if (ModelState.IsValid) return purchaseService.AddPurchaseOrderDetails(purchaseOrderDetails);
            return null;
        }

        [HttpGet]
        [Route("GetPurchaseRequisitionId/{requisition_No}")]
        public int GetPurchaseRequisitionId(string requisition_No)
        {
            return purchaseService.GetPurchaseRequisitionId(requisition_No);
        }
        [HttpGet]
        [Route("GetItemId/{itemName}")]
        public int GetItemId(string itemName)
        {
            return purchaseService.GetItemId(itemName);
        }
        [HttpGet]
        [Route("GetPurchaseRequisitionList_ForApproval")]
        public List<PurchaseRequisitionViewEntity> GetPurchaseRequistionListForApproval()
        {
            return purchaseService.GetPurchaseRequistionListForApproval();
        }
        [HttpGet]
        [Route("ManageRequisition")]
        public List<PurchaseRequisitionViewEntity> ManageRequisition()
        {
            return purchaseService.ManageRequisition();
        }
        [HttpGet]
        [Route("GetPurchaseRequisitionList")]
        public List<PurchaseRequisitionViewEntity> GetPurchaseRequistionList()
        {
            return purchaseService.GetPurchaseRequistionList();
        }
        [HttpGet]
        [Route("GetPurchaseRequisitionInfoByNo/{reqNo}")]
        public PurchaseRequisitionViewEntity GetPurchaseReqByNo(string reqNo)
        {
            return purchaseService.GetPurchaseRequisitionInfoByNo(reqNo);
        }
        
        [HttpGet]
        [Route("GetRequisitionItemDetailsByReqNo/{reqNo}")]
        public List<OrderItemEntity> GetPurchaseReqItemByNo(string reqNo)
        {
            return purchaseService.GetPurchaseRequisitionItemByNo(reqNo);
        }
        [HttpGet]
        [Route("GetRequisitionDetailsByReqNo/{reqNo}")]
        public List<PurchaseRequisitionDetailsEntity> GetRequisitionDetailsByReqNo(string reqNo)
        {
            return purchaseService.GetPurchaseRequisitionItemDetailsByReqNo(reqNo);
        }
        [HttpGet]
        [Route("GetRequisitionOthersItemDetailsByReqNo/{reqNo}")]
        public List<PurchaseRequisitionOthersModel> GetPurchaseRequisitionOthersItemByReqNo(string reqNo)
        {
            return purchaseService.GetPurchaseRequisitionOthersItemByReqNo(reqNo);
        }
        [HttpGet]
        [Route("GetPurchaseReqInfo/{reqNo}")]
        public PurchaseRequisitionViewEntity GetPurchaseReqInfo(string reqNo)
        { return purchaseService.GetPurchaseReqInfo(reqNo); }
        [HttpPut]
        [Route("UpdateRequisitionStatus")]
        public PurchaseRequisitionEntity UpdateStatus([FromBody] PurchaseRequisitionEntity purchaseRequisition)
        {
            if (ModelState.IsValid) return purchaseService.UpdateRequisitionStatus(purchaseRequisition);
            return null;
        }
        [HttpPost]
        [Route("GenerateReport")]
        public PRE GenerateReport([FromBody] PRE purchase)
        {
            if (ModelState.IsValid) return purchaseService.GeneratePurchaseInvoice(purchase, _host.ContentRootPath);
            return null;
        }
        [HttpGet]
        [Route("GetPOList")]
        public List<PurchaseOrderViewModel> GetPOList()
        {
            return purchaseService.GetPoList();
        }
        [HttpGet]
        [Route("GetPOTrackingList")]
        public List<PurchaseOrderViewModel> GetPOTrackingList()
        {
            return purchaseService.GetPOTrackingList();
        }
        
        [HttpGet]
        [Route("GetUnPaidPoListByVendorCode/{vendorCode}")]
        public List<PurchaseOrderViewModel> GetUnpaidPOList(string vendorCode)
        {
            return purchaseService.GetUnPaidPoListByVendorCode(vendorCode);
        }
        
        [HttpGet]
        [Route("GetPurchaseOrderByPOId/{poId}")]
        public PurchaseOrderViewModel GetPurchaseOrderByPoId(string poId)
        {
            return purchaseService.GetPurchaseOrderByPOId(poId);
        }
        [HttpGet]
        [Route("GetPurchaseListByQuotationNo/{po_No}")]
        public PurchaseOrderViewModel GetPurchaseListByQuotationNo(string po_No)
        {
            return purchaseService.GetPurchaseListByQuotationNo(po_No);
        }



        [HttpGet]
        [Route("GetPurchaseOrderId/{po_No}")]
        public int GetPurchaseOrderId(string po_No)
        {
            return purchaseService.GetPurchaseOrderId(po_No);
        }
        [HttpGet]
        [Route("GetPurchaseOrderDetailsByPO_ID/{poId}")]
        public List<PurchaseOrderDetailsEntity> GetPurchaseOrderDetailsByPOID(string poId)
        {
            return purchaseService.GetPurchaseOrderDetailsByPOID(poId);
        }
        //[HttpGet]
        //[Route("GetPurchaseOrderDetailsByPO_NO/{poNo}")]
        //public List<PurchaseOrderDetailsEntity> GetPurchaseOrderDetailsByPO_NO(string poNo)
        //{
        //    return purchaseService.GetPurchaseOrderDetailsByPO_NO(poNo);
        //}
        [HttpGet]
        [Route("GetPurchaseOrderDetailsBYPO_ID_IN/{PO_ID_IN}")]
        public List<PurchaseOrderDetailsEntity> GetPurchaseOrderDetailsBYPO_ID_IN(string PO_ID_IN)
        {
            return purchaseService.GetPurchaseOrderDetailsBYPO_ID_IN(PO_ID_IN);
        }
        [HttpGet]
        [Route("GetAllPurchaseOrderDetails")]
        public List<PurchaseOrderDetailsEntity> GetAllPurchaseOrderDetails()
        {
            return purchaseService.GetAllPurchaseOrderDetails();
        }
        [HttpGet]
        [Route("GetPurchaseOrderIdByPurchaseDate/{date1}/{date2}")]
        public List<PurchaseOrderViewModel> GetPurchaseOrderIdByPurchaseDate(DateTime date1, DateTime date2)
        {
            return purchaseService.GetPurchaseOrderIdByPurchaseDate(date1, date2);
        }
        [HttpGet]
        [Route("GetDailyPurchaseStatementByDate/{date1}/{date2}")]
        public List<PurchaseOrderViewModel> GetDailyPurchaseStatementByDate(DateTime date1, DateTime date2)
        {
            return purchaseService.GetDailyPurchaseStatementByDate(date1, date2);
        }
        [HttpGet]
        [Route("GetPurchaseOrderDetailsByPO/{poNo}")]
        public List<PurchaseOrderViewModel>GetPurchaseOrderDetailsByPO(string poNo)
        {
            return purchaseService.GetPurchaseOrderDetailsByPO_NO(poNo);
        }
        [HttpGet]
        [Route("GetAllWarehouse")]
        public List<WarehouseModel> GetAllWarehouse()
        {
            return purchaseService.GetAllWareHouse();
        }
        [HttpGet]
        [Route("GetPurchaseOrderByPO/{poNo}")]
        public PurchaseOrderModel GetPurchaseOrderByPO(string poNo)
        {
            return purchaseService.GetPurchaseOrderByPO_NO(poNo);
        }
        [HttpGet]
        [Route("GetPurchaseOrderDetailsByPO_NO/{poNo}")]
        public List<PurchaseOrderDetailsEntity> GetPurchaseOrderDetailsByPONO(string poNo)
        {
            return purchaseService.GetPurchaseOrderDetailsByPONO(poNo);
        }
        [HttpGet]
        [Route("GetReqNo")]
        public string GetReqNo()
        {
            return purchaseService.GetReqNo();
        }
        [HttpGet]
        [Route("GetPONo")]
        public string GetPONo()
        {
            return purchaseService.GetPONo();
        }
        [HttpGet]
        [Route("GetPurchaseOrderNo")]
        public string GetPurchaseOrderNo()
        {
            return purchaseService.GetPurchaseOrderNo();
        }
        [HttpGet]
        [Route("GetPurchaseOrderInfo/{PONO}")]
        public PurchaseOrderViewModel GetPurchaseOrderInfo(string PONO)
        {
            return purchaseService.GetPurchaseOrderInfo(PONO);
        }
        [HttpGet]
        [Route("GetPackagingInstructionById/{Ids}")] 
        public List<PackagingInstructionModel> GetPackagingInstruction(string Ids)
        { return purchaseService.PackagingInstruction(Ids); }
        [HttpGet]
        [Route("GetTermsAndConditions/{Ids}")]
        public List<PurchaseTermsConditionsModel> GetTermsAndConditions(string Ids)
        { return purchaseService.GetTermsAndConditions(Ids); }
        [HttpGet]
        [Route("GetPurchaseListForProject/{voucherNo}")]
        public List<PurchaseOrderViewModel> GetPurchaseListForProject(string voucherNo)
        {
            return purchaseService.GetPurchaseListForProject(voucherNo);
        }
        [HttpGet]
        [Route("GetPurchaseItem")]
        public List<PurchaseOrderViewModel> GetPurchaseItem()
        {
            return purchaseService.GetPurchaseItem();
        }
        [HttpGet]
        [Route("GetPurchaseList")]
        public List<PurchaseOrderViewModel> GetPurchaseList()
        {
            return purchaseService.GetPurchaseList();
        }
        [HttpGet]
        [Route("GetPurchaseItemSumForProject")]
        public PurchaseOrderViewModel GetPurchaseItemSumForProject()
        {
            return purchaseService.GetPurchaseItemSumForProject();
        }

        [HttpGet]
        [Route("GetPurchaseListForProjectByDate/{from_date}/{to_date}")]
        public List<PurchaseOrderViewModel> GetPurchaseListForProjectByDate(string from_date, string to_date)
        {
            return purchaseService.GetPurchaseListForProjectByDate(from_date, to_date);
        }
        [HttpGet]
        [Route("GetPurchaseItemSumForProject_By_Date/{from_date}/{to_date}")]
        public PurchaseOrderViewModel GetPurchaseItemSumForProject_By_Date(string from_date, string to_date)
        {
            return purchaseService.GetPurchaseItemSumForProjectByDate(from_date, to_date);
        }
        //---
        [HttpGet]
        [Route("GetPurchaseListForProjectByVoucherNo/{voucherNo}")]
        public List<PurchaseOrderDetailsEntity> GetPurchaseListForProjectByVoucherNo(string voucherNo)
        {
            return purchaseService.GetPurchaseListForProjectByVoucherNo(voucherNo);
        }



        [HttpGet]
        [Route("GetStockStatement/{strFdate}/{strTDate}")]
        public List<RStockInformation> GetStockStatement(string strFdate, string strTDate)
        {
            return purchaseService.mGetProductStatement(strFdate, strTDate);
        }
        [HttpGet]
        [Route("GetStockSummery")]
        public List<RStockInformation> GetStockSummery()
        {
            return purchaseService.mGetProductSummery();
        }
        
        [HttpGet]
        [Route("CheckExistItem/{voucherNo}")]
        public bool CheckExistItem(string voucherNo)
        {
            return purchaseService.CheckExistItem(voucherNo);
        }
        [HttpGet]
        [Route("GetProjectCostReport/{projectName}")]
        public List<ProjectCostReportModel> GetProjectCostRepor(string projectName)
        {
            return purchaseService.GetProjectCost(projectName);
        }
        [HttpGet]
        [Route("GetProjectwiseCost")]
        public List<ProjectCostReportModel> GetProjectwiseCost(string projectName)
        {
            return purchaseService.GetProjectwiseCost(projectName);
        }
        
    }
}
