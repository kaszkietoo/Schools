﻿using Schools.Data.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schools.Web.Utils
{
    public class TokenAuthorizeAttribute : AuthorizeAttribute
    {
        private const string _securityToken = "token";
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (Authorize(filterContext))
            {
                return;
            }
            HandleUnauthorizedRequest(filterContext);
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
        }
        private bool Authorize(AuthorizationContext actionContext)
        {
            try
            {                
                HttpRequestBase request = actionContext.RequestContext.HttpContext.Request;
                string token = request.Params[_securityToken];
                return SecurityManager.IsTokenValid(token, CommonManager.GetIP(request), request.UserAgent);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}