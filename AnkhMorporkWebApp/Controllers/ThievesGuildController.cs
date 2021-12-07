
using System.Web.Mvc;
using AnkhMorporkApp.Guilds;
using AnkhMorporkWebApp.Models;
using AnkhMorporkApp.Services.GuildsServices;

namespace AnkhMorporkWebApp.Controllers
{
    public class ThievesGuildController : Controller
    {
        public ThievesGuildController()
        {
        }
        // GET: ThievesGuild
        public ActionResult Index()
        {
            var model = TempData["NewCustomer"] as PlayerThiefModel;
            --GuildOfThieves.NumberOfThieves;
            return View(model);
        }

        public ActionResult Yes(decimal sum, decimal balance)
        {
            Player player = new Player(balance);
            player.GiveMoney(sum);
            Response.Write(@"<script language='javascript'>alert('Details saved successfully')</script>");
            return RedirectToAction("Index", "Home", player);
        }
    }
}