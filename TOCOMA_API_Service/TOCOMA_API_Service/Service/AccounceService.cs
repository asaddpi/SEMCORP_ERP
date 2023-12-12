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
    public class AccounceService
    {
        protected readonly ApplicationDbContex _dbContext;
        public AccounceService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        Acc_TransectionModel _otransection = new Acc_TransectionModel();
        internal List<Acc_GeneralJournalModel> GetJournal()
        {
            List<Acc_GeneralJournalModel> journal = new List<Acc_GeneralJournalModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var _obJournal = connection.Query<Acc_GeneralJournalModel>("SP_ACC_GET_GENERAL_JOURNAL");
                    if (_obJournal != null && _obJournal.Count() > 0)
                    {
                        journal = _obJournal.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return journal;
        }
        
        internal string GetTransectionUnicCode()
        {
            string billNo = "";
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var _obJournal = connection.Query<string>("SP_SEQUENCE_GENERATE_TRANSECTION_NO");
                    if (_obJournal != null && _obJournal.Count() > 0)
                    {
                        billNo = _obJournal.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return billNo;
        }
        internal Acc_TransectionModel AddTransection(Acc_TransectionModel transectionModel)
        {
            _otransection = new Acc_TransectionModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<Acc_TransectionModel>("SP_ACC_INSERT_PURCHASE_TRANSECTION",
                        this.SetParameters(transectionModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return _otransection;
        }
        public DynamicParameters SetParameters(Acc_TransectionModel transectionModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TRANSACTION_ID", transectionModel.TRANSACTION_ID);
            parameters.Add("@DOCUMENT_ID", transectionModel.DOCUMENT_ID);
            parameters.Add("@DESCRIPTION", transectionModel.DESCRIPTION);
            parameters.Add("@BILL_NO", transectionModel.BILL_NO);
            return parameters;
        }
        internal int GetTransectionId()
        {
            int transection = 0;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var POID = connection.Query<int>("SELECT TOP 1 TRANSACTION_ID FROM TBL_ACC_TRANSACTION ORDER BY TRANSACTION_ID DESC");
                    if (POID != null && POID.Count() > 0)
                    {
                        transection = POID.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return transection;
        }
        internal List<Acc_LedgerModel> AddJournalDetails(List<Acc_LedgerModel> ledgerList)
        {
            List<Acc_LedgerModel> _oledgerDetails = new List<Acc_LedgerModel>();
            try
            {
                if (ledgerList.Count > 0)
                {
                    foreach (var ledger in ledgerList)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<Acc_LedgerModel>("SP_ACC_INSERT_LEDGER",
                                this.SetJournalDetails(ledger), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _oledgerDetails;
        }
        public DynamicParameters SetJournalDetails(Acc_LedgerModel journal)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TRANSACTION_ID", journal.TRANSACTION_ID);
            parameters.Add("@ACCOUNT_ID", journal.ACCOUNT_ID);
            parameters.Add("@ENTRY_TYPE", journal.ENTRY_TYPE);
            parameters.Add("@AMOUNT", journal.AMOUNT);
            parameters.Add("@EMPLOYEE_ID", journal.EMPLOYEE_ID);
            parameters.Add("@COST_CENTER_ID", journal.COST_CENTER_ID);
            return parameters;
        }
        internal List<AccPayableDetailsViewModel> GetAccouncePayable()
        {
            List<AccPayableDetailsViewModel> journal = new List<AccPayableDetailsViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var _obJournal = connection.Query<AccPayableDetailsViewModel>("SP_GET_ACC_ACCOUNT_PAYABLE");
                    if (_obJournal != null && _obJournal.Count() > 0)
                    {
                        journal = _obJournal.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return journal;
        }
        internal List<AccPayableDetailsViewModel> GetAccouncePayableSummery()
        {
            List<AccPayableDetailsViewModel> journal = new List<AccPayableDetailsViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var _obJournal = connection.Query<AccPayableDetailsViewModel>("SP_GET_ACC_ACCOUNT_PAYABLE_SUMMERY");
                    if (_obJournal != null && _obJournal.Count() > 0)
                    {
                        journal = _obJournal.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return journal;
        }
        //internal List<AccPayableDetailsViewModel> GetSupplierAccountSummery()
        //{
        //    List<AccPayableDetailsViewModel> journalList = new List<AccPayableDetailsViewModel>();
        //    List<AccPayableDetailsViewModel> journalList1 = new List<AccPayableDetailsViewModel>();
        //    AccPayableDetailsViewModel journal = new AccPayableDetailsViewModel();
        //    try
        //    {
        //        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
        //        {
        //            connection.Open();
        //            var _obJournal = connection.Query<AccPayableDetailsViewModel>("SP_VENDOR_GET_VENDORS_ACCOUNT_SUMMERY");
        //            DataSet DS = new DataSet();
        //            DS = SqlHelper.ExecuteDataset(Global.ConnectionString, "SP_VENDOR_GET_VENDORS_ACCOUNT_SUMMERY"); //connection.Query<AccPayableDetailsViewModel>("SP_VENDOR_GET_VENDORS_ACCOUNT_SUMMERY");
        //            //if (_obJournal != null && _obJournal.Count() > 0)
        //            //{
        //            //    journal = _obJournal.ToList();
        //            //}
        //            if(DS.Tables[0].Rows.Count>0)
        //            {
        //                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
        //                {
        //                    journal = new AccPayableDetailsViewModel();
        //                    journal.VENDOR_ID = Convert.ToInt32(DS.Tables[0].Rows[i].ItemArray[0].ToString());
        //                    journal.VENDOR_NAME = DS.Tables[0].Rows[i].ItemArray[1].ToString();
        //                    journal.VENDORTYPE = DS.Tables[0].Rows[i].ItemArray[2].ToString();
        //                    journal.TOTALPURCHASE = DS.Tables[0].Rows[i].ItemArray[3].ToString();
        //                    journal.AIT = DS.Tables[0].Rows[i].ItemArray[4].ToString();

        //                    journalList.Add(journal);
        //                }
        //                for(int j=0;j<DS.Tables[1].Rows.Count;j++)
        //                {
        //                    foreach(var k in journalList)
        //                    {
        //                        if(k.VENDOR_ID== Convert.ToInt32(DS.Tables[1].Rows[j].ItemArray[0].ToString()))
        //                        {
        //                            journal = new AccPayableDetailsViewModel();
        //                            journal.AMOUNT_PAID = DS.Tables[1].Rows[j].ItemArray[1].ToString();
        //                            journalList.Add(journal);
        //                        }
        //                    }
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception EX)
        //    {

        //    }
        //    return journalList;
        //}

        internal List<AccPayableDetailsViewModel> GetSupplierAccountSummery()
        {
            List<AccPayableDetailsViewModel> journalList = new List<AccPayableDetailsViewModel>();
            List<AccPayableDetailsViewModel> journalList1 = new List<AccPayableDetailsViewModel>();
            AccPayableDetailsViewModel journal = new AccPayableDetailsViewModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var _obJournal = connection.Query<AccPayableDetailsViewModel>("SP_VENDOR_GET_VENDORS_ACCOUNT_SUMMERY");


                    if (_obJournal != null && _obJournal.Count() > 0)
                    {
                        journalList = _obJournal.ToList();
                    }


                }
            }
            catch (Exception EX)
            {

            }
            return journalList;
        }
        internal List<AccPayableDetailsViewModel> GetSupplierTotalPaidAmount()
        {
            List<AccPayableDetailsViewModel> AmountList = new List<AccPayableDetailsViewModel>();
            List<AccPayableDetailsViewModel> journalList1 = new List<AccPayableDetailsViewModel>();
            AccPayableDetailsViewModel journal = new AccPayableDetailsViewModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var _obJournal = connection.Query<AccPayableDetailsViewModel>("SP_VENDOR_GET_VENDORS_TOTAL_PAID_AMOUNT");


                    if (_obJournal != null && _obJournal.Count() > 0)
                    {
                        AmountList = _obJournal.ToList();
                    }


                }
            }
            catch (Exception EX)
            {

            }
            return AmountList;
        }
    }
}
