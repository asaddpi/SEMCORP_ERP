using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class Acc_TransectionModel
    {
        public int TRANSACTION_ID { get; set; }
        public int DOCUMENT_ID { get; set; }
        
        public string DESCRIPTION { get; set; }
        public string BILL_NO { get; set; }
    }
}
