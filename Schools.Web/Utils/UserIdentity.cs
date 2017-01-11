using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Schools.Web.Utils
{
    public class UserIdentity : IIdentity
    {
        public string _name;
        public UserIdentity(string name)
        {
            _name = name;
        }
        public string AuthenticationType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}