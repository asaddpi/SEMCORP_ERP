using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class UserModel
    {
        public int USER_ID { get; set; }
        public string LOGIN_ID { get; set; }
        public string PASSWORD { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public string EMPLOYEE_NAME { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE { get; set; }
        public string EMPLOYEE_IMAGE { get; set; }
        public string DESIGNATION { get; set; }
        public int DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public DateTime? HireDate { get; set; }
        public int USER_ROLE_ID { get; set; }
        public string USER_ROLE { get; set; }
        public bool Status { get; set; }
        public bool IsAuthenticated { get; set; }
        public string MESSAGE { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string FULL_NAME { get; set; }
        

    }
}
