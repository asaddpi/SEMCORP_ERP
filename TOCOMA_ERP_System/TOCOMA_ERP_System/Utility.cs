using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace TOCOMA_ERP_System
{
    public class Utility
    {
        public static string Encrypt(string password)
        {
            var provider = MD5.Create();
            string salt = "S0m3R@nd0mSalt";
            byte[] bytes = provider.ComputeHash(Encoding.UTF32.GetBytes(salt + password));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
        public static string BaseUrl { get; set; }
        public static string ReportUrl { get; set; }

        public static DateTime GetDateFromStringToDate(string date)
        {

            DateTime dt = new DateTime();
            string d = date.Substring(0, 2);
            string m = date.Substring(3, 2);
            string y = date.Substring(6, 4);
             dt = Convert.ToDateTime(y + "-" + m + "-" + d);
           
            return dt;
        }
    }
}
