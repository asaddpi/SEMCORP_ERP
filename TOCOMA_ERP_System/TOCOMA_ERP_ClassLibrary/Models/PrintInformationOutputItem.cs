using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PrintInformationOutputItem
    {
        private DataSet _dataSet;
        private string[] _ContractIdList;
        public DataSet dataSet
        {
            get { return _dataSet; }
            set { _dataSet = value; }
        }

        public string[] ContractIdList
        {
            get { return _ContractIdList; }
            set { _ContractIdList = value; }
        }
        public String ITEM_NAME { set; get; }
        public Int64 ITEM_MONEY { set; get; }
        public String ITEM_NO { set; get; }
        public Int16 TOTAL { set; get; }
    }
}
