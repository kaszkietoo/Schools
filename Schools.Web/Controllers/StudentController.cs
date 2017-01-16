using Schools.Data.DTO;
using Schools.Data.Repositories;
using Schools.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schools.Web.Controllers
{
    public class StudentController : Controller
    {
        [HttpPost]
        public JsonResult Add(StudentModel student)
        {
            using (var studentRepository = new StudentRepository())
            {
                studentRepository.Add(new StudentDTO { Name = student.Name, Surname = student.Surname, Number = student.Number, ClassId = student.ClassId });
            }

            return Json("ok");
        }
    }
}