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
    public class AuthenticationService
    {
        protected readonly ApplicationDbContex _dbContext;
        public AuthenticationService(ApplicationDbContex _db)
        {
            _dbContext = _db;
        }


        public UserModel GetUserInfo(UserModel userModel)
        {
            UserModel response = new UserModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LOGIN_ID", userModel.LOGIN_ID, DbType.String);
                parameters.Add("@PASSWORD", userModel.PASSWORD, DbType.String);
                using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    connection.Open();
                    var userData = connection.Query<UserModel>("SP_USER_GET_USER_INFO", parameters, commandType: CommandType.StoredProcedure);

                    if (userData != null && userData.Count() > 0)
                    {
                        if (userData.FirstOrDefault().LOGIN_ID == userModel.LOGIN_ID && userData.FirstOrDefault().PASSWORD == userModel.PASSWORD)
                        {
                            //response.Status = true;

                            userData.FirstOrDefault().Status = true;
                            response = userData.FirstOrDefault();
                            //response.MESSAGE = Convert.ToString(userData.FirstOrDefault().UserId + "|" + userData.FirstOrDefault().UserName);
                        }
                        else
                        {
                            userData.FirstOrDefault().Status = false;
                            response.MESSAGE = "Incorrect UserName Or Password";
                        }
                    }
                    else
                    {
                        //userData.FirstOrDefault().Status = false;
                        response.Status = false;
                        response.MESSAGE = "Email not registered. Please Check your User/Email Id";
                    }
                    return response;
                }

            }
            catch (Exception Ex)
            {
                userModel.Status = false;
                response.MESSAGE = "An Error has occurred. Please try again !";
            }
            return response;
        }
        internal bool GetExistingUserByEmailId(string emailId)
        {
            string strSQL;
            int employeeId;
            bool flag = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand();
                    SqlTransaction myTrans;
                    myTrans = connection.BeginTransaction();
                    cmdInsert.Connection = connection;
                    cmdInsert.Transaction = myTrans;
                    SqlDataReader dr;

                    strSQL = "SELECT ";
                    strSQL = strSQL + " * ";
                    strSQL = strSQL + "FROM TBL_USER ";
                    strSQL = strSQL + "WHERE LOGIN_ID='" + emailId + "' ";

                    cmdInsert.CommandText = strSQL;
                    dr = cmdInsert.ExecuteReader();
                    if (dr.Read())
                    {
                        flag = true;
                    }
                    dr.Close();
                    cmdInsert.Transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                flag = flag;
            }
            return flag;
        }
        internal bool CreateUser(UserModel user)
        {
            string strSQL;
            int employeeId;
            string customerCode;
            bool flag = true;
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.ConnectionString))
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand();
                    SqlTransaction myTrans;
                    myTrans = connection.BeginTransaction();
                    cmdInsert.Connection = connection;
                    cmdInsert.Transaction = myTrans;
                    SqlDataReader dr;

                    string cuscode = "";
                    int empId = 0;
                    int userRole = 2;

                    //Random rnd = new Random();
                    //string num = user.CUSTOMER_NAME.ToString().Substring(0,1) + rnd.Next(9999);


                    bool userexist = false;

                    strSQL = "Select * from [dbo].[TBL_EMPLOYEE] Where EMPLOYEE_NAME='" + user.FULL_NAME + "' And EMAIL='" + user.EMAIL + "'";
                    //strSQL = strSQL + "CUSTOMER_ID,CUSTOMER_CODE ";
                    //strSQL = strSQL + "FROM TBL_CUSTOMER ";
                    //strSQL = strSQL + "WHERE CUSTOMER_NAME='" + user.CUSTOMER_NAME + "' ";

                    cmdInsert.CommandText = strSQL;
                    dr = cmdInsert.ExecuteReader();
                    if (dr.Read())
                    {
                        userexist = true;
                    }
                    dr.Close();
                    if (userexist != true)
                    {
                        strSQL = "INSERT INTO TBL_EMPLOYEE(EMPLOYEE_NAME,EMAIL,MOBILE) ";
                        strSQL = strSQL + "VALUES(";
                        strSQL = strSQL + "'" + user.FULL_NAME + "','" + user.EMAIL + "','" + user.MOBILE + "' ";
                        strSQL = strSQL + ")";
                        cmdInsert.CommandText = strSQL;
                        cmdInsert.ExecuteNonQuery();

                        strSQL = "SELECT ";
                        strSQL = strSQL + "EMPLOYEE_ID ";
                        strSQL = strSQL + "FROM TBL_EMPLOYEE ";
                        strSQL = strSQL + "WHERE EMAIL='" + user.EMAIL + "' ";

                        cmdInsert.CommandText = strSQL;
                        dr = cmdInsert.ExecuteReader();
                        if (dr.Read())
                        {
                            empId = Convert.ToInt32(dr["EMPLOYEE_ID"]);
                        }
                        dr.Close();
                    }









                    //strSQL = "INSERT INTO TBL_CUSTOMER(CUSTOMER_CODE,CUSTOMER_NAME) ";
                    //strSQL = strSQL + "VALUES(";
                    //strSQL = strSQL + "'" + user.CUSTOMER_CODE + "','" + user.CUSTOMER_NAME + "' ";
                    //strSQL = strSQL + ")";
                    //cmdInsert.CommandText = strSQL;
                    //cmdInsert.ExecuteNonQuery();

                    //strSQL = "SELECT ";
                    //strSQL = strSQL + "CUSTOMER_ID,CUSTOMER_CODE ";
                    //strSQL = strSQL + "FROM TBL_CUSTOMER ";
                    //strSQL = strSQL + "WHERE CUSTOMER_NAME='" + user.CUSTOMER_NAME + "' ";

                    //cmdInsert.CommandText = strSQL;
                    //dr = cmdInsert.ExecuteReader();
                    //if (dr.Read())
                    //{
                    //    customerCode = (dr["CUSTOMER_CODE"].ToString());
                    //    //vendorName = dr["EMPLOYEE_NAME"].ToString();
                    //    user.CUSTOMER_CODE = customerCode;
                    //}
                    //dr.Close();


                    strSQL = "INSERT INTO TBL_USER(FULL_NAME,EMAIL,MOBILE,LOGIN_ID,PASSWORD,EMPLOYEE_ID,USER_ROLE_ID,IsActive,USER_STATUS) ";
                    strSQL = strSQL + "VALUES(";
                    strSQL = strSQL + "'" + user.FULL_NAME + "','" + user.EMAIL + "','" + user.MOBILE + "','" + user.LOGIN_ID + "','" + user.PASSWORD + "','" + empId + "','" + userRole + "'," + 0 + ",'Pending'";
                    strSQL = strSQL + ")";
                    cmdInsert.CommandText = strSQL;
                    cmdInsert.ExecuteNonQuery();



                    cmdInsert.Transaction.Commit();

                }
            }
            catch (Exception ex)
            {
                flag = flag;
            }
            return flag;
        }
    }
}
