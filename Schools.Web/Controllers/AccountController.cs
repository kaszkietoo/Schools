using Schools.Web.Utils;
using System.Web.Http;
using System.Web.Mvc;

namespace Schools.Web.Controllers
{
    [TokenAuthorize]
    public class AccountController : Controller
    {
        public JsonResult LogIn()
        {
            return Json("ok", JsonRequestBehavior.AllowGet);
        }
    }
}
