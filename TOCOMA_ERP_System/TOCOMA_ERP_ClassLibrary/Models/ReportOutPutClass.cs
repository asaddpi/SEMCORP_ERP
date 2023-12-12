using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ReportOutPutClass
    {
        public String ContractIdList { set; get; }
        public String ITEM_NAME { set; get; }
        public Int64 ITEM_MONEY { set; get; }
        public String ITEM_NO { set; get; }
        public Int16 TOTAL { set; get; }

        public DataSet dataSet { set; get; }

    }
}
