using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFirst.Controllers
{
    public class EmpController : ApiController
    {
        [Route("Abhi/GetList")]
        public List<string> GetListName()
        {
            List<string> objlist = new List<string>()
            {
                "Rahul",
                "Kumar",
                "Rohit",
                "Mohan",
                "Sohan"
            };
            return objlist;
        }
        [Route("Rahul/GetList")]
        public List<string> GetListName2()
        {
            List<string> objlist = new List<string>()
            {
                "Rahul1",
                "Kumar1",
                "Rohit1",
                "Mohan1",
                "Sohan1"
            };
            return objlist;
        }
    }
}