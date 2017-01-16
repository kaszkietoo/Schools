using Schools.Data.DTO;
using Schools.Data.Repositories;
using Schools.Web.Models;
using Schools.Web.Utils;
using System.Web.Mvc;

namespace Schools.Web.Controllers
{
    [TokenAuthorize(Data.AccountType.Admin)]
    public class SchoolController : Controller
    {        
        [HttpPost]
        public JsonResult Add(SchoolModel school)
        {
            using (var schoolRepository = new SchoolRepository())
            {
                schoolRepository.Add(new SchoolDTO
                {
                    City = school.City,
                    Director = school.Director,
                    Email = school.Email,
                    Name = school.Name,
                    NIP = school.NIP,
                    Number = school.Number,
                    PostalCode = school.PostalCode,
                    Street = school.Street,
                    Telephone = school.Telephone
                });
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