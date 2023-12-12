using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PlanandOperationViewModel
    {
        public int ID { get; set; }
        public int SL { get; set; }
        public string ENTRYDATE { get; set; }
        public string TASK_DESCRIPTION { get; set; }
        public int DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string TASK_ASSIGN_TO { get; set; }
        

        public string TASK_ASSIGN_BY { get; set; }
        public string  PLANNED_START_DATE { get; set; }
        public string ACTUAL_START_DATE { get; set; }
        public string PLANNED_COMPLETION_DATE { get; set; }
        public string ACTUAL_COMPLETION_DATE { get; set; }
        public string PLANNED_DURATION { get; set; }
        public string ACTUAL_DURATION { get; set; }
        public string ACTIVITIES { get; set; }
        public string STATUS { get; set; }
        public int STATUS_ID { get; set; }
             
        public string COMMENTS { get; set; }
        public int OPEN_FOR { get; set; }
        public int REG_BY { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public List<PlanandOperationViewModel> planAnd = new List<PlanandOperationViewModel>();
    }
}
