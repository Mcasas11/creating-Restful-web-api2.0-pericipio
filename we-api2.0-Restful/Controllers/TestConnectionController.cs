using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using we_api2._0_Restful.Models;

namespace we_api2._0_Restful.Controllers
{
    public class TestConnectionController : ApiController
    {
        public IEnumerable<string> Get()
        {
            var result = TestConnection();
            if (result)
            {
                return new string[] { "Database Connection successful." };
            }
            else
            {
                return new string[] { "Database Connection failed. " };
            }
        }

        public bool TestConnection()
        {
            using(var db = new WebApiEntities())
            {
                DbConnection conn = db.Database.Connection;
                try
                {
                    conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
