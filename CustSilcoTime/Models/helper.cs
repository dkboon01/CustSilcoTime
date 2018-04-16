using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

using System.Net;
using System.IO;
using System.Configuration;
using System.Data;
using System.Collections;


using System.Data.Entity;

using System.Data.SqlClient;

using System.Globalization;


namespace CustSilcoTime.Models
{
    public class Helper
    {
        public static List<SelectTimeSheetForManagerPayweek_Result> GetTimeSheetForManagerPayweek<T>( string manager, int payweek)

        where T : class
        {
            var db = new Cust_Silco_PYEntities();
            List<SelectTimeSheetForManagerPayweek_Result> EmployeeEntry = db.SelectTimeSheetForManagerPayweek(manager, payweek).ToList();
            return EmployeeEntry;

        }
    }
}