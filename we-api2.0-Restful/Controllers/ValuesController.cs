using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using we_api2._0_Restful.Models;

namespace we_api2._0_Restful.Controllers
{
    public class ValuesController : ApiController
    {
        WebApiEntities db = new WebApiEntities();
        public IEnumerable<Customer> Get()
        {
            return db.Customer.ToList();
        }
    }
}
