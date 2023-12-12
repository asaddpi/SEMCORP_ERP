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
    public class OurClientService
    {
        protected readonly ApplicationDbContex _dbContext;
        string strSQL;
        public OurClientService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        internal clsClientProjectSectorType AddItem(clsClientProjectSectorType item)
        {
            clsClientProjectSectorType referenceprojecttype = new clsClientProjectSectorType();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<clsClientProjectSectorType>("WEB_SP_OUR_CLIENT_INSERT_UPDATE_OURCLIENT_PROJECT_SECTOR_TYPE",
                            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }
            return referenceprojecttype;
        }
        public DynamicParameters SetParameters(clsClientProjectSectorType item)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@CLIENT_WORKING_SECTOR_ID", item.CLIENT_WORKING_SECTOR_ID);
            parameters.Add("@CLIENT_WORKING_SECTOR_NAME", item.CLIENT_WORKING_SECTOR_NAME);            
            parameters.Add("@OPERATION_TYPE", item.OPERATION_TYPE);
            return parameters;
        }
        internal List<clsClientProjectSectorType> GetClientProjectSectorTypeList()
        {
            List<clsClientProjectSectorType> projectTypeList = new List<clsClientProjectSectorType>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var customer = connection.Query<clsClientProjectSectorType>("SELECT * FROM TBL_WEB_CLIENT_PROJECT_SECTOR_TYPE");
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
        internal clsClientDetails AddClientDetails(clsClientDetails item)
        {
            clsClientDetails referenceprojecttype = new clsClientDetails();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<clsClientDetails>("WEB_SP_OUR_CLIENT_INSERT_UPDATE_OUR_CLIENT_INFO",
                            this.SetClientParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }
            return referenceprojecttype;
        }
        public DynamicParameters SetClientParameters(clsClientDetails item)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@OUR_CLIENT_ID", item.OUR_CLIENT_ID);
            parameters.Add("@BANNER_IMAGE_LINK", item.BANNER_IMAGE_LINK);
            parameters.Add("@BANNER_TITLE", item.BANNER_TITLE);
            parameters.Add("@CLIENT_WORKING_SECTOR_ID", item.CLIENT_WORKING_SECTOR_ID);
            parameters.Add("@CLIENT_NAME", item.CLIENT_NAME);
            parameters.Add("@CLIENT_LOGO", item.CLIENT_LOGO);
            parameters.Add("@DESCRIPTION", item.DESCRIPTION);
            parameters.Add("@OPERATION_TYPE", item.OPERATION_TYPE);
            return parameters;
        }
    }
}
