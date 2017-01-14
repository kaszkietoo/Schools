using Schools.Web.Utils;
using System.Web.Mvc;
using Schools.Data.Repositories;
using Schools.Data.DTO;
using Schools.Data.Utils;
using System.Text;
using System;

namespace Schools.Web.Controllers
{    
    public class AccountController : Controller
    {
        [TokenAuthorize]
        public JsonResult LogIn()
        {
            using (var userRepository = new UserRepository())
            {
                return Json(userRepository.GetAccountType(User.Identity.Name).ToString(), JsonRequestBehavior.AllowGet);
            }            
        }

        [TokenAuthorize]
        [HttpPost]
        public JsonResult AddTeacher(UserDTO user)
        {
            using (var userRepository = new UserRepository())
            {
                user.AccountType = Data.AccountType.Teacher;
                var emailConfirmationPair = SecurityManager.GenerateEmailConfirmationCode(user.Email);
                user.EmailConfirmationCode = emailConfirmationPair.Code;
                userRepository.Add(user);
                EmailService.SendEmailConfirmationCode(emailConfirmationPair.ValueToSend, user.Email, Request.UrlReferrer.AbsoluteUri);
            }

            return Json("ok");
        }
                
        [HttpPost]
        public JsonResult Confirm(string code, string hashedPassword, string username)
        {
            using (var userRepository = new UserRepository())
            {
                bool confirmed = userRepository.ConfirmEmail(code, hashedPassword, username);
            }

            return Json("ok");
        }        
    }
}
