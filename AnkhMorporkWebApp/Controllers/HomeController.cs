using System.Web.Mvc;

namespace AnkhMorporkWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Play()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}