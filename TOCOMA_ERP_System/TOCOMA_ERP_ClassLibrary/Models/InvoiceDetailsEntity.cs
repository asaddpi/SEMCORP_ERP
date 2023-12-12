using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class InvoiceDetailsEntity
    {
      public int INVOICE_DETAILS_ID { get; set; }
      public int INVOICE_MASTER_ID{ get; set; }
      public string SERVICE_CODE { get; set; }
      public string SERVICE_NAME{ get; set; }
      public decimal QUANTITY{ get; set; }
      public string UNIT { get; set; }
      public decimal PRICE{ get; set; }
      public decimal AMOUNT{ get; set; }
    }
}
