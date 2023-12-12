using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
     public class ACC_SalesAccountInfoClass
    {
        public string SALES_ORDER_NO { get; set; }
        public string STATUS_OF_SHIPMENT { get; set; }
        //

        public ACC_COMPANY_VOUCHER_MODEL acc_salesInfo { get; set; } = new ACC_COMPANY_VOUCHER_MODEL();        
    }
}
