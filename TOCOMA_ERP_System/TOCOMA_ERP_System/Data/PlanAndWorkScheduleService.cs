using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using TOCOMA_ERP_ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using System.Data;


namespace TOCOMA_ERP_System.Data
{
    public class PlanAndWorkScheduleService
    {
        private readonly HttpClient Http;
        public PlanAndWorkScheduleService(HttpClient httpClient)
        {
            Http = httpClient;
        }
        List<PlanandOperationViewModel> listPlanOperation = new List<PlanandOperationViewModel>();
        public async Task<List<PlanandOperationViewModel>> GetPlanAndWork()
        {
            listPlanOperation = await Http.GetFromJsonAsync<List<PlanandOperationViewModel>>(Utility.BaseUrl + "api/Setup/GetWorkScheduleBySuperAdmin");
            return await Http.GetFromJsonAsync<List<PlanandOperationViewModel>>(Utility.BaseUrl + "api/Setup/GetWorkScheduleBySuperAdmin");            
        }

        
        public class ListtoDataTable
        {
            public System.Data.DataTable ToDataTable<T>(List<T> items)
            {
                System.Data.DataTable dataTable = new System.Data.DataTable(typeof(T).Name);
                //Get all the properties by using reflection
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {

                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }

                return dataTable;
            }
        }
    }
}
