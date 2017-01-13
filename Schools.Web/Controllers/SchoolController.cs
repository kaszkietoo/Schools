using Schools.Data.DTO;
using Schools.Data.Repositories;
using Schools.Web.Utils;
using System.Web.Mvc;

namespace Schools.Web.Controllers
{
    [TokenAuthorize(Data.AccountType.Admin)]
    public class SchoolController : Controller
    {        
        [HttpPost]
        public JsonResult Add(SchoolDTO school)
        {
            using (var schoolRepository = new SchoolRepository())
            {
                schoolRepository.Add(school);
            }

            return Json("ok");
        }

        public JsonResult GetAll()
        {
            using (var schoolRepository = new SchoolRepository())
            {
                return Json(schoolRepository.GetAll(), JsonRequestBehavior.AllowGet);
            }                                        
        }
    }
}