using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ToastInstance
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public ToastSettings toastSettings { get; set; }
    }
}
