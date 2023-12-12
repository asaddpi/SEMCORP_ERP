using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;
using Microsoft.ApplicationBlocks.Data;


namespace TOCOMA_API_Service.Service
{
    public class PurchaseService
    {
        protected readonly ApplicationDbContex _dbContext;
        PurchaseRequisitionEntity _opurchaseRequisition = new PurchaseRequisitionEntity();
        PurchaseOrderModel _opurchaseOrder = new PurchaseOrderModel();
        string strSQL;
        //private ReportService _ReportService = new ReportService();



        public PurchaseService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        //public PurchaseService(IHostingEnvironment host)
        //{
        //    _host = host;
        //}
        public List<PurchaseRequisitionEntity> GetProductCategoryList()
        {
            IDataReader dr = null;
            PurchaseRequisitionEntity category = null;
            List<PurchaseRequisitionEntity> categoryList = new List<PurchaseRequisitionEntity>();
            try
            {
                //dr = SqlHelper.ExecuteReader(Global.ConnectionString, "SP_CATEGORY_GET_ALL_DATA_FROM_TBL_PRODUCTCATEGORY");
                while (dr.Read())
                {
                    //category = new clsPurchaseRequisition();
                    //category.SL = Convert.ToString(dr["SL"]);
                    //category.ProductCategoryId = Convert.ToInt32((dr["ProductCategoryId"]));
                    //category.CategoryCode = Convert.ToString((dr["CategoryCode"]));
                    //category.ProductCategoryName = Convert.ToString((dr["ProductCategoryName"]));
                    //categoryList.Add(category);
                }
                List<PurchaseRequisitionEntity> p = new List<PurchaseRequisitionEntity>();
                PurchaseRequisitionEntity pur = new PurchaseRequisitionEntity();
                pur.REQUEST_DEPARTMENT_ID = 1;
                pur.PRIORITY = "High";
                pur.REG_BY = "Asad";
                p.Add(pur);
                return p;
            }
            catch
            {
                return null;
            }
            finally
            {
                if ((dr != null))
                { dr.Close(); }
            }
        }

        internal List<PurchaseRequisitionViewEntity> GetPurchaseRequistionListForApproval()
        {
            List<PurchaseRequisitionViewEntity> purchaseRequisitionList = new List<PurchaseRequisitionViewEntity>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseRequisitionViewEntity>("SP_PURCHASE_GET_PURCHASE_REQUISITION_INFO_FOR_APPROVAL");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchaseRequisitionList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchaseRequisitionList;
        }
        internal List<PurchaseRequisitionViewEntity> ManageRequisition()
        {
            List<PurchaseRequisitionViewEntity> purchaseRequisitionList = new List<PurchaseRequisitionViewEntity>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseRequisitionViewEntity>("SP_PURCHASE_MANAGE_PURCHASE_REQUISITION");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchaseRequisitionList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchaseRequisitionList;
        }
        internal List<PurchaseRequisitionViewEntity> GetPurchaseRequistionList()
        {
            List<PurchaseRequisitionViewEntity> purchaseRequisitionList = new List<PurchaseRequisitionViewEntity>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseRequisitionViewEntity>("SP_PURCHASE_GET_PURCHASE_REQUISITION_INFO");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchaseRequisitionList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchaseRequisitionList;
        }

        internal PurchaseRequisitionViewEntity GetPurchaseRequisitionInfoByNo(string reqNo)
        {
            PurchaseRequisitionViewEntity purchasereq = new PurchaseRequisitionViewEntity();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@REQUISITION_NO", reqNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseRequisitionViewEntity>("SP_PURCHASE_GET_PURCHASE_REQUISITION_DETAILS_BY_REQ_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchasereq = oproductgroup.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchasereq;
        }

        internal List<PurchaseOrderViewModel> GetPoList()
        {
            List<PurchaseOrderViewModel> purchaseOrderList = new List<PurchaseOrderViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseOrderViewModel>("SP_PO_GET_PURCHASE_ORDER_LIST");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchaseOrderList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchaseOrderList;
        }
        internal List<PurchaseOrderViewModel> GetPOTrackingList()
        {
            List<PurchaseOrderViewModel> purchaseOrderList = new List<PurchaseOrderViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_ORDER_TRACKER");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchaseOrderList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchaseOrderList;
        }


        internal List<PurchaseOrderViewModel> GetUnPaidPoListByVendorCode(string vendorCode)
        {
            List<PurchaseOrderViewModel> purchaseOrderList = new List<PurchaseOrderViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@VENDOR_ID", vendorCode, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseOrderViewModel>("SP_VENDOR_GET_UNPAID_PO_LIST_BY_VENDOR", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchaseOrderList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchaseOrderList;
        }

        internal PRE GeneratePurchaseInvoice(PRE purchase, string rooPath)
        {
            PRE p = new PRE();

            DataRow row;
            string Path = "";
            string ReportName = "";
            string strResourcePath = "";
            string SheetName = "";
            string PageCount = "1";
            string ReportNo = "2";
            string responseURL = "";
            string reportType = "41";
            int checkeditem = 1;
            string str_sql_query = "";

            DataSet DS = new DataSet();
            DataTable dataTab = new DataTable();


            Path = "\\Reports\\Purchase_Report.xlsx";
            ReportName = "Purchase_Report";
            SheetName = "Purchase";
            DS = GetData();
            strResourcePath = rooPath + Path;
            string tempath = rooPath + "\\Reports";
            dataTab = DS.Tables[0];
            DataTable dataTab1 = new DataTable();
            dataTab1.TableName = "ReportInfo";
            dataTab1.Columns.Add(new DataColumn("ResourcePath", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("ReportName", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("SheetName", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("PageCount", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("ReportNo", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("checkeditem", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("reportType", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("Dropvalue", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("Datestring", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("Datestring2", typeof(string)));
            dataTab1.Columns.Add(new DataColumn("Datestring3", typeof(string)));

            row = dataTab1.NewRow();
            row["ResourcePath"] = strResourcePath;
            row["ReportName"] = ReportName;
            row["SheetName"] = SheetName;
            row["PageCount"] = PageCount;
            row["ReportNo"] = ReportNo;
            row["checkeditem"] = checkeditem;
            row["reportType"] = reportType;
            dataTab1.Rows.Add(row);


            //---------------------------------------------
            DS.Tables.Add(dataTab1);
            string STR_MESSAGE = "";
            PrintInformationOutputItem outputItem = new PrintInformationOutputItem();
            outputItem.dataSet = DS;
            if (DS != null && DS.Tables[0].Rows.Count > 0)
            {
                //_ReportService.GENERATE_INVOICE(OutputReportSupport.GetReportConfig(outputItem), outputItem.dataSet, strResourcePath);
                //Session["mag"] = "Invoice Created Successfully";
                //_ReportService.GENERATE_INVOICE(OutputReportSupport.GetReportConfig(outputItem), outputItem.dataSet);
                //STR_MESSAGE = "Invoice Created Successfully";
            }
            else { }
            return p;
        }
        private DataSet GetData()
        {
            DataSet DS = new DataSet();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                connection.Open();
            }
            DS = SqlHelper.ExecuteDataset(Global.ConnectionString, CommandType.Text, "SELECT * FROM TBL_ITEM");

            return DS;

        }

        internal List<OrderItemEntity> GetPurchaseRequisitionItemByNo(string reqNo)
        {
            List<OrderItemEntity> purchasereqitemList = new List<OrderItemEntity>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@REQUISITION_NO", reqNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<OrderItemEntity>("SP_PURCHASE_GET_PURCHASE_REQUISITION_ITEM_BY_REQ_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchasereqitemList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchasereqitemList;
        }
        internal List<PurchaseRequisitionDetailsEntity> GetPurchaseRequisitionItemDetailsByReqNo(string reqNo)
        {
            List<PurchaseRequisitionDetailsEntity> purchasereqitemList = new List<PurchaseRequisitionDetailsEntity>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@REQUISITION_NO", reqNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseRequisitionDetailsEntity>("SP_PURCHASE_GET_PURCHASE_REQUISITION_ITEM_BY_REQ_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchasereqitemList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchasereqitemList;
        }

        internal bool CheckExistItem(string voucherNo)
        {
            bool flag = false;
            IDataReader dr = null;
            dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "Select * from TBL_PURCHASE_ORDER Where VOUCHER_NO='"+ voucherNo + "'");
            while(dr.Read())
            {
                flag = true;
            }
            return flag;
        }

        internal List<PurchaseRequisitionOthersModel> GetPurchaseRequisitionOthersItemByReqNo(string reqNo)
        {
            List<PurchaseRequisitionOthersModel> purchasereqitemList = new List<PurchaseRequisitionOthersModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@REQUISITION_NO", reqNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseRequisitionOthersModel>("SP_PURCHASE_GET_PURCHASE_REQUISITION_OTHERS_ITEM_BY_REQ_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchasereqitemList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchasereqitemList;
        }
        public PurchaseRequisitionViewEntity GetPurchaseReqInfo(string reqNo)
        {
            PurchaseRequisitionViewEntity purchaseReqView = new PurchaseRequisitionViewEntity();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@REQUISITION_NO", reqNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<PurchaseRequisitionViewEntity>("SP_PURCHASE_GET_PURCHASE_REQUISITION_BY_REQ_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchaseReqView = oproductgroup.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchaseReqView;
        }

        internal int GetItemId(string itemName)
        {
            SqlHelper.ExecuteNonQuery(Global.ConnectionString, "INSERT INTO TBL_ITEM (ITEM_NAME)VALUES(" + itemName + ")");

            int itemId = 0;

            return itemId;
        }

        internal List<PurchaseRequisitionDetailsEntity> AddPurchaseRequisitionDetails(List<PurchaseRequisitionDetailsEntity> purchaseRequisitionDetails)
        {
            List<PurchaseRequisitionDetailsEntity> _opurchaseRequisitionDetails = new List<PurchaseRequisitionDetailsEntity>();
            try
            {
                if (purchaseRequisitionDetails.Count > 0)
                {
                    foreach (var requisitionDetails in purchaseRequisitionDetails)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<PurchaseRequisitionDetailsEntity>("SP_PURCHASE_INSERT_PURCHASE_REQUISITION_DETAILS",
                                this.SetParametersRequisitionDetails(requisitionDetails), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }
        internal List<PurchaseRequisitionDetailsEntity> UpdatePurchaseRequisitionDetails(List<PurchaseRequisitionDetailsEntity> purchaseRequisitionDetails)
        {
            List<PurchaseRequisitionDetailsEntity> _opurchaseRequisitionDetails = new List<PurchaseRequisitionDetailsEntity>();
            try
            {
                if (purchaseRequisitionDetails.Count > 0)
                {
                    foreach (var requisitionDetails in purchaseRequisitionDetails)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<PurchaseRequisitionDetailsEntity>("SP_PURCHASE_UPDATE_PURCHASE_REQUISITION_DETAILS",
                                this.SetParametersRequisitionDetails(requisitionDetails), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }
        //---------
        internal List<PurchaseRequisitionOthersModel> AddPurchaseRequisitionOthers(List<PurchaseRequisitionOthersModel> purchaseRequisitionDetails)
        {
            List<PurchaseRequisitionOthersModel> _opurchaseRequisitionDetails = new List<PurchaseRequisitionOthersModel>();
            try
            {
                if (purchaseRequisitionDetails.Count > 0)
                {
                    foreach (var requisitionDetails in purchaseRequisitionDetails)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<PurchaseRequisitionOthersModel>("SP_PURCHASE_INSERT_PURCHASE_REQUISITION_OTHERS",
                                this.SetParametersRequisitionOthers(requisitionDetails), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }

        public DynamicParameters SetParametersRequisitionDetails(PurchaseRequisitionDetailsEntity purchaseRequisitionDetails)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PURCHASE_REQUISITION_DETAILS_ID", purchaseRequisitionDetails.PURCHASE_REQUISITION_DETAILS_ID);
            parameters.Add("@PURCHASE_REQUISITION_ID", purchaseRequisitionDetails.PURCHASE_REQUISITION_ID);
            parameters.Add("@REQUISITION_NO", purchaseRequisitionDetails.REQUISITION_NO);
            parameters.Add("@ITEM_ID", purchaseRequisitionDetails.ITEM_ID);
            parameters.Add("@PACK_SIZE", purchaseRequisitionDetails.PACK_SIZE);
            parameters.Add("@UOM", purchaseRequisitionDetails.UOM);
            parameters.Add("@QUANTITY", purchaseRequisitionDetails.QUANTITY);
            parameters.Add("@RATE", purchaseRequisitionDetails.RATE);

            return parameters;
        }
        internal List<PurchaseRequisitionOthersModel> UpdatePurchaseRequisitionOthers(List<PurchaseRequisitionOthersModel> purchaseRequisitionDetails)
        {
            List<PurchaseRequisitionOthersModel> _opurchaseRequisitionDetails = new List<PurchaseRequisitionOthersModel>();
            try
            {
                if (purchaseRequisitionDetails.Count > 0)
                {
                    foreach (var requisitionDetails in purchaseRequisitionDetails)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<PurchaseRequisitionOthersModel>("SP_PURCHASE_UPDATE_PURCHASE_REQUISITION_OTHERS",
                                this.UpdateRequisitionOthersParam(requisitionDetails), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }
        public DynamicParameters UpdateRequisitionOthersParam(PurchaseRequisitionOthersModel purchaseRequisitionOthers)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PURCHASE_REQUISITION_OTHERS_ID", purchaseRequisitionOthers.PURCHASE_REQUISITION_OTHERS_ID);
            parameters.Add("@PURCHASE_REQUISITION_ID", purchaseRequisitionOthers.PURCHASE_REQUISITION_ID);
            parameters.Add("@REQUISITION_NO", purchaseRequisitionOthers.REQUISITION_NO);
            parameters.Add("@OTHERS_ITEM", purchaseRequisitionOthers.OTHERS_ITEM);
            parameters.Add("@QUANTITY", purchaseRequisitionOthers.QUANTITY);
            parameters.Add("@UNIT", purchaseRequisitionOthers.UNIT);
            parameters.Add("@RATE", purchaseRequisitionOthers.RATE);

            return parameters;
        }
        public DynamicParameters SetParametersRequisitionOthers(PurchaseRequisitionOthersModel purchaseRequisitionOthers)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PURCHASE_REQUISITION_ID", purchaseRequisitionOthers.PURCHASE_REQUISITION_ID);
            parameters.Add("@REQUISITION_NO", purchaseRequisitionOthers.REQUISITION_NO);
            parameters.Add("@OTHERS_ITEM", purchaseRequisitionOthers.OTHERS_ITEM);
            parameters.Add("@QUANTITY", purchaseRequisitionOthers.QUANTITY);
            parameters.Add("@UNIT", purchaseRequisitionOthers.UNIT);
            parameters.Add("@RATE", purchaseRequisitionOthers.RATE);

            return parameters;
        }

        internal List<PurchaseOrderDetailsEntity> AddPurchaseOrderDetails(List<PurchaseOrderDetailsEntity> purchaseOrderDetails)
        {
            List<PurchaseOrderDetailsEntity> _opurchaseOrderDetails = new List<PurchaseOrderDetailsEntity>();
            try
            {
                if (purchaseOrderDetails.Count > 0)
                {
                    foreach (var requisitionDetails in purchaseOrderDetails)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<PurchaseOrderDetailsEntity>("SP_PURCHASE_INSERT_PURCHASE_ORDER_DETAILS",
                                this.SetParametersOrderDetails(requisitionDetails), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseOrderDetails;
        }
        public DynamicParameters SetParametersOrderDetails(PurchaseOrderDetailsEntity purchaseOrderDetails)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PO_DETAILS_ID", purchaseOrderDetails.PO_DETAILS_ID);
            parameters.Add("@PO_ID", purchaseOrderDetails.PO_ID);
            parameters.Add("@PO_NUMBER", purchaseOrderDetails.PO_NUMBER);
            parameters.Add("@ITEM_ID", purchaseOrderDetails.ITEM_ID);
            parameters.Add("@UOM", purchaseOrderDetails.UOM);
            parameters.Add("@QUANTITY", purchaseOrderDetails.QUANTITY);
            parameters.Add("@UNIT_PRICE", purchaseOrderDetails.UNIT_PRICE);
            parameters.Add("@UNIT_TOTAL", purchaseOrderDetails.UNIT_TOTAL);
            parameters.Add("@AIT", purchaseOrderDetails.AIT);
            parameters.Add("@VAT", purchaseOrderDetails.VAT);
            parameters.Add("@ADJ_RETURN_DISCOUNT", purchaseOrderDetails.ADJ_RETURN_DISCOUNT);
            parameters.Add("@PACK_SIZE", purchaseOrderDetails.PACK_SIZE);


            return parameters;
        }

        public PurchaseRequisitionEntity UpdateRequisitionStatus(PurchaseRequisitionEntity purchaseRequisition)
        {
            _opurchaseRequisition = new PurchaseRequisitionEntity();
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "UPDATE TBL_PURCHASE_REQUISITION SET STATUS='" + purchaseRequisition.STATUS + "' WHERE REQUISITION_NO='" + purchaseRequisition.REQUISITION_NO + "'");
                //using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                //{
                //    if (connection.State == ConnectionState.Closed) connection.Open();
                //    var _oproductcategory = connection.Query<PurchaseRequisitionEntity>("SP_PURCHASE_INSERT_PURCHASE_REQUISITION",
                //        this.SetParameters(purchaseRequisition), commandType: CommandType.StoredProcedure);
                //}
            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisition;
        }
        public PurchaseRequisitionEntity AddPurchaseRequisition(PurchaseRequisitionEntity purchaseRequisition)
        {
            _opurchaseRequisition = new PurchaseRequisitionEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<PurchaseRequisitionEntity>("SP_PURCHASE_INSERT_PURCHASE_REQUISITION",
                        this.SetParameters(purchaseRequisition), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisition;
        }
        public PurchaseRequisitionEntity UpdatePurchaseRequisition(PurchaseRequisitionEntity purchaseRequisition)
        {
            _opurchaseRequisition = new PurchaseRequisitionEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<PurchaseRequisitionEntity>("SP_PURCHASE_UPDATE_PURCHASE_REQUISITION",
                        this.SetParameters(purchaseRequisition), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisition;
        }
        public DynamicParameters SetParameters(PurchaseRequisitionEntity purchaseRequisition)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PURCHASE_REQUISITION_ID", purchaseRequisition.PURCHASE_REQUISITION_ID);
            parameters.Add("@REQUISITION_NO", purchaseRequisition.REQUISITION_NO);
            parameters.Add("@REQUESTED_BY", purchaseRequisition.REQUESTED_BY);
            parameters.Add("@REQUEST_DEPARTMENT_ID", purchaseRequisition.REQUEST_DEPARTMENT_ID);
            parameters.Add("@REQUEST_RECEIVE_DEPARTMENT_ID", purchaseRequisition.REQUEST_RECEIVE_DEPARTMENT_ID);
            parameters.Add("@REQUEST_DATE", purchaseRequisition.REQUEST_DATE);
            parameters.Add("@REQUIRED_DATE", purchaseRequisition.REQUIRED_DATE);
            parameters.Add("@REQUEST_FOR", purchaseRequisition.REQUEST_FOR);
            parameters.Add("@PRIORITY", purchaseRequisition.PRIORITY);
            parameters.Add("@REQUISITION_PURPOSE", purchaseRequisition.REQUISITION_PURPOSE);
            parameters.Add("@PAYMENT_MODE", purchaseRequisition.PAYMENT_MODE);
            parameters.Add("@REQUISITION_TOTAL", purchaseRequisition.REQUISITION_TOTAL);
            parameters.Add("@STATUS", purchaseRequisition.STATUS);
            parameters.Add("@REG_BY", purchaseRequisition.REG_BY);


            return parameters;
        }
        internal PurchaseOrderModel AddPurchaseForProject(PurchaseOrderModel purchase)
        {
            bool flag = false;
            int vendorId = 0;
            string vendorName = "";
            PurchaseOrderModel payment = new PurchaseOrderModel();
            ItemEntity itemEntity = new ItemEntity();
            string voucher_type ="34";
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    SqlDataReader dr;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;



                    strSQL = "SELECT 'PO-'+RIGHT('00000000'+CAST(NEXT VALUE FOR PO_UNIC_NO AS VARCHAR(8)),8)";
                    command.CommandText = strSQL;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {

                        purchase.PO_NUMBER_LONG_CODE = dr.GetValue(0).ToString();

                    }
                    dr.Close();

                    //---------Find Vendor
                    strSQL = "SELECT ";
                    strSQL = strSQL + "VENDOR_NAME,VENDOR_ID ";
                    strSQL = strSQL + "FROM TBL_VENDOR_REGISTRATION ";
                    strSQL = strSQL + "WHERE VENDOR_NAME='" + purchase.VENDOR_NAME + "' ";

                    command.CommandText = strSQL;                    
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        vendorId = Convert.ToInt32(dr["VENDOR_ID"].ToString());
                        vendorName = dr["VENDOR_NAME"].ToString();
                        purchase.VENDOR_ID = vendorId;
                    }
                    dr.Close();
                    if (vendorId == 0)
                    {
                        string code = "";
                        try
                        {
                            strSQL = "SELECT 'V'+RIGHT('00000000'+CAST(NEXT VALUE FOR CUSTOMER_CODE AS VARCHAR(8)),8)";
                            command.CommandText = strSQL;
                            dr = command.ExecuteReader();
                            if (dr.Read())
                            {

                                code = dr.GetValue(0).ToString();

                            }
                            dr.Close();
                        }
                        catch (Exception EX)
                        {

                        }


                        strSQL = "INSERT INTO TBL_VENDOR_REGISTRATION";
                        strSQL = strSQL + "(VENDOR_CODE,VENDOR_NAME";

                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + code + "'";
                        strSQL = strSQL + ",'" + purchase.VENDOR_NAME + "' ";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();

                        strSQL = "SELECT ";
                        strSQL = strSQL + "VENDOR_NAME,VENDOR_ID ";
                        strSQL = strSQL + "FROM TBL_VENDOR_REGISTRATION ";
                        strSQL = strSQL + "WHERE VENDOR_NAME='" + purchase.VENDOR_NAME + "' ";

                        command.CommandText = strSQL;
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            vendorId = Convert.ToInt32(dr["VENDOR_ID"].ToString());
                            vendorName = dr["VENDOR_NAME"].ToString();
                            purchase.VENDOR_ID = vendorId;
                        }
                        dr.Close();
                    }

                    //-----------


                    ////------------Account
                    strSQL = "INSERT INTO ACC_COMPANY_VOUCHER(";
                    strSQL = strSQL + "COMP_REF_NO,BRANCH_ID,LEDGER_NAME,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,COMP_VOUCHER_MONTH_ID ";//COMP_VOUCHER_DUE_DATE,,AUTOJV
                    strSQL = strSQL + ",COMP_VOUCHER_AMOUNT,COMP_VOUCHER_NET_AMOUNT,COMP_VOUCHER_NARRATION)";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "' ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.BRANCH_ID + "' ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.LEDGER_NAME.Trim() + "' ";
                    strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_TYPE + " ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_DATE.ToShortDateString() + "' ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_DATE.ToString("MMMyy").ToUpper() + " ' ";
                    strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_AMOUNT + " ";
                    strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_NET_AMOUNT + " ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_NARRATION + "' ";
                    strSQL = strSQL + ")";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    string strChildKey = "", strReverseLedger = "", strDebitLedger = "", strCreditLedger = "";
                    int intloop = 1;
                    if (purchase.acc_Voucher_Model
                        .Count > 2)
                    {
                        strReverseLedger = "As Per Details";
                    }
                    else
                    {
                        strReverseLedger = "";
                    }
                    foreach (var voucheritem in purchase.acc_Voucher_Model)
                    {
                        strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                        strSQL = "INSERT INTO ACC_VOUCHER";
                        strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
                        strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
                        strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
                        strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,VOUCHER_CHEQUE_NUMBER,VOUCHER_CHEQUE_DATE,VOUCHER_CHEQUE_DRAWN_ON ";   //,TRANSFER_TYPE Not Found In Table
                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + voucheritem.COMP_REF_NO + "'";
                        strSQL = strSQL + ",'" + voucheritem.BRANCH_ID.Replace("'", "''") + "' ";
                        strSQL = strSQL + ",'" + strChildKey + "' ";
                        strSQL = strSQL + ", " + voucheritem.COMP_VOUCHER_TYPE + " ";
                        strSQL = strSQL + "," + intloop + "";
                        strSQL = strSQL + ",'" + voucheritem.COMP_VOUCHER_DATE.ToShortDateString() + "'";
                        strSQL = strSQL + ",'" + voucheritem.LEDGER_NAME.Replace("'", "''") + "' ";
                        if (voucheritem.VOUCHER_TOBY == "Dr")
                        {
                            strSQL = strSQL + "," + voucheritem.VOUCHER_DEBIT_AMOUNT + " ";
                            strSQL = strSQL + ",0 ";
                            strSQL = strSQL + ",'Dr'";
                            if (strReverseLedger != "")
                            {
                                strSQL = strSQL + ",'" + strReverseLedger + "' ";
                            }
                            else
                            {
                                strReverseLedger = purchase.acc_Voucher_Model.Find(x => x.VOUCHER_TOBY == "Dr").LEDGER_NAME;
                                strSQL = strSQL + ",'" + strReverseLedger + "' ";
                            }
                        }
                        else if (voucheritem.VOUCHER_TOBY == "Cr")
                        {
                            strSQL = strSQL + ",0 ";
                            strSQL = strSQL + "," + voucheritem.VOUCHER_CREDIT_AMOUNT + " ";
                            strSQL = strSQL + ",'Cr'";
                            if (strReverseLedger != "")
                            {
                                strSQL = strSQL + ",'" + strReverseLedger + "' ";
                            }
                            else
                            {
                                strReverseLedger = purchase.acc_Voucher_Model.Find(x => x.VOUCHER_TOBY == "Cr").LEDGER_NAME;
                                strSQL = strSQL + ",'" + strReverseLedger + "' ";
                            }
                        }
                        strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_NUMBER + "'";
                        strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_DATE.Year + "-" + voucheritem.VOUCHER_CHEQUE_DATE.Month + "-" + voucheritem.VOUCHER_CHEQUE_DATE.Day + "'";

                        strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_DRAWN_ON + "'";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();
                        intloop += 1;
                    }


                    ////---------end

                    strSQL = "INSERT INTO TBL_PURCHASE_ORDER(";
                    strSQL = strSQL + "PO_NUMBER_LONG_CODE,VOUCHER_NO,SUPPLIER_MEMO_NO,PO_DATE,VOUCHER_TYPE,CARRING_WAY_COST,LABOUR_COST,OTHERS_COST,GRAND_TOTAL,VENDOR_ID,DEPARTMENT_NAME,BUSINESS_ID,COMPANY_NAME) ";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + purchase.PO_NUMBER_LONG_CODE + "' ";
                    strSQL = strSQL + ",'" + purchase.VOUCHER_NO + "' ";
                    strSQL = strSQL + ",'" + purchase.SUPPLIER_MEMO_NO + "' ";
                    strSQL = strSQL + ",'" + purchase.PO_DATE + "' ";
                    strSQL = strSQL + ",'" + voucher_type + "' ";
                    strSQL = strSQL + ",'" + purchase.CARRING_WAY_COST + "' ";
                    strSQL = strSQL + "," + purchase.LABOUR_COST + " ";
                    strSQL = strSQL + ",'" + purchase.OTHERS_COST + "' ";
                    strSQL = strSQL + ",'" + purchase.GRAND_TOTAL + " ' ";
                    strSQL = strSQL + ",'" + purchase.VENDOR_ID + " ' ";
                    strSQL = strSQL + ",'" + purchase.DEPARTMENT_NAME + " ' ";
                    strSQL = strSQL + ",'" + purchase.BUSINESS_ID + " ' ";
                    strSQL = strSQL + ",'" + purchase.COMPANY_NAME + " ' ";
                    strSQL = strSQL + ")";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    int poId = 0;

                    strSQL = "SELECT ";
                    strSQL = strSQL + "PO_ID ";
                    strSQL = strSQL + "FROM TBL_PURCHASE_ORDER ";
                    strSQL = strSQL + "WHERE PO_NUMBER_LONG_CODE='" + purchase.PO_NUMBER_LONG_CODE + "' ";

                    command.CommandText = strSQL;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        poId = Convert.ToInt32(dr["PO_ID"].ToString());

                    }
                    dr.Close();
                    int itemId = 0;
                    string itemName;                    
                    int billtrnPosition = 1;

                    foreach (var acc_voucherItem in purchase.acc_VoucherItemList)
                    {
                        strChildKey = purchase.acc_com_VoucherModel.COMP_REF_NO + billtrnPosition.ToString().PadLeft(4, '0');
                        strSQL = "INSERT INTO ACC_VOUCHER_ITEM";
                        strSQL = strSQL + "(BILL_TRAN_KEY,BRANCH_ID,COMP_REF_NO,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,BILL_TRAN_POSITION,STOCKITEM_NAME,BILL_QUANTITY,BILL_RATE,BILL_UOM,GODOWNS_NAME,BILL_TRAN_TOBY";

                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + strChildKey + "'";
                        strSQL = strSQL + ",'" + acc_voucherItem.BRANCH_ID + "'";
                        strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "'";
                        strSQL = strSQL + ",'" + acc_voucherItem.COMP_VOUCHER_TYPE + "'";
                        strSQL = strSQL + ",'" + acc_voucherItem.COMP_VOUCHER_DATE + "' ";
                        strSQL = strSQL + ",'" + billtrnPosition + "' ";
                        strSQL = strSQL + ", '" + acc_voucherItem.STOCKITEM_NAME + "' ";
                        strSQL = strSQL + ",'" + acc_voucherItem.BILL_QUANTITY + "' ";
                        strSQL = strSQL + ",'" + acc_voucherItem.BILL_RATE + "' ";
                        strSQL = strSQL + ",'" + acc_voucherItem.BILL_UOM + "' ";
                        strSQL = strSQL + ",'" + acc_voucherItem.GODOWNS_NAME + "' ";
                        strSQL = strSQL + ",'" + "AB" + "' ";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();
                        billtrnPosition += 1;
                    }

                    foreach (var voucheritem in purchase.pOrderDetailsList)
                    {
                        strSQL = "SELECT ";
                        strSQL = strSQL + "ITEM_NAME,ITEM_ID ";
                        strSQL = strSQL + "FROM TBL_ITEM ";
                        strSQL = strSQL + "WHERE ITEM_NAME='" + voucheritem.ITEM_NAME + "' ";

                        command.CommandText = strSQL;
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            itemId = Convert.ToInt32(dr["ITEM_ID"].ToString());
                            itemName = dr["ITEM_NAME"].ToString();
                            voucheritem.ITEM_ID = itemId;
                        }
                        dr.Close();
                        if (itemId == 0)
                        {
                            string code = "";
                            try
                            {
                                strSQL = "SELECT RIGHT('0000'+CAST(NEXT VALUE FOR ITEM_CODE AS VARCHAR(4)),4) AS UNIC_ITEM_CODE";
                                command.CommandText = strSQL;
                                dr = command.ExecuteReader();
                                if (dr.Read())
                                {

                                    code = dr["UNIC_ITEM_CODE"].ToString();

                                }
                                dr.Close();
                            }
                            catch (Exception EX)
                            {

                            }


                            strSQL = "INSERT INTO TBL_ITEM";
                            strSQL = strSQL + "(ITEM_CODE,ITEM_NAME,BUSINESS_ID,UNIT_ID,SHORT_DESCRIPTION";

                            strSQL = strSQL + ") VALUES(";
                            strSQL = strSQL + "'" + code + "'";
                            strSQL = strSQL + ",'" + voucheritem.ITEM_NAME + "' ";
                            strSQL = strSQL + ",'" + 2 + "' ";
                            strSQL = strSQL + ",'" + voucheritem.UNIT_ID + "' ";
                            strSQL = strSQL + ",'" + voucheritem.SHORT_DESCRIPTION + "' ";
                            strSQL = strSQL + ")";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();

                            strSQL = "SELECT ";
                            strSQL = strSQL + "ITEM_NAME,ITEM_ID ";
                            strSQL = strSQL + "FROM TBL_ITEM ";
                            strSQL = strSQL + "WHERE ITEM_NAME='" + voucheritem.ITEM_NAME + "' ";

                            command.CommandText = strSQL;
                            dr = command.ExecuteReader();
                            if (dr.Read())
                            {
                                itemId = Convert.ToInt32(dr["ITEM_ID"].ToString());
                                itemName = dr["ITEM_NAME"].ToString();
                                voucheritem.ITEM_ID = itemId;
                            }
                            dr.Close();
                        }
                        else
                        {
                            strSQL = "UPDATE TBL_ITEM SET ";
                            strSQL = strSQL + " UNIT_ID='" + voucheritem.UNIT_ID + "',SHORT_DESCRIPTION='"+ voucheritem.SHORT_DESCRIPTION + "' WHERE ITEM_ID='" + voucheritem.ITEM_ID + "'";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();
                        }

                        //strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                        strSQL = "INSERT INTO TBL_PURCHASE_ORDER_DETAILS";
                        strSQL = strSQL + "(PO_ID,PO_NUMBER_LONG_CODE,ITEM_ID,QUANTITY,UNIT_PRICE,UNIT_TOTAL,VOUCHER_TYPE";

                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + poId + "'";
                        strSQL = strSQL + ",'" + purchase.PO_NUMBER_LONG_CODE + "'";
                        strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "' ";
                        strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                        strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                        strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                        strSQL = strSQL + ",'" + voucher_type + "' ";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();

                        //-----Insert Stock

                        strSQL = "INSERT INTO TBL_STOCK";
                        strSQL = strSQL + "(PO_NO,DOCUMENTS_NO";

                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + purchase.PO_NUMBER_LONG_CODE + "'";
                        strSQL = strSQL + ",'" + purchase.VOUCHER_NO + "'";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();

                        int stockId = 0;

                        strSQL = "SELECT ";
                        strSQL = strSQL + "STOCK_ID ";
                        strSQL = strSQL + "FROM TBL_STOCK ";
                        strSQL = strSQL + "WHERE PO_NO='" + purchase.PO_NUMBER_LONG_CODE + "' ";

                        command.CommandText = strSQL;
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            stockId = Convert.ToInt32(dr["STOCK_ID"].ToString());
                        }
                        dr.Close();

                        strSQL = "INSERT INTO TBL_STOCK_DETAILS";
                        strSQL = strSQL + "(STOCK_ID,ITEM_ID,STOCK_IN_QUANTITY,UNIT_PRICE,TOTAL_PRICE";

                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + stockId + "'";
                        strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "'";
                        strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                        strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                        strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();

                        double balance = 0;
                        double currentbalance = 0;
                        int stockItemId = 0;
                        strSQL = "SELECT ";
                        strSQL = strSQL + "ITEM_ID,BALANCE ";
                        strSQL = strSQL + "FROM TBL_STOCK_SUMMERY ";
                        strSQL = strSQL + "WHERE ITEM_ID='" + voucheritem.ITEM_ID + "' ";

                        command.CommandText = strSQL;
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            balance = Convert.ToDouble(dr["BALANCE"].ToString());
                            stockItemId = Convert.ToInt32(dr["ITEM_ID"].ToString());

                        }
                        dr.Close();

                        if (stockItemId != 0)
                        {
                            currentbalance = balance + voucheritem.QUANTITY;
                            double totalValue = currentbalance * voucheritem.UNIT_PRICE;
                            strSQL = "UPDATE TBL_STOCK_SUMMERY SET ";
                            strSQL = strSQL + " STOCK_IN_QUANTITY='" + voucheritem.QUANTITY + "',BALANCE='" + currentbalance + "'," +
                                    " UNIT_PRICE='" + voucheritem.UNIT_PRICE + "',TOTAL_VALUE='" + totalValue + "' WHERE ITEM_ID='" + voucheritem.ITEM_ID + "'";

                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();


                        }
                        else
                        {

                            currentbalance = voucheritem.QUANTITY;
                            strSQL = "INSERT INTO TBL_STOCK_SUMMERY";
                            strSQL = strSQL + "(ITEM_ID,STOCK_IN_QUANTITY,BALANCE,UNIT_PRICE,TOTAL_VALUE";
                            strSQL = strSQL + ") VALUES(";
                            strSQL = strSQL + " '" + voucheritem.ITEM_ID + "'";
                            strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                            strSQL = strSQL + ",'" + currentbalance + "' ";
                            strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                            strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                            strSQL = strSQL + ")";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();
                        }




                        itemId = 0;
                    }
                    transaction.Commit();
                }
                //payment.status = true;
            }
            catch (Exception EX)
            {
                payment.status = false;
                //payment.ErrorMessage = EX.Message;
                //return payment;
            }
            return payment;
        }
        //--------Stock Out
        internal DeliveryNoteMasterEntity CreateDeliveryNote(DeliveryNoteMasterEntity delivery)
        {
            bool flag = false;
            int vendorId = 0;
            string vendorName = "";
            DeliveryNoteMasterEntity Status = new DeliveryNoteMasterEntity();
            ItemEntity itemEntity = new ItemEntity();
            string voucher_type = "35";
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    SqlDataReader dr;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;



                    strSQL = "SELECT 'DN-'+RIGHT('00000000'+CAST(NEXT VALUE FOR DELIVERYNOTE_UNIC_NO AS VARCHAR(8)),8)";
                    command.CommandText = strSQL;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {

                        delivery.DELIVERY_NOTE_NO = dr.GetValue(0).ToString();

                    }
                    dr.Close();


                    strSQL = "INSERT INTO TBL_DELIVERY_MASTER(";
                    strSQL = strSQL + "DELIVERY_DATE,DELIVERY_TIME,WO_NUMBER,WORK_NAME,DELIVERY_NOTE_NO,DELIVERY_LOCATION,CUSTOMER_ID,CUSTOMER_PROJECT_ID,DELIVERY_PERSON,CARRING_BY,ITEM_CATEGORY,TOTAL_WEIGHT) ";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + delivery.DELIVERY_DATE + "' ";
                    strSQL = strSQL + ",'" + delivery.DELIVERY_TIME + "' ";
                    strSQL = strSQL + ",'" + delivery.WO_NUMBER + "' ";
                    strSQL = strSQL + ",'" + delivery.WORK_NAME + "' ";
                    strSQL = strSQL + ",'" + delivery.DELIVERY_NOTE_NO + "' ";
                    strSQL = strSQL + ",'" + delivery.DELIVERY_LOCATION + "' ";
                    strSQL = strSQL + ",'" + delivery.CUSTOMER_ID + "' ";                    
                    strSQL = strSQL + ",'" + delivery.CUSTOMER_PROJECT_ID + "' ";
                    strSQL = strSQL + ",'" + delivery.DELIVERY_PERSON + "' ";                    
                    strSQL = strSQL + ",'" + delivery.CARRING_BY + "' ";                    
                    strSQL = strSQL + ",'" + delivery.ITEM_CATEGORY + "' ";                    
                    strSQL = strSQL + ",'" + delivery.TOTAL_WEIGHT + "' ";                    
                    strSQL = strSQL + ")";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    int poId = 0;

                    strSQL = "SELECT ";
                    strSQL = strSQL + "DELIVERY_ID ";
                    strSQL = strSQL + "FROM TBL_DELIVERY_MASTER ";
                    strSQL = strSQL + "WHERE DELIVERY_NOTE_NO='" + delivery.DELIVERY_NOTE_NO + "' ";

                    command.CommandText = strSQL;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        poId = Convert.ToInt32(dr["DELIVERY_ID"].ToString());

                    }
                    dr.Close();
                    int itemId = 0;
                    string itemName;

                    foreach (var voucheritem in delivery.deliverlyDetailsList)
                    {

                        //strSQL = "INSERT INTO TBL_DELIVERY_DETAILS";
                        //strSQL = strSQL + "(ITEM_CODE,ITEM_NAME,QUANTITY,UNIT,DELIVERY_ID,DELIVERY_NOTE_NO";

                        //strSQL = strSQL + ") VALUES(";
                        //strSQL = strSQL + "'" + voucheritem.ITEM_CODE + "'";
                        //strSQL = strSQL + ",'" + voucheritem.ITEM_NAME + "'";
                        //strSQL = strSQL + ",'" + voucheritem.QUANTITY + "'";
                        //strSQL = strSQL + ",'" + voucheritem.UNIT + "' ";
                        //strSQL = strSQL + ",'" + poId + "' ";
                        //strSQL = strSQL + ",'" + delivery.DELIVERY_NOTE_NO + "' ";                        

                        //strSQL = strSQL + ")";

                        //------------------

                        



                        String query = "INSERT INTO TBL_DELIVERY_DETAILS (ITEM_CODE,ITEM_NAME,QUANTITY,UNIT,DELIVERY_ID,DELIVERY_NOTE_NO) VALUES (@ITEM_CODE,@ITEM_NAME,@QUANTITY, @UNIT,@DELIVERY_ID,@DELIVERY_NOTE_NO)";
                        //command = new SqlCommand(query, Global.ConnectionString);
                        //SqlCommand command = new SqlCommand(query, db.Connection);

                        command.Parameters.AddWithValue("@ITEM_CODE", voucheritem.ITEM_CODE);
                        command.Parameters.AddWithValue("@ITEM_NAME", voucheritem.ITEM_NAME);
                        command.Parameters.AddWithValue("@QUANTITY", voucheritem.QUANTITY);
                        command.Parameters.AddWithValue("@UNIT", voucheritem.UNIT);
                        command.Parameters.AddWithValue("@DELIVERY_ID", poId);
                        command.Parameters.AddWithValue("@DELIVERY_NOTE_NO", delivery.DELIVERY_NOTE_NO);
                        command.CommandText = query;
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();




                        //command.Parameters.Add("@ITEM_CODE",SqlDbType.VarChar);
                        ////SqlParameter param;
                        ////param = command.Parameters.Add("@ITEM_CODE", SqlDbType.VarChar, voucheritem.ITEM_CODE);
                        //SqlParameter param = new SqlParameter();
                        //param.ParameterName = "@ITEM_CODE";
                        //param.Value = voucheritem.ITEM_CODE;

                        //param.ParameterName = "@ITEM_NAME";
                        //param.Value = voucheritem.ITEM_NAME;

                        //param.ParameterName = "@QUANTITY";
                        //param.Value = voucheritem.QUANTITY;
                        //param.ParameterName = "@UNIT";
                        //param.Value = voucheritem.UNIT;
                        //param.ParameterName = "@DELIVERY_ID";
                        //param.Value = voucheritem.poId;

                        //// 3. add new parameter to command object
                        //command.Parameters.Add(param);

                        //// get data stream
                        ////reader = cmd.ExecuteReader();


                        ////command.CommandText = strSQL;
                        //command.ExecuteNonQuery();

                        //strSQL = "INSERT INTO TBL_PROJECT_WISE_STOCK";
                        //strSQL = strSQL + "(ITEM_CODE,ITEM_NAME,CUSTOMER_ID,CUSTOMER_PROJECT_ID,STOCK_QUANTITY,UNIT";

                        //strSQL = strSQL + ") VALUES(";
                        //strSQL = strSQL + "'" + voucheritem.ITEM_CODE + "'";
                        //strSQL = strSQL + ",'" + voucheritem.ITEM_NAME + "'";
                        //strSQL = strSQL + ",'" + delivery.CUSTOMER_ID + "'";
                        //strSQL = strSQL + ",'" + delivery.CUSTOMER_PROJECT_ID + "'";
                        //strSQL = strSQL + ",'" + voucheritem.QUANTITY + "'";
                        //strSQL = strSQL + ",'" + voucheritem.UNIT + "' ";
                        //strSQL = strSQL + ")";
                        query = "";
                        command.CommandText = "";
                        String ps_query = "INSERT INTO TBL_PROJECT_WISE_STOCK (ITEM_CODE,ITEM_NAME,CUSTOMER_ID,CUSTOMER_PROJECT_ID,STOCK_QUANTITY,UNIT) VALUES (@P_ITEM_CODE,@P_ITEM_NAME,@CUSTOMER_ID, @CUSTOMER_PROJECT_ID,@STOCK_QUANTITY,@P_UNIT)";
                        command.Parameters.AddWithValue("@P_ITEM_CODE", voucheritem.ITEM_CODE);
                        command.Parameters.AddWithValue("@P_ITEM_NAME", voucheritem.ITEM_NAME);
                        command.Parameters.AddWithValue("@CUSTOMER_ID", delivery.CUSTOMER_ID);
                        command.Parameters.AddWithValue("@CUSTOMER_PROJECT_ID", delivery.CUSTOMER_PROJECT_ID);
                        command.Parameters.AddWithValue("@STOCK_QUANTITY", voucheritem.QUANTITY);
                        command.Parameters.AddWithValue("@P_UNIT", voucheritem.UNIT);


                        command.CommandText = ps_query;
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();

                    }
                    transaction.Commit();
                }
                //payment.status = true;
            }
            catch (Exception EX)
            {
                //payment.status = false;
                //payment.ErrorMessage = EX.Message;
                //return payment;
            }
            return Status;
        }
        //--------

        internal PurchaseOrderModel UpdatePurchaseForProject(PurchaseOrderModel purchase)
        {
            bool flag = false;
            int vendorId = 0;
            string vendorName = "";
            PurchaseOrderModel payment = new PurchaseOrderModel();
            ItemEntity itemEntity = new ItemEntity();
            string voucher_type = "34";
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();



                    SqlTransaction transaction;
                    SqlDataReader dr;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    //---------Find Vendor
                    strSQL = "SELECT ";
                    strSQL = strSQL + "VENDOR_NAME,VENDOR_ID ";
                    strSQL = strSQL + "FROM TBL_VENDOR_REGISTRATION ";
                    strSQL = strSQL + "WHERE VENDOR_NAME='" + purchase.VENDOR_NAME + "' ";

                    command.CommandText = strSQL;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        vendorId = Convert.ToInt32(dr["VENDOR_ID"].ToString());
                        vendorName = dr["VENDOR_NAME"].ToString();
                        purchase.VENDOR_ID = vendorId;
                    }
                    dr.Close();
                    if (vendorId == 0)
                    {
                        string code = "";
                        try
                        {
                            strSQL = "SELECT 'V'+RIGHT('00000000'+CAST(NEXT VALUE FOR CUSTOMER_CODE AS VARCHAR(8)),8)";
                            command.CommandText = strSQL;
                            dr = command.ExecuteReader();
                            if (dr.Read())
                            {

                                code = dr.GetValue(0).ToString();

                            }
                            dr.Close();
                        }
                        catch (Exception EX)
                        {

                        }


                        strSQL = "INSERT INTO TBL_VENDOR_REGISTRATION";
                        strSQL = strSQL + "(VENDOR_CODE,VENDOR_NAME";

                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + code + "'";
                        strSQL = strSQL + ",'" + purchase.VENDOR_NAME + "' ";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();

                        strSQL = "SELECT ";
                        strSQL = strSQL + "VENDOR_NAME,VENDOR_ID ";
                        strSQL = strSQL + "FROM TBL_VENDOR_REGISTRATION ";
                        strSQL = strSQL + "WHERE VENDOR_NAME='" + purchase.VENDOR_NAME + "' ";

                        command.CommandText = strSQL;
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            vendorId = Convert.ToInt32(dr["VENDOR_ID"].ToString());
                            vendorName = dr["VENDOR_NAME"].ToString();
                            purchase.VENDOR_ID = vendorId;
                        }
                        dr.Close();
                    }
                    else
                    {
                        strSQL = "UPDATE TBL_VENDOR_REGISTRATION SET ";
                        strSQL = strSQL + " VENDOR_NAME='" + purchase.VENDOR_NAME + "' WHERE VENDOR_ID=" + purchase.VENDOR_ID + "";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();
                    }
                    //-----------



                    strSQL = "UPDATE TBL_PURCHASE_ORDER SET ";
                    strSQL = strSQL + " PO_DATE='" + purchase.PO_DATE + "',VENDOR_ID="+ purchase.VENDOR_ID+ ",CARRING_WAY_COST="+ purchase.CARRING_WAY_COST+ ",LABOUR_COST="+ purchase .LABOUR_COST+ ",OTHERS_COST="+ purchase.OTHERS_COST+ ",GRAND_TOTAL="+ purchase.GRAND_TOTAL+ " WHERE PO_ID=" + purchase.PO_ID + "";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    int itemId = 0;
                    string itemName;
                    foreach (var voucheritem in purchase.pOrderDetailsList)
                    {
                        if(voucheritem.PO_DETAILS_ID!=0)
                        {
                            strSQL = "UPDATE TBL_ITEM SET ";
                            strSQL = strSQL + " ITEM_NAME='" + voucheritem.ITEM_NAME + "' WHERE ITEM_ID=" + voucheritem.ITEM_ID + "";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();

                            strSQL = "UPDATE TBL_PURCHASE_ORDER_DETAILS SET ";
                            strSQL = strSQL + " QUANTITY='" + voucheritem.QUANTITY + "',UNIT_PRICE=" + voucheritem.UNIT_PRICE + ",UNIT_TOTAL=" + voucheritem.UNIT_TOTAL + " WHERE PO_DETAILS_ID=" + voucheritem.PO_DETAILS_ID + "";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            strSQL = "SELECT ";
                            strSQL = strSQL + "ITEM_NAME,ITEM_ID ";
                            strSQL = strSQL + "FROM TBL_ITEM ";
                            strSQL = strSQL + "WHERE ITEM_NAME='" + voucheritem.ITEM_NAME + "' ";

                            command.CommandText = strSQL;
                            dr = command.ExecuteReader();
                            if (dr.Read())
                            {
                                itemId = Convert.ToInt32(dr["ITEM_ID"].ToString());
                                itemName = dr["ITEM_NAME"].ToString();
                                voucheritem.ITEM_ID = itemId;
                            }
                            dr.Close();
                            if (itemId == 0)
                            {
                                string code = "";
                                try
                                {
                                    strSQL = "SELECT RIGHT('0000'+CAST(NEXT VALUE FOR ITEM_CODE AS VARCHAR(4)),4) AS UNIC_ITEM_CODE";
                                    command.CommandText = strSQL;
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {

                                        code = dr["UNIC_ITEM_CODE"].ToString();

                                    }
                                    dr.Close();
                                }
                                catch (Exception EX)
                                {

                                }


                                strSQL = "INSERT INTO TBL_ITEM";
                                strSQL = strSQL + "(ITEM_CODE,ITEM_NAME,BUSINESS_ID,UNIT_ID,SHORT_DESCRIPTION";

                                strSQL = strSQL + ") VALUES(";
                                strSQL = strSQL + "'" + code + "'";
                                strSQL = strSQL + ",'" + voucheritem.ITEM_NAME + "' ";
                                strSQL = strSQL + ",'" + 2 + "' ";
                                strSQL = strSQL + ",'" + voucheritem.UNIT_ID + "' ";
                                strSQL = strSQL + ",'" + voucheritem.SHORT_DESCRIPTION + "' ";
                                strSQL = strSQL + ")";
                                command.CommandText = strSQL;
                                command.ExecuteNonQuery();

                                strSQL = "SELECT ";
                                strSQL = strSQL + "ITEM_NAME,ITEM_ID ";
                                strSQL = strSQL + "FROM TBL_ITEM ";
                                strSQL = strSQL + "WHERE ITEM_NAME='" + voucheritem.ITEM_NAME + "' ";

                                command.CommandText = strSQL;
                                dr = command.ExecuteReader();
                                if (dr.Read())
                                {
                                    itemId = Convert.ToInt32(dr["ITEM_ID"].ToString());
                                    itemName = dr["ITEM_NAME"].ToString();
                                    voucheritem.ITEM_ID = itemId;
                                }
                                dr.Close();
                            }
                            else
                            {
                                strSQL = "UPDATE TBL_ITEM SET ";
                                strSQL = strSQL + " UNIT_ID='" + voucheritem.UNIT_ID + "',SHORT_DESCRIPTION='" + voucheritem.SHORT_DESCRIPTION + "' WHERE ITEM_ID='" + voucheritem.ITEM_ID + "'";
                                command.CommandText = strSQL;
                                command.ExecuteNonQuery();
                            }

                            //strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                            strSQL = "INSERT INTO TBL_PURCHASE_ORDER_DETAILS";
                            strSQL = strSQL + "(PO_ID,PO_NUMBER_LONG_CODE,ITEM_ID,QUANTITY,UNIT_PRICE,UNIT_TOTAL,VOUCHER_TYPE";

                            strSQL = strSQL + ") VALUES(";
                            strSQL = strSQL + "'" + purchase.PO_ID + "'";
                            strSQL = strSQL + ",'" + purchase.PO_NUMBER_LONG_CODE + "'";
                            strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "' ";
                            strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                            strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                            strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                            strSQL = strSQL + ",'" + voucher_type + "' ";
                            strSQL = strSQL + ")";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();
                        }
                        
                    }

                    





                    transaction.Commit();
                }
                //payment.status = true;
            }
            catch (Exception EX)
            {
                //payment.status = false;
                //payment.ErrorMessage = EX.Message;
                //return payment;
            }
            return payment;
        }
        public void DeletePurchaseItem(int id)
        {
            bool flag = false;
            int vendorId = 0;
            string vendorName = "";
            PurchaseOrderModel payment = new PurchaseOrderModel();
            ItemEntity itemEntity = new ItemEntity();
            string voucher_type = "34";
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();



                    SqlTransaction transaction;
                    SqlDataReader dr;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    strSQL = "Delete From TBL_PURCHASE_ORDER_DETAILS WHERE PO_DETAILS_ID=" + id + " ";
                    
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();


                    transaction.Commit();
                }
               
            }
            catch (Exception EX)
            {
                
            }
            
            
        }
        internal PurchaseOrderModel AddPurchase(PurchaseOrderModel purchase)
        {
            PurchaseOrderModel payment = new PurchaseOrderModel();
            using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlDataReader dr;
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        command.Transaction = transaction;
                        //strSQL = "INSERT INTO ACC_COMPANY_VOUCHER(";
                        //strSQL = strSQL + "COMP_REF_NO,BRANCH_ID,LEDGER_NAME,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,COMP_VOUCHER_MONTH_ID ";//COMP_VOUCHER_DUE_DATE,,AUTOJV
                        //strSQL = strSQL + ",COMP_VOUCHER_AMOUNT,COMP_VOUCHER_NET_AMOUNT,COMP_VOUCHER_NARRATION)";
                        //strSQL = strSQL + "VALUES(";
                        //strSQL = strSQL + "'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "' ";
                        //strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.BRANCH_ID + "' ";
                        //strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.LEDGER_NAME.Trim() + "' ";
                        //strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_TYPE + " ";
                        //strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_DATE.ToShortDateString() + "' ";
                        //strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_DATE.ToString("MMMyy").ToUpper() + " ' ";
                        //strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_AMOUNT + " ";
                        //strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_NET_AMOUNT + " ";
                        //strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_NARRATION + "' ";
                        //strSQL = strSQL + ")";
                        //command.CommandText = strSQL;
                        //command.ExecuteNonQuery();

                        //string strChildKey = "", strReverseLedger = "", strDebitLedger = "", strCreditLedger = "";
                        //int intloop = 1;
                        //if (purchase.acc_Voucher_Model
                        //    .Count > 2)
                        //{
                        //    strReverseLedger = "As Per Details";
                        //}
                        //else
                        //{
                        //    strReverseLedger = "";
                        //}
                        //foreach (var voucheritem in purchase.acc_Voucher_Model)
                        //{
                        //    strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                        //    strSQL = "INSERT INTO ACC_VOUCHER";
                        //    strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
                        //    strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
                        //    strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
                        //    strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,VOUCHER_CHEQUE_NUMBER,VOUCHER_CHEQUE_DATE,VOUCHER_CHEQUE_DRAWN_ON ";   //,TRANSFER_TYPE Not Found In Table
                        //    strSQL = strSQL + ") VALUES(";
                        //    strSQL = strSQL + "'" + voucheritem.COMP_REF_NO + "'";
                        //    strSQL = strSQL + ",'" + voucheritem.BRANCH_ID.Replace("'", "''") + "' ";
                        //    strSQL = strSQL + ",'" + strChildKey + "' ";
                        //    strSQL = strSQL + ", " + voucheritem.COMP_VOUCHER_TYPE + " ";
                        //    strSQL = strSQL + "," + intloop + "";
                        //    strSQL = strSQL + ",'" + voucheritem.COMP_VOUCHER_DATE.ToShortDateString() + "'";
                        //    strSQL = strSQL + ",'" + voucheritem.LEDGER_NAME.Replace("'", "''") + "' ";
                        //    if (voucheritem.VOUCHER_TOBY == "Dr")
                        //    {
                        //        strSQL = strSQL + "," + voucheritem.VOUCHER_DEBIT_AMOUNT + " ";
                        //        strSQL = strSQL + ",0 ";
                        //        strSQL = strSQL + ",'Dr'";
                        //        if (strReverseLedger != "")
                        //        {
                        //            strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //        }
                        //        else
                        //        {
                        //            strReverseLedger = purchase.acc_Voucher_Model.Find(x => x.VOUCHER_TOBY == "Dr").LEDGER_NAME;
                        //            strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //        }
                        //    }
                        //    else if (voucheritem.VOUCHER_TOBY == "Cr")
                        //    {
                        //        strSQL = strSQL + ",0 ";
                        //        strSQL = strSQL + "," + voucheritem.VOUCHER_CREDIT_AMOUNT + " ";
                        //        strSQL = strSQL + ",'Cr'";
                        //        if (strReverseLedger != "")
                        //        {
                        //            strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //        }
                        //        else
                        //        {
                        //            strReverseLedger = purchase.acc_Voucher_Model.Find(x => x.VOUCHER_TOBY == "Cr").LEDGER_NAME;
                        //            strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //        }
                        //    }
                        //    strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_NUMBER + "'";
                        //    strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_DATE.Year + "-" + voucheritem.VOUCHER_CHEQUE_DATE.Month + "-" + voucheritem.VOUCHER_CHEQUE_DATE.Day + "'";

                        //    strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_DRAWN_ON + "'";
                        //    strSQL = strSQL + ")";
                        //    command.CommandText = strSQL;
                        //    command.ExecuteNonQuery();
                        //    intloop += 1;
                        //}


                        //-----------
                        strSQL = "INSERT INTO TBL_PURCHASE_ORDER(";
                        strSQL = strSQL + "PO_NUMBER,VOUCHER_TYPE,PO_DATE,VENDOR_ID,SHIPPING_ADDRESS,DELIVERY_MODE,DELIVERY_TIME,TERMS_CONDITION,SUB_TOTAL,TAX_RATE,TAX_AMOUNT,VAT_RATE,VAT_AMOUNT,DISCOUNT_RATE,DISCOUNT_AMOUNT,ADVANCE,GRAND_TOTAL,REG_BY) ";
                        
                        strSQL = strSQL + "VALUES(";
                        strSQL = strSQL + "'" + purchase.PO_NUMBER + "' ";
                        strSQL = strSQL + ",'" + purchase.VOUCHER_TYPE + "' ";
                        strSQL = strSQL + ",'" + purchase.PO_DATE + "' ";
                        strSQL = strSQL + "," + purchase.VENDOR_ID + " ";
                        strSQL = strSQL + ",'" + purchase.SHIPPING_ADDRESS + "' ";
                        strSQL = strSQL + ",'" + purchase.DELIVERY_MODE + "' ";
                        strSQL = strSQL + ",'" + purchase.DELIVERY_TIME + "' ";
                        strSQL = strSQL + ",'" + purchase.TERMS_CONDITION + "' ";
                        strSQL = strSQL + ",'" + purchase.SUB_TOTAL + "' ";
                        strSQL = strSQL + ",'" + purchase.TAX_RATE + "' ";                        
                        strSQL = strSQL + "," + purchase.TAX_AMOUNT + " ";
                        strSQL = strSQL + ",'" + purchase.VAT_RATE + "' ";
                        strSQL = strSQL + ",'" + purchase.VAT_AMOUNT + " ' ";
                        strSQL = strSQL + ",'" + purchase.DISCOUNT_RATE + " ' ";
                        strSQL = strSQL + ",'" + purchase.DISCOUNT_AMOUNT + " ' ";
                        strSQL = strSQL + ",'" + purchase.ADVANCE + " ' ";
                        strSQL = strSQL + ",'" + purchase.GRAND_TOTAL + " ' ";
                        strSQL = strSQL + ",'" + purchase.REG_BY + " ' ";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();

                        int poId = 0;

                        strSQL = "SELECT ";
                        strSQL = strSQL + "PO_ID ";
                        strSQL = strSQL + "FROM TBL_PURCHASE_ORDER ";
                        strSQL = strSQL + "WHERE PO_NUMBER='" + purchase.PO_NUMBER + "' ";

                        command.CommandText = strSQL;
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            poId = Convert.ToInt32(dr["PO_ID"].ToString());

                        }
                        dr.Close();
                        int itemId = 0;
                        string itemName;
                        int billtrnPosition = 1;

                        //foreach (var acc_voucherItem in purchase.acc_VoucherItemList)
                        //{
                        //    strSQL = "INSERT INTO ACC_VOUCHER_ITEM";
                        //    strSQL = strSQL + "(BILL_TRAN_KEY,BRANCH_ID,COMP_REF_NO,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,BILL_TRAN_POSITION,STOCKITEM_NAME,BILL_QUANTITY,BILL_RATE,BILL_UOM,GODOWNS_NAME,BILL_TRAN_TOBY";

                        //    strSQL = strSQL + ") VALUES(";
                        //    strSQL = strSQL + "'" + strChildKey + "'";
                        //    strSQL = strSQL + ",'" + acc_voucherItem.BRANCH_ID + "'";
                        //    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "'";
                        //    strSQL = strSQL + ",'" + acc_voucherItem.COMP_VOUCHER_TYPE + "'";
                        //    strSQL = strSQL + ",'" + acc_voucherItem.COMP_VOUCHER_DATE + "' ";
                        //    strSQL = strSQL + ",'" + billtrnPosition + "' ";
                        //    strSQL = strSQL + ", '" + acc_voucherItem.STOCKITEM_NAME + "' ";
                        //    strSQL = strSQL + ",'" + acc_voucherItem.BILL_QUANTITY + "' ";
                        //    strSQL = strSQL + ",'" + acc_voucherItem.BILL_RATE + "' ";
                        //    strSQL = strSQL + ",'" + acc_voucherItem.BILL_UOM + "' ";
                        //    strSQL = strSQL + ",'" + acc_voucherItem.GODOWNS_NAME + "' ";
                        //    strSQL = strSQL + ",'" + "AB" + "' ";
                        //    strSQL = strSQL + ")";
                        //    command.CommandText = strSQL;
                        //    command.ExecuteNonQuery();
                        //    billtrnPosition += 1;
                        //}

                        foreach (var voucheritem in purchase.pOrderDetailsList)
                        {
                            //strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                            strSQL = "INSERT INTO TBL_PURCHASE_ORDER_DETAILS";
                            strSQL = strSQL + "(PO_ID,PO_NUMBER,ITEM_ID,ITEM_CODE,ITEM_NAME,QUANTITY,UNIT_PRICE,UNIT_TOTAL,UOM";

                            strSQL = strSQL + ") VALUES(";
                            strSQL = strSQL + "'" + poId + "'";
                            strSQL = strSQL + ",'" + purchase.PO_NUMBER + "'";
                            //strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "'";
                            //strSQL = strSQL + ",'" + strChildKey + "'";
                            strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "' ";
                            strSQL = strSQL + ",'" + voucheritem.ITEM_CODE + "' ";
                            strSQL = strSQL + ",'" + voucheritem.ITEM_NAME + "' ";
                            strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                            strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                            strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                            strSQL = strSQL + ",'" + voucheritem.UOM + "' ";
                            strSQL = strSQL + ")";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();

                            //-----Insert Stock

                            //strSQL = "INSERT INTO TBL_STOCK";
                            //strSQL = strSQL + "(PO_NO,DOCUMENTS_NO";

                            //strSQL = strSQL + ") VALUES(";
                            //strSQL = strSQL + "'" + purchase.PO_NUMBER_LONG_CODE + "'";
                            //strSQL = strSQL + ",'" + purchase.VOUCHER_NO + "'";
                            //strSQL = strSQL + ")";
                            //command.CommandText = strSQL;
                            //command.ExecuteNonQuery();

                            //int stockId = 0;

                            //strSQL = "SELECT ";
                            //strSQL = strSQL + "STOCK_ID ";
                            //strSQL = strSQL + "FROM TBL_STOCK ";
                            //strSQL = strSQL + "WHERE PO_NO='" + purchase.PO_NUMBER_LONG_CODE + "' ";

                            //command.CommandText = strSQL;
                            //dr = command.ExecuteReader();
                            //if (dr.Read())
                            //{
                            //    stockId = Convert.ToInt32(dr["STOCK_ID"].ToString());
                            //}
                            //dr.Close();

                            //strSQL = "INSERT INTO TBL_STOCK_DETAILS";
                            //strSQL = strSQL + "(STOCK_ID,ITEM_ID,STOCK_IN_QUANTITY,UNIT_PRICE,TOTAL_PRICE";

                            //strSQL = strSQL + ") VALUES(";
                            //strSQL = strSQL + "'" + stockId + "'";
                            //strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "'";
                            //strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                            //strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                            //strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                            //strSQL = strSQL + ")";
                            //command.CommandText = strSQL;
                            //command.ExecuteNonQuery();

                            //double balance = 0;
                            //double currentbalance = 0;
                            //int stockItemId = 0;
                            //strSQL = "SELECT ";
                            //strSQL = strSQL + "ITEM_ID,BALANCE ";
                            //strSQL = strSQL + "FROM TBL_STOCK_SUMMERY ";
                            //strSQL = strSQL + "WHERE ITEM_ID='" + voucheritem.ITEM_ID + "' ";

                            //command.CommandText = strSQL;
                            //dr = command.ExecuteReader();
                            //if (dr.Read())
                            //{
                            //    balance = Convert.ToDouble(dr["BALANCE"].ToString());
                            //    stockItemId = Convert.ToInt32(dr["ITEM_ID"].ToString());

                            //}
                            //dr.Close();

                            //if (stockItemId != 0)
                            //{
                            //    currentbalance = balance + voucheritem.QUANTITY;
                            //    double totalValue = currentbalance * voucheritem.UNIT_PRICE;
                            //    strSQL = "UPDATE TBL_STOCK_SUMMERY SET ";
                            //    strSQL = strSQL + " STOCK_IN_QUANTITY='" + voucheritem.QUANTITY + "',BALANCE='" + currentbalance + "'," +
                            //            " UNIT_PRICE='" + voucheritem.UNIT_PRICE + "',TOTAL_VALUE='" + totalValue + "' WHERE ITEM_ID='" + voucheritem.ITEM_ID + "'";

                            //    command.CommandText = strSQL;
                            //    command.ExecuteNonQuery();


                            //}
                            //else
                            //{

                            //    currentbalance = voucheritem.QUANTITY;
                            //    strSQL = "INSERT INTO TBL_STOCK_SUMMERY";
                            //    strSQL = strSQL + "(ITEM_ID,STOCK_IN_QUANTITY,BALANCE,UNIT_PRICE,TOTAL_VALUE";
                            //    strSQL = strSQL + ") VALUES(";
                            //    strSQL = strSQL + " '" + voucheritem.ITEM_ID + "'";
                            //    strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                            //    strSQL = strSQL + ",'" + currentbalance + "' ";
                            //    strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                            //    strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                            //    strSQL = strSQL + ")";
                            //    command.CommandText = strSQL;
                            //    command.ExecuteNonQuery();
                            //}




                            itemId = 0;
                        }

                        //---------

                        //command = new SqlCommand("SP_PURCHASE_INSERT_PURCHASE_ORDER", connection);
                        //command.CommandType = CommandType.StoredProcedure;


                        //command.Parameters.AddWithValue("@PO_ID", purchase.PO_ID);
                        //command.Parameters.AddWithValue("@PO_NUMBER_LONG_CODE", purchase.PO_NUMBER_LONG_CODE);
                        //command.Parameters.AddWithValue("@REQUISITION_NO", purchase.REQUISITION_NO);
                        //command.Parameters.AddWithValue("@PO_DATE", purchase.PO_DATE);
                        //command.Parameters.AddWithValue("@QUOTATION_REFERANCE_NO", purchase.QUOTATION_REFERANCE_NO);
                        //command.Parameters.AddWithValue("@QUOTATION_REFERANCE_DATE", purchase.QUOTATION_REFERANCE_DATE);
                        //command.Parameters.AddWithValue("@TRUNSECTION_TYPE", purchase.TRUNSECTION_TYPE);
                        //command.Parameters.AddWithValue("@VENDOR_ID", purchase.VENDOR_ID);
                        //command.Parameters.AddWithValue("@CONSIGNEE_ID", purchase.CONSIGNEE_ID);
                        //command.Parameters.AddWithValue("@TERMS_OF_DELIVERY", purchase.TERMS_OF_DELIVERY);
                        //command.Parameters.AddWithValue("@SHIPPING_ADDRESS", purchase.SHIPPING_ADDRESS);
                        //command.Parameters.AddWithValue("@DELIVERY_MODE", purchase.DELIVERY_MODE);
                        //command.Parameters.AddWithValue("@PAYMENT_TERM", purchase.PAYMENT_TERM);
                        //command.Parameters.AddWithValue("@PAYMENT_MODE", purchase.PAYMENT_MODE);
                        //command.Parameters.AddWithValue("@INCOTERM", purchase.INCOTERM);
                        //command.Parameters.AddWithValue("@CURRENCY", purchase.CURRENCY_NAME);
                        //command.Parameters.AddWithValue("@SHIP_VIA", purchase.SHIP_VIA);
                        //command.Parameters.AddWithValue("@CONTAINER_SIZE", purchase.CONTAINER_SIZE);
                        //command.Parameters.AddWithValue("@DELIVERY_TIME", purchase.DELIVERY_TIME);
                        //command.Parameters.AddWithValue("@COUNTRY_OF_ORIGIN", purchase.COUNTRY_OF_ORIGIN);
                        //command.Parameters.AddWithValue("@IMPORT_FROM", purchase.IMPORT_FROM);
                        //command.Parameters.AddWithValue("@PORT_OF_LOADING", purchase.PORT_OF_LOADING);
                        //command.Parameters.AddWithValue("@PORT_OF_DISCHARGE", purchase.PORT_OF_DISCHARGE);
                        ////parameters.Add("@LABEL", purchase.LABEL);
                        ////parameters.Add("@SHELF_LIFE", purchase.SHELF_LIFE);
                        //command.Parameters.AddWithValue("@CARRING_WAY_NAME", purchase.CARRING_WAY_NAME);
                        //command.Parameters.AddWithValue("@CARRING_WAY_COST", purchase.CARRING_WAY_COST);
                        //command.Parameters.AddWithValue("@GRAND_TOTAL", purchase.GRAND_TOTAL);
                        //command.Parameters.AddWithValue("@SHIPPING_MARK", purchase.SHIPPING_MARK);
                        //command.Parameters.AddWithValue("@PACKAGING", purchase.PACKAGING);
                        //command.Parameters.AddWithValue("@IDENTIFICATION_NUMBER", purchase.IDENTIFICATION_NUMBER);
                        //command.Parameters.AddWithValue("@ETD_1st_Date", purchase.ETD_1st_Date);
                        //command.Parameters.AddWithValue("@ETD_2nd_Date", purchase.ETD_2nd_Date);
                        //command.Parameters.AddWithValue("@ETD_3rd_Date", purchase.ETD_3rd_Date);
                        //command.Parameters.AddWithValue("@ETD_4th_Date", purchase.ETD_4th_Date);
                        //command.Parameters.AddWithValue("@ETA_1st_Date", purchase.ETA_1st_Date);
                        //command.Parameters.AddWithValue("@ETA_2nd_Date", purchase.ETA_2nd_Date);
                        //command.Parameters.AddWithValue("@ETA_3rd_Date", purchase.ETA_3rd_Date);
                        //command.Parameters.AddWithValue("@ETA_4th_Date", purchase.ETA_4th_Date);
                        //command.Parameters.AddWithValue("@EA_WH_1st_Date", purchase.EA_WH_1st_Date);
                        //command.Parameters.AddWithValue("@EA_WH_2nd_Date", purchase.EA_WH_2nd_Date);
                        //command.Parameters.AddWithValue("@EA_WH_3rd_Date", purchase.EA_WH_3rd_Date);
                        //command.Parameters.AddWithValue("@EA_WH_4th_Date", purchase.EA_WH_4th_Date);
                        //command.Parameters.AddWithValue("@RECEIVED_DATE", purchase.RECEIVED_DATE);
                        //command.Parameters.AddWithValue("@SHIPMENT_STATUS", purchase.SHIPMENT_STATUS);



                        ////parameters.Add("@REQUESTED_BY", purchase.QUOTATION_REFERANCE_NO);
                        ////parameters.Add("@DEPARTMENT_ID", purchase.QUOTATION_REFERANCE_DATE);
                        ////parameters.Add("@REQUEST_DATE", purchase.VENDOR_ID);
                        ////parameters.Add("@REQUIRED_DATE", purchase.CONSIGNEE_ID);
                        ////parameters.Add("@REQUEST_FOR", purchase.TERMS_OF_DELIVERY);
                        ////parameters.Add("@PRIORITY", purchase.SHIPPING_ADDRESS);
                        ////parameters.Add("@REQUISITION_PURPOSE", purchase.DELIVERY_MODE);
                        ////parameters.Add("@REQUISITION_TOTAL", purchase.PAYMENT_TERM);
                        ////parameters.Add("@STATUS", purchase.PAYMENT_MODE);
                        //command.Parameters.AddWithValue("@REG_BY", purchase.REG_BY);
                        //command.Parameters.AddWithValue("@BILL_NO", purchase.BILL_NO);
                        //command.Parameters.AddWithValue("@BIN", purchase.BIN);
                        //command.Parameters.AddWithValue("@TIN", purchase.TIN);
                        //command.Parameters.AddWithValue("@EMAIL", purchase.EMAIL);
                        //command.Parameters.AddWithValue("@MOBILE", purchase.MOBILE);
                        //command.Parameters.AddWithValue("@PACKAGING_INSTRUCTION", purchase.PACKAGING_INSTRUCTION);
                        //command.Parameters.AddWithValue("@OTHER_TERMS_AND_CONDITION", purchase.OTHER_TERMS_AND_CONDITION);
                        //---------

                        //command.Transaction = transaction;

                        //command.ExecuteNonQuery();


                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {

                    }

                }

            }
            return payment;
        }
        internal PurchaseOrderModel AddPurchaseOrder(PurchaseOrderModel purchase)
        {
            bool flag = false;
            int vendorId = 0;
            string vendorName = "";
            PurchaseOrderModel payment = new PurchaseOrderModel();
            ItemEntity itemEntity = new ItemEntity();
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    SqlDataReader dr;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    strSQL = "INSERT INTO ACC_COMPANY_VOUCHER(";
                    strSQL = strSQL + "COMP_REF_NO,BRANCH_ID,LEDGER_NAME,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,COMP_VOUCHER_MONTH_ID ";//COMP_VOUCHER_DUE_DATE,,AUTOJV
                    strSQL = strSQL + ",COMP_VOUCHER_AMOUNT,COMP_VOUCHER_NET_AMOUNT,COMP_VOUCHER_NARRATION)";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "' ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.BRANCH_ID + "' ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.LEDGER_NAME + "' ";
                    strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_TYPE + " ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_DATE.ToShortDateString() + "' ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_DATE.ToString("MMMyy").ToUpper() + " ' ";
                    strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_AMOUNT + " ";
                    strSQL = strSQL + "," + purchase.acc_com_VoucherModel.COMP_VOUCHER_NET_AMOUNT + " ";
                    strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_VOUCHER_NARRATION + "' ";
                    strSQL = strSQL + ")";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();



                    string strChildKey = "", strReverseLedger = "", strDebitLedger = "", strCreditLedger = "";
                    int intloop = 1;
                    if (purchase.acc_Voucher_Model
                        .Count > 2)
                    {
                        strReverseLedger = "As Per Details";
                    }
                    else
                    {
                        strReverseLedger = "";
                    }
                    foreach (var voucheritem in purchase.acc_Voucher_Model)
                    {
                        strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                        strSQL = "INSERT INTO ACC_VOUCHER";
                        strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
                        strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
                        strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
                        strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,VOUCHER_CHEQUE_NUMBER,VOUCHER_CHEQUE_DATE,VOUCHER_CHEQUE_DRAWN_ON ";   //,TRANSFER_TYPE Not Found In Table
                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + voucheritem.COMP_REF_NO + "'";
                        strSQL = strSQL + ",'" + voucheritem.BRANCH_ID.Replace("'", "''") + "' ";
                        strSQL = strSQL + ",'" + strChildKey + "' ";
                        strSQL = strSQL + ", " + voucheritem.COMP_VOUCHER_TYPE + " ";
                        strSQL = strSQL + "," + intloop + "";
                        strSQL = strSQL + ",'" + voucheritem.COMP_VOUCHER_DATE.ToShortDateString() + "'";
                        strSQL = strSQL + ",'" + voucheritem.LEDGER_NAME.Replace("'", "''") + "' ";
                        if (voucheritem.VOUCHER_TOBY == "Dr")
                        {
                            strSQL = strSQL + "," + voucheritem.VOUCHER_DEBIT_AMOUNT + " ";
                            strSQL = strSQL + ",0 ";
                            strSQL = strSQL + ",'Dr'";
                            if (strReverseLedger != "")
                            {
                                strSQL = strSQL + ",'" + strReverseLedger + "' ";
                            }
                            else
                            {
                                strReverseLedger = purchase.acc_Voucher_Model.Find(x => x.VOUCHER_TOBY == "Dr").LEDGER_NAME;
                                strSQL = strSQL + ",'" + strReverseLedger + "' ";
                            }
                        }
                        else if (voucheritem.VOUCHER_TOBY == "Cr")
                        {
                            strSQL = strSQL + ",0 ";
                            strSQL = strSQL + "," + voucheritem.VOUCHER_CREDIT_AMOUNT + " ";
                            strSQL = strSQL + ",'Cr'";
                            if (strReverseLedger != "")
                            {
                                strSQL = strSQL + ",'" + strReverseLedger + "' ";
                            }
                            else
                            {
                                strReverseLedger = purchase.acc_Voucher_Model.Find(x => x.VOUCHER_TOBY == "Cr").LEDGER_NAME;
                                strSQL = strSQL + ",'" + strReverseLedger + "' ";
                            }
                        }
                        strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_NUMBER + "'";
                        strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_DATE.Year + "-" + voucheritem.VOUCHER_CHEQUE_DATE.Month + "-" + voucheritem.VOUCHER_CHEQUE_DATE.Day + "'";

                        strSQL = strSQL + ",'" + voucheritem.VOUCHER_CHEQUE_DRAWN_ON + "'";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();
                        intloop += 1;
                    }

                    //-----------
                    //command = new SqlCommand("sp1", con);
                    //strSQL = "INSERT INTO TBL_PURCHASE_ORDER(";
                    //strSQL = strSQL + "PO_NUMBER_LONG_CODE,VOUCHER_NO,PO_DATE,CARRING_WAY_COST,LABOUR_COST,OTHERS_COST,GRAND_TOTAL,VENDOR_ID,DEPARTMENT_NAME,BUSINESS_ID) ";
                    //strSQL = strSQL + "PO_NUMBER_LONG_CODE,REQUISITION_NO,PO_DATE,QUOTATION_REFERANCE_NO,QUOTATION_REFERANCE_DATE"+
                    //strSQL = strSQL + ",TRUNSECTION_TYPE,VENDOR_ID,CONSIGNEE_ID,TERMS_OF_DELIVERY,SHIPPING_ADDRESS,DELIVERY_MODE"+
                    //strSQL = strSQL + ",PAYMENT_TERM,PAYMENT_MODE,INCOTERM,CURRENCY,SHIP_VIA,CONTAINER_SIZE
                    //   ,DELIVERY_TIME
                    //   ,COUNTRY_OF_ORIGIN
                    //,IMPORT_FROM
                    //   ,PORT_OF_LOADING
                    //   ,PORT_OF_DISCHARGE
                    //   --,LABEL
                    //   --,SHELF_LIFE
                    //   ,CARRING_WAY_NAME
                    //   ,CARRING_WAY_COST
                    //   ,GRAND_TOTAL
                    //   ,SHIPPING_MARK
                    //   ,PACKAGING
                    //   ,IDENTIFICATION_NUMBER

                    //   ,ETD_1st_Date
                    //   ,ETD_2nd_Date
                    //   ,ETD_3rd_Date
                    //   ,ETD_4th_Date
                    //   ,ETA_1st_Date
                    //   ,ETA_2nd_Date
                    //   ,ETA_3rd_Date
                    //   ,ETA_4th_Date
                    //   ,EA_WH_1st_Date
                    //   ,EA_WH_2nd_Date
                    //   ,EA_WH_3rd_Date
                    //   ,EA_WH_4th_Date
                    //   ,RECEIVED_DATE
                    //   ,SHIPMENT_STATUS
                    //   ,REG_BY
                    //,BILL_NO
                    //,BIN
                    //,TIN
                    //,EMAIL
                    //,MOBILE
                    //,PACKAGING_INSTRUCTION
                    //,OTHER_TERMS_AND_CONDITION
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + purchase.PO_NUMBER_LONG_CODE + "' ";
                    strSQL = strSQL + ",'" + purchase.VOUCHER_NO + "' ";
                    strSQL = strSQL + ",'" + purchase.PO_DATE + "' ";
                    strSQL = strSQL + ",'" + purchase.CARRING_WAY_COST + "' ";
                    strSQL = strSQL + "," + purchase.LABOUR_COST + " ";
                    strSQL = strSQL + ",'" + purchase.OTHERS_COST + "' ";
                    strSQL = strSQL + ",'" + purchase.GRAND_TOTAL + " ' ";
                    strSQL = strSQL + ",'" + purchase.VENDOR_ID + " ' ";
                    strSQL = strSQL + ",'" + purchase.DEPARTMENT_NAME + " ' ";
                    strSQL = strSQL + ",'" + purchase.BUSINESS_ID + " ' ";
                    strSQL = strSQL + ")";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    int poId = 0;

                    strSQL = "SELECT ";
                    strSQL = strSQL + "PO_ID ";
                    strSQL = strSQL + "FROM TBL_PURCHASE_ORDER ";
                    strSQL = strSQL + "WHERE PO_NUMBER_LONG_CODE='" + purchase.PO_NUMBER_LONG_CODE + "' ";

                    command.CommandText = strSQL;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        poId = Convert.ToInt32(dr["PO_ID"].ToString());

                    }
                    dr.Close();
                    int itemId = 0;
                    string itemName;

                    foreach (var voucheritem in purchase.pOrderDetailsList)
                    {
                        //strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                        strSQL = "INSERT INTO TBL_PURCHASE_ORDER_DETAILS";
                        strSQL = strSQL + "(PO_ID,PO_NUMBER_LONG_CODE,ITEM_ID,QUANTITY,UNIT_PRICE,UNIT_TOTAL";

                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + poId + "'";
                        strSQL = strSQL + ",'" + purchase.PO_NUMBER_LONG_CODE + "'";
                        strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "' ";
                        strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                        strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                        strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();

                        //-----Insert Stock

                        //strSQL = "INSERT INTO TBL_STOCK";
                        //strSQL = strSQL + "(PO_NO,DOCUMENTS_NO";

                        //strSQL = strSQL + ") VALUES(";
                        //strSQL = strSQL + "'" + purchase.PO_NUMBER_LONG_CODE + "'";
                        //strSQL = strSQL + ",'" + purchase.VOUCHER_NO + "'";
                        //strSQL = strSQL + ")";
                        //command.CommandText = strSQL;
                        //command.ExecuteNonQuery();

                        //int stockId = 0;

                        //strSQL = "SELECT ";
                        //strSQL = strSQL + "STOCK_ID ";
                        //strSQL = strSQL + "FROM TBL_STOCK ";
                        //strSQL = strSQL + "WHERE PO_NO='" + purchase.PO_NUMBER_LONG_CODE + "' ";

                        //command.CommandText = strSQL;
                        //dr = command.ExecuteReader();
                        //if (dr.Read())
                        //{
                        //    stockId = Convert.ToInt32(dr["STOCK_ID"].ToString());
                        //}
                        //dr.Close();

                        //strSQL = "INSERT INTO TBL_STOCK_DETAILS";
                        //strSQL = strSQL + "(STOCK_ID,ITEM_ID,STOCK_IN_QUANTITY,UNIT_PRICE,TOTAL_PRICE";

                        //strSQL = strSQL + ") VALUES(";
                        //strSQL = strSQL + "'" + stockId + "'";
                        //strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "'";
                        //strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                        //strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                        //strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                        //strSQL = strSQL + ")";
                        //command.CommandText = strSQL;
                        //command.ExecuteNonQuery();

                        //double balance = 0;
                        //double currentbalance = 0;
                        //int stockItemId = 0;
                        //strSQL = "SELECT ";
                        //strSQL = strSQL + "ITEM_ID,BALANCE ";
                        //strSQL = strSQL + "FROM TBL_STOCK_SUMMERY ";
                        //strSQL = strSQL + "WHERE ITEM_ID='" + voucheritem.ITEM_ID + "' ";

                        //command.CommandText = strSQL;
                        //dr = command.ExecuteReader();
                        //if (dr.Read())
                        //{
                        //    balance = Convert.ToDouble(dr["BALANCE"].ToString());
                        //    stockItemId = Convert.ToInt32(dr["ITEM_ID"].ToString());

                        //}
                        //dr.Close();

                        //if (stockItemId != 0)
                        //{
                        //    currentbalance = balance + voucheritem.QUANTITY;
                        //    double totalValue = currentbalance * voucheritem.UNIT_PRICE;
                        //    strSQL = "UPDATE TBL_STOCK_SUMMERY SET ";
                        //    strSQL = strSQL + " STOCK_IN_QUANTITY='" + voucheritem.QUANTITY + "',BALANCE='" + currentbalance + "'," +
                        //            " UNIT_PRICE='" + voucheritem.UNIT_PRICE + "',TOTAL_VALUE='" + totalValue + "' WHERE ITEM_ID='" + voucheritem.ITEM_ID + "'";

                        //    command.CommandText = strSQL;
                        //    command.ExecuteNonQuery();


                        //}
                        //else
                        //{

                        //    currentbalance = voucheritem.QUANTITY;
                        //    strSQL = "INSERT INTO TBL_STOCK_SUMMERY";
                        //    strSQL = strSQL + "(ITEM_ID,STOCK_IN_QUANTITY,BALANCE,UNIT_PRICE,TOTAL_VALUE";
                        //    strSQL = strSQL + ") VALUES(";
                        //    strSQL = strSQL + " '" + voucheritem.ITEM_ID + "'";
                        //    strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                        //    strSQL = strSQL + ",'" + currentbalance + "' ";
                        //    strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                        //    strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                        //    strSQL = strSQL + ")";
                        //    command.CommandText = strSQL;
                        //    command.ExecuteNonQuery();
                        //}




                        itemId = 0;
                    }
                    transaction.Commit();
                }
                //payment.status = true;
            }
            catch (Exception EX)
            {
                //payment.status = false;
                //payment.ErrorMessage = EX.Message;
                //return payment;
            }
            return payment;
        }
        public PurchaseOrderModel AddPurchaseOrder_bkp(PurchaseOrderModel purchaseOrder)
        {
            _opurchaseOrder = new PurchaseOrderModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<PurchaseOrderModel>("SP_PURCHASE_INSERT_PURCHASE_ORDER",
                        this.SetParametersForPurchaseOrder(purchaseOrder), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return _opurchaseOrder;
        }
        public PurchaseOrderModel EditPurchaseOrder(PurchaseOrderModel purchaseOrder)
        {
            _opurchaseOrder = new PurchaseOrderModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<PurchaseOrderModel>("SP_PURCHASE_UPDATE_PURCHASE_ORDER",
                        this.SetParametersForPurchaseOrder(purchaseOrder), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return _opurchaseOrder;
        }
        public DynamicParameters SetParametersForPurchaseOrder(PurchaseOrderModel purchaseOrder)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PO_ID", purchaseOrder.PO_ID);
            parameters.Add("@PO_NUMBER_LONG_CODE", purchaseOrder.PO_NUMBER_LONG_CODE);
            parameters.Add("@REQUISITION_NO", purchaseOrder.REQUISITION_NO);
            parameters.Add("@PO_DATE", purchaseOrder.PO_DATE);
            parameters.Add("@QUOTATION_REFERANCE_NO", purchaseOrder.QUOTATION_REFERANCE_NO);
            parameters.Add("@QUOTATION_REFERANCE_DATE", purchaseOrder.QUOTATION_REFERANCE_DATE);
            parameters.Add("@TRUNSECTION_TYPE", purchaseOrder.TRUNSECTION_TYPE);
            parameters.Add("@VENDOR_ID", purchaseOrder.VENDOR_ID);
            parameters.Add("@CONSIGNEE_ID", purchaseOrder.CONSIGNEE_ID);
            parameters.Add("@TERMS_OF_DELIVERY", purchaseOrder.TERMS_OF_DELIVERY);
            parameters.Add("@SHIPPING_ADDRESS", purchaseOrder.SHIPPING_ADDRESS);
            parameters.Add("@DELIVERY_MODE", purchaseOrder.DELIVERY_MODE);
            parameters.Add("@PAYMENT_TERM", purchaseOrder.PAYMENT_TERM);
            parameters.Add("@PAYMENT_MODE", purchaseOrder.PAYMENT_MODE);
            parameters.Add("@INCOTERM", purchaseOrder.INCOTERM);
            parameters.Add("@CURRENCY", purchaseOrder.CURRENCY_NAME);
            parameters.Add("@SHIP_VIA", purchaseOrder.SHIP_VIA);
            parameters.Add("@CONTAINER_SIZE", purchaseOrder.CONTAINER_SIZE);
            parameters.Add("@DELIVERY_TIME", purchaseOrder.DELIVERY_TIME);
            parameters.Add("@COUNTRY_OF_ORIGIN", purchaseOrder.COUNTRY_OF_ORIGIN);
            parameters.Add("@IMPORT_FROM", purchaseOrder.IMPORT_FROM);
            parameters.Add("@PORT_OF_LOADING", purchaseOrder.PORT_OF_LOADING);
            parameters.Add("@PORT_OF_DISCHARGE", purchaseOrder.PORT_OF_DISCHARGE);
            //parameters.Add("@LABEL", purchaseOrder.LABEL);
            //parameters.Add("@SHELF_LIFE", purchaseOrder.SHELF_LIFE);
            parameters.Add("@CARRING_WAY_NAME", purchaseOrder.CARRING_WAY_NAME);
            parameters.Add("@CARRING_WAY_COST", purchaseOrder.CARRING_WAY_COST);
            parameters.Add("@GRAND_TOTAL", purchaseOrder.GRAND_TOTAL);
            parameters.Add("@SHIPPING_MARK", purchaseOrder.SHIPPING_MARK);
            parameters.Add("@PACKAGING", purchaseOrder.PACKAGING);
            parameters.Add("@IDENTIFICATION_NUMBER", purchaseOrder.IDENTIFICATION_NUMBER);
            parameters.Add("@ETD_1st_Date", purchaseOrder.ETD_1st_Date);
            parameters.Add("@ETD_2nd_Date", purchaseOrder.ETD_2nd_Date);
            parameters.Add("@ETD_3rd_Date", purchaseOrder.ETD_3rd_Date);
            parameters.Add("@ETD_4th_Date", purchaseOrder.ETD_4th_Date);
            parameters.Add("@ETA_1st_Date", purchaseOrder.ETA_1st_Date);
            parameters.Add("@ETA_2nd_Date", purchaseOrder.ETA_2nd_Date);
            parameters.Add("@ETA_3rd_Date", purchaseOrder.ETA_3rd_Date);
            parameters.Add("@ETA_4th_Date", purchaseOrder.ETA_4th_Date);
            parameters.Add("@EA_WH_1st_Date", purchaseOrder.EA_WH_1st_Date);
            parameters.Add("@EA_WH_2nd_Date", purchaseOrder.EA_WH_2nd_Date);
            parameters.Add("@EA_WH_3rd_Date", purchaseOrder.EA_WH_3rd_Date);
            parameters.Add("@EA_WH_4th_Date", purchaseOrder.EA_WH_4th_Date);
            parameters.Add("@RECEIVED_DATE", purchaseOrder.RECEIVED_DATE);
            parameters.Add("@SHIPMENT_STATUS", purchaseOrder.SHIPMENT_STATUS);



            //parameters.Add("@REQUESTED_BY", purchaseOrder.QUOTATION_REFERANCE_NO);
            //parameters.Add("@DEPARTMENT_ID", purchaseOrder.QUOTATION_REFERANCE_DATE);
            //parameters.Add("@REQUEST_DATE", purchaseOrder.VENDOR_ID);
            //parameters.Add("@REQUIRED_DATE", purchaseOrder.CONSIGNEE_ID);
            //parameters.Add("@REQUEST_FOR", purchaseOrder.TERMS_OF_DELIVERY);
            //parameters.Add("@PRIORITY", purchaseOrder.SHIPPING_ADDRESS);
            //parameters.Add("@REQUISITION_PURPOSE", purchaseOrder.DELIVERY_MODE);
            //parameters.Add("@REQUISITION_TOTAL", purchaseOrder.PAYMENT_TERM);
            //parameters.Add("@STATUS", purchaseOrder.PAYMENT_MODE);
            parameters.Add("@REG_BY", purchaseOrder.REG_BY);
            parameters.Add("@BILL_NO", purchaseOrder.BILL_NO);
            parameters.Add("@BIN", purchaseOrder.BIN);
            parameters.Add("@TIN", purchaseOrder.TIN);
            parameters.Add("@EMAIL", purchaseOrder.EMAIL);
            parameters.Add("@MOBILE", purchaseOrder.MOBILE);
            parameters.Add("@PACKAGING_INSTRUCTION", purchaseOrder.PACKAGING_INSTRUCTION);
            parameters.Add("@OTHER_TERMS_AND_CONDITION", purchaseOrder.OTHER_TERMS_AND_CONDITION);
            return parameters;
        }
        internal int GetPurchaseRequisitionId(string requisition_No)
        {
            int PurchaseId = 0;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var PID = connection.Query<int>("SELECT * FROM TBL_PURCHASE_REQUISITION WHERE REQUISITION_NO='" + requisition_No + "'");
                    if (PID != null && PID.Count() > 0)
                    {
                        PurchaseId = PID.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return PurchaseId;
        }
        internal int GetPurchaseOrderId(string po_No)
        {
            int orderId = 0;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var POID = connection.Query<int>("SELECT PO_ID FROM TBL_PURCHASE_ORDER WHERE PO_NUMBER_LONG_CODE='" + po_No + "'");
                    if (POID != null && POID.Count() > 0)
                    {
                        orderId = POID.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return orderId;
        }
        internal PurchaseOrderViewModel GetPurchaseOrderByPOId(string poId)
        {
            PurchaseOrderViewModel poViewModel = new PurchaseOrderViewModel();

            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_ID", poId, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_GET_PURCHASE_ORDER_BY_POID", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        poViewModel = poModel.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return poViewModel;
        }

        internal PurchaseOrderViewModel GetPurchaseListByQuotationNo(string po_No)
        {
            PurchaseOrderViewModel poViewModel = new PurchaseOrderViewModel();

            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_NO", po_No, DbType.String);

                var parameters1 = new DynamicParameters();
                
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_GET_PURCHASE_ORDER_BY_PONO", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        poViewModel = poModel.FirstOrDefault();
                        parameters1.Add("@PO_NO", poViewModel.PO_NUMBER, DbType.String);
                        var poDetailsModel = connection.Query<PurchaseOrderDetailsEntity>("SP_PURCHASE_GET_PURCHASE_ORDER_DETAILS_BY_PO_NO", parameters1, commandType: CommandType.StoredProcedure);
                        poViewModel.pOrderDetailsList = poDetailsModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return poViewModel;
        }
        //----------------------------------
        internal List<PurchaseOrderViewModel> GetPurchaseOrderIdByPurchaseDate(DateTime date1, DateTime date2)
        {
            List<PurchaseOrderViewModel> purchaseOrderDetailsList = new List<PurchaseOrderViewModel>();
            try
            {
                //date1 = "2022-03-30";
                //date2 = "2022-03-30";
                string d1 = date1.Day.ToString();
                string m1 = date1.Month.ToString();
                string y1 = date1.Year.ToString();
                string fdate = y1 + "-" + m1 + "-" + d1;
                string d2 = date2.Day.ToString();
                string m2 = date2.Month.ToString();
                string y2 = date2.Year.ToString();
                string tdate = y2 + "-" + m2 + "-" + d2;
                var parameters = new DynamicParameters();
                parameters.Add("@PO_DATE_FROM", fdate, DbType.String);
                parameters.Add("@PO_DATE_TO", tdate, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_GET_PURCHASE_ORDER_BY_PO_DATE", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderDetailsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderDetailsList;
        }
        public PurchaseOrderModel UpdateShipmentInfo(PurchaseOrderModel purchaseOrder)
        {
            _opurchaseOrder = new PurchaseOrderModel();

            string strSQL;
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand();
                    SqlTransaction myTrans;
                    myTrans = connection.BeginTransaction();
                    cmdInsert.Connection = connection;
                    cmdInsert.Transaction = myTrans;


                    strSQL = "UPDATE TBL_PURCHASE_ORDER SET ETD_1st_Date='" + purchaseOrder.ETD_1st_Date + "',";
                    strSQL = strSQL + "ETD_2nd_Date='" + purchaseOrder.ETD_1st_Date + "', ";
                    strSQL = strSQL + "ETD_3rd_Date='" + purchaseOrder.ETD_3rd_Date + "', ";
                    strSQL = strSQL + "ETD_4th_Date='" + purchaseOrder.ETD_4th_Date + "', ";
                    strSQL = strSQL + "ETA_1st_Date='" + purchaseOrder.ETA_1st_Date + "', ";
                    strSQL = strSQL + "ETA_2nd_Date='" + purchaseOrder.ETA_2nd_Date + "', ";
                    strSQL = strSQL + "ETA_3rd_Date='" + purchaseOrder.ETA_3rd_Date + "', ";
                    strSQL = strSQL + "ETA_4th_Date='" + purchaseOrder.ETA_4th_Date + "', ";
                    strSQL = strSQL + "EA_WH_1st_Date='" + purchaseOrder.EA_WH_1st_Date + "', ";
                    strSQL = strSQL + "EA_WH_2nd_Date='" + purchaseOrder.EA_WH_2nd_Date + "', ";
                    strSQL = strSQL + "EA_WH_3rd_Date='" + purchaseOrder.EA_WH_3rd_Date + "', ";
                    strSQL = strSQL + "EA_WH_4th_Date='" + purchaseOrder.EA_WH_4th_Date + "', ";
                    strSQL = strSQL + "RECEIVED_DATE='" + purchaseOrder.RECEIVED_DATE + "', ";
                    strSQL = strSQL + "SHIPMENT_STATUS='" + purchaseOrder.SHIPMENT_STATUS + "', ";
                    strSQL = strSQL + "LC_NO='" + purchaseOrder.LC_NO + "', ";
                    strSQL = strSQL + "LC_DATE='" + purchaseOrder.LC_DATE + "', ";
                    strSQL = strSQL + "LC_STATUS='" + purchaseOrder.LC_STATUS + "' ";
                    strSQL = strSQL + "WHERE PO_NUMBER_LONG_CODE = '" + purchaseOrder.PO_NUMBER_LONG_CODE + "'";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    cmdInsert.Transaction.Commit();

                    //if (connection.State == ConnectionState.Closed) connection.Open();
                    //var _oproductcategory = connection.Query<BankBranchModel>("SP_BRANCH_INSERT_BRANCH",
                    //    this.SetParametersforBranch(branchModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            //try
            //{
            //    using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            //    {
            //        if (connection.State == ConnectionState.Closed) connection.Open();
            //        var _oproductcategory = connection.Query<PurchaseOrderModel>("SP_PURCHASE_UPDATE_SHIPMENT_INFO",
            //            this.SetParametersShipmentInfo(purchaseOrder), commandType: CommandType.StoredProcedure);
            //    }
            //}
            //catch (Exception EX)
            //{

            //}
            return _opurchaseOrder;
        }
        public DynamicParameters SetParametersShipmentInfo(PurchaseOrderModel purchaseOrder)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@PO_NUMBER_LONG_CODE", purchaseOrder.PO_NUMBER_LONG_CODE);
            parameters.Add("@ETD_1st_Date", purchaseOrder.ETD_1st_Date);
            parameters.Add("@ETD_2nd_Date", purchaseOrder.ETD_2nd_Date);
            parameters.Add("@ETD_3rd_Date", purchaseOrder.ETD_3rd_Date);
            parameters.Add("@ETD_4th_Date", purchaseOrder.ETD_4th_Date);
            parameters.Add("@ETA_1st_Date", purchaseOrder.ETA_1st_Date);
            parameters.Add("@ETA_2nd_Date", purchaseOrder.ETA_2nd_Date);
            parameters.Add("@ETA_3rd_Date", purchaseOrder.ETA_3rd_Date);
            parameters.Add("@ETA_4th_Date", purchaseOrder.ETA_4th_Date);
            parameters.Add("@EA_WH_1st_Date", purchaseOrder.EA_WH_1st_Date);
            parameters.Add("@EA_WH_2nd_Date", purchaseOrder.EA_WH_2nd_Date);
            parameters.Add("@EA_WH_3rd_Date", purchaseOrder.EA_WH_3rd_Date);
            parameters.Add("@EA_WH_4th_Date", purchaseOrder.EA_WH_4th_Date);
            parameters.Add("@RECEIVED_DATE", purchaseOrder.RECEIVED_DATE);
            parameters.Add("@SHIPMENT_STATUS", purchaseOrder.SHIPMENT_STATUS);

            return parameters;
        }
        public PurchaseOrderModel UpdateGoodsReceiveInfo(PurchaseOrderModel purchaseOrder)
        {
            _opurchaseOrder = new PurchaseOrderModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<PurchaseOrderModel>("SP_PURCHASE_UPDATE_GOOD_RECEIVE_INFO",
                        this.SetParametersPurchaseOrder(purchaseOrder), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return _opurchaseOrder;
        }
        public DynamicParameters SetParametersPurchaseOrder(PurchaseOrderModel purchaseOrder)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@PO_NUMBER_LONG_CODE", purchaseOrder.PO_NUMBER_LONG_CODE);
            parameters.Add("@GOOD_RECEIVE_NOTE", purchaseOrder.GOOD_RECEIVE_NOTE);
            parameters.Add("@RECEIVED_DATE", purchaseOrder.RECEIVED_DATE);
            parameters.Add("@SHIPMENT_STATUS", purchaseOrder.SHIPMENT_STATUS);

            return parameters;
        }
        internal List<PurchaseOrderViewModel> GetDailyPurchaseStatementByDate(DateTime date1, DateTime date2)
        {
            List<PurchaseOrderViewModel> purchaseOrderDetailsList = new List<PurchaseOrderViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_DATE_FROM", date1, DbType.DateTime);
                parameters.Add("@PO_DATE_TO", date2, DbType.DateTime);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_GET_DAILY_PURCHASE_STATEMENT_BY_PO_DATE", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderDetailsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderDetailsList;
        }
        internal List<PurchaseOrderDetailsEntity> GetPurchaseOrderDetailsByPOID(string POID)
        {
            List<PurchaseOrderDetailsEntity> purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_ID", POID, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderDetailsEntity>("SP_PURCHASE_GET_PURCHASE_ORDER_DETAILS_BY_POID", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderDetailsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderDetailsList;
        }
        internal List<PurchaseOrderDetailsEntity> GetPurchaseOrderDetailsByPONO(string PONO)
        {
            List<PurchaseOrderDetailsEntity> purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_NO", PONO, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderDetailsEntity>("SP_PURCHASE_GET_PURCHASE_ORDER_DETAILS_BY_PO_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderDetailsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderDetailsList;
        }
        internal PurchaseOrderViewModel GetPurchaseOrderInfo(string PONO)
        {
            PurchaseOrderViewModel purchaseOrderView = new PurchaseOrderViewModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_ID", PONO, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_GET_PURCHASE_ORDER_INFO", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderView = poModel.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderView;
        }
        internal List<PurchaseOrderViewModel> GetPurchaseListForProject(string voucherNo)
        {
            List<PurchaseOrderViewModel> purchaseOrderView = new List<PurchaseOrderViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@VoucherNo", voucherNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_PURCHASE_ITEM_FOR_PROJECT",parameters,commandType:CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderView = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderView;
        }
        internal List<PurchaseOrderViewModel> GetPurchaseItem()
        {
            List<PurchaseOrderViewModel> purchaseOrderView = new List<PurchaseOrderViewModel>();
            try
            {
                //var parameters = new DynamicParameters();
                //parameters.Add("@VoucherNo", voucherNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_GET_PURCHASE_ITEM");
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderView = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderView;
        }
        internal List<PurchaseOrderViewModel> GetPurchaseList()
        {
            List<PurchaseOrderViewModel> purchaseOrderView = new List<PurchaseOrderViewModel>();
            try
            {
                //var parameters = new DynamicParameters();
                //parameters.Add("@PO_ID", PONO, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_GET_PURCHASE_INFO");
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderView = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderView;
        }
        internal List<PurchaseOrderViewModel> GetPurchaseListForProjectByDate(string from_date, string to_date)
        {
            List<PurchaseOrderViewModel> purchaseOrderView = new List<PurchaseOrderViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@from_date", from_date, DbType.String);
                parameters.Add("@to_date", to_date, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    //var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_PURCHASE_ITEM_FOR_PROJECT");
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_PURCHASE_ITEM_FOR_PROJECT_BY_Date", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderView = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderView;
        }
        //--Search by Voucher
        internal List<PurchaseOrderDetailsEntity> GetPurchaseListForProjectByVoucherNo(string voucherNo)
        {
            List<PurchaseOrderDetailsEntity> purchaseOrderView = new List<PurchaseOrderDetailsEntity>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Voucher_no", voucherNo, DbType.String);                
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    //var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_PURCHASE_ITEM_FOR_PROJECT");
                    var poModel = connection.Query<PurchaseOrderDetailsEntity>("SP_PURCHASE_GET_PURCHASE_ORDER_BY_VOUCHER_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderView = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderView;
        }
        internal PurchaseOrderViewModel GetPurchaseItemSumForProject()
        {
            PurchaseOrderViewModel purchaseOrderView = new PurchaseOrderViewModel();
            try
            {                
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_PURCHASE_ITEM_SUM_FOR_PROJECT");
                    //var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_PURCHASE_ITEM_FOR_PROJECT_BY_Date", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderView = poModel.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderView;
        }
        internal PurchaseOrderViewModel GetPurchaseItemSumForProjectByDate(string from_date, string to_date)
        {
            PurchaseOrderViewModel purchaseOrderView = new PurchaseOrderViewModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@from_date", from_date, DbType.String);
                parameters.Add("@to_date", to_date, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    //var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_PURCHASE_ITEM_SUM_FOR_PROJECT");
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_PURCHASE_ITEM_SUM_FOR_PROJECT_By_Date", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderView = poModel.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderView;
        }

        internal List<PurchaseOrderViewModel> GetPurchaseOrderDetailsByPO_NO(string PONO)
        {
            List<PurchaseOrderViewModel> purchaseOrderDetailsList = new List<PurchaseOrderViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_NO", PONO, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderViewModel>("SP_PURCHASE_GET_PURCHASE_ORDER_DETAILS_BY_PO_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderDetailsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderDetailsList;
        }
        internal PurchaseOrderModel GetPurchaseOrderByPO_NO(string PONO)
        {
            PurchaseOrderModel purchaseOrderDetailsList = new PurchaseOrderModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_NO", PONO, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderModel>("SP_PURCHASE_GET_PURCHASE_ORDER_BY_PO_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderDetailsList = poModel.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderDetailsList;
        }
        internal List<PurchaseOrderDetailsEntity> GetPurchaseOrderDetailsBYPO_ID_IN(string POID)
        {
            List<PurchaseOrderDetailsEntity> purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
            try
            {
                var parameters = new DynamicParameters();

                string CONDITION = "WHERE POD.PO_ID IN(" + POID + ")";
                parameters.Add("@SEARCH_CONDITION", CONDITION, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderDetailsEntity>("SP_PURCHASE_GET_PURCHASE_ORDER_DETAILS_BY_POID_IN", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderDetailsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderDetailsList;
        }
        //--------
        internal List<PurchaseOrderDetailsEntity> GetAllPurchaseOrderDetails()
        {
            List<PurchaseOrderDetailsEntity> purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseOrderDetailsEntity>("SELECT * FROM TBL_PURCHASE_ORDER_DETAILS p INNER JOIN TBL_ITEM I ON p.ITEM_ID=I.ITEM_ID");
                    if (poModel.Count() > 0)
                    {
                        purchaseOrderDetailsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }


            return purchaseOrderDetailsList;
        }
        internal List<WarehouseModel> GetAllWareHouse()
        {
            List<WarehouseModel> wareHouseList = new List<WarehouseModel>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<WarehouseModel>("SELECT * FROM TBL_WAREHOUSE");
                if (poModel.Count() > 0)
                {
                    wareHouseList = poModel.ToList();
                }
            }
            return wareHouseList;
        }
        //public RequisitionNo GetReqNo()
        //{
        //    RequisitionNo reQNo = new RequisitionNo();
        //    try
        //    {
        //        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
        //        {
        //            connection.Open();
        //            var oproductgroup = connection.Query<RequisitionNo>("SP_SEQUENCE_GENERATE_REQUISITION_NO");
        //            if (oproductgroup != null && oproductgroup.Count() > 0)
        //            {
        //                reQNo = oproductgroup.FirstOrDefault();
        //            }
        //        }
        //    }
        //    catch (Exception EX)
        //    {

        //    }            
        //    return reQNo;
        //}
        internal string GetReqNo()
        {
            string reqNo = "";
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var PID = connection.Query<string>("SP_SEQUENCE_GENERATE_REQUISITION_NO");
                    if (PID != null && PID.Count() > 0)
                    {
                        reqNo = PID.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return reqNo;
        }
        //--
        internal string GetPONo()
        {
            string pono = "";
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var PID = connection.Query<string>("SP_SEQUENCE_GENERATE_PO_NO");
                    if (PID != null && PID.Count() > 0)
                    {
                        pono = PID.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return pono;
        }
        internal string GetPurchaseOrderNo()
        {
            string pono = "";
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    string year = System.DateTime.Now.Year.ToString().Substring(2, 2);
                    int length = 4;
                    int number = 50;
                    int n = 0;
                    string sYear = DateTime.Now.Year.ToString();

                    string sMonth = DateTime.Now.Month.ToString().PadLeft(2, '0');

                    string sDay = DateTime.Now.Day.ToString().PadLeft(2, '0');

                    string caseTime = year + sMonth + sDay;
                    string asString = number.ToString("D" + length);
                    var PID = connection.Query<string>("Select TOP 1 PO_NUMBER from TBL_PURCHASE_ORDER ORDER BY  PO_ID DESC");
                    if (PID != null && PID.Count() > 0)
                    {
                        pono = PID.FirstOrDefault();
                    }
                    if (pono == "")
                    { pono = "0"; }
                    string no = "0";
                    if (pono.Length >1)
                    { no = pono.Remove(0, 6); }
                    else { }

                    string num = caseTime + (Convert.ToInt64(no) + 1);
                    pono = num;
                }
            }
            catch (Exception EX)
            {

            }
            return pono;
        }
        internal string GetPurchaseOrderNo111()
        {
            string pono = "";
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    string year = System.DateTime.Now.Year.ToString().Substring(2, 2);
                    int length = 4;
                    int number = 50;
                    int n = 0;
                    string asString = number.ToString("D" + length);
                    var PID = connection.Query<string>("Select TOP 1 PO_NUMBER_LONG_CODE from TBL_PURCHASE_ORDER ORDER BY  PO_ID DESC");
                    if (PID != null && PID.Count() > 0)
                    {
                        pono = PID.FirstOrDefault();
                    }
                    if (pono != "")
                    {
                        n = Convert.ToInt32(pono.Substring(6, 4));
                        n = n + 1;
                    }
                    else { n = 1; }

                    string C = n.ToString("D" + length) + "-" + year;
                    pono = C;

                }
            }
            catch (Exception EX)
            {

            }
            return pono;
        }

        public List<PackagingInstructionModel> PackagingInstruction(string Ids)
        {
            List<PackagingInstructionModel> PackageInsList = new List<PackagingInstructionModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", Ids, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PackagingInstructionModel>("SP_PURCHASE_GET_PACKAGING_INSTRUCTION", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        PackageInsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return PackageInsList;

        }
        public List<PurchaseTermsConditionsModel> GetTermsAndConditions(string Ids)
        {
            List<PurchaseTermsConditionsModel> termsAndConditonsList = new List<PurchaseTermsConditionsModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", Ids, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseTermsConditionsModel>("SP_PURCHASE_GET_TERMS_AND_CONDITIONS", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        termsAndConditonsList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return termsAndConditonsList;
        }


        //#region ksr
        public List<RStockInformation> mGetProductSummery()
        {
            string strSQL = null;
            SqlDataReader dr;
            List<RStockInformation> ooAccLedger = new List<RStockInformation>();
            //connstring = Utility.SQLConnstringComSwitch(strDeComID);
            using (SqlConnection gcnMain = new SqlConnection(Global.ConnectionString))
            {
                if (gcnMain.State == ConnectionState.Open)
                {
                    gcnMain.Close();
                }
                gcnMain.Open();

                SqlCommand cmdInsert = new SqlCommand();
                SqlTransaction myTrans;
                myTrans = gcnMain.BeginTransaction();
                cmdInsert.Connection = gcnMain;
                cmdInsert.Transaction = myTrans;
                cmdInsert.CommandTimeout = 0;
                int intMode = 1;
                #region "Stock Statament"
                if (intMode == 1)
                {
                    strSQL = "DELETE FROM INV_STOCK_STATEMENT ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //---OPening
                    ////--ItemOpe_QTY
                    strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_CODE,ITEM_NAME,STOCKITEM_ALIAS,PURCHASE_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    strSQL = strSQL + "SELECT TBL_ITEM.ITEM_CODE,TBL_ITEM.ITEM_NAME,'' OLD_ITEM_ALIAS,TBL_PURCHASE_ORDER_DETAILS.QUANTITY,TBL_PURCHASE_ORDER_DETAILS.UNIT_PRICE ,('')POWER_CLASS,TBL_ITEM.PACK_SIZE FROM TBL_PURCHASE_ORDER_DETAILS,TBL_ITEM ";
                    strSQL = strSQL + " WHERE TBL_PURCHASE_ORDER_DETAILS .ITEM_ID =TBL_ITEM.ITEM_ID ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    ////--Purchase Quantity < From Date
                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,OPENING_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I   ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND M.PO_DATE < '" + strFdate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ///end Opening

                    //////--Purchase_QTY

                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,PURCHASE_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ////--Transfer_QTY
                    ///
                    //  -------------------
                    strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_CODE,ITEM_NAME,SALES_QTY) ";
                    strSQL = strSQL + "SELECT ITEM_CODE,ITEM_NAME,QUANTITY FROM [dbo].[TBL_DELIVERY_DETAILS] ";

                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();




                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,SALES_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =35 ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();


                    //////--Sales RETURN_QTY
                    ////strSQL = "INSERT INTO INV_STOCK_STATEMENT(STOCKGROUP_NAME,ITEM_NAME,STOCKITEM_ALIAS,RETURN_QTY,CLASS,PACK_SIZE) ";
                    ////strSQL = strSQL + "select s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,  abs(isnull(sum(t.INV_TRAN_QUANTITY),0)) as opn  ";
                    ////strSQL = strSQL + ",s.POWER_CLASS,s.STOCKCATEGORY_NAME from INV_STOCKITEM s,INV_TRAN t where s.STOCKITEM_NAME =t.STOCKITEM_NAME ";
                    ////strSQL = strSQL + "AND t.INV_DATE BETWEEN  " + Utility.cvtSQLDateString(strFdate) + " ";
                    ////strSQL = strSQL + "AND  " + Utility.cvtSQLDateString(strTDate) + " ";
                    ////strSQL = strSQL + " and t.INV_VOUCHER_TYPE = " + (int)Utility.VOUCHER_TYPE.vtSALES_RETURN + " ";
                    ////strSQL = strSQL + "AND t.BRANCH_ID='" + strBranchID + "' ";
                    ////if (strstring != "")
                    ////{
                    ////    strSQL = strSQL + "AND s.STOCKGROUP_NAME in (" + strstring + ") ";
                    ////}
                    ////if (strBranchID == "0001")
                    ////{
                    ////    strSQL = strSQL + "AND t.GODOWNS_NAME='Main Location' ";
                    ////}
                    ////strSQL = strSQL + " group by s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,s.POWER_CLASS,s.STOCKCATEGORY_NAME ";
                    ////cmdInsert.CommandText = strSQL;
                    ////cmdInsert.ExecuteNonQuery();
                }
                cmdInsert.Transaction.Commit();
                cmdInsert.CommandTimeout = 30;


                strSQL = "SELECT  ITEM_CODE,ITEM_NAME,OPENING_QTY,PURCHASE_QTY,SALES_QTY,SAMPLE_QTY,";
                strSQL = strSQL + "RETURN_QTY,CONVERT_QTY,BROKEN_QTY,PHY_STOCK_QTY,PHY_STOCK_QTY_OUT,STOCK_TRANSFER_QTY,STOCK_TRANSFER_IN_QTY,CONSUMPTION_QTY from STOCK_SUMMERY_VIEW";

                strSQL = strSQL + " ORDER by ITEM_NAME ";


                cmdInsert.CommandText = strSQL;
                cmdInsert.Connection = gcnMain;
                dr = cmdInsert.ExecuteReader();
                while (dr.Read())
                {
                    RStockInformation oLedg = new RStockInformation();
                    
                    oLedg.strItemCode = dr["ITEM_CODE"].ToString();                    
                    oLedg.strItemName = dr["ITEM_NAME"].ToString();                    
                    oLedg.dblOpnQty = Convert.ToDouble(dr["OPENING_QTY"]);
                    oLedg.purchaseQty = Math.Abs(Convert.ToDouble(dr["PURCHASE_QTY"]));
                    oLedg.salesQty = Math.Abs(Convert.ToDouble(dr["SALES_QTY"]));
                    oLedg.dblSampleQty = Math.Abs(Convert.ToDouble(dr["SAMPLE_QTY"]));
                    oLedg.dblReturnQty = Math.Abs(Convert.ToDouble(dr["RETURN_QTY"]));
                    oLedg.dblConvertQty = Math.Abs((Convert.ToDouble(dr["CONVERT_QTY"])));
                    oLedg.dblBroken = Math.Abs((Convert.ToDouble(dr["BROKEN_QTY"])));
                    oLedg.dblPhyStockQty = (Convert.ToDouble(dr["PHY_STOCK_QTY"]));
                    oLedg.dblPhyStockQtyOut = (Convert.ToDouble(dr["PHY_STOCK_QTY_OUT"]));
                    oLedg.dblTranserOutQty = Math.Abs(Convert.ToDouble(dr["STOCK_TRANSFER_QTY"]));
                    oLedg.dblStockTranserQty = Math.Abs(Convert.ToDouble(dr["STOCK_TRANSFER_IN_QTY"]));
                    oLedg.dblConsumptionQty = Math.Abs(Convert.ToDouble(dr["CONSUMPTION_QTY"]));
                    oLedg.stockBalance = oLedg.purchaseQty - oLedg.salesQty;
                    

                    ooAccLedger.Add(oLedg);
                }
                if (!dr.HasRows)
                {
                    RStockInformation oLedg = new RStockInformation();
                    oLedg.strGroupName = "";
                    oLedg.strItemName = "";
                    oLedg.strItemCode = "";
                    oLedg.strItemAlias = "";
                    oLedg.strPackSize = "";
                    oLedg.strClass = "";
                    oLedg.dblOpnQty = 0;
                    oLedg.dblInwQty = 0;
                    oLedg.dblOutWardQty = 0;
                    oLedg.dblSampleQty = 0;
                    oLedg.dblReturnQty = 0;
                    oLedg.dblConvertQty = 0;
                    oLedg.dblBroken = 0;
                    oLedg.dblPhyStockQty = 0;
                    oLedg.dblPhyStockQtyOut = 0;
                    oLedg.dblStockTranserQty = 0;
                    oLedg.dblConsumptionQty = 0;
                    ooAccLedger.Add(oLedg);
                }
                dr.Close();
                gcnMain.Close();

            }
            return ooAccLedger;
        }
        public List<RStockInformation> mGetProductStatement(string strFdate, string strTDate)
        {
            string strSQL = null;
            SqlDataReader dr;
            List<RStockInformation> ooAccLedger = new List<RStockInformation>();
            //connstring = Utility.SQLConnstringComSwitch(strDeComID);
            using (SqlConnection gcnMain = new SqlConnection(Global.ConnectionString))
            {
                if (gcnMain.State == ConnectionState.Open)
                {
                    gcnMain.Close();
                }
                gcnMain.Open();

                SqlCommand cmdInsert = new SqlCommand();
                SqlTransaction myTrans;
                myTrans = gcnMain.BeginTransaction();
                cmdInsert.Connection = gcnMain;
                cmdInsert.Transaction = myTrans;
                cmdInsert.CommandTimeout = 0;
                int intMode = 1;
                #region "Stock Statament"
                if (intMode == 1)
                {
                    strSQL = "DELETE FROM INV_STOCK_STATEMENT ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //---OPening
                    ////--ItemOpe_QTY
                    strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,PRODUCTION_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    strSQL = strSQL + "SELECT TBL_ITEM.ITEM_NAME,'' OLD_ITEM_ALIAS,TBL_PURCHASE_ORDER_DETAILS.QUANTITY,TBL_PURCHASE_ORDER_DETAILS.UNIT_PRICE ,('')POWER_CLASS,TBL_ITEM.PACK_SIZE FROM TBL_PURCHASE_ORDER_DETAILS,TBL_ITEM ";
                    strSQL = strSQL + " WHERE TBL_PURCHASE_ORDER_DETAILS .ITEM_ID =TBL_ITEM.ITEM_ID   AND  TBL_PURCHASE_ORDER_DETAILS.VOUCHER_TYPE =34  ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    ////--Purchase Quantity < From Date
                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,OPENING_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I   ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND M.PO_DATE < '" + strFdate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ///end Opening

                    //////--Purchase_QTY

                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,PURCHASE_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ////--Transfer_QTY
                    ///

                    strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,SALES_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    strSQL = strSQL + "SELECT TBL_ITEM.ITEM_NAME,'' OLD_ITEM_ALIAS,TBL_PURCHASE_ORDER_DETAILS.QUANTITY,TBL_PURCHASE_ORDER_DETAILS.UNIT_PRICE ,('')POWER_CLASS,TBL_ITEM.PACK_SIZE FROM TBL_PURCHASE_ORDER_DETAILS,TBL_ITEM ";
                    strSQL = strSQL + " WHERE TBL_PURCHASE_ORDER_DETAILS .ITEM_ID =TBL_ITEM.ITEM_ID   AND  TBL_PURCHASE_ORDER_DETAILS.VOUCHER_TYPE =35  ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();


                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,SALES_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =35 ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();


                    //////--Sales RETURN_QTY
                    ////strSQL = "INSERT INTO INV_STOCK_STATEMENT(STOCKGROUP_NAME,ITEM_NAME,STOCKITEM_ALIAS,RETURN_QTY,CLASS,PACK_SIZE) ";
                    ////strSQL = strSQL + "select s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,  abs(isnull(sum(t.INV_TRAN_QUANTITY),0)) as opn  ";
                    ////strSQL = strSQL + ",s.POWER_CLASS,s.STOCKCATEGORY_NAME from INV_STOCKITEM s,INV_TRAN t where s.STOCKITEM_NAME =t.STOCKITEM_NAME ";
                    ////strSQL = strSQL + "AND t.INV_DATE BETWEEN  " + Utility.cvtSQLDateString(strFdate) + " ";
                    ////strSQL = strSQL + "AND  " + Utility.cvtSQLDateString(strTDate) + " ";
                    ////strSQL = strSQL + " and t.INV_VOUCHER_TYPE = " + (int)Utility.VOUCHER_TYPE.vtSALES_RETURN + " ";
                    ////strSQL = strSQL + "AND t.BRANCH_ID='" + strBranchID + "' ";
                    ////if (strstring != "")
                    ////{
                    ////    strSQL = strSQL + "AND s.STOCKGROUP_NAME in (" + strstring + ") ";
                    ////}
                    ////if (strBranchID == "0001")
                    ////{
                    ////    strSQL = strSQL + "AND t.GODOWNS_NAME='Main Location' ";
                    ////}
                    ////strSQL = strSQL + " group by s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,s.POWER_CLASS,s.STOCKCATEGORY_NAME ";
                    ////cmdInsert.CommandText = strSQL;
                    ////cmdInsert.ExecuteNonQuery();
                }
                cmdInsert.Transaction.Commit();
                cmdInsert.CommandTimeout = 30;


                strSQL = "SELECT  STOCKGROUP_NAME,ITEM_NAME,STOCKITEM_ALIAS,OPENING_QTY,PRODUCTION_QTY,SALES_QTY,SAMPLE_QTY,";
                strSQL = strSQL + "RETURN_QTY,CONVERT_QTY,BROKEN_QTY,PHY_STOCK_QTY,PHY_STOCK_QTY_OUT,STOCK_TRANSFER_QTY,STOCK_TRANSFER_IN_QTY,CONSUMPTION_QTY,CLASS,PACK_SIZE from INV_STOCK_STATEMENT_VIEW";

                strSQL = strSQL + " ORDER by ITEM_NAME ";


                cmdInsert.CommandText = strSQL;
                cmdInsert.Connection = gcnMain;
                dr = cmdInsert.ExecuteReader();
                while (dr.Read())
                {
                    RStockInformation oLedg = new RStockInformation();
                    oLedg.strGroupName = dr["STOCKGROUP_NAME"].ToString();
                    oLedg.strItemName = dr["ITEM_NAME"].ToString();
                    oLedg.strItemAlias = dr["STOCKITEM_ALIAS"].ToString();
                    oLedg.dblOpnQty = Convert.ToDouble(dr["OPENING_QTY"]);
                    oLedg.purchaseQty = Math.Abs(Convert.ToDouble(dr["PRODUCTION_QTY"]));
                    oLedg.salesQty = Math.Abs(Convert.ToDouble(dr["SALES_QTY"]));
                    oLedg.dblSampleQty = Math.Abs(Convert.ToDouble(dr["SAMPLE_QTY"]));
                    oLedg.dblReturnQty = Math.Abs(Convert.ToDouble(dr["RETURN_QTY"]));
                    oLedg.dblConvertQty = Math.Abs((Convert.ToDouble(dr["CONVERT_QTY"])));
                    oLedg.dblBroken = Math.Abs((Convert.ToDouble(dr["BROKEN_QTY"])));
                    oLedg.dblPhyStockQty = (Convert.ToDouble(dr["PHY_STOCK_QTY"]));
                    oLedg.dblPhyStockQtyOut = (Convert.ToDouble(dr["PHY_STOCK_QTY_OUT"]));
                    oLedg.dblTranserOutQty = Math.Abs(Convert.ToDouble(dr["STOCK_TRANSFER_QTY"]));
                    oLedg.dblStockTranserQty = Math.Abs(Convert.ToDouble(dr["STOCK_TRANSFER_IN_QTY"]));
                    oLedg.dblConsumptionQty = Math.Abs(Convert.ToDouble(dr["CONSUMPTION_QTY"]));
                    if (dr["CLASS"].ToString() != "")
                    {
                        oLedg.strClass = dr["CLASS"].ToString();
                    }
                    else
                    {
                        oLedg.strClass = "";
                    }
                    if (dr["PACK_SIZE"].ToString() != "")
                    {
                        oLedg.strPackSize = dr["PACK_SIZE"].ToString();
                    }
                    else
                    {
                        oLedg.strPackSize = "";
                    }

                    ooAccLedger.Add(oLedg);
                }
                if (!dr.HasRows)
                {
                    RStockInformation oLedg = new RStockInformation();
                    oLedg.strGroupName = "";
                    oLedg.strItemName = "";
                    oLedg.strItemAlias = "";
                    oLedg.strPackSize = "";
                    oLedg.strClass = "";
                    oLedg.dblOpnQty = 0;
                    oLedg.dblInwQty = 0;
                    oLedg.dblOutWardQty = 0;
                    oLedg.dblSampleQty = 0;
                    oLedg.dblReturnQty = 0;
                    oLedg.dblConvertQty = 0;
                    oLedg.dblBroken = 0;
                    oLedg.dblPhyStockQty = 0;
                    oLedg.dblPhyStockQtyOut = 0;
                    oLedg.dblStockTranserQty = 0;
                    oLedg.dblConsumptionQty = 0;
                    ooAccLedger.Add(oLedg);
                }
                dr.Close();
                gcnMain.Close();

            }
            return ooAccLedger;
        }

        public List<ProjectCostReportModel> GetProjectCost(string projectName)
        {
            string strSQL = null;
            SqlDataReader dr;
            List<ProjectCostReportModel> ooAccLedger = new List<ProjectCostReportModel>();
            //connstring = Utility.SQLConnstringComSwitch(strDeComID);
            using (SqlConnection gcnMain = new SqlConnection(Global.ConnectionString))
            {
                if (gcnMain.State == ConnectionState.Open)
                {
                    gcnMain.Close();
                }
                gcnMain.Open();

                SqlCommand cmdInsert = new SqlCommand();
                SqlTransaction myTrans;
                myTrans = gcnMain.BeginTransaction();
                cmdInsert.Connection = gcnMain;
                cmdInsert.Transaction = myTrans;
                cmdInsert.CommandTimeout = 0;
                int intMode = 1;
                
                if (intMode == 1)
                {
                    strSQL = "DELETE FROM TBL_PROJECT_COST_REPORT_DATA ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //---Purchase                    
                    strSQL = "INSERT INTO TBL_PROJECT_COST_REPORT_DATA(PROJECT_NAME,COST_HEAD,AMOUNT) ";
                    strSQL = strSQL + "Select LEDGER_NAME,'Purchase',SUM(GRAND_TOTAL)GRAND_TOTAL from TBL_PURCHASE_ORDER ";
                    strSQL = strSQL + " WHERE VOUCHER_TYPE=34 And LEDGER_NAME='" + projectName + "' GROUP BY LEDGER_NAME  ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    ////Expense

                    strSQL = "INSERT INTO TBL_PROJECT_COST_REPORT_DATA(PROJECT_NAME,COST_HEAD,AMOUNT) ";
                    strSQL = strSQL + "Select A.LEDGER_NAME,l.LEDGER_NAME,SUM(A.COMP_VOUCHER_AMOUNT) from [dbo].[A_M_LEDGER] l ";
                    strSQL = strSQL + "inner join [dbo].[A_M_LEDGERGROUP] lg on l.LEDGER_PARENT_GROUP=lg.GR_NAME ";
                    strSQL = strSQL + "inner join [dbo].[ACC_VOUCHER] V ON l.LEDGER_NAME=V.LEDGER_NAME ";
                    strSQL = strSQL + "inner join [dbo].[ACC_COMPANY_VOUCHER] A on V.COMP_REF_NO=A.COMP_REF_NO ";
                    strSQL = strSQL + " where lg.GR_PARENT='Expenses' And A.LEDGER_NAME='"+ projectName + "' Group By A.LEDGER_NAME,L.LEDGER_NAME  ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    ////--Purchase Quantity < From Date
                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,OPENING_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I   ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND M.PO_DATE < '" + strFdate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ///end Opening

                    //////--Purchase_QTY

                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,PURCHASE_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ////--Transfer_QTY
                    ///

                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,SALES_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT TBL_ITEM.ITEM_NAME,'' OLD_ITEM_ALIAS,TBL_PURCHASE_ORDER_DETAILS.QUANTITY,TBL_PURCHASE_ORDER_DETAILS.UNIT_PRICE ,('')POWER_CLASS,TBL_ITEM.PACK_SIZE FROM TBL_PURCHASE_ORDER_DETAILS,TBL_ITEM ";
                    //strSQL = strSQL + " WHERE TBL_PURCHASE_ORDER_DETAILS .ITEM_ID =TBL_ITEM.ITEM_ID   AND  TBL_PURCHASE_ORDER_DETAILS.VOUCHER_TYPE =35  ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();


                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,SALES_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =35 ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();


                    //////--Sales RETURN_QTY
                    ////strSQL = "INSERT INTO INV_STOCK_STATEMENT(STOCKGROUP_NAME,ITEM_NAME,STOCKITEM_ALIAS,RETURN_QTY,CLASS,PACK_SIZE) ";
                    ////strSQL = strSQL + "select s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,  abs(isnull(sum(t.INV_TRAN_QUANTITY),0)) as opn  ";
                    ////strSQL = strSQL + ",s.POWER_CLASS,s.STOCKCATEGORY_NAME from INV_STOCKITEM s,INV_TRAN t where s.STOCKITEM_NAME =t.STOCKITEM_NAME ";
                    ////strSQL = strSQL + "AND t.INV_DATE BETWEEN  " + Utility.cvtSQLDateString(strFdate) + " ";
                    ////strSQL = strSQL + "AND  " + Utility.cvtSQLDateString(strTDate) + " ";
                    ////strSQL = strSQL + " and t.INV_VOUCHER_TYPE = " + (int)Utility.VOUCHER_TYPE.vtSALES_RETURN + " ";
                    ////strSQL = strSQL + "AND t.BRANCH_ID='" + strBranchID + "' ";
                    ////if (strstring != "")
                    ////{
                    ////    strSQL = strSQL + "AND s.STOCKGROUP_NAME in (" + strstring + ") ";
                    ////}
                    ////if (strBranchID == "0001")
                    ////{
                    ////    strSQL = strSQL + "AND t.GODOWNS_NAME='Main Location' ";
                    ////}
                    ////strSQL = strSQL + " group by s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,s.POWER_CLASS,s.STOCKCATEGORY_NAME ";
                    ////cmdInsert.CommandText = strSQL;
                    ////cmdInsert.ExecuteNonQuery();
                }
                cmdInsert.Transaction.Commit();
                cmdInsert.CommandTimeout = 30;

                
                strSQL = "SELECT  PROJECT_NAME,COST_HEAD,AMOUNT";
                strSQL = strSQL + " From TBL_PROJECT_COST_REPORT_DATA";

                strSQL = strSQL + " ORDER by COST_HEAD ";


                cmdInsert.CommandText = strSQL;
                cmdInsert.Connection = gcnMain;
                dr = cmdInsert.ExecuteReader();
                while (dr.Read())
                {
                    ProjectCostReportModel oLedg = new ProjectCostReportModel();
                    oLedg.PROJECT_NAME = dr["PROJECT_NAME"].ToString();
                    oLedg.COST_HEAD = dr["COST_HEAD"].ToString();                    
                    oLedg.AMOUNT = Convert.ToDouble(dr["AMOUNT"]);
                    
                    

                    ooAccLedger.Add(oLedg);
                }
                if (!dr.HasRows)
                {
                    ProjectCostReportModel oLedg = new ProjectCostReportModel();
                    oLedg.PROJECT_NAME = "";
                    oLedg.COST_HEAD = "";                   
                    oLedg.AMOUNT = 0;                    
                    ooAccLedger.Add(oLedg);
                }
                dr.Close();
                gcnMain.Close();

            }
            return ooAccLedger;
        }

        public List<ProjectCostReportModel> GetProjectwiseCost(string projectName)
        {
            string strSQL = null;
            SqlDataReader dr;
            List<ProjectCostReportModel> ooAccLedger = new List<ProjectCostReportModel>();
            //connstring = Utility.SQLConnstringComSwitch(strDeComID);
            using (SqlConnection gcnMain = new SqlConnection(Global.ConnectionString))
            {
                if (gcnMain.State == ConnectionState.Open)
                {
                    gcnMain.Close();
                }
                gcnMain.Open();

                SqlCommand cmdInsert = new SqlCommand();
                SqlTransaction myTrans;
                myTrans = gcnMain.BeginTransaction();
                cmdInsert.Connection = gcnMain;
                cmdInsert.Transaction = myTrans;
                cmdInsert.CommandTimeout = 0;
                int intMode = 1;

                if (intMode == 1)
                {
                    strSQL = "DELETE FROM TBL_PROJECT_COST_REPORT_DATA ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //---Purchase                    
                    strSQL = "INSERT INTO TBL_PROJECT_COST_REPORT_DATA(PROJECT_NAME,AMOUNT) ";
                    strSQL = strSQL + "Select LEDGER_NAME,SUM(GRAND_TOTAL)GRAND_TOTAL from TBL_PURCHASE_ORDER ";
                    strSQL = strSQL + " WHERE VOUCHER_TYPE=34  GROUP BY LEDGER_NAME  ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    ////Expense

                    strSQL = "INSERT INTO TBL_PROJECT_COST_REPORT_DATA(PROJECT_NAME,AMOUNT) ";
                    strSQL = strSQL + "Select P.APPLICATION_NAME,SUM(A.COMP_VOUCHER_AMOUNT)Cost from [dbo].[ACC_COMPANY_VOUCHER] A  ";
                    strSQL = strSQL + "inner join [dbo].[A_M_LEDGER] l on A.LEDGER_NAME=l.LEDGER_NAME ";
                    strSQL = strSQL + "inner join [dbo].[A_M_LEDGERGROUP] lg on l.LEDGER_PARENT_GROUP=lg.GR_NAME ";
                    strSQL = strSQL + "Inner Join [dbo].[TBL_CUSTOMER_PROJECT] p on A.COMPANY_ID=p.PROJECT_CODE ";
                    strSQL = strSQL + " Where Lg.GR_PARENT='Expenses'  Group By P.APPLICATION_NAME  ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    ////--Purchase Quantity < From Date
                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,OPENING_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I   ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND M.PO_DATE < '" + strFdate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ///end Opening

                    //////--Purchase_QTY

                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,PURCHASE_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ////--Transfer_QTY
                    ///

                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,SALES_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT TBL_ITEM.ITEM_NAME,'' OLD_ITEM_ALIAS,TBL_PURCHASE_ORDER_DETAILS.QUANTITY,TBL_PURCHASE_ORDER_DETAILS.UNIT_PRICE ,('')POWER_CLASS,TBL_ITEM.PACK_SIZE FROM TBL_PURCHASE_ORDER_DETAILS,TBL_ITEM ";
                    //strSQL = strSQL + " WHERE TBL_PURCHASE_ORDER_DETAILS .ITEM_ID =TBL_ITEM.ITEM_ID   AND  TBL_PURCHASE_ORDER_DETAILS.VOUCHER_TYPE =35  ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();


                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,SALES_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =35 ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();


                    //////--Sales RETURN_QTY
                    ////strSQL = "INSERT INTO INV_STOCK_STATEMENT(STOCKGROUP_NAME,ITEM_NAME,STOCKITEM_ALIAS,RETURN_QTY,CLASS,PACK_SIZE) ";
                    ////strSQL = strSQL + "select s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,  abs(isnull(sum(t.INV_TRAN_QUANTITY),0)) as opn  ";
                    ////strSQL = strSQL + ",s.POWER_CLASS,s.STOCKCATEGORY_NAME from INV_STOCKITEM s,INV_TRAN t where s.STOCKITEM_NAME =t.STOCKITEM_NAME ";
                    ////strSQL = strSQL + "AND t.INV_DATE BETWEEN  " + Utility.cvtSQLDateString(strFdate) + " ";
                    ////strSQL = strSQL + "AND  " + Utility.cvtSQLDateString(strTDate) + " ";
                    ////strSQL = strSQL + " and t.INV_VOUCHER_TYPE = " + (int)Utility.VOUCHER_TYPE.vtSALES_RETURN + " ";
                    ////strSQL = strSQL + "AND t.BRANCH_ID='" + strBranchID + "' ";
                    ////if (strstring != "")
                    ////{
                    ////    strSQL = strSQL + "AND s.STOCKGROUP_NAME in (" + strstring + ") ";
                    ////}
                    ////if (strBranchID == "0001")
                    ////{
                    ////    strSQL = strSQL + "AND t.GODOWNS_NAME='Main Location' ";
                    ////}
                    ////strSQL = strSQL + " group by s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,s.POWER_CLASS,s.STOCKCATEGORY_NAME ";
                    ////cmdInsert.CommandText = strSQL;
                    ////cmdInsert.ExecuteNonQuery();
                }
                cmdInsert.Transaction.Commit();
                cmdInsert.CommandTimeout = 30;


                strSQL = "SELECT  PROJECT_NAME,SUM(AMOUNT)AMOUNT";
                strSQL = strSQL + " From TBL_PROJECT_COST_REPORT_DATA";

                strSQL = strSQL + " Group by PROJECT_NAME ";


                cmdInsert.CommandText = strSQL;
                cmdInsert.Connection = gcnMain;
                dr = cmdInsert.ExecuteReader();
                while (dr.Read())
                {
                    ProjectCostReportModel oLedg = new ProjectCostReportModel();
                    oLedg.PROJECT_NAME = dr["PROJECT_NAME"].ToString();
                    oLedg.AMOUNT = Convert.ToDouble(dr["AMOUNT"]);



                    ooAccLedger.Add(oLedg);
                }
                if (!dr.HasRows)
                {
                    ProjectCostReportModel oLedg = new ProjectCostReportModel();
                    oLedg.PROJECT_NAME = "";
                    oLedg.COST_HEAD = "";
                    oLedg.AMOUNT = 0;
                    ooAccLedger.Add(oLedg);
                }
                dr.Close();
                gcnMain.Close();

            }
            return ooAccLedger;
        }


        //#region "Purchase Return
        //public string mSavePurReturn(string strDeComID, string strRefNo, long mlngVType, string strDate, string strDueDate, string strMonthID, string strLedgerName, string strSalesLedger,
        //                             double dblNetAmount, double dblTotalAmount, double dblAddAmount, double dblLessAmount, string strRefType,
        //                             long lngAgstRef, long mlngIsInvEffinDirSalesInv, string strNarrations,
        //                             string strBranchId, string vstrGodownName, long mlngCashFlow, long mlngIsChqueCash, string DGSalesGrid,
        //                             string DGsalesOrder, string DGVector, string DGBillWise, string DGAddLess, bool blnMultiCurr, double mdblCurrRate, string mstrFCsymbol, bool blngNumberMethod, string strSalesRep)
        //{

        //    string strDRCR = "";
        //    string strBillKey, strItemName, strItemBangla, strAddLess, strBatchNo = "", strUOm, strPer, strGodownName, strBillAgnstKey = "", strPreRefNo = "", strBillTranKey = "", strGift = "", strbatch = "";
        //    double dblqty = 0, dblRate, dblBonusQty, dblAltWhere = 1, dblTotalCost = 1, dblCostPrice, dblCredit;
        //    long lngloop = 1, lngPosition = 1;
        //    bool blnMultiple = false;
        //    connstring = Utility.SQLConnstringComSwitch(strDeComID);

        //    using (SqlConnection gcnMain = new SqlConnection(connstring))
        //    {
        //        if (gcnMain.State == ConnectionState.Open)
        //        {
        //            gcnMain.Close();
        //        }

        //        try
        //        {
        //            gcnMain.Open();



        //            if (strRefType != Utility.gcEND_OF_LIST)
        //            {
        //                if (mlngVType == (int)Utility.VOUCHER_TYPE.vtSALES_RETURN)
        //                {
        //                    if (strRefType == "Sales Invoice")
        //                    {
        //                        lngAgstRef = (int)Utility.VOUCHER_TYPE.vtSALES_INVOICE;
        //                    }
        //                    else
        //                    {
        //                        lngAgstRef = (int)Utility.VOUCHER_TYPE.vtSALES_INVOICE_POS;
        //                    }
        //                }
        //                else if (mlngVType == (int)Utility.VOUCHER_TYPE.vtPURCHASE_RETURN)
        //                {
        //                    lngAgstRef = (int)Utility.VOUCHER_TYPE.vtPURCHASE_RETURN;
        //                }
        //            }
        //            else
        //            {
        //                lngAgstRef = 0;
        //            }
        //            if (strSalesRep == Utility.gcEND_OF_LIST)
        //            {
        //                strSalesRep = "";
        //            }

        //            SqlDataReader rsget;
        //            SqlCommand cmdInsert = new SqlCommand();
        //            SqlTransaction myTrans;
        //            myTrans = gcnMain.BeginTransaction();
        //            cmdInsert.Connection = gcnMain;
        //            cmdInsert.Transaction = myTrans;


        //            strSQL = Voucher.gInsertCompanyVoucher(strRefNo, mlngVType, strDate, strMonthID, strDueDate, strLedgerName, dblNetAmount, dblNetAmount, dblAddAmount, dblLessAmount, lngAgstRef, strNarrations,
        //                                                strBranchId, 0, "", strSalesRep, "", "", "", "", "");

        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();

        //            if (DGVector != "")
        //            {
        //                string[] words = DGVector.Split('~');
        //                foreach (string strVector in words)
        //                {
        //                    string[] ooCost = strVector.Split('|');
        //                    if (ooCost[0] != "")
        //                    {
        //                        strSQL = Voucher.mInsertVector(strRefNo, ooCost[1].ToString(), ooCost[2].ToString(), strDate, strLedgerName, "Cr", lngPosition, lngPosition, 1, ooCost[0].ToString(), Utility.Val(ooCost[3].ToString()), 0, "", mlngVType);
        //                        cmdInsert.CommandText = strSQL;
        //                        cmdInsert.ExecuteNonQuery();
        //                        if (mlngVType == (int)Utility.VOUCHER_TYPE.vtPURCHASE_RETURN)
        //                        {
        //                            strSQL = Voucher.mInsertVector(strRefNo, ooCost[1].ToString(), ooCost[2].ToString(), strDate, strLedgerName, "Cr", lngPosition, lngPosition, 2, ooCost[0].ToString(), Utility.Val(ooCost[3].ToString()), 0, "", mlngVType);
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                        else
        //                        {
        //                            strSQL = Voucher.mInsertVector(strRefNo, ooCost[1].ToString(), ooCost[2].ToString(), strDate, strLedgerName, "Dr", lngPosition, lngPosition, 2, ooCost[0].ToString(), Utility.Val(ooCost[3].ToString()), 0, "", mlngVType);
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                        lngPosition += 1;
        //                    }

        //                }
        //            }


        //            strSQL = Voucher.gInteractInvInsertMaster(strLedgerName, strRefNo, mlngVType, strDate, strBranchId, strNarrations);
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();

        //            if (DGBillWise != "")
        //            {
        //                int intbillpos = 1;
        //                string strAgstRefNo = "";
        //                string[] words = DGBillWise.Split('~');
        //                foreach (string strBill in words)
        //                {
        //                    string[] ooCost = strBill.Split('|');
        //                    if (ooCost[0] != "")
        //                    {
        //                        strAgstRefNo = strBranchId + ooCost[1].ToString();
        //                        strSQL = Voucher.gInsertBillWise(strBranchId, strRefNo, ooCost[2].ToString(), mlngVType, strLedgerName, intbillpos, ooCost[0].ToString(),
        //                                                            Utility.Val(ooCost[3].ToString()), ooCost[4].ToString(), strAgstRefNo, intbillpos);
        //                        cmdInsert.CommandText = strSQL;
        //                        cmdInsert.ExecuteNonQuery();
        //                        intbillpos += 1;
        //                    }
        //                }
        //                if (mlngVType == (long)(Utility.VOUCHER_TYPE.vtSALES_RETURN))
        //                {
        //                    strDRCR = "Cr";
        //                }
        //                else
        //                {
        //                    strDRCR = "Dr";
        //                }

        //                strSQL = Voucher.gInsertBillWise(strBranchId, strRefNo, strDate, mlngVType, strLedgerName, 0, "New Ref", dblNetAmount, strDRCR, Utility.Mid(strRefNo, 2, strRefNo.Length - 2), 0, strDueDate);
        //                cmdInsert.CommandText = strSQL;
        //                cmdInsert.ExecuteNonQuery();
        //            }
        //            else
        //            {
        //                if (mlngVType == (long)(Utility.VOUCHER_TYPE.vtSALES_RETURN))
        //                {
        //                    strDRCR = "Cr";
        //                }
        //                else
        //                {
        //                    strDRCR = "Dr";
        //                }

        //                strSQL = Voucher.gInsertBillWise(strBranchId, strRefNo, strDate, mlngVType, strLedgerName, 0, "New Ref", dblNetAmount, strDRCR, Utility.Mid(strRefNo, 2, strRefNo.Length - 2), 0, strDueDate);
        //                cmdInsert.CommandText = strSQL;
        //                cmdInsert.ExecuteNonQuery();
        //            }


        //            if (DGSalesGrid != "")
        //            {

        //                string[] words = DGSalesGrid.Split('~');
        //                foreach (string strSalesGrid in words)
        //                {
        //                    string[] ooCost = strSalesGrid.Split('|');
        //                    if (ooCost[0] != "")
        //                    {
        //                        strBillKey = strRefNo + lngloop.ToString().PadLeft(4, '0');
        //                        strItemName = ooCost[0].ToString();
        //                        strItemBangla = "";
        //                        //trItemDesc = ooCost[1].ToString();
        //                        strGodownName = vstrGodownName;
        //                        dblqty = Utility.Val(ooCost[1].ToString());
        //                        dblRate = Utility.Val(ooCost[2].ToString());
        //                        dblTotalAmount = Utility.Val(ooCost[4].ToString());
        //                        strUOm = ooCost[3].ToString();
        //                        strPer = ooCost[3].ToString();
        //                        dblBonusQty = Utility.Val(ooCost[5].ToString());
        //                        if (ooCost[6].ToString() != "")
        //                        {
        //                            strbatch = ooCost[6].ToString();
        //                        }
        //                        else
        //                        {
        //                            strbatch = "";
        //                        }
        //                        dblCostPrice = Utility.Val(ooCost[7].ToString());
        //                        strBillTranKey = ooCost[9].ToString();
        //                        strGift = "";
        //                        //dblBonusQty = 0;
        //                        strAddLess = "";
        //                        dblAltWhere = 1;
        //                        //If InStr(1, .TextMatrix(lngloop, 3), strPer) = 0 Then
        //                        //    dblAltWhere = gdblDenomation(Replace$(.TextMatrix(lngloop, 1), "'", "''"))
        //                        //End If
        //                        if (mlngVType == (long)(Utility.VOUCHER_TYPE.vtSALES_RETURN))
        //                        {
        //                            strDRCR = "Cr";
        //                        }
        //                        else
        //                        {
        //                            strDRCR = "Dr";
        //                        }
        //                        strSQL = Voucher.gInsertBillTran(strBillKey, strRefNo, mlngVType, strDate, strItemName, strGodownName, dblqty, dblBonusQty, strUOm, dblRate, dblTotalAmount, strAddLess,
        //                                                            0, dblTotalAmount, strDRCR, lngloop, strBranchId, Utility.gstrBaseCurrency, strPer, "", "", strbatch, "", "", strItemBangla);
        //                        cmdInsert.CommandText = strSQL;
        //                        cmdInsert.ExecuteNonQuery();

        //                        strSQL = Voucher.gInsertBillTranProcess(strRefNo + lngloop.ToString().PadLeft(4, '0'), strBranchId, lngloop, strRefNo, strRefNo, mlngVType, strDate,
        //                                                                strItemName, strGodownName, dblqty, strUOm, strRefNo + lngloop.ToString().PadLeft(4, '0'), 0, 0, strPer);
        //                        cmdInsert.CommandText = strSQL;
        //                        cmdInsert.ExecuteNonQuery();

        //                        if (strRefType != Utility.gcEND_OF_LIST)
        //                        {
        //                            strSQL = "SELECT COMP_REF_NO,BILL_TRAN_KEY,STOCKITEM_NAME,BILL_QUANTITY FROM ACC_BILL_TRAN ";
        //                            strSQL = strSQL + "WHERE BILL_TRAN_KEY = '" + strBillTranKey + "'";
        //                            cmdInsert.CommandText = strSQL;
        //                            rsget = cmdInsert.ExecuteReader();
        //                            if (rsget.Read())
        //                            {
        //                                strPreRefNo = rsget["COMP_REF_NO"].ToString();
        //                                strBillAgnstKey = rsget["BILL_TRAN_KEY"].ToString();
        //                            }
        //                            rsget.Close();
        //                            strSQL = Voucher.gInsertBillTranProcess(strBillKey, strBranchId, lngPosition, strRefNo, strPreRefNo, lngAgstRef, strDate, strItemName, strGodownName, dblqty * -1, strUOm, strBillAgnstKey, 0, 0, strPer);
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                        if (mlngVType == (long)(Utility.VOUCHER_TYPE.vtSALES_RETURN))
        //                        {
        //                            strSQL = Voucher.gInventoryInsertTranPurchases(strRefNo, strRefNo + lngloop.ToString().PadLeft(4, '0'), lngloop, dblCostPrice, dblqty * dblCostPrice, lngAgstRef, strItemName, strGodownName, "I", dblqty + dblBonusQty, mlngVType, strDate, strBranchId, strBatchNo, strPer, strUOm);
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                        else if (mlngVType == (long)(Utility.VOUCHER_TYPE.vtPURCHASE_RETURN))
        //                        {
        //                            strSQL = Voucher.gInventoryInsertPurchaseReturn(strRefNo, strBillKey, lngloop, Math.Round(dblRate, 2), -1 * dblTotalCost, lngAgstRef, strItemName, strGodownName,
        //                                                                           "O", dblqty * -1, dblBonusQty * -1, dblCostPrice, mlngVType, strDate, strBranchId, strbatch, 0, strPer, strUOm, 0, (int)mlngVType);
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                            strSQL = "UPDATE INV_TRAN SET ";
        //                            strSQL = strSQL + "OUTWARD_COST_AMOUNT = " + dblRate * dblqty * -1 + " ";
        //                            strSQL = strSQL + ",OUTWARD_SALES_AMOUNT = " + dblRate * dblqty * -1 + " ";
        //                            strSQL = strSQL + ",INV_TRAN_AMOUNT = " + dblRate * dblqty * -1 + " ";
        //                            strSQL = strSQL + "WHERE INV_TRAN_KEY='" + strBillKey + "' ";
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }

        //                    }
        //                    lngPosition += 1;
        //                    lngloop += 1;
        //                }
        //            }
        //            dblCredit = dblNetAmount;
        //            if (mlngVType == (int)Utility.VOUCHER_TYPE.vtSALES_RETURN)
        //            {
        //                if (mlngIsChqueCash == 0)
        //                {
        //                    strSQL = Voucher.gInsertSalesVoucher(strRefNo, strDate, 1, strLedgerName, "Cr", dblCredit, mlngVType, strSalesLedger, strBranchId, 0, "", "", "", "");
        //                    cmdInsert.CommandText = strSQL;
        //                    cmdInsert.ExecuteNonQuery();
        //                }
        //                else
        //                {
        //                    strSQL = Voucher.gInsertSalesVoucher(strRefNo, strDate, 1, strLedgerName, "Cr", dblCredit, mlngVType, strSalesLedger, strBranchId, 0, "", "", "", "");
        //                    cmdInsert.CommandText = strSQL;
        //                    cmdInsert.ExecuteNonQuery();
        //                }

        //                strSQL = Voucher.gInsertSalesVoucher(strRefNo, strDate, 2, strSalesLedger, "Dr", dblCredit, mlngVType, strLedgerName, strBranchId, 2, "", "", "", "", "", strbatch);
        //                cmdInsert.CommandText = strSQL;
        //                cmdInsert.ExecuteNonQuery();
        //            }
        //            else if (mlngVType == (int)Utility.VOUCHER_TYPE.vtPURCHASE_RETURN)
        //            {
        //                if (mlngIsChqueCash == 0)
        //                {
        //                    strSQL = Voucher.gInsertSalesVoucher(strRefNo, strDate, 1, strLedgerName, "Dr", dblCredit, mlngVType, strSalesLedger, strBranchId, 0, "", "", "", "");
        //                    cmdInsert.CommandText = strSQL;
        //                    cmdInsert.ExecuteNonQuery();
        //                }
        //                else
        //                {
        //                    strSQL = Voucher.gInsertSalesVoucher(strRefNo, strDate, 1, strLedgerName, "Dr", dblCredit, mlngVType, strSalesLedger, strBranchId, 0, "", "", "", "");
        //                    cmdInsert.CommandText = strSQL;
        //                    cmdInsert.ExecuteNonQuery();
        //                }

        //                strSQL = Voucher.gInsertSalesVoucher(strRefNo, strDate, 2, strSalesLedger, "Cr", dblCredit, mlngVType, strLedgerName, strBranchId, 2, "", "", "", "", "", strbatch);
        //                cmdInsert.CommandText = strSQL;
        //                cmdInsert.ExecuteNonQuery();
        //            }




        //            if (strRefType != Utility.gcEND_OF_LIST)
        //            {
        //                if (DGsalesOrder != "")
        //                {
        //                    string[] words1 = DGsalesOrder.Split('~');
        //                    foreach (string strSalesOrder in words1)
        //                    {
        //                        string[] ooCost1 = strSalesOrder.Split('|');
        //                        if (ooCost1[0] != "")
        //                        {
        //                            strSQL = "SELECT SUM(BILL_QUANTITY) AS QTY FROM ACC_BILL_TRAN_PROCESS ";
        //                            strSQL = strSQL + "WHERE AGST_COMP_REF_NO = '" + ooCost1[0] + "'";
        //                            cmdInsert.CommandText = strSQL;
        //                            rsget = cmdInsert.ExecuteReader();
        //                            if (rsget.Read())
        //                            {

        //                                if (Utility.Val(rsget["QTY"].ToString()) == 0)
        //                                {
        //                                    rsget.Close();
        //                                    strSQL = "UPDATE ACC_COMPANY_VOUCHER SET COMP_VOUCHER_STATUS = 1 ";
        //                                    strSQL = strSQL + "WHERE COMP_REF_NO = '" + ooCost1[0] + "'";
        //                                    cmdInsert.CommandText = strSQL;
        //                                    cmdInsert.ExecuteNonQuery();
        //                                }
        //                                else
        //                                {
        //                                    rsget.Close();
        //                                    strSQL = "UPDATE ACC_COMPANY_VOUCHER SET COMP_VOUCHER_STATUS = 0 ";
        //                                    strSQL = strSQL + "WHERE COMP_REF_NO = '" + ooCost1[0] + "'";
        //                                    cmdInsert.CommandText = strSQL;
        //                                    cmdInsert.ExecuteNonQuery();
        //                                }
        //                            }
        //                            else
        //                            {
        //                                rsget.Close();
        //                            }

        //                            strSQL = "INSERT INTO ACC_VOUCHER_JOIN(VOUCHER_JOIN_PRIMARY_REF,VOUCHER_JOIN_FOREIGN_REF,BRANCH_ID) ";
        //                            strSQL = strSQL + "VALUES(";
        //                            strSQL = strSQL + "'" + strRefNo + "','" + ooCost1[0] + "','" + strBranchId + "'";
        //                            strSQL = strSQL + ")";
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                    }

        //                }
        //            }




        //            if (DGAddLess != "")
        //            {
        //                string[] words1 = DGAddLess.Split('~');
        //                foreach (string ooassets in words1)
        //                {
        //                    string[] oAssets = ooassets.Split('|');
        //                    if (oAssets[0] != "")
        //                    {
        //                        strSQL = Voucher.gInsertADDLESS(strRefNo, oAssets[0], strDate, dblAddAmount, dblLessAmount, strBranchId);
        //                        cmdInsert.CommandText = strSQL;
        //                        cmdInsert.ExecuteNonQuery();

        //                        if (dblLessAmount > 0)
        //                        {
        //                            strSQL = Voucher.gInsertSalesVoucher(strRefNo, strDate, lngPosition, oAssets[0], "Dr", dblLessAmount, mlngVType, strSalesLedger, strBranchId, 0, "-", "", "", "");
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                            dblLessAmount = 0;
        //                        }
        //                        else
        //                        {
        //                            if (dblAddAmount != 0)
        //                            {
        //                                strSQL = Voucher.gInsertSalesVoucher(strRefNo, strDate, lngPosition, oAssets[0], "Cr", dblAddAmount, mlngVType, strLedgerName, strBranchId, 0, "+", "", "", "", "", strbatch);
        //                                cmdInsert.CommandText = strSQL;
        //                                cmdInsert.ExecuteNonQuery();
        //                            }
        //                            dblAddAmount = 0;
        //                        }
        //                    }

        //                }

        //            }

        //            if (blngNumberMethod == true)
        //            {
        //                strSQL = Voucher.gIncreaseVoucher((int)mlngVType);
        //                cmdInsert.CommandText = strSQL;
        //                cmdInsert.ExecuteNonQuery();
        //            }
        //            cmdInsert.Transaction.Commit();
        //            gcnMain.Close();
        //            return "Inserted...";

        //        }
        //        catch (Exception ex)
        //        {
        //            return (ex.ToString());
        //        }
        //        finally
        //        {
        //            gcnMain.Close();

        //        }
        //    }
        //}

        //public string mUpdatePurReturn(string strDeComID, string mstrRefNo, string strRefNo, long mlngVType, string strDate, string strDueDate, string strMonthID, string strLedgerName, string strSalesLedger,
        //                             double dblNetAmount, double dblTotalAmount, double dblAddAmount, double dblLessAmount, string strRefType,
        //                             long lngAgstRef, long mlngIsInvEffinDirSalesInv, string strNarrations,
        //                             string strBranchId, string vstrGodownName, long mlngCashFlow, long mlngIsChqueCash, string DGSalesGrid,
        //                             string DGsalesOrder, string DGVector, string DGBillWise, string DGAddLess, bool blnMultiCurr, double mdblCurrRate, string mstrFCsymbol, string strSalesRep)
        //{

        //    string strDRCR = "";
        //    string strBillKey, strItemName, strItemBangla, strAddLess, strBatchNo = "", strUOm, strPer, strGodownName, strBillAgnstKey = "", strPreRefNo = "", strBillTranKey = "", strGift = "", strbatch = "";
        //    double dblqty = 0, dblRate, dblBonusQty, dblTotalCost = 1, dblCostPrice, dblCredit, dblAltWhere = 1;
        //    long lngloop = 1, lngPosition = 1;
        //    connstring = Utility.SQLConnstringComSwitch(strDeComID);

        //    using (SqlConnection gcnMain = new SqlConnection(connstring))
        //    {
        //        if (gcnMain.State == ConnectionState.Open)
        //        {
        //            gcnMain.Close();
        //        }

        //        try
        //        {
        //            gcnMain.Open();



        //            if (strRefType != Utility.gcEND_OF_LIST)
        //            {
        //                if (mlngVType == (int)Utility.VOUCHER_TYPE.vtSALES_RETURN)
        //                {
        //                    if (strRefType == "Sales Invoice")
        //                    {
        //                        lngAgstRef = (int)Utility.VOUCHER_TYPE.vtSALES_INVOICE;
        //                    }
        //                    else
        //                    {
        //                        lngAgstRef = (int)Utility.VOUCHER_TYPE.vtSALES_INVOICE_POS;
        //                    }
        //                }
        //                else if (mlngVType == (int)Utility.VOUCHER_TYPE.vtPURCHASE_RETURN)
        //                {
        //                    lngAgstRef = (int)Utility.VOUCHER_TYPE.vtPURCHASE_RETURN;
        //                }
        //            }
        //            else
        //            {
        //                lngAgstRef = 0;
        //            }
        //            if (strSalesRep == Utility.gcEND_OF_LIST)
        //            {
        //                strSalesRep = "";
        //            }




        //            SqlDataReader rsget;
        //            SqlCommand cmdInsert = new SqlCommand();
        //            SqlTransaction myTrans;
        //            myTrans = gcnMain.BeginTransaction();
        //            cmdInsert.Connection = gcnMain;
        //            cmdInsert.Transaction = myTrans;


        //            //'All Delete Code Here
        //            strSQL = "DELETE FROM ACC_BILL_TRAN WHERE COMP_REF_NO = '" + mstrRefNo + "' ";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();
        //            strSQL = "DELETE FROM ACC_BILL_TRAN_PROCESS WHERE COMP_REF_NO = '" + mstrRefNo + "' ";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();
        //            strSQL = "DELETE FROM ACC_VOUCHER WHERE COMP_REF_NO = '" + mstrRefNo + "' ";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();

        //            strSQL = "DELETE FROM ACC_ADD_LESS WHERE ADD_LESS_COMP_REF_NO = '" + mstrRefNo + "'";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();
        //            strSQL = "DELETE FROM ACC_VOUCHER_JOIN WHERE VOUCHER_JOIN_PRIMARY_REF = '" + mstrRefNo + "'";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();

        //            strSQL = "DELETE FROM ACC_BILL_WISE WHERE COMP_REF_NO = '" + mstrRefNo + "'";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();
        //            //strSQL = "DELETE FROM INV_TRAN_HARDWARE_SL_REF WHERE COMP_REF_NO = '" + mstrRefNo + "' ";
        //            //cmdInsert.CommandText = strSQL;
        //            //cmdInsert.ExecuteNonQuery();


        //            strSQL = "DELETE FROM INV_TRAN WHERE INV_REF_NO = '" + mstrRefNo + "' ";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();

        //            strSQL = "DELETE FROM INV_MASTER WHERE INV_REF_NO = '" + mstrRefNo + "'";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();
        //            strSQL = "DELETE FROM VECTOR_TRANSACTION WHERE COMP_REF_NO = '" + mstrRefNo + "'";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();



        //            strSQL = "UPDATE ACC_COMPANY_VOUCHER SET ";
        //            strSQL = strSQL + "LEDGER_NAME = '" + strLedgerName + "',";
        //            strSQL = strSQL + "SALES_REP = '" + strSalesRep + "',";
        //            strSQL = strSQL + "BRANCH_ID = '" + strBranchId + "',";
        //            strSQL = strSQL + "COMP_VOUCHER_DATE = " + Utility.cvtSQLDateString(strDate) + ",";
        //            strSQL = strSQL + "COMP_VOUCHER_MONTH_ID = '" + strMonthID + "',";
        //            strSQL = strSQL + "COMP_VOUCHER_NARRATION = '" + strNarrations + "',";
        //            strSQL = strSQL + "COMP_VOUCHER_AMOUNT = " + dblTotalAmount + ",";
        //            strSQL = strSQL + "COMP_VOUCHER_NET_AMOUNT = " + dblNetAmount + ",";
        //            strSQL = strSQL + "COMP_VOUCHER_ADD_AMOUNT = " + dblAddAmount + ",";
        //            strSQL = strSQL + "COMP_VOUCHER_LESS_AMOUNT = " + dblLessAmount + ",";
        //            strSQL = strSQL + "COMP_VOUCHER_DUE_DATE = " + Utility.cvtSQLDateString(strDueDate) + ",";
        //            strSQL = strSQL + "INSERT_DATE = " + Utility.cvtSQLDateString(DateTime.Today.ToString("dd/MM/yyyy"));

        //            strSQL = strSQL + " WHERE COMP_REF_NO = '" + mstrRefNo + "'";
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();

        //            strSQL = Voucher.gInteractInvInsertMaster(strLedgerName, mstrRefNo, mlngVType, strDate, strBranchId, strNarrations);
        //            cmdInsert.CommandText = strSQL;
        //            cmdInsert.ExecuteNonQuery();

        //            if (DGSalesGrid != "")
        //            {

        //                string[] words = DGSalesGrid.Split('~');
        //                foreach (string strSalesGrid in words)
        //                {
        //                    string[] ooCost = strSalesGrid.Split('|');
        //                    if (ooCost[0] != "")
        //                    {
        //                        strBillKey = mstrRefNo + lngloop.ToString().PadLeft(4, '0');
        //                        strItemName = ooCost[0].ToString();
        //                        //dblCostPrice = Utility.gdblGetCostPrice(strItemName, strDate);
        //                        //strItemBangla = Utility.gGetItemNameBangla (ooCost[1].ToString());
        //                        strItemBangla = "";
        //                        //trItemDesc = ooCost[1].ToString();
        //                        strGodownName = vstrGodownName;
        //                        dblqty = Utility.Val(ooCost[1].ToString());
        //                        dblRate = Utility.Val(ooCost[2].ToString());
        //                        dblTotalAmount = Utility.Val(ooCost[4].ToString());
        //                        strUOm = ooCost[3].ToString();
        //                        strPer = ooCost[3].ToString();
        //                        dblBonusQty = Utility.Val(ooCost[5].ToString());
        //                        if (ooCost[6].ToString() != "")
        //                        {
        //                            strbatch = ooCost[6].ToString();
        //                        }
        //                        else
        //                        {
        //                            strbatch = "";
        //                        }
        //                        dblCostPrice = Utility.Val(ooCost[7].ToString());
        //                        strBillTranKey = ooCost[8].ToString();
        //                        strGift = ooCost[9].ToString();

        //                        strAddLess = "";
        //                        dblAltWhere = 1;
        //                        //If InStr(1, .TextMatrix(lngloop, 3), strPer) = 0 Then
        //                        //    dblAltWhere = gdblDenomation(Replace$(.TextMatrix(lngloop, 1), "'", "''"))
        //                        //End If
        //                        if (mlngVType == (long)(Utility.VOUCHER_TYPE.vtSALES_RETURN))
        //                        {
        //                            strDRCR = "Cr";
        //                        }
        //                        else
        //                        {
        //                            strDRCR = "Dr";
        //                        }
        //                        strSQL = Voucher.gInsertBillTran(strBillKey, mstrRefNo, mlngVType, strDate, strItemName, strGodownName, dblqty, dblBonusQty, strUOm, dblRate, dblTotalAmount, strAddLess,
        //                                                            0, dblTotalAmount, strDRCR, lngloop, strBranchId, Utility.gstrBaseCurrency, strPer, "", "", strbatch, "", "", strItemBangla);
        //                        cmdInsert.CommandText = strSQL;
        //                        cmdInsert.ExecuteNonQuery();

        //                        strSQL = Voucher.gInsertBillTranProcess(strBillKey, strBranchId, lngloop, mstrRefNo, strRefNo, mlngVType, strDate,
        //                                                                strItemName, strGodownName, dblqty, strUOm, strBillKey, 0, 0, strPer);
        //                        cmdInsert.CommandText = strSQL;
        //                        cmdInsert.ExecuteNonQuery();

        //                        if (strRefType != Utility.gcEND_OF_LIST)
        //                        {
        //                            strSQL = "SELECT COMP_REF_NO,BILL_TRAN_KEY,STOCKITEM_NAME,BILL_QUANTITY FROM ACC_BILL_TRAN ";
        //                            strSQL = strSQL + "WHERE BILL_TRAN_KEY = '" + strBillTranKey + "'";
        //                            cmdInsert.CommandText = strSQL;
        //                            rsget = cmdInsert.ExecuteReader();
        //                            if (rsget.Read())
        //                            {
        //                                strPreRefNo = rsget["COMP_REF_NO"].ToString();
        //                                strBillAgnstKey = rsget["BILL_TRAN_KEY"].ToString();
        //                            }
        //                            rsget.Close();
        //                            strSQL = Voucher.gInsertBillTranProcess(strBillKey, strBranchId, lngPosition, mstrRefNo, strPreRefNo, lngAgstRef, strDate, strItemName, strGodownName, dblqty * -1, strUOm, strBillAgnstKey, 0, 0, strPer);
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                        if (mlngVType == (long)(Utility.VOUCHER_TYPE.vtSALES_RETURN))
        //                        {
        //                            strSQL = Voucher.gInventoryInsertTranSales(mstrRefNo, strBillKey, lngloop, dblCostPrice, dblqty * dblCostPrice, lngAgstRef, strItemName, strGodownName, "I", dblqty + dblBonusQty, mlngVType, strDate, strBranchId, strBatchNo, strPer, strUOm);
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                        else if (mlngVType == (long)(Utility.VOUCHER_TYPE.vtPURCHASE_RETURN))
        //                        {
        //                            strSQL = Voucher.gInventoryInsertPurchaseReturn(mstrRefNo, strBillKey, lngloop, Math.Round(dblRate, 2), -1 * dblTotalCost, lngAgstRef, strItemName, strGodownName,
        //                                                                           "O", dblqty * -1, dblBonusQty * -1, dblCostPrice, mlngVType, strDate, strBranchId, strbatch, 0, strPer, strUOm, 0, (int)mlngVType);
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                            strSQL = "UPDATE INV_TRAN SET ";
        //                            strSQL = strSQL + "OUTWARD_COST_AMOUNT = " + dblRate * dblqty * -1 + " ";
        //                            strSQL = strSQL + ",OUTWARD_SALES_AMOUNT = " + dblRate * dblqty * -1 + " ";
        //                            strSQL = strSQL + ",INV_TRAN_AMOUNT = " + dblRate * dblqty * -1 + " ";
        //                            strSQL = strSQL + "WHERE INV_TRAN_KEY='" + strBillKey + "' ";
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }


        //                    }
        //                    lngPosition += 1;
        //                    lngloop += 1;
        //                }
        //            }
        //            dblCredit = dblNetAmount;
        //            if (mlngVType == (int)Utility.VOUCHER_TYPE.vtSALES_RETURN)
        //            {
        //                if (mlngIsChqueCash == 0)
        //                {
        //                    strSQL = Voucher.gInsertSalesVoucher(mstrRefNo, strDate, 1, strLedgerName, "Cr", dblCredit, mlngVType, strSalesLedger, strBranchId, 0, "", "", "", "");
        //                    cmdInsert.CommandText = strSQL;
        //                    cmdInsert.ExecuteNonQuery();
        //                }
        //                else
        //                {
        //                    strSQL = Voucher.gInsertSalesVoucher(mstrRefNo, strDate, 1, strLedgerName, "Cr", dblCredit, mlngVType, strSalesLedger, strBranchId, 0, "", "", "", "");
        //                    cmdInsert.CommandText = strSQL;
        //                    cmdInsert.ExecuteNonQuery();
        //                }

        //                strSQL = Voucher.gInsertSalesVoucher(mstrRefNo, strDate, 2, strSalesLedger, "Dr", dblCredit, mlngVType, strLedgerName, strBranchId, 2, "", "", "", "", "", strbatch);
        //                cmdInsert.CommandText = strSQL;
        //                cmdInsert.ExecuteNonQuery();
        //            }
        //            else if (mlngVType == (int)Utility.VOUCHER_TYPE.vtPURCHASE_RETURN)
        //            {
        //                if (mlngIsChqueCash == 0)
        //                {
        //                    strSQL = Voucher.gInsertSalesVoucher(mstrRefNo, strDate, 1, strLedgerName, "Dr", dblCredit, mlngVType, strSalesLedger, strBranchId, 0, "", "", "", "");
        //                    cmdInsert.CommandText = strSQL;
        //                    cmdInsert.ExecuteNonQuery();
        //                }
        //                else
        //                {
        //                    strSQL = Voucher.gInsertSalesVoucher(mstrRefNo, strDate, 1, strLedgerName, "Dr", dblCredit, mlngVType, strSalesLedger, strBranchId, 0, "", "", "", "");
        //                    cmdInsert.CommandText = strSQL;
        //                    cmdInsert.ExecuteNonQuery();
        //                }

        //                strSQL = Voucher.gInsertSalesVoucher(mstrRefNo, strDate, 2, strSalesLedger, "Cr", dblCredit, mlngVType, strLedgerName, strBranchId, 2, "", "", "", "", "", strbatch);
        //                cmdInsert.CommandText = strSQL;
        //                cmdInsert.ExecuteNonQuery();
        //            }




        //            if (strRefType != Utility.gcEND_OF_LIST)
        //            {
        //                if (DGsalesOrder != "")
        //                {
        //                    string[] words1 = DGsalesOrder.Split('~');
        //                    foreach (string strSalesOrder in words1)
        //                    {
        //                        string[] ooCost1 = strSalesOrder.Split('|');
        //                        if (ooCost1[0] != "")
        //                        {
        //                            strSQL = "SELECT SUM(BILL_QUANTITY) AS QTY FROM ACC_BILL_TRAN_PROCESS ";
        //                            strSQL = strSQL + "WHERE AGST_COMP_REF_NO = '" + ooCost1[0] + "'";
        //                            cmdInsert.CommandText = strSQL;
        //                            rsget = cmdInsert.ExecuteReader();
        //                            if (rsget.Read())
        //                            {

        //                                if (Utility.Val(rsget["QTY"].ToString()) == 0)
        //                                {
        //                                    rsget.Close();
        //                                    strSQL = "UPDATE ACC_COMPANY_VOUCHER SET COMP_VOUCHER_STATUS = 1 ";
        //                                    strSQL = strSQL + "WHERE COMP_REF_NO = '" + ooCost1[0] + "'";
        //                                    cmdInsert.CommandText = strSQL;
        //                                    cmdInsert.ExecuteNonQuery();
        //                                }
        //                                else
        //                                {
        //                                    rsget.Close();
        //                                    strSQL = "UPDATE ACC_COMPANY_VOUCHER SET COMP_VOUCHER_STATUS = 0 ";
        //                                    strSQL = strSQL + "WHERE COMP_REF_NO = '" + ooCost1[0] + "'";
        //                                    cmdInsert.CommandText = strSQL;
        //                                    cmdInsert.ExecuteNonQuery();
        //                                }
        //                            }
        //                            else
        //                            {
        //                                rsget.Close();
        //                            }

        //                            strSQL = "INSERT INTO ACC_VOUCHER_JOIN(VOUCHER_JOIN_PRIMARY_REF,VOUCHER_JOIN_FOREIGN_REF,BRANCH_ID) ";
        //                            strSQL = strSQL + "VALUES(";
        //                            strSQL = strSQL + "'" + mstrRefNo + "','" + ooCost1[0] + "','" + strBranchId + "'";
        //                            strSQL = strSQL + ")";
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                    }

        //                }
        //            }




        //            if (DGAddLess != "")
        //            {
        //                string[] words1 = DGAddLess.Split('~');
        //                foreach (string ooassets in words1)
        //                {
        //                    string[] oAssets = ooassets.Split('|');
        //                    if (oAssets[0] != "")
        //                    {
        //                        strSQL = Voucher.gInsertADDLESS(mstrRefNo, oAssets[0], strDate, dblAddAmount, dblLessAmount, strBranchId);
        //                        cmdInsert.CommandText = strSQL;
        //                        cmdInsert.ExecuteNonQuery();

        //                        if (dblLessAmount > 0)
        //                        {
        //                            strSQL = Voucher.gInsertSalesVoucher(mstrRefNo, strDate, lngPosition, oAssets[0], "Dr", dblLessAmount, mlngVType, strSalesLedger, strBranchId, 0, "-", "", "", "");
        //                            cmdInsert.CommandText = strSQL;
        //                            cmdInsert.ExecuteNonQuery();
        //                            dblLessAmount = 0;
        //                        }
        //                        else
        //                        {
        //                            if (dblAddAmount != 0)
        //                            {
        //                                strSQL = Voucher.gInsertSalesVoucher(mstrRefNo, strDate, lngPosition, oAssets[0], "Cr", dblAddAmount, mlngVType, strLedgerName, strBranchId, 0, "+", "", "", "", "", strbatch);
        //                                cmdInsert.CommandText = strSQL;
        //                                cmdInsert.ExecuteNonQuery();
        //                            }
        //                            dblAddAmount = 0;
        //                        }
        //                    }

        //                }

        //            }

        //            //if (DGAddLess != "")
        //            //{

        //            //    strSQL = Voucher.gInsertADDLESS(strRefNo, strLedgerName, strDate, dblAddAmount, dblLessAmount, strBranchId);
        //            //    cmdInsert.CommandText = strSQL;
        //            //    cmdInsert.ExecuteNonQuery();
        //            //}
        //            //}
        //            cmdInsert.Transaction.Commit();
        //            gcnMain.Close();
        //            return "Updated...";

        //        }
        //        catch (Exception ex)
        //        {
        //            return (ex.ToString());
        //        }
        //        finally
        //        {
        //            gcnMain.Close();

        //        }
        //    }
        //}
        //#endregion
        #endregion


        #endregion
    }

}
