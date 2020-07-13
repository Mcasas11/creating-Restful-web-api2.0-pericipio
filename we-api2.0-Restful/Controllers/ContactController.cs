using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using we_api2._0_Restful.Models;

namespace we_api2._0_Restful.Controllers
{
    public class ContactController : ApiController
    {
        public Contact[] Get()
        {
            return new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Marcos Casas"
                },
                new Contact
                {
                    Id = 2,
                    Name= "Tommy Langaker"
                }
            };
        }
    }
}
