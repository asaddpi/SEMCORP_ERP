using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models.WebsiteModel
{
    public class clsTocomaHistory
    {
      public int TOCOMA_HISTORY_ID { get; set; }
      public string YEAR{ get; set; }
      public string MONTH{ get; set; }
      public string TITLE{ get; set; }
      public string DESCRIPTION{ get; set; }
      public string IMAGE_LINK{ get; set; }
      public string ENABLE{ get; set; }
      public string OPERATION_TYPE { get; set; }
    }
}
