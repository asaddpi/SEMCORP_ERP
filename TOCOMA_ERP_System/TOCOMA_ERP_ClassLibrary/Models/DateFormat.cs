using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public static class DateFormat
    {
        //static void Main(string[] args)
        //{
        //    var mydate = "29021996";
        //    var date = mydate.ToDateTime(format: "ddMMyyyy"); // {29.02.1996 00:00:00}

        //    mydate = "2016 3";
        //    date = mydate.ToDateTime("yyyy M"); // {01.03.2016 00:00:00}

        //    mydate = "2016 12";
        //    date = mydate.ToDateTime("yyyy d"); // {12.01.2016 00:00:00}

        //    mydate = "2016/31/05 13:33";
        //    date = mydate.ToDateTime("yyyy/d/M HH:mm"); // {31.05.2016 13:33:00}

        //    mydate = "2016/31 Ocak";
        //    date = mydate.ToDateTime("yyyy/d MMMM"); // {31.01.2016 00:00:00}

        //    mydate = "2016/31 January";
        //    date = mydate.ToDateTime("yyyy/d MMMM", cultureString: "en-US");
        //    // {31.01.2016 00:00:00}

        //    mydate = "11/شعبان/1437";
        //    date = mydate.ToDateTime(
        //        culture: CultureInfo.GetCultureInfo("ar-SA"),
        //        format: "dd/MMMM/yyyy");
        //    // Weird :) I supposed dd/yyyy/MMMM but that did not work !?$^&*

        //    System.Diagnostics.Debug.Assert(
        //       date.Equals(new DateTime(year: 2016, month: 5, day: 18)));
        //}
        public static DateTime ToDateTime(this string s,string format, CultureInfo culture)
        {
            try
            {
                var r = DateTime.ParseExact(s: s, format: format,
                                        provider: culture);
                return r;
            }
            catch (FormatException)
            {
                throw;
            }
            catch (CultureNotFoundException)
            {
                throw; // Given Culture is not supported culture
            }

        }

    }
    
}
