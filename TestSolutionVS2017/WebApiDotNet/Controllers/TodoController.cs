using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiDotNet.Models;

namespace WebApiDotNet.Controllers
{
    public class TodoController
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