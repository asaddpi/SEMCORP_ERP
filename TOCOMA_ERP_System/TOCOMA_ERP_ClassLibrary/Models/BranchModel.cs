using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class BranchModel
    {
        public string BRANCH_ID { get; set; }
        public int BANK_ID { get; set; }
        public string BRANCH_SERIAL { get; set; }
        public string BRANCH_NAME { get; set; }
        public string BRANCH_NAME_DEFAULT { get; set; }
        public string BRANCH_ADD1 { get; set; }
        public string BRANCH_ADD2 { get; set; }
        public string BRANCH_COUNTRY { get; set; }
        public string BRANCH_COMMENTS { get; set; }
        public int BRANCH_ACTIVE { get; set; }
        public int BRANCH_STATUS { get; set; }
        public int BRANCH_TYPE { get; set; }
        public int BRANCH_FLAG { get; set; }
        public string BRANCH_PHONE { get; set; }
        public string BRANCH_FAX { get; set; }

        [EmailAddress(ErrorMessage = "Please Input Valid Email Address")]
        public string BRANCH_EMAIL { get; set; }
        public string ENTRYBY { get; set; }
        public string UPDATEBY { get; set; }
        
    }
}
