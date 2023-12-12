using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models.WebsiteModel;

namespace TOCOMA_API_Service.Service.Website
{
    public class ReferenceProjectTypeService
    {
        protected readonly ApplicationDbContex _dbContext;
        string strSQL;
        public ReferenceProjectTypeService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        public bool GetIsItemExist(string typeName)
        {
            bool flag = false;
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                connection.Open();
                var oproductgroup = connection.Query<ReferenceProjectTypeModel>("SELECT * FROM TBL_WEB_REF_PROJECT_TYPE WHERE REF_PROJECT_TYPE_NAME='" + typeName + "'");
                if (oproductgroup != null && oproductgroup.Count() > 0)
                {
                    flag = true;
                }
            }
            return flag;
        }
        internal ReferenceProjectTypeModel AddItem(ReferenceProjectTypeModel item)
        {
            ReferenceProjectTypeModel referenceprojecttype = new ReferenceProjectTypeModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<ReferenceProjectTypeModel>("WEB_SP_PROJECT_TYPE_INSERT_UPDATE_INTO_PROJECT_TYPE",
                            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }


            return referenceprojecttype;
        }
        public DynamicParameters SetParameters(ReferenceProjectTypeModel item)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@REF_PROJECT_TYPE_ID", item.REF_PROJECT_TYPE_ID);
            parameters.Add("@REF_PROJECT_TYPE_NAME", item.REF_PROJECT_TYPE_NAME);
            parameters.Add("@REF_PROJECT_TYPE_IMAGE", item.REF_PROJECT_TYPE_IMAGE);
            parameters.Add("@OPERATION_TYPE", item.OPERATION_TYPE);
            return parameters;
        }
        //----
        internal clsReferenceProject AddReferenceProject(clsReferenceProject item)
        {
            clsReferenceProject referenceprojecttype = new clsReferenceProject();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<clsReferenceProject>("WEB_SP_RP_INSERT_REFERENCE_PROJECT",
                            this.SetRFParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }


            return referenceprojecttype;
        }
        public DynamicParameters SetRFParameters(clsReferenceProject item)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@REF_PROJECT_ID", item.REF_PROJECT_ID);
            parameters.Add("@REF_PROJECT_TYPE_ID", item.REF_PROJECT_TYPE_ID);
            parameters.Add("@PROJECT_NAME", item.PROJECT_NAME);
            parameters.Add("@PROJECT_ADDRESS", item.PROJECT_ADDRESS);
            parameters.Add("@PROJECT_IMAGE", item.PROJECT_IMAGE);
            parameters.Add("@PROJECT_VIDEO_LINK", item.PROJECT_VIDEO_LINK);
            parameters.Add("@CASE_STUDY_LINK", item.CASE_STUDY_LINK);
            parameters.Add("@PROJECT_OWNER", item.PROJECT_OWNER);
            parameters.Add("@PROJECT_ENGINEER", item.PROJECT_ENGINEER);
            parameters.Add("@PROJECT_CONTRACTOR", item.PROJECT_CONTRACTOR);
            parameters.Add("@PROJECT_SUB_CONTRACTOR", item.PROJECT_SUB_CONTRACTOR);
            parameters.Add("@PROJECT_CHEMICAL_APPLICATOR", item.PROJECT_CHEMICAL_APPLICATOR);
            parameters.Add("@PROJECT_REQUIREMENTS", item.PROJECT_REQUIREMENTS);
            parameters.Add("@TOCOMA_SOLUTIONS", item.TOCOMA_SOLUTIONS);
            parameters.Add("@USED_PRODUCT", item.USED_PRODUCT);
            parameters.Add("@REG_BY", item.REG_BY);
            parameters.Add("@UPD_BY", item.UPD_BY);
            return parameters;
        }
        internal List<ReferenceProjectTypeModel> GetProjectTypeist()
        {
            List<ReferenceProjectTypeModel> projectTypeList = new List<ReferenceProjectTypeModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customer = connection.Query<ReferenceProjectTypeModel>("SELECT * FROM TBL_WEB_REF_PROJECT_TYPE");
                    if (customer != null && customer.Count() > 0)
                    {
                        projectTypeList = customer.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return projectTypeList;
        }
        public void DeleteRefProjectType(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    connection.Query<ReferenceProjectTypeModel>("UPDATE TBL_WEB_REF_PROJECT_TYPE SET ENABLE=0 WHERE REF_PROJECT_TYPE_ID=" + id + "");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
