using Dapper;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;


namespace TOCOMA_API_Service.Service
{
    public class VendorService
    {
        protected readonly ApplicationDbContex _dbContext;
        public VendorService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        VendorEntity vendor = new VendorEntity();
        internal VendorEntity AddVendor(VendorEntity vendorEntity)
        {
            vendor = new VendorEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<VendorEntity>("SP_VENDOR_INSERT_VENDOR_DETAILS",
                        this.SetParameters(vendorEntity), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return vendor;
        }
        internal VendorEntity UpdateVendor(VendorEntity vendorEntity)
        {
            vendor = new VendorEntity();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<VendorEntity>("SP_VENDOR_UPDATE_VENDOR_DETAILS",
                        this.SetParameters(vendorEntity), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return vendor;
        }
        internal VendorPaymentModel AddVendorPayment(VendorPaymentModel vendorPayment)
        {
            VendorPaymentModel payment = new VendorPaymentModel ();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<VendorPaymentModel>("SP_VENDOR_ADD_VENDOR_PAYMENT",
                        this.SetParametersVPayment(vendorPayment), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return payment;
        }
        public DynamicParameters SetParametersVPayment(VendorPaymentModel payment)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@VENDOR_ID", payment.VENDOR_ID);
            parameters.Add("@PO_ID", payment.PO_ID);
            parameters.Add("@PO_NUMBER_LONG_CODE", payment.PO_NUMBER_LONG_CODE);
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

        internal List<VendorEntity> GetVendorList()
        {
            List<VendorEntity> vendorList = new List<VendorEntity>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var vendor = connection.Query<VendorEntity>("SELECT * FROM TBL_VENDOR_REGISTRATION");
                    if (vendor.Count() > 0)
                    {
                        vendorList = vendor.ToList();
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return vendorList;
        }
        internal VendorEntity GetVendorByVendorCode(string vendorcode)
        {
            VendorEntity vendor = new VendorEntity();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@VENDOR_CODE", vendorcode, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var vendor_details = connection.Query<VendorEntity>("SP_VENDOR_GET_VENDOR_INFO_BY_VENDOR_CODE", parameters, commandType: CommandType.StoredProcedure);
                    
                    if (vendor_details.Count() > 0)
                    {
                        vendor = vendor_details.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return vendor;
        }

        public DynamicParameters SetParameters(VendorEntity vendorModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            
            parameters.Add("@VENDOR_ID", vendorModel.VENDOR_ID);
            parameters.Add("@VENDOR_CODE", vendorModel.VENDOR_CODE);
            parameters.Add("@VENDOR_NAME", vendorModel.VENDOR_NAME);
            parameters.Add("@REGISTERED_ADDRESS", vendorModel.REGISTERED_ADDRESS);
            parameters.Add("@FACTORY_ADDRESS", vendorModel.FACTORY_ADDRESS);
            parameters.Add("@CONTACT_PERSON_NAME", vendorModel.CONTACT_PERSON_NAME);
            parameters.Add("@CONTACT_PERSON_DESIGNATION", vendorModel.CONTACT_PERSON_DESIGNATION);
            parameters.Add("@CONTACT_NO", vendorModel.CONTACT_NO);
            parameters.Add("@EMAIL", vendorModel.EMAIL);
            parameters.Add("@FAX", vendorModel.FAX);
            parameters.Add("@NAME_SALES", vendorModel.NAME_SALES);
            parameters.Add("@PHONE_SALES", vendorModel.PHONE_SALES);
            parameters.Add("@EMAIL_SALES", vendorModel.EMAIL_SALES);
            parameters.Add("@NAME_TECHNICAL_SUPPORT", vendorModel.NAME_TECHNICAL_SUPPORT);
            parameters.Add("@PHONE_TECHNICAL_SUPPORT", vendorModel.PHONE_TECHNICAL_SUPPORT);
            parameters.Add("@EMAIL_TECHNICAL_SUPPORT", vendorModel.EMAIL_TECHNICAL_SUPPORT);
            parameters.Add("@NAME_FINANCE", vendorModel.NAME_FINANCE);
            parameters.Add("@PHONE_FINANCE", vendorModel.PHONE_FINANCE);
            parameters.Add("@EMAIL_FINANCE", vendorModel.EMAIL_FINANCE);
            parameters.Add("@NAME_OTHERS1", vendorModel.NAME_OTHERS1);
            parameters.Add("@PHONE_OTHERS1", vendorModel.PHONE_OTHERS1);
            parameters.Add("@EMAIL_OTHERS1", vendorModel.EMAIL_OTHERS1);
            parameters.Add("@NAME_OTHERS2", vendorModel.NAME_OTHERS2);
            parameters.Add("@PHONE_OTHERS2", vendorModel.PHONE_OTHERS2);
            parameters.Add("@EMAIL_OTHERS2", vendorModel.EMAIL_OTHERS2);
            parameters.Add("@YEAR_OF_INCORPORATION", vendorModel.YEAR_OF_INCORPORATION);
            parameters.Add("@NATURE_OF_BUSINESS", vendorModel.NATURE_OF_BUSINESS);
            parameters.Add("@MODE_OF_COMPANY", vendorModel.MODE_OF_COMPANY);
            parameters.Add("@TYPE_OF_BUSINESS", vendorModel.TYPE_OF_BUSINESS);
            parameters.Add("@TYPE_OF_SUPPLY", vendorModel.TYPE_OF_SUPPLY);
            parameters.Add("@TYPE_OF_PAYMENTS", vendorModel.TYPE_OF_PAYMENTS);
            parameters.Add("@ANNUAL_TURNOVER", vendorModel.ANNUAL_TURNOVER);
            parameters.Add("@DIRECTORS1", vendorModel.DIRECTORS1);
            parameters.Add("@DIRECTORS2", vendorModel.DIRECTORS2);
            parameters.Add("@DIRECTORS3", vendorModel.DIRECTORS3);
            parameters.Add("@DIRECTORS4", vendorModel.DIRECTORS4);
            parameters.Add("@DIRECTORS5", vendorModel.DIRECTORS5);
            parameters.Add("@DIRECTORS6", vendorModel.DIRECTORS6);
            parameters.Add("@VENDOR_CLIENT_1", vendorModel.VENDOR_CLIENT_1);
            parameters.Add("@VENDOR_CLIENT_2", vendorModel.VENDOR_CLIENT_2);
            parameters.Add("@VENDOR_CLIENT_3", vendorModel.VENDOR_CLIENT_3);
            parameters.Add("@VENDOR_CLIENT_4", vendorModel.VENDOR_CLIENT_4);
            parameters.Add("@VENDOR_CLIENT_5", vendorModel.VENDOR_CLIENT_5);
            parameters.Add("@VENDOR_CLIENT_6", vendorModel.VENDOR_CLIENT_6);
            parameters.Add("@BANK_OPERATING_COUNTRY", vendorModel.BANK_OPERATING_COUNTRY);
            parameters.Add("@BANK_KEY_ROUTING_NUMBER", vendorModel.BANK_KEY_ROUTING_NUMBER);
            parameters.Add("@BANK_ID", vendorModel.BANK_ID);
            parameters.Add("@BANK_BRANCH_ID", vendorModel.BANK_BRANCH_ID);
            parameters.Add("@BRANCH_ADDRESS", vendorModel.BRANCH_ADDRESS);
            parameters.Add("@POSTAL_CODE", vendorModel.POSTAL_CODE);
            parameters.Add("@SWIFT_CODE", vendorModel.SWIFT_CODE);
            parameters.Add("@ACCOUNT_NUMBER", vendorModel.ACCOUNT_NUMBER);
            parameters.Add("@ACCOUNT_CURRENCY", vendorModel.ACCOUNT_CURRENCY);
            parameters.Add("@BENIFICIARY_NAME", vendorModel.BENIFICIARY_NAME);
            parameters.Add("@CREDIT_PERIOD", vendorModel.CREDIT_PERIOD);
            parameters.Add("@CREDIT_LIMIT", vendorModel.CREDIT_LIMIT);
            parameters.Add("@INCORPORATION_CERTIFICATE_STATUS", vendorModel.INCORPORATION_CERTIFICATE_STATUS);
            parameters.Add("@INCORPORATION_CERTIFICATE_NUMBER", vendorModel.INCORPORATION_CERTIFICATE_NUMBER);
            parameters.Add("@COMPANY_PROFILE_BROCHUR_STATUS", vendorModel.COMPANY_PROFILE_BROCHUR_STATUS);
            parameters.Add("@COMPANY_PROFILE_BROCHUR_NUMBER", vendorModel.COMPANY_PROFILE_BROCHUR_NUMBER);
            parameters.Add("@TRADE_LICENSE_STATUS", vendorModel.TRADE_LICENSE_STATUS);
            parameters.Add("@TRADE_LICENSE_NUMBER", vendorModel.TRADE_LICENSE_NUMBER);
            parameters.Add("@TIN_CERTIFICATE_STATUS", vendorModel.TIN_CERTIFICATE_STATUS);
            parameters.Add("@TIN_CERTIFICATE_NUMBER", vendorModel.TIN_CERTIFICATE_NUMBER);
            parameters.Add("@VAT_REGISTRATION_CERTIFICATE_STATUS", vendorModel.VAT_REGISTRATION_CERTIFICATE_STATUS);
            parameters.Add("@VAT_REGISTRATION_CERTIFICATE_NUMBER", vendorModel.VAT_REGISTRATION_CERTIFICATE_NUMBER);
            parameters.Add("@ENVIRONMENT_CLEARANCE_CERTIFICATE_STATUS", vendorModel.ENVIRONMENT_CLEARANCE_CERTIFICATE_STATUS);
            parameters.Add("@ENVIRONMENT_CLEARANCE_CERTIFICATE_NUMBER", vendorModel.ENVIRONMENT_CLEARANCE_CERTIFICATE_NUMBER);
            parameters.Add("@VENDOR_DECLARATION", vendorModel.VENDOR_DECLARATION);
            parameters.Add("@VENDOR_TYPE_STATUS", vendorModel.VENDOR_TYPE_STATUS);
            parameters.Add("@REG_BY", vendorModel.REG_BY);


            return parameters;
        }
        internal List<VendorAccountViewModel> GetVendorAccountInfo(string vendorId)
        {
            List<VendorAccountViewModel> vendorAccountDataList = new List<VendorAccountViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@VENDOR_ID", vendorId, DbType.String);               
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<VendorAccountViewModel>("SP_VENDOR_CREATE_SUPPLIER_ACCOUNT", parameters, commandType: CommandType.StoredProcedure);
                    if (poModel.Count() > 0)
                    {
                        vendorAccountDataList = poModel.ToList();
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return vendorAccountDataList;
        }
        internal List<VendorPaymentViewModel> GetVendorPaymentBYDate(DateTime date1, DateTime date2)
        {
            List<VendorPaymentViewModel> purchaseOrderDetailsList = new List<VendorPaymentViewModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PO_DATE_FROM", date1, DbType.DateTime);
                parameters.Add("@PO_DATE_TO", date2, DbType.DateTime);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var poModel = connection.Query<VendorPaymentViewModel>("SP_VENDOR_VENDOR_PAYMENT_STATEMENT", parameters, commandType: CommandType.StoredProcedure);
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
        public double GetSupplierOutStandingBalance(string pono)
        {
            double balance = 0;
            var parameters = new DynamicParameters();
            parameters.Add("@PO_NO", pono, DbType.String);
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var poModel = connection.Query<double>("SP_GET_VENDOR_OUTSTANDING_BALANCE", parameters, commandType: CommandType.StoredProcedure);
                if (poModel.Count() > 0)
                {
                    balance = poModel.FirstOrDefault();
                }
            }
            return balance;
        }
        internal List<CustomerContactModel> GetVendorContactDetailsCode(string vendorcode)
        {
            List<CustomerContactModel> contactList = new List<CustomerContactModel>();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CUSTOMER_VENDOR_CODE", vendorcode, DbType.String);
                parameters.Add("@TYPE", "V", DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var VendorcontactList = connection.Query<CustomerContactModel>("SP_VENDOR_GET_VENDOR_CONTACT_LIST", parameters, commandType: CommandType.StoredProcedure);

                    if (VendorcontactList.Count() > 0)
                    {
                        contactList = VendorcontactList.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return contactList;
        }
        public void DeleteVendorContact(int id)
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

    }
}
