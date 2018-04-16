using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustSilcoTime.Models;

namespace CustSilcoTime.Controllers
{
    public class ValuesController : ApiController
    {
        private Cust_Silco_PYEntities db = new Cust_Silco_PYEntities();

        [Route("api/Values/GetTimeSheetManagerPayweek/{manager}/{payweek}")]
        public HttpResponseMessage GetTimeSheetForManagerPayweek(string manager, int payweek)
        {

            var timesheet =
                       Helper.GetTimeSheetForManagerPayweek<SelectTimeSheetForManagerPayweek_Result>(manager, payweek).ToList();


            return Request.CreateResponse(HttpStatusCode.OK, timesheet);
        }
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
