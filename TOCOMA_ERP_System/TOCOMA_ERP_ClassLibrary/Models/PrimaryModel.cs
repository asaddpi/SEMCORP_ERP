using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PrimaryModel
    {
        public int PRIMARY_ID { get; set; }
        public string PRIMARY_NAME { get; set; }

        public List<LedgerGroupModel> ledgerGroupCurrentAssetsList { get; set; }
        public List<LedgerGroupModel> ledgerGroupFixedList { get; set; }
        public List<LedgerGroupModel> ledgerGroupLiabilitiesList { get; set; }
        public List<LedgerGroupModel> ledgerGroupIncomeList { get; set; }
    }
}
