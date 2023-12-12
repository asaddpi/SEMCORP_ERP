using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class BankBranchModel
    {
        public int BANK_BRANCH_ID { get; set; }
        public string BRANCH_CODE { get; set; }
        public int BANK_ID { get; set; }
        public string BANK_NAME { get; set; }
        public string BRANCH_NAME { get; set; }
        public string BRANCH_ADDRESS { get; set; }
        public string ROUTING_NUMBER { get; set; }
        public string SWIFT_CODE { get; set; }
        public string POSTAL_CODE { get; set; }
        public string BRANCH_PHONE { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_PERSON_DESIGNATION { get; set; }
        public string CONTACT_PERSON_MOBILE { get; set; }
        public string CONTACT_PERSON_EMAIL { get; set; }
        public string BRANCH_EMAIL { get; set; }
        public int Operation_Type { get; set; }
    }
}
