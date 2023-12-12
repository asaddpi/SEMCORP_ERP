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
    public class CustomerService
    {
        protected readonly ApplicationDbContex _dbContext;
        public CustomerService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        internal List<CustomerModel> GetCustomerList()
        {
            List<CustomerModel> customerList = new List<CustomerModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customer = connection.Query<CustomerModel>("SELECT * FROM TBL_CUSTOMER");
                    if (customer != null && customer.Count() > 0)
                    {
                        customerList = customer.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return customerList;
        }
        internal List<CustomerModel> GetCustomerProjectList()
        {
            List<CustomerModel> customerList = new List<CustomerModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customer = connection.Query<CustomerModel>("Select * from [dbo].[TBL_CUSTOMER] C Inner join [dbo].[TBL_CUSTOMER_PROJECT] P on C.CUSTOMER_ID=P.CUSTOMER_ID");
                    if (customer != null && customer.Count() > 0)
                    {
                        customerList = customer.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return customerList;
        }
        internal List<CustomerProjectModel> GetAllCustomerProjectList()
        {
            List<CustomerProjectModel> customerList = new List<CustomerProjectModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customer = connection.Query<CustomerProjectModel>("Select * from [dbo].[TBL_CUSTOMER] C Inner join [dbo].[TBL_CUSTOMER_PROJECT] P on C.CUSTOMER_ID=P.CUSTOMER_ID");
                    if (customer != null && customer.Count() > 0)
                    {
                        customerList = customer.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return customerList;
        }

        internal CustomerProjectModel GetAllCustomerProjectListById(object projectId)
        {
            CustomerProjectModel customerProject = new CustomerProjectModel();
            try
            {
                var parameters = new DynamicParameters();                
                parameters.Add("@CUSTOMER_PROJECT_ID", projectId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customer = connection.Query<CustomerProjectModel>("SELECT * FROM TBL_CUSTOMER_PROJECT WHERE CUSTOMER_PROJECT_ID='"+projectId+"'");
                    if (customer != null && customer.Count() > 0)
                    {
                        customerProject = customer.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return customerProject;
        }

        internal List<string> GetWorkOrderNoList(int customerId, int projectId)
        {
            List<string> woNoList = new List<string>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_ID", customerId, DbType.Int32);
                parameters.Add("@CUSTOMER_PROJECT_ID", projectId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customer = connection.Query<string>("SP_GET_ALL_WORK_ORDER_NO_BY_CUSTOMERID_PROJECT_ID", parameters, commandType: CommandType.StoredProcedure);
                    if (customer != null && customer.Count() > 0)
                    {
                        woNoList = customer.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return woNoList;
        }
        internal List<CustomerViewModel> GetAllCustomers()
        {
            List<CustomerViewModel> customerList = new List<CustomerViewModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customer = connection.Query<CustomerViewModel>("SP_CUSTOMER_GET_ALL_CUSTOMER");
                    if (customer != null && customer.Count() > 0)
                    {
                        customerList = customer.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return customerList;
        }
        internal List<CustomerAccountReportModel> GetCustomerAccountData(string CustomerId)
        {
            List<CustomerAccountReportModel> customerList = new List<CustomerAccountReportModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_ID", CustomerId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();                    
                    var customer = connection.Query<CustomerAccountReportModel>("SP_CUSTOMER_ACCOUNT_BKP_3", parameters, commandType: CommandType.StoredProcedure);
                    if (customer != null && customer.Count() > 0)
                    {
                        customerList = customer.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return customerList;
        }



        internal CustomerModel AddCustomer(CustomerModel item)
        {
            CustomerModel _oItem = new CustomerModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<CustomerModel>("SP_CUSTOMER_INSERT_CUSTOMER",
                            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }


            return _oItem;
        }
        internal CustomerModel UpdateCustomer(CustomerModel item)
        {
            CustomerModel _oItem = new CustomerModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<CustomerModel>("SP_CUSTOMER_UPDATE_CUSTOMER",
                            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }


            return _oItem;
        }
        public DynamicParameters SetParameters(CustomerModel customer)
        {
            DynamicParameters parameters = new DynamicParameters();
            
            parameters.Add("@CUSTOMER_CODE", customer.CUSTOMER_CODE);
            parameters.Add("@CUSTOMER_NAME", customer.CUSTOMER_NAME);
            parameters.Add("@CUSTOMER_NAME_SHORT_FORM", customer.CUSTOMER_NAME_SHORT_FORM);
            parameters.Add("@CORPORATE_ADDRESS", customer.CORPORATE_ADDRESS);
            parameters.Add("@SHIPPING_ADDRESS", customer.SHIPPING_ADDRESS);
            parameters.Add("@CUSTOMER_TYPE_ID", customer.CUSTOMER_TYPE_ID);
            parameters.Add("@CONTACT_PERSON_NAME", customer.CONTACT_PERSON_NAME);
            parameters.Add("@CONTACT_PERSON_PHONE", customer.CONTACT_PERSON_PHONE);
            parameters.Add("@CONTACT_PERSON_EMAIL", customer.CONTACT_PERSON_EMAIL);
            parameters.Add("@CONTACT_PERSON_DESIGNATION", customer.CONTACT_PERSON_DESIGNATION);


            return parameters;
        }
        internal CustomerProjectModel AddCustomerProject(CustomerProjectModel customerProject)
        {
            CustomerProjectModel _opurchaseRequisitionDetails = new CustomerProjectModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<CustomerProjectModel>("SP_CUSTOMER_INSERT_CUSTOMER_PROJECT",
                        this.SetParametersCustomerProject(customerProject), commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }
        internal List<CustomerProjectModel> UpdateCustomerProject(List<CustomerProjectModel> customerProject)
        {
            List<CustomerProjectModel> _opurchaseRequisitionDetails = new List<CustomerProjectModel>();
            try
            {
                if (customerProject.Count > 0)
                {
                    foreach (var project in customerProject)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            if(project.CUSTOMER_PROJECT_ID!=0)
                            {
                                var _oproductcategory = connection.Query<CustomerProjectModel>("SP_CUSTOMER_UPDATE_CUSTOMER_PROJECT",
                                this.SetParametersCustomerProject(project), commandType: CommandType.StoredProcedure);
                            }
                            else
                            {
                                var _oproductcategory = connection.Query<CustomerProjectModel>("SP_CUSTOMER_INSERT_CUSTOMER_PROJECT",
                               this.SetParametersCustomerProject(project), commandType: CommandType.StoredProcedure);
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
        public DynamicParameters SetParametersCustomerProject(CustomerProjectModel project)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CUSTOMER_ID", project.CUSTOMER_ID);
            parameters.Add("@CUSTOMER_PROJECT_ID", project.CUSTOMER_PROJECT_ID);
            parameters.Add("@SHIPPING_PROJECT_NAME", project.SHIPPING_PROJECT_NAME);
            parameters.Add("@PROJECT_NAME_SHORT_FORM", project.PROJECT_NAME_SHORT_FORM);
            parameters.Add("@PROJECT_ADDRESS", project.PROJECT_ADDRESS);
            parameters.Add("@PROJECT_CONTACT_PERSON_NAME", project.PROJECT_CONTACT_PERSON_NAME);
            parameters.Add("@PROJECT_CONTACT_PERSON_PHONE", project.PROJECT_CONTACT_PERSON_PHONE);
            parameters.Add("@PROJECT_CONTACT_PERSON_EMAIL", project.PROJECT_CONTACT_PERSON_EMAIL);
            parameters.Add("@OPERATION_TYPE", project.OPERATION_TYPE);
            

            return parameters;
        }

        internal List<CustomerContactModel> AddCustomerContact(List<CustomerContactModel> customercontact)
        {
            List<CustomerContactModel> _opurchaseRequisitionDetails = new List<CustomerContactModel>();
            try
            {
                if (customercontact.Count > 0)
                {
                    foreach (var contact in customercontact)
                    {
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {
                            if (connection.State == ConnectionState.Closed) connection.Open();
                            var _oproductcategory = connection.Query<CustomerContactModel>("SP_CUSTOMER_INSERT_INTO_CUSTOMER_CONTACT_LIST",
                                this.SetParametersCustomerContact(contact), commandType: CommandType.StoredProcedure);
                        }
                    }
                }

            }
            catch (Exception EX)
            {

            }
            return _opurchaseRequisitionDetails;
        }
        internal List<CustomerContactModel> UpdateCustomerContact(List<CustomerContactModel> customercontact)
        {
            List<CustomerContactModel> _opurchaseRequisitionDetails = new List<CustomerContactModel>();
            try
            {
                if (customercontact.Count > 0)
                {
                    foreach (var contact in customercontact)
                    {
                        
                        using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                        {

                            bool isExist = false;
                            IDataReader dr = null;
                            dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, "Select CUSTOMER_CONTACT_ID From TBL_CUSTOMER_CONTACT_LIST WHERE CUSTOMER_CONTACT_ID=" + contact.CUSTOMER_CONTACT_ID+ "");
                            while(dr.Read())
                            {
                                isExist = true;
                            }
                            if(isExist==true)
                            {
                                if (connection.State == ConnectionState.Closed) connection.Open();
                                var _oproductcategory = connection.Query<CustomerContactModel>("SP_CUSTOMER_UPDATE_INTO_CUSTOMER_CONTACT_LIST",
                                    this.SetParametersCustomerContact(contact), commandType: CommandType.StoredProcedure);
                            }
                            else if(isExist==false)
                            {
                                if (connection.State == ConnectionState.Closed) connection.Open();
                                var _oproductcategory = connection.Query<CustomerContactModel>("SP_CUSTOMER_INSERT_INTO_CUSTOMER_CONTACT_LIST",
                                    this.SetParametersCustomerContact(contact), commandType: CommandType.StoredProcedure);
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
        public DynamicParameters SetParametersCustomerContact(CustomerContactModel contact)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CUSTOMER_VENDOR_CODE", contact.CUSTOMER_VENDOR_CODE);
            parameters.Add("@CUSTOMER_CONTACT_ID", contact.CUSTOMER_CONTACT_ID);
            parameters.Add("@NAME", contact.NAME);
            parameters.Add("@DESIGNATION", contact.DESIGNATION);
            parameters.Add("@DEPARTMENT_NAME", contact.DEPARTMENT_NAME);
            parameters.Add("@MOBILE", contact.MOBILE);
            parameters.Add("@EMAIL", contact.EMAIL);
            parameters.Add("@WECHAT", contact.WECHAT);
            parameters.Add("@WHATSAPP", contact.WHATSAPP);
            parameters.Add("@TYPE", contact.TYPE);


            return parameters;
        }
        internal List<CustomerTypeModel> GetCustomerType()
        {
            List<CustomerTypeModel> customerTypeList = new List<CustomerTypeModel>();
            try
            {
                using(IDbConnection connection=new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customerType = connection.Query<CustomerTypeModel>("SELECT * FROM TBL_CUSTOMER_TYPE");
                    if(customerType!=null && customerType.Count()>0)
                    {
                        customerTypeList = customerType.ToList();
                    }
                }
            }
            catch(Exception ex)
            {
                
            }

            return customerTypeList;
        }
        internal CustomerModel GetCustomerData(int customerId)
        {
            CustomerModel customer = new CustomerModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_ID", customerId, DbType.Int32);
                using (IDbConnection connection=new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();                    
                    var Customer = connection.Query<CustomerModel>("SP_CUSTOMER_GET_CUSTOMER_DATA", parameters, commandType: CommandType.StoredProcedure);
                    if(Customer !=null && Customer.Count()>0)
                    {
                        customer = Customer.FirstOrDefault();
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return customer;
        }
        internal List<CustomerContactModel> GetCustomerContactList(string customerId)
        {
            List<CustomerContactModel> customercontactList = new List<CustomerContactModel>();
            try
            {
                DataSet ds = new DataSet();
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_ID", customerId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var Customercontact = connection.Query<CustomerContactModel>("SELECT * FROM TBL_CUSTOMER_CONTACT_LIST  WHERE CUSTOMER_VENDOR_CODE='" + customerId + "'");
                    
                    if (Customercontact != null && Customercontact.Count() > 0)
                    {
                        customercontactList = Customercontact.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return customercontactList;
        }
        internal List<CustomerProjectModel> GetCustomerProjectList(int customerId)
        {
            List<CustomerProjectModel> customerprojectList = new List<CustomerProjectModel>();
            try
            {
                DataSet ds = new DataSet();
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_ID", customerId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var Customerproject = connection.Query<CustomerProjectModel>("SELECT * FROM TBL_CUSTOMER_PROJECT WHERE CUSTOMER_ID=" + customerId + "");

                    if (Customerproject != null && Customerproject.Count() > 0)
                    {
                        customerprojectList = Customerproject.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return customerprojectList;
        }

        internal CustomerViewModel GetCustomerById(string customerId)
        {
            CustomerViewModel customerView = new CustomerViewModel();
            try
            {                
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_ID", customerId, DbType.Int32);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var Customerproject = connection.Query<CustomerViewModel>("Select * From TBL_CUSTOMER Where CUSTOMER_ID="+ customerId +" ");

                    if (Customerproject != null && Customerproject.Count() > 0)
                    {
                        customerView = Customerproject.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return customerView;
        }
        internal string GetCustomerCode(string code)
        {
            string customerCode = "";
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CODE", code, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var _obJournal = connection.Query<string>("SP_SEQUENCE_GET_CUSTOMER_CODE", parameters, commandType: CommandType.StoredProcedure);
                    
                    if (_obJournal != null && _obJournal.Count() > 0)
                    {
                        customerCode = _obJournal.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return customerCode;
        }
        internal int GetPurchaseOrderId(string customerCode)
        {
            int customerId = 0;
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var POID = connection.Query<int>("SELECT CUSTOMER_ID FROM TBL_CUSTOMER WHERE CUSTOMER_CODE='" + customerCode + "'");
                    if (POID != null && POID.Count() > 0)
                    {
                        customerId = POID.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return customerId;
        }
        public void DeleteCustomerContact(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Global.ConnectionString, CommandType.Text, "DELETE FROM TBL_CUSTOMER_CONTACT_LIST WHERE CUSTOMER_CONTACT_ID=" + id + "");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public double GetCustomerReceiveableBalance(string pono)
        {
            double balance = 0;
            var parameters = new DynamicParameters();
            parameters.Add("@SO_NO", pono, DbType.String);
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<double>("SP_GET_CUSTOMER_RECEIVE_BALANCE", parameters, commandType: CommandType.StoredProcedure);
                if (poModel.Count() > 0)
                {
                    balance = poModel.FirstOrDefault();
                }
            }
            return balance;
        }
        internal CustomerPaymentViewModel AddCustomerPayment(CustomerPaymentViewModel vendorPayment)
        {
            CustomerPaymentViewModel payment = new CustomerPaymentViewModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<CustomerPaymentViewModel>("SP_CUSTOMER_ADD_CUSTOMER_PAYMENT",
                        this.SetParametersVPayment(vendorPayment), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return payment;
        }
        public DynamicParameters SetParametersVPayment(CustomerPaymentViewModel payment)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@CUSTOMER_ID", payment.CUSTOMER_ID);
            parameters.Add("@SALES_ID", payment.SALES_ID);
            parameters.Add("@SALES_ORDER_NO", payment.SALES_ORDER_NO);
            parameters.Add("@PAYMENT_DATE", payment.PAYMENT_DATE);
            parameters.Add("@TYPE_OF_PAYMENT", payment.TYPE_OF_PAYMENT);
            parameters.Add("@CHEQUE_NO", payment.CHEQUE_NO);
            parameters.Add("@CHEQUE_DATE", payment.CHEQUE_DATE);
            parameters.Add("@BANK_ID", payment.BANK_ID);
            parameters.Add("@BANK_BRANCH_ID", payment.BANK_BRANCH_ID);
            parameters.Add("@PAYMENT_AMOUNT", payment.PAYMENT_AMOUNT);
            parameters.Add("@AMOUNT_PAID", payment.AMOUNT_PAID);
            parameters.Add("@AMOUNT_DUE", payment.AMOUNT_DUE);
            parameters.Add("@OPENING_BALANCE", payment.OPENING_BALANCE);
            parameters.Add("@CURRENT_BALANCE", payment.CURRENT_BALANCE);
            parameters.Add("@MONEY_RECEIPT_NO", payment.MONEY_RECEIPT_NO);
            parameters.Add("@NEXT_PAYMENT_DATE", payment.NEXT_PAYMENT_DATE);
            parameters.Add("@REMARKS", payment.REMARKS);
            parameters.Add("@INVOICE_BREAKDOWN_AMOUNT", payment.INVOICE_BREAKDOWN_AMOUNT);
            parameters.Add("@TOTAL_INVOICE_AMOUNT", payment.TOTAL_INVOICE_AMOUNT);
            parameters.Add("@PAYMENT_STATUS", payment.PAYMENT_STATUS);
            parameters.Add("@REG_BY", payment.REG_BY);




            return parameters;
        }

    }
}
