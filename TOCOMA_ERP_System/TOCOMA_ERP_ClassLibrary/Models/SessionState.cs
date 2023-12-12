using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class SessionState
    {
        public int Employee_Id { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public int Department_Id { get; set; }
        public string LoginId { get; set; }
    }
}
