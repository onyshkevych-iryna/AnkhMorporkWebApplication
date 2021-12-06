
using System.Web.Mvc;
using AnkhMorporkApp.Guilds;
using AnkhMorporkApp.Models;
using AnkhMorporkApp.Services.GuildsServices;

namespace AnkhMorporkWebApp.Controllers
{
    public class ThievesGuildController : Controller
    {
        // GET: ThievesGuild
        public ActionResult Index()
        {
            --GuildOfThieves.NumberOfThieves;
            var thief = new Thief();

            return View(thief);
        }

        public ActionResult Yes()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}