using Schools.Data.DTO;
using Schools.Data.Repositories;
using Schools.Web.Models;
using Schools.Web.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schools.Web.Controllers
{
    [TokenAuthorize]
    public class ClassController : Controller
    {
        [HttpPost]
        public JsonResult Add(ClassModel classModel)
        {
            using (var classRepository = new ClassRepository())
            {
                classRepository.Add(new ClassDTO { Name = classModel.Name, Username = HttpContext.User.Identity.Name });
            }

            return Json("ok");
        }

        public JsonResult GetAllForUser()
        {
            using (var classRepository = new ClassRepository())
            {
                return Json(classRepository.GetAllForUser(HttpContext.User.Identity.Name), JsonRequestBehavior.AllowGet);
            }
        }
    }
}