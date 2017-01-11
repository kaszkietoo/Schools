using Schools.Web.Utils;
using System.Web.Mvc;
using Schools.Data.Repositories;

namespace Schools.Web.Controllers
{
    [TokenAuthorize]
    public class AccountController : Controller
    {
        public JsonResult LogIn()
        {
            using (var userRepository = new UserRepository())
            {
                return Json(userRepository.GetAccountType(User.Identity.Name).ToString(), JsonRequestBehavior.AllowGet);
            }            
        }        
    }
}
