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
    public class BankService
    {
        protected readonly ApplicationDbContex _dbContext;
        BankModel bankmodel = new BankModel();
        BankBranchModel branch = new BankBranchModel();
        public BankService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }

        internal BankModel AddBank(BankModel bankModel)
        {
            bankmodel = new BankModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<BankModel>("SP_BANK_INSERT_BANK",
                        this.SetParameters(bankModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return bankmodel;
        }
        internal BankModel UpdateBank(BankModel bankModel)
        {
            bankmodel = new BankModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<BankModel>("SP_BANK_INSERT_BANK",
                        this.SetParameters(bankModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return bankmodel;
        }

        internal List<BankBranchModel> GetAllBranch()
        {
            List<BankBranchModel> branchList = new List<BankBranchModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var branch = connection.Query<BankBranchModel>("SELECT * FROM TBL_BANK_BRANCH BR INNER JOIN TBL_BANK B ON BR.BANK_ID=B.BANK_ID WHERE BR.ENABLED=1");
                    if (branch.Count() > 0)
                    {
                        branchList = branch.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return branchList;
        }

        internal List<BankModel> GetBankList()
        {
            List<BankModel> bankList = new List<BankModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var bank = connection.Query<BankModel>("SELECT * FROM TBL_BANK WHERE ENABLED=1");
                    if (bank.Count() > 0)
                    {
                        bankList = bank.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return bankList;
        }
        internal List<BankBranchModel> GetBranchList(int bankId)
        {
            List<BankBranchModel> branchList = new List<BankBranchModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var bank = connection.Query<BankBranchModel>("SELECT * FROM TBL_BANK_BRANCH WHERE BANK_ID=" + bankId + " ");
                    if (bank.Count() > 0)
                    {
                        branchList = bank.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return branchList;
        }


        public DynamicParameters SetParameters(BankModel bankModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BANK_ID", bankModel.BANK_ID);
            parameters.Add("@BANK_CODE", bankModel.BANK_CODE);
            parameters.Add("@BANK_NAME", bankModel.BANK_NAME);
            parameters.Add("@Operation_Type", bankModel.Operation_Type);
            return parameters;
        }
        internal BankBranchModel AddBranch(BankBranchModel branchModel)
        {
            branch = new BankBranchModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<BankBranchModel>("SP_BRANCH_INSERT_BRANCH",
                        this.SetParametersforBranch(branchModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return branch;
        }
        internal BankBranchModel UpdateBranch(BankBranchModel branchModel)
        {
            branch = new BankBranchModel();
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


                    strSQL = "UPDATE TBL_BANK_BRANCH SET BANK_ID=" + branchModel.BANK_ID + ",";
                    strSQL = strSQL + "BRANCH_CODE='" + branchModel.BRANCH_CODE + "', ";
                    strSQL = strSQL + "BRANCH_NAME='" + branchModel.BRANCH_NAME + "', ";
                    strSQL = strSQL + "BRANCH_ADDRESS='" + branchModel.BRANCH_ADDRESS + "', ";
                    strSQL = strSQL + "BRANCH_PHONE='" + branchModel.BRANCH_PHONE + "', ";
                    strSQL = strSQL + "ROUTING_NUMBER='" + branchModel.ROUTING_NUMBER + "', ";
                    strSQL = strSQL + "SWIFT_CODE='" + branchModel.SWIFT_CODE + "', ";
                    strSQL = strSQL + "POSTAL_CODE='" + branchModel.POSTAL_CODE + "', ";
                    strSQL = strSQL + "CONTACT_PERSON_NAME='" + branchModel.CONTACT_PERSON_NAME + "', ";
                    strSQL = strSQL + "CONTACT_PERSON_DESIGNATION='" + branchModel.CONTACT_PERSON_DESIGNATION + "', ";
                    strSQL = strSQL + "CONTACT_PERSON_MOBILE='" + branchModel.CONTACT_PERSON_MOBILE + "', ";
                    strSQL = strSQL + "CONTACT_PERSON_EMAIL='" + branchModel.CONTACT_PERSON_EMAIL + "', ";
                    strSQL = strSQL + "BRANCH_EMAIL='" + branchModel.BRANCH_EMAIL + "' ";
                    strSQL = strSQL + "WHERE BANK_BRANCH_ID = " + branchModel.BANK_BRANCH_ID + "";
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
            return branch;
        }
        public DynamicParameters SetParametersforBranch(BankBranchModel branch)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BANK_BRANCH_ID", branch.BANK_BRANCH_ID);
            parameters.Add("@BANK_ID", branch.BANK_ID);
            parameters.Add("@BRANCH_CODE", branch.BRANCH_CODE);
            parameters.Add("@BRANCH_NAME", branch.BRANCH_NAME);
            parameters.Add("@BRANCH_ADDRESS", branch.BRANCH_ADDRESS);
            parameters.Add("@BRANCH_PHONE", branch.BRANCH_PHONE);
            parameters.Add("@ROUTING_NUMBER", branch.ROUTING_NUMBER);
            parameters.Add("@SWIFT_CODE", branch.SWIFT_CODE);
            parameters.Add("@POSTAL_CODE", branch.POSTAL_CODE);
            parameters.Add("@CONTACT_PERSON_NAME", branch.CONTACT_PERSON_NAME);
            parameters.Add("@CONTACT_PERSON_DESIGNATION", branch.CONTACT_PERSON_DESIGNATION);
            parameters.Add("@CONTACT_PERSON_MOBILE", branch.CONTACT_PERSON_MOBILE);
            parameters.Add("@CONTACT_PERSON_EMAIL", branch.CONTACT_PERSON_EMAIL);
            parameters.Add("@BRANCH_EMAIL", branch.BRANCH_EMAIL);
            parameters.Add("@Operation_Type", branch.Operation_Type);
            return parameters;
        }
        internal BankBranchModel GetBranchInfo(int branchId)
        {
            BankBranchModel branch = new BankBranchModel();
            
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@BANK_BRANCH_ID", branchId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    
                    var oproductgroup = connection.Query<BankBranchModel>("SP_BRANCH_GET_BRANCH_INFO_BY_BRANCH_ID", parameters, commandType: CommandType.StoredProcedure);
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        branch = oproductgroup.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return branch;
        }
        public void DeleteBank(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    connection.Query<CountryModel>("UPDATE TBL_BANK SET ENABLED=0 WHERE BANK_ID=" + id + "");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
