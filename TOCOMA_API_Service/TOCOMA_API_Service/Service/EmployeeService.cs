using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace TOCOMA_API_Service.Service
{
    public class EmployeeService
    {
        protected readonly ApplicationDbContex _dbContext;
        public EmployeeService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        public List<EmployeeModel>GetEmployeelist()
        {
            List<EmployeeModel> empList = new List<EmployeeModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var employeeList = connection.Query<EmployeeModel>("SP_EMPLOYEE_GET_ALL_EMPLOYEE");
                    if (employeeList != null && employeeList.Count() > 0)
                    {
                        empList = employeeList.ToList();
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return empList;
            
        }
        public List<EmployeeModel> GetSOCEmployeelist()
        {
            List<EmployeeModel> empList = new List<EmployeeModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var employeeList = connection.Query<EmployeeModel>("SELECT * FROM TBL_EMPLOYEE Where DEPARTMENT_ID=5");
                    if (employeeList != null && employeeList.Count() > 0)
                    {
                        empList = employeeList.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return empList;

        }
        public EmployeeModel GetEmployeeByCode(string code)
        {
            EmployeeModel employee = new EmployeeModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var employeeList = connection.Query<EmployeeModel>("Select * from TBL_EMPLOYEE Where EMPLOYEE_ID='"+code+"' ");
                    if (employeeList != null && employeeList.Count() > 0)
                    {
                        employee = employeeList.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return employee;

        }
    }
    
}

