using Schools.Web.Utils;
using System.Web.Mvc;

namespace Schools.Web.Controllers
{
    public class IPController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return CommonManager.GetIP(Request);
        }
    }
}
