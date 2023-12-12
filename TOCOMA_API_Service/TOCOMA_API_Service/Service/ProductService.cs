using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;

namespace TOCOMA_API_Service.Service
{
    public class ProductService
    {
        protected readonly ApplicationDbContex _dbContext;
        private PurchaseService pservice;
        string strSQL;
        public ProductService(ApplicationDbContex _db, PurchaseService opurcheseService)
        {
            _dbContext = _db;
            pservice = opurcheseService;
        }
        
        
        ItemEntity _oItem = new ItemEntity();
        internal List<ItemViewModel> GetItemList()
        {
            List<ItemViewModel> itemList = new List<ItemViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<ItemViewModel>("SP_ITEM_GETALL_ITEM");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        itemList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return itemList;
        }
        internal List<ItemViewModel> GetProjectItemList()
        {
            List<ItemViewModel> itemList = new List<ItemViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<ItemViewModel>("SP_ITEM_GETALL_PROJECT_ITEM");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        itemList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return itemList;
        }
        public bool GetIsItemExist(string itemcode)
        {
            bool flag = false;
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                connection.Open();
                var oproductgroup = connection.Query<ItemEntity>("SELECT * FROM TBL_ITEM WHERE ITEM_CODE='" + itemcode + "'");
                if (oproductgroup != null && oproductgroup.Count() > 0)
                {
                    flag = true;
                }
            }
            return flag;
        }
        internal ItemEntity AddItem(ItemEntity item)
        {
            _oItem = new ItemEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<ItemEntity>("SP_PRODUCT_INSERT_PRODUCT",
                            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                }
                _oItem.Status = true;
                //using (IDbConnection connection = new SqlConnection(Global.SOC_ConnectionString))
                //{
                //    if (connection.State == ConnectionState.Closed) connection.Open();
                //    var _oproductcategory = connection.Query<ItemEntity>("SP_PRODUCT_INSERT_PRODUCT",
                //            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                //}
                //using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                //{
                //    if (connection.State == ConnectionState.Closed) connection.Open();
                //    SqlCommand command = connection.CreateCommand();
                //    SqlDataReader dr;

                //    using (SqlTransaction transaction = connection.BeginTransaction())
                //    {
                //        try
                //        {
                //            command.Transaction = transaction;

                //            string strRefNo = "";
                //            string poNo = pservice.GetPurchaseOrderNo();
                //            strRefNo = "OP" + poNo;
                //            long lngStockStatus = 0, lngloop = 1;
                //            int vtSTOCK_OPENING = 0;


                //            //-------------
                //            //strSQL = "INSERT INTO TBL_ITEM(";
                //            //strSQL = strSQL + "ITEM_NAME,CATEGORY_ID,SUBCATEGORY_ID,SHORT_DESCRIPTION,LONG_DESCRIPTION) ";


                //            //strSQL = strSQL + "VALUES(";
                //            //strSQL = strSQL + "'" + poNo + "' ";
                //            //strSQL = strSQL + ",'" + strRefNo + "' ";
                //            //strSQL = strSQL + ",'" + vtSTOCK_OPENING + "' ";
                //            //strSQL = strSQL + ",'" + System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year + "' ";
                //            //strSQL = strSQL + "," + item.STOCKITEM_OPENING_VALUE + " ";

                //            //strSQL = strSQL + ")";
                //            //command.CommandText = strSQL;
                //            //command.ExecuteNonQuery();
                //            //-----------
                //            strSQL = "INSERT INTO TBL_PURCHASE_ORDER(";
                //            strSQL = strSQL + "PO_NUMBER_LONG_CODE,COMP_REF_NO,VOUCHER_TYPE,PO_DATE,GRAND_TOTAL) ";


                //            strSQL = strSQL + "VALUES(";
                //            strSQL = strSQL + "'" + poNo + "' ";
                //            strSQL = strSQL + ",'" + strRefNo + "' ";
                //            strSQL = strSQL + ",'" + vtSTOCK_OPENING + "' ";
                //            strSQL = strSQL + ",'" + System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year + "' ";
                //            strSQL = strSQL + "," + item.STOCKITEM_OPENING_VALUE + " ";

                //            strSQL = strSQL + ")";
                //            command.CommandText = strSQL;
                //            command.ExecuteNonQuery();

                //            int poId = 0;

                //            strSQL = "SELECT ";
                //            strSQL = strSQL + "PO_ID ";
                //            strSQL = strSQL + "FROM TBL_PURCHASE_ORDER ";
                //            strSQL = strSQL + "WHERE PO_NUMBER_LONG_CODE='" + poNo + "' ";

                //            command.CommandText = strSQL;
                //            dr = command.ExecuteReader();
                //            if (dr.Read())
                //            {
                //                poId = Convert.ToInt32(dr["PO_ID"].ToString());

                //            }
                //            dr.Close();
                //            int itemId = 0;
                //            string itemName;


                //            strSQL = "INSERT INTO TBL_PURCHASE_ORDER_DETAILS";
                //            strSQL = strSQL + "(PO_ID,PO_NUMBER_LONG_CODE,COMP_REF_NO,VOUCHER_TYPE,ITEM_ID,QUANTITY,UNIT_PRICE,UNIT_TOTAL";

                //            strSQL = strSQL + ") VALUES(";
                //            strSQL = strSQL + "'" + poId + "'";
                //            strSQL = strSQL + ",'" + poNo + "'";
                //            strSQL = strSQL + ",'" + strRefNo + "' ";
                //            strSQL = strSQL + ",'" + vtSTOCK_OPENING + "' ";
                //            strSQL = strSQL + ",'" + item.ITEM_ID + "' ";
                //            strSQL = strSQL + ",'" + item.STOCKITEM_OPENING_BALANCE + "' ";
                //            strSQL = strSQL + ", " + item.STOCKITEM_OPENING_RATE + " ";
                //            strSQL = strSQL + ",'" + item.STOCKITEM_OPENING_VALUE + "' ";
                //            strSQL = strSQL + ")";
                //            command.CommandText = strSQL;
                //            command.ExecuteNonQuery();
                //            lngloop += 1;

                //            transaction.Commit();
                //        }
                //        catch (Exception ex)
                //        {

                //        }
                //    }
                //}

            }
            catch (Exception Ex)
            {

            }


            return _oItem;
        }
        //internal ItemEntity AddItem(ItemEntity item)
        //{
        //    _oItem = new ItemEntity();
        //    try
        //    {
        //        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
        //        {
        //            if (connection.State == ConnectionState.Closed) connection.Open();
        //            //var _oproductcategory = connection.Query<ItemEntity>("SP_PRODUCT_INSERT_PRODUCT",
        //            //        this.SetParameters(item), commandType: CommandType.StoredProcedure);
        //        }
        //        using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
        //        {
        //            if (connection.State == ConnectionState.Closed) connection.Open();
        //            SqlCommand command = connection.CreateCommand();
        //            SqlDataReader dr;
                    
        //            using (SqlTransaction transaction = connection.BeginTransaction())
        //            {
        //                try
        //                {
        //                    command.Transaction = transaction;
                            
        //                    string strRefNo = "";
        //                    string poNo = pservice.GetPurchaseOrderNo();
        //                    strRefNo ="OP" + poNo;
        //                    long lngStockStatus = 0, lngloop = 1;
        //                    int vtSTOCK_OPENING = 0;
        //                    //-----------
        //                    strSQL = "INSERT INTO TBL_PURCHASE_ORDER(";
        //                    strSQL = strSQL + "PO_NUMBER_LONG_CODE,COMP_REF_NO,VOUCHER_TYPE,PO_DATE,GRAND_TOTAL) ";
                            
                            
        //                    strSQL = strSQL + "VALUES(";
        //                    strSQL = strSQL + "'" + poNo + "' ";                            
        //                    strSQL = strSQL + ",'" + strRefNo + "' ";
        //                    strSQL = strSQL + ",'" + vtSTOCK_OPENING + "' ";
        //                    strSQL = strSQL + ",'" + System.DateTime.Now.Day+"/"+System.DateTime.Now.Month+"/"+System.DateTime.Now.Year + "' ";
        //                    strSQL = strSQL + "," + item.STOCKITEM_OPENING_VALUE + " ";

        //                    strSQL = strSQL + ")";
        //                    command.CommandText = strSQL;
        //                    command.ExecuteNonQuery();

        //                    int poId = 0;

        //                    strSQL = "SELECT ";
        //                    strSQL = strSQL + "PO_ID ";
        //                    strSQL = strSQL + "FROM TBL_PURCHASE_ORDER ";
        //                    strSQL = strSQL + "WHERE PO_NUMBER_LONG_CODE='" + poNo + "' ";

        //                    command.CommandText = strSQL;
        //                    dr = command.ExecuteReader();
        //                    if (dr.Read())
        //                    {
        //                        poId = Convert.ToInt32(dr["PO_ID"].ToString());

        //                    }
        //                    dr.Close();
        //                    int itemId = 0;
        //                    string itemName;


        //                    strSQL = "INSERT INTO TBL_PURCHASE_ORDER_DETAILS";
        //                    strSQL = strSQL + "(PO_ID,PO_NUMBER_LONG_CODE,COMP_REF_NO,VOUCHER_TYPE,ITEM_ID,QUANTITY,UNIT_PRICE,UNIT_TOTAL";

        //                    strSQL = strSQL + ") VALUES(";
        //                    strSQL = strSQL + "'" + poId + "'";
        //                    strSQL = strSQL + ",'" + poNo + "'";
        //                    strSQL = strSQL + ",'" + strRefNo + "' ";
        //                    strSQL = strSQL + ",'" + vtSTOCK_OPENING + "' ";
        //                    strSQL = strSQL + ",'" + item.ITEM_ID + "' ";
        //                    strSQL = strSQL + ",'" + item.STOCKITEM_OPENING_BALANCE + "' ";
        //                    strSQL = strSQL + ", " + item.STOCKITEM_OPENING_RATE + " ";
        //                    strSQL = strSQL + ",'" + item.STOCKITEM_OPENING_VALUE + "' ";
        //                    strSQL = strSQL + ")";
        //                    command.CommandText = strSQL;
        //                    command.ExecuteNonQuery();
        //                    lngloop += 1;

        //                    transaction.Commit();
        //                }
        //                catch(Exception ex)
        //                {

        //                }
        //            }
        //        }
            
        //    }
        //    catch (Exception Ex)
        //    {

        //    }


        //    return _oItem;
        //}
        internal ItemEntity EditItem(ItemEntity item)
        {
            _oItem = new ItemEntity();
            try
            {
                //using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                //{
                //    if (connection.State == ConnectionState.Closed) connection.Open();
                //    var _oproductcategory = connection.Query<ItemEntity>("SP_PRODUCT_UPDATE_PRODUCT",
                //            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                //}
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    strSQL = "UPDATE TBL_ITEM SET ITEM_NAME = '" + item.ITEM_NAME + "', ";
                    strSQL = strSQL + "CATEGORY_ID = '" + item.CATEGORY_ID + "',";
                    strSQL = strSQL + "MODEL = '" + item.MODEL + "',";
                    strSQL = strSQL + "SHORT_DESCRIPTION = '" + item.SHORT_DESCRIPTION + "',";
                    strSQL = strSQL + "LONG_DESCRIPTION = '" + item.LONG_DESCRIPTION + "', ";
                    strSQL = strSQL + "APPLICATION_AREA = '" + item.APPLICATION_AREA + "',";
                    strSQL = strSQL + "DOSAGE = '" + item.DOSAGE + "',";
                    strSQL = strSQL + "COVERAGE_CONSUMPTION = '" + item.COVERAGE_CONSUMPTION + "', ";
                    strSQL = strSQL + "MAID_IN_COUNTRY = '" + item.MAID_IN_COUNTRY + "', ";
                    strSQL = strSQL + "IMPORT_FROM = '" + item.IMPORT_FROM + "', ";
                    strSQL = strSQL + "BRAND_NAME = '" + item.BRAND_NAME + "', ";
                    strSQL = strSQL + "BRAND_ORIGIN_COUNTRY = '" + item.BRAND_ORIGIN_COUNTRY + "', ";
                    strSQL = strSQL + "ITEM_KEYWORD = '" + item.ITEM_KEYWORD + "', ";
                    strSQL = strSQL + "SHELF_LIFE = '" + item.SHELF_LIFE + "', ";
                    strSQL = strSQL + "ITEM_PRICE = '" + item.ITEM_PRICE + "', ";
                    strSQL = strSQL + "UNIT_ID = '" + item.UNIT_ID + "', ";
                    strSQL = strSQL + "ITEM_BATCH_NO = '" + item.ITEM_BATCH_NO + "', ";
                    strSQL = strSQL + "COLOR_ID = '" + item.COLOR_ID + "', ";
                    strSQL = strSQL + "PACK_SIZE = '" + item.PACK_SIZE + "', ";
                    strSQL = strSQL + "ITEM_IMAGE = '" + item.ITEM_IMAGE + "', ";
                    strSQL = strSQL + "ITEM_SPECIALTY = '" + item.ITEM_SPECIALTY + "', ";
                    strSQL = strSQL + "ITEM_TYPE = '" + item.ITEM_TYPE + "', ";
                    strSQL = strSQL + "SEWSTIVENESS = '" + item.SEWSTIVENESS + "' ";
                    strSQL = strSQL + "WHERE ITEM_CODE = '" + item.ITEM_CODE+ "' ";

                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();



                    transaction.Commit();

                    _oItem.Status = true;
                }
            }
            catch (Exception Ex)
            {
                _oItem.msg = Ex.Message + strSQL;
            }


            return _oItem;
        }
        public DynamicParameters SetParameters(ItemEntity item)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ITEM_ID", item.ITEM_ID);  
            parameters.Add("@ITEM_CODE", item.ITEM_CODE);              
            parameters.Add("@ITEM_NAME", item.ITEM_NAME);
            parameters.Add("@MODEL", item.MODEL);
            parameters.Add("@CATEGORY_ID", item.CATEGORY_ID);
            parameters.Add("@SUBCATEGORY_ID", item.SUBCATEGORY_ID);            
            parameters.Add("@LONG_DESCRIPTION", item.LONG_DESCRIPTION);
            parameters.Add("@APPLICATION_AREA", item.APPLICATION_AREA);
            parameters.Add("@ITEM_IMAGE", item.ITEM_IMAGE);
            parameters.Add("@DOSAGE", item.DOSAGE);
            parameters.Add("@COVERAGE_CONSUMPTION", item.COVERAGE_CONSUMPTION);
            parameters.Add("@MAID_IN_COUNTRY", item.MAID_IN_COUNTRY);
            parameters.Add("@IMPORT_FROM", item.IMPORT_FROM);
            parameters.Add("@BRAND_NAME", item.BRAND_NAME);
            parameters.Add("@BRAND_ORIGIN_COUNTRY", item.BRAND_ORIGIN_COUNTRY);
            parameters.Add("@ITEM_KEYWORD", item.ITEM_KEYWORD);                  
            parameters.Add("@SHELF_LIFE", item.SHELF_LIFE);
            parameters.Add("@ITEM_BATCH_NO", item.ITEM_BATCH_NO);
            parameters.Add("@ITEM_PRICE", item.ITEM_PRICE);
            parameters.Add("@ITEM_PURCHASE_PRICE", item.ITEM_PURCHASE_PRICE);
            parameters.Add("@ITEM_SALE_PRICE", item.ITEM_SALE_PRICE);
            parameters.Add("@VENDOR_ID", item.VENDOR_ID);
            parameters.Add("@UNIT_ID", item.UNIT_ID);
            parameters.Add("@COLOR_ID", item.COLOR_ID);
            parameters.Add("@PACK_SIZE", item.PACK_SIZE);
            parameters.Add("@ITEM_SPECIALTY", item.ITEM_SPECIALTY);
            parameters.Add("@TYPE_OF_INVENTORY", item.TYPE_OF_INVENTORY);
            parameters.Add("@SEWSTIVENESS", item.SEWSTIVENESS);
            parameters.Add("@ITEM_FORM_APPEARANCE", item.ITEM_FORM_APPEARANCE);
            parameters.Add("@STOCKITEM_OPENING_BALANCE", item.STOCKITEM_OPENING_BALANCE);
            parameters.Add("@STOCKITEM_OPENING_RATE", item.STOCKITEM_OPENING_RATE);            
            parameters.Add("@STOCKITEM_OPENING_VALUE", item.STOCKITEM_OPENING_VALUE);
            parameters.Add("@BUSINESS_ID", item.BUSINESS_ID);
            parameters.Add("@OperationType", item.OperationType);

            return parameters;
        }
        public ItemEntity GetItemNameByItem(string itemName)
        {
            ItemEntity item = new ItemEntity();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ITEMNAME", itemName, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<ItemEntity>("SP_PRODUCT_GET_PRODUCT_BY_NAME", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        item = oproductgroup.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return item;

        }
        public ItemViewModel GetItemDetailsByItemCode(string itemCode)
        {
            ItemViewModel itemdetails = new ItemViewModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ITEM_CODE", itemCode, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<ItemViewModel>("SP_PRODUCT_GET_PRODUCT_BY_CODE", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        itemdetails = oproductgroup.FirstOrDefault();
                        var ritem= connection.Query<ItemEntity>("SELECT * FROM TBL_ITEM WHERE ITEM_ID IN ('"+ itemdetails.RELATED_ITEMS + "')");
                        itemdetails.relateditemList = ritem.ToList();
                    }
                    
                }
            }
            catch (Exception EX)
            {

            }
            return itemdetails;

        }

        internal string GetProductCode()
        {
            string code = "";
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var PID = connection.Query<string>("SP_SEQUENCE_GENERATE_ITEM_CODE");
                    if (PID != null && PID.Count() > 0)
                    {
                        code = PID.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return code;
        }
    }
}
