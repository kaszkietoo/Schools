using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Schools.Web.Utils
{
    public class UserPrincipal : IPrincipal
    {
        public IIdentity _identity;
        public UserPrincipal(IIdentity identity)
        {
            _identity = identity;
        }

        public IIdentity Identity
        {
            get
            {
                return _identity;
            }
        }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}