using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDotNet.Authentication;

namespace WebApiDotNet.Controllers
{
    [IdentityBasicAuthentication]
    public class Todo2Controller : ApiController
    {
        LocalDataContext localDataContext = new LocalDataContext();

        // GET api/values/5
        public string Get()
        {
            return "In TodoController";
        }

        // POST api/values
        public void Post([FromBody]TodoItem todoItem)
        {
            localDataContext.TodoItems.InsertOnSubmit(todoItem);
            localDataContext.SubmitChanges();
        }
    }
}
