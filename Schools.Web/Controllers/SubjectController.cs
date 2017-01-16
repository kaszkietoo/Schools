using Schools.Data.Repositories;
using System.Web.Mvc;

namespace Schools.Web.Controllers
{
    public class SubjectController : Controller
    {
        public JsonResult GetAll()
        {
            using (var subjectRepository = new SubjectRepository())
            {
                return Json(subjectRepository.GetAll(), JsonRequestBehavior.AllowGet);
            }
        }
    }
}