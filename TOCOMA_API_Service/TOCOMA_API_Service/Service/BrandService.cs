using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;

namespace TOCOMA_API_Service.Service
{
    public class BrandService
    {
        protected readonly ApplicationDbContex _dbContext;
        public BrandService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }
        BrandModel brand = new BrandModel();
        internal BrandModel AddBrand(BrandModel brandModel)
        {
            brand = new BrandModel();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var _obrand = connection.Query<BrandModel>("SP_BRAND_INSERT_BRAND",
                        this.SetParameters(brandModel), commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception EX)
            {

            }
            return brand;
        }
        public DynamicParameters SetParameters(BrandModel brandModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BRAND_ID", brandModel.BRAND_ID);
            parameters.Add("@BRAND_NAME", brandModel.BRAND_NAME);
            parameters.Add("@REMARKS", brandModel.REMARKS);

            return parameters;
        }
        internal List<BrandModel> GetBrandList()
        {
            List<BrandModel> brandList = new List<BrandModel>();
            try
            {
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    var brand = connection.Query<BrandModel>("SELECT * FROM TBL_BRAND");
                    if (brand.Count() > 0)
                    {
                        brandList = brand.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return brandList;
        }
    }
}
