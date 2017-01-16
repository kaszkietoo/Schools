using Schools.Data.DTO;
using Schools.Data.Repositories;
using Schools.Web.Models;
using System.Web.Mvc;

namespace Schools.Web.Controllers
{
    public class ScoreController : Controller
    {
        [HttpPost]
        public JsonResult Add(ScoreModel score)
        {
            using (var scoreRepository = new ScoreRepository())
            {
                scoreRepository.Add(new ScoreDTO { FinalScore = score.FinalScore, StudentId = score.StudentId, SubjectId = score.SubjectId });
            }

            return Json("ok");
        }
    }    
}