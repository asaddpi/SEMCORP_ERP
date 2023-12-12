using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ToastSettings
    {
        public ToastSettings(string heading,string message,string baseClass,string additionalclass,string iconclass)
        {
            Heading = heading;
            Message = message;
            BaseClass = baseClass;
            AdditionalClasses = additionalclass;
            IconClass = iconclass;
        }
        public string Heading { get; set; }
        public string Message { get; set; }
        public string BaseClass { get; set; }
        public string AdditionalClasses { get; set; }
        public string IconClass { get; set; }
    }
}
