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
    public class StockService
    {
        protected readonly ApplicationDbContex _dbContext;
        public StockService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        public StockModel AddStock(StockModel stock)
        {
            StockModel stockModel = new StockModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<StockModel>("SP_STOCK_INSERT_STOCK",
                        this.SetParametersStock(stock), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return stockModel;
        }
        public DynamicParameters SetParametersStock(StockModel stock)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@PO_NO", stock.PO_NO);
            parameters.Add("@TRANSECTION_DATE", stock.TRANSECTION_DATE);
            parameters.Add("@DESCRIPTION", stock.DESCRIPTION);
            parameters.Add("@CUSTOMER_SUPPLIER_ID", stock.CUSTOMER_SUPPLIER_ID);
            parameters.Add("@DOCUMENTS_NO", stock.DOCUMENTS_NO);
            parameters.Add("@DOCUMENT_DATE", stock.DOCUMENT_DATE);
            parameters.Add("@INVOICE_NO", stock.INVOICE_NO);
            parameters.Add("@INVOICE_DATE", stock.INVOICE_DATE);
            parameters.Add("@GATE_PASS_NO", stock.GATE_PASS_NO);
            parameters.Add("@DELIVERY_NOTE_NO", stock.DELIVERY_NOTE_NO);
            parameters.Add("@BATCH_NO", stock.BATCH_NO);
            parameters.Add("@EXPIRY_DATE", stock.EXPIRY_DATE);
            parameters.Add("@GOOD_RECEIVE_NOTE", stock.GOOD_RECEIVE_NOTE);
            parameters.Add("@WAREHOUSE_ID", stock.WAREHOUSE_ID);
            parameters.Add("@REMARKS", stock.REMARKS);
            parameters.Add("@RECEIVE_BY", stock.RECEIVE_BY);






            return parameters;
        }

        internal List<ProjectWiseStockModel> GetProjectwiseStock()
        {
            List<ProjectWiseStockModel> stockList = new List<ProjectWiseStockModel>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<ProjectWiseStockModel>("SP_GET_PROJECT_WISE_STOCK_LIST");
                if (poModel.Count() > 0)
                {
                    stockList = poModel.ToList();
                }
            }
            return stockList;
        }

        internal int GetPurchaseOrderId(string po_No)
        {
            int orderId = 0;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var POID = connection.Query<int>("SELECT STOCK_ID FROM TBL_STOCK WHERE PO_NO='" + po_No + "'");
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
        internal List<Stock_Details_Model> AddStockDetails(List<Stock_Details_Model> purchaseOrderDetails)
        {
            List<Stock_Details_Model> _opurchaseOrderDetails = new List<Stock_Details_Model>();
            try
            {
                if (purchaseOrderDetails.Count > 0)
                {
                    foreach (var requisitionDetails in purchaseOrderDetails)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<Stock_Details_Model>("SP_STOCK_INSERT_STOCK_DETAILS",
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
        internal List<Stock_Details_Model> AddStockSummery(List<Stock_Details_Model> purchaseOrderDetails)
        {
            List<Stock_Details_Model> _opurchaseOrderDetails = new List<Stock_Details_Model>();
            Stock_Details_Model sdm = new Stock_Details_Model();
            try
            {
                if (purchaseOrderDetails.Count > 0)
                {
                    foreach (var requisitionDetails in purchaseOrderDetails)
                    {
                        //GetRows(requisitionDetails.ITEM_ID);
                        if (GetRows(requisitionDetails.ITEM_ID) != true)
                        {
                            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                            {
                                if (connection.State == ConnectionState.Closed) connection.Open();


                                //int itemId=SqlHelper.ExecuteReader(Global.ConnectionString, "SELECT * FROM TBL_STOCK_SUMMERY")

                                //var summery = connection.Query<Stock_Details_Model>("SELECT * FROM  TBL_STOCK_SUMMERY WHERE ITEM_ID=" + requisitionDetails.ITEM_ID + "");

                                //requisitionDetails.STOCK_IN_QUANTITY= summery.STOCK_IN_QUANTITY+ requisitionDetails.STOCK_IN_QUANTITY

                                requisitionDetails.TOTAL_VALUE = requisitionDetails.STOCK_IN_QUANTITY * requisitionDetails.UNIT_PRICE;

                                var _oproductcategory = connection.Query<Stock_Details_Model>("SP_STOCK_INSERT_STOCK_SUMMERY",
                                    this.SetParametersStockSummery(requisitionDetails), commandType: CommandType.StoredProcedure);
                            }
                        }
                        else
                        {
                            IDataReader dr = null;
                            dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "SELECT * FROM  TBL_STOCK_SUMMERY WHERE ITEM_ID=" + requisitionDetails.ITEM_ID + "");
                            while (dr.Read())
                            {
                                sdm.ITEM_ID = Convert.ToInt32(dr["ITEM_ID"].ToString());
                                sdm.STOCK_IN_QUANTITY = Convert.ToDouble(dr["STOCK_IN_QUANTITY"].ToString());
                                sdm.TOTAL_VALUE = Convert.ToDouble(dr["TOTAL_VALUE"].ToString());
                            }

                            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                            {
                                if (connection.State == ConnectionState.Closed) connection.Open();
                                requisitionDetails.STOCK_IN_QUANTITY = sdm.STOCK_IN_QUANTITY + requisitionDetails.STOCK_IN_QUANTITY;
                                requisitionDetails.TOTAL_VALUE = sdm.TOTAL_VALUE + (requisitionDetails.STOCK_IN_QUANTITY * requisitionDetails.UNIT_PRICE);

                                var _oproductcategory = connection.Query<Stock_Details_Model>("SP_STOCK_UPDATE_STOCK_SUMMERY",
                                    this.SetParametersStockSummery(requisitionDetails), commandType: CommandType.StoredProcedure);
                            }
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseOrderDetails;
        }
        public DynamicParameters SetParametersStockSummery(Stock_Details_Model purchaseOrderDetails)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@ITEM_ID", purchaseOrderDetails.ITEM_ID);
            parameters.Add("@UOM", purchaseOrderDetails.UOM);
            parameters.Add("@PACK_SIZE", purchaseOrderDetails.PACK_SIZE);
            parameters.Add("@UNIT_PRICE", purchaseOrderDetails.UNIT_PRICE);
            parameters.Add("@STOCK_IN_QUANTITY", purchaseOrderDetails.STOCK_IN_QUANTITY);
            parameters.Add("@BALANCE", purchaseOrderDetails.BALANCE);
            parameters.Add("@WAREHOUSE_ID", purchaseOrderDetails.WAREHOUSE_ID);
            parameters.Add("@TOTAL_VALUE", purchaseOrderDetails.TOTAL_VALUE);
            parameters.Add("@REMARKS", purchaseOrderDetails.REMARKS);

            return parameters;
        }
        public DynamicParameters SetParametersOrderDetails(Stock_Details_Model purchaseOrderDetails)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@STOCK_ID", purchaseOrderDetails.STOCK_ID);
            parameters.Add("@ITEM_ID", purchaseOrderDetails.ITEM_ID);
            parameters.Add("@PACK_SIZE", purchaseOrderDetails.PACK_SIZE);
            parameters.Add("@UOM", purchaseOrderDetails.UOM);
            parameters.Add("@STOCK_IN_QUANTITY", purchaseOrderDetails.STOCK_IN_QUANTITY);
            parameters.Add("@UNIT_PRICE", purchaseOrderDetails.UNIT_PRICE);



            return parameters;
        }
        private bool GetRows(int itemId)
        {
            bool flag = false;
            IDataReader DR = null;
            DR = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "SELECT * FROM TBL_STOCK_SUMMERY WHERE ITEM_ID=" + itemId + "");
            while (DR.Read())
            {
                flag = true;
            }
            return flag;
        }
        public List<StockModel> GetStockStatement()
        {
            List<StockModel> stockList = new List<StockModel>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<StockModel>("SP_STOCK_GET_STOCK_IN_OUT_STATEMENT");
                if (poModel.Count() > 0)
                {
                    stockList = poModel.ToList();
                }
            }
            return stockList;
        }

        public List<StockSummeryReportModel> GetStockSummery()
        {
            List<StockSummeryReportModel> stockList = new List<StockSummeryReportModel>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<StockSummeryReportModel>("SP_STOCK_CREATE_STOCK_SUMMERY");
                if (poModel.Count() > 0)
                {
                    stockList = poModel.ToList();
                }
            }
            return stockList;
        }
        public List<StockSummeryReportModel> GetStockSummaryForProject()
        {
            List<StockSummeryReportModel> stockList = new List<StockSummeryReportModel>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<StockSummeryReportModel>("SP_STOCK_SUMMERYFOR_PROJECT");
                if (poModel.Count() > 0)
                {
                    stockList = poModel.ToList();
                }
            }
            return stockList;
        }

        public List<RStockInformation> mGetStockSummery()
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
               
                if (intMode == 1)
                {
                    strSQL = "DELETE FROM TBL_STOCK_SUMMERY ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    ////---OPening
                    ////--ItemOpe_QTY
                    //strSQL = "INSERT INTO TBL_STOCK_SUMMERY(ITEM_NAME,STOCKITEM_ALIAS,OPENING_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT TBL_ITEM.ITEM_NAME,'' OLD_ITEM_ALIAS,TBL_PURCHASE_ORDER_DETAILS.QUANTITY,TBL_PURCHASE_ORDER_DETAILS.UNIT_PRICE ,('')POWER_CLASS,TBL_ITEM.PACK_SIZE FROM TBL_PURCHASE_ORDER_DETAILS,TBL_ITEM ";
                    //strSQL = strSQL + " WHERE TBL_PURCHASE_ORDER_DETAILS .ITEM_ID =TBL_ITEM.ITEM_ID   AND  TBL_PURCHASE_ORDER_DETAILS.VOUCHER_TYPE =0  ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    ////--Purchase Quantity < From Date
                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(ITEM_NAME,STOCKITEM_ALIAS,OPENING_QTY,PURCHASE_RATE,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.QUANTITY,D.UNIT_PRICE,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I   ";
                    //strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    //strSQL = strSQL + "AND M.PO_DATE < '" + strFdate + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();
                    /////end Opening

                    //////--Purchase_QTY

                    strSQL = "INSERT INTO TBL_STOCK_SUMMERY(ITEM_NAME,STOCK_IN_QUANTITY,STOCK_OUT_QUANTITY,UNIT_PRICE) ";
                    strSQL = strSQL + "SELECT I.ITEM_NAME,abs(isnull(sum(D.QUANTITY),0)),'0',D.UNIT_PRICE  ";
                    strSQL = strSQL + "FROM  TBL_PURCHASE_ORDER M,TBL_PURCHASE_ORDER_DETAILS D,TBL_ITEM I  ";
                    strSQL = strSQL + " WHERE M.PO_NUMBER_LONG_CODE=D.PO_NUMBER_LONG_CODE  AND  D .ITEM_ID =I.ITEM_ID AND  D.VOUCHER_TYPE =34  ";
                    strSQL = strSQL + " group by s.STOCKGROUP_NAME,s.STOCKITEM_NAME,s.OLD_ITEM_ALIAS,s.POWER_CLASS,s.STOCKCATEGORY_NAME  ";
                    //strSQL = strSQL + "AND Convert(datetime,M.PO_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //////--SALES_QTY
                    //strSQL = "INSERT INTO INV_STOCK_STATEMENT(STOCKGROUP_NAME,ITEM_NAME,STOCKITEM_ALIAS,SALES_QTY,CLASS,PACK_SIZE) ";
                    //strSQL = strSQL + "SELECT C.CATEGORY_NAME,I.ITEM_NAME,'' OLD_ITEM_ALIAS,D.SALES_QUANTITY ,('')POWER_CLASS,I.PACK_SIZE  ";
                    //strSQL = strSQL + "FROM TBL_SALES_ORDER M,TBL_SALES_ORDER_DETAILS D,TBL_ITEM I,TBL_ITEM_CATEGORY C   ";
                    //strSQL = strSQL + " WHERE M.SALES_ORDER_NO=D.SALES_ORDER_NO  AND  D .ITEM_ID =I.ITEM_ID AND I.CATEGORY_ID=C.CATEGORY_ID  ";
                    //strSQL = strSQL + "AND Convert(datetime,M.DELIVERY_DATE,103)  BETWEEN '" + strFdate + "' And '" + strTDate + "' ";
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


                strSQL = "SELECT  ITEM_NAME,STOCK_IN_QUANTITY,STOCK_OUT_QUANTITY,UNIT_PRICE";
                strSQL = strSQL + " from TBL_STOCK_SUMMERY";

                strSQL = strSQL + " ORDER by ITEM_NAME ";


                cmdInsert.CommandText = strSQL;
                cmdInsert.Connection = gcnMain;
                dr = cmdInsert.ExecuteReader();
                while (dr.Read())
                {
                    RStockInformation oLedg = new RStockInformation();
                    //oLedg.strGroupName = dr["STOCKGROUP_NAME"].ToString();
                    oLedg.strItemName = dr["ITEM_NAME"].ToString();
                    //oLedg.strItemAlias = dr["STOCKITEM_ALIAS"].ToString();
                    oLedg.dblOpnQty = Convert.ToDouble(dr["STOCK_IN_QUANTITY"]);
                    if (dr["STOCK_OUT_QUANTITY"] != null)
                    { oLedg.purchaseQty = Math.Abs(Convert.ToDouble(dr["STOCK_OUT_QUANTITY"])); }
                    oLedg.salesQty = Math.Abs(Convert.ToDouble(dr["UNIT_PRICE"]));
                    //oLedg.dblSampleQty = Math.Abs(Convert.ToDouble(dr["SAMPLE_QTY"]));
                    //oLedg.dblReturnQty = Math.Abs(Convert.ToDouble(dr["RETURN_QTY"]));
                    //oLedg.dblConvertQty = Math.Abs((Convert.ToDouble(dr["CONVERT_QTY"])));
                    //oLedg.dblBroken = Math.Abs((Convert.ToDouble(dr["BROKEN_QTY"])));
                    //oLedg.dblPhyStockQty = (Convert.ToDouble(dr["PHY_STOCK_QTY"]));
                    //oLedg.dblPhyStockQtyOut = (Convert.ToDouble(dr["PHY_STOCK_QTY_OUT"]));
                    //oLedg.dblTranserOutQty = Math.Abs(Convert.ToDouble(dr["STOCK_TRANSFER_QTY"]));
                    //oLedg.dblStockTranserQty = Math.Abs(Convert.ToDouble(dr["STOCK_TRANSFER_IN_QTY"]));
                    //oLedg.dblConsumptionQty = Math.Abs(Convert.ToDouble(dr["CONSUMPTION_QTY"]));
                    //if (dr["CLASS"].ToString() != "")
                    //{
                    //    oLedg.strClass = dr["CLASS"].ToString();
                    //}
                    //else
                    //{
                    //    oLedg.strClass = "";
                    //}
                    //if (dr["PACK_SIZE"].ToString() != "")
                    //{
                    //    oLedg.strPackSize = dr["PACK_SIZE"].ToString();
                    //}
                    //else
                    //{
                    //    oLedg.strPackSize = "";
                    //}

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
    }
}
        


