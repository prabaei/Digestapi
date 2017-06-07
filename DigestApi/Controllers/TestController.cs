using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace DigestApi.Controllers
{
    public class TestController : ApiController
    {
        [Authorize]
        public JToken get()
        {
            return JObject.Parse("{Name:\"prabaharan\",age:3}");
        }
    }
}
