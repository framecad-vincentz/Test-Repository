using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDotNet.Controllers.QSS
{
    public class ContactController : ApiController
    {
        // GET api/values/5
        public string Get()
        {
            return "ContactController-Get";
        }
    }
}
