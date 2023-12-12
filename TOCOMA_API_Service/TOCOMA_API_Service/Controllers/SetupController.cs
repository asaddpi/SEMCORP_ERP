using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_API_Service.Service;
using TOCOMA_ERP_ClassLibrary.Models;

namespace TOCOMA_API_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetupController : ControllerBase
    {
        private SetupService setupService;
        public SetupController(SetupService _OsetupService)
        {
            setupService = _OsetupService;
        }
        #region Branch
        [HttpPost]
        [Route("AddBranch")]
        public BranchModel AddBranch([FromBody] BranchModel branchModel)
        {
            if (ModelState.IsValid) return setupService.AddBranch(branchModel);
            return null;
        }
        [HttpPut]
        [Route("UpdateBranch")]
        public BranchModel UpdateBranch([FromBody] BranchModel branchModel)
        {
            if (ModelState.IsValid) return setupService.UpdateBranch(branchModel);
            return null;
        }
        [HttpGet]
        [Route("GetBranchList")]
        public List<BranchModel> GetBranchLit()
        { return setupService.GetBranchList(); }

        [HttpDelete]
        [Route("DeleteBranchById/{id}")]
        public void DeleteBranchById(string id)
        {
            setupService.DeleteBranchById(id);
        }
        #endregion

        #region Currency

        [HttpPost]
        [Route("AddCurrency")]
        public CurrencyModel AddCurrency([FromBody] CurrencyModel currency)
        {
            if (ModelState.IsValid) return setupService.AddCurrency(currency);
            return null;
        }
        [HttpPost]
        [Route("SaveCurrency")]
        public CurrencyModel SaveCurrency([FromBody] CurrencyModel currency)
        {
            if (ModelState.IsValid) return setupService.AddCurrency(currency);
            return null;
        }
        [HttpPut]
        [Route("UpdateCurrency")]
        public CurrencyModel UpdateCurrency([FromBody] CurrencyModel currency)
        {
            if (ModelState.IsValid) return setupService.UpdateCurrency(currency);
            return null;
        }
        [HttpDelete]
        [Route("DeleteCurrency/{id}")]
        public void DeleteCurrency(string id)
        {
            setupService.DeleteCurrency(id);
        }


        [HttpGet]
        [Route("GetCurrency")]
        public List<CurrencyModel> GetCurrency()
        { return setupService.GetCurrency(); }

        #endregion

        #region Ledger Group
        [HttpPost]
        [Route("AddLedgerGroup")]
        public LedgerGroupModel AddLedgerGroup([FromBody] LedgerGroupModel ledgerGroup)
        {
            if (ModelState.IsValid) return setupService.AddLedgerGroup(ledgerGroup);
            return null;
        }
        [HttpPut]
        [Route("UpdateLedgerGroup")]
        public LedgerGroupModel UpdateLedgerGroup([FromBody] LedgerGroupModel ledgerGroup)
        {
            if (ModelState.IsValid) return setupService.UpdateLedgerGroup(ledgerGroup);
            return null;
        }

        [HttpDelete]
        [Route("DeleteLedgerGroup/{id}")]
        public void DeleteLedgerGroup(int id)
        {
            setupService.DeleteLedgerGroup(id);
        }

        [HttpGet]
        [Route("GetLedgerGroup")]
        public List<LedgerGroupModel> GetLedgerGroup()
        { return setupService.GetLedgerGroup(); }
        [HttpGet]
        [Route("GetPaymentMediaTypeList")]
        public List<LedgerModel> GetPaymentMediaTypeList()
        { return setupService.GetPaymentMediaTypeList(); }
        [HttpGet]
        [Route("GetCustomerProjectList")]
        public List<LedgerModel> GetCustomerProjectList()
        { return setupService.GetCustomerProjectList(); }


        [HttpGet]
        [Route("GetLedgerGroupByGRName/{serial}")]
        public bool GetLedgerGroupByGRName(int serial)
        { return setupService.GetLedgerGroupByGRName(serial); }

        #endregion


        #region Ledger
        [HttpPost]
        [Route("AddLedger")]
        public LedgerModel AddLedger([FromBody] LedgerModel ledger)
        {
            if (ModelState.IsValid) return setupService.AddLedger(ledger);
            return null;
        }
        [HttpPut]
        [Route("UpdateLedger")]
        public LedgerModel UpdateLedger([FromBody] LedgerModel ledger)
        {
            if (ModelState.IsValid) return setupService.UpdateLedger(ledger);
            return null;
        }
        [HttpDelete]
        [Route("DeleteLedgerByName/{name}")]
        public void DeleteLedgerById(string name)
        {
            setupService.DeleteLedgerById(name);
        }


        [HttpGet]
        [Route("GetLedger")]
        public List<LedgerModel> GetLedger()
        { return setupService.GetLedger(); }

        [HttpGet]
        [Route("GetLedgerByCode/{Id}")]
        public LedgerModel GetLedgerByCode(string Id)
        { return setupService.GetLedgerByCode(Id); }



        [HttpGet]
        [Route("GetLedgerByGRName/{name}")]
        public bool GetLedgerByGRName(string name)
        { return setupService.GetLedgerByGRName(name); }


        #endregion

        #region Budget
        [HttpPost]
        [Route("AddBudget")]
        public BudgetModel AddBudget([FromBody] BudgetModel budgetModel)
        {
            if (ModelState.IsValid) return setupService.AddBudget(budgetModel);
            return null;
        }
        [HttpPut]
        [Route("UpdateBudget")]
        public BudgetModel UpdateBudget([FromBody] BudgetModel budgetModel)
        {
            if (ModelState.IsValid) return setupService.UpdateBudget(budgetModel);
            return null;
        }
        [HttpGet]
        [Route("GetBudgetList")]
        public List<BudgetModel> GetBudgetList()
        { return setupService.GetBudgetList(); }

        [HttpDelete]
        [Route("DeleteBudgetById/{id}")]
        public void DeleteBudgetById(int id)
        {
            setupService.DeleteBudgetById(id);
        }
        #endregion

        #region Cost Categories
        [HttpPost]
        [Route("AddCostCategories")]
        public CostCategoriesModels AddCostCategories([FromBody] CostCategoriesModels costCategories)
        {
            if (ModelState.IsValid) return setupService.AddCostCategories(costCategories);
            return null;
        }
        [HttpPut]
        [Route("UpdateCostCategories")]
        public CostCategoriesModels UpdateCostCategories([FromBody] CostCategoriesModels budgetModel)
        {
            if (ModelState.IsValid) return setupService.UpdateCostCategories(budgetModel);
            return null;
        }
        [HttpGet]
        [Route("GetCostCategoriesList")]
        public List<CostCategoriesModels> GetCostCategoriesList()
        { return setupService.GetCostCategoriesList(); }

        [HttpDelete]
        [Route("DeleteCostCategoriesById/{id}")]
        public void DeleteCostCategoriesById(int id)
        {
            setupService.DeleteBudgetById(id);
        }



        #endregion

        #region Country
        //[HttpGet]
        //[Route("GetCountry")]
        //public List<CountryModel> GetCountry()
        //{
        //    return setupService.GetCountry();
        //}
        //#endregion
        //#region Primary
        [HttpGet]
        [Route("GetPrimaryList")]
        public List<PrimaryModel> GetPrimaryList()
        {
            return setupService.GetPrimaryList();
        }

        //#endregion
        [HttpGet]
        [Route("GetUnitList")]
        public List<UnitModel> GetUnitList()
        {
            return setupService.GetUnitList();
        }
        [HttpGet]
        [Route("GetColorList")]
        public List<ColorModel> GetColorList()
        {
            return setupService.GetColorList();
        }
        [HttpGet]
        [Route("GetItemForm_Appearance")]
        public List<ItemForm_Appearance> GetItemForm_Appearance()
        {
            return setupService.GetItemForm_Appearance();
        }

        [HttpGet]
        [Route("GetItemSewstiveness")]
        public List<ItemSewstivenessModel> GetItemSewstiveness()
        {
            return setupService.GetItemSewstiveness();
        }

        [HttpPost]
        [Route("AddBrand")]
        public BrandModel AddBrand([FromBody] BrandModel brand)
        {
            if (ModelState.IsValid) return setupService.AddBrand(brand);
            return null;
        }
        [HttpPut]
        [Route("UpdateBrand")]
        public BrandModel UpdateBrand([FromBody] BrandModel brand)
        {
            if (ModelState.IsValid) return setupService.UpdateBrand(brand);
            return null;
        }

        [HttpPost]
        [Route("AddUnit")]
        public UnitModel AddUnit([FromBody] UnitModel unitModel)
        {
            if (ModelState.IsValid) return setupService.AddUnit(unitModel);
            return null;
        }
        [HttpPut]
        [Route("UpdateUnit")]
        public UnitModel UpdateUnit([FromBody] UnitModel unitModel)
        {
            if (ModelState.IsValid) return setupService.UpdateUnit(unitModel);
            return null;
        }
        [HttpDelete]
        [Route("DeleteUnit/{id}")]
        public void DeleteUnit(int id)
        {
            setupService.DeleteUnit(id);
        }
        [HttpGet]
        [Route("GetUnit")]
        public List<UnitModel> GetUnit()
        {
            return setupService.GetUnitList();
        }
        [HttpPost]
        [Route("AddItemCategory")]
        public ItemCategory AddItemCategory([FromBody] ItemCategory itemCategory)
        {
            if (ModelState.IsValid) return setupService.AddItemCategory(itemCategory);
            return null;
        }
        [HttpPost]
        [Route("AddItemSubCategory")]
        public ItemSubCategory AddItemSubCategory([FromBody] ItemSubCategory itemCategory)
        {
            if (ModelState.IsValid) return setupService.AddItemSubCategory(itemCategory);
            return null;
        }
        [HttpPut]
        [Route("UpdateItemCategory")]
        public ItemCategory UpdateItemCategory([FromBody] ItemCategory itemCategory)
        {
            if (ModelState.IsValid) return setupService.UpdateItemCategory(itemCategory);
            return null;
        }
        [HttpDelete]
        [Route("DeleteCategory/{id}")]
        public void DeleteCategory(int id)
        {
            setupService.DeleteCategory(id);
        }
        [HttpGet]
        [Route("GetServiceList")]
        public List<ServiceEntity> GetServiceList()
        {
            return setupService.GetServiceList();
        }

        [HttpPost]
        [Route("AddService")]
        public ServiceEntity AddService([FromBody] ServiceEntity itemCategory)
        {
            if (ModelState.IsValid) return setupService.AddService(itemCategory);
            return null;
        }
        [HttpPut]
        [Route("UpdateService")]
        public ServiceEntity UpdateService([FromBody] ServiceEntity itemCategory)
        {
            if (ModelState.IsValid) return setupService.UpdateService(itemCategory);
            return null;
        }
        [HttpDelete]
        [Route("DeleteService/{id}")]
        public void DeleteService(int id)
        {
            setupService.DeleteCategory(id);
        }
        [HttpDelete]
        [Route("DeleteBrand/{id}")]
        public void DeleteBrand(int id)
        {
            setupService.DeleteBrand(id);
        }
        [HttpDelete]
        [Route("DeleteCountry/{id}")]
        public void DeleteCountry(int id)
        {
            setupService.DeleteCountry(id);
        }


        [HttpGet]
        [Route("GetItemCategory")]
        public List<ItemCategory> GetItemCategory()
        {
            return setupService.GetItemCategory();
        }
        [HttpGet]
        [Route("GetCategoryNameListById/{Ids}")]
        public List<string> GetCategoryNameListById(string Ids)
        {
            return setupService.GetCategoryNameListById(Ids);
        }
        [HttpPost]
        [Route("AddTermsConditionType")]
        public TermsConditionTypeEntity AddTermsConditionType([FromBody] TermsConditionTypeEntity typeEntity)
        {
            if (ModelState.IsValid) return setupService.AddTermsConditionType(typeEntity);
            return null;

        }
        [HttpGet]
        [Route("GetTermsConditionType")]
        public List<TermsConditionTypeEntity> GetTermsConditionType()
        {
            return setupService.GetTermsConditionType();
        }
        [HttpGet]
        [Route("GetItemType")]
        public List<clsItemType> GetItemType()
        {
            return setupService.GetItemType();
        }
        //GetItemType
        [HttpPost]
        [Route("AddColor")]
        public ColorModel AddColor([FromBody] ColorModel colorModel)
        {
            if (ModelState.IsValid) return setupService.AddColor(colorModel);
            return null;
        }
        [HttpPost]
        [Route("AddItemType")]
        public clsItemType AddItemType([FromBody] clsItemType itemType)
        {
            if (ModelState.IsValid) return setupService.AddItemType(itemType);
            return null;
        }
        [HttpPut]
        [Route("UpdateColor")]
        public ColorModel UpdateColor([FromBody] ColorModel colorModel)
        {
            if (ModelState.IsValid) return setupService.UpdateColor(colorModel);
            return null;
        }
        [HttpDelete]
        [Route("DeleteColor/{id}")]
        public void DeleteColor(int id)
        {
            setupService.DeleteColor(id);
        }

        [HttpGet]
        [Route("GetWareHouseList")]
        public List<WarehouseModel> GetWarehouseList()
        {
            return setupService.GetWareHouseList();
        }
        [HttpPost]
        [Route("AddPlanAndWorkSchedule")]
        public PlanAndOperationModel AddPlanAndWorkSchedule([FromBody] PlanAndOperationModel planAndOperation)
        {
            if (ModelState.IsValid) return setupService.AddPlanAndWorkSchedule(planAndOperation);
            return null;
        }
        [HttpPut]
        [Route("UpdatePlanAndWorkSchedule")]
        public PlanAndOperationModel UpdatePlanAndWorkSchedule([FromBody] PlanAndOperationModel planAndOperation)
        {
            if (ModelState.IsValid) return setupService.UpdatePlanAndWorkSchedule(planAndOperation);
            return null;
        }

        [HttpGet]
        [Route("GetWorkSchedule/{departmentId}")]
        public List<PlanandOperationViewModel> GetWorkSchedule(int departmentId)
        {
            return setupService.GetWorkSchedule(departmentId);
        }
        [HttpGet]
        [Route("GetWorkScheduleBySuperAdmin")]
        public List<PlanandOperationViewModel> GetWorkScheduleBySuperAdmin()
        {
            return setupService.GetWorkScheduleBySuperAdmin();
        }
        [HttpGet]
        [Route("GetPlanAndWorkScheduleById/{Id}")]
        public PlanAndOperationModel GetPlanAndWorkScheduleById(int Id)
        {
            return setupService.GetPlanAndWorkScheduleById(Id);
        }
        [HttpGet]
        [Route("GetPlanAndWorkScheduleViewById/{Id}")]
        public PlanandOperationViewModel GetPlanAndWorkScheduleViewById(string Id)
        {
            return setupService.GetPlanAndWorkScheduleViewById(Id);
        }

        [HttpGet]
        [Route("GetPlanAndWorkStatus")]
        public List<PlanAndWorkScheduleStatusModel> GetPlanAndWorkStatus()
        {
            return setupService.GetPlanAndWorkStatus();
        }
        //[HttpGet]
        //[Route("GetWorkScheduleBySearchOption/{searchOption}")]
        //public List<PlanandOperationViewModel> GetWorkScheduleBySearchOption(string searchOption)
        //{
        //    return setupService.GetWorkScheduleBySearchOption(searchOption);
        //}
        [HttpGet]
        [Route("GetDeliveryTime")]
        public List<PDeliveryTimeModel> GetDeliveryTime()
        {
            return setupService.GetDeliveryTime();
        }
        [HttpGet]
        [Route("GetShippingAddress")]
        public List<ShippingAddressModel> GetShippingAddress()
        {
            return setupService.GetShippingAddress();
        }
        //[HttpGet]
        //[Route("GetWareHouseList")]
        //public List<WarehouseModel> GetWareHouseList()
        //{
        //    return setupService.GetWareHouseList();
        //}
        [HttpPost]
        [Route("AddShippingAddress")]
        public ShippingAddressModel AddShippingAddress([FromBody] ShippingAddressModel shippingAddressModel)
        {
            return setupService.AddShippingAddress(shippingAddressModel);
        }
        [HttpPost]
        [Route("AddDeliveryMode")]
        public DeliveryModeModel AddDeliveryMode([FromBody] DeliveryModeModel deliveryMode)
        {
            return setupService.AddDeliveryMode(deliveryMode);
        }
        [HttpGet]
        [Route("GetDeliveryMode")]
        public List<DeliveryModeModel> GetDeliveryMode()
        { return setupService.GetDeliveryMode(); }
        [HttpPost]
        [Route("AddPaymentTerm")]
        public PaymentTermModel AddPaymentTerm([FromBody] PaymentTermModel paymentTerm)
        {
            return setupService.AddPaymentTerm(paymentTerm);
        }
        [HttpGet]
        [Route("GetPaymentTerm")]
        public List<PaymentTermModel> GetPaymentTerm()
        { return setupService.GetPaymentTerm(); }
        [HttpPost]
        [Route("AddCountry")]
        public CountryModel AddCountry([FromBody] CountryModel country)
        {
            if (ModelState.IsValid) return setupService.AddCountry(country);
            return null;
        }
        [HttpPut]
        [Route("UpdateCountry")]
        public CountryModel UpdateCountry([FromBody] CountryModel country)
        {
            if (ModelState.IsValid) return setupService.UpdateCountry(country);
            return null;
        }

        [HttpGet]
        [Route("GetCountry")]
        public List<CountryModel> GetCountry()
        {
            return setupService.GetCountry();
        }
        [HttpGet]
        [Route("GetPackagingInstruction")]
        public List<PackagingInstructionModel> GetPackagingIns()
        {
            return setupService.GetPackagingInstruction();
        }
        [HttpPost]
        [Route("AddPackagingInstruction")]
        public PackagingInstructionModel AddPackagingInstruction([FromBody] PackagingInstructionModel packagingIns)
        {
            if (ModelState.IsValid) return setupService.AddPackagingInstruction(packagingIns);
            return null;
        }
        [HttpGet]
        [Route("GetTermsConditions")]
        public List<PurchaseTermsConditionsModel> GetTermsConditions()
        { return setupService.GetPurchaseTermsConditions(); }
        [HttpGet]
        [Route("GetSalesTermsConditions")]
        public List<PurchaseTermsConditionsModel> GetSalesTermsConditions()
        { return setupService.GetSalesTermsConditions(); }
        [HttpGet]
        [Route("GetSalesTermsConditionsForSalesOrder")]
        public List<PurchaseTermsConditionsModel> GetSalesTermsConditionsForSalesOrder()
        { return setupService.GetSalesTermsConditionsForSalesOrder(); }


        [HttpGet]
        [Route("GetSalesTermsConditionsBySearch/{searchParameter}")]
        public List<PurchaseTermsConditionsModel> GetSalesTermsConditionsBySearch(string searchParameter)
        { return setupService.GetSalesTermsConditionsBySearch(searchParameter); }

        [HttpPost]
        [Route("AddTermsConditions")]
        public PurchaseTermsConditionsModel AddTermsConditions([FromBody] PurchaseTermsConditionsModel termsConditions)
        {
            if (ModelState.IsValid) return setupService.AddTermsCondition(termsConditions);
            return null;
        }
        [HttpPost]
        [Route("AddSalesTermsConditions")]
        public PurchaseTermsConditionsModel AddSalesTermsConditions([FromBody] PurchaseTermsConditionsModel termsConditions)
        {
            if (ModelState.IsValid) return setupService.AddSalesTermsCondition(termsConditions);
            return null;
        }
        [HttpPut]
        [Route("UpdateSalesTermsConditions")]
        public PurchaseTermsConditionsModel UpdateSalesTermsConditions([FromBody] PurchaseTermsConditionsModel termsConditions)
        {
            if (ModelState.IsValid) return setupService.UpdateSalesTermsCondition(termsConditions);
            return null;
        }
        [HttpDelete]
        [Route("DeleteTermsConditions/{id}")]
        public void DeleteTermsConditions(int id)
        {
            setupService.DeleteSalesTermsConditions(id);
        }

        [HttpPost]
        [Route("AddIncoterm")]
        public InCoTermModel AddIncoterm([FromBody] InCoTermModel incoterm)
        {
            if (ModelState.IsValid) return setupService.AddIncoterm(incoterm);
            return null;
        }

        [HttpDelete]
        [Route("DeletePlanAndWorkScheduleById/{id}")]
        public void DeletePlanAndWorkScheduleById(int id)
        {
            setupService.DeletePlanAndWorkScheduleById(id);
        }
        [HttpGet]
        [Route("GetIncoTerm")]
        public List<InCoTermModel> GetIncoTerm()
        { return setupService.GetIncoTerm(); }

        [HttpGet]
        [Route("GetShipVia")]
        public List<ShipViaModel> GetShipVia()
        { return setupService.GetShipVia(); }
        [HttpPost]
        [Route("AddShipVia")]
        public ShipViaModel AddShipVia([FromBody] ShipViaModel incoterm)
        {
            if (ModelState.IsValid) return setupService.AddShipVia(incoterm);
            return null;
        }
        [HttpGet]
        [Route("GetExpectedDeliveryDate")]
        public List<ExpectedDeliveryDateModel> GetExpectedDeliveryDate()
        { return setupService.GetExpectedDeliveryDate(); }
        [HttpPost]
        [Route("AddExpectedDeliveryDate")]
        public ExpectedDeliveryDateModel AddExpectedDeliveryDate([FromBody] ExpectedDeliveryDateModel expecteddate)
        {
            if (ModelState.IsValid) return setupService.AddExpectedDeliveryDate(expecteddate);
            return null;
        }

        [HttpGet]
        [Route("GetBrandList")]
        public List<BrandModel> GetBrandList()
        { return setupService.GetBrandList(); }

        [HttpGet]
        [Route("GetItemSubCategory")]
        public List<ItemSubCategory> GetItemSubCategory()
        {
            return setupService.GetItemSubCategory();
        }
        [HttpGet]
        [Route("GetItemSubCategoryByCatId/{Id}")]
        public List<ItemSubCategory> GetItemSubCategoryByCatId(string Id)
        {
            return setupService.GetItemSubCategoryById(Id);
        }
        [HttpGet]
        [Route("GetItemSubCategoryList")]
        public List<ItemSubCategory> GetItemSubCategoryList()
        {
            return setupService.GetItemSubCategoryList();
        }
        [HttpGet]
        [Route("GetItemApplicationArea")]
        public List<ItemApplicationAreaModel> GetItemApplicationArea()
        { return setupService.GetItemApplicationArea(); }
        [HttpPost]
        [Route("AddItemApplicationArea")]
        public ItemApplicationAreaModel AddApplicationArea([FromBody] ItemApplicationAreaModel applicationArea)
        {
            if (ModelState.IsValid) return setupService.AddApplicationArea(applicationArea);
            return null;
        }
        [HttpPut]
        [Route("UpdateItemApplicationArea")]
        public ItemApplicationAreaModel UpdateApplicationArea([FromBody] ItemApplicationAreaModel applicationArea)
        {
            if (ModelState.IsValid) return setupService.UpdateApplicationArea(applicationArea);
            return null;
        }
        [HttpDelete]
        [Route("DeleteApplicationArea/{id}")]
        public void DeleteApplicationArea(int id)
        {
            setupService.DeleteApplicationArea(id);
        }
        [HttpDelete]
        [Route("DeleteProject/{id}")]
        public void DeleteProject(int id)
        {
            setupService.DeleteProject(id);
        }
        

        [HttpPost]
        [Route("AddInventoryType")]
        public InventoryTypeModel AddInventoryType([FromBody] InventoryTypeModel applicationArea)
        {
            if (ModelState.IsValid) return setupService.AddInventoryType(applicationArea);
            return null;
        }
        [HttpPut]
        [Route("UpdateInventoryType")]
        public InventoryTypeModel UpdateInventoryType([FromBody] InventoryTypeModel applicationArea)
        {
            if (ModelState.IsValid) return setupService.UpdateInventoryType(applicationArea);
            return null;
        }
        [HttpDelete]
        [Route("DeleteInventoryType/{id}")]
        public void DeleteInventoryType(int id)
        {
            setupService.DeleteInventoryType(id);
        }

        [HttpGet]
        [Route("GetInventoryType")]
        public List<InventoryTypeModel> GetInventoryType()
        { return setupService.GetInventoryType(); }

        [HttpGet]
        [Route("GetTaxInfo")]
        public TAX_CLASS GetTaxInfo()
        { return setupService.GetTaxInfo(); }


        [HttpPost]
        [Route("AddServiceCategory")]
        public ServiceCategoryEntity AddServiceCategory([FromBody] ServiceCategoryEntity srvc)
        {
            if (ModelState.IsValid) return setupService.AddServiceCategory(srvc);
            return null;
        }
        [HttpPost]
        [Route("AddServiceSubCategory")]
        public ServiceSubCategoryEntity AddServiceSubCategory([FromBody] ServiceSubCategoryEntity srvc)
        {
            if (ModelState.IsValid) return setupService.AddServiceSubCategory(srvc);
            return null;
        }
        [HttpGet]
        [Route("GetServiceCategory")]
        public List<ServiceCategoryEntity> GetServiceCategory()
        {
            return setupService.GetServiceCategoryList();
        }
        [HttpGet]
        [Route("GetServiceSubCategory")]
        public List<ServiceSubCategoryEntity> GetServiceSubCategory()
        {
            return setupService.GetServiceSubCategoryList();
        }
        [HttpPut]
        [Route("UpdateServiceCategory")]
        public ServiceCategoryEntity UpdateServiceCategory([FromBody] ServiceCategoryEntity srvc)
        {
            if (ModelState.IsValid) return setupService.UpdateServiceCategory(srvc);
            return null;
        }
        [HttpPut]
        [Route("UpdateServiceSubCategory")]
        public ServiceSubCategoryEntity UpdateServiceSubCategory([FromBody] ServiceSubCategoryEntity srvc)
        {
            if (ModelState.IsValid) return setupService.UpdateServiceSubCategory(srvc);
            return null;
        }
        [HttpDelete]
        [Route("DeleteServiceCategory/{id}")]
        public void DeleteServiceCategory(int id)
        {
            setupService.DeleteServiceCategory(id);
        }
        [HttpDelete]
        [Route("DeleteServiceSubCategory/{id}")]
        public void DeleteServiceSubCategory(int id)
        {
            setupService.DeleteServiceSubCategory(id);
        }
        [HttpGet]
        [Route("GetServiceSubCategoryWithCategory")]
        public List<ServiceSubCategoryEntity> GetServiceSubCategoryWithCategory()
        {
            return setupService.GetServiceSubCategoryWithCategory();
        }
        [HttpGet]
        [Route("GetServiceDetails")]
        public List<ServiceEntity> GetServiceDetails()
        {
            return setupService.GetServiceDetails();
        }
        #endregion
    }
}
