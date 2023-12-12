using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class Acc_GeneralJournalModel
    {
        public string Date { get; set; }
        public string DescriptionOrAccountTitle { get; set; }
        public string AmountDebit { get; set; }
        public string AmountCredit { get; set; }
    }
}
