using Schools.Web.Utils;
using System.Web.Mvc;
using Schools.Data.Repositories;
using Schools.Data.DTO;

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
        
        [HttpPost]
        public JsonResult AddTeacher(UserDTO user)
        {
            using (var userRepository = new UserRepository())
            {
                user.AccountType = Data.AccountType.Teacher;
                userRepository.Add(user);
            }

            return Json("ok");
        }        
    }
}
