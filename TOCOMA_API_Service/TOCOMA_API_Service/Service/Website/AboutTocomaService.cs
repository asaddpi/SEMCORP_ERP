using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models.WebsiteModel;

namespace TOCOMA_API_Service.Service.Website
{
    public class AboutTocomaService
    {
        protected readonly ApplicationDbContex _dbContext;
        string strSQL;
        public AboutTocomaService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        internal clsAboutTocoma AddItem(clsAboutTocoma item)
        {
            clsAboutTocoma referenceprojecttype = new clsAboutTocoma();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<clsAboutTocoma>("WEB_SP_ABOUT_TOCOMA_INSERT_UPDATE_INTO_ABOUT_TOCOMA",
                            this.SetParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }


            return referenceprojecttype;
        }
        public List<clsTocomaVisionMission>GetAboutTocomaInfo()
        {
            List<clsTocomaVisionMission> getlist = new List<clsTocomaVisionMission>();
            try
            {                
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<clsTocomaVisionMission>("Select * From TBL_WEB_TOCOMA_MISSION_VISION");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        getlist = oproductgroup.ToList();
                    }
                }
            }
            catch (Exception EX)
            {

            }
            return getlist;
        }
        internal clsAboutTocoma GetTocomaInfo()
        {
            clsAboutTocoma purchasereq = new clsAboutTocoma();
            try
            {
                //var parameters = new DynamicParameters();
                //parameters.Add("@REQUISITION_NO", reqNo, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var oproductgroup = connection.Query<clsAboutTocoma>("Select * From TBL_WEB_ABOUT_TOCOMA");
                    if (oproductgroup != null && oproductgroup.Count() > 0)
                    {
                        purchasereq = oproductgroup.FirstOrDefault();
                    }
                }
            }
            catch (Exception EX)
            {

            }

            return purchasereq;
        }

        public DynamicParameters SetParameters(clsAboutTocoma item)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@ABOUT_TOCOMA_ID", item.ABOUT_TOCOMA_ID);
            parameters.Add("@BANNER_TITLE", item.BANNER_TITLE);
            parameters.Add("@BANNER_IMAGE_LINK", item.BANNER_IMAGE_LINK);
            parameters.Add("@DESCRIPTION", item.DESCRIPTION);
            parameters.Add("@OPERATION_TYPE", item.OPERATION_TYPE);
            return parameters;
        }
        internal clsTocomaVisionMission AddVisionMission(clsTocomaVisionMission item)
        {
            clsTocomaVisionMission referenceprojecttype = new clsTocomaVisionMission();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<clsTocomaVisionMission>("WEB_SP_ABOUT_TOCOMA_INSERT_UPDATE_TOCOMA_MISSION_VISION",
                            this.SetTocomaVisionMissionParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }


            return referenceprojecttype;
        }
        public DynamicParameters SetTocomaVisionMissionParameters(clsTocomaVisionMission item)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@TOCOMA_MISSION_VISSION_ID", item.TOCOMA_MISSION_VISSION_ID);
            parameters.Add("@NAME", item.NAME);            
            parameters.Add("@DESCRIPTION", item.DESCRIPTION);
            parameters.Add("@IMAGE_LINK", item.IMAGE_LINK);
            parameters.Add("@OPERATION_TYPE", item.OPERATION_TYPE);
            return parameters;
        }
        internal clsTocomaHistory AddTocomaHistory(clsTocomaHistory item)
        {
            clsTocomaHistory referenceprojecttype = new clsTocomaHistory();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _oproductcategory = connection.Query<clsTocomaHistory>("WEB_SP_ABOUT_TOCOMA_INSERT_UPDATE_TOCOMA_HISTORY",
                            this.SetTocomahistoryParameters(item), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception Ex)
            {

            }


            return referenceprojecttype;
        }
        public DynamicParameters SetTocomahistoryParameters(clsTocomaHistory item)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@TOCOMA_HISTORY_ID", item.TOCOMA_HISTORY_ID);
            parameters.Add("@YEAR", item.YEAR);
            parameters.Add("@TITLE", item.TITLE);
            parameters.Add("@DESCRIPTION", item.DESCRIPTION);
            parameters.Add("@IMAGE_LINK", item.IMAGE_LINK);
            parameters.Add("@OPERATION_TYPE", item.OPERATION_TYPE);
            return parameters;
        }
        

    }
}
