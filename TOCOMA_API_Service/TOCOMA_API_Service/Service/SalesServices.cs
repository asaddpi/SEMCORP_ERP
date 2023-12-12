using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace TOCOMA_API_Service.Service
{
    public class SalesServices
    {
        protected readonly ApplicationDbContex _dbContext;
        public SalesServices(ApplicationDbContex _db)
        {
            _dbContext = _db;
            string strSQL;
        }
        internal SalesQuotationModel AddSalesQuotation(SalesQuotationModel item)
        {
            SalesQuotationModel _oItem = new SalesQuotationModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<SalesQuotationModel>("SP_SALES_INSERT_SALES_QUOTATION",
                            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                }


                string strSQL;
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
                            foreach (var voucheritem in item.chartList)
                            {
                                strSQL = "INSERT INTO TBL_SALES_QUOTATION_AMOUNT_DETAILS";
                                strSQL = strSQL + "(QUOTATION_NO,ITEM_NAME,PARCHENT,AMOUNT";

                                strSQL = strSQL + ") VALUES(";
                                strSQL = strSQL + " '" + item.QUOTATION_NO+ "'";
                                strSQL = strSQL + ",'" + voucheritem.ITEM_NAME + "'";                                
                                strSQL = strSQL + ", " + voucheritem.PARCHENT + " ";
                                strSQL = strSQL + ",'" + voucheritem.AMOUNT + "' ";
                                strSQL = strSQL + ")";
                                command.CommandText = strSQL;
                                command.ExecuteNonQuery();

                            }
                            command.Transaction = transaction;
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }

            }
            catch (Exception Ex)
            {

            }


            return _oItem;
        }
        internal SalesQuotationModel UpdateSalesQuotation(SalesQuotationModel item)
        {
            SalesQuotationModel _oItem = new SalesQuotationModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<SalesQuotationModel>("SP_SALES_UPDATE_SALES_QUOTATION",
                            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }


            return _oItem;
        }
        public DynamicParameters SetParameters(SalesQuotationModel salesQuotation)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@QUOTATION_TYPE", salesQuotation.QUOTATION_TYPE);
            parameters.Add("@QUOTATION_NO", salesQuotation.QUOTATION_NO);
            parameters.Add("@QUOTATION_DATE", salesQuotation.QUOTATION_DATE);
            parameters.Add("@VALID_UP_TO_DATE", salesQuotation.VALID_UP_TO_DATE);
            parameters.Add("@INCOTERM", salesQuotation.INCOTERM);
            parameters.Add("@SHIP_VIA", salesQuotation.SHIP_VIA);
            parameters.Add("@SALES_PERSON", salesQuotation.SALES_PERSON);
            parameters.Add("@PHONE_NO", salesQuotation.PHONE_NO);
            parameters.Add("@PAYMENT_TERMS", salesQuotation.PAYMENT_TERMS);
            parameters.Add("@EXPECTED_DELIVERY_DATE", salesQuotation.EXPECTED_DELIVERY_DATE);
            parameters.Add("@INQUERY_DATE", salesQuotation.INQUERY_DATE);
            parameters.Add("@CUSTOMER_ID", salesQuotation.CUSTOMER_ID);
            parameters.Add("@WORKING_METHOD", salesQuotation.WORKING_METHOD);
            parameters.Add("@USED_PRODUCT", salesQuotation.USED_PRODUCT);
            parameters.Add("@TERMS_AND_CONDITION", salesQuotation.TERMS_AND_CONDITION);
            parameters.Add("@UNTAXABLE_AMOUNT", salesQuotation.UNTAXABLE_AMOUNT);
            parameters.Add("@MOBILIZATION_COST", salesQuotation.MOBILIZATION_COST);
            parameters.Add("@TAX_RATE", salesQuotation.TAX_RATE);
            parameters.Add("@TAX_AMOUNT", salesQuotation.TAX_AMOUNT);
            parameters.Add("@VAT_RATE", salesQuotation.VAT_RATE);
            parameters.Add("@VAT_AMOUNT", salesQuotation.VAT_AMOUNT);
            parameters.Add("@OTHER_COST", salesQuotation.OTHER_COST);
            parameters.Add("@DISCOUNT_RATE", salesQuotation.DISCOUNT_RATE);
            parameters.Add("@DISCOUNT_AMOUNT", salesQuotation.DISCOUNT_AMOUNT);
            parameters.Add("@IN_WORD", salesQuotation.IN_WORD);
            parameters.Add("@SALES_TOTAL", salesQuotation.SALES_TOTAL);
            parameters.Add("@STATUS", salesQuotation.STATUS);
            parameters.Add("@REG_BY", salesQuotation.REG_BY);


            return parameters;
        }
        public int GetSalesQuotationId(string quotationNo)
        {
            int Id = 0;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var qId = connection.Query<int>("SELECT SALES_QUOTATION_ID FROM TBL_SALES_QUOTATION WHERE QUOTATION_NO='" + quotationNo + "'");
                    if (qId != null && qId.Count() > 0)
                    {
                        Id = qId.FirstOrDefault();
                    }
                }
            }
            catch (Exception Ex)
            {

            }

            return Id;
        }
        internal List<SalesItemDetailsModel> AddSalesQuotationDetails(List<SalesItemDetailsModel> salesItems)
        {
            List<SalesItemDetailsModel> _opurchaseRequisitionDetails = new List<SalesItemDetailsModel>();
            try
            {
                if (salesItems.Count > 0)
                {
                    foreach (var requisitionDetails in salesItems)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<SalesItemDetailsModel>("SP_SALES_INSERT_SALES_QUOTATION_ITEM_DETAILS",
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
        internal List<SalesItemDetailsModel> UpdateSalesQuotationDetails(List<SalesItemDetailsModel> salesItems)
        {
            List<SalesItemDetailsModel> _opurchaseRequisitionDetails = new List<SalesItemDetailsModel>();
            try
            {
                if (salesItems.Count > 0)
                {
                    foreach (var requisitionDetails in salesItems)
                    {
                        using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                        {

                            bool isExist = false;
                            IDataReader dr = null;
                            string strSQL;
                            dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "Select SALES_QUOTATION_DETAILS_ID From TBL_SALES_QUOTATION_DETAILS WHERE SALES_QUOTATION_DETAILS_ID=" + requisitionDetails.SALES_QUOTATION_DETAILS_ID + "");
                            while (dr.Read())
                            {
                                isExist = true;
                            }
                            if (isExist == true)
                            {

                                //if (connection.State == ConnectionState.Open)
                                //{
                                //    connection.Close();
                                //}
                                //connection.Open();
                                //SqlCommand cmdInsert = new SqlCommand();
                                //SqlTransaction myTrans;
                                //myTrans = connection.BeginTransaction();
                                //cmdInsert.Connection = connection;
                                //cmdInsert.Transaction = myTrans;

                                //strSQL = "UPDATE TBL_SALES_QUOTATION_DETAILS SET ETA_TL_WH_1st_DATE='" + sales.ETA_TL_WH_1st_DATE + "',";
                                //strSQL = strSQL + "ETA_TL_WH_2nd_DATE='" + sales.ETA_TL_WH_2nd_DATE + "', ";
                                //strSQL = strSQL + "ETA_TL_WH_3rd_DATE='" + sales.ETA_TL_WH_3rd_DATE + "', ";
                                //strSQL = strSQL + "EXPECTED_DELIVERY_1st_DATE='" + sales.EXPECTED_DELIVERY_1st_DATE + "', ";
                                //strSQL = strSQL + "EXPECTED_DELIVERY_2nd_DATE='" + sales.EXPECTED_DELIVERY_2nd_DATE + "', ";
                                //strSQL = strSQL + "EXPECTED_DELIVERY_3rd_DATE='" + sales.EXPECTED_DELIVERY_3rd_DATE + "', ";
                                //strSQL = strSQL + "PARCHENTAGE_OF_COMPLETE='" + sales.PARCHENTAGE_OF_COMPLETE + "', ";
                                //strSQL = strSQL + "STATUS_OF_SHIPMENT='" + sales.STATUS_OF_SHIPMENT + "' ";

                                //strSQL = strSQL + "WHERE SALES_ID = " + sales.SALES_ID + "";
                                //cmdInsert.CommandText = strSQL;
                                //cmdInsert.ExecuteNonQuery();
                                //cmdInsert.Transaction.Commit();

                                //parameters.Add("@SALES_QUOTATION_ID", salesItems.SALES_QUOTATION_ID);
                                //parameters.Add("@QUOTATION_NO", salesItems.QUOTATION_NO);
                                //parameters.Add("@ITEM_ID", salesItems.ITEM_ID);
                                //parameters.Add("@ITEM_DESCRIPTION", salesItems.ITEM_DESCRIPTION);
                                //parameters.Add("@ORDER_QUANTITY", salesItems.ORDER_QUANTITY);
                                //parameters.Add("@UOM", salesItems.UOM);
                                //parameters.Add("@PACK_SIZE", salesItems.PACK_SIZE);
                                //parameters.Add("@UNIT_PRICE", salesItems.UNIT_PRICE);
                                //parameters.Add("@AIT", salesItems.AIT);
                                //parameters.Add("@VAT", salesItems.VAT);
                                //parameters.Add("@TOTAL_PRICE", salesItems.TOTAL_PRICE);

                                if (connection.State == ConnectionState.Closed) connection.Open();
                                var _oproductcategory = connection.Query<SalesItemDetailsModel>("SP_SALES_UPDATE_SALES_QUOTATION_ITEM_DETAILS",
                                    this.SetParametersRequisitionDetails(requisitionDetails), commandType: CommandType.StoredProcedure);
                            }
                            else if (isExist == false)
                            {
                                if (connection.State == ConnectionState.Closed) connection.Open();
                                var _oproductcategory = connection.Query<SalesItemDetailsModel>("SP_SALES_INSERT_SALES_QUOTATION_ITEM_DETAILS",
                                    this.SetParametersRequisitionDetails(requisitionDetails), commandType: CommandType.StoredProcedure);
                            }

                        }


                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }



        public DynamicParameters SetParametersRequisitionDetails(SalesItemDetailsModel salesItems)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SALES_QUOTATION_DETAILS_ID", salesItems.SALES_QUOTATION_DETAILS_ID);
            parameters.Add("@SALES_QUOTATION_ID", salesItems.SALES_QUOTATION_ID);
            parameters.Add("@QUOTATION_NO", salesItems.QUOTATION_NO);
            parameters.Add("@SERVICE_CODE", salesItems.SERVICE_CODE);
            parameters.Add("@SERVICE_NAME", salesItems.SERVICE_NAME);
            parameters.Add("@ITEM_DESCRIPTION", salesItems.ITEM_DESCRIPTION);
            parameters.Add("@ORDER_QUANTITY", salesItems.ORDER_QUANTITY);
            parameters.Add("@UOM", salesItems.UOM);
            parameters.Add("@PACK_SIZE", salesItems.PACK_SIZE);
            parameters.Add("@UNIT_PRICE", salesItems.UNIT_PRICE);
            parameters.Add("@AIT", salesItems.AIT);
            parameters.Add("@VAT", salesItems.VAT);
            parameters.Add("@TOTAL_PRICE", salesItems.TOTAL_PRICE);

            return parameters;
        }

        internal PurchaseOrderModel AddPurchase(PurchaseOrderModel purchase)
        {
            PurchaseOrderModel payment = new PurchaseOrderModel();
            string strSQL;
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


                        //-----------
                        strSQL = "INSERT INTO TBL_PURCHASE_ORDER(";
                        strSQL = strSQL + "PO_NUMBER_LONG_CODE,REQUISITION_NO,COMP_REF_NO,LEDGER_NAME,PO_DATE,QUOTATION_REFERANCE_NO,QUOTATION_REFERANCE_DATE,TRUNSECTION_TYPE,VENDOR_ID,CONSIGNEE_ID,TERMS_OF_DELIVERY,SHIPPING_ADDRESS,DELIVERY_MODE ";//COMP_VOUCHER_DUE_DATE,,AUTOJV
                        strSQL = strSQL + ",PAYMENT_TERM,PAYMENT_MODE,INCOTERM,CURRENCY,SHIP_VIA,CONTAINER_SIZE,DELIVERY_TIME,COUNTRY_OF_ORIGIN,IMPORT_FROM,PORT_OF_LOADING,PORT_OF_DISCHARGE,CARRING_WAY_NAME,CARRING_WAY_COST ";
                        strSQL = strSQL + ",GRAND_TOTAL,SHIPPING_MARK,PACKAGING,IDENTIFICATION_NUMBER,PACKAGING_INSTRUCTION,OTHER_TERMS_AND_CONDITION)";
                        strSQL = strSQL + "VALUES(";
                        strSQL = strSQL + "'" + purchase.PO_NUMBER_LONG_CODE + "' ";
                        strSQL = strSQL + ",'" + purchase.REQUISITION_NO + "' ";
                        strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "' ";
                        strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.LEDGER_NAME.Trim() + "' ";
                        strSQL = strSQL + ",'" + purchase.PO_DATE + "' ";
                        strSQL = strSQL + "," + purchase.QUOTATION_REFERANCE_NO + " ";
                        strSQL = strSQL + ",'" + purchase.QUOTATION_REFERANCE_DATE + "' ";
                        strSQL = strSQL + ",'" + purchase.TRUNSECTION_TYPE + " ' ";
                        strSQL = strSQL + "," + purchase.VENDOR_ID + " ";
                        strSQL = strSQL + "," + purchase.CONSIGNEE_ID + " ";
                        strSQL = strSQL + ",'" + purchase.TERMS_OF_DELIVERY + "' ";
                        strSQL = strSQL + ",'" + purchase.SHIPPING_ADDRESS + "' ";
                        strSQL = strSQL + ",'" + purchase.DELIVERY_MODE + "' ";
                        strSQL = strSQL + ",'" + purchase.PAYMENT_TERM + "' ";
                        strSQL = strSQL + ",'" + purchase.PAYMENT_MODE + "' ";
                        strSQL = strSQL + ",'" + purchase.INCOTERM + "' ";
                        strSQL = strSQL + ",'" + purchase.CURRENCY_NAME + "' ";
                        strSQL = strSQL + ",'" + purchase.SHIP_VIA + "' ";
                        strSQL = strSQL + ",'" + purchase.CONTAINER_SIZE + "' ";
                        strSQL = strSQL + ",'" + purchase.DELIVERY_TIME + "' ";
                        strSQL = strSQL + ",'" + purchase.COUNTRY_OF_ORIGIN + "' ";
                        strSQL = strSQL + ",'" + purchase.IMPORT_FROM + "' ";
                        strSQL = strSQL + ",'" + purchase.PORT_OF_LOADING + "' ";
                        strSQL = strSQL + ",'" + purchase.PORT_OF_DISCHARGE + "' ";
                        strSQL = strSQL + ",'" + purchase.CARRING_WAY_NAME + "' ";
                        strSQL = strSQL + ",'" + purchase.CARRING_WAY_COST + "' ";
                        strSQL = strSQL + ",'" + purchase.GRAND_TOTAL + "' ";
                        strSQL = strSQL + ",'" + purchase.SHIPPING_MARK + "' ";
                        strSQL = strSQL + ",'" + purchase.PACKAGING + "' ";
                        strSQL = strSQL + ",'" + purchase.IDENTIFICATION_NUMBER + "' ";
                        strSQL = strSQL + ",'" + purchase.PACKAGING_INSTRUCTION + "' ";
                        strSQL = strSQL + ",'" + purchase.OTHER_TERMS_AND_CONDITION + "' ";


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
                            //strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                            strSQL = "INSERT INTO TBL_PURCHASE_ORDER_DETAILS";
                            strSQL = strSQL + "(PO_ID,PO_NUMBER_LONG_CODE,COMP_REF_NO,BILL_TRAN_KEY,ITEM_ID,QUANTITY,UNIT_PRICE,UNIT_TOTAL";

                            strSQL = strSQL + ") VALUES(";
                            strSQL = strSQL + "'" + poId + "'";
                            strSQL = strSQL + ",'" + purchase.PO_NUMBER_LONG_CODE + "'";
                            strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "'";
                            strSQL = strSQL + ",'" + strChildKey + "'";
                            strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "' ";
                            strSQL = strSQL + ",'" + voucheritem.QUANTITY + "' ";
                            strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                            strSQL = strSQL + ",'" + voucheritem.TOTAL_AMOUNT + "' ";
                            strSQL = strSQL + ")";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();
                            itemId = 0;
                        }
                        command.Transaction = transaction;
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

        //---Insert Sales Order

        internal SalesOrderModel AddSalesOrder(SalesOrderModel purchase)
        {
            SalesOrderModel payment = new SalesOrderModel();
            string strSQL;
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
                        //strSQL = strSQL + "COMP_REF_NO,BRANCH_ID,LEDGER_NAME,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,COMP_VOUCHER_MONTH_ID ";
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
                        //    strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,VOUCHER_CHEQUE_NUMBER,VOUCHER_CHEQUE_DATE,VOUCHER_CHEQUE_DRAWN_ON "; 
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
                        //strSQL = "INSERT INTO TBL_SALES_ORDER(";
                        //strSQL = strSQL + "SALES_ORDER_NO,PO_WO_NUMBER,PO_WO_DATE,COMP_REF_NO,LEDGER_NAME,VOUCHER_TYPE,SALES_ORDER_RECEIVED_DATE,ORDER_RECEIVED_BY,CUSTOMER_ID,ASSIGN_TO,TOTAL_AMOUNT,DISCOUNT_IN_PARCHENT,DISCOUNT_IN_TAKA,ADVANCE_PAID_IN_PARCHENT,ADVANCE_PAID_IN_TAKA ";//COMP_VOUCHER_DUE_DATE,,AUTOJV
                        //strSQL = strSQL + ",DELIVERY_CHARGE,OTHERS_CHARGE,GRAND_TOTAL,REG_BY,UPD_BY,QUOTATION_NO,DELIVERY_NOTE_NO,TERMS_AND_CONDITION) ";
                        //strSQL = strSQL + "VALUES(";
                        //strSQL = strSQL + "'" + purchase.SALES_ORDER_NO + "' ";
                        //strSQL = strSQL + ",'" + purchase.PO_WO_NUMBER + "' ";
                        //strSQL = strSQL + ",'" + purchase.PO_WO_DATE + "' ";
                        //strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "' ";
                        //strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.LEDGER_NAME.Trim() + "' ";
                        //strSQL = strSQL + ",'" + purchase.VOUCHER_TYPE + "' ";
                        //strSQL = strSQL + "," + purchase.SALES_ORDER_RECEIVED_DATE + " ";
                        //strSQL = strSQL + ",'" + purchase.ORDER_RECEIVED_BY + "' ";
                        //strSQL = strSQL + ",'" + purchase.CUSTOMER_ID + "' ";
                        //strSQL = strSQL + ",'" + purchase.ASSIGN_TO + "' ";
                        //strSQL = strSQL + ",'" + purchase.TOTAL_AMOUNT + "' ";
                        //strSQL = strSQL + ",'" + purchase.DISCOUNT_IN_PARCHENT + "' ";
                        //strSQL = strSQL + ",'" + purchase.DISCOUNT_IN_TAKA + "' ";
                        //strSQL = strSQL + ",'" + purchase.ADVANCE_PAID_IN_PARCHENT + "' ";
                        //strSQL = strSQL + ",'" + purchase.ADVANCE_PAID_IN_TAKA + "' ";
                        //strSQL = strSQL + ",'" + purchase.DELIVERY_CHARGE + "' ";
                        //strSQL = strSQL + ",'" + purchase.OTHERS_CHARGE + "' ";
                        //strSQL = strSQL + ",'" + purchase.GRAND_TOTAL + "' ";
                        //strSQL = strSQL + ",'" + purchase.REG_BY + "' ";
                        //strSQL = strSQL + ",'" + purchase.UPD_BY + "' ";
                        //strSQL = strSQL + ",'" + purchase.QUOTATION_NO + "' ";
                        //strSQL = strSQL + ",'" + purchase.DELIVERY_NOTE_NO + "' ";
                        //strSQL = strSQL + ",'" + purchase.TERMS_AND_CONDITION + "' ";
                        //strSQL = strSQL + ")";
                        //command.CommandText = strSQL;
                        //command.ExecuteNonQuery();

                        strSQL = "INSERT INTO TBL_SALES_ORDER(";
                        strSQL = strSQL + "SALES_ORDER_NO,PO_WO_NUMBER,PO_WO_DATE,COMP_REF_NO,LEDGER_NAME ";
                        strSQL = strSQL + ",VOUCHER_TYPE,SALES_ORDER_RECEIVED_DATE,ORDER_RECEIVED_BY,CUSTOMER_ID,CUSTOMER_PROJECT_ID,ASSIGN_TO ";
                        strSQL = strSQL + ",TOTAL_AMOUNT,DISCOUNT_IN_PARCHENT,DISCOUNT_IN_TAKA,ADVANCE_PAID_IN_PARCHENT,ADVANCE_PAID_IN_TAKA ";
                        strSQL = strSQL + ",DELIVERY_CHARGE,OTHERS_CHARGE,GRAND_TOTAL,REG_BY,UPD_BY,QUOTATION_NO,DELIVERY_NOTE_NO,TERMS_AND_CONDITION) ";

                        strSQL = strSQL + "VALUES(";
                        strSQL = strSQL + "'" + purchase.SALES_ORDER_NO + "' ";
                        strSQL = strSQL + ",'" + purchase.PO_WO_NUMBER + "' ";
                        strSQL = strSQL + ",'" + purchase.PO_WO_DATE + "' ";
                        strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "' ";
                        strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.LEDGER_NAME.Trim() + "' ";
                        strSQL = strSQL + ",'" + purchase.VOUCHER_TYPE + "' ";
                        strSQL = strSQL + "," + purchase.SALES_ORDER_RECEIVED_DATE + " ";
                        strSQL = strSQL + ",'" + purchase.ORDER_RECEIVED_BY + "' ";
                        strSQL = strSQL + ",'" + purchase.CUSTOMER_ID + "' ";
                        strSQL = strSQL + ",'" + purchase.CUSTOMER_PROJECT_ID + "' ";
                        strSQL = strSQL + ",'" + purchase.ASSIGN_TO + "' ";
                        strSQL = strSQL + ",'" + purchase.TOTAL_AMOUNT + "' ";
                        strSQL = strSQL + ",'" + purchase.DISCOUNT_IN_PARCHENT + "' ";
                        strSQL = strSQL + ",'" + purchase.DISCOUNT_IN_TAKA + "' ";
                        strSQL = strSQL + ",'" + purchase.ADVANCE_PAID_IN_PARCHENT + "' ";
                        strSQL = strSQL + ",'" + purchase.ADVANCE_PAID_IN_TAKA + "' ";
                        strSQL = strSQL + ",'" + purchase.DELIVERY_CHARGE + "' ";
                        strSQL = strSQL + ",'" + purchase.OTHERS_CHARGE + "' ";
                        strSQL = strSQL + ",'" + purchase.GRAND_TOTAL + "' ";
                        strSQL = strSQL + ",'" + purchase.REG_BY + "' ";
                        strSQL = strSQL + ",'" + purchase.UPD_BY + "' ";
                        strSQL = strSQL + ",'" + purchase.QUOTATION_NO + "' ";
                        strSQL = strSQL + ",'" + purchase.DELIVERY_NOTE_NO + "' ";
                        strSQL = strSQL + ",'" + purchase.TERMS_AND_CONDITION + "' ";
                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();

                        int poId = 0;

                        strSQL = "SELECT ";
                        strSQL = strSQL + "SALES_ID ";
                        strSQL = strSQL + "FROM TBL_SALES_ORDER ";
                        strSQL = strSQL + "WHERE SALES_ORDER_NO='" + purchase.SALES_ORDER_NO + "' ";

                        command.CommandText = strSQL;
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            poId = Convert.ToInt32(dr["SALES_ID"].ToString());

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

                        foreach (var voucheritem in purchase.sOrderDetailsList)
                        {
                            //parameters.Add("@PO_WO_NUMBER", salesItems.PO_WO_NUMBER);
                            //parameters.Add("@SALES_ORDER_NO", salesItems.SALES_ORDER_NO);
                            //parameters.Add("@SALES_ID", salesItems.SALES_ID);
                            //parameters.Add("@ITEM_ID", salesItems.ITEM_ID);
                            //parameters.Add("@ITEM_DESCRIPTION", salesItems.ITEM_DESCRIPTION);
                            //parameters.Add("@SALES_QUANTITY", salesItems.ORDER_QUANTITY);
                            //parameters.Add("@UOM", salesItems.UOM);
                            //parameters.Add("@UNIT_PRICE", salesItems.UNIT_PRICE);
                            //parameters.Add("@AIT", salesItems.AIT);
                            //parameters.Add("@VAT", salesItems.VAT);
                            //parameters.Add("@PACK_SIZE", salesItems.PACK_SIZE);
                            //parameters.Add("@AMOUNT", salesItems.TOTAL_PRICE);


                            strSQL = "INSERT INTO TBL_SALES_ORDER_DETAILS";
                            strSQL = strSQL + "(PO_WO_NUMBER,SALES_ORDER_NO,SERVICE_CODE,SALES_ID,SERVICE_NAME,ITEM_DESCRIPTION,COMP_REF_NO,ITEM_ID,SALES_QUANTITY,UOM,UNIT_PRICE,AMOUNT";

                            strSQL = strSQL + ") VALUES(";
                            strSQL = strSQL + "'" + purchase.PO_WO_NUMBER + "'";
                            strSQL = strSQL + ",'" + voucheritem.SALES_ORDER_NO + "'";
                            strSQL = strSQL + ",'" + voucheritem.SERVICE_CODE + "'";
                            strSQL = strSQL + ",'" + poId + "'";
                            strSQL = strSQL + ",'" + voucheritem.SERVICE_NAME + "'";
                            strSQL = strSQL + ",'" + voucheritem.ITEM_DESCRIPTION + "'";
                            strSQL = strSQL + ",'" + purchase.acc_com_VoucherModel.COMP_REF_NO + "'";
                            strSQL = strSQL + ",'" + voucheritem.ITEM_ID + "' ";
                            strSQL = strSQL + ",'" + voucheritem.SALES_QUANTITY + "' ";
                            strSQL = strSQL + ",'" + voucheritem.UOM + "' ";
                            strSQL = strSQL + ", " + voucheritem.UNIT_PRICE + " ";
                            strSQL = strSQL + ",'" + voucheritem.TOTAL_PRICE + "' ";
                            strSQL = strSQL + ")";
                            command.CommandText = strSQL;
                            command.ExecuteNonQuery();
                            itemId = 0;
                        }
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
        internal SalesOrderModel AddSalesOrder_bkp(SalesOrderModel sales)
        {
            SalesOrderModel _oItem = new SalesOrderModel();
            bool flag = false;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<SalesOrderModel>("SP_SALES_INSERT_SALES_ORDER",
                            this.SetSalesOrderParameters(sales), commandType: CommandType.StoredProcedure);
                }
                _oItem.SuccessStatus = true;
            }
            catch (Exception Ex)
            {
                _oItem.SuccessStatus = false;
            }


            return _oItem;
        }
        internal SalesOrderModel UpdateSalesOrder(SalesOrderModel sales)
        {
            SalesOrderModel _oItem = new SalesOrderModel();
            bool flag = false;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<SalesOrderModel>("SP_SALES_UPDATE_SALES_ORDER",
                            this.SetSalesOrderParameters(sales), commandType: CommandType.StoredProcedure);
                }
                _oItem.SuccessStatus = true;
            }
            catch (Exception Ex)
            {
                _oItem.SuccessStatus = false;
            }


            return _oItem;
        }
        public DynamicParameters SetSalesOrderParameters(SalesOrderModel salesOrder)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@SALES_ORDER_NO", salesOrder.SALES_ORDER_NO);
            parameters.Add("@PO_WO_NUMBER", salesOrder.PO_WO_NUMBER);
            parameters.Add("@PO_WO_DATE", salesOrder.PO_WO_DATE);
            parameters.Add("@SALES_ORDER_RECEIVED_DATE", salesOrder.SALES_ORDER_RECEIVED_DATE);
            parameters.Add("@ORDER_RECEIVED_BY", salesOrder.ORDER_RECEIVED_BY);
            parameters.Add("@CUSTOMER_ID", salesOrder.CUSTOMER_ID);
            parameters.Add("@DELIVERY_DATE", salesOrder.DELIVERY_DATE);
            parameters.Add("@ASSIGN_TO", salesOrder.ASSIGN_TO);
            parameters.Add("@TOTAL_AMOUNT", salesOrder.TOTAL_AMOUNT);
            parameters.Add("@DISCOUNT_IN_PARCHENT", salesOrder.DISCOUNT_IN_PARCHENT);
            parameters.Add("@DISCOUNT_IN_TAKA", salesOrder.DISCOUNT_IN_TAKA);
            parameters.Add("@ADVANCE_PAID_IN_PARCHENT", salesOrder.ADVANCE_PAID_IN_PARCHENT);
            parameters.Add("@ADVANCE_PAID_IN_TAKA", salesOrder.ADVANCE_PAID_IN_TAKA);
            parameters.Add("@DELIVERY_CHARGE", salesOrder.DELIVERY_CHARGE);
            parameters.Add("@OTHERS_CHARGE", salesOrder.OTHERS_CHARGE);
            parameters.Add("@GRAND_TOTAL", salesOrder.GRAND_TOTAL);
            parameters.Add("@REG_BY", salesOrder.REG_BY);
            parameters.Add("@UPD_BY", salesOrder.UPD_BY);
            parameters.Add("@QUOTATION_NO", salesOrder.QUOTATION_NO);
            parameters.Add("@DELIVERY_NOTE_NO", salesOrder.DELIVERY_NOTE_NO);
            parameters.Add("@TERMS_AND_CONDITION", salesOrder.TERMS_AND_CONDITION);


            return parameters;
        }
        public int GetSalesOrderId()
        {
            int Id = 0;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var qId = connection.Query<int>("SELECT TOP 1  SALES_ID FROM TBL_SALES_ORDER Order by SALES_ID DESC");
                    if (qId != null && qId.Count() > 0)
                    {
                        Id = qId.FirstOrDefault();
                    }
                }
            }
            catch (Exception Ex)
            {

            }

            return Id;
        }
        internal List<SalesItemDetailsModel> AddSalesOrderDetails(List<SalesItemDetailsModel> salesItems)
        {
            List<SalesItemDetailsModel> _opurchaseRequisitionDetails = new List<SalesItemDetailsModel>();
            try
            {
                if (salesItems.Count > 0)
                {
                    foreach (var requisitionDetails in salesItems)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<SalesItemDetailsModel>("SP_SALES_INSERT_SALES_ORDER_ITEM_DETAILS",
                                this.SetParametersSalesOrderDetails(requisitionDetails), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }
        internal List<SalesItemDetailsModel> UpdateSalesOrderDetails(List<SalesItemDetailsModel> salesItems)
        {
            List<SalesItemDetailsModel> _opurchaseRequisitionDetails = new List<SalesItemDetailsModel>();
            try
            {
                if (salesItems.Count > 0)
                {
                    foreach (var requisitionDetails in salesItems)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<SalesItemDetailsModel>("SP_SALES_UPDATE_SALES_ORDER_ITEM_DETAILS",
                                this.SetParametersSalesOrderDetails(requisitionDetails), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }
        public DynamicParameters SetParametersSalesOrderDetails(SalesItemDetailsModel salesItems)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PO_WO_NUMBER", salesItems.PO_WO_NUMBER);
            parameters.Add("@SALES_ORDER_NO", salesItems.SALES_ORDER_NO);
            parameters.Add("@SALES_ID", salesItems.SALES_ID);
            parameters.Add("@ITEM_ID", salesItems.ITEM_ID);
            parameters.Add("@ITEM_DESCRIPTION", salesItems.ITEM_DESCRIPTION);
            parameters.Add("@SALES_QUANTITY", salesItems.ORDER_QUANTITY);
            parameters.Add("@UOM", salesItems.UOM);
            parameters.Add("@UNIT_PRICE", salesItems.UNIT_PRICE);
            parameters.Add("@AIT", salesItems.AIT);
            parameters.Add("@VAT", salesItems.VAT);
            parameters.Add("@PACK_SIZE", salesItems.PACK_SIZE);
            parameters.Add("@AMOUNT", salesItems.TOTAL_PRICE);

            return parameters;
        }
        public List<SalesOrderViewModel> GetSalesInfo()
        {
            List<SalesOrderViewModel> salesInfo = new List<SalesOrderViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<SalesOrderViewModel>("SP_SALES_GET_SALES_INFO");
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesInfo = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception Ex)
            {

            }

            return salesInfo;
        }
        public SalesOrderViewModel GetSalesInfoByPO(string poNumber)
        {
            SalesOrderViewModel salesOrderView = new SalesOrderViewModel();
            var parameters = new DynamicParameters();
            parameters.Add("@PO_WO_NUMBER", poNumber, DbType.String);
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                connection.Open();
                try
                {
                    var salesDetailsInfo = connection.Query<SalesOrderViewModel>("SP_SALES_GET_SALES_INFO_BY_PO_WO_NUMBER", parameters, commandType: CommandType.StoredProcedure);
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesOrderView = salesDetailsInfo.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {

                }

            }
            return salesOrderView;
        }
        //----

        public SalesOrderModel GetSalesInfoBySalesOrderNo(string poNumber)
        {
            SalesOrderModel salesOrderView = new SalesOrderModel();
            var parameters = new DynamicParameters();
            parameters.Add("@PO_WO_NUMBER", poNumber, DbType.String);
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                connection.Open();
                var salesDetailsInfo = connection.Query<SalesOrderModel>("SP_SALES_GET_SALES_INFO_BY_PO_WO_NUMBER", parameters, commandType: CommandType.StoredProcedure);
                if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                {
                    salesOrderView = salesDetailsInfo.FirstOrDefault();
                }
            }
            return salesOrderView;
        }
        public List<SalesItemDetailsModel> GetSalesItemByPoNo(string poNumber)
        {
            List<SalesItemDetailsModel> itemList = new List<SalesItemDetailsModel>();
            var parameters = new DynamicParameters();
            parameters.Add("@PO_WO_NUMBER", poNumber, DbType.String);
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                connection.Open();
                var salesDetailsInfo = connection.Query<SalesItemDetailsModel>("SP_SALES_GET_SALES_ITEM_DETAILS_BY_PO_NO", parameters, commandType: CommandType.StoredProcedure);
                if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                {
                    itemList = salesDetailsInfo.ToList();
                }
            }
            return itemList;
        }
        public List<SalesItemDetailsModel> GetAllSalesItemDetails()
        {
            List<SalesItemDetailsModel> itemList = new List<SalesItemDetailsModel>();

            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                connection.Open();
                var salesDetailsInfo = connection.Query<SalesItemDetailsModel>("SELECT * FROM TBL_SALES_ORDER_DETAILS s INNER JOIN TBL_ITEM i ON s.ITEM_ID=i.ITEM_ID");
                if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                {
                    itemList = salesDetailsInfo.ToList();
                }
            }
            return itemList;
        }
        public List<SalesOrderViewModel> GetSalesOrderTrackingInfo()
        {
            List<SalesOrderViewModel> salesInfo = new List<SalesOrderViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<SalesOrderViewModel>("SP_SALES_GET_SALES_ORDER_TRACKER_INFO");
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesInfo = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesInfo;
        }
        //

        public List<SalesOrderViewModel> GetSalesOrderShipmentInfo()
        {
            List<SalesOrderViewModel> salesInfo = new List<SalesOrderViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<SalesOrderViewModel>("SELECT Distinct STATUS_OF_SHIPMENT FROM TBL_SALES_ORDER");
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesInfo = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesInfo;
        }
        public SalesOrderModel GetSalesByPO(string poNumber)
        {
            SalesOrderModel salesOrderView = new SalesOrderModel();
            var parameters = new DynamicParameters();
            parameters.Add("@PO_WO_NUMBER", poNumber, DbType.String);
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                connection.Open();
                var salesDetailsInfo = connection.Query<SalesOrderModel>("SP_SALES_GET_SALES_INFO_BY_PO_WO_NUMBER", parameters, commandType: CommandType.StoredProcedure);
                if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                {
                    salesOrderView = salesDetailsInfo.FirstOrDefault();
                }
            }
            return salesOrderView;
        }
        internal SalesOrderModel UpdateSalesTracking(SalesOrderModel sales)
        {
            SalesOrderModel _oItem = new SalesOrderModel();
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


                    strSQL = "UPDATE TBL_SALES_ORDER SET ETA_TL_WH_1st_DATE='" + sales.ETA_TL_WH_1st_DATE + "',";
                    strSQL = strSQL + "ETA_TL_WH_2nd_DATE='" + sales.ETA_TL_WH_2nd_DATE + "', ";
                    strSQL = strSQL + "ETA_TL_WH_3rd_DATE='" + sales.ETA_TL_WH_3rd_DATE + "', ";
                    strSQL = strSQL + "EXPECTED_DELIVERY_1st_DATE='" + sales.EXPECTED_DELIVERY_1st_DATE + "', ";
                    strSQL = strSQL + "EXPECTED_DELIVERY_2nd_DATE='" + sales.EXPECTED_DELIVERY_2nd_DATE + "', ";
                    strSQL = strSQL + "EXPECTED_DELIVERY_3rd_DATE='" + sales.EXPECTED_DELIVERY_3rd_DATE + "', ";
                    strSQL = strSQL + "PARCHENTAGE_OF_COMPLETE='" + sales.PARCHENTAGE_OF_COMPLETE + "', ";
                    strSQL = strSQL + "STATUS_OF_SHIPMENT='" + sales.STATUS_OF_SHIPMENT + "', ";
                    strSQL = strSQL + "DELIVERY_DATE='" + sales.DELIVERY_DATE + "' ";

                    strSQL = strSQL + "WHERE SALES_ID = " + sales.SALES_ID + "";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    cmdInsert.Transaction.Commit();

                }
            }
            catch (Exception EX)
            {

            }



            return _oItem;
        }
        public DynamicParameters SetSalesOrderTrackingParameters(SalesOrderModel salesOrder)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@PO_WO_NUMBER", salesOrder.PO_WO_NUMBER);
            parameters.Add("@ETA_TL_WH_1st_DATE", salesOrder.ETA_TL_WH_1st_DATE);
            parameters.Add("@ETA_TL_WH_2nd_DATE", salesOrder.ETA_TL_WH_2nd_DATE);
            parameters.Add("@ETA_TL_WH_3rd_DATE", salesOrder.ETA_TL_WH_3rd_DATE);
            parameters.Add("@EXPECTED_DELIVERY_1st_DATE", salesOrder.EXPECTED_DELIVERY_1st_DATE);
            parameters.Add("@EXPECTED_DELIVERY_2nd_DATE", salesOrder.EXPECTED_DELIVERY_2nd_DATE);
            parameters.Add("@EXPECTED_DELIVERY_3rd_DATE", salesOrder.EXPECTED_DELIVERY_3rd_DATE);
            parameters.Add("@PARCHENTAGE_OF_COMPLETE", salesOrder.PARCHENTAGE_OF_COMPLETE);
            parameters.Add("@STATUS_OF_SHIPMENT", salesOrder.STATUS_OF_SHIPMENT);



            return parameters;
        }
        public List<SalesQuotationView> GetAllQuotationList()
        {
            List<SalesQuotationView> salesQuotationList = new List<SalesQuotationView>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<SalesQuotationView>("SP_SALES_GET_QUOTATION_LIST");
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        internal List<SalesItemDetailsModel> GetWorkOrderItemList(string woNO)
        {
            List<SalesItemDetailsModel> salesQuotationList = new List<SalesItemDetailsModel>();
            try
            {
                var parameter = new DynamicParameters();
                parameter.Add("@workOrderNo", woNO, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<SalesItemDetailsModel>("SP_GET_WORK_ORDER_ITEM_LIST", parameter, commandType: CommandType.StoredProcedure);
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        public List<DeliveryNoteViewModel> GetDeliveryList(string woNo)
        {
            List<DeliveryNoteViewModel> salesQuotationList = new List<DeliveryNoteViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@workOrderNo", woNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<DeliveryNoteViewModel>("SP_GET_DELIVERY_NOTE_INFO", parameters, commandType: CommandType.StoredProcedure);
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        public List<DeliveryNoteViewModel> GetAllDeliveryList()
        {
            List<DeliveryNoteViewModel> salesQuotationList = new List<DeliveryNoteViewModel>();
            try
            {
                //var parameters = new DynamicParameters();
                //parameters.Add("@workOrderNo", woNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<DeliveryNoteViewModel>("SP_GET_ALL_DELIVERY_NOTE_INFO");
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        public List<InvoiceViewModel> GetInvoiceList(string woNo)
        {
            List<InvoiceViewModel> salesQuotationList = new List<InvoiceViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@workOrderNo", woNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<InvoiceViewModel>("SP_GET_INVOICE_INFO", parameters, commandType: CommandType.StoredProcedure);
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        public List<InvoiceViewModel> GetAllInvoiceList()
        {
            List<InvoiceViewModel> salesQuotationList = new List<InvoiceViewModel>();
            try
            {
                //var parameters = new DynamicParameters();
                //parameters.Add("@workOrderNo", woNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<InvoiceViewModel>("SP_GET_ALL_INVOICE_INFO");
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        //ByWorkOrderNo  SP_GET_ALL_INVOICE_INFO
        public SalesOrderViewModel GetSalesOrderInfoByWONO(string woNo)
        {
            SalesOrderViewModel salesOrderView = new SalesOrderViewModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@workOrderNo", woNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<SalesOrderViewModel>("SP_GET_SALES_ORDER_INFO_BY_WORK_ORDER_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesOrderView = salesDetailsInfo.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesOrderView;
        }
        public List<DeliveryNoteViewModel> GetAllDeliveryListByDeliveryNote(string deliveryNoteNo)
        {
            List<DeliveryNoteViewModel> salesQuotationList = new List<DeliveryNoteViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@delivery_note_No", deliveryNoteNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<DeliveryNoteViewModel>("SP_GET_DELIVERY_NOTE_INFO_BY_DELIVERYNOTE_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        //
        public List<InvoiceViewModel> GetAllInvoiceListByInvNo(string invNo)
        {
            List<InvoiceViewModel> salesQuotationList = new List<InvoiceViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@INV_No", invNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<InvoiceViewModel>("SP_GET_INVOICE_INFO_BY_INV_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        public List<SalesQuotationView> GetAllQuotationListCurrentYear()
        {
            List<SalesQuotationView> salesQuotationList = new List<SalesQuotationView>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesDetailsInfo = connection.Query<SalesQuotationView>("SP_SALES_GET_QUOTATION_LIST_CURRENTYEAR");
                    if (salesDetailsInfo != null && salesDetailsInfo.Count() > 0)
                    {
                        salesQuotationList = salesDetailsInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotationList;
        }
        public SalesQuotationView GetSalesQuotationById(int Id)
        {
            SalesQuotationView salesQuotation = new SalesQuotationView();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Quotation_Id", Id, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesQuotationInfo = connection.Query<SalesQuotationView>("SP_SALES_GET_SALES_QUOTATION_BY_QUOTATION_ID", parameters, commandType: CommandType.StoredProcedure);
                    if (salesQuotationInfo != null && salesQuotationInfo.Count() > 0)
                    {
                        salesQuotation = salesQuotationInfo.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotation;
        }
        // ByQuotationNo
        public SalesQuotationView GetSalesQuotationByQuotationNo(string QuotationNo)
        {
            SalesQuotationView salesQuotation = new SalesQuotationView();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Quotation_NO", QuotationNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesQuotationInfo = connection.Query<SalesQuotationView>("SP_SALES_GET_SALES_QUOTATION_BY_QUOTATION_NUMBER", parameters, commandType: CommandType.StoredProcedure);
                    if (salesQuotationInfo != null && salesQuotationInfo.Count() > 0)
                    {
                        salesQuotation = salesQuotationInfo.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotation;
        }
        public SalesQuotationModel GetSalesQuotationByReqNo(string qutNo)
        {
            SalesQuotationModel salesQuotation = new SalesQuotationModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Quotation_NO", qutNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesQuotationInfo = connection.Query<SalesQuotationModel>("SP_SALES_GET_SALES_QUOTATION_BY_QUOTATION_NUMBER", parameters, commandType: CommandType.StoredProcedure);
                    if (salesQuotationInfo != null && salesQuotationInfo.Count() > 0)
                    {
                        salesQuotation = salesQuotationInfo.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return salesQuotation;
        }
        public List<SalesQuotationItemView> GetSalesQuotationItemList(int Id)
        {
            List<SalesQuotationItemView> SalesQuotationViewList = new List<SalesQuotationItemView>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Quotation_Id", Id, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesQuotationInfo = connection.Query<SalesQuotationItemView>("SP_SALES_GET_SALES_QUOTATION_ITEM_LIST", parameters, commandType: CommandType.StoredProcedure);
                    if (salesQuotationInfo != null && salesQuotationInfo.Count() > 0)
                    {
                        SalesQuotationViewList = salesQuotationInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return SalesQuotationViewList;
        }
        //
        public List<SalesQuotationItemView> GetSalesQuotationItemListByQuotationNo(string quotationNo)
        {
            List<SalesQuotationItemView> SalesQuotationViewList = new List<SalesQuotationItemView>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Quotation_NO", quotationNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesQuotationInfo = connection.Query<SalesQuotationItemView>("SP_SALES_GET_SALES_QUOTATION_ITEM_LISTBY_QUTNO", parameters, commandType: CommandType.StoredProcedure);
                    if (salesQuotationInfo != null && salesQuotationInfo.Count() > 0)
                    {
                        SalesQuotationViewList = salesQuotationInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return SalesQuotationViewList;
        }
        public List<SalesItemDetailsModel> GetSalesQuotationItemListByQutNo(string qutNo)
        {
            List<SalesItemDetailsModel> SalesQuotationViewList = new List<SalesItemDetailsModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Quotation_NO", qutNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var salesQuotationInfo = connection.Query<SalesItemDetailsModel>("SP_SALES_GET_SALES_QUOTATION_ITEM_LISTBY_QUTNO", parameters, commandType: CommandType.StoredProcedure);
                    if (salesQuotationInfo != null && salesQuotationInfo.Count() > 0)
                    {
                        SalesQuotationViewList = salesQuotationInfo.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return SalesQuotationViewList;
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
                    var poModel = connection.Query<PurchaseTermsConditionsModel>("SP_SALES_GET_TERMS_AND_CONDITIONS", parameters, commandType: CommandType.StoredProcedure);
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
        public List<ItemEntity> GetUsedProduct(string Ids)
        {
            List<ItemEntity> usedProductList = new List<ItemEntity>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", Ids, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ItemEntity>("SP_SALES_GET_USED_PRODUCT_IN_PROJECT", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        usedProductList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return usedProductList;
        }
        public List<ItemEntity> GetItemListByUsedProduct(string Ids)
        {
            List<ItemEntity> termsAndConditonsList = new List<ItemEntity>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", Ids, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ItemEntity>("SP_SALES_GET_ITEM_BY_ITEM_Ids", parameters, commandType: CommandType.StoredProcedure);
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
        internal string GetQutNo()
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
                    var PID = connection.Query<string>("Select TOP 1 QUOTATION_NO from TBL_SALES_QUOTATION ORDER BY  SALES_QUOTATION_ID DESC");
                    if (PID != null && PID.Count() > 0)
                    {
                        pono = PID.FirstOrDefault();
                    }

                    if (pono == "")
                    { pono = "0"; }
                    string no = "0";
                    if (pono != "0")
                    {
                        if (pono.Length > 0)
                        { no = pono.Remove(0, 7); }
                        else { }
                    }
                    else
                    {
                        if (pono != "0")
                        {
                            if (pono.Length > 0)
                            { no = pono.Remove(0, 6); }
                            else { }
                        }
                    }


                    string num = caseTime + "Q" + (Convert.ToInt64(no) + 1);
                    pono = num;
                }
            }
            catch (Exception EX)
            {

            }
            return pono;
        }
        internal InvoiceMasterEntity CreateInvoice(InvoiceMasterEntity invoice)
        {
            bool flag = false;
            int vendorId = 0;
            string vendorName = "";
            string strSQL = "";
            InvoiceMasterEntity Status = new InvoiceMasterEntity();
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



                    strSQL = "SELECT 'IN-'+RIGHT('00000000'+CAST(NEXT VALUE FOR INVOICE_UNIC_NO AS VARCHAR(8)),8)";
                    command.CommandText = strSQL;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {

                        invoice.INVOICE_NO = dr.GetValue(0).ToString();

                    }
                    dr.Close();


                    strSQL = "INSERT INTO TBL_INVOICE_MASTER(";
                    strSQL = strSQL + "INVOICE_NO,WO_NUMBER,WORK_NAME,DELIVERY_NOTE_NO,CUSTOMER_ID,CUSTOMER_PROJECT_ID,INVOICE_DATE,INVOICE_AMOUNT,DISCOUNT,TAX_AMOUNT,VAT,ADVANCE,GRAND_TOTAL,TERMS_CONDITION,IN_WORDS) ";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + invoice.INVOICE_NO + "' ";
                    strSQL = strSQL + ",'" + invoice.WO_NUMBER + "' ";
                    strSQL = strSQL + ",'" + invoice.WORK_NAME + "' ";
                    strSQL = strSQL + ",'" + invoice.DELIVERY_NOTE_NO + "' ";
                    strSQL = strSQL + ",'" + invoice.CUSTOMER_ID + "' ";
                    strSQL = strSQL + ",'" + invoice.CUSTOMER_PROJECT_ID + "' ";
                    strSQL = strSQL + ",'" + invoice.INVOICE_DATE + "' ";
                    strSQL = strSQL + ",'" + invoice.INVOICE_AMOUNT + "' ";
                    strSQL = strSQL + ",'" + invoice.DISCOUNT + "' ";
                    strSQL = strSQL + ",'" + invoice.TAX_AMOUNT + "' ";
                    strSQL = strSQL + ",'" + invoice.VAT + "' ";
                    strSQL = strSQL + ",'" + invoice.ADVANCE + "' ";
                    strSQL = strSQL + ",'" + invoice.GRAND_TOTAL + "' ";
                    strSQL = strSQL + ",'" + invoice.TERMS_CONDITION + "' ";
                    strSQL = strSQL + ",'" + invoice.IN_WORDS + "' ";
                    strSQL = strSQL + ")";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    int invMasterId = 0;

                    //strSQL = "SELECT ";
                    //strSQL = strSQL + "INVOICE_MASTER_ID ";
                    //strSQL = strSQL + "FROM TBL_INVOICE_MASTER ";
                    //strSQL = strSQL + "WHERE WO_NUMBER='" + invoice.WO_NUMBER + "' ";


                    strSQL = "SELECT ";
                    strSQL = strSQL + "TOP 1 INVOICE_MASTER_ID ";
                    strSQL = strSQL + "FROM TBL_INVOICE_MASTER ";
                    strSQL = strSQL + "order by INVOICE_MASTER_ID DESC ";

                    command.CommandText = strSQL;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        invMasterId = Convert.ToInt32(dr["INVOICE_MASTER_ID"].ToString());

                    }
                    dr.Close();
                    int itemId = 0;
                    string itemName;

                    foreach (var invoiceServiceItem in invoice.invoiceDetailsList)
                    {

                        strSQL = "INSERT INTO TBL_INVOICE_DETAILS";
                        strSQL = strSQL + "(INVOICE_MASTER_ID,SERVICE_CODE,SERVICE_NAME,QUANTITY,UNIT,PRICE,AMOUNT";

                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + invMasterId + "'";
                        strSQL = strSQL + ",'" + invoiceServiceItem.SERVICE_CODE + "'";
                        strSQL = strSQL + ",'" + invoiceServiceItem.SERVICE_NAME + "'";
                        strSQL = strSQL + ",'" + invoiceServiceItem.QUANTITY + "' ";
                        strSQL = strSQL + ",'" + invoiceServiceItem.UNIT + "' ";
                        strSQL = strSQL + ",'" + invoiceServiceItem.PRICE + "' ";
                        strSQL = strSQL + ",'" + invoiceServiceItem.AMOUNT + "' ";

                        strSQL = strSQL + ")";
                        command.CommandText = strSQL;
                        command.ExecuteNonQuery();




                    }
                    
                    string accVoucherNo = "";
                    IDataReader _dr=null;
                    dr = SqlHelper.ExecuteReader(Global.ConnectionString, "SP_SEQUENCE_GENERATE_ACC_VOUCHER_NO", 3);
                    while (dr.Read())
                    {
                        accVoucherNo = _dr["VOUCHER_NO"].ToString();
                    }                    

                    //////----------Accounts 
                    //ACC_COMPANY_VOUCHER_MODEL accCompanyVoucherModel = new ACC_COMPANY_VOUCHER_MODEL();

                    //accCompanyVoucherModel.COMP_REF_NO = accVoucherNo;
                    ////accCompanyVoucherModel.COMP_VOUCHER_DATE = Convert.ToDateTime(dd);
                    ////accCompanyVoucherModel.BRANCH_ID = branchList.Find(x => x.BRANCH_NAME == BranchName).BRANCH_ID;
                    //accCompanyVoucherModel.LEDGER_NAME = customerList.Find(x => x.CUSTOMER_ID == salesOrder.CUSTOMER_ID).CUSTOMER_NAME;
                    //accCompanyVoucherModel.COMP_VOUCHER_AMOUNT = Convert.ToDecimal(invoice.GRAND_TOTAL);
                    //accCompanyVoucherModel.COMP_VOUCHER_ADD_AMOUNT = 0;
                    //accCompanyVoucherModel.COMP_VOUCHER_LESS_AMOUNT = 0;
                    //accCompanyVoucherModel.COMP_VOUCHER_NET_AMOUNT = Convert.ToDecimal(invoice.GRAND_TOTAL);
                    //accCompanyVoucherModel.COMP_VOUCHER_PROCESS_AMOUNT = 0;
                    //accCompanyVoucherModel.COMP_VOUCHER_NARRATION = "";
                    //accCompanyVoucherModel.COMP_VOUCHER_TYPE = 3;
                    //accCompanyVoucherModel.ENTRYBY = await sessionStorage.GetItemAsync<string>("session_employeeName");
                    //accCompanyVoucherModel.UPDATEBY = await sessionStorage.GetItemAsync<string>("session_employeeName");


                    //List<ACC_VOUCHER_MODEL> voucherItem = new List<ACC_VOUCHER_MODEL>
                    //{
                    //            new ACC_VOUCHER_MODEL {
                    //                COMP_REF_NO =accVoucherNo
                    //                  ,VOUCHER_REF_KEY=""
                    //                  ,BRANCH_ID=accCompanyVoucherModel.BRANCH_ID
                    //                  ,COMP_VOUCHER_DATE=accCompanyVoucherModel.COMP_VOUCHER_DATE
                    //                  ,COMP_VOUCHER_TYPE=3
                    //                  ,LEDGER_NAME=customerList.Find(x => x.CUSTOMER_ID == salesOrder.CUSTOMER_ID).CUSTOMER_NAME
                    //                  ,VOUCHER_DEBIT_AMOUNT=Convert.ToDecimal(invoice.GRAND_TOTAL)
                    //                  ,VOUCHER_CREDIT_AMOUNT=0
                    //                  ,VOUCHER_ADD_AMOUNT=0
                    //                  ,VOUCHER_LESS_AMOUNT=0
                    //                  ,VOUCHER_TOBY="Dr"
                    //                  ,VOUCHER_FC_DEBIT_AMOUNT=0
                    //                  ,VOUCHER_FC_CREDIT_AMOUNT = 0
                    //            },
                    //            new ACC_VOUCHER_MODEL {
                    //              COMP_REF_NO = accVoucherNo
                    //              ,VOUCHER_REF_KEY=""
                    //              ,BRANCH_ID=accCompanyVoucherModel.BRANCH_ID
                    //              ,COMP_VOUCHER_DATE=accCompanyVoucherModel.COMP_VOUCHER_DATE
                    //              ,COMP_VOUCHER_TYPE=3
                    //              ,LEDGER_NAME=SelectedString
                    //              ,VOUCHER_DEBIT_AMOUNT=0
                    //              ,VOUCHER_CREDIT_AMOUNT=Convert.ToDecimal(invoice.GRAND_TOTAL)
                    //              ,VOUCHER_ADD_AMOUNT=0
                    //              ,VOUCHER_LESS_AMOUNT=0
                    //              ,VOUCHER_TOBY="Cr"
                    //              ,VOUCHER_FC_DEBIT_AMOUNT=0
                    //              ,VOUCHER_FC_CREDIT_AMOUNT = 0

                    //            }
                    //};



                    ////-----------


                    //strSQL = "INSERT INTO ACC_COMPANY_VOUCHER(";
                    //strSQL = strSQL + "COMP_REF_NO,BRANCH_ID,LEDGER_NAME,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,COMP_VOUCHER_MONTH_ID ";
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
                    //    strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,VOUCHER_CHEQUE_NUMBER,VOUCHER_CHEQUE_DATE,VOUCHER_CHEQUE_DRAWN_ON ";
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

                    ////----------Account end


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
        internal List<string> GetDeliveryNoteNoList(string woNo)
        {
            List<string> list = new List<string>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Work_Order_No", woNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var dnList = connection.Query<string>("SP_GET_DELIVERY_NOTE_NO_LIST_BY_WO_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (dnList != null && dnList.Count() > 0)
                    {
                        list = dnList.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return list;
        }
        internal string GetQutNo111(string prefix)
        {
            string qutNo = "";
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_NAME_Prefix", prefix, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var auto_qutNo = connection.Query<string>("SP_SALES_GET_QUTATION_NO", parameters, commandType: CommandType.StoredProcedure);
                    if (auto_qutNo != null && auto_qutNo.Count() > 0)
                    {
                        qutNo = auto_qutNo.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return qutNo;
        }
        internal string GetSalesOrderNo()
        {
            string salesOrderNo = "";
            try
            {
                //var parameters = new DynamicParameters();
                //parameters.Add("@CUSTOMER_NAME_Prefix", prefix, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var auto_qutNo = connection.Query<string>("SP_SALES_GET_SALES_ORDER_NO");
                    if (auto_qutNo != null && auto_qutNo.Count() > 0)
                    {
                        salesOrderNo = auto_qutNo.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return salesOrderNo;
        }
        internal string GetDeliveryNoteNo()
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
                    var PID = connection.Query<string>("Select TOP 1 DELIVERY_NOTE_NO from TBL_SALES_ORDER ORDER BY  SALES_ID DESC");
                    if (PID != null && PID.Count() > 0)
                    {
                        pono = PID.FirstOrDefault();
                    }
                    if (pono == "" || pono == null)
                    { pono = "0"; }
                    //string no = "0";
                    //if (pono.Length > 0)
                    //{ no = pono.Remove(0, 6); }
                    //else { }

                    //string num = caseTime + "Q" + (Convert.ToInt64(no) + 1);
                    string num = Convert.ToString(Convert.ToInt64(pono) + 1);
                    pono = num;
                }
            }
            catch (Exception EX)
            {

            }
            return pono;
        }
        internal List<SalesOrderViewModel> GetUnPaidPoListByCustomerCode(int customerId)
        {
            List<SalesOrderViewModel> purchaseOrderList = new List<SalesOrderViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_Id", customerId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<SalesOrderViewModel>("SP_CUSTOMER_GET_UNPAID_PO_LIST_BY_CUSTOMER", parameters, commandType: CommandType.StoredProcedure);
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
        internal SalesOrderModel UpdateSalesShipmentStatus(SalesOrderModel sales)
        {
            SalesOrderModel _oItem = new SalesOrderModel();
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
                    string voucher_ref_No = "";
                    string type = "3";
                    SalesOrderViewModel salesOrder = new SalesOrderViewModel();
                    DateTime v_date = new DateTime();
                    IDataReader dr_;
                    if (sales.STATUS_OF_SHIPMENT == "Delivered")
                    {
                        dr_ = SqlHelper.ExecuteReader(Global.ConnectionString, "SP_SEQUENCE_GENERATE_ACC_VOUCHER_NO", type);
                        while (dr_.Read())
                        {
                            voucher_ref_No = dr_["VOUCHER_NO"].ToString();
                        }


                        strSQL = "UPDATE TBL_SALES_ORDER SET STATUS_OF_SHIPMENT='" + sales.STATUS_OF_SHIPMENT + "' ";

                        strSQL = strSQL + "WHERE SALES_ORDER_NO = '" + sales.SALES_ORDER_NO + "'";
                        cmdInsert.CommandText = strSQL;
                        cmdInsert.ExecuteNonQuery();

                        SqlDataReader dr;


                        strSQL = "Select c.CUSTOMER_NAME,s.DELIVERY_DATE,s.GRAND_TOTAL from [dbo].[TBL_SALES_ORDER] s inner join [dbo].[TBL_CUSTOMER] c on s.CUSTOMER_ID=c.CUSTOMER_ID ";
                        strSQL = strSQL + " Where s.SALES_ORDER_NO='" + sales.SALES_ORDER_NO + "' ";
                        cmdInsert.CommandText = strSQL;
                        dr = cmdInsert.ExecuteReader();
                        DateTime aDate = DateTime.Now;
                        string d = "";
                        string m = "";
                        string y = "";
                        if (dr.Read())
                        {
                            salesOrder.CUSTOMER_NAME = Convert.ToString(dr["CUSTOMER_NAME"]);

                            d = (dr["DELIVERY_DATE"]).ToString().Substring(0, 2);
                            m = (dr["DELIVERY_DATE"]).ToString().Substring(3, 2);
                            y = (dr["DELIVERY_DATE"]).ToString().Substring(6, 4);
                            salesOrder.DELIVERY_DATE = y + "-" + m + "-" + d;
                            aDate = Convert.ToDateTime(salesOrder.DELIVERY_DATE);
                            //Console.WriteLine(aDate.ToString("MM/dd/yyyy-MM-dd"));


                            int dt_date = Convert.ToDateTime(dr["DELIVERY_DATE"]).Day;
                            int dt_M = Convert.ToDateTime(dr["DELIVERY_DATE"]).Month;
                            int dt_y = Convert.ToDateTime(dr["DELIVERY_DATE"]).Year;
                            DateTime dtttt = Convert.ToDateTime(dt_y + "-" + dt_M + "-" + dt_date);
                            sales.GRAND_TOTAL = Convert.ToDouble(dr["GRAND_TOTAL"]);

                        }
                        dr.Close();


                        //strSQL = "Select * from [dbo].[TBL_SALES_ORDER] s inner join [dbo].[TBL_CUSTOMER] c on s.CUSTOMER_ID=c.CUSTOMER_ID ";
                        //strSQL = strSQL + " Where s.SALES_ORDER_NO='" + sales.SALES_ORDER_NO + "' ";
                        //cmdInsert.CommandText = strSQL;
                        //dr = cmdInsert.ExecuteReader();
                        //if (dr.Read())
                        //{
                        //    salesOrder.CUSTOMER_NAME = Convert.ToString(dr["CUSTOMER_NAME"]);
                        //    salesOrder.DELIVERY_DATE = Convert.ToString(Convert.ToDateTime(dr["DELIVERY_DATE"]));
                        //    v_date = Convert.ToDateTime(dr["DELIVERY_DATE"]);
                        //    sales.GRAND_TOTAL = Convert.ToDouble(dr["GRAND_TOTAL"]);

                        //}
                        //dr.Close();

                        //Find Ledger with this customer

                        //strSQL = "Select * from [dbo].[TBL_SALES_ORDER] s inner join [dbo].[TBL_CUSTOMER] c on s.CUSTOMER_ID=c.CUSTOMER_ID ";
                        //strSQL = strSQL + " Where s.SALES_ORDER_NO='" + sales.SALES_ORDER_NO + "' ";
                        //cmdInsert.CommandText = strSQL;
                        //dr = cmdInsert.ExecuteReader();
                        //if (dr.Read())
                        //{
                        //    salesOrder.CUSTOMER_NAME = Convert.ToString(dr["CUSTOMER_NAME"]);
                        //    salesOrder.DELIVERY_DATE = Convert.ToString(Convert.ToDateTime(dr["DELIVERY_DATE"]));
                        //    v_date = Convert.ToDateTime(dr["DELIVERY_DATE"]);
                        //    sales.GRAND_TOTAL = Convert.ToDouble(dr["GRAND_TOTAL"]);

                        //}
                        //dr.Close();
                        DateTime dt = Convert.ToDateTime(salesOrder.DELIVERY_DATE);
                        //int d = v_date.Day;
                        //int m = v_date.Month;


                        strSQL = "INSERT INTO ACC_COMPANY_VOUCHER(";
                        strSQL = strSQL + "COMP_REF_NO,BRANCH_ID,LEDGER_NAME,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,COMP_VOUCHER_MONTH_ID ";//COMP_VOUCHER_DUE_DATE,,AUTOJV
                        strSQL = strSQL + ",COMP_VOUCHER_AMOUNT,COMP_VOUCHER_NET_AMOUNT,COMP_VOUCHER_NARRATION)";
                        strSQL = strSQL + "VALUES(";
                        strSQL = strSQL + "'" + voucher_ref_No + "' ";
                        strSQL = strSQL + ",'" + "0005" + "' ";
                        strSQL = strSQL + ",'" + "Account Receivable" + "' ";
                        strSQL = strSQL + "," + "3" + " ";
                        strSQL = strSQL + ",'" + salesOrder.DELIVERY_DATE + "' ";
                        strSQL = strSQL + ",'" + aDate.ToString("MMMyy").ToUpper() + " ' ";
                        strSQL = strSQL + "," + sales.GRAND_TOTAL + " ";
                        strSQL = strSQL + "," + sales.GRAND_TOTAL + " ";
                        strSQL = strSQL + ",'" + "Sales to " + salesOrder.CUSTOMER_NAME + "' ";
                        strSQL = strSQL + ")";
                        cmdInsert.CommandText = strSQL;
                        cmdInsert.ExecuteNonQuery();

                        //-----------------
                        int intloop = 1;
                        string strChildKey = voucher_ref_No + intloop.ToString().PadLeft(4, '0');

                        strSQL = "INSERT INTO ACC_VOUCHER";
                        strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
                        strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
                        strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
                        strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,VOUCHER_CHEQUE_NUMBER,VOUCHER_CHEQUE_DATE,VOUCHER_CHEQUE_DRAWN_ON ";   //,TRANSFER_TYPE Not Found In Table
                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + voucher_ref_No + "'";
                        strSQL = strSQL + ",'" + "0005" + "' ";
                        strSQL = strSQL + ",'" + strChildKey + "' ";
                        strSQL = strSQL + ", " + "3" + " ";
                        strSQL = strSQL + "," + intloop + "";
                        strSQL = strSQL + ",'" + salesOrder.DELIVERY_DATE + "'";
                        strSQL = strSQL + ",'" + "Account Receivable" + "' ";
                        strSQL = strSQL + "," + sales.GRAND_TOTAL + " ";
                        strSQL = strSQL + ",0 ";
                        strSQL = strSQL + ",'Dr'";
                        strSQL = strSQL + ",'" + "Account Receivable" + "' ";
                        strSQL = strSQL + ",'" + "" + "'";
                        strSQL = strSQL + ",'" + "2001-01-01" + "'";
                        strSQL = strSQL + ",'" + "" + "'";
                        strSQL = strSQL + ")";
                        //if (strReverseLedger != "")
                        //{
                        //    strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //}
                        //else
                        //{
                        //    strReverseLedger = paymentVoucher.accVoucherList.Find(x => x.VOUCHER_TOBY == "Dr").LEDGER_NAME;
                        //    strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //}
                        //if (voucheritem.VOUCHER_TOBY == "Dr")
                        //{
                        //    strSQL = strSQL + "," + voucheritem.VOUCHER_DEBIT_AMOUNT + " ";
                        //    strSQL = strSQL + ",0 ";
                        //    strSQL = strSQL + ",'Dr'";
                        //    if (strReverseLedger != "")
                        //    {
                        //        strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //    }
                        //    else
                        //    {
                        //        strReverseLedger = paymentVoucher.accVoucherList.Find(x => x.VOUCHER_TOBY == "Dr").LEDGER_NAME;
                        //        strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //    }
                        //}
                        //else if (voucheritem.VOUCHER_TOBY == "Cr")
                        //{
                        //    strSQL = strSQL + ",0 ";
                        //    strSQL = strSQL + "," + voucheritem.VOUCHER_CREDIT_AMOUNT + " ";
                        //    strSQL = strSQL + ",'Cr'";
                        //    if (strReverseLedger != "")
                        //    {
                        //        strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //    }
                        //    else
                        //    {
                        //        strReverseLedger = paymentVoucher.accVoucherList.Find(x => x.VOUCHER_TOBY == "Cr").LEDGER_NAME;
                        //        strSQL = strSQL + ",'" + strReverseLedger + "' ";
                        //    }
                        //}

                        cmdInsert.CommandText = strSQL;
                        cmdInsert.ExecuteNonQuery();

                        //


                        int intloop1 = 2;
                        string strChildKey1 = voucher_ref_No + intloop1.ToString().PadLeft(4, '0');

                        strSQL = "INSERT INTO ACC_VOUCHER";
                        strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
                        strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
                        strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
                        strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,VOUCHER_CHEQUE_NUMBER,VOUCHER_CHEQUE_DATE,VOUCHER_CHEQUE_DRAWN_ON ";   //,TRANSFER_TYPE Not Found In Table
                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + voucher_ref_No + "'";
                        strSQL = strSQL + ",'" + "0005" + "' ";
                        strSQL = strSQL + ",'" + strChildKey1 + "' ";
                        strSQL = strSQL + ", " + "3" + " ";
                        strSQL = strSQL + "," + intloop1 + "";
                        strSQL = strSQL + ",'" + salesOrder.DELIVERY_DATE + "'";
                        strSQL = strSQL + ",'" + "Sales" + "' ";
                        strSQL = strSQL + ",0 ";
                        strSQL = strSQL + "," + sales.GRAND_TOTAL + " ";
                        strSQL = strSQL + ",'Cr'";
                        strSQL = strSQL + ",'" + "Account Receivable" + "' ";
                        strSQL = strSQL + ",'" + "" + "'";
                        strSQL = strSQL + ",'" + "2001-01-01" + "'";
                        strSQL = strSQL + ",'" + "" + "'";
                        strSQL = strSQL + ")";
                        cmdInsert.CommandText = strSQL;
                        cmdInsert.ExecuteNonQuery();




                    }
                    else
                    {
                        strSQL = "UPDATE TBL_SALES_ORDER SET STATUS_OF_SHIPMENT='" + sales.STATUS_OF_SHIPMENT + "' ";

                        strSQL = strSQL + "WHERE SALES_ORDER_NO = '" + sales.SALES_ORDER_NO + "'";
                        cmdInsert.CommandText = strSQL;
                        cmdInsert.ExecuteNonQuery();
                    }
                    cmdInsert.Transaction.Commit();
                }

            }
            catch (Exception EX)
            {

            }
            return _oItem;
        }
    }
}
