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
    public class TransectionService
    {
        protected readonly ApplicationDbContex _dbContext;
        string strSQL;
        public TransectionService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }

        #region ACC_COMPANY_VOUCHER_ PAYMENT VOUCHER
        internal ACC_COMPANY_VOUCHER_MODEL AddACC_COMPANY_VOUCHER_PAYMENTVOUCHER(ACC_COMPANY_VOUCHER_MODEL paymentVoucher)
        {
            bool flag = false;
            ACC_COMPANY_VOUCHER_MODEL payment = new ACC_COMPANY_VOUCHER_MODEL();
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    strSQL = "INSERT INTO ACC_COMPANY_VOUCHER(";
                    strSQL = strSQL + "COMP_REF_NO,BRANCH_ID,COMPANY_ID,LEDGER_NAME,COMP_VOUCHER_TYPE,COMP_VOUCHER_DATE,COMP_VOUCHER_MONTH_ID ";//COMP_VOUCHER_DUE_DATE,,AUTOJV
                    strSQL = strSQL + ",COMP_VOUCHER_AMOUNT,COMP_VOUCHER_NET_AMOUNT,COMP_VOUCHER_NARRATION)";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + paymentVoucher.COMP_REF_NO + "' ";
                    strSQL = strSQL + ",'" + paymentVoucher.BRANCH_ID.Replace("'", "''") + "' ";
                    strSQL = strSQL + ",'" + paymentVoucher.COMPANY_ID + "' ";
                    strSQL = strSQL + ",'" + paymentVoucher.LEDGER_NAME.Replace("'", "''") + "' ";
                    strSQL = strSQL + "," + paymentVoucher.COMP_VOUCHER_TYPE + " ";
                    strSQL = strSQL + ",'" + paymentVoucher.COMP_VOUCHER_DATE.ToShortDateString() + "' ";
                    strSQL = strSQL + ",'" + paymentVoucher.COMP_VOUCHER_DATE.ToString("MMMyy").ToUpper() + " ' ";
                    strSQL = strSQL + "," + paymentVoucher.COMP_VOUCHER_AMOUNT + " ";
                    strSQL = strSQL + "," + paymentVoucher.COMP_VOUCHER_NET_AMOUNT + " ";
                    strSQL = strSQL + ",'" + paymentVoucher.COMP_VOUCHER_NARRATION + "' ";
                    strSQL = strSQL + ")";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    //--------Child Table

                    string strChildKey = "", strReverseLedger = "", strDebitLedger = "", strCreditLedger = "";
                    int intloop = 1;
                    if (paymentVoucher.accVoucherList.Count > 2)
                    {
                        strReverseLedger = "As Per Details";
                    }
                    else
                    {
                        strReverseLedger = "";
                    }
                    foreach (var voucheritem in paymentVoucher.accVoucherList)
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
                                strReverseLedger = paymentVoucher.accVoucherList.Find(x => x.VOUCHER_TOBY == "Dr").LEDGER_NAME;
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
                                strReverseLedger = paymentVoucher.accVoucherList.Find(x => x.VOUCHER_TOBY == "Cr").LEDGER_NAME;
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
                    transaction.Commit();
                }
                payment.status = true;
            }
            catch (Exception EX)
            {
                payment.status = false;
                payment.ErrorMessage = EX.Message;
                return payment;
            }
            return payment;
        }

        internal CashAndBankBalanceModel GetCashBalance()
        {
            CashAndBankBalanceModel cash = new CashAndBankBalanceModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var cashBalance = connection.Query<CashAndBankBalanceModel>("rpt_GET_CURRENT_CASH_BALANCE");
                    if (cashBalance.Count() > 0)
                    {
                        cash = cashBalance.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return cash;
        }
        internal List<LedgerModel> GetBankLedgerList()
        {
            List<LedgerModel> ledgerList = new List<LedgerModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var ledger = connection.Query<LedgerModel>("rpt_GET_BANK_LEDGER_LIST");
                    if (ledger.Count() > 0)
                    {
                        ledgerList = ledger.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerList;
        }
        internal List<ACC_VOUCHER_MODEL> GetBankVoucherList()
        {
            List<ACC_VOUCHER_MODEL> ledgerList = new List<ACC_VOUCHER_MODEL>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var ledger = connection.Query<ACC_VOUCHER_MODEL>("rpt_GET_BANK_VOUCHER_LIST");
                    if (ledger.Count() > 0)
                    {
                        ledgerList = ledger.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerList;
        }

        internal List<ACC_Trial_Balance_Report> GetTrialBalance(string fromDate, string toDate)
        {
            List<ACC_Trial_Balance_Report> List = new List<ACC_Trial_Balance_Report>();
            List<ACC_Trial_Balance_Report> trialBalanceList = new List<ACC_Trial_Balance_Report>();
            ACC_Trial_Balance_Report trialB = new ACC_Trial_Balance_Report();
            try
            {
                int i = 0;
                var parameters = new DynamicParameters();
                parameters.Add("@frDate", fromDate, DbType.String);
                parameters.Add("@toDate", toDate, DbType.String);
                parameters.Add("@OpenOrClose", i, DbType.Int32);

                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var trialBalance = connection.Query<ACC_Trial_Balance_Report>("GET_TRIAL_BALANCE", parameters, commandType: CommandType.StoredProcedure);
                    //var trialBalance = connection.Query<ACC_Trial_Balance_Report>("select * from ACC_TRIAL_BALANCE");
                    if (trialBalance.Count() > 0)
                    {
                        foreach (var item in trialBalance)
                        {
                            decimal gr_O = Convert.ToDecimal(item.GR_OPENING);
                            decimal gr_d = Convert.ToDecimal(item.GR_DEBIT);
                            decimal gr_c = Convert.ToDecimal(item.GR_CREDIT);
                            decimal cl_d = gr_O + gr_d + gr_c;
                            decimal Closing_gr_d = 0;
                            decimal Closing_gr_c = 0;
                            if (cl_d < 0) { Closing_gr_d = cl_d; }
                            else { Closing_gr_d = 0; }
                            if (cl_d > 0) { Closing_gr_c = cl_d; }
                            else { Closing_gr_d = 0; }
                            //decimal Closing_gr_d = Convert.ToDecimal(item.GR_OPENING)+ Convert.ToDecimal(item.GR_DEBIT);
                            //decimal Closing_gr_c = Convert.ToDecimal(item.GR_OPENING) - Convert.ToDecimal(item.GR_CREDIT);

                            trialB = new ACC_Trial_Balance_Report();
                            trialB.GR_NAME = item.GR_NAME;
                            trialB.GR_PARENT = item.GR_PARENT;
                            trialB.GR_OPENING = gr_O.ToString("#,##0.00").Replace("-", ""); //(item.GR_OPENING).ToString("#,##0.00");
                            trialB.GR_DEBIT = gr_d.ToString("#,##0.00").Replace("-", "");// Convert.ToDecimal((item.GR_DEBIT).ToString("#,##0"));
                            trialB.GR_CREDIT = gr_c.ToString("#,##0.00").Replace("-", ""); //Convert.ToDecimal((item.GR_CREDIT).ToString("#,##0"));
                            trialB.C_GR_DEBIT = Closing_gr_d.ToString("#,##0.00").Replace("-", ""); //Convert.ToDecimal((item.GR_OPENING + item.GR_DEBIT).ToString("#,##0")); 
                            trialB.C_GR_CREDIT = Closing_gr_c.ToString("#,##0.00").Replace("-", ""); //Convert.ToDecimal((item.GR_OPENING - item.GR_CREDIT).ToString("#,##0"));                            

                            trialBalanceList.Add(trialB);

                        }

                        //trialBalanceList = trialBalance.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return trialBalanceList;
        }
        //

        internal List<ACC_Trial_Balance_Report> GetACCTrialBalance(string fromDate, string toDate)
        {
            List<ACC_Trial_Balance_Report> List = new List<ACC_Trial_Balance_Report>();
            List<ACC_Trial_Balance_Report> trialBalanceList = new List<ACC_Trial_Balance_Report>();
            ACC_Trial_Balance_Report trialB = new ACC_Trial_Balance_Report();
            try
            {
                int i = 0;
                var parameters = new DynamicParameters();
                parameters.Add("@frDate", fromDate, DbType.String);
                parameters.Add("@toDate", toDate, DbType.String);
                parameters.Add("@OpenOrClose", i, DbType.Int32);

                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var trialBalance = connection.Query<ACC_Trial_Balance_Report>("SP_ACC_GET_TRIAL_BALANCE", parameters, commandType: CommandType.StoredProcedure);
                    //var trialBalance = connection.Query<ACC_Trial_Balance_Report>("select * from ACC_TRIAL_BALANCE");
                    if (trialBalance.Count() > 0)
                    {
                        foreach (var item in trialBalance)
                        {

                            decimal gr_O = 0;
                            decimal gr_d = 0;
                            decimal gr_c = 0;
                            if (item.GR_OPENING != "")
                            { gr_O = Convert.ToDecimal(item.GR_OPENING); }
                            if (item.GR_DEBIT != "")
                            { gr_d = Convert.ToDecimal(item.GR_DEBIT); }
                            if (item.GR_CREDIT != "")
                            { gr_c = Convert.ToDecimal(item.GR_CREDIT); }

                            //decimal cl_d = gr_O + gr_d + gr_c;
                            //decimal Closing_gr_d = 0;
                            //decimal Closing_gr_c = 0;
                            //if (cl_d < 0) { Closing_gr_d = cl_d; }
                            //else { Closing_gr_d = 0; }
                            //if (cl_d > 0) { Closing_gr_c = cl_d; }
                            //else { Closing_gr_d = 0; }
                            //decimal Closing_gr_d = Convert.ToDecimal(item.GR_OPENING)+ Convert.ToDecimal(item.GR_DEBIT);
                            //decimal Closing_gr_c = Convert.ToDecimal(item.GR_OPENING) - Convert.ToDecimal(item.GR_CREDIT);

                            trialB = new ACC_Trial_Balance_Report();
                            trialB.GR_NAME = item.GR_NAME;
                            trialB.GR_PARENT = item.GR_PARENT;
                            if ((Convert.ToDecimal(item.GR_DEBIT) - Convert.ToDecimal(item.GR_CREDIT)) > 0)
                            {
                                trialB.GR_DEBIT = Convert.ToString(Convert.ToDecimal(item.GR_DEBIT) - Convert.ToDecimal(item.GR_CREDIT));
                                trialB.GR_CREDIT = "0.00";
                                gr_d = Convert.ToDecimal(trialB.GR_DEBIT);
                                gr_c = Convert.ToDecimal(trialB.GR_CREDIT);
                            }
                            else if ((Convert.ToDecimal(item.GR_DEBIT) - Convert.ToDecimal(item.GR_CREDIT)) < 0)
                            {
                                trialB.GR_DEBIT = "0.00";
                                trialB.GR_CREDIT = Convert.ToString(Convert.ToDecimal(item.GR_DEBIT) - Convert.ToDecimal(item.GR_CREDIT));
                                gr_d = Convert.ToDecimal(trialB.GR_DEBIT);
                                gr_c = Convert.ToDecimal(trialB.GR_CREDIT);
                            }

                            //trialB.GR_OPENING = gr_O.ToString("#,##0.00").Replace("-", ""); //(item.GR_OPENING).ToString("#,##0.00");
                            trialB.GR_DEBIT = gr_d.ToString("#,##0.00").Replace("-", "");// Convert.ToDecimal((item.GR_DEBIT).ToString("#,##0"));
                            trialB.GR_CREDIT = gr_c.ToString("#,##0.00").Replace("-", ""); //Convert.ToDecimal((item.GR_CREDIT).ToString("#,##0"));
                                                                                           // trialB.C_GR_DEBIT = Closing_gr_d.ToString("#,##0.00").Replace("-", ""); //Convert.ToDecimal((item.GR_OPENING + item.GR_DEBIT).ToString("#,##0")); 
                                                                                           //trialB.C_GR_CREDIT = Closing_gr_c.ToString("#,##0.00").Replace("-", ""); //Convert.ToDecimal((item.GR_OPENING - item.GR_CREDIT).ToString("#,##0"));                            

                            trialBalanceList.Add(trialB);

                        }

                        //trialBalanceList = trialBalance.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return trialBalanceList;
        }

        internal List<ACC_PROFIT_LOSS> GetProfitAndLoss(string fromDate, string toDate)
        {
            List<ACC_PROFIT_LOSS> List = new List<ACC_PROFIT_LOSS>();
            List<ACC_PROFIT_LOSS> trialBalanceList = new List<ACC_PROFIT_LOSS>();
            ACC_PROFIT_LOSS trialB = new ACC_PROFIT_LOSS();
            try
            {
                double dblGP = gdblGP(fromDate, toDate);
                var parameters = new DynamicParameters();
                parameters.Add("@frDate", fromDate, DbType.String);
                parameters.Add("@toDate", toDate, DbType.String);
                parameters.Add("@dblGP", dblGP, DbType.Double);

                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var trialBalance = connection.Query<ACC_PROFIT_LOSS>("GET_PROFIT_AND_LOSS", parameters, commandType: CommandType.StoredProcedure);

                    if (trialBalance.Count() > 0)
                    {
                        foreach (var item in trialBalance)
                        {
                            //decimal gr_O = Convert.ToDecimal(item.GR_OPENING);
                            //decimal gr_d = Convert.ToDecimal(item.GR_DEBIT);
                            //decimal gr_c = Convert.ToDecimal(item.GR_CREDIT);
                            //decimal Closing_gr_d = Convert.ToDecimal(item.GR_OPENING) + Convert.ToDecimal(item.GR_DEBIT);
                            //decimal Closing_gr_c = Convert.ToDecimal(item.GR_OPENING) - Convert.ToDecimal(item.GR_CREDIT);

                            trialB = new ACC_PROFIT_LOSS();
                            trialB.GR_NAME = item.GR_NAME;
                            trialB.GR_PARENT = item.GR_PARENT;
                            if (item.GR_PRIMARY_TYPE == "3")
                            { trialB.GR_PRIMARY_TYPE = "Income"; }
                            else if (item.GR_PRIMARY_TYPE == "4")
                            { trialB.GR_PRIMARY_TYPE = "Expenses"; }

                            trialB.GR_AMOUNT = item.GR_AMOUNT;
                            //trialB.GR_OPENING = gr_O.ToString("#,##0.00").Replace("-", "");
                            //trialB.GR_DEBIT = gr_d.ToString("#,##0.00").Replace("-", "");
                            //trialB.GR_CREDIT = gr_c.ToString("#,##0.00").Replace("-", ""); 
                            //trialB.C_GR_DEBIT = Closing_gr_d.ToString("#,##0.00").Replace("-", "");  
                            //trialB.C_GR_CREDIT = Closing_gr_c.ToString("#,##0.00").Replace("-", "");                             

                            trialBalanceList.Add(trialB);

                        }

                        //trialBalanceList = trialBalance.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return trialBalanceList;
        }
        //----------
        internal List<ACC_General_Ledger_Report> GetGeneralLedgerReport(string fromDate, string toDate, string ledgerName)
        {
            List<ACC_General_Ledger_Report> List = new List<ACC_General_Ledger_Report>();
            List<ACC_General_Ledger_Report> generalLedger = new List<ACC_General_Ledger_Report>();
            ACC_General_Ledger_Report trialB = new ACC_General_Ledger_Report();
            try
            {
                int i = 0;

                var parameters = new DynamicParameters();
                parameters.Add("@frDate", fromDate, DbType.String);
                parameters.Add("@toDate", toDate, DbType.String);
                parameters.Add("@ledger_name", ledgerName, DbType.String);


                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var ledger = connection.Query<ACC_General_Ledger_Report>("general_ledger_creation", parameters, commandType: CommandType.StoredProcedure);

                    if (ledger.Count() > 0)
                    {
                        generalLedger = ledger.ToList();
                        //foreach (var item in ledger)
                        //{
                        //    decimal gr_O = Convert.ToDecimal(item.GR_OPENING);
                        //    decimal gr_d = Convert.ToDecimal(item.GR_DEBIT);
                        //    decimal gr_c = Convert.ToDecimal(item.GR_CREDIT);
                        //    decimal Closing_gr_d = Convert.ToDecimal(item.GR_OPENING) + Convert.ToDecimal(item.GR_DEBIT);
                        //    decimal Closing_gr_c = Convert.ToDecimal(item.GR_OPENING) - Convert.ToDecimal(item.GR_CREDIT);

                        //    trialB = new ACC_General_Ledger_Report();
                        //    trialB.GR_NAME = item.GR_NAME;
                        //    trialB.GR_PARENT = item.GR_PARENT;
                        //    if (item.GR_PRIMARY_TYPE == "1")
                        //    { trialB.GR_PRIMARY_TYPE = "Assets"; }
                        //    else if (item.GR_PRIMARY_TYPE == "2")
                        //    { trialB.GR_PRIMARY_TYPE = "Liabilities"; }

                        //    trialB.GR_AMOUNT = (item.GR_AMOUNT).Replace("-", "");


                        //    trialBalanceList.Add(trialB);

                        //}


                    }
                }
            }
            catch (Exception ex)
            {

            }
            return generalLedger;
        }
        //--
        internal LedgerModel GetLedgerDataByLedgerName(string ledgerName)
        {

            LedgerModel ledgerData = new LedgerModel();
            try
            {

                var parameters = new DynamicParameters();

                //parameters.Add("@ledger_name", ledgerName, DbType.String);


                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var ledger = connection.Query<LedgerModel>("Select * From A_M_LEDGER Where LEDGER_NAME='" + ledgerName + "'");

                    if (ledger.Count() > 0)
                    {
                        ledgerData = ledger.FirstOrDefault();

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerData;
        }
        internal List<clsAccount_Payable_Balance> GetAccounce_Payable_Balance()
        {

            List<clsAccount_Payable_Balance> ledgerData = new List<clsAccount_Payable_Balance>();
            try
            {
                var parameters = new DynamicParameters();
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var ledger = connection.Query<clsAccount_Payable_Balance>("ACCOUNT_PAYABLE_BALANCE");

                    if (ledger.Count() > 0)
                    {
                        ledgerData = ledger.ToList();

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerData;
        }
        internal List<clsAccount_Payable_Balance> GetAccounce_Receiveable_Balance()
        {

            List<clsAccount_Payable_Balance> ledgerData = new List<clsAccount_Payable_Balance>();
            try
            {
                var parameters = new DynamicParameters();
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var ledger = connection.Query<clsAccount_Payable_Balance>("ACCOUNT_RECEIVEABLE_BALANCE");

                    if (ledger.Count() > 0)
                    {
                        ledgerData = ledger.ToList();

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerData;
        }
        internal List<ACC_Balance_Sheet_Report> GetBalanceSheetReport(string fromDate, string toDate)
        {
            List<ACC_Balance_Sheet_Report> List = new List<ACC_Balance_Sheet_Report>();
            List<ACC_Balance_Sheet_Report> trialBalanceList = new List<ACC_Balance_Sheet_Report>();
            ACC_Balance_Sheet_Report trialB = new ACC_Balance_Sheet_Report();
            try
            {
                int i = 0;
                double dblGP = gdblGP(fromDate, toDate);
                var parameters = new DynamicParameters();
                parameters.Add("@frDate", fromDate, DbType.String);
                parameters.Add("@toDate", toDate, DbType.String);
                parameters.Add("@dblPL4", i, DbType.Int32);
                parameters.Add("@dblGP", dblGP, DbType.Double);

                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var trialBalance = connection.Query<ACC_Balance_Sheet_Report>("generate_balance_sheet_Report", parameters, commandType: CommandType.StoredProcedure);

                    if (trialBalance.Count() > 0)
                    {
                        foreach (var item in trialBalance)
                        {
                            //decimal gr_O = Convert.ToDecimal(item.GR_OPENING);
                            //decimal gr_d = Convert.ToDecimal(item.GR_DEBIT);
                            //decimal gr_c = Convert.ToDecimal(item.GR_CREDIT);
                            //decimal Closing_gr_d = Convert.ToDecimal(item.GR_OPENING) + Convert.ToDecimal(item.GR_DEBIT);
                            //decimal Closing_gr_c = Convert.ToDecimal(item.GR_OPENING) - Convert.ToDecimal(item.GR_CREDIT);

                            trialB = new ACC_Balance_Sheet_Report();
                            trialB.GR_NAME = item.GR_NAME;
                            trialB.GR_PARENT = item.GR_PARENT;
                            if (item.GR_PRIMARY_TYPE == "1")
                            { trialB.GR_PRIMARY_TYPE = "Assets"; }
                            else if (item.GR_PRIMARY_TYPE == "2")
                            { trialB.GR_PRIMARY_TYPE = "Liabilities"; }

                            trialB.GR_AMOUNT = (item.GR_AMOUNT).Replace("-", "");
                            trialB.LEDGER_NAME = item.LEDGER_NAME;
                            //trialB.GR_OPENING = gr_O.ToString("#,##0.00").Replace("-", "");
                            //trialB.GR_DEBIT = gr_d.ToString("#,##0.00").Replace("-", "");
                            //trialB.GR_CREDIT = gr_c.ToString("#,##0.00").Replace("-", ""); 
                            //trialB.C_GR_DEBIT = Closing_gr_d.ToString("#,##0.00").Replace("-", "");  
                            //trialB.C_GR_CREDIT = Closing_gr_c.ToString("#,##0.00").Replace("-", "");                             

                            trialBalanceList.Add(trialB);

                        }

                        //trialBalanceList = trialBalance.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return trialBalanceList;
        }

        private double gdblGP(string vdteFromDate, string vdteTodate)
        {
            string strSQL = "";
            double dblOpeningStock = 0, dblClosingStock = 0, dblCGS = 0, dblPurchase = 0, dblSales = 0;
            string connstring = "";
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            using (SqlConnection gcnMain = new SqlConnection(Global.ConnectionString))
            {
                if (gcnMain.State == ConnectionState.Open)
                {
                    gcnMain.Close();
                }
                gcnMain.Open();

                cmd.Connection = gcnMain;

                strSQL = "SELECT ";
                strSQL = strSQL + "ISNULL(SUM(ACC_VOUCHER.VOUCHER_CREDIT_AMOUNT - ACC_VOUCHER.VOUCHER_DEBIT_AMOUNT),0) AS DEBIT_TOTAL ";
                strSQL = strSQL + "FROM ACC_VOUCHER LEFT OUTER JOIN ";
                strSQL = strSQL + "ACC_LEDGER_GROUP_QRY ON ACC_VOUCHER.LEDGER_NAME = ACC_LEDGER_GROUP_QRY.LEDGER_NAME ";
                strSQL = strSQL + "WHERE (ACC_LEDGER_GROUP_QRY.GR_PRIMARY_TYPE = 3) ";
                strSQL = strSQL + "AND ACC_LEDGER_GROUP_QRY.GR_GROUP LIKE '211%' ";
                strSQL = strSQL + "AND (COMP_VOUCHER_DATE BETWEEN '" + vdteFromDate + "' ";
                strSQL = strSQL + "AND '" + vdteTodate + "') ";
                strSQL = strSQL + "AND ACC_LEDGER_GROUP_QRY.GR_LEVEL = 2 ";
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dblSales = Convert.ToDouble(dr["DEBIT_TOTAL"]);
                }
                dr.Close();
                strSQL = "SELECT ISNULL(SUM( VOUCHER_CREDIT_AMOUNT - VOUCHER_DEBIT_AMOUNT),0) AS TOTAL ";
                strSQL = strSQL + "FROM ACC_MAIN_LEDGER ";
                strSQL = strSQL + "WHERE (COMP_VOUCHER_DATE BETWEEN '" + vdteFromDate + "'";
                strSQL = strSQL + "AND '" + vdteTodate + "') ";
                strSQL = strSQL + "AND LEDGER_GROUP LIKE '211%' ";
                strSQL = strSQL + "AND LEDGER_PRIMARY_TYPE = 3 ";
                strSQL = strSQL + "AND LEDGER_LEVEL = 2 ";
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dblSales = dblSales + Convert.ToDouble(dr["TOTAL"]);
                }
                dr.Close();
                strSQL = "SELECT ";
                strSQL = strSQL + "ISNULL(SUM(ACC_VOUCHER.VOUCHER_DEBIT_AMOUNT - ACC_VOUCHER.VOUCHER_CREDIT_AMOUNT),0) AS DEBIT_TOTAL ";
                strSQL = strSQL + "FROM ACC_VOUCHER LEFT OUTER JOIN ";
                strSQL = strSQL + "ACC_LEDGER_GROUP_QRY ON ACC_VOUCHER.LEDGER_NAME = ACC_LEDGER_GROUP_QRY.LEDGER_NAME ";
                strSQL = strSQL + "WHERE (ACC_LEDGER_GROUP_QRY.GR_PRIMARY_TYPE = 4) ";
                strSQL = strSQL + "AND ACC_LEDGER_GROUP_QRY.GR_GROUP LIKE '21%' ";
                strSQL = strSQL + "AND (COMP_VOUCHER_DATE BETWEEN '" + vdteFromDate + "' ";
                strSQL = strSQL + "AND '" + vdteTodate + "') ";
                strSQL = strSQL + "AND ACC_LEDGER_GROUP_QRY.GR_LEVEL = 2 ";
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dblPurchase = Convert.ToDouble(dr["DEBIT_TOTAL"]);
                }
                dr.Close();


                strSQL = "SELECT ISNULL(SUM(VOUCHER_DEBIT_AMOUNT - VOUCHER_CREDIT_AMOUNT),0) AS TOTAL ";
                strSQL = strSQL + "FROM ACC_MAIN_LEDGER ";
                strSQL = strSQL + "WHERE ";
                strSQL = strSQL + " (COMP_VOUCHER_DATE BETWEEN '" + vdteFromDate + "' ";
                strSQL = strSQL + "AND '" + vdteTodate + "') ";
                strSQL = strSQL + "AND LEDGER_GROUP LIKE '21%' ";
                strSQL = strSQL + "AND LEDGER_PRIMARY_TYPE = 4 ";
                strSQL = strSQL + "AND LEDGER_LEVEL = 2 ";
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dblPurchase = dblPurchase + Convert.ToDouble(dr["TOTAL"]);
                }
                dr.Close();
                dblCGS = (dblOpeningStock + dblPurchase) - dblClosingStock;
                return (dblSales - dblCGS);


            }
        }

        internal string GetACCVoucherNo(string type)
        {
            string accVoucherNo = "";
            IDataReader dr;
            dr = SqlHelper.ExecuteReader(Global.ConnectionString, "SP_SEQUENCE_GENERATE_ACC_VOUCHER_NO", type);
            while (dr.Read())
            {
                accVoucherNo = dr["VOUCHER_NO"].ToString();
            }
            return accVoucherNo;
        }

        internal string GetPurchaseVoucherNo()
        {
            string accVoucherNo = "";
            IDataReader dr;
            dr = SqlHelper.ExecuteReader(Global.ConnectionString, "GET_VOUCHER_NO");
            while (dr.Read())
            {
                accVoucherNo = dr["VOUCHER_NO"].ToString();
            }
            return accVoucherNo;
        }

        //----Update

        internal ACC_COMPANY_VOUCHER_MODEL UpdateACC_COMPANY_VOUCHER_PAYMENTVOUCHER(ACC_COMPANY_VOUCHER_MODEL paymentVoucher)
        {
            ACC_COMPANY_VOUCHER_MODEL payment = new ACC_COMPANY_VOUCHER_MODEL();
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    strSQL = "Delete FROM ACC_VOUCHER WHERE COMP_REF_NO='" + paymentVoucher.COMP_REF_NO + "'";

                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    //-----------
                    strSQL = "UPDATE ACC_COMPANY_VOUCHER SET LEDGER_NAME = '" + paymentVoucher.LEDGER_NAME.Replace("'", "''") + "', ";
                    strSQL = strSQL + "COMP_VOUCHER_TYPE = '" + paymentVoucher.COMP_VOUCHER_TYPE + "',";
                    strSQL = strSQL + "COMP_VOUCHER_DATE = '" + paymentVoucher.COMP_VOUCHER_DATE.ToShortDateString() + "',";
                    strSQL = strSQL + "COMP_VOUCHER_MONTH_ID = '" + paymentVoucher.COMP_VOUCHER_DATE.ToString("MMMyy").ToUpper() + "', ";
                    strSQL = strSQL + "COMP_VOUCHER_AMOUNT = " + paymentVoucher.COMP_VOUCHER_AMOUNT + ",";
                    strSQL = strSQL + "COMP_VOUCHER_NET_AMOUNT = " + paymentVoucher.COMP_VOUCHER_NET_AMOUNT + ",";
                    strSQL = strSQL + "COMP_VOUCHER_NARRATION = '" + paymentVoucher.COMP_VOUCHER_NARRATION + "' ";
                    strSQL = strSQL + "WHERE COMP_REF_NO = '" + paymentVoucher.COMP_REF_NO + "' ";

                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    //--------Child Table

                    string strChildKey = "", strReverseLedger = "", strDebitLedger = "", strCreditLedger = "";
                    int intloop = 1;
                    if (paymentVoucher.accVoucherList.Count > 2)
                    {
                        strReverseLedger = "As Per Details";
                    }
                    else
                    {
                        strReverseLedger = "";
                    }
                    foreach (var voucheritem in paymentVoucher.accVoucherList)
                    {
                        strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
                        strSQL = "INSERT INTO ACC_VOUCHER";
                        strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
                        strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
                        strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
                        strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,VOUCHER_CHEQUE_NUMBER,VOUCHER_CHEQUE_DATE,VOUCHER_CHEQUE_DRAWN_ON ";   //,TRANSFER_TYPE Not Found In Table
                        strSQL = strSQL + ") VALUES(";
                        strSQL = strSQL + "'" + voucheritem.COMP_REF_NO + "'";
                        strSQL = strSQL + ",'" + paymentVoucher.BRANCH_ID.Replace("'", "''") + "' ";
                        strSQL = strSQL + ",'" + strChildKey + "' ";
                        strSQL = strSQL + "," + paymentVoucher.COMP_VOUCHER_TYPE + " ";
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
                                strReverseLedger = paymentVoucher.accVoucherList.Find(x => x.VOUCHER_TOBY == "Dr").LEDGER_NAME;
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
                                strReverseLedger = paymentVoucher.accVoucherList.Find(x => x.VOUCHER_TOBY == "Cr").LEDGER_NAME;
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
                    transaction.Commit();
                }
                payment.status = true;
            }
            catch (Exception EX)
            {
                payment.status = false;
                payment.ErrorMessage = EX.Message;

            }
            return payment;
        }

        //
        internal VendorPaymentViewModel UpdatePaymentStatus(VendorPaymentViewModel paymentVoucher)
        {
            VendorPaymentViewModel payment = new VendorPaymentViewModel();
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;



                    //-----------
                    strSQL = "UPDATE TBL_VENDOR_PAYMENT SET PAYMENT_STATUS = '" + "Paid" + "' ";

                    strSQL = strSQL + "WHERE VENDOR_PAYMENT_ID = '" + paymentVoucher.VENDOR_PAYMENT_ID + "' ";

                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();


                    transaction.Commit();
                }

            }
            catch (Exception EX)
            {


            }
            return payment;
        }
        //
        internal CustomerPaymentViewModel UpdatePaymentReceiptStatus(CustomerPaymentViewModel paymentVoucher)
        {
            CustomerPaymentViewModel payment = new CustomerPaymentViewModel();
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;



                    //-----------
                    strSQL = "UPDATE TBL_CUSTOMER_PAYMENT SET PAYMENT_STATUS = '" + " Payment Receive" + "' ";

                    strSQL = strSQL + "WHERE CUSTOMER_PAYMENT_ID = '" + paymentVoucher.CUSTOMER_PAYMENT_ID + "' ";

                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();


                    transaction.Commit();
                }

            }
            catch (Exception EX)
            {


            }
            return payment;
        }


        public List<ACC_COMPANY_VOUCHER_MODEL> GetVoucherList(int VoucherType)
        {
            List<ACC_COMPANY_VOUCHER_MODEL> voucherList = new List<ACC_COMPANY_VOUCHER_MODEL>();
            ACC_COMPANY_VOUCHER_MODEL voucher = new ACC_COMPANY_VOUCHER_MODEL();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    //if (connection.State == ConnectionState.Closed) connection.Open();
                    //var voucher = connection.Query<ACC_COMPANY_VOUCHER_MODEL>("SP_GET_PAYMENT_VOUCHER_LIST");
                    IDataReader dr;
                    dr = SqlHelper.ExecuteReader(Global.ConnectionString, "SP_GET_VOUCHER_LIST", VoucherType);

                    while (dr.Read())
                    {
                        voucher = new ACC_COMPANY_VOUCHER_MODEL();
                        voucher.COMP_VOUCHER_SERIAL = Convert.ToInt32(dr["COMP_VOUCHER_SERIAL"]);
                        voucher.COMP_REF_NO = Convert.ToString(dr["COMP_REF_NO"]);
                        voucher.LEDGER_NAME = Convert.ToString(dr["LEDGER_NAME"]);
                        voucher.COMP_VOUCHER_TYPE = Convert.ToInt32(dr["COMP_VOUCHER_TYPE"]);
                        voucher.COMP_VOUCHER_DATE = Convert.ToDateTime(dr["COMP_VOUCHER_DATE"]);
                        voucher.COMP_VOUCHER_NET_AMOUNT = Convert.ToDecimal(dr["COMP_VOUCHER_NET_AMOUNT"]);
                        //var dateTime = Convert.ToDateTime(dr["COMP_VOUCHER_DATE"]);
                        //var shortDateValue = dateTime.ToShortDateString();
                        //DateTime dt = new DateTime();
                        //dt = Convert.ToDateTime(dr["COMP_VOUCHER_MONTH_ID"]);
                        //voucher.COMP_VOUCHER_DATE = shortDateValue;
                        voucher.COMP_VOUCHER_MONTH_ID = Convert.ToString(dr["COMP_VOUCHER_MONTH_ID"]);

                        voucherList.Add(voucher);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return voucherList;
        }
        public List<ACC_VOUCHER_MODEL> GetACCVoucherByRefNo(string refNo)
        {

            ACC_COMPANY_VOUCHER_MODEL voucher = new ACC_COMPANY_VOUCHER_MODEL();
            List<ACC_VOUCHER_MODEL> accVoucherChild = new List<ACC_VOUCHER_MODEL>();
            ACC_VOUCHER_MODEL accVoucher = new ACC_VOUCHER_MODEL();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var voucherMaster = connection.Query<ACC_COMPANY_VOUCHER_MODEL>("SELECT * FROM ACC_COMPANY_VOUCHER WHERE COMP_REF_NO='" + refNo + "'");
                    //var voucherItem =connection.Query<List<ACC_VOUCHER_MODEL>>("SELECT * FROM ACC_VOUCHER WHERE COMP_REF_NO='" + refNo + "'");
                    if (voucherMaster.Count() > 0)
                    {
                        voucher = voucherMaster.FirstOrDefault();
                    }
                    IDataReader dr;
                    dr = SqlHelper.ExecuteReader(Global.ConnectionString, "SP_PAYMENT_REPORT", refNo);

                    while (dr.Read())
                    {
                        accVoucher = new ACC_VOUCHER_MODEL();
                        accVoucher.VOUCHER_SERIAL = Convert.ToString(dr["VOUCHER_SERIAL"]);
                        accVoucher.Voucher_date = Convert.ToString(dr["COMP_VOUCHER_DATE"]);
                        accVoucher.COMP_REF_NO = Convert.ToString(dr["COMP_REF_NO"]);
                        accVoucher.VOUCHER_TOBY = Convert.ToString(dr["VOUCHER_TOBY"]);
                        accVoucher.LEDGER_NAME = Convert.ToString(dr["LEDGER_NAME"]);
                        accVoucher.VOUCHER_DEBIT_AMOUNT = Convert.ToDecimal(dr["VOUCHER_DEBIT_AMOUNT"]);
                        accVoucher.VOUCHER_CREDIT_AMOUNT = Convert.ToDecimal(dr["VOUCHER_CREDIT_AMOUNT"]);
                        accVoucher.COMP_VOUCHER_AMOUNT = Convert.ToDecimal(dr["COMP_VOUCHER_AMOUNT"]);
                        accVoucher.VOUCHER_CHEQUE_NUMBER = Convert.ToString(dr["VOUCHER_CHEQUE_NUMBER"]);
                        accVoucher.VOUCHER_CHEQUE_DATE = Convert.ToDateTime(dr["VOUCHER_CHEQUE_DATE"]);
                        accVoucher.VOUCHER_CHEQUE_DRAWN_ON = Convert.ToString(dr["VOUCHER_CHEQUE_DRAWN_ON"]);
                        accVoucher.COMP_VOUCHER_NARRATION = Convert.ToString(dr["COMP_VOUCHER_NARRATION"]);


                        accVoucherChild.Add(accVoucher);
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return accVoucherChild;
        }
        public ACC_COMPANY_VOUCHER_MODEL GetPaymentVoucherByRefNo(string refNo)
        {

            ACC_COMPANY_VOUCHER_MODEL voucher = new ACC_COMPANY_VOUCHER_MODEL();
            ACC_VOUCHER_MODEL accVoucherChild = new ACC_VOUCHER_MODEL();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@COMP_REF_NO", refNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    //var voucherMaster = connection.Query<ACC_COMPANY_VOUCHER_MODEL>("SP_GET_ACC_COMPANY_VOUCHER", parameters, commandType: CommandType.StoredProcedure);
                    var voucherMaster = connection.Query<ACC_COMPANY_VOUCHER_MODEL>("SELECT * FROM ACC_COMPANY_VOUCHER WHERE COMP_REF_NO='" + refNo + "'");
                    var voucherChild = connection.Query<ACC_VOUCHER_MODEL>("SELECT * FROM ACC_VOUCHER WHERE COMP_REF_NO='" + refNo + "'");
                    if (voucherMaster.Count() > 0)
                    {
                        voucher = voucherMaster.FirstOrDefault();
                    }
                    voucher.accVoucherList = voucherChild.ToList();

                    //IDataReader dr;
                    //dr = SqlHelper.ExecuteReader(Global.ConnectionString, "SP_GET_ACC_VOUCHER", refNo);

                    //while (dr.Read())
                    //{
                    //    accVoucherChild = new ACC_VOUCHER_MODEL();
                    //    accVoucherChild.COMP_REF_NO = Convert.ToString(dr["COMP_REF_NO"]);
                    //    accVoucherChild.VOUCHER_SERIAL = Convert.ToString(dr["VOUCHER_SERIAL"]);
                    //    accVoucherChild.VOUCHER_TOBY = Convert.ToString(dr["VOUCHER_TOBY"]);
                    //    accVoucherChild.LEDGER_NAME = Convert.ToString(dr["LEDGER_NAME"]);
                    //    accVoucherChild.VOUCHER_DEBIT_AMOUNT = Convert.ToDecimal(dr["VOUCHER_DEBIT_AMOUNT"]);
                    //    accVoucherChild.VOUCHER_CREDIT_AMOUNT = Convert.ToDecimal(dr["VOUCHER_CREDIT_AMOUNT"]);
                    //    accVoucherChild.VOUCHER_CHEQUE_NUMBER = Convert.ToString(dr["VOUCHER_CHEQUE_NUMBER"]);
                    //    //if(Convert.ToString(dr["VOUCHER_CHEQUE_DATE"])=="NULL" || Convert.ToString(dr["VOUCHER_CHEQUE_DATE"])=="")
                    //    //{ accVoucherChild.VOUCHER_CHEQUE_DATE = null; }
                    //    //else { accVoucherChild.VOUCHER_CHEQUE_DATE = Convert.ToDateTime(dr["VOUCHER_CHEQUE_DATE"]); }
                    //    //accVoucherChild.Voucherchequedate = Convert.ToString(dr["VOUCHER_CHEQUE_DATE"]);
                    //    accVoucherChild.VOUCHER_CHEQUE_DATE = Convert.ToDateTime(dr["VOUCHER_CHEQUE_DATE"]);
                    //    accVoucherChild.VOUCHER_CHEQUE_DRAWN_ON = Convert.ToString(dr["VOUCHER_CHEQUE_DRAWN_ON"]);


                    //    voucher.accVoucherList.Add(accVoucherChild);
                    //}

                }
            }
            catch (Exception ex)
            {

            }
            return voucher;
        }

        public List<PrimaryModel> GetchartList()
        {
            List<PrimaryModel> list = new List<PrimaryModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var chartList = connection.Query<PrimaryModel>("SELECT * FROM A_M_PRIMARY");
                    if (chartList.Count() > 0)
                    {
                        list = chartList.ToList();
                    }

                }
            }
            catch (Exception ex)
            {

            }

            return list;
        }
        public List<LedgerGroupModel> GetLedgerGroupList()
        {
            List<LedgerGroupModel> ledgerGrouplist = new List<LedgerGroupModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var chartList = connection.Query<LedgerGroupModel>("SELECT * FROM A_M_LEDGERGROUP");
                    if (chartList.Count() > 0)
                    {
                        ledgerGrouplist = chartList.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return ledgerGrouplist;
        }

        public ACC_COMPANY_VOUCHER_MODEL DeletePaymentByRefNo(ACC_COMPANY_VOUCHER_MODEL paymentVoucher)
        {
            try
            {
                //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM SubCategory WHERE SubCategoryId=" + id + "");

                //using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                //{
                //    if (connection.State == ConnectionState.Closed) connection.Open();
                //    connection.Query<CountryModel>("DELETE FROM A_CURRENCY WHERE CURRENCY_SERIAL='" + refNo + "'");

                //}
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    strSQL = "Delete FROM ACC_VOUCHER WHERE COMP_REF_NO='" + paymentVoucher.COMP_REF_NO + "' AND COMP_VOUCHER_TYPE=" + paymentVoucher.COMP_VOUCHER_TYPE + "";



                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    strSQL = "Delete FROM ACC_COMPANY_VOUCHER WHERE COMP_REF_NO='" + paymentVoucher.COMP_REF_NO + "' AND COMP_VOUCHER_TYPE=" + paymentVoucher.COMP_VOUCHER_TYPE + "";

                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();


                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }








        //public DynamicParameters SetPaymentVoucherParameters(ACC_COMPANY_VOUCHER_MODEL payment_voucher)
        //{
        //    DynamicParameters parameters = new DynamicParameters();

        //    parameters.Add("@COMP_VOUCHER_SERIAL", payment_voucher.COMP_VOUCHER_SERIAL);
        //    parameters.Add("@COMP_REF_NO", payment_voucher.COMP_REF_NO);
        //    parameters.Add("@SAMPLE_STATUS", payment_voucher.SAMPLE_STATUS);
        //    parameters.Add("@BRANCH_ID", payment_voucher.BRANCH_ID);
        //    parameters.Add("@LEDGER_NAME", payment_voucher.LEDGER_NAME);
        //    parameters.Add("@COMP_VOUCHER_TYPE", payment_voucher.COMP_VOUCHER_TYPE);
        //    parameters.Add("@COMP_VOUCHER_DATE", payment_voucher.COMP_VOUCHER_DATE);
        //    parameters.Add("@COMP_VOUCHER_MONTH_ID", payment_voucher.COMP_VOUCHER_MONTH_ID);
        //    parameters.Add("@COMP_VOUCHER_AMOUNT", payment_voucher.COMP_VOUCHER_AMOUNT);
        //    parameters.Add("@COMP_VOUCHER_ADD_AMOUNT", payment_voucher.COMP_VOUCHER_ADD_AMOUNT);
        //    parameters.Add("@COMP_VOUCHER_LESS_AMOUNT", payment_voucher.COMP_VOUCHER_LESS_AMOUNT);
        //    parameters.Add("@COMP_VOUCHER_NET_AMOUNT", payment_voucher.COMP_VOUCHER_NET_AMOUNT);
        //    parameters.Add("@COMP_VOUCHER_PROCESS_AMOUNT", payment_voucher.COMP_VOUCHER_PROCESS_AMOUNT);
        //    parameters.Add("@COMP_VOUCHER_NARRATION", payment_voucher.COMP_VOUCHER_NARRATION);
        //    parameters.Add("@COMP_VOUCHER_TERM_OF_PAYMENTS", payment_voucher.COMP_VOUCHER_TERM_OF_PAYMENTS);
        //    parameters.Add("@COMP_VOUCHER_DESPATCH_THRU", payment_voucher.COMP_VOUCHER_DESPATCH_THRU);
        //    parameters.Add("@COMP_VOUCHER_STATUS", payment_voucher.COMP_VOUCHER_STATUS);
        //    parameters.Add("@COMP_VOUCHER_FC", payment_voucher.COMP_VOUCHER_FC);
        //    parameters.Add("@COMP_AGAINST_REF", payment_voucher.COMP_AGAINST_REF);
        //    parameters.Add("@AGNST_COMP_REF_NO", payment_voucher.AGNST_COMP_REF_NO);
        //    parameters.Add("@ENTRYBY", payment_voucher.ENTRYBY);
        //    parameters.Add("@UPDATEBY", payment_voucher.UPDATEBY);
        //    return parameters;
        //}

        //internal List<ACC_VOUCHER_MODEL> ADD_ACC_VOUCHER_MODEL_PAYMENTVOUCHER_DETAILS(List<ACC_VOUCHER_MODEL> paymentVoucher_Details)
        //{
        //    List<ACC_VOUCHER_MODEL> paymentDetails = new List<ACC_VOUCHER_MODEL>();
        //    try
        //    {

        //        //if (dblpfAmnt > 0 && dblHlamnt > 0)
        //        //{
        //        //    strReverseLedger = "As Per Details";
        //        //}
        //        //else if (dblpfAmnt > 0)
        //        //{
        //        //    strReverseLedger = strPFLedger;
        //        //    strPrefix = "PF";
        //        //}
        //        //else if (dblHlamnt > 0)
        //        //{
        //        //    strReverseLedger = strHLLedger;
        //        //    strPrefix = "HL";
        //        //}

        //        //if (strReverseLedger == "As Per Details")
        //        //{
        //            //strBillWiseRef = strRefNumber + intvoucherPosition.ToString("0000");
        //            //strSQL = "INSERT INTO ACC_VOUCHER";
        //            //strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
        //            //strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
        //            //strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
        //            //strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,AUTOJV,REVERSE_LEDGER1,TRANSFER_TYPE,REPLAMENT ";
        //            //strSQL = strSQL + ") VALUES(";
        //            //strSQL = strSQL + "'" + strRefNumber + "'";
        //            //strSQL = strSQL + ",'" + strBranchID.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",'" + strBillWiseRef + "' ";
        //            //strSQL = strSQL + "," + vlngVoucherType + "";
        //            //strSQL = strSQL + "," + intvoucherPosition + "";
        //            //strSQL = strSQL + "," + Utility.cvtSQLDateString(rowdefault["COMP_VOUCHER_DATE"].ToString()) + "";
        //            //strSQL = strSQL + ",'" + strMainLegder.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + "," + dblAmount + " ";
        //            //strSQL = strSQL + ",0 ";
        //            //strSQL = strSQL + ",'Dr'";
        //            //strSQL = strSQL + ",'" + strReverseLedger.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",1";
        //            //strSQL = strSQL + ",'" + strReverseLedger.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",1";
        //            //strSQL = strSQL + ",'" + strMainLegder.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ")";
        //            //cmdInsert.CommandText = strSQL;
        //            //cmdInsert.ExecuteNonQuery();
        //            //intvoucherPosition += 1;
        //            //strBillWiseRef = strRefNumber + intvoucherPosition.ToString("0000");
        //            //strSQL = "INSERT INTO ACC_VOUCHER";
        //            //strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
        //            //strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
        //            //strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
        //            //strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,AUTOJV,REVERSE_LEDGER1,LEDG_PREFIX,TRANSFER_TYPE,REPLAMENT ";
        //            //strSQL = strSQL + ") VALUES(";
        //            //strSQL = strSQL + "'" + strRefNumber + "'";
        //            //strSQL = strSQL + ",'" + strBranchID.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",'" + strBillWiseRef + "' ";
        //            //strSQL = strSQL + "," + vlngVoucherType + "";
        //            //strSQL = strSQL + "," + intvoucherPosition + "";
        //            //strSQL = strSQL + "," + Utility.cvtSQLDateString(rowdefault["COMP_VOUCHER_DATE"].ToString()) + "";
        //            //strSQL = strSQL + ",'" + strPFLedger.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",0 ";
        //            //strSQL = strSQL + "," + dblpfAmnt + " ";
        //            //strSQL = strSQL + ",'Cr'";
        //            //strSQL = strSQL + ",'" + strReverseLedger.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",1";
        //            //strSQL = strSQL + ",'" + strMainLegder.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",'PF' ";
        //            //strSQL = strSQL + ",1";
        //            //strSQL = strSQL + ",'" + strMainLegder.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ")";
        //            //cmdInsert.CommandText = strSQL;
        //            //cmdInsert.ExecuteNonQuery();
        //            //intvoucherPosition += 1;
        //            //strBillWiseRef = strRefNumber + intvoucherPosition.ToString("0000");
        //            //strSQL = "INSERT INTO ACC_VOUCHER";
        //            //strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
        //            //strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
        //            //strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
        //            //strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER,AUTOJV,REVERSE_LEDGER1,LEDG_PREFIX,TRANSFER_TYPE,REPLAMENT ";
        //            //strSQL = strSQL + ") VALUES(";
        //            //strSQL = strSQL + "'" + strRefNumber + "'";
        //            //strSQL = strSQL + ",'" + strBranchID.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",'" + strBillWiseRef + "' ";
        //            //strSQL = strSQL + "," + vlngVoucherType + "";
        //            //strSQL = strSQL + "," + intvoucherPosition + "";
        //            //strSQL = strSQL + "," + Utility.cvtSQLDateString(rowdefault["COMP_VOUCHER_DATE"].ToString()) + "";
        //            //strSQL = strSQL + ",'" + strHLLedger.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",0 ";
        //            //strSQL = strSQL + "," + dblHlamnt + " ";
        //            //strSQL = strSQL + ",'Cr'";
        //            //strSQL = strSQL + ",'" + strReverseLedger.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",1";
        //            //strSQL = strSQL + ",'" + strMainLegder.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ",'HL' ";
        //            //strSQL = strSQL + ",1";
        //            //strSQL = strSQL + ",'" + strMainLegder.Replace("'", "''") + "' ";
        //            //strSQL = strSQL + ")";

        //            //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
        //        //}







        //        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
        //        {
        //            if (connection.State == ConnectionState.Closed) connection.Open();

        //            string strChildKey = "",strReverseLedger="",strDebitLedger="",strCreditLedger="";
        //            int intloop = 1;


        //            foreach (var voucheritem in paymentVoucher_Details)
        //            {
        //                strChildKey = voucheritem.COMP_REF_NO + intloop.ToString().PadLeft(4, '0');
        //                strSQL = "INSERT INTO ACC_VOUCHER";
        //                strSQL = strSQL + "(COMP_REF_NO,BRANCH_ID,VOUCHER_REF_KEY,COMP_VOUCHER_TYPE,";
        //                strSQL = strSQL + "COMP_VOUCHER_POSITION,COMP_VOUCHER_DATE,LEDGER_NAME,";
        //                strSQL = strSQL + "VOUCHER_DEBIT_AMOUNT,VOUCHER_CREDIT_AMOUNT,";
        //                strSQL = strSQL + "VOUCHER_TOBY,VOUCHER_REVERSE_LEDGER ";   //,TRANSFER_TYPE Not Found In Table
        //                strSQL = strSQL + ") VALUES(";
        //                strSQL = strSQL + "'" + voucheritem.COMP_REF_NO + "'";
        //                strSQL = strSQL + ",'" + voucheritem.BRANCH_ID.Replace("'", "''") + "' ";
        //                strSQL = strSQL + ",'" + strChildKey + "' ";
        //                strSQL = strSQL + "," + voucheritem.COMP_VOUCHER_TYPE + "";
        //                strSQL = strSQL + "," + intloop + "";
        //                strSQL = strSQL + ",'" + voucheritem.COMP_VOUCHER_DATE.ToShortDateString() + "'";
        //                strSQL = strSQL + ",'" + voucheritem.LEDGER_NAME.Replace("'", "''") + "' ";

        //                //   ,AUTOJV  Not Found in Table

        //                if (voucheritem.VOUCHER_TOBY=="Dr")
        //                {
        //                    strSQL = strSQL + "," + voucheritem.VOUCHER_DEBIT_AMOUNT + " ";
        //                    strSQL = strSQL + ",0 ";
        //                    strSQL = strSQL + ",'Dr'";
        //                    if (intloop > 2)
        //                    {
        //                        strReverseLedger = "As Per Details";
        //                    }
        //                    else
        //                    {
        //                        strCreditLedger = strDebitLedger;
        //                    }
        //                }
        //                else if(voucheritem.VOUCHER_TOBY=="Cr")
        //                {
        //                    strSQL = strSQL + ",0 ";
        //                    strSQL = strSQL + "," + voucheritem.VOUCHER_CREDIT_AMOUNT + " ";                            
        //                    strSQL = strSQL + ",'Cr'";
        //                    if (intloop > 2)
        //                    {
        //                        strReverseLedger = "As Per Details";
        //                    }
        //                    else
        //                    {
        //                        strDebitLedger = strCreditLedger;
        //                    }
        //                }

        //                strSQL = strSQL + ",'" + voucheritem.VOUCHER_REVERSE_LEDGER + "' ";
        //                strSQL = strSQL + ")";

        //                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);

        //                intloop += 1;
        //            }



        //        }
        //    }
        //    catch (Exception EX)
        //    {

        //    }
        //    return paymentDetails;
        //}
        //public DynamicParameters SetPaymentVoucherDetailsParameters(ACC_VOUCHER_MODEL paymentVoucher_Details)
        //{
        //    DynamicParameters parameters = new DynamicParameters();

        //    parameters.Add("@VOUCHER_SERIAL", paymentVoucher_Details.VOUCHER_SERIAL);
        //    parameters.Add("@COMP_REF_NO", paymentVoucher_Details.COMP_REF_NO);           
        //    parameters.Add("@VOUCHER_REF_KEY", paymentVoucher_Details.VOUCHER_REF_KEY);
        //    parameters.Add("@BRANCH_ID", paymentVoucher_Details.BRANCH_ID);
        //    parameters.Add("@COMP_VOUCHER_TYPE", paymentVoucher_Details.COMP_VOUCHER_TYPE);
        //    parameters.Add("@COMP_VOUCHER_POSITION", paymentVoucher_Details.COMP_VOUCHER_POSITION);
        //    parameters.Add("@COMP_VOUCHER_DATE", paymentVoucher_Details.COMP_VOUCHER_DATE);
        //    parameters.Add("@LEDGER_NAME", paymentVoucher_Details.LEDGER_NAME);
        //    parameters.Add("@VOUCHER_CHEQUE_NUMBER", paymentVoucher_Details.VOUCHER_CHEQUE_NUMBER);
        //    parameters.Add("@VOUCHER_CHEQUE_DATE", paymentVoucher_Details.VOUCHER_CHEQUE_DATE);
        //    parameters.Add("@VOUCHER_CHEQUE_DRAWN_ON", paymentVoucher_Details.VOUCHER_CHEQUE_DRAWN_ON);
        //    parameters.Add("@VOUCHER_BANK_DATE", paymentVoucher_Details.VOUCHER_BANK_DATE);
        //    parameters.Add("@VOUCHER_DEBIT_AMOUNT", paymentVoucher_Details.VOUCHER_DEBIT_AMOUNT);
        //    parameters.Add("@VOUCHER_CREDIT_AMOUNT", paymentVoucher_Details.VOUCHER_CREDIT_AMOUNT);
        //    parameters.Add("@VOUCHER_ADD_AMOUNT", paymentVoucher_Details.VOUCHER_ADD_AMOUNT);
        //    parameters.Add("@VOUCHER_LESS_AMOUNT", paymentVoucher_Details.VOUCHER_LESS_AMOUNT);
        //    parameters.Add("@VOUCHER_TOBY", paymentVoucher_Details.VOUCHER_TOBY);
        //    parameters.Add("@VOUCHER_REVERSE_LEDGER", paymentVoucher_Details.VOUCHER_REVERSE_LEDGER);
        //    parameters.Add("@VOUCHER_FC_DEBIT_AMOUNT", paymentVoucher_Details.VOUCHER_FC_DEBIT_AMOUNT);
        //    parameters.Add("@VOUCHER_FC_CREDIT_AMOUNT", paymentVoucher_Details.VOUCHER_FC_CREDIT_AMOUNT);
        //    parameters.Add("@VOUCHER_CURRENCY_SYMBOL", paymentVoucher_Details.VOUCHER_CURRENCY_SYMBOL);
        //    parameters.Add("@VOUCHER_ADD_LESS_SIGN", paymentVoucher_Details.VOUCHER_ADD_LESS_SIGN);
        //    parameters.Add("@ENTRYBY", paymentVoucher_Details.ENTRYBY);
        //    parameters.Add("@UPDATEBY", paymentVoucher_Details.UPDATEBY);
        //    return parameters;
        //}
        #endregion

        internal clsMiscBillRequisition AddBillReq(clsMiscBillRequisition billReq)
        {
            bool flag = false;
            clsMiscBillRequisition payment = new clsMiscBillRequisition();
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    strSQL = "INSERT INTO TBL_MISC_BILL_REQUISITION(";
                    strSQL = strSQL + "DATE,LEDGER_NAME,LOCATION_FROM,DESTINATION_TO,PURPOSE,TOUR_BY ";
                    strSQL = strSQL + ",AMOUNT,EMPLOYEE,STATUS)";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + billReq.DATE + "' ";
                    strSQL = strSQL + ",'" + billReq.LEDGER_NAME.Replace("'", "''") + "' ";
                    strSQL = strSQL + ",'" + billReq.LOCATION_FROM + "' ";
                    strSQL = strSQL + ",'" + billReq.DESTINATION_TO + "' ";
                    strSQL = strSQL + ",'" + billReq.PURPOSE + " ' ";
                    strSQL = strSQL + ",'" + billReq.TOUR_BY + "' ";
                    strSQL = strSQL + "," + billReq.AMOUNT + " ";
                    strSQL = strSQL + ",'" + billReq.EMPLOYEE + "' ";
                    strSQL = strSQL + ",'" + billReq.STATUS + "' ";
                    strSQL = strSQL + ")";
                    command.CommandText = strSQL;
                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
            catch (Exception EX)
            {

            }
            return payment;
        }
        public List<clsMiscBillRequisition> GetBillReqList()
        {
            List<clsMiscBillRequisition> ledgerGrouplist = new List<clsMiscBillRequisition>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var chartList = connection.Query<clsMiscBillRequisition>("Select BILL_REQUISITION_ID,CONVERT(varchar,Date,106)DATE,LEDGER_NAME,LOCATION_FROM,DESTINATION_TO,PURPOSE,TOUR_BY,AMOUNT,EMPLOYEE,STATUS from [dbo].[TBL_MISC_BILL_REQUISITION]");
                    if (chartList.Count() > 0)
                    {
                        ledgerGrouplist = chartList.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return ledgerGrouplist;
        }

        public List<clsMiscBillRequisitionViewModel> GetBillReqListById(string Id)
        {
            List<clsMiscBillRequisitionViewModel> ledgerGrouplist = new List<clsMiscBillRequisitionViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var chartList = connection.Query<clsMiscBillRequisitionViewModel>("Select BILL_REQUISITION_ID,CONVERT(varchar,Date,106)DATE,LEDGER_NAME,LOCATION_FROM,DESTINATION_TO,PURPOSE,TOUR_BY,AMOUNT,EMPLOYEE,CONVERT(varchar,ENTRY_DATE,106)ENTRY_DATE from [dbo].[TBL_MISC_BILL_REQUISITION] Where BILL_REQUISITION_ID=" + Id + "");
                    if (chartList.Count() > 0)
                    {
                        ledgerGrouplist = chartList.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return ledgerGrouplist;
        }
    }
}
