using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;
using Dapper;

namespace TOCOMA_API_Service.Service
{
    public class DepartmentService
    {
        protected readonly ApplicationDbContex _dbContext;
        public DepartmentService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        internal List<DepartmentEntity> GetDepartmentList()
        {
            List<DepartmentEntity> departmentList = new List<DepartmentEntity>();
            try
            {   
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();                    
                    var oproductgroup = connection.Query<DepartmentEntity>("SELECT * FROM TBL_DEPARTMENT");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        departmentList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return departmentList;
        }
        internal List<ItemEntity> GetItemList()
        {
            List<ItemEntity> itemList = new List<ItemEntity>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<ItemEntity>("SP_ITEM_GETALL_ITEM");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        itemList = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return itemList;
        }
    }
}
