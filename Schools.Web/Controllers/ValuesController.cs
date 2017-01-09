using Schools.Web.Utils;
using System.Web.Mvc;
using System.Linq;

namespace Schools.Web.Controllers
{
    [TokenAuthorize]
    public class ValuesController : Controller
    {
        private string[] _people = new string[] { "John Doe", "Amy Rose", "Harry Sam" };

        public JsonResult Find(string q)
        {
            var data = _people.Where(p => p.ToLower().Contains(q));

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
