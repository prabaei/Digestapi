using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using DigestApi.CustomFilter;

namespace DigestApi.Controllers
{
    public class TestController : ApiController
    {
        [DigestAuth]
        public HttpResponseMessage get()
        {
            //return JObject.Parse("{Name:\"prabaharan\",age:3}");
            var message = Request.CreateResponse(HttpStatusCode.Accepted);
            return message;
        }
    }
}
