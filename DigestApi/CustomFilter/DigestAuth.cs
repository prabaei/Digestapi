using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace DigestApi.CustomFilter
{
    public class DigestAuth : System.Web.Http.Filters.ActionFilterAttribute, IAuthenticationFilter
    {
        public  Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
           var a= context.Request.Headers.Authorization;
            if (a == null)
            {
                //context.re
            }
            return Task.FromResult(0);
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            //context.Result = new HttpUnauthorizedResult();
            return Task.FromResult(0);
        }
    }
}