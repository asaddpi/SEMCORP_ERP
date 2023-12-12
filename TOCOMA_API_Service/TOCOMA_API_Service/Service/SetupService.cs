using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using TOCOMA_ERP_ClassLibrary.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace TOCOMA_API_Service.Service
{
    public class SetupService
    {
        protected readonly ApplicationDbContex _dbContext;
        BrandModel brand = new BrandModel();
        UnitModel unit = new UnitModel();
        ColorModel color = new ColorModel();
        public SetupService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        #region Branch
        internal BranchModel AddBranch(BranchModel branchModel)
        {
            BranchModel branch = new BranchModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<BranchModel>("SP_A_M_BRANCH_INSERT_BRANCH",
                        this.SetParameters(branchModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return branch;
        }

        internal BranchModel UpdateBranch(BranchModel branchModel)
        {
            BranchModel branch = new BranchModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<BranchModel>("SP_A_M_BRANCH_UPDATE_BRANCH",
                        this.SetParameters(branchModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return branch;
        }



        public DynamicParameters SetParameters(BranchModel branch)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@BRANCH_ID", branch.BRANCH_ID);
            parameters.Add("@BRANCH_NAME", branch.BRANCH_NAME);
            parameters.Add("@BRANCH_NAME_DEFAULT", branch.BRANCH_NAME_DEFAULT);
            parameters.Add("@BRANCH_ADD1", branch.BRANCH_ADD1);
            parameters.Add("@BRANCH_ADD2", branch.BRANCH_ADD2);
            parameters.Add("@BRANCH_COUNTRY", branch.BRANCH_COUNTRY);
            parameters.Add("@BRANCH_PHONE", branch.BRANCH_PHONE);
            parameters.Add("@BRANCH_FAX", branch.BRANCH_FAX);
            parameters.Add("@BRANCH_EMAIL", branch.BRANCH_EMAIL);
            parameters.Add("@BRANCH_STATUS", branch.BRANCH_STATUS);
            parameters.Add("@ENTRYBY", branch.ENTRYBY);
            parameters.Add("@UPDATEBY", branch.UPDATEBY);
            return parameters;
        }
        public List<BranchModel> GetBranchList()
        {
            List<BranchModel> branchList = new List<BranchModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var branch = connection.Query<BranchModel>("SELECT * FROM A_BRANCH");
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
        public void DeleteBranchById(string id)
        {
            try
            {
                //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM SubCategory WHERE SubCategoryId=" + id + "");

                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    connection.Query<CountryModel>("DELETE FROM A_BRANCH WHERE BRANCH_ID='" + id + "'");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Currency
        internal CurrencyModel AddCurrency(CurrencyModel currency)
        {
            CurrencyModel currencyModel = new CurrencyModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _ocurrency = connection.Query<CurrencyModel>("SP_A_CURRENCY_INSERT_CURRENCY",
                        this.SetCurrencyParameters(currency), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return currencyModel;
        }
        internal CurrencyModel UpdateCurrency(CurrencyModel branchModel)
        {
            CurrencyModel currencyModel = new CurrencyModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<CurrencyModel>("SP_A_CURRENCY_UPDATE_CURRENCY",
                        this.SetCurrencyParameters(branchModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return currencyModel;
        }

        public DynamicParameters SetCurrencyParameters(CurrencyModel currency)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CURRENCY_SERIAL", currency.CURRENCY_SERIAL);
            parameters.Add("@CURRENCY_SYMBOL", currency.CURRENCY_SYMBOL);
            parameters.Add("@CURRENCY_NAME", currency.CURRENCY_NAME);
            parameters.Add("@ENTRYBY", currency.ENTRYBY);
            parameters.Add("@UPDATEBY", currency.UPDATEBY);

            return parameters;
        }
        public List<CurrencyModel> GetCurrency()
        {
            List<CurrencyModel> currencyList = new List<CurrencyModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var currencies = connection.Query<CurrencyModel>("SELECT * FROM A_CURRENCY ORDER BY CURRENCY_NAME");
                    if (currencies.Count() > 0)
                    {
                        currencyList = currencies.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return currencyList;

        }
        public void DeleteCurrency(string id)
        {
            try
            {
                //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM SubCategory WHERE SubCategoryId=" + id + "");

                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    connection.Query<CountryModel>("DELETE FROM A_CURRENCY WHERE CURRENCY_SERIAL='" + id + "'");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Ledger Group
        

        internal LedgerGroupModel AddLedgerGroup(LedgerGroupModel ledgergroup)
        {

            //------------------------
            long lngGroup = 0
                , lngGroupLavel = 0
                , lngType = 0
                , lngCashFlowType = 0
                , mlngAccounTtype = 0
                , lngManuFacType = 0;
            string strGroup
                , strPrimary
                , strParent
                , strOneDown
                , strSQL
                , strOnedownNew = "";
            Boolean blnInsert = false;
            SqlDataReader dr;
            ledgergroup.Success_Status = false;
            int intPosition = 9999, intDuplicate = 0;


            strGroup = ledgergroup.GR_NAME.Trim().Replace("'", "''");           
            
            using (SqlConnection gcnMain = new SqlConnection(Global.ConnectionString))
            {

                try
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

                    strParent = ledgergroup.GR_PARENT.Replace("'", "''");
                    strSQL = "SELECT GR_PARENT, GR_PRIMARY,GR_GROUP,GR_LEVEL,GR_PRIMARY,GR_PRIMARY_TYPE,";
                    strSQL = strSQL + "GR_ONE_DOWN,GR_CASH_FLOW_TYPE FROM A_M_LEDGERGROUP ";
                    strSQL = strSQL + "WHERE GR_NAME = '" + strParent + "' ";
                    cmdInsert.CommandText = strSQL;
                    dr = cmdInsert.ExecuteReader();
                    if (dr.Read())
                    {
                        strOnedownNew = dr["GR_PARENT"].ToString().Replace("'", "''");
                        lngGroup = long.Parse(dr["GR_GROUP"].ToString());
                        lngGroupLavel = long.Parse(dr["GR_LEVEL"].ToString()) + 1;
                        lngCashFlowType = long.Parse(dr["GR_CASH_FLOW_TYPE"].ToString());
                        //lngManuFacType = long.Parse(dr["GR_MANUFAC_GROUP"].ToString());
                        mlngAccounTtype = long.Parse(dr["GR_PRIMARY_TYPE"].ToString());
                        strPrimary = dr["GR_PRIMARY"].ToString().Replace("'", "''");
                        if (dr["GR_PRIMARY"].ToString() == strParent)
                        {
                            strOneDown = strGroup;
                        }
                        else
                        {
                            //strOneDown = strUnder;
                            strOneDown = dr["GR_ONE_DOWN"].ToString().Replace("'", "''");
                        }
                    }
                    else
                    {
                        lngGroup = 0;
                        lngGroupLavel = 0;
                        lngCashFlowType = 0;
                        lngManuFacType = 0;
                        strOneDown = string.Empty;
                        strPrimary = string.Empty;

                    }
                    dr.Close();


                    if (mlngAccounTtype == 0)
                    {
                        if (ledgergroup.GR_PRIMARY.Trim().ToUpper() == "ASSETS")
                        {
                            mlngAccounTtype = 1;
                        }
                        else if (ledgergroup.GR_PRIMARY.Trim().ToUpper() == "EQUITY AND LIABILITIES")
                        {
                            mlngAccounTtype = 2;
                        }
                        else if (ledgergroup.GR_PRIMARY.Trim().ToUpper() == "INCOME")
                        {
                            mlngAccounTtype = 3;
                        }
                        else if (ledgergroup.GR_PRIMARY.Trim().ToUpper() == "EXPENSES")
                        {
                            mlngAccounTtype = 4;
                        }
                    }
                    

                    if (strParent.ToUpper().ToString() == "PRIMARY")
                    {
                        strParent = ledgergroup.GR_PRIMARY;
                        strPrimary = strGroup;
                        lngGroupLavel = (long)GROUP_TYPE.gtMAIN_GROUP;
                        strOneDown = strGroup;
                    }

                    if (lngGroup == 0)
                    {
                        lngGroup = (long)GR_GROUP_TYPE.grOTHER_LEDGER;
                    }

                    if (lngGroup == (long)GR_GROUP_TYPE.grCash)
                    {
                        lngCashFlowType = 0;
                    }
                    else if (lngGroup == (long)GR_GROUP_TYPE.grBANKACCOUNTS)
                    {
                        lngCashFlowType = 0;
                    }
                    
                   
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            ledgergroup.GR_ONE_DOWN = strOnedownNew;
                            ledgergroup.GR_LEVEL = Convert.ToInt32(lngGroupLavel);
                            ledgergroup.GR_GROUP = Convert.ToInt32(lngGroup);
                            ledgergroup.GR_PRIMARY_TYPE = Convert.ToInt32(mlngAccounTtype);
                            ledgergroup.GR_PARENT_POSITION = intPosition;   
                        }

                        strSQL = "INSERT INTO A_M_LEDGERGROUP(GR_NAME,GR_PARENT,GR_ONE_DOWN,GR_PRIMARY" +
                            ",GR_LEVEL,GR_GROUP,GR_PRIMARY_TYPE,GR_CASH_FLOW_TYPE,GR_PARENT_POSITION,ENTRYBY) " +
                            "VALUES(";
                        strSQL = strSQL + "'" + ledgergroup.GR_NAME + "'";
                        strSQL = strSQL + ",'" + ledgergroup.GR_PARENT + "' ";
                        strSQL = strSQL + ",'" + ledgergroup.GR_ONE_DOWN + "' ";
                        strSQL = strSQL + ",'" + ledgergroup.GR_PRIMARY + "' ";
                        strSQL = strSQL + ",'" + ledgergroup.GR_LEVEL + "' ";
                        strSQL = strSQL + ",'" + ledgergroup.GR_GROUP + "' ";
                        strSQL = strSQL + ",'" + ledgergroup.GR_PRIMARY_TYPE + "' ";
                        strSQL = strSQL + ",'" + ledgergroup.GR_CASH_FLOW_TYPE + "' ";
                        strSQL = strSQL + ",'" + ledgergroup.GR_PARENT_POSITION + "' ";
                        strSQL = strSQL + ",'" + ledgergroup.ENTRYBY + "' ";                        
                        strSQL = strSQL + ")";
                        cmdInsert.CommandText = strSQL;
                        cmdInsert.ExecuteNonQuery();
                    

                    do
                    {
                        if (lngGroupLavel == 1)
                        {
                            blnInsert = true;
                        }
                        strSQL = "SELECT GR_PARENT,GR_LEVEL FROM A_M_LEDGERGROUP ";
                        strSQL = strSQL + "WHERE GR_NAME ='" + strGroup + "' ";
                        SqlDataReader dr1;
                        cmdInsert.CommandText = strSQL;
                        dr1 = cmdInsert.ExecuteReader();
                        if (dr1.Read())
                        {
                            strParent = dr1["GR_PARENT"].ToString().Replace("'", "''");
                            //lngGroupLavel = (long)dr1["GR_LEVEL"];
                            lngGroupLavel = long.Parse(dr1["GR_LEVEL"].ToString());
                        }
                        dr1.Close();
                        if (blnInsert == false)
                        {
                            strSQL = "INSERT INTO A_M_G_TO_LEDGER(GR_PARENT,GR_NAME) VALUES(";
                            strSQL = strSQL + "'" + strParent + "','" + strGroup + "'";
                            strSQL = strSQL + ")";
                            cmdInsert.CommandText = strSQL;
                            cmdInsert.ExecuteNonQuery();
                            //if (strAccountType != "")
                            //{
                            //    lngType = 1;
                            //    blnInsert = true;
                            //}

                            strGroup = strParent;
                        }
                    }

                    while (blnInsert = false);

                    cmdInsert.Transaction.Commit();
                    ledgergroup.Success_Status = true;

                }
                catch(Exception ex)
                {
                    ledgergroup.Success_Status =false;
                }
            }
            return ledgergroup;
        }

        internal List<string> GetCategoryNameListById(string ids)
        {
            List<string> categoryNameList = new List<string>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
                {
                    if (dbConnection.State == ConnectionState.Closed) dbConnection.Open();
                    string query = "Select CATEGORY_NAME from TBL_ITEM_CATEGORY Where CATEGORY_ID IN (" + ids + ")";
                    var typeList = dbConnection.Query<string>(query);

                    if (typeList.Count() > 0 && typeList != null)
                    {
                        categoryNameList = typeList.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return categoryNameList;
        }

        internal TermsConditionTypeEntity AddTermsConditionType(TermsConditionTypeEntity typeEntity)
        {
            try
            {
                using(IDbConnection dbConnection=new SqlConnection(Global.ConnectionString))
                {
                    var data = dbConnection.Query<TermsConditionTypeEntity>("SP_SETUP_INSERT_UPDATE_TERMS_CONDITION_TYPE",
                        this.SetParameters(typeEntity), commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            {

            }
            return typeEntity;

        }
        public DynamicParameters SetParameters(TermsConditionTypeEntity typeEntity)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@TERMS_CONDITION_TYPE_ID", typeEntity.TERMS_CONDITION_TYPE_ID);
            param.Add("@TERMS_CONDITION_TYPE", typeEntity.TERMS_CONDITION_TYPE);
            param.Add("@OPERATION_TYPE", typeEntity.OPERATION_TYPE);            

            return param;
        }

        //internal List<TermsConditionTypeEntity> GetTermsConditionType()
        //{
        //    List<TermsConditionTypeEntity> list = new List<TermsConditionTypeEntity>();
        //    using(IDbConnection connection=new SqlConnection(Global.ConnectionString))
        //    {
        //        if (connection.State == ConnectionState.Closed) connection.Open();
        //        var typeList = connection.Query<TermsConditionTypeEntity>("Select * from TBL_TERMS_CONDITION_TYPE");

        //        if(typeList.Count() >0 && typeList !=null)
        //        {
        //            list = typeList.ToList();
        //        }
        //    }
        //    return list;
        //}

        internal List<TermsConditionTypeEntity> GetTermsConditionType()
        {
            List<TermsConditionTypeEntity> list = new List<TermsConditionTypeEntity>();
            List<PurchaseTermsConditionsModel> tlist = new List<PurchaseTermsConditionsModel>();

            PurchaseTermsConditionsModel tc = new PurchaseTermsConditionsModel();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var typeList = connection.Query<TermsConditionTypeEntity>("Select * from TBL_TERMS_CONDITION_TYPE");
                var tcList= connection.Query<PurchaseTermsConditionsModel>("Select * from TBL_SALES_TERM_CONDITIONS where POSITION = 1 AND ENABLE = 1");
                tlist = tcList.ToList();
                foreach (var item in typeList.ToList())
                {
                    var t= connection.Query<PurchaseTermsConditionsModel>("Select * from TBL_SALES_TERM_CONDITIONS WHERE TERMS_CONDITION_TYPE_ID="+item.TERMS_CONDITION_TYPE_ID+ " AND POSITION = 1 AND ENABLE = 1");
                    
                    foreach(var i in t.ToList())
                    {
                        tc = new PurchaseTermsConditionsModel();

                        tc.SALES_TERMS_CONDITION_ID = i.SALES_TERMS_CONDITION_ID;
                        tc.TERMS_AND_CONDITIONS = i.TERMS_AND_CONDITIONS;
                        if(item.TermsConditionList==null)
                        {
                            item.TermsConditionList = new List<PurchaseTermsConditionsModel>();
                            item.TermsConditionList.Add(tc);
                        }
                        else
                        {
                            item.TermsConditionList.Add(tc);
                        }
                        
                    }

                    


                }
                

                if (typeList.Count() > 0 && typeList != null)
                {
                    list = typeList.ToList();
                }
            }
            return list;
        }

        private string GetEndGroup(string grName)
        {
            string strEngGroup;
            string strSQL;
            IDataReader dr;
            strSQL = "SELECT GR_PRIMARY FROM A_M_LEDGERGROUP ";
            strSQL = strSQL + "WHERE GR_NAME = '" + grName + "' ";
            //strSQL = strSQL + "OR GR_PARENT = '" + sStart + "')";


            dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);
            if (dr.Read())
            {
                strEngGroup = dr["GR_PRIMARY"].ToString();
            }
            else
            {
                strEngGroup = "PRIMARY";
            }
            dr.Close();
            
            return strEngGroup;
        }
        internal LedgerGroupModel UpdateLedgerGroup(LedgerGroupModel ledgerGroup)
        {
            LedgerGroupModel lgGroup = new LedgerGroupModel();
            Boolean blnUnderChange;
            long lngGroupLevel = 0, lngGroup, lngCashFlowType, lngDefaultGroup, lngOldLevel, lngNewLevel, lngManuFacType;
            double dblOpeningDebit, dblOpeningCredit;
            string strSQL, strOldLedgerUnder, strOneDown = "", strParent, strOldParent, strNewParent, strPrimary, strOldLedgerGroup, strOldLedgerGroup1, strOneDownNew = "";
            Boolean blnInsert = false;
            int mlngAccounTtype = 0;
            string strDeComID;
            long mlngGroupSerial;
            string strGroupName;
            string strUnder;
            string strCashflowType;
            string strAccountType ="";
            string strMobileNo;
            string strConatctNo;
            int intPosition;
            int intDuplicate;
            string strRegMobile;

            SqlDataReader dr;
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    strGroupName = ledgerGroup.GR_NAME;
                    strUnder = ledgerGroup.GR_PARENT;
                    strGroupName = strGroupName.Trim().Replace("'", "''");
                    strParent = strUnder.Trim().Replace("'", "''");
                    strNewParent = strParent;
                    strPrimary =GetEndGroup(ledgerGroup.GR_NAME);  //Not Find
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






                    if (strPrimary.ToUpper() == "PRIMARY")
                    {
                        strPrimary = strParent;
                    }
                    //if (gcnMain.State == ConnectionState.Open)
                    //{
                    //    gcnMain.Close();
                    //}
                    //gcnMain.Open();

                    dr =SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "SELECT GR_NAME,GR_PARENT,GR_GROUP,GR_DEFAULT_GROUP" +
                        " ,GR_OPENING_DEBIT,GR_LEVEL,GR_OPENING_CREDIT FROM A_M_LEDGERGROUP WHERE GR_SERIAL = " + ledgerGroup.GR_SERIAL + " ");
                    if (dr.Read())
                    {
                        strOldLedgerGroup = dr["GR_NAME"].ToString().Replace("'", "''");
                        strOldLedgerGroup1 = strOldLedgerGroup;
                        strOldLedgerUnder = dr["GR_PARENT"].ToString();
                        lngGroup = long.Parse(dr["GR_GROUP"].ToString());
                        lngDefaultGroup = long.Parse(dr["GR_DEFAULT_GROUP"].ToString());

                        dblOpeningDebit = double.Parse(dr["GR_OPENING_DEBIT"].ToString());
                        dblOpeningCredit = double.Parse(dr["GR_OPENING_CREDIT"].ToString());
                        lngOldLevel = long.Parse(dr["GR_LEVEL"].ToString());
                    }
                    else
                    {
                        strOldLedgerGroup = string.Empty;
                        strOldLedgerGroup1 = string.Empty;
                        strOldLedgerUnder = string.Empty;
                        lngGroup = 0;
                        lngDefaultGroup = 0;
                        dblOpeningDebit = 0;
                        dblOpeningCredit = 0;
                        lngOldLevel = 0;
                    }
                    dr.Close();
                    do
                    {
                        if (lngOldLevel == 1)
                        {
                            blnInsert = true;
                        }
                        else
                        {
                            blnInsert = false;
                        }                        
                        SqlDataReader dr1;                        
                        dr1 = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "SELECT GR_PARENT,GR_LEVEL FROM A_M_LEDGERGROUP" +
                                                                                              " WHERE GR_NAME ='" + strOldLedgerGroup + "' ");
                        
                        if (dr1.Read())
                        {
                            strOldParent = dr1["GR_PARENT"].ToString().Replace("'", "''");
                            //lngGroupLavel = (long)dr1["GR_LEVEL"];
                            lngOldLevel = long.Parse(dr1["GR_LEVEL"].ToString());
                        }
                        else
                        {
                            strOldParent = string.Empty;
                            lngOldLevel = 0;
                        }
                        dr1.Close();
                        if (blnInsert == false)
                        {
                            SqlConnection conn = new SqlConnection();
                            strSQL = "UPDATE A_M_LEDGERGROUP SET GR_OPENING_DEBIT =  GR_OPENING_DEBIT - " + dblOpeningDebit + ",";
                            strSQL = strSQL + "GR_OPENING_CREDIT =  GR_OPENING_CREDIT - " + dblOpeningCredit + " ";
                            strSQL = strSQL + "WHERE GR_NAME = '" + strOldParent + "'";
                            //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
                            cmdInsert.CommandText = strSQL;
                            cmdInsert.ExecuteNonQuery();
                            strOldLedgerGroup = strOldParent;
                            blnInsert = true;

                        }
                    }
                    while (blnInsert == false);
                    blnInsert = false;
                    if (strOldLedgerUnder.Trim() != strUnder.Trim())
                    {
                        blnUnderChange = true;
                    }
                    else
                    {
                        blnUnderChange = false;
                    }
                    lngCashFlowType = Convert.ToInt64(ledgerGroup.GR_CASH_FLOW_TYPE);
                    //if (strCashflowType == "Operating Activities")
                    //{
                    //    lngCashFlowType = 1;
                    //}
                    //else if (strCashflowType == "Investing Activities")
                    //{
                    //    lngCashFlowType = 2;
                    //}
                    //else if (strCashflowType == "Financing Activities")
                    //{
                    //    lngCashFlowType = 3;
                    //}
                    //else
                    //{
                    //    lngCashFlowType = 4;
                    //}

                    strSQL = "SELECT GR_PARENT,GR_PRIMARY,GR_GROUP,GR_LEVEL,GR_PRIMARY_TYPE,GR_ONE_DOWN,GR_CASH_FLOW_TYPE FROM A_M_LEDGERGROUP ";
                    strSQL = strSQL + "WHERE GR_NAME = '" + strParent + "' ";
                    dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);                  
                   
                    if (dr.Read())
                    {
                        strOneDownNew = dr["GR_PARENT"].ToString().Replace("'", "''");
                        if (lngDefaultGroup == 0)
                        {
                            lngGroup = long.Parse(dr["GR_GROUP"].ToString());
                        }
                        if (lngGroup == 0)
                        {
                            lngGroup = (long)(GR_GROUP_TYPE.grOTHER_LEDGER);
                        }
                        lngGroupLevel = long.Parse(dr["GR_LEVEL"].ToString()) + 1;
                        lngCashFlowType = int.Parse(dr["GR_CASH_FLOW_TYPE"].ToString());
                        mlngAccounTtype = int.Parse(dr["GR_PRIMARY_TYPE"].ToString());
                        //lngManuFacType = int.Parse(dr["GR_MANUFAC_GROUP"].ToString());
                        //strPrimary = dr["GR_PRIMARY"].ToString().Replace("'", "''");

                        if (dr["GR_PRIMARY"].ToString() == strParent)
                        {
                            strOneDown = strGroupName;
                        }
                        else
                        {
                            strOneDown = dr["GR_ONE_DOWN"].ToString().Replace("'", "''");
                        }
                    }

                    dr.Close();
                    if (strParent.ToUpper() == "PRIMARY")
                    {
                        SqlDataReader reader;                        
                            reader= SqlHelper.ExecuteReader(Global.ConnectionString, "SP_GET_GR_PRIMARY_TYPE", ledgerGroup.GR_PRIMARY_TYPE);
                        if(reader.Read())
                        {
                            strAccountType = reader["PRIMARY_NAME"].ToString();
                        }
                        
                        strParent = strAccountType;
                        if (strAccountType.Trim().ToUpper() == "ASSETS")
                        {
                            mlngAccounTtype = 1;
                        }
                        else if (strAccountType.Trim().ToUpper() == "EQUITY AND LIABILITIES")
                        {
                            mlngAccounTtype = 2;
                        }
                        else if (strAccountType.Trim().ToUpper() == "INCOME")
                        {
                            mlngAccounTtype = 3;
                        }
                        else if (strAccountType.Trim().ToUpper() == "EXPENSES")
                        {
                            mlngAccounTtype = 4;
                        }
                        lngGroupLevel = 1;
                        strOneDown = strGroupName;
                        strPrimary = strGroupName;

                    }
                    else
                    {
                        if (lngGroupLevel == 0)
                        {
                            lngGroupLevel = 2;
                        }

                        //strOneDown = strParent;
                    }
                    if (strPrimary.ToUpper() == "PRIMARY")
                    {
                        strPrimary = strParent;
                        strOneDown = strGroupName;
                    }
                    //SqlCommand cmdInsert = new SqlCommand();
                    //SqlTransaction myTrans;
                    //myTrans = gcnMain.BeginTransaction();
                    //cmdInsert.Connection = gcnMain;
                    //cmdInsert.Transaction = myTrans;

                    //strPrimary = strGroupName;
                    // lngGroupLevel = (long)(Utility.GROUP_TYPE.gtMAIN_GROUP);
                    //strOneDown = strGroupName;
                    strSQL = "DELETE FROM A_M_G_TO_LEDGER WHERE GR_NAME = '" + strOldLedgerGroup + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
                    lngNewLevel = lngGroupLevel;
                    strSQL = "UPDATE A_M_LEDGERGROUP SET GR_NAME = '" + strGroupName + "', ";
                    strSQL = strSQL + "GR_PARENT = '" + strParent + "',";
                    
                    //if (lngGroupLevel == 1)
                    //{
                    //    strSQL = strSQL + "GR_SEQUENCES = " + lngSequences + ",";
                    //}
                    strSQL = strSQL + "GR_PRIMARY = '" + strPrimary + "',";
                    strSQL = strSQL + "GR_ONE_DOWN = '" + strOneDownNew + "', ";
                    strSQL = strSQL + "GR_PRIMARY_TYPE = " + mlngAccounTtype + ",";
                    strSQL = strSQL + "GR_LEVEL = " + lngGroupLevel + ",";
                    strSQL = strSQL + "GR_CASH_FLOW_TYPE = " + lngCashFlowType + ", ";
                    // strSQL = strSQL + "GR_MANUFAC_GROUP = " + lngManuFacType + ", ";
                    // strSQL = strSQL + "GR_AFFECT_GP = " + lngAffectGP + ",";
                    strSQL = strSQL + "GR_GROUP = " + lngGroup + " ";
                    //strSQL = strSQL + ",GR_MOBILE_NO ='" + strMobileNo.Trim().Replace("'", "''") + "' ";
                    //strSQL = strSQL + ",GR_CONTACT_NO ='" + strConatctNo.Trim().Replace("'", "''") + "' ";
                    //strSQL = strSQL + ",GR_PARENT_POSITION =" + intPosition + " ";
                    //strSQL = strSQL + ",REGIS_MOBILE ='" + strRegMobile.Trim().Replace("'", "''") + "' ";
                    //strSQL = strSQL + ",DUPLICATE =" + intDuplicate + " ";
                    strSQL = strSQL + "WHERE GR_SERIAL = " + ledgerGroup.GR_SERIAL + " ";
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    strSQL = "UPDATE A_M_LEDGERGROUP SET GR_PARENT = '" + strGroupName + "' ";
                    strSQL = strSQL + "WHERE GR_PARENT = '" + strOldLedgerGroup1 + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);


                    strSQL = "UPDATE A_M_LEDGERGROUP SET GR_ONE_DOWN = '" + strGroupName + "' ";
                    strSQL = strSQL + "WHERE GR_ONE_DOWN = '" + strOldLedgerGroup1 + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);


                    strSQL = "UPDATE A_M_LEDGERGROUP SET GR_PRIMARY = '" + strGroupName + "' ";
                    strSQL = strSQL + "WHERE GR_PRIMARY = '" + strOldLedgerGroup1 + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);

                    //strSQL = "UPDATE USER_ONLILE_SECURITY SET COR_MOBILE_NO = '" + strRegMobile.Trim().Replace("'", "''") + "' ";
                    //strSQL = strSQL + ",LEDGER_NAME = '" + strGroupName + "' ";
                    //strSQL = strSQL + "WHERE LEDGER_NAME = '" + strOldLedgerGroup1 + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();


                    strSQL = "UPDATE A_M_LEDGER SET LEDGER_PRIMARY_GROUP = '" + strGroupName + "' ";
                    strSQL = strSQL + "WHERE LEDGER_PRIMARY_GROUP = '" + strOldLedgerGroup1 + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);


                    strSQL = "UPDATE A_M_LEDGER SET LEDGER_PARENT_GROUP = '" + strGroupName + "' ";
                    strSQL = strSQL + "WHERE LEDGER_PARENT_GROUP = '" + strOldLedgerGroup1 + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);


                    strSQL = "UPDATE A_M_LEDGER SET LEDGER_ONE_DOWN = '" + strGroupName + "' ";
                    strSQL = strSQL + "WHERE LEDGER_ONE_DOWN = '" + strOldLedgerGroup1 + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);


                    //strSQL = "UPDATE S_A_M_LEDGER SET LEDGER_MANUFAC_GROUP = " + lngManuFacType + " ";
                    //strSQL = strSQL + "WHERE LEDGER_PARENT_GROUP = '" + strGroupName + "' ";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();

                    strSQL = "UPDATE A_M_LEDGERGROUP SET GR_CASH_FLOW_TYPE = " + lngCashFlowType + " ";
                    strSQL = strSQL + "WHERE GR_PARENT = '" + strGroupName + "' ";
                    strSQL = strSQL + "AND GR_CASH_FLOW_TYPE <> 4 ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);

                    strSQL = "UPDATE A_M_LEDGERGROUP SET GR_PRIMARY = '" + strPrimary + "' ";
                    strSQL = strSQL + "WHERE GR_PARENT = '" + strGroupName + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);

                    strSQL = "UPDATE A_M_LEDGER SET LEDGER_CASH_FLOW_TYPE = " + lngCashFlowType + " ";
                    strSQL = strSQL + "WHERE LEDGER_PARENT_GROUP = '" + strGroupName + "' ";
                    strSQL = strSQL + "AND LEDGER_CASH_FLOW_TYPE <> 4 ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);

                    strSQL = "UPDATE A_M_LEDGER SET LEDGER_PRIMARY_GROUP = '" + strPrimary + "' ";
                    strSQL = strSQL + "WHERE LEDGER_PARENT_GROUP = '" + strGroupName + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    strSQL = "INSERT INTO A_M_G_TO_LEDGER(GR_PARENT,GR_NAME) VALUES(";
                    strSQL = strSQL + "'" + strParent + "','" + strGroupName + "'";
                    strSQL = strSQL + ")";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);

                    //If blnUnderChange Then
                    lngGroupLevel = lngGroupLevel + 1;
                    //grUpdateNextLevel strGroupName, lngGroupLevel, lngGroup, strPrimary, lngCashFlowType, mlngAccounTtype;

                    do
                    {
                        if (lngNewLevel == 1)
                        {
                            blnInsert = true;
                        }
                        strSQL = "SELECT GR_PARENT,GR_LEVEL FROM A_M_LEDGERGROUP ";
                        strSQL = strSQL + "WHERE GR_NAME ='" + strGroupName + "' ";
                        SqlDataReader dr2;
                        cmdInsert.CommandText = strSQL;
                        dr2 = cmdInsert.ExecuteReader();                        
                        //dr2=SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);
                        if (dr2.Read())
                        {
                            strNewParent = dr2["GR_PARENT"].ToString().Replace("'", "''");
                            //lngGroupLavel = (long)dr1["GR_LEVEL"];
                            lngNewLevel = long.Parse(dr2["GR_LEVEL"].ToString());
                        }
                        else
                        {
                            strNewParent = string.Empty;
                            lngNewLevel = 0;
                        }
                        dr2.Close();
                        if (blnInsert == false)
                        {

                            strSQL = "UPDATE A_M_LEDGERGROUP SET GR_OPENING_DEBIT =  GR_OPENING_DEBIT + " + dblOpeningDebit + ",";
                            strSQL = strSQL + "GR_OPENING_CREDIT =  GR_OPENING_CREDIT + " + dblOpeningCredit + " ";
                            strSQL = strSQL + "WHERE GR_NAME = '" + strNewParent + "'";
                            //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
                            cmdInsert.CommandText = strSQL;
                            cmdInsert.ExecuteNonQuery();
                            strOldLedgerGroup = strOldParent;
                            lngNewLevel = 1;
                        }
                    }

                    while (blnInsert == false);
                    cmdInsert.Transaction.Commit();
                    ////gcnMain.Close();
                    //cmdInsert.Dispose();
                    //gcnMain.Dispose();

                    //if (connection.State == ConnectionState.Closed) connection.Open();
                    //var _oproductcategory = connection.Query<LedgerGroupModel>("SP_A_M_LEDGERGROUP_UPDATE_LEDGER_GROUP",
                    //    this.SetLedgerGroupParameters(ledgerGroup), commandType: CommandType.StoredProcedure);

                    lgGroup.Success_Status = true;
                }
            }
            catch (Exception EX)
            {
                lgGroup.Success_Status = false;
            }
            return lgGroup;
        }

        internal List<ItemSubCategory> GetItemSubCategory()
        {
            List<ItemSubCategory> subcategoryList = new List<ItemSubCategory>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ItemSubCategory>("SELECT * FROM TBL_ITEM_SUBCATEGORY ORDER BY SUBCATEGORY_NAME");
                    if (poModel.Count() > 0)
                    {
                        subcategoryList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return subcategoryList;
        }
        internal List<ItemSubCategory> GetItemSubCategoryById(string Id)
        {
            List<ItemSubCategory> subcategoryList = new List<ItemSubCategory>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ItemSubCategory>("SELECT * FROM TBL_ITEM_SUBCATEGORY WHERE CATEGORY_ID='"+Id+"'");
                    if (poModel.Count() > 0)
                    {
                        subcategoryList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return subcategoryList;
        }
        internal List<ItemSubCategory> GetItemSubCategoryList()
        {
            List<ItemSubCategory> subcategoryList = new List<ItemSubCategory>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ItemSubCategory>("SELECT * FROM TBL_ITEM_SUBCATEGORY s INNER JOIN TBL_ITEM_CATEGORY c on s.CATEGORY_ID=c.CATEGORY_ID ORDER BY s.SUBCATEGORY_NAME");
                    if (poModel.Count() > 0)
                    {
                        subcategoryList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return subcategoryList;
        }

        internal TAX_CLASS GetTaxInfo()
        {
            TAX_CLASS taxinfo = new TAX_CLASS();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var tax = connection.Query<TAX_CLASS>("SELECT * FROM TBL_TAX");
                if (tax.Count() > 0)
                {
                    taxinfo = tax.FirstOrDefault();
                }
            }
            return taxinfo;
        }

        public DynamicParameters SetLedgerGroupParameters(LedgerGroupModel ledgerGroup)
        {
            DynamicParameters parameters = new DynamicParameters();
            //parameters.Add("@GR_SERIAL", ledgerGroup.GR_SERIAL);
            parameters.Add("@GR_NAME", ledgerGroup.GR_NAME);
            parameters.Add("@GR_PARENT", ledgerGroup.GR_PARENT);
            parameters.Add("@GR_ONE_DOWN", ledgerGroup.GR_ONE_DOWN);
            parameters.Add("@GR_PRIMARY", ledgerGroup.GR_PRIMARY);
            parameters.Add("@GR_LEVEL", ledgerGroup.GR_LEVEL);
            parameters.Add("@GR_GROUP", ledgerGroup.GR_GROUP);
            parameters.Add("@GR_PRIMARY_TYPE", ledgerGroup.GR_PRIMARY_TYPE);
            parameters.Add("@GR_CASH_FLOW_TYPE", ledgerGroup.GR_CASH_FLOW_TYPE);
            parameters.Add("@GR_PARENT_POSITION", ledgerGroup.GR_PARENT_POSITION);
            parameters.Add("@ENTRYBY", ledgerGroup.ENTRYBY);
            //parameters.Add("@UPDATEBY", ledgerGroup.UPDATEBY);

            return parameters;
        }

        public List<LedgerGroupModel> GetLedgerGroup()
        {
            List<LedgerGroupModel> ledgerGroupList = new List<LedgerGroupModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var currencies = connection.Query<LedgerGroupModel>("SP_GET_ALL_LEDGERGROUP");
                    if (currencies.Count() > 0)
                    {
                        ledgerGroupList = currencies.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerGroupList;

        }
        public List<LedgerModel> GetPaymentMediaTypeList()
        {
            List<LedgerModel> ledgerGroupList = new List<LedgerModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var currencies = connection.Query<LedgerModel>("Select * from A_M_LEDGER WHERE PAYMENT_MEDIA_TYPE=1 ORDER BY LEDGER_NAME");
                    if (currencies.Count() > 0)
                    {
                        ledgerGroupList = currencies.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerGroupList;

        }
        public List<LedgerModel> GetCustomerProjectList()
        {
            List<LedgerModel> ledgerGroupList = new List<LedgerModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var currencies = connection.Query<LedgerModel>("Select * from A_M_LEDGER WHERE PAYMENT_MEDIA_TYPE=2 ORDER BY LEDGER_NAME");
                    if (currencies.Count() > 0)
                    {
                        ledgerGroupList = currencies.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerGroupList;

        }

        //------------- Get Ledger Group
        //private void DisplayReqList(List<AccountdGroup> tests, object sender, EventArgs e)
        //{
        //    try
        //    {
        //        foreach (AccountdGroup ts in tests)
        //        {
        //            txtSlNo.Text = ts.lngSlNo.ToString();
        //            mstrOLDGroup = ts.GroupName;
        //            txtGroupName.Text = ts.GroupName;
        //            txtCashFlowType.Enabled = false;
        //            txtAccountsType.Enabled = false;
        //            if (ts.lngGrLevel == 1)
        //            {
        //                txtUnder.Text = "Primary";
        //            }
        //            else
        //            {
        //                txtUnder.Text = ts.ParentName;
        //            }
        //            if (ts.intPrimaryType == 1)
        //            {
        //                txtAccountsType.Text = "Assets";
        //            }
        //            else if (ts.intPrimaryType == 2)
        //            {
        //                txtAccountsType.Text = "Equity And Liabilities";
        //            }
        //            else if (ts.intPrimaryType == 3)
        //            {
        //                txtAccountsType.Text = "Income";
        //            }
        //            else if (ts.intPrimaryType == 4)
        //            {
        //                txtAccountsType.Text = "Expenses";
        //            }


        //            if (ts.intCashFlowType == 1)
        //            {
        //                txtCashFlowType.Text = "Operating Activities";
        //            }
        //            else if (ts.intCashFlowType == 2)
        //            {
        //                txtCashFlowType.Text = "Investing Activities";
        //            }
        //            else if (ts.intCashFlowType == 3)
        //            {
        //                txtCashFlowType.Text = "Financing Activities";
        //            }
        //            else
        //            {
        //                txtCashFlowType.Text = "End of List";
        //            }
        //            txtMobileNo.Text = ts.strMobileNo;
        //            txtConatctNo.Text = ts.strContactNo;
        //            txtRegisMobile.Text = ts.strResignMobile;
        //            txtSortingPos.Text = ts.intMode.ToString();
        //            if (ts.intduplicate == 1)
        //            {
        //                chkDuplicate.Checked = true;
        //            }
        //            else
        //            {
        //                chkDuplicate.Checked = false;
        //            }
        //            txtGroupName.Focus();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //}
        //private List<AccountdGroup> GetSelectedItem()
        //{
        //    List<AccountdGroup> items = new List<AccountdGroup>();
        //    try
        //    {

        //        AccountdGroup itm = new AccountdGroup();
        //        itm.lngSlNo = Convert.ToInt64(DG.CurrentRow.Cells[0].Value.ToString());
        //        itm.intPrimaryType = Convert.ToInt32(DG.CurrentRow.Cells[1].Value.ToString());
        //        itm.lngGrLevel = Convert.ToInt32(DG.CurrentRow.Cells[2].Value.ToString());
        //        itm.intCashFlowType = Convert.ToInt32(DG.CurrentRow.Cells[3].Value.ToString());
        //        itm.GroupName = DG.CurrentRow.Cells[4].Value.ToString();
        //        itm.ParentName = DG.CurrentRow.Cells[5].Value.ToString();
        //        itm.strMobileNo = DG.CurrentRow.Cells[11].Value.ToString();
        //        itm.strContactNo = DG.CurrentRow.Cells[12].Value.ToString();
        //        itm.intMode = Convert.ToInt32(DG.CurrentRow.Cells[13].Value.ToString());
        //        itm.intduplicate = Convert.ToInt32(DG.CurrentRow.Cells[14].Value.ToString());
        //        if (DG.CurrentRow.Cells[15].Value != null)
        //        {
        //            itm.strResignMobile = DG.CurrentRow.Cells[15].Value.ToString();
        //        }
        //        else
        //        {
        //            itm.strResignMobile = "";
        //        }
        //        items.Add(itm);
        //        return items;
        //    }
        //    catch (Exception ex)
        //    {
        //        return items;
        //    }
        //}

        //-------------








        public void DeleteLedgerGroup(int serial)
        {
            try
            {
                //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM SubCategory WHERE SubCategoryId=" + id + "");

                //using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                //{
                //    if (connection.State == ConnectionState.Closed) connection.Open();
                //    connection.Query<CountryModel>("DELETE FROM A_M_LEDGERGROUP WHERE GR_SERIAL='" + id + "'");
                //}
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
                    string strSQL = "";
                    string name = "";
                    SqlDataReader dr1;
                    strSQL = "SELECT GR_NAME FROM A_M_LEDGERGROUP WHERE GR_SERIAL="+ serial+ "";
                    dr1 = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);
                    if (dr1.Read())
                    {
                        name = dr1["GR_NAME"].ToString();
                       
                    }


                    strSQL = "DELETE FROM A_M_G_TO_LEDGER ";
                    strSQL = strSQL + "WHERE GR_NAME = '" + name + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    strSQL = "DELETE FROM A_M_LEDGERGROUP ";                    
                    strSQL = strSQL + "WHERE GR_NAME = '" + name + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    cmdInsert.Transaction.Commit();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetLedgerGroupByGRName(int serial)
        {
            bool status = false;
            try
            {
                //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM SubCategory WHERE SubCategoryId=" + id + "");
                
                IDataReader dr;
                dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "SELECT GR_DEFAULT_GROUP  FROM A_M_LEDGERGROUP WHERE GR_SERIAL=" + serial + "");
                while (dr.Read())
                {
                    int default_value = Convert.ToInt32(dr["GR_DEFAULT_GROUP"]);
                    if(default_value==1)
                    { status = true; }
                    else { status = false; }
                    
                }
            }
            catch (Exception ex)
            {
                
            }
            return status;
        }

        #endregion

        #region Ledger        
        internal LedgerModel AddLedger(LedgerModel ledger)
        {
            LedgerModel ledgermodel = new LedgerModel();
            long lngGroupType = 0, lngLedgerGroup = 0, lngMultiply = 0, lngLedgerLevel = 0, lngVector = 0, lngGrLevel = 0,
                lngCashFlowType = 0, lngManuFacType = 0, lngLedgerStatus = 0, lngInventoryAffect = 0, lngPayroll = 0, lngPaySumm = 0;
            string strSQL, strPrimary = "", strReportGroup = "", strLedgerName = "", strParent, strEMail, strFax, strVectorDrCr = "";
            double dblOpeningBalance = 0;

            bool blnInsert = false;
            strLedgerName = ledger.LEDGER_NAME.Trim().Replace("'", "''");

            strParent = ledger.LEDGER_PARENT_GROUP;
            strEMail = ledger.LEDGER_EMAIL;
            strFax = ledger.LEDGER_FAX;
            
            if ( ledger.LEDGER_VECTOR == "Yes")
            {
                lngVector = 2;
            }
            else if (ledger.LEDGER_VECTOR == "No")
            {
                lngVector = 1;
            }
            if (ledger.DR_CR.ToUpper() == "DR")
            {
                lngMultiply = -1;
            }
            else if (ledger.DR_CR.ToUpper() == "CR")
            {
                lngMultiply = 1;
            }

            if (ledger.LEDGER_OPENING_BALANCE == 0)
            {
                dblOpeningBalance = 0;
            }
            else
            {
                dblOpeningBalance =Convert.ToDouble(ledger.LEDGER_OPENING_BALANCE) * lngMultiply;
            }
            try
            {
                SqlDataReader dr;
                strSQL = "SELECT GR_PRIMARY,GR_GROUP,GR_LEVEL,GR_ONE_DOWN,GR_PRIMARY_TYPE,";
                strSQL += "GR_CASH_FLOW_TYPE FROM A_M_LEDGERGROUP WHERE GR_NAME = '" + strParent + "' ";
                
                dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);
                if (dr.Read())
                {
                    strPrimary = dr["GR_PRIMARY"].ToString();
                    lngLedgerGroup = long.Parse(dr["GR_GROUP"].ToString());
                    lngGroupType = long.Parse(dr["GR_PRIMARY_TYPE"].ToString());
                    strReportGroup = (dr["GR_ONE_DOWN"].ToString());
                    lngLedgerLevel = long.Parse(dr["GR_LEVEL"].ToString()) + 1;
                    lngCashFlowType = long.Parse(dr["GR_CASH_FLOW_TYPE"].ToString());
                    //lngManuFacType = long.Parse(dr["GR_MANUFAC_GROUP"].ToString());

                    if (strPrimary == strReportGroup)
                    {
                        strReportGroup = strLedgerName;
                    }

                }

                dr.Close();

                if (lngLedgerGroup == 0)
                {
                    lngLedgerGroup = (long)GR_GROUP_TYPE.grOTHER_LEDGER;
                }

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


                    strSQL = "INSERT INTO A_M_LEDGER(";
                    strSQL = strSQL + "LEDGER_NAME, LEDGER_CASH_FLOW_TYPE,LEDGER_PARENT_GROUP,";
                    strSQL = strSQL + "LEDGER_PRIMARY_GROUP,LEDGER_ONE_DOWN,LEDGER_OPENING_BALANCE,";
                    strSQL = strSQL + "LEDGER_ADDRESS1,LEDGER_ADDRESS2,LEDGER_CITY,LEDGER_POSTAL, ";
                    strSQL = strSQL + "LEDGER_PHONE,LEDGER_FAX,LEDGER_EMAIL,";
                    strSQL = strSQL + "LEDGER_COMMENTS,";
                    strSQL = strSQL + "LEDGER_GROUP,LEDGER_LEVEL,LEDGER_PRIMARY_TYPE,";
                    strSQL = strSQL + "LEDGER_VECTOR,";
                    strSQL = strSQL + "LEDGER_CURRENCY_SYMBOL,LEDGER_STATUS) ";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + strLedgerName + "',";
                    //strSQL = strSQL + "'" + strLedgerName + "',";
                    //strSQL = strSQL + " " + lngInventoryAffect + ",";
                    strSQL = strSQL + "" + lngCashFlowType + ",";
                    strSQL = strSQL + "'" + strParent + "','" + strPrimary + "', ";
                    strSQL = strSQL + "'" + strReportGroup + "', ";
                    strSQL = strSQL + "" + dblOpeningBalance + ",";
                    strSQL = strSQL + "'" + ledger.LEDGER_ADDRESS1 + "', ";
                    strSQL = strSQL + "'" + ledger.LEDGER_ADDRESS1 + "', ";
                    strSQL = strSQL + "'" + ledger.LEDGER_CITY + "', ";
                    strSQL = strSQL + "'" + ledger.LEDGER_POSTAL + "', ";
                    strSQL = strSQL + "'" + ledger.LEDGER_PHONE + "', ";
                    strSQL = strSQL + "'" + strFax + "', ";
                    strSQL = strSQL + "'" + strEMail + "', ";
                    strSQL = strSQL + "'" + ledger.LEDGER_COMMENTS + "',";
                    //strSQL = strSQL + "" + lngPayroll + ",";
                    //strSQL = strSQL + "" + dblOpeningBalance + ",";
                    strSQL = strSQL + " " + lngLedgerGroup + ", ";
                    strSQL = strSQL + " " + lngLedgerLevel + ", ";
                    strSQL = strSQL + " " + lngGroupType + ", ";
                    strSQL = strSQL + " " + lngVector + ",";
                    //strSQL = strSQL + " " + lngManuFacType + ",";
                    strSQL = strSQL + "'" + ledger.LEDGER_CURRENCY_NAME + "',";
                    strSQL = strSQL + " " + lngLedgerStatus + "";
                    //strSQL = strSQL + " " + Utility.Val(strPFAmount) + ",";
                    //strSQL = strSQL + " " + lngPaySumm + " ";
                    strSQL = strSQL + ")";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);

                    strSQL = "INSERT INTO A_M_LEDGER_TO_GROUP(GR_NAME,LEDGER_NAME) VALUES(";
                    strSQL = strSQL + "'" + strParent + "','" + strLedgerName + "'";
                    strSQL = strSQL + ")";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
                    do
                    {


                        strSQL = "SELECT GR_PARENT,GR_LEVEL FROM A_M_LEDGERGROUP ";
                        strSQL = strSQL + "WHERE GR_NAME ='" + strParent + "' ";
                        SqlDataReader dr1;
                        dr1 = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);
                        if (dr1.Read())
                        {
                            strParent = dr1["GR_PARENT"].ToString().Replace("'", "''");
                            lngGrLevel = long.Parse(dr1["GR_LEVEL"].ToString());
                        }

                        dr1.Close();
                        if (lngGrLevel == 1)
                        {
                            blnInsert = true;
                        }

                        if (blnInsert == false)
                        {

                            strSQL = "INSERT INTO A_M_LEDGER_TO_GROUP(GR_NAME,LEDGER_NAME) ";
                            strSQL = strSQL + "VALUES(";
                            strSQL = strSQL + "'" + strParent + "','" + strLedgerName + "'";
                            strSQL = strSQL + ")";

                            cmdInsert.CommandText = strSQL;
                            cmdInsert.ExecuteNonQuery();
                            //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
                        }
                    }

                    while (blnInsert == false);
                    dr.Close();

                    cmdInsert.Transaction.Commit();
                    gcnMain.Close();

                }
            }
            catch (Exception EX)
            {

            }
            return ledgermodel;
        }
        internal LedgerModel UpdateLedger(LedgerModel ledger)
        {
            LedgerModel ledgermodel = new LedgerModel();
            long lngGroupType = 0, lngLedgerGroup = 0, lngMultiply = 0, lngLedgerLevel = 0, lngVector = 0, lngGrLevel = 0,
                lngCashFlowType = 0, lngManuFacType = 0, lngLedgerStatus = 0, lngInventoryAffect = 0, lngPayroll = 0, lngStatus = 0, lngPaySumm = 0;
            string strSQL, strPrimary = "", strReportGroup = "", strLedgerName = "", strParent, strEMail, strFax, strVectorDrCr = "";
            double dblOpeningBalance = 0, dblOldOpening = 0, dblClosingBalance = 0, dblOpn = 0, dblCls = 0;

            bool blnInsert = false;

            using (SqlConnection gcnMain = new SqlConnection(Global.ConnectionString))
            {
                if (gcnMain.State == ConnectionState.Open)
                {
                    gcnMain.Close();
                }
                gcnMain.Open();
                SqlCommand cmdInsert = new SqlCommand();
                SqlTransaction myTrans;
                SqlDataReader dr;
                myTrans = gcnMain.BeginTransaction();
                cmdInsert.Connection = gcnMain;
                cmdInsert.Transaction = myTrans;



                strLedgerName = ledger.LEDGER_NAME.Trim().Replace("'", "''");

                strParent = ledger.LEDGER_PARENT_GROUP;
                strEMail = ledger.LEDGER_EMAIL;
                strFax = ledger.LEDGER_FAX;
                
                if (ledger.LEDGER_VECTOR == "Yes")
                {
                    lngVector = 2;
                }
                else if (ledger.LEDGER_VECTOR == "No")
                {
                    lngVector = 1;
                }
                if (ledger.DR_CR.ToUpper() == "DR")
                {
                    lngMultiply = -1;
                }
                else if (ledger.DR_CR.ToUpper() == "CR")
                {
                    lngMultiply = 1;
                }

                if (ledger.LEDGER_OPENING_BALANCE == 0)
                {
                    dblOpeningBalance = 0;
                }
                else
                {
                    dblOpeningBalance = Convert.ToDouble(ledger.LEDGER_OPENING_BALANCE) * lngMultiply;
                }
                try
                {
                    strSQL = "SELECT GR_PRIMARY,GR_GROUP,GR_LEVEL,GR_ONE_DOWN,GR_PRIMARY_TYPE,";
                    strSQL += "GR_CASH_FLOW_TYPE FROM A_M_LEDGERGROUP WHERE GR_NAME = '" + strParent + "' ";
                    dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);
                    if (dr.Read())
                    {
                        strPrimary = dr["GR_PRIMARY"].ToString();
                        lngLedgerGroup = long.Parse(dr["GR_GROUP"].ToString());
                        lngGroupType = long.Parse(dr["GR_PRIMARY_TYPE"].ToString());
                        strReportGroup = (dr["GR_ONE_DOWN"].ToString());
                        lngLedgerLevel = long.Parse(dr["GR_LEVEL"].ToString()) + 1;
                        lngCashFlowType = long.Parse(dr["GR_CASH_FLOW_TYPE"].ToString());
                        if (strPrimary == strReportGroup)
                        {
                            strReportGroup = strLedgerName;
                        }
                    }
                    dr.Close();

                    strSQL = "SELECT LEDGER_OPENING_BALANCE FROM A_M_LEDGER ";
                    strSQL = strSQL + "WHERE LEDGER_NAME = '" + ledger.LEDGER_NAME.Trim().Replace("'", "''") + "'";
                    dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);
                    if (dr.Read())
                    {
                        dblOldOpening = Convert.ToDouble(dr["LEDGER_OPENING_BALANCE"]);
                        //dblClosingBalance = Convert.ToDouble(dr["LEDGER_CLOSING_BALANCE"]);
                    }

                    dr.Close();
                    strSQL = "DELETE FROM A_M_LEDGER_TO_GROUP WHERE LEDGER_NAME = '" + ledger.LEDGER_NAME.Trim().Replace("'", "''") + "'";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();


                    if (lngLedgerGroup == 0)
                    {
                        lngLedgerGroup = (long)GR_GROUP_TYPE.grOTHER_LEDGER;
                    }


                    strSQL = "UPDATE A_M_LEDGER ";
                    strSQL = strSQL + "SET LEDGER_NAME = '" + strLedgerName.Trim().Replace("'", "''") + "',";
                    //strSQL = strSQL + "LEDGER_NAME_MERZE = '" + strLedgerName.Trim().Replace("'", "''") + "',";
                    strSQL = strSQL + "LEDGER_PARENT_GROUP = '" + strParent + "',";
                    //strSQL = strSQL + "LEDGER_INVENTORY_AFFECT = " + lngInventoryAffect + ",";
                    strSQL = strSQL + "LEDGER_PRIMARY_GROUP = '" + strPrimary + "',";
                    strSQL = strSQL + "LEDGER_ONE_DOWN = '" + strReportGroup + "',";
                    strSQL = strSQL + "LEDGER_OPENING_BALANCE = " + dblOpeningBalance + ", ";
                    strSQL = strSQL + "LEDGER_ADDRESS1 = '" + ledger.LEDGER_ADDRESS1 + "', ";
                    strSQL = strSQL + "LEDGER_ADDRESS2 = '" + ledger.LEDGER_ADDRESS2 + "', ";
                    strSQL = strSQL + "LEDGER_CITY = '" + ledger.LEDGER_CITY + "', ";
                    strSQL = strSQL + "LEDGER_CURRENCY_SYMBOL = '" + ledger.LEDGER_CURRENCY_SYMBOL + "', ";
                    strSQL = strSQL + "LEDGER_POSTAL = '" + ledger.LEDGER_POSTAL + "', ";
                    strSQL = strSQL + "LEDGER_PHONE = '" + ledger.LEDGER_PHONE + "', ";
                    strSQL = strSQL + "LEDGER_FAX = '" + ledger.LEDGER_FAX + "', ";
                    strSQL = strSQL + "LEDGER_EMAIL = '" + ledger.LEDGER_EMAIL + "', ";
                    strSQL = strSQL + "LEDGER_COMMENTS = '" + ledger.LEDGER_COMMENTS + "', ";
                    //strSQL = strSQL + "LEDGER_PAYROLL = " + lngPayroll + ",";
                    strSQL = strSQL + "LEDGER_GROUP = " + lngLedgerGroup + ",";
                    strSQL = strSQL + "LEDGER_LEVEL = " + lngLedgerLevel + ",";
                    strSQL = strSQL + "LEDGER_STATUS = " + lngLedgerStatus + ",";
                    strSQL = strSQL + "LEDGER_VECTOR = " + lngVector + ",";
                    //strSQL = strSQL + "LEDGER_MANUFAC_GROUP = " + lngManuFacType + ",";
                    strSQL = strSQL + "LEDGER_PRIMARY_TYPE = " + lngGroupType + "";
                    //strSQL = strSQL + "SUMM_RPT = " + lngPaySumm + ",";
                    //strSQL = strSQL + "PF_AMOUNT =" + Utility.Val(strPFAmount) + ",";
                    //strSQL = strSQL + "LEDGER_CLOSING_BALANCE = " + ((dblClosingBalance + dblOpeningBalance) - dblOldOpening) + " ";
                    strSQL = strSQL + " WHERE LEDGER_SERIAL = " + ledger.LEDGER_SERIAL + " ";

                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);

                    //string strUpdate = Utility.gInsertUpdateLog(strDeComID
                    //, strOldLedger.Trim().Replace("'", "''")
                    //, dblOldOpening
                    //, strLedgerName.Trim().Replace("'", "''")
                    //, dblOpeningBalance
                    //, "ACC_LEDGER", "LEDGER_NAME");    // NOT Found this Method


                    strSQL = "INSERT INTO A_M_LEDGER_TO_GROUP(GR_NAME,LEDGER_NAME) VALUES(";
                    strSQL = strSQL + "'" + strParent + "','" + strLedgerName.Trim().Replace("'", "''") + "'";
                    strSQL = strSQL + ")";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
                    dr.Close();
                    do
                    {
                        strSQL = "SELECT GR_PARENT,GR_LEVEL FROM A_M_LEDGERGROUP ";
                        strSQL = strSQL + "WHERE GR_NAME ='" + strParent + "' ";
                        SqlDataReader dr1;
                        dr1 = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, strSQL);
                        if (dr1.Read())
                        {
                            strParent = dr1["GR_PARENT"].ToString().Replace("'", "''");
                            lngGrLevel = long.Parse(dr1["GR_LEVEL"].ToString());
                        }

                        dr1.Close();
                        if (lngGrLevel == 1)
                        {
                            blnInsert = true;
                        }
                        if (lngGrLevel == 0)
                        {
                            blnInsert = true;
                        }
                        if (blnInsert == false)
                        {

                            strSQL = "INSERT INTO A_M_LEDGER_TO_GROUP(GR_NAME,LEDGER_NAME) ";
                            strSQL = strSQL + "VALUES(";
                            strSQL = strSQL + "'" + strParent + "','" + strLedgerName.Trim().Replace("'", "''") + "'";
                            strSQL = strSQL + ")";
                            cmdInsert.CommandText = strSQL;
                            cmdInsert.ExecuteNonQuery();
                            //SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, strSQL);
                        }
                    }

                    while (blnInsert == false);

                    strSQL = "UPDATE ACC_VOUCHER SET VOUCHER_REVERSE_LEDGER = '" + strLedgerName.Trim().Replace("'", "''") + "' ";
                    strSQL = strSQL + "WHERE VOUCHER_REVERSE_LEDGER = '" + ledger.LEDGER_NAME.Trim().Replace("'", "''") + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();
                    cmdInsert.Transaction.Commit();
                    gcnMain.Close();
                    
                }
                catch (Exception ex)
                {

                }
            }
            return ledgermodel;
        }
        public DynamicParameters SetLedgerParameters(LedgerModel ledger)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LEDGER_SERIAL", ledger.LEDGER_SERIAL);
            parameters.Add("@LEDGER_NAME", ledger.LEDGER_NAME);
            parameters.Add("@LEDGER_CURRENCY_SYMBOL", ledger.LEDGER_CURRENCY_SYMBOL);
            parameters.Add("@LEDGER_CASH_FLOW_TYPE", ledger.LEDGER_CASH_FLOW_TYPE);
            parameters.Add("@LEDGER_PARENT_GROUP", ledger.LEDGER_PARENT_GROUP);
            parameters.Add("@LEDGER_PRIMARY_GROUP", ledger.LEDGER_PRIMARY_GROUP);
            parameters.Add("@LEDGER_ONE_DOWN", ledger.LEDGER_ONE_DOWN);
            parameters.Add("@LEDGER_NAME_DEFAULT", ledger.LEDGER_NAME_DEFAULT);
            parameters.Add("@LEDGER_STATUS", ledger.LEDGER_STATUS);
            parameters.Add("@LEDGER_OPENING_BALANCE", ledger.LEDGER_OPENING_BALANCE);
            parameters.Add("@LEDGER_FC_OPENING_BALANCE", ledger.LEDGER_FC_OPENING_BALANCE);            
            parameters.Add("@LEDGER_CURRENCY_NAME", ledger.LEDGER_CURRENCY_NAME);
            parameters.Add("@LEDGER_ADDRESS1", ledger.LEDGER_ADDRESS1);
            parameters.Add("@LEDGER_ADDRESS2", ledger.LEDGER_ADDRESS2);
            parameters.Add("@LEDGER_CITY", ledger.LEDGER_CITY);
            parameters.Add("@LEDGER_POSTAL", ledger.LEDGER_POSTAL);
            parameters.Add("@LEDGER_FAX", ledger.LEDGER_FAX);
            parameters.Add("@LEDGER_PHONE", ledger.LEDGER_PHONE);
            parameters.Add("@LEDGER_MOBILE", ledger.LEDGER_MOBILE);
            parameters.Add("@LEDGER_EMAIL", ledger.LEDGER_EMAIL);
            parameters.Add("@LEDGER_COUNTRY", ledger.LEDGER_COUNTRY);
            parameters.Add("@LEDGER_COMMENTS", ledger.LEDGER_COMMENTS);
            parameters.Add("@LEDGER_VECTOR", ledger.LEDGER_VECTOR);
            parameters.Add("@LEDGER_GROUP", ledger.LEDGER_GROUP);
            parameters.Add("@LEDGER_PRIMARY_TYPE", ledger.LEDGER_PRIMARY_TYPE);
            parameters.Add("@ENTRYBY", ledger.ENTRYBY);
            parameters.Add("@UPDATEBY", ledger.UPDATEBY);

            return parameters;
        }
        public void DeleteLedgerById(string name)
        {
            try
            {
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
                    string strSQL = "";

                    strSQL = "DELETE FROM A_M_LEDGER_TO_GROUP ";
                    strSQL = strSQL + "WHERE LEDGER_NAME = '" + name + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    strSQL = "DELETE FROM A_M_LEDGER ";
                    strSQL = strSQL + "WHERE LEDGER_NAME = '" + name + "' ";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();

                    cmdInsert.Transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public List<LedgerModel> GetLedger()
        {
            List<LedgerModel> ledgerList = new List<LedgerModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var currencies = connection.Query<LedgerModel>("SELECT * FROM A_M_LEDGER");
                    if (currencies.Count() > 0)
                    {
                        ledgerList = currencies.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledgerList;

        }
        public LedgerModel GetLedgerByCode(string Id)
        {
            LedgerModel ledger = new LedgerModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var currencies = connection.Query<LedgerModel>("SELECT * FROM A_M_LEDGER WHERE LEDGER_SERIAL="+Id+"");
                    if (currencies.Count() > 0)
                    {
                        ledger = currencies.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ledger;

        }


        public bool GetLedgerByGRName(string name)
        {
            bool status = false;
            try
            {
                IDataReader dr;
                dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "SELECT LEDGER_DEFAULT  FROM A_M_LEDGER WHERE LEDGER_NAME='" + name + "'");
                while (dr.Read())
                {
                    int default_value = Convert.ToInt32(dr["LEDGER_DEFAULT"]);
                    if (default_value == 1)
                    { status = true; }
                    else { status = false; }

                }
            }
            catch (Exception ex)
            {

            }
            return status;
        }

        #endregion

        #region Budget
        internal BudgetModel AddBudget(BudgetModel budgetModel)
        {
            BudgetModel branch = new BudgetModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<BudgetModel>("SP_ACC_BRANCH_INSERT_BRANCH",
                        this.SetParameters_budget(budgetModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return branch;
        }
        public DynamicParameters SetParameters_budget(BudgetModel budget)
        {
            DynamicParameters parameters = new DynamicParameters();
            //parameters.Add("@BRANCH_NAME", budget.BRANCH_NAME);
            //parameters.Add("@BRANCH_ADD1", budget.BRANCH_ADD1);
            //parameters.Add("@BRANCH_ADD2", budget.BRANCH_ADD2);
            return parameters;
        }
        internal BudgetModel UpdateBudget(BudgetModel budgetModel)
        {
            BudgetModel branch = new BudgetModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<BudgetModel>("SP_ACC_BRANCH_INSERT_BRANCH",
                        this.SetParameters_budget(budgetModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return branch;
        }

        public List<BudgetModel> GetBudgetList()
        {
            List<BudgetModel> budgetsList = new List<BudgetModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var budgets = connection.Query<BudgetModel>("SELECT * FROM ACC_BRANCH");
                    if (budgets.Count() > 0)
                    {
                        budgetsList = budgets.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return budgetsList;
        }

        public void DeleteBudgetById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    connection.Query<CountryModel>("DELETE FROM ACC_BRANCH WHERE BRANCH_ID=" + id + "");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Cost Categories
        internal CostCategoriesModels AddCostCategories(CostCategoriesModels costCategoriesModels)
        {
            CostCategoriesModels costCategories = new CostCategoriesModels();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<CostCategoriesModels>("SP_ACC_BRANCH_INSERT_BRANCH",
                        this.SetParameters_costCategories(costCategoriesModels), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return costCategories;
        }
        public DynamicParameters SetParameters_costCategories(CostCategoriesModels costCategories)
        {
            DynamicParameters parameters = new DynamicParameters();
            //parameters.Add("@BRANCH_NAME", budget.BRANCH_NAME);
            //parameters.Add("@BRANCH_ADD1", budget.BRANCH_ADD1);
            //parameters.Add("@BRANCH_ADD2", budget.BRANCH_ADD2);
            return parameters;
        }
        internal CostCategoriesModels UpdateCostCategories(CostCategoriesModels costCategoriesModel)
        {
            CostCategoriesModels costCategories = new CostCategoriesModels();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<CostCategoriesModels>("SP_ACC_BRANCH_INSERT_BRANCH",
                        this.SetParameters_costCategories(costCategoriesModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return costCategories;
        }
        public List<CostCategoriesModels> GetCostCategoriesList()
        {
            List<CostCategoriesModels> costCategoriesList = new List<CostCategoriesModels>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var costCategories = connection.Query<CostCategoriesModels>("SELECT * FROM ACC_BRANCH");
                    if (costCategories.Count() > 0)
                    {
                        costCategoriesList = costCategories.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return costCategoriesList;
        }

        #endregion


        #region Country
        //public List<CountryModel> GetCountry()
        //{
        //    List<CountryModel> countryList = new List<CountryModel>();
        //    try
        //    {
        //        using (IDbConnection connection = new SqlConnection(Global.SOC_ConnectionString))
        //        {
        //            if (connection.State == ConnectionState.Closed) connection.Open();
        //            var poModel = connection.Query<CountryModel>("SELECT * FROM Country");
        //            if (poModel.Count() > 0)
        //            {
        //                countryList = poModel.ToList();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return countryList;
        //}
        #endregion

        #region Primary
        public List<PrimaryModel> GetPrimaryList()
        {
            List<PrimaryModel> primaryList = new List<PrimaryModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PrimaryModel>("SELECT * FROM A_M_PRIMARY");
                    if (poModel.Count() > 0)
                    {
                        primaryList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return primaryList;
        }

        #endregion
        internal List<UnitModel> GetUnitList()
        {
            List<UnitModel> unitList = new List<UnitModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var unit = connection.Query<UnitModel>("SELECT * FROM TBL_UNIT ORDER BY UNIT_NAME");
                    if (unit.Count() > 0)
                    {
                        unitList = unit.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return unitList;
        }
        internal List<ColorModel> GetColorList()
        {
            List<ColorModel> colorList = new List<ColorModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var color = connection.Query<ColorModel>("SELECT * FROM TBL_COLOR ORDER BY COLOR_NAME");
                    if (color.Count() > 0)
                    {
                        colorList = color.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return colorList;
        }
        internal List<ItemForm_Appearance> GetItemForm_Appearance()
        {
            List<ItemForm_Appearance> itemForm_AppearanceList = new List<ItemForm_Appearance>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var color = connection.Query<ItemForm_Appearance>("SELECT * FROM TBL_ITEM_FORM_APPEARANCE");
                    if (color.Count() > 0)
                    {
                        itemForm_AppearanceList = color.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return itemForm_AppearanceList;
        }

        internal List<ItemSewstivenessModel> GetItemSewstiveness()
        {
            List<ItemSewstivenessModel> itemSewstivenessList = new List<ItemSewstivenessModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var color = connection.Query<ItemSewstivenessModel>("SELECT * FROM TBL_ITEM_SEWISTIVENESS");
                    if (color.Count() > 0)
                    {
                        itemSewstivenessList = color.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return itemSewstivenessList;
        }


        internal BrandModel AddBrand(BrandModel brandModel)
        {
            brand = new BrandModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<BrandModel>("SP_BRAND_INSERT_BRAND",
                        this.SetParameters(brandModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return brand;
        }
        internal BrandModel UpdateBrand(BrandModel brandModel)
        {
            brand = new BrandModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<BrandModel>("SP_BRAND_INSERT_BRAND",
                        this.SetParameters(brandModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return brand;
        }
        public DynamicParameters SetParameters(BrandModel brandModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BRAND_ID", brandModel.BRAND_ID);
            parameters.Add("@BRAND_NAME", brandModel.BRAND_NAME);
            parameters.Add("@Operation_Type", brandModel.Operation_Type);

            return parameters;
        }
        internal UnitModel AddUnit(UnitModel brandModel)
        {
            unit = new UnitModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<UnitModel>("SP_UNIT_INSERT_UNIT",
                        this.SetParametersUnit(brandModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return unit;
        }
        internal UnitModel UpdateUnit(UnitModel brandModel)
        {
            unit = new UnitModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<UnitModel>("SP_UNIT_INSERT_UNIT",
                        this.SetParametersUnit(brandModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return unit;
        }
        
        public DynamicParameters SetParametersUnit(UnitModel unitModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UNIT_ID", unitModel.UNIT_ID);
            parameters.Add("@UNIT_NAME", unitModel.UNIT_NAME);            
            parameters.Add("@OPERATION_TYPE", unitModel.Operation_Type);

            return parameters;
        }
        internal ItemCategory AddItemCategory(ItemCategory itemCategory)
        {
            ItemCategory category = new ItemCategory();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ItemCategory>("SP_CATEGORY_INSERT_ITEMCATEGORY",
                        this.SetParametersCategory(itemCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch
            {

            }
            return category;
        }
        internal ItemCategory UpdateItemCategory(ItemCategory itemCategory)
        {
            ItemCategory category = new ItemCategory();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ItemCategory>("SP_CATEGORY_INSERT_ITEMCATEGORY",
                        this.SetParametersCategory(itemCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch
            {

            }
            return category;
        }
        public void DeleteCategory(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_ITEM_CATEGORY WHERE CATEGORY_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteUnit(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_UNIT WHERE UNIT_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteCountry(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_COUNTRY WHERE COUNTRY_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteColor(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_COLOR WHERE COLOR_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteBrand(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_BRAND WHERE BRAND_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteApplicationArea(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_ITEM_APPLICATION_AREA WHERE APPLICATION_AREA_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteProject(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_CUSTOMER_PROJECT WHERE CUSTOMER_PROJECT_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteInventoryType(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_INVENTORY_TYPE WHERE INVENTORY_TYPE_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DynamicParameters SetParametersService(ServiceEntity category)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SERVICE_ID", category.SERVICE_ID);
            parameters.Add("@SERVICE_CATEGORY_ID", category.SERVICE_CATEGORY_ID);
            parameters.Add("@SERVICE_CODE", category.SERVICE_CODE);
            parameters.Add("@SERVICE_NAME", category.SERVICE_NAME);
            parameters.Add("@OPERATION_TYPE", category.OPERATION_TYPE);
            return parameters;
        }
        public DynamicParameters SetParametersCategory(ItemCategory category)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CATEGORY_ID", category.CATEGORY_ID);
            parameters.Add("@CATEGORY_NAME", category.CATEGORY_NAME);            
            parameters.Add("@Operation_Type", category.Operation_Type);
            return parameters;
        }
        //

        internal ItemSubCategory AddItemSubCategory(ItemSubCategory itemsubCategory)
        {
            ItemSubCategory subcategory = new ItemSubCategory();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ItemCategory>("SP_CATEGORY_INSERT_ITEM_SUB_CATEGORY",
                        this.SetParametersSubCategory(itemsubCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch
            {

            }
            return subcategory;
        }
        public DynamicParameters SetParametersSubCategory(ItemSubCategory category)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SUBCATEGORY_ID", category.SUBCATEGORY_ID);
            parameters.Add("@CATEGORY_ID", category.CATEGORY_ID);
            parameters.Add("@SUBCATEGORY_NAME", category.SUBCATEGORY_NAME);
            parameters.Add("@Operation_Type", category.Operation_Type);
            return parameters;
        }

        internal ServiceEntity AddService(ServiceEntity itemCategory)
        {
            ServiceEntity category = new ServiceEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ServiceEntity>("SP_INSERT_SERVICE",
                        this.SetParametersService(itemCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            {

            }
            return category;
        }
        internal ServiceEntity UpdateService(ServiceEntity itemCategory)
        {
            ServiceEntity category = new ServiceEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ServiceEntity>("SP_INSERT_SERVICE",
                        this.SetParametersService(itemCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            {

            }
            return category;
        }

        internal ColorModel AddColor(ColorModel colorModel)
        {
            color = new ColorModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ColorModel>("SP_COLOR_INSERT_COLOR",
                        this.SetParametersColor(colorModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return color;
        }
        internal clsItemType AddItemType(clsItemType itemType)
        {
            clsItemType itemtype = new clsItemType();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<clsItemType>("SP_ITEM_TYPE_INSERT_ITEMTYPE",
                        this.SetParametersItemType(itemType), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return itemtype;
        }
        internal List<clsItemType> GetItemType()
        {
            List<clsItemType> itemList = new List<clsItemType>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
                {
                    using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();
                        var poModel = connection.Query<clsItemType>("SELECT * FROM TBL_ITEM_TYPE");
                        if (poModel.Count() > 0)
                        {
                            itemList = poModel.ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return itemList;

        }
        public DynamicParameters SetParametersItemType(clsItemType itemType)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ITEM_TYPE_ID", itemType.ITEM_TYPE_ID);
            parameters.Add("@ITEM_TYPE", itemType.ITEM_TYPE);
            parameters.Add("@Operation_Type", itemType.Operation_Type);

            return parameters;
        }
        internal ColorModel UpdateColor(ColorModel colorModel)
        {
            color = new ColorModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ColorModel>("SP_COLOR_INSERT_COLOR",
                        this.SetParametersColor(colorModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return color;
        }
        public DynamicParameters SetParametersColor(ColorModel colorModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@COLOR_ID", colorModel.COLOR_ID);
            parameters.Add("@COLOR_NAME", colorModel.COLOR_NAME);
            parameters.Add("@Operation_Type", colorModel.Operation_Type);

            return parameters;
        }

        public List<WarehouseModel> GetWareHouseList()
        {
            List<WarehouseModel> stockList = new List<WarehouseModel>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<WarehouseModel>("SELECT * FROM TBL_WAREHOUSE");
                if (poModel.Count() > 0)
                {
                    stockList = poModel.ToList();
                }
            }
            return stockList;
        }
        public List<ItemCategory> GetItemCategory()
        {
            List<ItemCategory> categoryList = new List<ItemCategory>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<ItemCategory>("SELECT * FROM TBL_ITEM_CATEGORY ORDER BY CATEGORY_NAME");
                if (poModel.Count() > 0)
                {
                    categoryList = poModel.ToList();
                }
            }
            return categoryList;
        }
        public List<ServiceEntity> GetServiceList()
        {
            List<ServiceEntity> categoryList = new List<ServiceEntity>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<ServiceEntity>("SELECT * FROM TBL_ALL_SEMCORP_SERVICES ORDER BY SERVICE_NAME");
                if (poModel.Count() > 0)
                {
                    categoryList = poModel.ToList();
                }
            }
            return categoryList;
        }
        internal PlanAndOperationModel AddPlanAndWorkSchedule(PlanAndOperationModel planAndOpp)
        {
            PlanAndOperationModel planAndOperation = new PlanAndOperationModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<PlanAndOperationModel>("SP_PLAN_INSERT_PLAN_AND_SCHEDULE",
                        this.SetParametersPlanandOperation(planAndOpp), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return planAndOperation;
        }
        internal PlanAndOperationModel UpdatePlanAndWorkSchedule(PlanAndOperationModel planAndOpp)
        {
            PlanAndOperationModel planAndOperation = new PlanAndOperationModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<PlanAndOperationModel>("SP_PLAN_UPDATE_PLAN_AND_SCHEDULE",
                        this.SetParametersPlanandOperationUpdate(planAndOpp), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return planAndOperation;
        }

        public DynamicParameters SetParametersPlanandOperation(PlanAndOperationModel planAndOpp)
        {
            DynamicParameters parameters = new DynamicParameters();


            parameters.Add("@TASK_DESCRIPTION", planAndOpp.TASK_DESCRIPTION);
            parameters.Add("@DEPARTMENT_ID", planAndOpp.DEPARTMENT_ID);
            parameters.Add("@TASK_ASSIGN_TO", planAndOpp.TASK_ASSIGN_TO);
            parameters.Add("@TASK_ASSIGN_BY", planAndOpp.TASK_ASSIGN_BY);
            parameters.Add("@PLANNED_START_DATE", planAndOpp.PLANNED_START_DATE);
            parameters.Add("@ACTUAL_START_DATE", planAndOpp.ACTUAL_START_DATE);
            parameters.Add("@PLANNED_COMPLETION_DATE", planAndOpp.PLANNED_COMPLETION_DATE);
            parameters.Add("@ACTUAL_COMPLETION_DATE", planAndOpp.ACTUAL_COMPLETION_DATE);
            parameters.Add("@PLANNED_DURATION", planAndOpp.PLANNED_DURATION);
            parameters.Add("@ACTUAL_DURATION", planAndOpp.ACTUAL_DURATION);
            parameters.Add("@ACTIVITIES", planAndOpp.ACTIVITIES);
            parameters.Add("@STATUS_ID", planAndOpp.STATUS_ID);
            parameters.Add("@COMMENTS", planAndOpp.COMMENTS);
            parameters.Add("@COMMENTS_QUILL_CONTENT", planAndOpp.COMMENTS_QUILL_CONTENT);
            parameters.Add("@OPEN_FOR", planAndOpp.OPEN_FOR);
            parameters.Add("@REG_BY", planAndOpp.REG_BY);


            return parameters;
        }
        public DynamicParameters SetParametersPlanandOperationUpdate(PlanAndOperationModel planAndOpp)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@ID", planAndOpp.ID);
            parameters.Add("@TASK_DESCRIPTION", planAndOpp.TASK_DESCRIPTION);
            parameters.Add("@DEPARTMENT_ID", planAndOpp.DEPARTMENT_ID);
            parameters.Add("@TASK_ASSIGN_TO", planAndOpp.TASK_ASSIGN_TO);
            parameters.Add("@TASK_ASSIGN_BY", planAndOpp.TASK_ASSIGN_BY);
            parameters.Add("@PLANNED_START_DATE", planAndOpp.PLANNED_START_DATE);
            parameters.Add("@ACTUAL_START_DATE", planAndOpp.ACTUAL_START_DATE);
            parameters.Add("@PLANNED_COMPLETION_DATE", planAndOpp.PLANNED_COMPLETION_DATE);
            parameters.Add("@ACTUAL_COMPLETION_DATE", planAndOpp.ACTUAL_COMPLETION_DATE);
            parameters.Add("@PLANNED_DURATION", planAndOpp.PLANNED_DURATION);
            parameters.Add("@ACTUAL_DURATION", planAndOpp.ACTUAL_DURATION);
            parameters.Add("@ACTIVITIES", planAndOpp.ACTIVITIES);
            parameters.Add("@STATUS_ID", planAndOpp.STATUS_ID);
            parameters.Add("@COMMENTS", planAndOpp.COMMENTS);
            parameters.Add("@COMMENTS_QUILL_CONTENT", planAndOpp.COMMENTS_QUILL_CONTENT);

            parameters.Add("@UPD_BY", planAndOpp.UPD_BY);



            return parameters;
        }
        public List<PlanandOperationViewModel> GetPlanAndWorkScheduleList()
        {
            List<PlanandOperationViewModel> planList = new List<PlanandOperationViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PlanandOperationViewModel>("SELECT * FROM TBL_PLAN_AND_OPERATION");
                    if (poModel.Count() > 0)
                    {
                        planList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return planList;
        }
        public List<PlanandOperationViewModel> GetWorkSchedule(int departmentId)
        {
            List<PlanandOperationViewModel> stockList = new List<PlanandOperationViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@EMPLOYEE_ID", employeeId, DbType.Int32);
                parameters.Add("@DEPARTMENT_ID", departmentId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PlanandOperationViewModel>("SP_PLAN_GET_PLANNING_AND_WORK_SCHEDULE_BY_DEPARTMENT_ID", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        stockList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return stockList;
        }

        public List<PlanandOperationViewModel> GetWorkScheduleBySearchOption(string searchOption)
        {
            List<PlanandOperationViewModel> stockList = new List<PlanandOperationViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@SEARCHOPTION", searchOption, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PlanandOperationViewModel>("SP_PLAN_GET_PLANNING_AND_WORK_SCHEDULE_BY_SEARCH_OPTION", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        stockList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return stockList;
        }

        public List<PlanandOperationViewModel> GetWorkScheduleBySuperAdmin()
        {
            List<PlanandOperationViewModel> stockList = new List<PlanandOperationViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PlanandOperationViewModel>("SP_PLAN_GET_PLANNING_AND_WORK_SCHEDULE_BY_SUPER_ADMIN");
                    if (poModel.Count() > 0)
                    {
                        stockList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return stockList;
        }
        public List<PlanAndWorkScheduleStatusModel> GetPlanAndWorkStatus()
        {
            List<PlanAndWorkScheduleStatusModel> statusList = new List<PlanAndWorkScheduleStatusModel>();
            try
            {

                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PlanAndWorkScheduleStatusModel>("SELECT * FROM TBL_PLAN_AND_WORK_SCHEDULE_STATUS");
                    if (poModel.Count() > 0)
                    {
                        statusList = poModel.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return statusList;
        }
        public PlanAndOperationModel GetPlanAndWorkScheduleById(int Id)
        {
            PlanAndOperationModel planAndOperation = new PlanAndOperationModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", Id, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PlanAndOperationModel>("SP_PLAN_GET_PLAN_AND_SCHEDULE_BY_ID", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        planAndOperation = poModel.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return planAndOperation;
        }
        public PlanandOperationViewModel GetPlanAndWorkScheduleViewById(string Id)
        {
            PlanandOperationViewModel planAndOperation = new PlanandOperationViewModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", Id, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PlanandOperationViewModel>("SP_PLAN_GET_PLAN_AND_SCHEDULE_VIEW_BY_ID", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        planAndOperation = poModel.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return planAndOperation;
        }
        public List<PDeliveryTimeModel> GetDeliveryTime()
        {
            List<PDeliveryTimeModel> deliveryTime = new List<PDeliveryTimeModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PDeliveryTimeModel>("SELECT * FROM TBL_SETUP_PDELIVERY_TIME");
                    if (poModel.Count() > 0)
                    {
                        deliveryTime = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return deliveryTime;
        }
        public List<ShippingAddressModel> GetShippingAddress()
        {
            List<ShippingAddressModel> deliveryTime = new List<ShippingAddressModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ShippingAddressModel>("SELECT * FROM TBL_SHIPPING_ADDRESS");
                    if (poModel.Count() > 0)
                    {
                        deliveryTime = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return deliveryTime;
        }
        //---
        
        public ShippingAddressModel AddShippingAddress(ShippingAddressModel shipping)
        {
            ShippingAddressModel shippingAddressModel = new ShippingAddressModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ShippingAddressModel>("SP_SETUP_INSERT_SHIPPING_ADDRESS",
                        this.SetParametersShippingAddress(shipping), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return shippingAddressModel;
        }
        public DynamicParameters SetParametersShippingAddress(ShippingAddressModel shippingAddress)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SHIPPING_ADDRESS", shippingAddress.SHIPPING_ADDRESS);
            return parameters;
        }
        public DeliveryModeModel AddDeliveryMode(DeliveryModeModel deliveryMode)
        {
            DeliveryModeModel deliveryModeModel = new DeliveryModeModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<DeliveryModeModel>("SP_SETUP_INSERT_INTO_DELIVERY_MODE",
                        this.SetParametersDeliveryMode(deliveryMode), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return deliveryModeModel;
        }

        public DynamicParameters SetParametersDeliveryMode(DeliveryModeModel deliveryMode)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@DELIVERY_MODE", deliveryMode.DELIVERY_MODE);
            return parameters;
        }
        public List<DeliveryModeModel> GetDeliveryMode()
        {
            List<DeliveryModeModel> deliveryModes = new List<DeliveryModeModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<DeliveryModeModel>("SELECT * FROM TBL_DELIVERYMODE");
                    if (poModel.Count() > 0)
                    {
                        deliveryModes = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return deliveryModes;
        }
        public PaymentTermModel AddPaymentTerm(PaymentTermModel payment)
        {
            PaymentTermModel paymentTerm = new PaymentTermModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<PaymentTermModel>("SP_SETUP_INSERT_INTO_PAYMENT_TERM",
                        this.SetParametersPaymentTerm(payment), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return paymentTerm;
        }
        public DynamicParameters SetParametersPaymentTerm(PaymentTermModel payment)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PAYMENT_TERM", payment.PAYMENT_TERM);
            return parameters;
        }
        public List<PaymentTermModel> GetPaymentTerm()
        {
            List<PaymentTermModel> paymentTermList = new List<PaymentTermModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PaymentTermModel>("SELECT * FROM TBL_PAYMENT_TERM");
                    if (poModel.Count() > 0)
                    {
                        paymentTermList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return paymentTermList;
        }
        public List<CountryModel> GetCountry()
        {
            List<CountryModel> countryList = new List<CountryModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<CountryModel>("SELECT * FROM TBL_COUNTRY ORDER BY COUNTRY_NAME");
                    if (poModel.Count() > 0)
                    {
                        countryList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return countryList;
        }

        public CountryModel AddCountry(CountryModel country)
        {
            CountryModel countryModel = new CountryModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<CountryModel>("SP_SETUP_INSERT_INTO_COUNTRY",
                        this.SetParametersPaymentTerm(country), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return countryModel;
        }
        public CountryModel UpdateCountry(CountryModel country)
        {
            CountryModel countryModel = new CountryModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<CountryModel>("SP_SETUP_INSERT_INTO_COUNTRY",
                        this.SetParametersPaymentTerm(country), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return countryModel;
        }
        public DynamicParameters SetParametersPaymentTerm(CountryModel country)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@COUNTRY_ID", country.COUNTRY_ID);
            parameters.Add("@COUNTRY_NAME", country.COUNTRY_NAME);
            parameters.Add("@Operation_Type", country.Operation_Type);
            return parameters;
        }
        public List<PackagingInstructionModel> GetPackagingInstruction()
        {
            List<PackagingInstructionModel> instructionList = new List<PackagingInstructionModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PackagingInstructionModel>("SELECT * FROM TBL_PACKAGING_INSTRUCTION");
                    if (poModel.Count() > 0)
                    {
                        instructionList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return instructionList;
        }
        public PackagingInstructionModel AddPackagingInstruction(PackagingInstructionModel packagingIns)
        {
            PackagingInstructionModel packageInsModel = new PackagingInstructionModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<PackagingInstructionModel>("SP_SETUP_INSERT_INTO_PACKAGING_INSTRUCTION",
                        this.SetParametersPackagingIns(packagingIns), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return packageInsModel;
        }
        public DynamicParameters SetParametersPackagingIns(PackagingInstructionModel packIns)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PACKAGING_INSTRUCTION", packIns.PACKAGING_INSTRUCTION);
            return parameters;
        }
        public List<PurchaseTermsConditionsModel> GetPurchaseTermsConditions()
        {
            List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseTermsConditionsModel>("SELECT * FROM TBL_PURCHASE_TERM_CONDITIONS");
                    if (poModel.Count() > 0)
                    {
                        termsConditionList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return termsConditionList;
        }
        public List<PurchaseTermsConditionsModel> GetSalesTermsConditions()
        {
            List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseTermsConditionsModel>("SELECT ROW_NUMBER()OVER(ORDER BY SALES_TERMS_CONDITION_ID)SL, * FROM TBL_SALES_TERM_CONDITIONS TC " +
                                                                                   " INNER JOIN TBL_TERMS_CONDITION_TYPE T ON TC.TERMS_CONDITION_TYPE_ID = T.TERMS_CONDITION_TYPE_ID " +
                                                                                   " where POSITION = 1 AND ENABLE = 1");
                    if (poModel.Count() > 0)
                    {
                        termsConditionList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return termsConditionList;
        }
        public List<PurchaseTermsConditionsModel> GetSalesTermsConditionsForSalesOrder()
        {
            List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<PurchaseTermsConditionsModel>("SELECT * FROM TBL_SALES_TERM_CONDITIONS where POSITION=2 AND ENABLE=1");
                    if (poModel.Count() > 0)
                    {
                        termsConditionList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return termsConditionList;
        }

        public List<PurchaseTermsConditionsModel> GetSalesTermsConditionsBySearch(string searchParameter)
        {
            List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    string query = "SELECT * FROM TBL_SALES_TERM_CONDITIONS where TERMS_AND_CONDITIONS LIKE '%" + searchParameter + "%' AND ENABLE=1";
                    var poModel = connection.Query<PurchaseTermsConditionsModel>(query);
                    if (poModel.Count() > 0)
                    {
                        termsConditionList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return termsConditionList;
        }
        public PurchaseTermsConditionsModel AddTermsCondition(PurchaseTermsConditionsModel termsConditions)
        {
            PurchaseTermsConditionsModel terms_Condition = new PurchaseTermsConditionsModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<PurchaseTermsConditionsModel>("SP_SETUP_INSERT_INTO_TERMS_CONDITION",
                        this.SetParametersTermsConditions(termsConditions), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return terms_Condition;
        }
        public PurchaseTermsConditionsModel AddSalesTermsCondition(PurchaseTermsConditionsModel termsConditions)
        {
            PurchaseTermsConditionsModel terms_Condition = new PurchaseTermsConditionsModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<PurchaseTermsConditionsModel>("SP_SETUP_INSERT_INTO_SALES_TERMS_CONDITION",
                        this.SetParametersTermsConditions(termsConditions), commandType: CommandType.StoredProcedure);
                    terms_Condition.STATUS = true;
                }
            }
            catch (Exception EX)
            {
                terms_Condition.STATUS = false;
            }
            return terms_Condition;
        }
        public DynamicParameters SetParametersTermsConditions(PurchaseTermsConditionsModel termsCondition)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@POSITION", termsCondition.POSITION);
            parameters.Add("@TERMS_AND_CONDITIONS", termsCondition.TERMS_AND_CONDITIONS);
            parameters.Add("@TERMS_CONDITION_TYPE_ID", termsCondition.TERMS_CONDITION_TYPE_ID);
            return parameters;
        }

        public PurchaseTermsConditionsModel UpdateSalesTermsCondition(PurchaseTermsConditionsModel termsConditions)
        {
            PurchaseTermsConditionsModel terms_Condition = new PurchaseTermsConditionsModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<PurchaseTermsConditionsModel>("SP_SETUP_UPDATE_INTO_SALES_TERMS_CONDITION",
                        this.SetParametersTermsConditionsForUpdate(termsConditions), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return terms_Condition;
        }
        public DynamicParameters SetParametersTermsConditionsForUpdate(PurchaseTermsConditionsModel termsCondition)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SALES_TERMS_CONDITION_ID", termsCondition.SALES_TERMS_CONDITION_ID);
            parameters.Add("@TERMS_AND_CONDITIONS", termsCondition.TERMS_AND_CONDITIONS);
            return parameters;
        }
        public void DeletePlanAndWorkScheduleById(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM ProductCategory WHERE ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteSalesTermsConditions(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "UPDATE TBL_SALES_TERM_CONDITIONS SET ENABLE=0 WHERE SALES_TERMS_CONDITION_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<InCoTermModel> GetIncoTerm()
        {
            List<InCoTermModel> paymentTermList = new List<InCoTermModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<InCoTermModel>("SELECT * FROM TBL_INCOTERM");
                    if (poModel.Count() > 0)
                    {
                        paymentTermList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }

            return paymentTermList;
        }
        public InCoTermModel AddIncoterm(InCoTermModel incoterm)
        {
            InCoTermModel inCoTermModel = new InCoTermModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<InCoTermModel>("SP_SETUP_INSERT_INTO_INCOTERM",
                        this.SetParametersIncoterm(incoterm), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return inCoTermModel;
        }
        public DynamicParameters SetParametersIncoterm(InCoTermModel inCoTermModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@INCOTERM_NAME", inCoTermModel.INCOTERM_NAME);
            return parameters;
        }
        public List<ShipViaModel> GetShipVia()
        {
            List<ShipViaModel> shipViaList = new List<ShipViaModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ShipViaModel>("SELECT * FROM TBL_SHIPVIA");
                    if (poModel.Count() > 0)
                    {
                        shipViaList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return shipViaList;
        }
        public ShipViaModel AddShipVia(ShipViaModel shipVia)
        {
            ShipViaModel inCoTermModel = new ShipViaModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ShipViaModel>("SP_SETUP_INSERT_INTO_SHIP_VIA",
                        this.SetParametersIncoterm(shipVia), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return inCoTermModel;
        }
        public DynamicParameters SetParametersIncoterm(ShipViaModel shipVia)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SHIP_VIA_NAME", shipVia.SHIP_VIA_NAME);
            return parameters;
        }
        public List<ExpectedDeliveryDateModel> GetExpectedDeliveryDate()
        {
            List<ExpectedDeliveryDateModel> expectedList = new List<ExpectedDeliveryDateModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ExpectedDeliveryDateModel>("SELECT * FROM TBL_EXPECTED_DELIVERY_DATE");
                    if (poModel.Count() > 0)
                    {
                        expectedList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return expectedList;
        }
        public ExpectedDeliveryDateModel AddExpectedDeliveryDate(ExpectedDeliveryDateModel expecteddate)
        {
            ExpectedDeliveryDateModel inCoTermModel = new ExpectedDeliveryDateModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ExpectedDeliveryDateModel>("SP_SETUP_INSERT_INTO_EXPECTED_DELIVERY_DATE",
                        this.SetParametersExpectedDate(expecteddate), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return inCoTermModel;
        }
        public DynamicParameters SetParametersExpectedDate(ExpectedDeliveryDateModel expecteddate)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EXPECTED_DELIVERY_DATE", expecteddate.EXPECTED_DELIVERY_DATE);
            return parameters;
        }
        //public List<CurrencyModel> GetCurrency()
        //{
        //    List<CurrencyModel> currencyList = new List<CurrencyModel>();
        //    try
        //    {
        //        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
        //        {
        //            if (connection.State == ConnectionState.Closed) connection.Open();
        //            var poModel = connection.Query<CurrencyModel>("SELECT * FROM TBL_CURRENCY");
        //            if (poModel.Count() > 0)
        //            {
        //                currencyList = poModel.ToList();
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    return currencyList;
        //}


        public List<BrandModel> GetBrandList()
        {
            List<BrandModel> brandList = new List<BrandModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<BrandModel>("SELECT * FROM TBL_BRAND ORDER BY BRAND_NAME");
                    if (poModel.Count() > 0)
                    {
                        brandList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return brandList;
        }
        public List<ItemApplicationAreaModel> GetItemApplicationArea()
        {
            List<ItemApplicationAreaModel> applicationAreaList = new List<ItemApplicationAreaModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ItemApplicationAreaModel>("SELECT * FROM TBL_ITEM_APPLICATION_AREA ORDER BY APPLICATION_AREA");
                    if (poModel.Count() > 0)
                    {
                        applicationAreaList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return applicationAreaList;
        }
        public List<InventoryTypeModel> GetInventoryType()
        {
            List<InventoryTypeModel> applicationAreaList = new List<InventoryTypeModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<InventoryTypeModel>("SELECT * FROM TBL_INVENTORY_TYPE ORDER BY INVENTORY_TYPE");
                    if (poModel.Count() > 0)
                    {
                        applicationAreaList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return applicationAreaList;
        }

        public ItemApplicationAreaModel AddApplicationArea(ItemApplicationAreaModel applicationarea)
        {
            ItemApplicationAreaModel applicationAreaModel = new ItemApplicationAreaModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ItemApplicationAreaModel>("SP_SETUP_INSERT_INTO_ITEM_APPLICATION_AREA",
                        this.SetParametersApplicationArea(applicationarea), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return applicationAreaModel;
        }
        public ItemApplicationAreaModel UpdateApplicationArea(ItemApplicationAreaModel applicationarea)
        {
            ItemApplicationAreaModel applicationAreaModel = new ItemApplicationAreaModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ItemApplicationAreaModel>("SP_SETUP_INSERT_INTO_ITEM_APPLICATION_AREA",
                        this.SetParametersApplicationArea(applicationarea), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return applicationAreaModel;
        }
        public DynamicParameters SetParametersApplicationArea(ItemApplicationAreaModel applicationArea)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@APPLICATION_AREA_ID", applicationArea.APPLICATION_AREA_ID);
            parameters.Add("@APPLICATION_AREA", applicationArea.APPLICATION_AREA);
            parameters.Add("@OPERATION_TYPE", applicationArea.Operation_Type);
            return parameters;
        }
        public InventoryTypeModel AddInventoryType(InventoryTypeModel applicationarea)
        {
            InventoryTypeModel applicationAreaModel = new InventoryTypeModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<InventoryTypeModel>("SP_SETUP_INSERT_INTO_INVENTORY_TYPE",
                        this.SetParametersInventoryType(applicationarea), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return applicationAreaModel;
        }
        public InventoryTypeModel UpdateInventoryType(InventoryTypeModel applicationarea)
        {
            InventoryTypeModel applicationAreaModel = new InventoryTypeModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<InventoryTypeModel>("SP_SETUP_INSERT_INTO_INVENTORY_TYPE",
                        this.SetParametersInventoryType(applicationarea), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return applicationAreaModel;
        }
        public DynamicParameters SetParametersInventoryType(InventoryTypeModel applicationArea)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@INVENTORY_TYPE_ID", applicationArea.INVENTORY_TYPE_ID);
            parameters.Add("@INVENTORY_TYPE", applicationArea.INVENTORY_TYPE);
            parameters.Add("@Operation_Type", applicationArea.Operation_Type);
            return parameters;
        }
        public ServiceCategoryEntity AddServiceCategory(ServiceCategoryEntity SrvcCategory)
        {
            ServiceCategoryEntity inCoTermModel = new ServiceCategoryEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ServiceCategoryEntity>("SP_SETUP_INSERT_INTO_SERVICE_CATEGORY",
                        this.SetParametersInSrvc(SrvcCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return inCoTermModel;
        }
        public ServiceCategoryEntity UpdateServiceCategory(ServiceCategoryEntity SrvcCategory)
        {
            ServiceCategoryEntity inCoTermModel = new ServiceCategoryEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ServiceCategoryEntity>("SP_SETUP_UPDATE_SERVICE_CATEGORY",
                        this.SetParametersInSrvc(SrvcCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return inCoTermModel;
        }
        public DynamicParameters SetParametersInSrvc(ServiceCategoryEntity SrvcCategory)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SERVICE_CATEGORY_ID", SrvcCategory.SERVICE_CATEGORY_ID);
            parameters.Add("@SERVICE_CATEGORY_NAME", SrvcCategory.SERVICE_CATEGORY_NAME);
            return parameters;
        }
        public ServiceSubCategoryEntity AddServiceSubCategory(ServiceSubCategoryEntity SrvcCategory)
        {
            ServiceSubCategoryEntity inCoTermModel = new ServiceSubCategoryEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ServiceSubCategoryEntity>("SP_SETUP_INSERT_INTO_SERVICE_SUB_CATEGORY",
                        this.SetParametersInSrvc(SrvcCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return inCoTermModel;
        }
        public ServiceSubCategoryEntity UpdateServiceSubCategory(ServiceSubCategoryEntity SrvcCategory)
        {
            ServiceSubCategoryEntity inCoTermModel = new ServiceSubCategoryEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<ServiceSubCategoryEntity>("SP_SETUP_UPDATE_SERVICE_SUB_CATEGORY",
                        this.SetParametersInSrvc(SrvcCategory), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return inCoTermModel;
        }
        public DynamicParameters SetParametersInSrvc(ServiceSubCategoryEntity SrvcCategory)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SERVICE_SUB_CATEGORY_ID", SrvcCategory.SERVICE_SUB_CATEGORY_ID);
            parameters.Add("@SERVICE_SUB_CATEGORY_NAME", SrvcCategory.SERVICE_SUB_CATEGORY_NAME);
            return parameters;
        }
        public List<ServiceCategoryEntity> GetServiceCategoryList()
        {
            List<ServiceCategoryEntity> categoryList = new List<ServiceCategoryEntity>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<ServiceCategoryEntity>("SELECT * FROM TBL_SERVICE_CATEGORY ORDER BY SERVICE_CATEGORY_NAME");
                if (poModel.Count() > 0)
                {
                    categoryList = poModel.ToList();
                }
            }
            return categoryList;
        }
        public List<ServiceSubCategoryEntity> GetServiceSubCategoryList()
        {
            List<ServiceSubCategoryEntity> categoryList = new List<ServiceSubCategoryEntity>();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<ServiceSubCategoryEntity>("SELECT * FROM TBL_SERVICE_SUB_CATEGORY s inner join [dbo].[TBL_SERVICE_CATEGORY] c on s.SERVICE_CATEGORY_ID=c.SERVICE_CATEGORY_ID ORDER BY s.SERVICE_SUB_CATEGORY_NAME");
                if (poModel.Count() > 0)
                {
                    categoryList = poModel.ToList();
                }
            }
            return categoryList;
        }
        public void DeleteServiceCategory(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_SERVICE_CATEGORY WHERE SERVICE_CATEGORY_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteServiceSubCategory(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_SERVICE_SUB_CATEGORY WHERE SERVICE_SUB_CATEGORY_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal List<ServiceSubCategoryEntity> GetServiceSubCategoryWithCategory()
        {
            List<ServiceSubCategoryEntity> subcategoryList = new List<ServiceSubCategoryEntity>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ServiceSubCategoryEntity>("SELECT * FROM TBL_SERVICE_SUB_CATEGORY s INNER JOIN TBL_SERVICE_CATEGORY c on s.SERVICE_CATEGORY_ID=c.SERVICE_CATEGORY_ID ORDER BY s.SERVICE_SUB_CATEGORY_NAME");
                    if (poModel.Count() > 0)
                    {
                        subcategoryList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return subcategoryList;
        }
        public void DeleteService(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_ALL_SEMCORP_SERVICES WHERE SERVICE_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal List<ServiceEntity> GetServiceDetails()
        {
            List<ServiceEntity> subcategoryList = new List<ServiceEntity>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<ServiceEntity>("SELECT * FROM TBL_ALL_SEMCORP_SERVICES s JOIN TBL_SERVICE_SUB_CATEGORY c on s.SERVICE_SUB_CATEGORY_ID=c.SERVICE_SUB_CATEGORY_ID JOIN TBL_SERVICE_CATEGORY sc on sc.SERVICE_CATEGORY_ID=c.SERVICE_CATEGORY_ID");
                    if (poModel.Count() > 0)
                    {
                        subcategoryList = poModel.ToList();
                    }
                }
            }
            catch (Exception)
            {

            }
            return subcategoryList;
        }
    }
}
