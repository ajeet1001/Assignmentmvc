using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace userAPI.Controllers
{
    [UserAuthorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        //private mvcDBEntities db = new mvcDBEntities();
        //public IEnumerable<string> Get()
        //{

        //    return new string[] { "Hello", "value2" };
        //}
        //[HttpGet]
        //public IHttpActionResult Check(string username, string password)
        //{
        //    user dbb = db.users.Where(x => x.username == username)
        //                         .Where(x => x.password == password).FirstOrDefault();
        //    if (dbb != null)
        //    {
        //        return Ok("Welcome");
        //    }
        //    return NotFound();

        //}

        // GET api/values/5
        [HttpGet]
        
        public IHttpActionResult Check()
        {
            return Ok("Welcome");
        }
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
