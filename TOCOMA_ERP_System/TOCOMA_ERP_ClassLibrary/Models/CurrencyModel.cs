using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class CurrencyModel
    {      
        public int CURRENCY_SERIAL { get; set; }

        [Required(ErrorMessage ="Please Input Currency Symbol")]
       public string CURRENCY_SYMBOL { get; set; }
        [Required(ErrorMessage = "Please Input Currency Name")]
        public string CURRENCY_NAME { get; set; }
        public string CURRENCY_STRING { get; set; }
        public string ENTRYBY { get; set; }
        public string UPDATEBY { get; set; }
        public int CURRENCY_DECIMAL { get; set; }
        public string CURRENCY_CODE { get; set; }

    }
}
