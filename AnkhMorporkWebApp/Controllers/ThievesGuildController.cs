
using System.Web.Mvc;
using AnkhMorporkApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class ThievesGuildController : Controller
    {
        // GET: ThievesGuild
        public ActionResult Index(decimal fee, string practice)
        {
            Fool f = new Fool(practice, fee);

            return View(f);
        }

        public ActionResult Yes()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}