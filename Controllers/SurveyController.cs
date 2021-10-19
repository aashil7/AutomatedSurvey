using System.Linq;
using System.Web.Mvc;



namespace AutomatedSurvey.Web.Controllers
{
    public class SurveyController : Controller
    {

        public ActionResult Survey()
        {
            return View();
        }


        public ActionResult Surveyquestion()
        {
            return View();
        }


        public ActionResult Addsurvey()
        {
            return View();
        }



        public ActionResult Manage()
        {
            return View();
        }


       // public ActionResult 




        //private readonly IRepository<Survey> _surveysRepository;
        //private readonly IRepository<Answer> _answersRepository;

        //public SurveyController() : this(new SurveyRepository(), new AnswerRepository()) { }

        //public SurveyController(
        //    IRepository<Survey> surveysRepository, IRepository<Answer> answersRepository)
        //{
        //    _surveysRepository = surveysRepository;
        //    _answersRepository = answersRepository;
        //}





        //public ActionResult Results()
        //{
        //    var answers = _answersRepository.All();
        //    var uniqueAnswers = answers;


        //    ViewBag.UniqueAnswers = uniqueAnswers;
        //    ViewBag.SurveyTitle = _surveysRepository.FirstOrDefault().Title;
        //    return View(answers);
        //}
    }
}




