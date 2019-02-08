using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http.Filters;

namespace userAPI.Controllers
{
    internal class UserAuthorizeAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            try
            {
                if (actionContext.Request.Headers.Authorization == null)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
                else
                {
                    // Gets header parameters 
                    //string originalString = actionContext.Request.Headers.Authorization.Parameter;
                    string authenticationString = actionContext.Request.Headers.Authorization.Parameter;
                    string originalString = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationString));

                    // Gets username and password  
                    string username = originalString.Split(':')[0];
                    string password = originalString.Split(':')[1];
                    //int userId = int.Parse(id);
                   // AuthsController auth = new AuthsController();
                    // Validate username and password  
                    if (!validAdmin(username, password))
                    {
                        // returns unauthorized error  
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                    }
                }

                base.OnAuthorization(actionContext);
            }
            // Handling Authorize: Basic <base64(username:password)> format.
            catch (Exception e)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
        }

        private bool validAdmin(string id, string pass)
        {
            using (var db = new mvcDBEntities())
            {
                var query = db.users.Where(x => x.username == id)
                                .Where(x => x.password == pass);

                if (query != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}