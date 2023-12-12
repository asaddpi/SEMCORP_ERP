using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class VendorEntity
    {
        public int VENDOR_ID { get; set; }
        public string VENDOR_CODE { get; set; }
        public string VENDOR_NAME { get; set; }
        public string REGISTERED_ADDRESS { get; set; }
        public string FACTORY_ADDRESS { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_PERSON_DESIGNATION { get; set; }
        public string CONTACT_NO { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string NAME_SALES { get; set; }
        public string PHONE_SALES { get; set; }
        public string EMAIL_SALES { get; set; }
        public string NAME_TECHNICAL_SUPPORT { get; set; }
        public string PHONE_TECHNICAL_SUPPORT { get; set; }
        public string EMAIL_TECHNICAL_SUPPORT { get; set; }
        public string NAME_FINANCE { get; set; }
        public string PHONE_FINANCE { get; set; }
        public string EMAIL_FINANCE { get; set; }
        public string NAME_OTHERS1 { get; set; }
        public string PHONE_OTHERS1 { get; set; }
        public string EMAIL_OTHERS1 { get; set; }
        public string NAME_OTHERS2 { get; set; }
        public string PHONE_OTHERS2 { get; set; }
        public string EMAIL_OTHERS2 { get; set; }

        //[StringLength(10, MinimumLength = 10, ErrorMessage = "field must be atleast 10 characters")]
        public string YEAR_OF_INCORPORATION { get; set; }
        public string NATURE_OF_BUSINESS { get; set; }
        public string MODE_OF_COMPANY { get; set; }
        public string TYPE_OF_BUSINESS { get; set; }
        public string TYPE_OF_SUPPLY { get; set; }
        public string TYPE_OF_PAYMENTS { get; set; }
        public double ANNUAL_TURNOVER { get; set; }
        public string DIRECTORS1 { get; set; }
        public string DIRECTORS2 { get; set; }
        public string DIRECTORS3 { get; set; }
        public string DIRECTORS4 { get; set; }
        public string DIRECTORS5 { get; set; }
        public string DIRECTORS6 { get; set; }
        public string VENDOR_CLIENT_1 { get; set; }
        public string VENDOR_CLIENT_2 { get; set; }
        public string VENDOR_CLIENT_3 { get; set; }
        public string VENDOR_CLIENT_4 { get; set; }
        public string VENDOR_CLIENT_5 { get; set; }
        public string VENDOR_CLIENT_6 { get; set; }
        public string VENDOR_CLIENT_ID { get; set; }
        public string BANK_OPERATING_COUNTRY { get; set; }
        public string BANK_KEY_ROUTING_NUMBER { get; set; }
        public int BANK_ID { get; set; }
        public int BANK_BRANCH_ID { get; set; }
        public string BRANCH_ADDRESS { get; set; }
        public string POSTAL_CODE { get; set; }
        public string SWIFT_CODE { get; set; }
        public string ACCOUNT_NUMBER { get; set; }        
        public string ACCOUNT_CURRENCY { get; set; }
        public string BENIFICIARY_NAME { get; set; }
        public string CREDIT_PERIOD { get; set; }
        public double CREDIT_LIMIT { get; set; }
        public string INCORPORATION_CERTIFICATE_STATUS { get; set; }
        public string INCORPORATION_CERTIFICATE_NUMBER { get; set; }
        public string COMPANY_PROFILE_BROCHUR_STATUS { get; set; }
        public string COMPANY_PROFILE_BROCHUR_NUMBER { get; set; }
        public string TRADE_LICENSE_STATUS { get; set; }
        public string TRADE_LICENSE_NUMBER { get; set; }
        public string TIN_CERTIFICATE_STATUS { get; set; }
        public string TIN_CERTIFICATE_NUMBER { get; set; }
        public string VAT_REGISTRATION_CERTIFICATE_STATUS { get; set; }
        public string VAT_REGISTRATION_CERTIFICATE_NUMBER { get; set; }
        public string ENVIRONMENT_CLEARANCE_CERTIFICATE_STATUS { get; set; }
        public string ENVIRONMENT_CLEARANCE_CERTIFICATE_NUMBER { get; set; }
        public string VENDOR_DECLARATION { get; set; }
        public string VENDOR_TYPE_STATUS { get; set; }
        public string REG_BY { get; set; }
       
    }
}
