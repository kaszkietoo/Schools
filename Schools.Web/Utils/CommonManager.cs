using System.Web;

namespace Schools.Web.Utils
{
    public static class CommonManager
    {
        public static string GetIP(HttpRequestBase request)
        {
            string ip = request.Headers["X-Forwarded-For"]; // AWS compatibility
            if (string.IsNullOrEmpty(ip))
            {
                ip = request.UserHostAddress;
            }
            return ip;
        }
    }
}