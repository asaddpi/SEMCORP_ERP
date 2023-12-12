using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class TermsConditionTypeEntity
    {
        public int TERMS_CONDITION_TYPE_ID { get; set; }
        public string TERMS_CONDITION_TYPE { get; set; }
        public int OPERATION_TYPE { get; set; }
        public int POSITION { get; set; }
        public List<PurchaseTermsConditionsModel> TermsConditionList { get; set; }
    }
}
